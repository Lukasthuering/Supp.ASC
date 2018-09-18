using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    class ATGStatus
    {
        #region Members
        private string _status;
        private List<ATGObject> _objects;
        #endregion

        #region Properties
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public List<ATGObject> Objects
        {
            get { return _objects; }
            set { _objects = value; }
        }
        #endregion

        public ATGStatus()
        {
            Objects = new List<ATGObject>();
        }
    }
}
