using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_algo
{
    class Program
    {
        static void Main(string[] args)
        {
            int reponse = 0;
            char[] group1 =
            {
                'A',
                'B'
            };

            char[] group2 =
{
                'C',
                'D'
            };

            char[] group3 =
            {
                'E',
                'F'
            };
                
            char[][] grosTableau =
            {
                group1,
                group2,
                group3,
            };


            Console.WriteLine("Dans quel ordre voulez - vous lire l'alphabet?");
            Console.WriteLine("1 - Dans l'ordre normal");
            Console.WriteLine("2 - En partant de la fin");
            Console.WriteLine("3 - Les lettres de gauche puis les lettres de droite");
            Console.WriteLine("4 - Les lettres de droite puis les lettres de gauche");

            reponse = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (reponse == 1)
            {
                for(int i = 0; i<grosTableau.Length; i++)
                {
                    for(int j = 0; j<grosTableau[i].Length;j++)
                    {
                        Console.WriteLine(grosTableau[i][j]);
                    }                                 
                }
            }
            else if(reponse == 2)
            {
                for (int i = grosTableau.Length - 1; i >= 0; i--)
                { 
                    for (int j = grosTableau[i].Length - 1; j >= 0; j--)
                    {
                        Console.WriteLine(grosTableau[i][j]);
                    }
                }
            }
            else if(reponse == 3)
            {
                for (int i = 0; i <= 1; i++)
                {
                    for (int j = 0; j < grosTableau.Length; j++)
                    {
                        Console.WriteLine(grosTableau[j][i]);
                    }
                }
            }
            else if(reponse == 4)
            {
                for (int i = 1; i >= 0; i--)
                {
                    for (int j = 0; j < grosTableau.Length; j++)
                    {
                        Console.WriteLine(grosTableau[j][i]);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}


