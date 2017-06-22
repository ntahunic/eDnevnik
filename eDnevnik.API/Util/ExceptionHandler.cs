using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace eDnevnik.API.Util
{
    public class ExceptionHandler
    {
        public static string HandleException(EntityException e)
        {
            SqlException error = e.InnerException as SqlException;

            switch (error.Number)
            {
                case 2627:
                    return GetConstraintExceptionMessage(error);
                default:
                    return error.Message + " (" + error.Number + ")";
            }

        }

        private static string GetConstraintExceptionMessage(SqlException error)
        {
            string newMessage = error.Message;
            int startIndex = newMessage.IndexOf("'");
            int endIndex = newMessage.IndexOf("'", startIndex + 1);

            if (startIndex > 0 && endIndex > 0)
            {
                string constraintName = newMessage.Substring(startIndex + 1, endIndex - startIndex - 1);

                if (constraintName == "CS_KorisnickoIme")
                    newMessage = "Korisnicko ime je zauzeto";

            }

            return newMessage;
        }
    }
}