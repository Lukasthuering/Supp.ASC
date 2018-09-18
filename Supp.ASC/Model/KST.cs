using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    static class KST
    {
        static public List<ATGKST> getKST(List<ATGObject> objects)
        {
            List<ATGKST> locations = new List<ATGKST>();
            foreach (ATGObject item in objects)
            {
                if (locations.Where(x => x.KST == item.KST).Count() == 0)
                    locations.Add(new ATGKST() { KST = item.KST });
                locations.First(y => y.KST == item.KST).Objects.Add(item);
            }
            return locations;
        }
    }
}
