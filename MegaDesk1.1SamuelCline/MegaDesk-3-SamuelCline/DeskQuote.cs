using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_SamuelCline
{
    class DeskQuote
    {
        
        public string customerName
                {
                    get;
                    set;
                }



        public int rushDays
        {
            get;
            set;
        }

        public Decimal FinalCost
        {
            get;
            set;
        }

        public decimal rushCost
        {
            get;
            set;
        }

        public decimal calculateCost(int baseCost,
                            decimal rushCost,
                            decimal materialCost,
                            decimal surfaceCost,
                            decimal DrawerCost)
        {
          decimal x =  baseCost + rushCost + materialCost + surfaceCost + DrawerCost;
            return x;
        }
        public decimal DrawerCost
        {
            get;
            set;
        }
        public decimal surfaceCost
        {
            get;
            set;
        }


        
        /*
       
        shippingOption
        customerAddress
        quoteNumber
        */

        public DateTime quoteDate
        {
            get;
            set;
        }
    }
}
