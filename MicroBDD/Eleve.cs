using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBDD
{
    internal class Eleve
    {
        private int IdEleve;
        private string nom;
        private string prenom;
        private int section;

        public Eleve(int _IdEleve,string _nom, string _prenom, int _section)
        {
            this.IdEleve = _IdEleve;
            this.nom = _nom;
            this.prenom = _prenom;
            this.section = _section;

        }
        public int getIdEleve() { return IdEleve; }
        public void setIdEleve(int IdEleve) { this.IdEleve = IdEleve; }
        public string getNom() { return nom; }
        public void setNom(string nom) { this.nom = nom; }
        public string getPrenom() { return prenom; }
        public void setPrenom(string prenom) { this.prenom = prenom; }
        public int getSection() { return section; }
        public void setSection(int section) { this.section = section; }

    }
}
