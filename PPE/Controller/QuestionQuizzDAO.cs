using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    public class QuestionQuizzDAO
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<question__quizz> List()
        {
            List<question__quizz> ListeQuestionQuizz = db.question__quizz.ToList();
            return ListeQuestionQuizz;
        }

        public static question__quizz Select(int id)
        {
            question__quizz QuestionQ = db.question__quizz.Find(id);
            return QuestionQ;
        }

        public static string Modify(question__quizz QuestionQ)
        {
            db.question__quizz.Attach(QuestionQ);
            db.Entry(QuestionQ).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "La question que vous avez choisie a bien été modifié";
        }

        public static string Delete (question__quizz QuestionQ)
        {
            db.question__quizz.Attach(QuestionQ);
            db.question__quizz.Remove(QuestionQ);
            db.SaveChanges();
            return "La question de quizz a bien été supprimé";
        }

        public static string Add (question__quizz QuestionQ)
        {
            db.question__quizz.Add(QuestionQ);
            db.SaveChanges();
            return "La question de quizz a bien été ajouté";
        }
    }
}
