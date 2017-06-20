using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    
    public class ThemeDAO
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<theme> List()
        {
            List<theme> ListeTheme = db.themes.ToList();
            return ListeTheme;
        }

        /// <summary>
        /// retourne les sous themes
        /// </summary>
        /// <param name="letheme">Le theme parent</param>
        /// <returns>Retourne une liste de sous themes</returns>
        public static List<theme> ssTheme(theme letheme)
        {
            List<theme> ListessTheme = db.themes.ToList();
            var result = db.themes.Include(x => x.themes).Single(x => x.id == letheme.id);           
            return result.theme1.ToList();
        }

        public static void addtheme(theme letheme)
        {
            db.themes.Add(letheme);
            db.SaveChanges();
        }


    }
}
