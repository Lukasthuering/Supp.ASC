using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    static class Result
    {
        static public List<ATGResult> getResults(List<ATGFinalKST> objects)
        {
            List<ATGResult> results = new List<ATGResult>();

            foreach (var item in objects)
            {
                if (results.Where(x => x.Month.Month == item.Month.Month && x.Month.Year == item.Month.Year).Count() == 0)
                {
                    results.Add(new ATGResult() { Month = new DateTime(item.Month.Year, item.Month.Month, 1) });
                }

                results.First(x => x.Month.Month == item.Month.Month && x.Month.Year == item.Month.Year).Stations.Add(item.Objects.Count());
                foreach (var i in item.Objects)
                {
                    results.First(x => x.Month.Month == item.Month.Month && x.Month.Year == item.Month.Year).Faults.Add(i.Status);
                    int asdfdsa = (i.Vessels.Count());
                    results.First(x => x.Month.Month == item.Month.Month && x.Month.Year == item.Month.Year).Days.Add(i.Objects.Count() / i.Vessels.Count());
                }
            }

            return results;
        }
    }
}
