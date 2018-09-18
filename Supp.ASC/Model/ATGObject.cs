using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATGTest
{
    class ATGObject
    {
        #region Members
        private int _kst;
        private string _location;
        private DateTime _timestamp;
        private int _vessel;
        private string _product;
        private double _dipping;
        private double _waterlevel;
        private double _temperature;
        private double _price;
        private string _status;
        private string text;
        #endregion

        #region Properties
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public int KST
        {
            get { return _kst; }
            set { _kst = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        public DateTime Timestamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }
        public int Vessel
        {
            get { return _vessel; }
            set { _vessel = value; }
        }
        public string Product
        {
            get { return _product; }
            set { _product = value; }
        }
        public double Dipping
        {
            get { return _dipping; }
            set { _dipping = value; }
        }
        public double Waterlevel
        {
            get { return _waterlevel; }
            set { _waterlevel = value; }
        }
        public double Temperature
        {
            get { return _temperature; }
            set { _temperature = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion
    }
}
