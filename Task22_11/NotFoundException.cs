using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22_11
{
    internal class NotFoundException:Exception
    {
        public NotFoundException() : base("Room is not found"){ }
        public NotFoundException(string message) : base(message){ }
    }
}
