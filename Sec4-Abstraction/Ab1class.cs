using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec4_Abstraction
{
    public abstract class Ab1class
    {
        private string name;

        abstract public string getName();

        public void setName(string name)
        {
            //Comment Here
            this.name = name;

            return;
        }

    }
}
