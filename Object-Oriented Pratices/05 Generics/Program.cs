using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Object_Oriented_Pratices
{
    class ProgramoNE
    {
        static void Main(string[] args)
        {
            var jSer= new JsonSerializer();
            jSer.Converters.Add(new JavaScriptDateTimeConverter());
            jSer.NullValueHandling = NullValueHandling.Ignore;

            StringBuilder sB = new StringBuilder();
            sB.Append("<Html>Test DC</Html>");

            using (JsonWriter jW = new JsonTextWriter(sB))
            {
                var Html = File.ReadAllLines;
                
            }
        }
    }
}
