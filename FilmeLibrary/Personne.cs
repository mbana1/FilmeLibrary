using System;
using System.Collections.Generic;
using System.Text;

namespace FilmeLibrary
{
    public class Personne
    {
        int id;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string adresse;
        private string ville;
        private string codePostale;
        private decimal taille;
        private decimal poids;
        private int age;
        
        public string Nom { get => nom; set => nom = value; }
        public int Id { get => id; set => id = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Ville { get => ville; set => ville = value; }
        public string CodePostale { get => codePostale; set => codePostale = value; }
        public decimal Taille { get => taille; set => taille = value; }
        public decimal Poids { get => poids; set => poids = value; }
       
        public int Age {
            get
            {

                int age = DateTime.Now.Year - DateNaissance.Year;
                DateTime dateAnniversaire =
                    new DateTime(
                        DateTime.Now.Year,
                        DateNaissance.Month,
                        DateNaissance.Day);

                if (dateAnniversaire >= DateTime.Now)
                {
                    age--;
                }

                return age;
            }
        }

        public Personne()
        {
           
        }

        public Personne(string nom, int id, string prenom, DateTime dateNaissance, string adresse, string ville, string codePostale, decimal taille,decimal poids)
        {
            Nom = nom;
            Id = id;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Adresse = adresse;
            Ville = ville;
            CodePostale = codePostale;
            Taille = taille;
            Poids = poids;
           
           
        }



        public string NomComplet() { return this.Prenom + " " + this.Nom; }

        public string Spresenter()
        {



            return "Bonjour je m'apelle " + this.NomComplet() + "j'ai " + this.Age + " ans" + "  j'habite à " + this.Ville;
        }

    }
}
