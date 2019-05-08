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

namespace COMP_203_Final
{
    public partial class DetailForm : Form
    {
        public DetailForm(string accountNumber, string PIN)
        {
            InitializeComponent();
            //FindAccount() searches the database for a row that has the account number and PIN that the user entered and retrieves it for the form. 
            this.accountTableAdapter1.FindAccount(this.accountDataSet1.Account, accountNumber, PIN);
        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.accountDataSet1);

        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accountDataSet.Account' table. You can move, or remove it, as needed.
            //this.accountTableAdapter.Fill(this.accountDataSet.Account);
            newSavingsTextBox.Text = savingsBalanceTextBox.Text;
            newCheckingTextBox.Text = checkingBalanceTextBox.Text;
            newLoanTextBox.Text = loanBalanceTextBox.Text;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fastCashButton_Click(object sender, EventArgs e)
        {
            //sets transaction amount to 40 and gets the current checking balance
            decimal transAmount = 40m;
            decimal newCheckBal;
            decimal checkBal;
            checkBal = decimal.Parse(newCheckingTextBox.Text);
            //if the transaction amount is greater than the balance, it subtracts the transaction amount from the balance and places it in the text box
            if (transAmount < checkBal)
            {
            newCheckBal = checkBal - transAmount;
            newCheckingTextBox.Text = newCheckBal.ToString();
            }
            else { MessageBox.Show("Transaction Amount is greater than Balance."); }
        }
        
        private void withdrawCheckingButton_Click(object sender, EventArgs e)
        {
            //gets the transaciton amount from the user and gets the current checking balance from its text box
            decimal transAmount;
            decimal checkBal;
            decimal newCheckBal;
            checkBal = decimal.Parse(newCheckingTextBox.Text);
            Get_Amounts(out transAmount);
            //if the transaction amount is greater than the balance, it subtracts the transaction amount from the balance and places it in the text box
            if (transAmount < checkBal)
            {
                newCheckBal = checkBal - transAmount;
                newCheckingTextBox.Text = newCheckBal.ToString();
            }
            else { MessageBox.Show("Transaction Amount is greater than Balance."); }
        }


        private void withdrawSavingsButton_Click(object sender, EventArgs e)
        {
            //gets the transaciton amount from the user and gets the current savings balance from its text box
            decimal transAmount;
            decimal savingsBal;
            decimal newSavingsBal;
            savingsBal = decimal.Parse(newSavingsTextBox.Text);
            Get_Amounts(out transAmount);
            //if the transaction amount is greater than the balance, it subtracts the transaction amount from the balance and places it in the text box
            if (transAmount < savingsBal)
            {
                newSavingsBal = savingsBal - transAmount;
                newSavingsTextBox.Text = newSavingsBal.ToString();
            }
            else { MessageBox.Show("Transaction Amount is greater than Balance."); }
        }

        private void depositSavingsButton_Click(object sender, EventArgs e)
        {
            //gets the transaciton amount from the user and gets the current savings balance from its text box
            decimal transAmount;
            decimal savingsBal;
            decimal newSavingsBal;
            savingsBal = decimal.Parse(newSavingsTextBox.Text);
            Get_Amounts(out transAmount);

            //the transaction amount is added to the balance
            newSavingsBal = savingsBal + transAmount;
            newSavingsTextBox.Text = newSavingsBal.ToString();
        }

        private void depositCheckingButton_Click(object sender, EventArgs e)
        {
            //gets the transaciton amount from the user and gets the current checking balance from its text box
            decimal transAmount;
            decimal checkBal;
            decimal newCheckBal;
            checkBal = decimal.Parse(newCheckingTextBox.Text);
            Get_Amounts(out transAmount);
            //the transaction amount is added to the balance
            newCheckBal = checkBal + transAmount;
            newCheckingTextBox.Text = newCheckBal.ToString();
        }

        private void loanPaymentButton_Click(object sender, EventArgs e)
        {
            //gets the transaciton amount from the user and gets the current loan balance from its text box
            decimal transAmount;
            decimal loanBal;
            decimal newLoanBal;
            loanBal = decimal.Parse(newLoanTextBox.Text);
            Get_Amounts(out transAmount);
            //subtracts the transaction amount from the loan balance
            newLoanBal = loanBal - transAmount;
            newLoanTextBox.Text = newLoanBal.ToString();
        }

        private void generateReceiptButton_Click(object sender, EventArgs e)
        {
            //creates an output file variable and creates (or overwrites an existing) file to write to
            StreamWriter outputFile;
            outputFile = File.CreateText("Receipt.txt");
            //writing in each line of the receipt separately
            outputFile.WriteLine("User: " + lastnameTextBox.Text + ", " + firstnameTextBox.Text);
            outputFile.WriteLine("Account Number: " + bankAccountIDTextBox.Text);
            outputFile.WriteLine(Environment.NewLine, "Balances before transactions");
            outputFile.WriteLine("Savings Balance:  " + savingsBalanceTextBox.Text);
            outputFile.WriteLine("Checking Balance: " + checkingBalanceTextBox.Text);
            outputFile.WriteLine("Loan Balance:     " + loanBalanceTextBox.Text);
            outputFile.WriteLine(Environment.NewLine, "Current Balances");
            outputFile.WriteLine("Savings Balance:  " + newSavingsTextBox.Text);
            outputFile.WriteLine("Checking Balance: " + newCheckingTextBox.Text);
            outputFile.WriteLine("Loan Balance:     " + newLoanTextBox.Text);

            outputFile.Close();

            MessageBox.Show("Receipt Generated");
        }

        private void Get_Amounts(out decimal transAmount)
        {

            if (!decimal.TryParse(amountTextBox.Text, out transAmount))
            {
                MessageBox.Show("Please enter a valid amount for transaction");
            }
        }
    }
}
