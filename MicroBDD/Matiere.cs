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

        // Constructeurs 
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
    }
}
