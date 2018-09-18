using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    class FinalObject
    {
        public static List<ATGFinalObject> getFinalObject(List<ATGVessel> objects)
        {
            List<ATGFinalObject> finalObjects = new List<ATGFinalObject>();

            foreach (ATGVessel item in objects)
            {
                var temp = item.Objects.First();
                var templist = finalObjects.Where(x => x.KST == temp.KST && x.Status == temp.Status && x.EndDate == item.EndDate && x.StartDate == item.StartDate && !x.Vessels.Contains(item.Vessel));

                if (templist.Count() != 0)
                {
                    templist.First().Objects.AddRange(item.Objects);
                    templist.First().Vessels.Add(item.Vessel);
                }
                else
                {
                    ATGFinalObject tempObject = new ATGFinalObject() { KST = temp.KST, Status = temp.Status, EndDate = item.EndDate, StartDate = item.StartDate };
                    tempObject.Vessels.Add(item.Vessel);
                    tempObject.Objects.AddRange(item.Objects);

                    finalObjects.Add(tempObject);
                }
            }

            return finalObjects;
        }
    }
}
