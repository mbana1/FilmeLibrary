using System;
using System.Collections.Generic;
using System.Text;

namespace FilmeLibrary
{
    class Fonctions
    {

        public static string Formater1ereLettre(string prenom)
        {

            prenom = prenom[0].ToString().ToUpper() + prenom.Substring(1).ToLower();
            return prenom;
        }





    }
}
