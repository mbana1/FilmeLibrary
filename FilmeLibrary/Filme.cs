using System;
using System.Collections.Generic;
using System.Text;

namespace FilmeLibrary
{
  public  class Filme
    {
        int ID;
        string titre;
        string realisateur;
        DateTime dateSortie;
        string resume;
        string genre;
        int duree;
        List<string> ListeActeurs = new List<string>();
     

        public int ID1 { get => ID; set => ID = value; }
        public string Titre { get => titre; set => titre = value; }
        public string Realisateur { get => realisateur; set => realisateur = value; }
        public DateTime DateSortie { get => dateSortie; set => dateSortie = value; }
        public string Resume { get => resume; set => resume = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Duree { get => duree; set => duree = value; }
        public List<string> ListeActeurs1 { get => ListeActeurs; set => ListeActeurs = value; }

        public Filme()
        {
        }

        public Filme(int iD1, string titre, string realisateur, DateTime dateSortie, string resume, string genre, int duree)
        {
            ID1 = iD1;
            Titre = titre;
            Realisateur = realisateur;
            DateSortie = dateSortie;
            Resume = resume;
            Genre = genre;
            Duree = duree;
      
        }
    }



   



}

