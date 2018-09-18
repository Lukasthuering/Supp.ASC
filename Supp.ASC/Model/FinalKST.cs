using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    static class FinalKST
    {
        static public List<ATGFinalKST> getFinalKST(List<ATGFinalObject> objects)
        {
            List<ATGFinalKST> finalKST = new List<ATGFinalKST>();

            foreach (var item in objects)
            {
                if (finalKST.Where(x => x.KST == item.KST && x.Month.Month == item.EndDate.Month && x.Month.Year == item.EndDate.Year).Count() == 0)
                {
                    finalKST.Add(new ATGFinalKST() { KST = item.KST, Month = item.EndDate });
                }
                finalKST.First(x => x.KST == item.KST && x.Month.Month == item.EndDate.Month && x.Month.Year == item.EndDate.Year).Objects.Add(item);
            }

            return finalKST;
        }
    }
}
