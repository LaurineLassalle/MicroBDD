using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBDD
{
    internal class Ecole
    {

        //Attributs
        private string cheminFichierMatiere = @"D:\Courprie\C#\exercie1\MicroBDD\matieres.csv";
        private string cheminFichierSection = @"D:\Courprie\C#\exercie1\MicroBDD\sections.csv";
        private string cheminFichierEleve = @"D:\Courprie\C#\exercie1\MicroBDD\eleves.csv";
        private List<Eleve> eleveList;
        private List<Matiere> matiereList;
        private List<Section> sectionList;
        // Constructeurs 
        public Ecole()
        {

        }


        //Méthodes 
        public void afficheListeEleve(List<Eleve> eleveList)//méthode d'affichage de la liste des éleves
        {
            try
            {
                foreach (Eleve eleve in eleveList)//pour chaque éleves présents dans la liste
                {
                    Console.WriteLine(eleve.getPrenom() + " " + eleve.getNom());//on affiche le prénom et le nom
                }
            }
            catch
            {
                Console.WriteLine("Aucun éléments dans la liste");
            }
        }
        public void lectureFichierEleves()
        {
            if (File.Exists(this.cheminFichierEleve)) //Vérifie l'existance du fichier élèves
            {

                string line = "";
                using (StreamReader sr = new StreamReader(this.cheminFichierEleve))//lecture du fichier
                {
                    //List<Eleve> eleveList = new List<Eleve>();//liste d'éleves (objet)
                    while ((line = sr.ReadLine()) != null)//lecture de chaque ligne du fichier
                    {
                        string[] ligneFichier = line.Split(";");//récupération des élements de la ligne
                        Eleve eleve = new Eleve(int.Parse(ligneFichier[0]), ligneFichier[1], ligneFichier[2], int.Parse(ligneFichier[3])); //création de l'objet éleve  
                        this.eleveList.Add(eleve);//ajout de l'objet éleve à la liste

                    }
                    this.afficheListeEleve(this.eleveList);

                }
            }
            else
            {
                Console.WriteLine($"{this.cheminFichierEleve} existe pas!");

            }
        }
    }
}
