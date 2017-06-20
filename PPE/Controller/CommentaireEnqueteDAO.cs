using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    public class CommentaireEnqueteDAO
    {
        public static PPE4Entities db = new PPE4Entities();
        public static List<commentaire__enquete> listeCommEnq(enquete enquete)
        {
            return db.commentaire__enquete.Where(x => x.enquete_id == enquete.id).ToList();
        }

        public static void Delete(commentaire__enquete idcomm)
        {
            
            
            db.commentaire__enquete.Remove(idcomm);
            db.SaveChanges();
        }


    }
}
