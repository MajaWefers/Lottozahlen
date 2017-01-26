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
            string antwort = "";

            do
            {

                System.Random zufall = new System.Random();
                int[] lotto_ausgabe = new int[7];

                for (int i = 0; i < 6; i++)
                {
                    int currentChoice;
                    do
                    {
                        currentChoice = zufall.Next(1, 50);
                    }   while (lotto_ausgabe.Contains(currentChoice));

                    lotto_ausgabe[i] = currentChoice;
                    
                    Console.WriteLine("Zahl " + (i + 1) + ": " + lotto_ausgabe[i]);
                }

                int superzahl = zufall.Next(1, 9);
                lotto_ausgabe[6] = superzahl;
                Console.WriteLine("\nSuperzahl: " + superzahl);

                //Ausgabe der gesamten Array-Indexwerte mit Komma getrennt
                Console.Write("\nArraywerte: " + String.Join(", ",lotto_ausgabe) + "\n");

                Console.WriteLine("\nNoch einmal? [j/n]");
                antwort = Console.ReadLine();
                Console.WriteLine();
            }
            while (antwort != "n");


        }
    }
}