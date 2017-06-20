using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PPE
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public PPE.enquete creationenquete = new enquete();
        public sequence newsequence = new sequence();

        public List<sequence> listeseq = new List<sequence>();
        

        public question__sequence newquestion { get; set; }

        public List<question__sequence> listequestion = new List<question__sequence>();



        public List<reponse__sequence> RQ = new List<reponse__sequence>();

        public enquete enquetemodif { get; set; }



        public quizz creationquiz = new quizz();
        public List<quizz> listequiz = new List<quizz>();
        public question__quizz newquestionquiz { get; set; }
        public reponse__quizz newreponsequiz { get; set; }
        public List<question__quizz> listequestionquizz = new List<question__quizz>();
        public List<reponse__quizz> listereponsequizz = new List<reponse__quizz>();
        public quizz modifquiz { get; set; }


        public sondage creationsondage = new sondage();
        public List<sondage> listesondage = new List<sondage>();
        public question__sondage newquestionsondage { get; set; }
        public reponse__sondage newreponsesondage { get; set; }
        public List<question__sondage> listequestionsondage = new List<question__sondage>();
        public List<reponse__sondage> listereponsesondage = new List<reponse__sondage>();
        public sondage modifsondage { get; set; }
    }

    public class newenquete
    {
        question__sequence questionseq { get; set; }
    }

    public class newquizz
    {
        question__quizz questionquiz { get; set; }
    }

    public class newsondage
    {
        question__sondage questionsondage { get; set; }
    }
}
