using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIT365_MegaDesk_Smith
{
    public enum RushShipping
    {
        RushOrder3Day,
        RushOrder5Day,
        RushOrder7Day,
        Normal14Day
    }

    class DeskQuote
    {
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public decimal QuotePrice { get; set; }
        public RushShipping QuoteShipping { get; set; }

        // Method for calculating the price of the quote:
        public decimal CalculationQuotePrice()
        {
            return 0;
        }

        // Method for displaying the price of the quote:
        public void DisplayQuotePrice()
        {
            // Code to show a field and fill it with the quote price.
        }
    }
}
