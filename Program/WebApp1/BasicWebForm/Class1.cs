using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicWebForm
{
    public class Class1
    {
        private int _age;

        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }

        public int Age2 { get; set; }

    }
}