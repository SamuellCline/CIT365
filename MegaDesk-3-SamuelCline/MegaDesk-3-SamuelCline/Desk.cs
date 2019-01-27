using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_SamuelCline
{
   public class Desk
    {

       
            //depth
            public bool Width(decimal x)
            {

                
                
                if ((x >= 24) && (x <= 96))
                {
                    return false;
                }

                else
                {
                    
                    return true;
                }

            }

            //width
            public bool Depth(decimal x)
            {
            if ((x >= 12) && (x <= 48))
            {
                return false;
            }

            else
            {

                return true;
            }

        }


            

        

/*
Validation with each method
deskSize-widith
deskSize-depth
deskSize-square inches
number of drawers < 8
deskMaterial swtich?
deskCost
*/


    }
}
