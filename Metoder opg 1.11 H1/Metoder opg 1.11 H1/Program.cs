using System;
using System.Collections.Generic; //For at kunne bruge List
using System.Linq;

namespace Metoder_opg_1._11_H1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Selvdefinerede metoder               

           Console.ReadKey(); ;
        }
        //Opretter metode der returnerer summen af to heltal
        public static int GetSum(int tal1, int tal2)
        {
            return tal1 + tal2;   
        }

        //Opretter metode der returnerer resultatet af to heltal divideret med hinanden
        public static double GetResultat(int tal1, int tal2)
        {
            return (double)tal1 / (double)tal2; //Skal ses som double for at få kommatal med
        }

        //Opretter metode der returnerer resultatet af hvor mange gange int tal2 går op i int tal1 
        public static int GetAntal(int tal1, int tal2)
        {
             int resultat = tal1 / tal2; /*Så får man hvor mange gange det går op, hvis der er en rest og det er
                                          * den man vil vide skal man fange den med modulus og returnere den*/
            return resultat;
            //rest = tal1 % tal2;
        }

        //Opretter metode der finder den største værdi i en liste
        public static int GetMax(List<int> listeNavn)
        {
            listeNavn.Sort();//Sorterer listen så det største tal står til sidst
           
            return listeNavn[(listeNavn.Count())-1];/* Returnerer den værdi der står på den sidste plads (-1 fordi listen starter
                                                     * på 0 og Count starter fra1)

            /*kunne også bare bruge den indbyggede funktion
             * return listeNavn.Max();*/

        }

        //Opretter en metode der returnerer en bool hvis x er indeholdt i listen list
        public static bool IfX(List<char> list)
        {
            int længde = list.Count();
           
            for (int i = 0; i < længde; i++)
            {
               if (list[i] == 'x')//tjekker på her index plads om "værdien" er x
                {
                    return true;
                }
               
            } return false;
          
        }
        //Opretter metode der giver gennemsnittet af en liste uden brug af AVG
        public static double GennemSnit(List<int> listeNavn)
        {
            int længde = listeNavn.Count();
            int sum = 0;
            double gennemsnit;
            for (int i = 0; i < længde; i++)
            {
                sum += listeNavn[i];//lægger værdien til totalsummen for hver gennemkørsel
            }
            return gennemsnit = (double)sum / (double)længde;
        }
        //Opretter metode der afgør om en liste er sorteret
        public static bool IsSortet(List<int> listeNavn)
        {
            int længde = listeNavn.Count(); //for at få længden på listen
            int count = 0;
            for (int i = 0; i < (længde-1); i++)
                {
                    if (listeNavn[i] > listeNavn[i+1])//tjekker for hvert gennemløb om det mindste står først, hvis ikke tælles count op
                    {
                        count++;
                    }
            }
            
            if (count > 0)
            {
                return false;
            }
            else return true;
                
            
        }

    }
}
