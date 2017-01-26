using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Created by SharpDevelop.
 * User: fia63bloemer
 * Date: 19.12.2016
 * Time: 11:33
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Lottozahlen
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lottozahlen\n");
            string[,] KW_52 = new string[2,52];
            char antwort = ' ';

            System.Random zufall = new System.Random();

            do
            {
                for (int j = 1; j <= 52; j++)
                {
                    int[] lotto_ausgabe = new int[7];
                    KW_52[0, j - 1] = j.ToString();

                    for (int i = 0; i < 6; i++)
                    {
                        int currentChoice;
                        do
                        {
                            currentChoice = zufall.Next(1, 50);
                        } while (lotto_ausgabe.Contains(currentChoice));

                        lotto_ausgabe[i] = currentChoice;
                    } //for Lottozahlen

                    int superzahl = zufall.Next(1, 10);
                    lotto_ausgabe[6] = superzahl;

                    //Arraywerte in zweiter Spalte speichern
                    KW_52[1, j - 1] = "Lottozahlen: " + String.Join(", ", lotto_ausgabe);

                    //Ausgabe
                    Console.Write("KW " + KW_52[0, j - 1] + " -> " + KW_52[1, j - 1] + "\n");
                } //for KW
                Console.WriteLine("\nNoch einmal? (j/n)");
                antwort = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (antwort != 'n');

            Console.ReadKey();
            }

        }
    }