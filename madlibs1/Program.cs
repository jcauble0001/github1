using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace madlibs1
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry1, entry2, entry3, entry4, entry5, entry6, entry7, entry8, entry9, entry10;

            BackgroundColor = ConsoleColor.DarkGray;
            ForegroundColor = ConsoleColor.White;
            WriteLine("MAD LIBS");

            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Press any key to play.");

            ReadKey();

            Clear();

            BackgroundColor = ConsoleColor.DarkGray;
            ForegroundColor = ConsoleColor.White;

            WriteLine("Get ready!");

            Beep(600, 450);
            Beep(700, 550);
            Beep(950, 650);

            BackgroundColor = ConsoleColor.DarkGray;
            ForegroundColor = ConsoleColor.White;

            Clear();

            Write("Enter a proper noun:  ");
            entry1 = ReadLine();
            WriteLine();

            Write("Enter a verb:  ");
            entry2 = ReadLine();
            WriteLine();

            Write("Enter a noun:  ");
            entry3 = ReadLine();
            WriteLine();

            Write("Enter an adjective :  ");
            entry4 = ReadLine();
            WriteLine();

            Write("Enter a noun:  ");
            entry5 = ReadLine();
            WriteLine();

            Write("Enter a verb:  ");
            entry6 = ReadLine();
            WriteLine();

            Write("Enter an adjective:  ");
            entry7 = ReadLine();
            WriteLine();

            Write("Enter a noun:  ");
            entry8 = ReadLine();
            WriteLine();

            Write("Enter an adverb:  ");
            entry9 = ReadLine();
            WriteLine();

            Write("Enter a noun:  ");
            entry10 = ReadLine();

            Clear();

            WriteLine("Creating your story...");

            Beep(950, 150);
            Beep(700, 150);
            Beep(600, 150);
            Beep(700, 150);
            Beep(950, 150);

            Clear();

            WriteLine($"His name was {entry1}");

            int a = 0;
            while (a < 3)
            {
                WriteLine();
                a++;
            }
            WriteLine("Press any key to terminate the program.");
            ReadKey();

        }
    }
}
