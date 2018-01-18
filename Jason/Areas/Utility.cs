using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jason.Areas
{
    public class Utility
    {
        public static String GetJFile()
        {
            String jFileText = File.ReadAllText("D:\\VS Projects\\MicrosoftVA\\Jason\\Models\\Option.cs");

            return jFileText;
        }
    }
}