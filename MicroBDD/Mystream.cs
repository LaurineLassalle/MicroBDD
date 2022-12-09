using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MicroBDD
{
    internal class Mystream
    {

        //private const string FILE_NAME_SECTIONS = "D:\\Courprie\\C#\\exercie1\\MicroBDD\\sections.csv";
        //private const string FILE_NAME_ELEVES = "D:\\Courprie\\C#\\exercie1\\MicroBDD\\eleves.csv";
        //private const string FILE_NAME_MATIERES = "D:\\Courprie\\C#\\exercie1\\MicroBDD\\matieres.csv";
        public void EcritureEleve(string FILE_NAME_ELEVES, Eleve eleve)
        {
            //lecture du fichier
            using (StreamWriter sw = new StreamWriter(FILE_NAME_ELEVES, true))
            {
                sw.WriteLine(eleve.getIdEleve() + ";" + eleve.getNom() + ";" + eleve.getPrenom() + ";" + eleve.getSection());
            }

        }
        public void EcritureSection(string FILE_NAME_SECTION, Section section)
        {
            //lecture du fichier
            using (StreamWriter sw = new StreamWriter(FILE_NAME_SECTION, true))
            {
                sw.WriteLine(section.getIdSection() + ";" + section.getNom());
            }

        }
        public void EcritureMatiere(string FILE_NAME_MATIERE, Matiere matiere)
        {
            //lecture du fichier
            using (StreamWriter sw = new StreamWriter(FILE_NAME_MATIERE, true))
            {
                sw.WriteLine(matiere.getIdMatiere() + ";" + matiere.getNom() + ";" + matiere.getIdSection());
            }

        }

    }
}
