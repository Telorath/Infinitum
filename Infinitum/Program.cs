using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinitum
{
    class Program
    {
        static List<string> options = new List<string>();
        static int selectedOption = 0;
        static bool playing = true;

        public static int SelectedOption
        {
            get { return selectedOption; }
            set {
                selectedOption = value;
                if (selectedOption >= options.Count)
                {
                    selectedOption = 0;
                }
                if (selectedOption < 0)
                {
                    selectedOption = options.Count - 1;
                }
            }
        }

        static void Display()
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
        }

        static void SelectOption()
        {
                if (selectedOption == 0)
                {
                    Console.WriteLine("Sorry! No game to play!");
                    Console.ReadLine();
                }

                if (selectedOption == 1)
                {
                    playing = false;
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                    return;
                }
        }

        static void GetInput()
        {
            ConsoleKeyInfo keyPress = Console.ReadKey();
            if (keyPress.Key == ConsoleKey.UpArrow)
            {
                SelectedOption--;
            }
            else if (keyPress.Key == ConsoleKey.DownArrow)
            {
                SelectedOption++;
            }
            else if (keyPress.Key == ConsoleKey.Enter)
            {

                SelectOption();

            }
        }

        static void Main(string[] args)
        {
            options.Add("Play");
            options.Add("Quit");

            Console.CursorVisible = false;

            while (playing)
            {

                Display();

                GetInput();

            }

        }
    }
}
