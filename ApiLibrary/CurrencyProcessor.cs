using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiLibrary
{
    public static class CurrencyProcessor
    {
        public static async  Task<Currency> LoadCurrency()
        {
            string url = "https://www.frankfurter.app/latest";

            using(HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Currency currency = await response.Content.ReadAsAsync<Currency>();
                    return currency;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
           
        } 
    }
}
