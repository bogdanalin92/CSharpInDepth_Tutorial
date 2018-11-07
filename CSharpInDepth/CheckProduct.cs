using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInDepth
{
    /// <summary>
    /// The following listing shows a single method
    /// that handles a button click in WF
    /// </summary>
    public class CheckProduct
    {
        

        private async void CheckProductEvent(object sender, EventArgs e)
        {
            try
            {
                productCheckButton.Enabled = false;
                string id = idInput.Text;
                //Task<Product> productLookup = directory.LookupAsync(id);
                //Task<int> stockLookup = warehouse.LookupStockLevelAsync(id);
                //Product product = await productLookup;
                //if(product == null)
                {
                    return;
                }
                //nameValue.Text = product.Name;
                //priceValue.Text = product.Price.ToString("c");

                //int stock = await stockLookup;
                //stockValue.Text = stock.ToString();
            }
            finally
            {
                productCheckButton.Enabled = true;
            }
        }
    }

    internal class idInput  
    {
        public static string Text { get; set; }
    }

    internal class productCheckButton
    {
        private static bool _enabled;
        public static bool Enabled { get { return _enabled; } set { _enabled = value; } }
        
    }
}
