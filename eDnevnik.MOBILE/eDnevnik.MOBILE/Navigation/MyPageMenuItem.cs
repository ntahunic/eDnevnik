using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.MOBILE.Navigation
{

    public class MyPageMenuItem
    {
        public MyPageMenuItem()
        {
            TargetType = typeof(MainPage);
            Title = "Obavijesti";
        }
        public string ImageSource { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}