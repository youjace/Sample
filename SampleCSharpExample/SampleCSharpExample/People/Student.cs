using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleCSharpExample.People
{   
    sealed class Student : PersonBase
    {
        public override string DoSelfIntroduction()
        {
            return string.Format("Hi my name is {0}, I'm a student at {1}.", FullName, SchoolName);
        }
    }
}
