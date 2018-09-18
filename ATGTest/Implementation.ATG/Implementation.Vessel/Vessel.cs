using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    static class Vessel
    {
        static public List<ATGVessel> getVessel(List<ATGObject> objects)
        {
            List<ATGVessel> vessel = new List<ATGVessel>();

            var temp = objects.OrderBy(x => x.Timestamp).ToList();

            foreach (ATGObject item in temp)
            {
                if (vessel.Where(x => (x.EndDate == item.Timestamp || x.EndDate.AddDays(1) == item.Timestamp) && x.Vessel == item.Vessel).Count() == 0)
                {
                    vessel.Add(new ATGVessel() { Vessel = item.Vessel, EndDate = item.Timestamp, StartDate = item.Timestamp });
                    vessel.First(x => x.StartDate == item.Timestamp && x.Vessel == item.Vessel).Objects.Add(item);
                }
                else
                {
                    vessel.First(x => (x.EndDate == item.Timestamp || x.EndDate.AddDays(1) == item.Timestamp) && item.Vessel == x.Vessel).EndDate = item.Timestamp;
                    vessel.First(x => x.EndDate == item.Timestamp && item.Vessel == x.Vessel).Objects.Add(item);
                }
            }

            return vessel;
        }
    }
}
