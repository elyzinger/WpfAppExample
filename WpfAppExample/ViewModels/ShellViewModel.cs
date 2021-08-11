using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExample.ViewModels
{
    class ShellViewModel : Screen
    {
        private string firstName ;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value;
                NotifyOfPropertyChange(() => lastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get { return $"{ FirstName} { LastName}"; }
        }

    }
}
