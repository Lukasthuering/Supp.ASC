using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    static class Date
    {
        static public List<ATGDate> getDate(List<ATGObject> objects)
        {
            List<ATGDate> date = new List<ATGDate>();

            var temp = objects.OrderBy(x => x.Timestamp).ToList();

            foreach (ATGObject item in temp)
            {
                var tempDate = date.Where(x => (x.EndDate == item.Timestamp || x.EndDate.AddDays(1) == item.Timestamp) && x.StartDate.Month == item.Timestamp.Month);
                if (tempDate.Count() == 0)
                {
                    date.Add(new ATGDate() { StartDate = item.Timestamp, EndDate = item.Timestamp });
                    date.First(x => x == tempDate.First()).Objects.Add(item);
                }
                else
                {
                    date.First(x => x == tempDate.First()).EndDate = item.Timestamp;
                    date.First(x => x == tempDate.First()).Objects.Add(item);
                }
            }

            return date;
        }
    }
}
