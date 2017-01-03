using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Client : IClient
    {
        public string Name { get; set; }

        private ArrayList applications = new ArrayList();

        public void AddApplication(string application)
        {
            applications.Add(application);
        }

        public void DelApplication(string application)
        {
            throw new NotImplementedException();
        }
    }
}
