using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExample.Model
{
    class Employee
    {
        public int TZ { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }  
        public string Job { get; set; }
        public DateTime StartDate { get; set; }
        public bool HasAddress { get; set; }

        

        public Employee()
        {
        }
        public Employee(int tz, string firstName, string lastName, string job, DateTime startDate, bool hasAddress)
        { 
            this.TZ = tz;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Job = job;
            this.StartDate = startDate;
            this.HasAddress = hasAddress;

        }
    }
}
