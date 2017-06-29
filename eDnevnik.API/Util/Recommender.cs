using eDnevnik.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.API.Util
{
    public class Recommender
    {
        private eDnevnikEntities db = new eDnevnikEntities();
        private Dictionary<int, List<OcjenaMaterijal>> materials = new Dictionary<int, List<OcjenaMaterijal>>();
        public List<MaterijalVM> GetSimilarMaterials(int currentMaterialId)
        {

            GetAllProducts(currentMaterialId);

            List<OcjenaMaterijal> currentProductRatings = db.OcjenaMaterijal.Where(x => x.MaterijalId == currentMaterialId).OrderBy(x => x.UcenikId).ToList();

            List<OcjenaMaterijal> commonRatings1 = new List<OcjenaMaterijal>();
            List<OcjenaMaterijal> commonRatings2 = new List<OcjenaMaterijal>();

            List<MaterijalVM> similarProducts = new List<MaterijalVM>();

            foreach (var item in materials)
            {
                foreach (OcjenaMaterijal r in currentProductRatings)
                {
                    if (item.Value.Where(x => x.UcenikId == r.UcenikId).Count() > 0)
                    {
                        commonRatings1.Add(r);
                        commonRatings2.Add(item.Value.Where(x => x.UcenikId == r.UcenikId).First());
                    }
                }

                double sim = CalculateSimilarity(commonRatings1, commonRatings2);

                if (sim > 0.6)
                {
                    similarProducts.Add(db.Materijal.Where(x=>x.MaterijalId==item.Key).Select(x=> new MaterijalVM {
                        MaterijalId = x.MaterijalId,
                        Naziv = x.Naziv,
                        Predmet = x.Predmet.Naziv,
                        PredmetId = x.PredmetId
                    }).First());
                }

                commonRatings1.Clear();
                commonRatings2.Clear();
            }


            return similarProducts;
        }

        private void GetAllProducts(int materialId)
        {
            List<MaterijalVM> activeMaterials = db.Materijal.Where(x => x.MaterijalId != materialId).Select(x => new MaterijalVM
            {
                MaterijalId = x.MaterijalId,
                Naziv = x.Naziv,
                Predmet = x.Predmet.Naziv,
                PredmetId = x.PredmetId
            }).ToList();

            List<OcjenaMaterijal> ratings;
            foreach (var item in activeMaterials)
            {
                ratings = db.OcjenaMaterijal.Where(x => x.MaterijalId == item.MaterijalId).OrderBy(x => x.UcenikId).ToList();

                if (ratings.Count > 0)
                {
                    materials.Add(item.MaterijalId, ratings);
                }
            }
        }

        private double CalculateSimilarity(List<OcjenaMaterijal> rating1, List<OcjenaMaterijal> rating2)
        {
            if (rating1.Count != rating2.Count)
                return 0;

            double numerator = 0, int1 = 0, int2 = 0;

            for (int i = 0; i < rating1.Count; i++)
            {
                numerator += rating1[i].OcjenaVrijednost * rating2[i].OcjenaVrijednost;
                int1 += Math.Pow(rating1[i].OcjenaVrijednost, 2);
                int2 += Math.Pow(rating2[i].OcjenaVrijednost, 2);

            }

            int1 = Math.Sqrt(int1);
            int2 = Math.Sqrt(int2);

            if (int1 * int2 != 0)
                return numerator / (int1 * int2);

            return 0;
        }
    }
}
