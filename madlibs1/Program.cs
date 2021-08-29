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

            Write($"This morning I saw a ");
            ForegroundColor = ConsoleColor.Yellow;
            Write($"{entry1} ");
            ForegroundColor = ConsoleColor.White;
            Write($"in a ");
            ForegroundColor = ConsoleColor.Yellow;
            Write($"{entry2}");
            ForegroundColor = ConsoleColor.White;
            WriteLine($".");
            Write($"The first thing I wanted to do was ");
            ForegroundColor = ConsoleColor.Yellow;
            Write($"{entry3} ");
            ForegroundColor = ConsoleColor.White;
            Write($"a ");
            ForegroundColor = ConsoleColor.Yellow;
            Write($"{entry4}");
            ForegroundColor = ConsoleColor.White;
            WriteLine($",");
            Write($"but thought the more reasonable act would be to ");
            ForegroundColor = ConsoleColor.Yellow;
            Write($"{entry5}");
            ForegroundColor = ConsoleColor.White;
            WriteLine($".");
            Write($"So I grabbed the closest ");
            ForegroundColor = ConsoleColor.Yellow;
            Write($"{entry6} ");
            ForegroundColor = ConsoleColor.White;
            Write($"and ");
            ForegroundColor = ConsoleColor.Yellow;
            Write($"{entry7} ");
            ForegroundColor = ConsoleColor.White;
            Write($"began to ");
            ForegroundColor = ConsoleColor.Yellow;
            Write($"{entry8} ");
            ForegroundColor = ConsoleColor.White;
            WriteLine("it.");
            Write($"Only then did I realize that there was a(n) ");
            ForegroundColor = ConsoleColor.Yellow;
            Write($"{entry9} {entry10} ");
            ForegroundColor = ConsoleColor.White;
            WriteLine("watching from afar.");
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
