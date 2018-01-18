using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jason.Models
{
    class Option
    {
        public string name { get; set; }
        public string sex { get; set; }

        public override string ToString()
        {
            return $"Name:{name}, Sex:{sex}";
        }
    }
}