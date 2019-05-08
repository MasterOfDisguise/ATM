using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP_203_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears the text boxes
            accountNumberTextBox.Text = "";
            PINTextBox.Text = "";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //creates a variable to hold the user input
            string accountNumber = accountNumberTextBox.Text;
            string PIN = PINTextBox.Text;

            if (accountNumber == "" || PIN == "")
            {
                MessageBox.Show("Please enter a valid Account Number and PIN");
            }
            else
            {
                //creates a detail form with the user input passed into it, then shows the form
                DetailForm details = new DetailForm(accountNumber, PIN);
                details.ShowDialog();
                accountNumberTextBox.Text = "";
                PINTextBox.Text = "";
            }
        }
    }
}
