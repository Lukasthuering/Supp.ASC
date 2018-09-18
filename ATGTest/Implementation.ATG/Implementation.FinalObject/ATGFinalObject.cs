using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    class ATGFinalObject
    {
        #region Members
        private int _kst;
        private string _status;
        private DateTime _startDate;
        private DateTime _endDate;
        private List<ATGObject> _objects;
        private List<int> _vessels;
        #endregion

        #region Properties
        public int KST
        {
            get { return _kst; }
            set { _kst = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
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
        public List<ATGObject> Objects
        {
            get { return _objects; }
            set { _objects = value; }
        }
        public List<int> Vessels
        {
            get { return _vessels; }
            set { _vessels = value; }
        }
        #endregion

        public ATGFinalObject()
        {
            Objects = new List<ATGObject>();
            Vessels = new List<int>();
        }
    }
}
