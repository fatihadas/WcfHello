using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonService
{
    public class Service : IService
    {
        public void DoWork()
        {

        }

        public string SayHi(string name)
        {
            return "Merhaba " + name;
        }
    }
}