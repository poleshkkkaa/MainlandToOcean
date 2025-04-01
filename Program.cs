using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace лаба4__1
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Planet earth = new Planet();

            bool restart;
            do
            {
                restart = false;
                earth.PrintPlanetName();
                earth.PrintContinentCount();

                string input;
                do
                {
                    Console.Write("\nВведіть назву материка: ");
                    input = Console.ReadLine();

                    if (!earth.ContinentExists(input))
                    {
                        Console.WriteLine("Невірна назва материка! Спробуйте ще раз.");
                    }
                } while (!earth.ContinentExists(input));

                earth.PrintContinentInfo(input);

                while (true)
                {
                    Console.Write("\nБажаєте продовжити? (yes/no): ");
                    string answer = Console.ReadLine().Trim().ToLower();

                    if (answer == "так" || answer == "yes")
                    {
                        restart = true;
                        break;
                    }
                    else if (answer == "ні" || answer == "no")
                    {
                        restart = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Невірний ввід. Введіть 'так/ні' 'yes/no'.");
                    }
                }
            } while (restart);
        }
    }
}