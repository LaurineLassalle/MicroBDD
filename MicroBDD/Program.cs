
using System;
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



            Section section1 = new Section(1, "BTS SIO");
            Eleve eleve1 = new Eleve(1,"Billard", "Mélissa", 1);
            //Console.WriteLine(eleve1.getPrenom());
            //Console.WriteLine(section1.getNom());
            //Console.WriteLine(section1.getIdSection());
            Matiere matiere1 = new Matiere(3, "Maths", 1);
            //Console.WriteLine(matiere1.getNom());
            //eleve1.setNom("Lassalle");
            //Console.WriteLine(eleve1.getNom());
            string FILE_NAME_SECTIONS = @"D:\Courprie\C#\exercie1\MicroBDD\sections.csv";
            string FILE_NAME_ELEVES = @"D:\Courprie\C#\exercie1\MicroBDD\eleves.csv";
            string FILE_NAME_MATIERES = @"D:\Courprie\C#\exercie1\MicroBDD\matieres.csv";

            //using (StreamWriter sw = new StreamWriter(FILE_NAME_ELEVES,true))
            //{

            //    sw.WriteLine(eleve1.getID() + ";" + eleve1.getNom() + ";" + eleve1.getPrenom() + ";" + eleve1.getSection());

            //}

            //Mystream mystream = new Mystream();
            //mystream.EcritureEleve(FILE_NAME_ELEVES, eleve1);
            //mystream.EcritureSection(FILE_NAME_SECTIONS, section1);
            //mystream.EcritureMatiere(FILE_NAME_MATIERES, matiere1);

            if (File.Exists(FILE_NAME_ELEVES)) //Vérifie l'existance du fichier élèves
            {
              
                string line = "";
                using (StreamReader sr = new StreamReader(FILE_NAME_ELEVES))//lecture du fichier
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        List<string> eleve = new List<string>();

                        eleve.AddRange(line.Split(";"));//liste d'élèves
                        Console.WriteLine(eleve[1]+" "+ eleve[2]);

                        //for (int i = 0; i < eleve.Count; i++)
                        //{
                        //    Console.WriteLine(eleve[i]);
                        //}
                  
                       
                    }
                }
            }
            else
            {
                Console.WriteLine($"{FILE_NAME_ELEVES} existe pas!");
            }

            if (File.Exists(FILE_NAME_MATIERES)) //Vérifie l'existance du fichier
            {
                
                string line = "";
                using (StreamReader sr = new StreamReader(FILE_NAME_MATIERES))//lecture du fichier matieres
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        List<string> matiere = new List<string>();

                        matiere.AddRange(line.Split(";"));//liste de matiere
                        Console.WriteLine(matiere[1]);
             

                    }
                }
            }
            else
            {
                Console.WriteLine($"{FILE_NAME_MATIERES} existe pas!");
            }
            if (File.Exists(FILE_NAME_SECTIONS)) //Vérifie l'existance du fichier sections
            {

                string line = "";
                using (StreamReader sr = new StreamReader(FILE_NAME_SECTIONS))//lecture du fichier sections
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        List<string> section = new List<string>();

                        section.AddRange(line.Split(";"));//liste des sections
                        Console.WriteLine(section[1]);

           

                    }
                }
            }
            else
            {
                Console.WriteLine($"{FILE_NAME_SECTIONS} existe pas!");
            }
        }
 

        //Mystream mystream = new Mystream();
        //mystream.Lecture();



   

    }
}
