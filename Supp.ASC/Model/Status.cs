using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    static class Status
    {
        static public List<ATGStatus> getStatus(List<ATGObject> objects)
        {
            List<ATGStatus> status = new List<ATGStatus>();
            foreach (ATGObject item in objects)
            {
                if (status.Where(x => x.Status == item.Status).Count() == 0)
                    status.Add(new ATGStatus() { Status = item.Status });
                status.First(y => y.Status == item.Status).Objects.Add(item);
            }
            return status;
        }
    }
}
