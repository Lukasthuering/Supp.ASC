using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    class ATGFinalKST
    {
        #region Members
        private DateTime _month;
        private int _kst;
        private List<ATGFinalObject> _objects;
        #endregion

        #region Properties
        public DateTime Month
        {
            get { return _month; }
            set { _month = value; }
        }
        public int KST
        {
            get { return _kst; }
            set { _kst = value; }
        }
        public List<ATGFinalObject> Objects
        {
            get { return _objects; }
            set { _objects = value; }
        }
        #endregion

        public ATGFinalKST()
        {
            Objects = new List<ATGFinalObject>();
        }
    }
}
