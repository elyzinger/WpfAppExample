using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppExample.Model;

namespace WpfAppExample.ViewModels
{
    class ShellViewModel : Screen
    {
        private string firstName ;
        private string lastName;
        private Employee employee;
        private BindableCollection<Employee> employees = new BindableCollection<Employee>();
        

        public ShellViewModel()
        {
            Employees.Add(new Employee {TZ = 1234, FirstName = "איליי", LastName="שי", Job = "מתכנת", StartDate = DateTime.Now , HasAddress = true});
            Employees.Add(new Employee { TZ = 111, FirstName = "אלעד", LastName = "רמי", Job = "חשב שכר", StartDate = DateTime.Now, HasAddress = true });
            Employees.Add(new Employee { TZ = 222, FirstName = "חיים", LastName = "זאב", Job = "מנקה", StartDate = DateTime.Now, HasAddress = true });
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value;
                NotifyOfPropertyChange(() => lastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public BindableCollection<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public Employee Employee
        {
            get { return employee; }
            set { employee = value;
                NotifyOfPropertyChange(() => Employee);
            }
        }

        public string FullName
        {
            get { return $"{ FirstName} { LastName}"; }
        }

        public bool CanbtnSave(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
                return false;
            return true;
                
            
        }
        public void btnSave(string firstName, string lastName)
        {
            //save to db
        }
    }
}
