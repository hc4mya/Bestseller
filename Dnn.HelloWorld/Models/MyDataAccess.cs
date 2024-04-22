using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Dnn.Dnn.HelloWorld.Models
{
    using DotNetNuke.Data;
    using System.Data;
    using System.Runtime.Remoting.Contexts;

    public class MyDataAccess
    {
        //public static DataTable GetMyData()
        //{
        //    return (DataTable)DataProvider.Instance().ExecuteSQL("SELECT * FROM Kérdések");

        //}

        public static IEnumerable<Kérdések> GetMyData()
        {
            DataTable dataTable = (DataTable)DataProvider.Instance().ExecuteSQL("SELECT * FROM Kérdések");

            List<Kérdések> kérdések = new List<Kérdések>();

            foreach (DataRow row in dataTable.Rows)
            {
                Kérdések kérdés = new Kérdések();
                kérdés.QuestionText = row["QuestionText"].ToString();
                // További oszlopok beállítása, ha vannak
                kérdések.Add(kérdés);
            }

            return kérdések;
        }


        //public static IEnumerable<Kérdések> GetMyData()
        //{
        //    using (var context = new YourDbContext())
        //    {
        //        // Entity Framework segítségével lekérdezzük az adatokat az adatbázisból
        //        var kérdések = context.Kérdések.ToList();

        //        return kérdések;
        //    }
        //}
    }
}