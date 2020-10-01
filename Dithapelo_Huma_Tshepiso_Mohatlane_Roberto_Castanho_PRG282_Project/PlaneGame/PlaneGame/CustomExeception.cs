using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Simulations_Project_PRG252
{
    class CustomExeception : Exception
    {
        public CustomExeception()
        {

        }
        public CustomExeception(string message) : base(message)
        {

        }
        public CustomExeception(string message, Exception InnerException) : base(message, InnerException)
        {

        }
    }
}
