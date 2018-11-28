using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinitum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> options = new List<string>();

            options.Add("Play");
            options.Add("Quit");

            int selectedOption = 0;

            Console.CursorVisible = false;

            while (true)
            {

                Console.Clear();
                for (int i = 0; i < options.Count; i++)
                {
                    if (i == selectedOption)
                    {
                        Console.Write(">");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine(options[i]);
                }

                ConsoleKeyInfo keyPress = Console.ReadKey();
                if (keyPress.Key == ConsoleKey.UpArrow)
                {
                    selectedOption--;
                    if (selectedOption < 0)
                    {
                        selectedOption = options.Count - 1;
                    }
                }
                else if (keyPress.Key == ConsoleKey.DownArrow)
                {
                    selectedOption++;
                    if (selectedOption >= options.Count)
                    {
                        selectedOption = 0;
                    }
                }
                else if (keyPress.Key == ConsoleKey.Enter)
                {

                    if (selectedOption == 0)
                    {
                        Console.WriteLine("Sorry! No game to play!");
                        Console.ReadLine();
                    }

                    if (selectedOption == 1)
                    {
                        Console.WriteLine("Thanks for playing!");
                        Console.ReadLine();
                        return;
                    }

                }

            }

        }
    }
}
