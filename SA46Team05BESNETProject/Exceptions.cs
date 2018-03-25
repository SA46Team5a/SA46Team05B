using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA46Team05BESNETProject
{
    public class ItemNotFound : ApplicationException
    {
        public ItemNotFound() { }
        public ItemNotFound(string message) : base(message) { }
    }

    public class InvalidID : ApplicationException
    {
        public InvalidID() { }
        public InvalidID(string message) : base(message) { }
    }

    class Exceptions
    {

    }
}
