using System;
using System.Data.SqlClient;
using FilmeLibrary;

namespace FilmeShop
{
    public class DataAcces
    {
        public const string CHEMINBDD = @"Server=.\SQLExpress;Database=FilmeBase;Trusted_Connection=Yes";



        public static void AddFilm(Filme filme)
        {
            using (SqlConnection connection = new SqlConnection(DataAcces.CHEMINBDD))
            {
                connection.Open();

                SqlCommand InserFilme = connection.CreateCommand();
                InserFilme.CommandText = "INSERT INTO FilmeTable(Titre,Réalisateur,DateDeSortie,Résumé,Genre,Durée) VALUES (@Titre,@Réalisateur,@DateDeSortie,@Résumé,@Genre,@Durée)";
                InserFilme.Parameters.AddWithValue("@Titre", filme.Titre);
                InserFilme.Parameters.AddWithValue("@Réalisateur", filme.Realisateur);
                InserFilme.Parameters.AddWithValue("@DateDeSortie", filme.DateSortie);
                InserFilme.Parameters.AddWithValue("@Résumé", filme.Resume);
                InserFilme.Parameters.AddWithValue("@Genre", filme.Genre);
                InserFilme.Parameters.AddWithValue("@Durée", filme.Duree);
                InserFilme.ExecuteNonQuery();
                connection.Close();
            }

        }


        public static void AddPersonne(Personne personne)
        {
            using (SqlConnection connection = new SqlConnection(DataAcces.CHEMINBDD))
            {
                connection.Open();

                SqlCommand InserPersonne = connection.CreateCommand();
                InserPersonne.CommandText = "INSERT INTO Personne(NomPersone,PrenomPersonne,DateDenaissance,Adresse,Ville,CodePostal,Taille,Poids,Age) VALUES (@NomPersone,@DateDenaissance,@Adresse,@Ville,@CodePostal,@Taille,@Poids,@Age)";
                InserPersonne.Parameters.AddWithValue("@NomPersone", personne.Nom);
                InserPersonne.Parameters.AddWithValue("@DateDenaissance", personne.Prenom);
                InserPersonne.Parameters.AddWithValue("@Adresse", personne.Adresse);
                InserPersonne.Parameters.AddWithValue("@Ville", personne.Ville);
                InserPersonne.Parameters.AddWithValue("@CodePostal", personne.CodePostale);
                InserPersonne.Parameters.AddWithValue("@Taille", personne.Taille);
                InserPersonne.Parameters.AddWithValue("@Poids", personne.Poids);
                InserPersonne.Parameters.AddWithValue("@Age", personne.Age);
                InserPersonne.ExecuteNonQuery();
                connection.Close();
            }

        }

        public static void GetAllPersonne()
        {
            using (SqlConnection connection = new SqlConnection(DataAcces.CHEMINBDD))
            {
                connection.Open();

                SqlCommand RecuperePersonne = connection.CreateCommand();
                RecuperePersonne.CommandText = "SELECT IDPersonne,NomPersonne,PrenonPersonne,DateDenaissance,Adresse,Ville,CodePostal,Taille,Poids,Age From Personne";               
                RecuperePersonne.ExecuteNonQuery();
                SqlDataReader dataReader = RecuperePersonne.ExecuteReader();
                while (dataReader.Read())
                {






                }
                connection.Close();
            }

        }





    }
}
