using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MegaDesk_3_SamuelCline
{
    public partial class AddQuote : Form
    {
        Desk desk1 = new Desk();
        DeskQuote dq1 = new DeskQuote();
        int index1;
        int index2;
        public AddQuote()
        {
            InitializeComponent();

        }


        List<Desk.SurfaceMaterial> materialList = Enum.GetValues(typeof(Desk.SurfaceMaterial)).Cast<Desk.SurfaceMaterial>().ToList();


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
        ////////////////////

        public void okBtn_Click(object sender, EventArgs e)
        {

            desk1.SurfaceArea = desk1.surfaceArea(widthBox.Value, depthBox.Value);

            if (desk1.SurfaceArea < 1000)
            {
                index2 = 0;
            }
            else if ((desk1.SurfaceArea > 1000) && (desk1.SurfaceArea < 2000))
            {
                index2 = 1;
            }
            else
            {
                index2 = 2;
            }


            decimal[,] rushCost = new decimal[3, 3];
            rushCost[0, 0] = 60;
            rushCost[1, 0] = 40;
            rushCost[2, 0] = 30;
            rushCost[0, 1] = 70;
            rushCost[1, 1] = 50;
            rushCost[2, 1] = 60;
            rushCost[0, 2] = 80;
            rushCost[1, 2] = 35;
            rushCost[2, 2] = 40;

            decimal rushFinal = rushCost[index1, index2];


            dq1.FinalCost = dq1.calculateCost(200,
                            rushFinal,
                           dq1.surfaceCost,
                           desk1.SurfaceArea,
                           dq1.DrawerCost);

            outputBox1.Text = dq1.FinalCost.ToString();
            dq1.quoteDate = DateTime.Today;
            writeCSV();

        }
        //////////////////


        private void widthBox_Validating(object sender, CancelEventArgs e)
        {

            if ((widthBox.Value >= 24) && (widthBox.Value <= 96))
            {
                errorProvider1.SetError(widthBox, "");
                desk1.Width = widthBox.Value;
            }

            else
            {
                errorProvider1.SetError(widthBox, "Enter Value between 24 and 96");
                e.Cancel = true;

            }


        }


        private void depthBox_Validating(object sender, CancelEventArgs e)
        {
            if ((depthBox.Value >= 12) && (depthBox.Value <= 48))
            {
                errorProvider1.SetError(depthBox, "");
                desk1.Depth = depthBox.Value;
            }

            else
            {

                errorProvider1.SetError(depthBox, "Enter Value between 12 and 48");
                e.Cancel = true;
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            foreach (Desk.SurfaceMaterial i in materialList)
            {
                materialBox.Items.Add(i);
            }
        }

        private void drawerBox_ValueChanged(object sender, EventArgs e)
        {
            desk1.drawers = drawerBox.Value;
            dq1.DrawerCost = desk1.drawers * 50;
        }

        private void shippingBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            int caseSwitch = shippingBox.SelectedIndex;
            int x;


            switch (caseSwitch)
            {
                case 1:
                    x = 3;
                    index1 = 0;
                    break;
                case 2:
                    x = 5;
                    index1 = 1;
                    break;
                case 3:
                    x = 7;
                    index1 = 2;
                    break;
                default:
                    x = 14;
                    break;
            }
            dq1.rushDays = x;

        }


        private void materialBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a;
            string b = "";
            switch (materialBox.SelectedIndex)
            {
                case 0:
                    a = 100;
                    b = "Laminate";
                    break;
                case 1:
                    a = 200;
                    b = "Oak";
                    break;
                case 2:
                    a = 300;
                    b = "Rosewood";
                    break;
                case 3:
                    a = 125;
                    b = "Veneer";
                    break;
                case 4:
                    a = 50;
                    b = "Pine";
                    break;


                default:
                    a = 0;
                    break;
            }
            desk1.SurfaceMaterialSelection = b;
            dq1.surfaceCost = a;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            dq1.customerName = nameBox.Text;
        }


        public void writeCSV()
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            saveFileDialog1.FileName = "quotes.txt";
            saveFileDialog1.ShowDialog();
            
            try
            {
               
                
                string csvFile = saveFileDialog1.FileName;//@"C:\Users\Samuel Cline\Documents\test123\quotes.txt";

                using (StreamWriter writer = new StreamWriter(csvFile, true))
                {
                    writer.WriteLine(
                            $"{dq1.quoteDate}," +
                            $"{dq1.customerName}," +
                            $"{desk1.Depth}," +
                            $"{desk1.Width}," +
                            $"{desk1.drawers}," +
                            $"{desk1.Material}," +
                            $"{dq1.rushDays}," +
                            $"{dq1.FinalCost}");
                }
            
            }

            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
}
    }


}

