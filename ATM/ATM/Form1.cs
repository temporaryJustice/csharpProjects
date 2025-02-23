namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Log in button...
        private void button1_Click(object sender, EventArgs e)
        {
            //Check if entry exists
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if(AtmManager.retrieveAccount(textBox1.Text, textBox2.Text))
                {
                    MessageBox.Show("Successfully signed in account!");
                }
                else
                {
                    MessageBox.Show("Invalid user/password combinasion.");
                    return;
                }
                
            }
            else
            {
                MessageBox.Show("boxes can not be empty!.");
                return;
            }
            Bank currentUser = AtmManager.extractBank(textBox1.Text, textBox2.Text);

            (new Form2(currentUser)).Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Signup button
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                AtmManager.addAccount(textBox1.Text, textBox2.Text);
                MessageBox.Show("Successfully signed up your account!");
            }
            else
            {
                MessageBox.Show("Username/Password can not be empty.");
            }
            
        }
    }

    public class AtmManager
    {
        static private List<Bank> accounts = new List<Bank>();

        //Function to add a new person to the banking system...
        static public void addAccount(string name, string pass)
        {
            accounts.Add(new Bank(name, pass));
        }

        static public bool retrieveAccount(string name, string pass)
        {

            foreach(Bank bank in accounts)
            {
                if(name.Equals(bank.getAccountOwner()) && pass.Equals(bank.getAccountPassword()))
                {
                   return true;
                }
            }
            return false;
        }

        static public Bank extractBank(string name, string pass)
        {
            foreach (Bank bank in accounts)
            {
                if (name.Equals(bank.getAccountOwner()) && pass.Equals(bank.getAccountPassword()))
                {
                    return bank;
                }
            }

            return null;
        }
    }

    public class Bank
    {
        decimal amount;
        private string accountOwner;
        private string password;

        public Bank()
        {
            amount = 0;
        }

        public Bank(string person, string pass)
        {
            accountOwner = person;
            amount = 0;
            password = pass;
        }

        public void withdraw(decimal number)
        {
            amount -= number;
        }

        public void deposit(decimal number)
        {
            amount += number;
        }
        
        public string getAccountOwner()
        {
            return accountOwner; 
        }

        public string getAccountPassword()
        {
            return password;
        }

        public decimal getAccountBal()
        {
            return amount;
        }
    }
}
