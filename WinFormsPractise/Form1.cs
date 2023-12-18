using System.Drawing.Text;

namespace WinFormsPractise
{
    public partial class Form1 : Form
    {
        private Bank mybank;
        private List<Account> users;
        internal Form1(Bank bank)
        {
            InitializeComponent();
            mybank = bank;
            users = new List<Account>();
        }

        private void LoadUsers()
        {
            if (mybank != null)
            {
                users = mybank.GetAccounts();
                if (GridViewUsers != null)
                {
                    GridViewUsers.DataSource = users;
                }
                else
                {
                    MessageBox.Show("Data Grid is not initialized.");
                }
            }
            else
            {
                MessageBox.Show("Bank not initialized.");
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void txtDeleteuser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            int accountNumber;
            string accountHolderName=textBox2.Text;
            Decimal openingBalance ;
            if (!int.TryParse(textBox1.Text, out accountNumber) || !Decimal.TryParse(textBox3.Text,out openingBalance))
            {
                MessageBox.Show("Invalid Input. Enter valid information.");
                return;
            }

            Account newAccount = new Account { AccountHolderName = accountHolderName, AccountNumber = accountNumber, Balance = openingBalance };
            mybank.AddAccounttoDB(newAccount);
            LoadUsers();
        }

        private void txtAdduser_Click(object sender, EventArgs e)
        {
            if(GridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user to delete.");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user??","Confirmation",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Account selectedUer =(Account)GridViewUsers.SelectedRows[0].DataBoundItem;
                mybank.DeleteAccount(selectedUer);
                LoadUsers();
            }            
        }
        private void ClearInputFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}