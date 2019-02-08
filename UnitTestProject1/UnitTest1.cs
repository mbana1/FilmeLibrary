using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Le_Nom_Technicien_Doit_S_Appeler_Felix()
        {
            var tech = new ();
            tech.Nom = "Felix";

            Assert.AreEqual("Felix", tech.Nom);
        }

        [TestMethod]
        public void Le_Nom_Technicien_Ne_Peut_Pas_Etre_Vide()
        {
            var tech = new Technicien();

            Assert.ThrowsException<ArgumentException>(
                () => tech.Nom = ""
                );
        }

        [TestMethod]
        public void Le_Nom_Technicien_Ne_Peut_Pas_Avoir_Un_Nom_Qui_Contient_Des_Chiffres()
        {
            var tech = new Technicien();

            var exception = Assert.ThrowsException<ArgumentException>(
                () => tech.Nom = "123Tech"
                );
            Assert.AreEqual("Le nom ne doit contenir que des lettres", exception.Message);
        }

        [TestMethod]
        public void Le_Prenom_Technicien_Doit_S_Appeler_Albert()
        {
            var tech = new Technicien();
            tech.Prenom = "Albert";

            Assert.AreEqual("Albert", tech.Prenom);
        }

        [TestMethod]
        public void Le_Tel_Technicien_Doit_Contenir_10_Chiffres()
        {
            var tech = new Technicien();
            tech.Tel = "0622334411";

            Assert.AreEqual("0622334411", tech.Tel);
        }

        [TestMethod]
        public void Le_Tel_Technicien_Ne_Peut_Pas_Avoir_De_Lettres()
        {
            var tech = new Technicien();

            var exception = Assert.ThrowsException<FormatException>(
                () => tech.Tel = "123452Tech"
                );
            Assert.AreEqual("Le numéro doit contenir 10 chiffres", exception.Message);
        }
        public void Le_Prenom_Technicien_Ne_Peut_Pas_Etre_Vide()
        {
            var tech = new Technicien();

            Assert.ThrowsException<ArgumentException>(
                () => tech.Prenom = ""
                );
        }

        [TestMethod]
        public void Le_Prenom_Technicien_Ne_Peut_Pas_Avoir_Plus_De_50_Caracteres()
        {
            var tech = new Technicien();

            var exception = Assert.ThrowsException<ArgumentException>(
            () => tech.Prenom = "fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff"
            );
            Assert.AreEqual("Le prénom saisi ne doit pas avoir plus de 50 caractères", exception.Message);
        }

        [TestMethod]
        public void Le_Mail_Technicien_Doit_Contenir_Arobase_Et_Point()
        {
            var tech = new Technicien();

            var exception = Assert.ThrowsException<ArgumentException>(
                () => tech.Mail = "fred123"
                );
            Assert.AreEqual("Mail non valide, il faut un @ et un .", exception.Message);
        }

        [TestMethod]
        public void Le_Mail_Technicien_Ne_Doit_Pas_Etre_Deja_Utilise()
        {
            var tech = new Technicien();

            var exception = Assert.ThrowsException<ArgumentException>(
                () => tech.Mail = "fred@gmail.com"
                );
            Assert.AreEqual("Mail déjà utilisé", exception.Message);
        }


        [TestMethod]
        public void Le_Login_Technicien_Doit_Etre_Compris_Entre_6_Et_10_Caracteres()
        {
            var tech = new Technicien();

            var exception = Assert.ThrowsException<ArgumentException>(
                () => tech.Login = "fred"
                );
            Assert.AreEqual("Le login doit être compris entre 6 et 10 caractères", exception.Message);
        }

        [TestMethod]
        public void Le_Login_Technicien_Doit_S_Appeler_UOgez1()
        {
            var tech = new Technicien();
            tech.Login = "UOgez1";

            Assert.AreEqual("UOgez1", tech.Login);
        }

        [TestMethod]
        public void Le_Login_Technicien_Ne_Doit_Pas_Etre_Deja_Utilise()
        {
            var tech = new Technicien();

            var exception = Assert.ThrowsException<ArgumentException>(
                () => tech.Login = "FCarena"
                );
            Assert.AreEqual("Le login est déjà utilisé", exception.Message);
        }

        public void Le_Mdp_Technicien_Doit_Contenir_1_Maj_1_Min_1_Chiffre_Et_Etre_Compris_Entre_4_Et_6_Caracteres()
        {
            var tech = new Technicien();
            tech.Mdp = "Test2";

            Assert.AreEqual("Test2", tech.Mdp);
        }

        [TestMethod]
        public void Le_Mdp_Technicien_Doit_Contenir_1_Maj_1_Min_1_Chiffre_Et_Etre_Compris_Entre_4_Et_6_CaracteresBis()
        {
            var tech = new Technicien();

            var exception = Assert.ThrowsException<FormatException>(
                () => tech.Mdp = "blablabla512"
                );
            Assert.AreEqual("Le mot de passe doit contenir au moins 1 majuscule, 1 minuscule et 1 chiffre et contenir entre 4 et  6 caractères", exception.Message);
        }

        [TestMethod]
        public void Creation_D_Un_Nouveau_Technicien()
        {
            var tech = new Technicien();
            tech.Nom = "ogez";
            tech.Prenom = "ulysse";
            tech.Tel = "0622334455";
            tech.Mail = "ulysse@gmail.com";
            tech.Login = "UlOgez";
            tech.Mdp = "Test1";
            tech.Sup = true;

            Assert.AreEqual("ogez", tech.Nom);
            Assert.AreEqual("ulysse", tech.Prenom);
            Assert.AreEqual("0622334455", tech.Tel);
            Assert.AreEqual("ulysse@gmail.com", tech.Mail);
            Assert.AreEqual("UlOgez", tech.Login);
            Assert.AreEqual("Test1", tech.Mdp);
            Assert.AreEqual(true, tech.Sup);
        }
    }
}


