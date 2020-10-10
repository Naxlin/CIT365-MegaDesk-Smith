using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIT365_MegaDesk_Smith
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            // Instantiating AddQuote form
            Form addQuote = new AddQuote();
            // One way of including MainMenu form object
            addQuote.Tag = this;
            // Showing the AddQuote form
            addQuote.Show();
            // Hiding the MainMenu form
            this.Hide();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            // Instantiating ViewAllQuotes form and passing the MainMenu object
            Form viewAllQuotes = new ViewAllQuotes(this);
            viewAllQuotes.Show();
            this.Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            // Instantiating SearchQuotes form and passing the MainMenu object
            Form searchQuotes = new SearchQuotes(this);
            searchQuotes.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
