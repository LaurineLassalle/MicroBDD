using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBDD
{
    internal class Eleve
    {
        //Attributs
        private int IdEleve;
        private string nom;
        private string prenom;
        private int section;
        private string cheminFichier = @"D:\Courprie\C#\exercie1\MicroBDD\eleves.csv";

        // Constructeurs 
        public Eleve(){}
        public Eleve(int _IdEleve, string _nom, string _prenom, int _section)
        {
            this.IdEleve = _IdEleve;
            this.nom = _nom;
            this.prenom = _prenom;
            this.section = _section;
        }

        //Accesseurs 
        public int getIdEleve() { return IdEleve; }
        public void setIdEleve(int IdEleve) { this.IdEleve = IdEleve; }
        public string getNom() { return nom; }
        public void setNom(string nom) { this.nom = nom; }
        public string getPrenom() { return prenom; }
        public void setPrenom(string prenom) { this.prenom = prenom; }
        public int getSection() { return section; }
        public void setSection(int section) { this.section = section; }
        public string getChemin() { return cheminFichier; }
        public void setChemin(string cheminFichier) { this.cheminFichier = cheminFichier; }
        //Méthodes 
        //public void afficheListeEleve(List<Eleve> eleveList)//méthode d'affichage de la liste des éleves
        //{
        //    try
        //    {
        //        foreach (Eleve eleve in eleveList)//pour chaque éleves présents dans la liste
        //        {
        //            Console.WriteLine(eleve.getPrenom() + " " + eleve.getNom());//on affiche le prénom et le nom
        //        }
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Aucun éléments dans la liste");
        //    }
        //}
        //public void lectureFichierEleves()
        //{
        //    if (File.Exists(this.cheminFichier)) //Vérifie l'existance du fichier élèves
        //    {

        //        string line = "";
        //        using (StreamReader sr = new StreamReader(this.cheminFichier))//lecture du fichier
        //        {
        //            List<Eleve> eleveList = new List<Eleve>();//liste d'éleves (objet)
        //            while ((line = sr.ReadLine()) != null)//lecture de chaque ligne du fichier
        //            {
        //                string[] ligneFichier = line.Split(";");//récupération des élements de la ligne
        //                Eleve eleve = new Eleve(int.Parse(ligneFichier[0]), ligneFichier[1], ligneFichier[2], int.Parse(ligneFichier[3])); //création de l'objet éleve  
        //                eleveList.Add(eleve);//ajout de l'objet éleve à la liste

        //            }
        //            this.afficheListeEleve(eleveList);

        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{this.cheminFichier} existe pas!");

        //    }
        //}

    }
}
