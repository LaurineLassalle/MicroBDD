
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace MicroBDD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bienvenue !");
            //Console.WriteLine("Faites votre choix: \n (1) Voir la liste des élèves\n (2) voir la liste des sections\n (3) Voir la liste des matières\n (4) Trouver un élève\n (5) Ajouter un élève \n (6) Ajouter une section \n (7) Ajouter une matière \n (8) Quitter");
            //string reponse = (Console.ReadLine());

            //try
            //{
            //    switch (reponse)
            //    {
            //        case "1":
            //            Console.WriteLine("Liste des élèves : ");
            //            break;
            //        case "2":
            //            Console.WriteLine("Liste des sections : ");
            //            break;
            //        case "3":
            //            Console.WriteLine("Liste des matières : ");
            //            break;
            //        case "4":
            //            Console.WriteLine("Trouver un élève : ");
            //            break;
            //        case "5":
            //            Console.WriteLine(" Ajouter un élève : ");
            //            break;
            //        case "6":
            //            Console.WriteLine("Ajouter une section : ");
            //            break;
            //        case "7":
            //            Console.WriteLine("Ajouter une matière : ");
            //            break;
            //        case "8":
            //            Console.WriteLine("Aurevoir");
            //            Environment.Exit(0);
            //            break;
            //        default:
            //            Console.WriteLine("Erreur de saisie");
            //            break;
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Erreur :", e.Message);
            //}
            Ecole ecole = new Ecole();
            Eleve eleves = new Eleve();
            Section sections = new Section();
            Matiere matieres = new Matiere();

            ecole.lectureFichierEleves();
            //eleves.lectureFichierEleves();
            //sections.lectureFichierSections();
            //matieres.lectureFichierMatieres();

        }

    }
}
