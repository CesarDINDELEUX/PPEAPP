using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    class SondageDAO
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<sondage> List()
        {
            List<sondage> ListeSondage = db.sondages.ToList();
            return ListeSondage;
        }

        public static sondage Select (int id)
        {
            sondage Sondage = db.sondages.Find();
            return Sondage;
        }

        public static void Modify (sondage Sondage)
        {
            db.sondages.Attach(Sondage);
            db.Entry(Sondage).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static void Delete (sondage Sondage)
        {
            db.sondages.Attach(Sondage);
            db.sondages.Remove(Sondage);
        }

        public static void Add (sondage Sondage)
        {
            db.sondages.Add(Sondage);
            db.SaveChanges();
        }
    }
}
