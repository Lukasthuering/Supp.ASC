using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ATGTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            // Objekte erstellen
            List<ATGObject> atgobjectlist = new List<ATGObject>();
            List<ATGResult> result = new List<ATGResult>();
            string atgListDirectory = "";
            bool hasPath = false;

            while (!hasPath)
            {
                atgListDirectory = getPath(atgListDirectory);
                hasPath = testPath(atgListDirectory);
            }

            //Debug Stopwatch
            stopwatch.Start();

            // ATG-Objekte aus ATG-Excel-Sheet auslesen
            atgobjectlist = ReadExcel.getData(atgListDirectory);

            // Die Finalen ATG-Objekte erstellen
            // @TLU Das sind die Antworten, mit denen du arbeitest
            result = ATG.createATG(atgobjectlist);

            // Ausgabe der Resultate
            // @TLU Das ist der Teil, den du ändern solltest
            Write.writeResult(result);

            //Debug Stopwatch
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.ToString());

            Console.ReadLine();
        }

        static private string getPath(string atgListDirectory)
        {
            Console.Clear();
            Console.WriteLine("*****************************************");
            Console.WriteLine("Debug Version des ATG-Statistik Programms");
            Console.WriteLine("*****************************************");
            Console.WriteLine();

            Console.WriteLine("Geben Sie den Pfad an:");
            atgListDirectory = Console.ReadLine();
            if (!atgListDirectory.Contains(".xlsx"))
                atgListDirectory = atgListDirectory + "\\ATG-Statistiken.xlsx";
            Console.WriteLine();

            Console.WriteLine("*****************************************");
            Console.WriteLine("Debug Version des ATG-Statistik Programms");
            Console.WriteLine("*****************************************");
            Console.WriteLine();

            return atgListDirectory;
        }

        static private bool testPath(string atgListDirectory)
        {
            return File.Exists(atgListDirectory);
        }
    }
}
