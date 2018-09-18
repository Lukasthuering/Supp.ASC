using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    class ATGDate
    {
        #region Members
        private DateTime _startDate;
        private DateTime _endDate;
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
        public List<ATGObject> Objects
        {
            get { return _objects; }
            set { _objects = value; }
        }
        #endregion

        public ATGDate()
        {
            Objects = new List<ATGObject>();
        }
    }
}