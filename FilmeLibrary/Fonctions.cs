using System;
using System.Collections.Generic;
using System.Text;

namespace FilmeLibrary
{
    namespace Console_Lib
    {
        class MesFonctions
        {
            /// <summary>
            /// Fonction permettant de transformer la 1ère lettre d'un string en majuscule
            /// </summary>
            /// <param name="prenom"></param>
            /// <returns></returns>
            public static string Formater1ereLettre(string prenom)
            {
                prenom = prenom[0].ToString().ToUpper() + prenom.Substring(1).ToLower();
                return prenom;
            }

            /// <summary>
            /// Procédure qui permet de masquer le mdp lors de sa saisie
            /// </summary>
            /// <returns></returns>
            public static string MasquerMdp()
            {
                Stack<char> stack = new Stack<char>();
                ConsoleKeyInfo consoleKeyInfo;

                while ((consoleKeyInfo = Console.ReadKey(true)).Key != ConsoleKey.Enter)
                {
                    if (consoleKeyInfo.Key != ConsoleKey.Backspace)
                    {
                        stack.Push(consoleKeyInfo.KeyChar);
                        Console.Write("*");
                    }
                    else
                    {
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        if (stack.Count > 0) stack.Pop();
                    }
                }
                return stack.Reverse().Aggregate(string.Empty, (pass, kc) => pass += kc.ToString());
            }
            /// <summary>
            /// Fonction permettant de vérifier si une adresse mail saisie n'est pas vide et contient un @ et un .
            /// </summary>
            /// <param name="email"></param>
            /// <returns></returns>
            public static bool ValidationMail(string email)
            {
                if (string.IsNullOrWhiteSpace(email))
                    return false;

                try
                {
                    email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                          RegexOptions.None, TimeSpan.FromMilliseconds(200));
                    string DomainMapper(Match match)
                    {

                        var idn = new IdnMapping();
                        var domainName = idn.GetAscii(match.Groups[2].Value);

                        return match.Groups[1].Value + domainName;
                    }
                }
                catch (RegexMatchTimeoutException e)
                {
                    return false;
                }
                catch (ArgumentException e)
                {
                    return false;
                }

                try
                {
                    return Regex.IsMatch(email,
                        @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
                }
                catch (RegexMatchTimeoutException)
                {
                    return false;
                }
            }
            /// <summary>
            /// Fonction qui vérifie que le numéro de téléphone ne comporte que des chiffres et 10 caractères
            /// </summary>
            /// <param name="tel"></param>
            /// <returns></returns>
            public static bool VerifierNumTel(string tel)
            {
                bool leNumTelEstUnNombre = true;
                bool result = true;
                if (string.IsNullOrWhiteSpace(tel) || tel.Length != 10)
                {
                    result = false;
                }
                else
                    for (int i = 0; i < tel.Length; i++)
                    {
                        leNumTelEstUnNombre = char.IsDigit(tel[i]);
                        if (leNumTelEstUnNombre == false)
                        {
                            result = false;
                        }
                    }
                return result;
            }
            /// <summary>
            /// Fonction qui vérifie que la donnée saisie ne comporte que des chiffres
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>
            public static bool VerifierSiQueDesChiffres(string value)
            {
                bool laValueEstUnNombre;
                bool result = true;
                for (int i = 0; i < value.Length; i++)
                {
                    laValueEstUnNombre = char.IsDigit(value[i]);
                    if (laValueEstUnNombre == false)
                    {
                        result = false;
                    }
                }
                return result;
            }
            /// <summary>
            /// Fonction qui vérifie si il y a au moins 1 lettre, 1 chiffre et 1 majuscule
            /// </summary>
            /// <param name="mdp"></param>
            /// <returns></returns>
            public static bool VerifierMdp(string mdp)
            {
                bool ilYAAuMoinsUneLettre = false;
                bool ilYAAuMoinsUnChiffre = false;
                bool ilYAAuMoinsUneMaj = false;

                if (mdp.Length < 4 || mdp.Length > 6)
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < mdp.Length; i++)
                    {
                        bool leIemeEstUneLettre = char.IsLetter(mdp[i]);

                        if (leIemeEstUneLettre == true)
                        {
                            ilYAAuMoinsUneLettre = true;
                        }
                    }
                    for (int i = 0; i < mdp.Length; i++)
                    {
                        bool leIemeEstUnChiffre = char.IsDigit(mdp[i]);
                        if (leIemeEstUnChiffre == true)
                        {
                            ilYAAuMoinsUnChiffre = true;
                        }
                    }
                    for (int i = 0; i < mdp.Length; i++)
                    {
                        bool leIemeEstUneMaj = char.IsUpper(mdp[i]);
                        if (leIemeEstUneMaj == true)
                        {
                            ilYAAuMoinsUneMaj = true;
                        }
                    }
                    return (ilYAAuMoinsUnChiffre && ilYAAuMoinsUneLettre && ilYAAuMoinsUneMaj);
                }
            }
            /// <summary>
            /// Fonction qui vérifie que le code postal contient 5 chiffres
            /// </summary>
            /// <param name="cp"></param>
            /// <returns></returns>
            public static bool VerifierCodePostal(string cp)
            {
                bool leCpEstUnNombre = true;
                bool result = true;
                if (cp.Length != 5)
                {
                    result = false;
                }
                else
                    for (int i = 0; i < cp.Length; i++)
                    {
                        leCpEstUnNombre = char.IsDigit(cp[i]);
                        if (leCpEstUnNombre == false)
                        {
                            result = false;
                        }
                    }
                return result;
            }
            /// <summary>
            /// Fonction qui vérifie si il n'y a que des lettres
            /// </summary>
            /// <param name="mot"></param>
            /// <returns></returns>
            public static bool VerifieSiQueDesLettres(string mot)
            {
                bool leMotNaQueDesLettres = true;
                bool result = true;
                for (int i = 0; i < mot.Length; i++)
                {
                    leMotNaQueDesLettres = char.IsLetter(mot[i]);
                    if (leMotNaQueDesLettres == false)
                    {
                        result = false;
                    }
                }
                return result;
            }

        }
    }

}
