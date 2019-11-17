using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaiidManagementApp
{
    public class Bid
    {
        public string Character;
        public string Item;
        public int? Amount;
        public string modifiers;
        private string _altname;
        private bool _forAlt = false;
        public bool forAlt
        {
            get
            {
                return _forAlt;
            }
            set
            {
                _forAlt = value;
            }
        }

        public string BidFor
        {
            get
            {
                return _altname;
            }
            set
            {
                _altname = value;
            }
        }
    }
}
