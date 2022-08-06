using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrieeX.GrieeXBase
{
    public class ComboList
    {
        private string _Display;
        private int _AlternateId;
        private int _ID;
        private int _Index = -1;

        public string Display
        {
            get { return _Display; }
            set { _Display = value; }
        }

        public int AlternateId
        {
            get { return _AlternateId; }
            set { _AlternateId = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }

        public ComboList()
            : base()
        {
        }

        public ComboList(string display)
        {
            this.Display = display;
        }

        public ComboList(string display, int id)
        {
            this.Display = display;
            this.ID = id;
        }

        public ComboList(string display, int altid, int id)
        {
            this.Display = display;
            this.AlternateId = altid;
            this.ID = id;
        }

        public ComboList(string display, int altid, int id, int index)
        {
            this.Display = display;
            this.AlternateId = altid;
            this.ID = id;
            this.Index = index;
        }

    }
}
