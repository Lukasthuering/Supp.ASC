using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    class ATGResult
    {
        #region Members
        private DateTime _month;
        private List<int> _days;
        private List<int> _stations;
        private List<string> _faults;
        #endregion

        #region Properties
        public DateTime Month
        {
            get { return _month; }
            set { _month = value; }
        }
        public List<int> Days
        {
            get { return _days; }
            set { _days = value; }
        }
        public List<int> Stations
        {
            get { return _stations; }
            set { _stations = value; }
        }
        public List<string> Faults
        {
            get { return _faults; }
            set { _faults = value; }
        }
        #endregion

        public ATGResult()
        {
            Days = new List<int>();
            Stations = new List<int>();
            Faults = new List<string>();
        }
    }
}
