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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

     

       

        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes1 = new ViewAllQuotes();
            viewAllQuotes1.Tag = this;
            viewAllQuotes1.Show(this);
            Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes SearchQuotes1 = new SearchQuotes();
            SearchQuotes1.Tag = this;
            SearchQuotes1.Show(this);
            Hide();
        }
    }
}
