using ApiLibrary;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAppExample.ViewModels
{
    public class StartWindowViewModel : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private Currency currency;
      

        //public bool TxtBoxEmphty { 
        //    get 
        //    {
        //        return CanExecuteSaveCommand();
        //    }
        //    set 
        //    {
        //        txtBoxEmphty = value;
        //    }
        //}
        public Currency Currency
        {
            get { return currency; }
            set
            {
                currency = value;
                OnPropertyChange("Currency");
            }
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChange("FirstName");
         
                //NotifyOfPropertyChange(() => FullName);
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChange("LastName");
     
                //NotifyOfPropertyChange(() => FullName);
            }
        }
        public DelegateCommand DelegateCommand { get; set; }
        public DelegateCommand DelegateSaveCommand { get; set; }

        public StartWindowViewModel()
        {
           
            ApiHelper.InitializeClient();
            //Window();
            getCurrency();
            DelegateCommand = new DelegateCommand(ExecuteCommand, CanExecuteCommand);
            DelegateSaveCommand = new DelegateCommand(ExecuteSaveCommand, CanExecuteSaveCommand);
            Task.Run(() =>
        {
            while (true)
            {
                DelegateCommand.RaiseCanExecuteChanged();
                DelegateSaveCommand.RaiseCanExecuteChanged();
                Thread.Sleep(1000);
            }
        });
            
        }

        private bool CanExecuteSaveCommand()
        {   
            if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
             return false; 
            
             return true; 
            
        }

        private void ExecuteSaveCommand()
        {
            MessageBox.Show($"Hello {FirstName} {LastName}");
        }

        private bool CanExecuteCommand()
        {
            return true;
           // return DateTime.Now.Second % 2 == 0;
        }

        private void ExecuteCommand()
        {
            //UpdateVie uv = new UpdateVie();
            MessageBox.Show("BOOM");
        }

  

        public event PropertyChangedEventHandler PropertyChanged;

        public async Task getCurrency()
        {

            this.Currency = await CurrencyProcessor.LoadCurrency();
           
        }
        //public async void Window()
        //{
        //    await getCurrency();
        //    //OnPropertyChange("Currency");
        //}

        private void OnPropertyChange(string property)
        {
            if (property != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
        
}
