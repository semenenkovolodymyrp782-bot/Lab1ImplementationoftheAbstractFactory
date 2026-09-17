using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class ACoffee_tables
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public abstract string GetInfo();
    }
}
