using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_SamuelCline
{
    public class Desk
    {

        public List<string> materialList = new List<string>();







        //depth
        public decimal Width
        {
            get;
            set;
        }

        //width
        public decimal Depth

        {
            get;
            set;

        }

        public enum SurfaceMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        };

        public SurfaceMaterial Material { get; set; }

        public decimal drawers
        {
            get;
            set;
        }

        

        public decimal SurfaceArea
        {
            get;
            set;
        }

        public decimal surfaceArea(decimal x, decimal y)
        {

            decimal z = x * y;
            return z;
        }

        public string SurfaceMaterialSelection
        {
            get;
            set;
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
