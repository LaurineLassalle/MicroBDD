using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace MicroBDD
{
    internal class Section { 

        //Attributs
        private int IdSection;
        private string nom;
        private string cheminFichier = @"D:\Courprie\C#\exercie1\MicroBDD\sections.csv";

        // Constructeurs 
        public Section()
        {
  

        }
        public Section(int _IdCompte, string _nom)
        {
            this.nom = _nom;
            this.IdSection = _IdCompte;

        }
        //Accesseurs 
        public int getIdSection() { return IdSection; }

        public string getNom() { return nom; }
        public string setNom(string nom) { return nom; }

        //Méthodes 
        public void afficheListeSections(List<Section> sectionList)//méthode d'affichage de la liste des sections
        {
            try
            {
                foreach (Section section in sectionList)//pour chaque section présente dans la liste
                {
                    Console.WriteLine(section.getNom());//on affiche le nom
                }
            }
            catch
            {
                Console.WriteLine("Aucun éléments dans la liste");
            }
        }
        public void lectureFichierSections()
        {
            if (File.Exists(this.cheminFichier)) //Vérifie l'existance du fichier sections
            {

                string line = "";
                using (StreamReader sr = new StreamReader(this.cheminFichier))//lecture du fichier
                {
                    List<Section> sectionList = new List<Section>();//liste de sections (objet)
                    while ((line = sr.ReadLine()) != null)//lecture de chaque ligne du fichier
                    {
                        string[] ligneFichier = line.Split(";");//récupération des élements de la ligne
                        Section section = new Section(int.Parse(ligneFichier[0]), ligneFichier[1]); //création de l'objet section  
                        sectionList.Add(section);//ajout de l'objet section à la liste

                    }
                    this.afficheListeSections(sectionList);
                }
            }
            else
            {
                Console.WriteLine($"{this.cheminFichier} existe pas!");

            }
        }
    }
}