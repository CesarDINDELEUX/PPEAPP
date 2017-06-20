using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    public class CommentaireSondageDAO
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<commentaire__sondage> List()
        {
            List<commentaire__sondage> ListeCommentaireSondage = db.commentaire__sondage.ToList();
            return ListeCommentaireSondage;
        }

        public static commentaire__sondage Select (int id)
        {
            commentaire__sondage CommentaireS = db.commentaire__sondage.Find(id);
            return CommentaireS;
        }

        public static string Delete (commentaire__sondage CommentaireS)
        {
            db.commentaire__sondage.Attach(CommentaireS);
            db.commentaire__sondage.Remove(CommentaireS);
            db.SaveChanges();
            return "Le commentaire sur le sondage a bien été suppimé";
        }
    }
}
