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

            Write("Enter a noun:  ");
            entry1 = ReadLine();
            WriteLine();

            Write("Enter a noun:  ");
            entry2 = ReadLine();
            WriteLine();

            Write("Enter a verb:  ");
            entry3 = ReadLine();
            WriteLine();

            Write("Enter a noun:  ");
            entry4 = ReadLine();
            WriteLine();

            Write("Enter a verb:  ");
            entry5 = ReadLine();
            WriteLine();

            Write("Enter a noun:  ");
            entry6 = ReadLine();
            WriteLine();

            Write("Enter an adverb:  ");
            entry7 = ReadLine();
            WriteLine();

            Write("Enter a verb:  ");
            entry8 = ReadLine();
            WriteLine();

            Write("Enter an adjective:  ");
            entry9 = ReadLine();
            WriteLine();

            Write("Enter a noun:  ");
            entry10 = ReadLine();

            Clear();

            WriteLine("Creating your story...");

            Beep(950, 100);
            Beep(700, 100);
            Beep(600, 100);
            Beep(700, 100);
            Beep(950, 100);

            Clear();

            WriteLine($"This morning I saw a {entry1} in a {entry2}.");
            WriteLine($"The first thing I wanted to do was {entry3} a {entry4},");
            WriteLine($"but thought the more reasonable act would be to {entry5}.");
            WriteLine($"So I grabbed the closest {entry6} and {entry7} began to {entry8} it.");
            WriteLine($"Only then did I realize that there was a(n) {entry9} {entry10}");
            WriteLine("wateching from afar.");
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
