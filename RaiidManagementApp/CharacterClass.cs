using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaiidManagementApp
{
    public class Character
    {
        private string _Name;
        private string _ClassName;
        private string _ParentName;
        private string _StatusName;

        public Character()
        {
        }

        public Character(string Name)
        {
            this._Name = Name;
        }
        public Character(string Name, string Classname, string parent, string status)
        {
            this._Name = Name;
            this._ClassName = Classname;
            this._ParentName = parent;
            this._StatusName = status;
        }
        public Character(string Name, string parent, string status)
        {
            this._Name = Name;
            this._ParentName = parent;
            this._StatusName = status;
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }

        }
        public string ClassName
        {
            get { return _ClassName; }
            set { _ClassName = value; }
        }
        public string ParentName
        {
            get { return _ParentName; }
            set { _ParentName = value; }
        }
        public string StatusName
        {
            get { return _StatusName; }
            set { _StatusName = value; }
        }
    }
}
