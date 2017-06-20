using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    public static class CadeauQuizzDao
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<cadeau> List()
        {
            List<cadeau> ListeCadeau = db.cadeaux.ToList();
            return ListeCadeau;
        }

        public static cadeau Select(int id)
        {
            cadeau Cadeau = db.cadeaux.Find(id);
            return Cadeau;
        }

        public static string Modify(cadeau Cadeau)
        {
            db.cadeaux.Attach(Cadeau);
            db.Entry(Cadeau).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "le cadeau a bien été modifié";
        }

        public static string Delete(cadeau Cadeau)
        {
            db.cadeaux.Attach(Cadeau);
            db.cadeaux.Remove(Cadeau);
            db.SaveChanges();
            return "le cadeau a bien été supprimé";
        }

        public static string Add(cadeau Cadeau)
        {
            db.cadeaux.Add(Cadeau);
            db.SaveChanges();
            return "le cadeau a bien été ajouté à la liste des cadeaux";
        }
    }
}
