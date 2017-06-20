using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static PPE4Entities db = new PPE4Entities();
        static void Main(string[] args)
        {
           enquete lol = db.enquetes.Find(1);
           SeqEnq(lol);
            foreach (var item in SeqEnq(lol))
            {
                Console.WriteLine(item.Intitule);
            }
            Console.ReadKey();
        }

        public static List<sequence> SeqEnq(enquete enquete)
        {
            return db.sequences.Where(x => x.enquete_id == enquete.id).ToList();
        }
    }
}
