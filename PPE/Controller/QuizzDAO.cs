using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PPE.Controller
{
    class QuizzDAO
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<quizz> List()
        {
            /// <summary>
            /// Liste tous les quizz et en renvoie la liste
            /// </summary>
            /// <returns>ListeQuizz comme une liste</returns>
            List<quizz> ListeQuizz = db.quizzs.ToList();
            return ListeQuizz;
        }

        public static quizz Select(int id)
        {
            ///<summary>
            ///Permet d'avoir un seul quizz en fonction de son ID qui est unique
            /// </summary>
            /// <param name="id">ID du quizz</param>
            quizz Quizz = db.quizzs.Find(id);
            return Quizz;
        }

        public static void Modify(quizz Quizz)
        {
            ///<summary>
            ///Prend en parametre un quizz le modifie et affiche un message qui confirme la modification
            /// </summary>
            db.quizzs.Attach(Quizz);
            db.Entry(Quizz).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static void Delete (quizz Quizz)
        {
            ///<summary>
            ///Permet la suppresion d'un quizz
            /// </summary>

            db.quizzs.Attach(Quizz);
            db.quizzs.Remove(Quizz);
            db.SaveChanges();
        }

        public static void Add(quizz Quizz)
        {
            ///<summary>
            ///Permet l'ajout d'un nouveau quizz
            /// </summary>

            db.quizzs.Add(Quizz);
            db.SaveChanges();
        }

    }
}
