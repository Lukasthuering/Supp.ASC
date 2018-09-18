using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    class ATGVessel
    {
        #region Members
        private DateTime _startDate;
        private DateTime _endDate;
        private int _vessel;
        private List<ATGObject> _objects;
        #endregion

        #region Properties
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        public int Vessel
        {
            get { return _vessel; }
            set { _vessel = value; }
        }
        public List<ATGObject> Objects
        {
            get { return _objects; }
            set { _objects = value; }
        }
        #endregion

        public ATGVessel()
        {
            Objects = new List<ATGObject>();
        }
    }
}
