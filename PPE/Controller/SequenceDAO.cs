using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    class SequenceDAO
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<sequence> List()
        {
            /// <summary>
            /// Liste tous les quizz et en renvoie la liste
            /// </summary>
            /// <returns>ListeQuizz comme une liste</returns>
            List<sequence> ListeSequence = db.sequences.ToList();
            return ListeSequence;
        }

        public static sequence Select(int id)
        {
            ///<summary>
            ///Permet d'avoir un seul quizz en fonction de son ID qui est unique
            /// </summary>
            /// <param name="id">ID du quizz</param>
            sequence seq = db.sequences.Find(id);
            return seq;
        }

        public static void Modify(sequence Sequence)
        {
            ///<summary>
            ///Prend en parametre un quizz le modifie et affiche un message qui confirme la modification
            /// </summary>
            db.sequences.Attach(Sequence);
            db.Entry(Sequence).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static void Delete(sequence Sequence)
        {
            ///<summary>
            ///Permet la suppresion d'un quizz
            /// </summary>

            db.sequences.Attach(Sequence);
            db.sequences.Remove(Sequence);
            db.SaveChanges();
        }

        public static void Add(sequence Sequence)
        {
            ///<summary>
            ///Permet l'ajout d'un nouveau quizz
            /// </summary>

            db.sequences.Add(Sequence);
            db.SaveChanges();
        }





    }
}
