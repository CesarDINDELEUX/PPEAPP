using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    public class QuestionSondageDAO
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<question__sondage> List()
        {
            List<question__sondage> ListeQuestionSondage = db.question__sondage.ToList();
            return ListeQuestionSondage;
        }

        public static question__sondage Select(int id)
        {
            question__sondage QuestionS = db.question__sondage.Find(id);
            return QuestionS;
        }

        public static string Modifiy (question__sondage QuestionS)
        {
            db.question__sondage.Attach(QuestionS);
            db.Entry(QuestionS).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "La question de sondage a bien été modifié";
        }

        public static string Delete (question__sondage QuestionS)
        {
            db.question__sondage.Attach(QuestionS);
            db.question__sondage.Remove(QuestionS);
            return "La question de sondage a bien été supprimé";
        }

        public static string Add(question__sondage QuestionS)
        {
            db.question__sondage.Add(QuestionS);
            db.SaveChanges();
            return "La question de sondage a bien été ajouté";
        }
    }
}
