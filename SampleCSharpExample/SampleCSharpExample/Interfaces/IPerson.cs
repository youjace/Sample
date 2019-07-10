using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCSharpExample.Interfaces
{
    public interface IPerson
    {
        string PersonId { get; set; }
        string FullName { get; set; }
        int Salary { get; set; }
        string JobPosition { get; set; }
        string CompanyName { get; set; }
        string SchoolName { get; set; }

        string DoWork();
        string DoSelfIntroduction();
        string ShowSalary();
    }
}
