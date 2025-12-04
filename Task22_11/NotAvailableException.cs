using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22_11
{
    internal class NotAvailableException:Exception
    {
        public NotAvailableException():base("Room is not available"){}
        public NotAvailableException(string message)
       : base(message){}
    }
}
