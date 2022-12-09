using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBDD
{
    internal class Matiere
    {
        //Attributs
        private int IdMatiere;
        private string nom;
        private int IdSection;
        private string cheminFichier = @"D:\Courprie\C#\exercie1\MicroBDD\matieres.csv";

        // Constructeurs 
        public Matiere()
        {

        }
        public Matiere(int _IdMatiere, string _nom, int _IdSection)
        {
            this.nom = _nom;
            this.IdMatiere = _IdMatiere;
            this.IdSection = _IdSection;
        }

        //Accesseurs 
        public int getIdMatiere() { return IdMatiere; }
        public int getIdSection() { return IdSection; }

        public string getNom() { return nom; }
        public string setNom(string nom) { return nom; }

        //Méthodes 
        public void afficheListeMatiere(List<Matiere> matiereList)//méthode d'affichage de la liste des matières
        {
            try
            {
                foreach (Matiere matiere in matiereList)//pour chaque matière présente dans la liste
                {
                    Console.WriteLine(matiere.getNom());//on affiche le nom
                }
            }
            catch
            {
                Console.WriteLine("Aucun éléments dans la liste");
            }
        }
        public void lectureFichierMatieres()
        {
            if (File.Exists(this.cheminFichier)) //Vérifie l'existance du fichier matières
            {

                string line = "";
                using (StreamReader sr = new StreamReader(this.cheminFichier))//lecture du fichier
                {
                    List<Matiere> matiereList = new List<Matiere>();//liste de matière (objet)
                    while ((line = sr.ReadLine()) != null)//lecture de chaque ligne du fichier
                    {
                        string[] ligneFichier = line.Split(";");//récupération des élements de la ligne
                        Matiere matiere = new Matiere(int.Parse(ligneFichier[0]), ligneFichier[1], int.Parse(ligneFichier[2])); //création de l'objet matière  
                        matiereList.Add(matiere);//ajout de l'objet matiere à la liste

                    }
                    this.afficheListeMatiere(matiereList);
                }
            }
            else
            {
                Console.WriteLine($"{this.cheminFichier} existe pas!");

            }
        }
    }
}
