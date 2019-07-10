using SampleCSharpExample.Interfaces;
using SampleCSharpExample.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCSharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;

            while (!stop)
            {
                string id;
                Console.WriteLine("Start a quick chat with:");
                Console.WriteLine("[1] Peter Parker");
                Console.WriteLine("[2] Bruce Wayne");
                Console.WriteLine("[3] Jon Snow");
                Console.WriteLine("[4] Harry Potter");

                id = Console.ReadLine();
                IPerson person = null;
                if (id == "1")
                {

                    person = PersonCreator.Create<Student>(id, "Peter Parker", "UST");
                }
                else if(id == "2")
                {
                    person = PersonCreator.Create<Customer>(id, "Bruce Wayne","","San Miguel");
                }
                else if (id == "3")
                {
                    person = PersonCreator.Create<Employee>(id, "Jon Snow","","SMDC",3000,"Manager");
                }
                else if (id == "4")
                {
                    person = PersonCreator.Create<Employee>(id, "Harry Potter", "", "SMDC",1500,"Clerk");
                }


                Console.WriteLine(person.DoSelfIntroduction());
                    Console.WriteLine(person.DoWork());
                    Console.WriteLine(person.ShowSalary());
       

                Console.WriteLine("Do another chat? (Enter Y if Yes)");
                stop = Console.ReadLine().ToUpper() == "Y" ? false : true;
            }
            

        }
        
    }
    public abstract class PersonBase : IPerson
    {
        public string PersonId { get; set; }
        public string FullName { get; set; }
        public int Salary { get; set; }
        public string JobPosition { get; set; }
        public string CompanyName { get; set; }
        public string SchoolName { get; set; }

        public virtual string DoWork() { return "I don't work yet"; }
        public abstract string DoSelfIntroduction();
        public virtual string ShowSalary() { return "I don't have a salary"; }

    }
    internal sealed class PersonCreator
    {
        public static IPerson Create<T> (string personId, string fullName, string schoolName ="", string companyName = "", int salary = 0, string jobPosition = "None" ) where T : new ()
        {
            dynamic result = new T();
            result.PersonId = personId;
            result.FullName = fullName;
            result.SchoolName = schoolName;
            result.CompanyName = companyName;
            result.Salary = salary;
            result.JobPosition = jobPosition;

            return (IPerson)result;
        }
    }
}
