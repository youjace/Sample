using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SampleCSharpExample.People
{
    sealed class Customer : PersonBase
    {
        public override string DoSelfIntroduction()
        {
            return string.Format("Hi my name is {0}, I'm a Customer.", FullName);
        }

        public override string DoWork()
        {
            return string.Format("I'm a business man. I own {0}.", CompanyName);
        }
        public override string ShowSalary()
        {
            return "My business earns $1M a month.";
        }
    }
}
