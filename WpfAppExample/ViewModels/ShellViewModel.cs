
using ApiLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using WpfAppExample.Model;

namespace WpfAppExample.ViewModels
{
    class ShellViewModel 
    {
        private string firstName ;
        private string lastName;
        private Employee employee;
        private Currency currency;
        //private BindableCollection<Employee> employees = new BindableCollection<Employee>();
        
        public List<double> MyProperty { get; set; }

        public ShellViewModel()
        {
            //Employees.Add(new Employee {TZ = 1234, FirstName = "איליי", LastName="שי", Job = "מתכנת", StartDate = DateTime.Now , HasAddress = true});
            //Employees.Add(new Employee { TZ = 111, FirstName = "אלעד", LastName = "רמי", Job = "חשב שכר", StartDate = DateTime.Now, HasAddress = true });
            //Employees.Add(new Employee { TZ = 222, FirstName = "חיים", LastName = "זאב", Job = "מנקה", StartDate = DateTime.Now, HasAddress = true });
             
            ApiHelper.InitializeClient();
            Window();
          

            //MyProperty = new List<double>() { currency.Rates.THB };
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                //NotifyOfPropertyChange(() => FirstName);
                //NotifyOfPropertyChange(() => FullName);
            }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value;
                //NotifyOfPropertyChange(() => LastName);
                //NotifyOfPropertyChange(() => FullName);
            }
        }
      
        public Currency Currency
        {
            get  { 
                return currency; }
            set {
                
                currency = value;
                //NotifyOfPropertyChange(() => Currency);
            }
        }

        //public BindableCollection<Employee> Employees
        //{
        //    get { return employees; }
        //    set { employees = value; }
        //}
        //public  Dictionary<string,double> CurrencyList
        //{
            
        //    get { return   currency.Rates; }
        //    set { currency.Rates = value; NotifyOfPropertyChange(() => currency.Rates); }
        //}

        public Employee Employee
        {
            get { return employee; }
            set { employee = value;
                //NotifyOfPropertyChange(() => Employee);
            }
        }

        public string FullName
        {
            get { return $"{FirstName}  { LastName}"; }
        }

        public bool CanbtnSave(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                return false;
            return true;
                
            
        }
        public async Task getCurrency()
        {

            this.Currency = await CurrencyProcessor.LoadCurrency();

        }
        public async void Window()
        {
            await getCurrency();
        }
        public void btnSave(string firstName, string lastName)
        {

            MessageBox.Show("");

            //Console.WriteLine(currency);

        }
       
        //public void  btnUpdate() 
        //{
        //    ActivateItemAsync(new UpdateViewModel());
        //}
    }
}
