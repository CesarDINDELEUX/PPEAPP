using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    
    class EnqueteDAO
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<enquete> List()
        {
            /// <summary>
            /// Liste toutes les enquetes et en renvoie la liste
            /// </summary>
            /// <returns>ListeEnquete comme une liste</returns>
            List<enquete> ListeEnquete = db.enquetes.ToList();
            return ListeEnquete;
        }

        public static enquete Select(int id)
        {
            ///<summary>
            ///Permet d'avoir une seule enquete en fonction de son ID qui est unique
            /// </summary>
            /// <param name="id">ID du quizz</param>
            enquete enq = db.enquetes.Find(id);
            return enq;
        }

        public static void Modify(enquete Enquete)
        {
            ///<summary>
            ///Prend en parametre une enquete, la modifie
            /// </summary>
            db.enquetes.Attach(Enquete);
            db.Entry(Enquete).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public static void Delete(enquete Enquete)
        {
            ///<summary>
            ///Permet la suppresion d'une enquete
            /// </summary>
            db.enquetes.Attach(Enquete);
            db.enquetes.Remove(Enquete);
            db.SaveChanges();
       }

        public static void Add(enquete Enquete)
        {
            ///<summary>
            ///Permet l'ajout d'une nouvelle enquete
            /// </summary>

            db.enquetes.Add(Enquete);
            db.SaveChanges();
        }

        public static List<sequence> SeqEnq(enquete enquete)
        {
            return db.sequences.Where(x => x.enquete_id == enquete.id).ToList();
        }

        public static void AddSequence(enquete enquete, List<sequence> lessequence)
        {
            db.enquetes.Add(enquete);
            foreach (var item in lessequence)
            {
                enquete.sequences.Add(item);
            }
            db.SaveChanges();
        }

    }
}
