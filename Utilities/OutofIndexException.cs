using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask6422.Utilities
{
    class OutofIndexException:Exception
    {
        public OutofIndexException(string message) : base(message)
        {

        }
    }
}
