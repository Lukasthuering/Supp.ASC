using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    class ATGKST
    {
        #region Members
        private int _kst;
        private List<ATGObject> _objects;
        #endregion

        #region Properties
        public int KST
        {
            get { return _kst; }
            set { _kst = value; }
        }
        public List<ATGObject> Objects
        {
            get { return _objects; }
            set { _objects = value; }
        }
        #endregion

        public ATGKST()
        {
            Objects = new List<ATGObject>();
        }
    }
}
