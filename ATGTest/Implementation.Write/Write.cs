using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    static class Write
    {
        public static void writeResult(List<ATGResult> result)
        {
            var temp = result.OrderBy(x => x.Month);

            int datlofD = 0;
            int datlofS = 0;
            int datlofF = 0;

            foreach (var item in temp)
            {
                Console.WriteLine(item.Month.Month.ToString() + "." + item.Month.Year.ToString());
                Console.WriteLine("Störung");
                int i = item.Days.Where(x => x == 1).Count();
                datlofD += i;
                Console.WriteLine("1 \t\t" + i.ToString());
                i = item.Days.Where(x => x >= 2 && x <= 4).Count();
                datlofD += i;
                Console.WriteLine("2-4 \t\t" + i.ToString());
                i = item.Days.Where(x => x >= 5 && x <= 9).Count();
                datlofD += i;
                Console.WriteLine("5-9 \t\t" + i.ToString());
                i = item.Days.Where(x => x >= 10).Count();
                datlofD += i;
                Console.WriteLine(">10 \t\t" + i.ToString());
                Console.WriteLine("Stationen");
                i = item.Stations.Where(x => x == 1).Count();
                datlofS += i;
                Console.WriteLine("1 \t\t" + i.ToString());
                i = item.Stations.Where(x => x >= 2 && x <= 4).Count();
                datlofS += i;
                Console.WriteLine("2-4 \t\t" + i.ToString());
                i = item.Stations.Where(x => x >= 5 && x <= 9).Count();
                datlofS += i;
                Console.WriteLine("5-9 \t\t" + i.ToString());
                i = item.Stations.Where(x => x >= 10).Count();
                datlofS += i;
                Console.WriteLine(">10 \t\t" + i.ToString());
                Console.WriteLine("Fehlerart");
                i = item.Faults.Where(x => x.Contains("Wasser")).Count();
                datlofF += i;
                Console.WriteLine("Wasser \t\t" + i.ToString());
                i = item.Faults.Where(x => x.Contains("Peildaten nicht aktuell")).Count();
                datlofF += i;
                Console.WriteLine("Peildaten \t" + i.ToString());
                i = item.Faults.Where(x => x.Contains("0-Werte")).Count();
                datlofF += i;
                Console.WriteLine("0-Wert \t\t" + i.ToString());
                i = item.Faults.Where(x => x.Contains("Wertgleichheit")).Count();
                datlofF += i;
                Console.WriteLine("Gleichheit \t" + i.ToString());
                Console.WriteLine();
            }

            Console.WriteLine("Tage:" + datlofD.ToString());
            Console.WriteLine("Stationen:" + datlofS.ToString());
            Console.WriteLine("Fehler:" + datlofF.ToString());
            Console.WriteLine();
        }
    }
}
