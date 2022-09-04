using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStock.Service.Exceptions
{
    public class CountNotEnoughException:Exception
    {
        public CountNotEnoughException(string message):base(message)
        {

        }
    }
}
