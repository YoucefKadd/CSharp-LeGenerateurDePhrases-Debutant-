using System;

namespace generateur_phrases_aleatoires // Note: actual namespace depends on the project name.
{
    class Program
    {
        static string ObtenirElementAleatoire(string[] t)
        {
            Random r = new Random();
            int i = r.Next(t.Length);
            return t[i];
             
        }
        static void Main(string[] args)
        {
            // sujet verbe complement
            var sujets = new string[] {
                "Un lapin",
                "Une grand-mère",
                "Un chat",
                "Un bonhomme de neige",
                "Une limace",
                "Une fee",
                "Un magicien",
                "Une tortue"
            };

            var verbes = new string[] {
                "mange",
                "écrase",
                "détruit",
                "observe",
                "attrape",
                "regarde",
                "boit",
                "avale",
                "néttoie",
                "se bat avec",
                "s'accroche à"
            };

            var complements = new string[] {
                "un arbre",
                "un livre",
                "la lune",
                "le soleil",
                "un serpent",
                "une carte",
                "une girafe",
                "le ciel",
                "une piscine",
                "un gateau",
                "une souris",
                "un crapaud"
            };

            const int NB_PHRASE = 10;

            for (int i = 0; i < NB_PHRASE; i++)
            {
                var sujet = ObtenirElementAleatoire(sujets);
                var verbe = ObtenirElementAleatoire(verbes);
                var complement = ObtenirElementAleatoire(complements);
                var phrase = $"{sujet} {verbe} {complement}";
                phrase = phrase.Replace("à la", "au");
                //sujet + verbe + complement  
                Console.WriteLine(phrase);
            }

            
        }
    }
}
