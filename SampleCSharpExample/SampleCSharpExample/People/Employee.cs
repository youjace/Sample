using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleCSharpExample.Enums;

namespace SampleCSharpExample.People
{
    sealed class Employee : PersonBase
    {
        public override string DoSelfIntroduction()
        {
            return string.Format("Hi my name is {0}, I'm a {1} at {2}", FullName, JobPosition, CompanyName);
        }

        public override string DoWork()
        {
            if(JobPosition == "Clerk")
                return "I do clerical work.";

            if (JobPosition == "Manager")
                return "I do managerial work";
            else
                return string.Empty;
        }
        public override string ShowSalary()
        {
            return string.Format("I earn ${0} a month", Salary);
        }
    }
}
