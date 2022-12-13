using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Formularz
{
    public class PracaException : Exception
    {

        public PracaException(string message)
            : base(message)
        {

        }
    }
    public class StudentException : Exception
    {

        public StudentException( string message)
            : base(message)
        {

        }
    }
    public class UczelniaException : Exception
    {

        public UczelniaException( string message)
            : base(message)
        {

        }
    }
}
