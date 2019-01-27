using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MegaDesk_3_SamuelCline
{
    public partial class AddQuote : Form
    {
        Desk desk1 = new Desk();
        public AddQuote()
        {
            InitializeComponent();

        }





        private void cancelBtn_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void depthBox_ValueChanged(object sender, EventArgs e)
        {
            /* if (desk1.Depth(depthBox.Value))
             {
                 //depthBox.BackColor = Color.Green;
                 errorProvider1.SetError(depthBox, "");


             }

             else
             {

                 errorProvider1.SetError(depthBox, "Enter Value between 24 and 96");
             }*/


        }

        public void okBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implimented");

        }



        private void widthBox_Validating(object sender, CancelEventArgs e)
        {

            if (desk1.Width(widthBox.Value))
            {
                //depthBox.BackColor = Color.Green;
                errorProvider1.SetError(widthBox, "Enter Value between 24 and 96");
                e.Cancel = desk1.Width(widthBox.Value);

            }

            else
            {

                errorProvider1.SetError(widthBox, "");
            }

            //e.Cancel = desk1.Depth(depthBox.Value);
        }

        private void depthBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           //

            
            if (desk1.Depth(depthBox.Value))
            {

                errorProvider1.SetError(depthBox, "Enter Value between 12 and 48");


            }

            else
            {

                errorProvider1.SetError(depthBox, "");
            }

            //e.Cancel = desk1.Depth(depthBox.Value);
        }
    }
}

