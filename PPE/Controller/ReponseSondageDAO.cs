using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    class ReponseSondageDAO
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<reponse__sondage> List()
        {
            List<reponse__sondage> ListeReponseSondage = db.reponse__sondage.ToList();
            return ListeReponseSondage;
        }

        public static reponse__sondage Select(int id)
        {
            reponse__sondage ReponseS = db.reponse__sondage.Find(id);
            return ReponseS;
        }

        public static string Modify(reponse__sondage ReponseS)
        {
            db.reponse__sondage.Attach(ReponseS);
            db.Entry(ReponseS).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "La reponse d'une question de sondage a été modifié correctement";
        }

        public static string Delete(reponse__sondage ReponseS)
        {
            db.reponse__sondage.Attach(ReponseS);
            db.reponse__sondage.Remove(ReponseS);
            db.SaveChanges();
            return "La réponse a bien été supprimé";
        }

        public static string Add(reponse__sondage ReponseS)
        {
            db.reponse__sondage.Add(ReponseS);
            db.SaveChanges();
            return "La réponse a bien été ajouté";
        }
    }
}
