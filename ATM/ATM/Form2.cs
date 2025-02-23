using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form2 : Form
    {
        Bank account;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Bank temp)
        {
            InitializeComponent();
            account = temp;
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Logged in as : " + account.getAccountOwner();
            this.label3.Text = "Current balance is : " + account.getAccountBal() + "$";

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal d = decimal.Parse(textBox1.Text);
            account.deposit(d);

            label3.Text = "Current balance is : " + account.getAccountBal() + "$";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal d = decimal.Parse(textBox1.Text);

            if(d > account.getAccountBal())
            {
                MessageBox.Show("Not enough!");
                return;
            }

            account.withdraw(d);
            label3.Text = "Current balance is : " + account.getAccountBal() + "$"; ;
        }
    }
}
