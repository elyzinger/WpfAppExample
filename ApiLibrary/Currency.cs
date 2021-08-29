using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiLibrary
{
    public class Currency 
    {
        private string _base;


        public  Dictionary<string, double> Rates { get; set; }


        public Currency()
        {

        }
        public string Base { get 
            {
                return this._base;
            }
            set
            {
                this._base = value;
                //OnPropertyChange("Base");
            }
        }
        public DateTime Date { get; set; }

        //public event PropertyChangedEventHandler PropertyChanged;
        
        //private void OnPropertyChange(string property)
        //{
        //    if (property != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(property));
        //    }
        //}
    }
}
