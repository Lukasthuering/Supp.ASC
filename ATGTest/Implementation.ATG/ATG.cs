using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    static class ATG
    {
        public static List<ATGResult> createATG(List<ATGObject> atgobjectlist)
        {
            List<ATGKST> locations = new List<ATGKST>();
            List<ATGStatus> status = new List<ATGStatus>();
            List<ATGDate> date = new List<ATGDate>();
            List<ATGVessel> vessel = new List<ATGVessel>();
            List<ATGFinalObject> finalObject = new List<ATGFinalObject>();
            List<ATGFinalKST> finalKST = new List<ATGFinalKST>();
            List<ATGResult> result = new List<ATGResult>();

            locations = KST.getKST(atgobjectlist);
            foreach (ATGKST item in locations)
            {
                status.AddRange(Status.getStatus(item.Objects));
            }

            foreach (ATGStatus item in status)
            {
                date.AddRange(Date.getDate(item.Objects));
            }

            foreach (ATGDate item in date)
            {
                vessel.AddRange(Vessel.getVessel(item.Objects));
            }

            finalObject = FinalObject.getFinalObject(vessel);

            finalKST = FinalKST.getFinalKST(finalObject);
            result = Result.getResults(finalKST);

           return result;
        }
    }
}
