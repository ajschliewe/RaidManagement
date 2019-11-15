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

        public bool forAlt
        {
            get
            {
                if (modifiers.IndexOf("alt") > -1) { return true; } else { return false; }
            }
        }
    }
}
