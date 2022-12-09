using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Section
{
    //Attributs
    private int IdSection;
    private string nom;

    public Section(int _IdCompte, string _nom)
    {
        this.nom = _nom;
        this.IdSection = _IdCompte;
        
    }
    //Accesseurs 
    public int getIdSection() { return IdSection; }

    public string getNom() { return nom; }
    public string setNom(string nom) { return nom; }


   





}