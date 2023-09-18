using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AtmManagementSystem
{
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        //X Button for exiting the application
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Establishing connection between winform and database
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-5A7M4IO\SQLEXPRESS;Initial Catalog=ATM_db;Integrated Security=True");
        string Acc = Login.AccNumber;
        int bal;
        private void Withdraw_Load(object sender, EventArgs e)
        {
            getBalance();
        }
        //method for displaying the balance when the user accesses this page
        private void getBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from Account_Tb1 where Acc_Num='" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "$ " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt16(dt.Rows[0][0].ToString());
            Con.Close();
        }
        //Method for adding the transaction to the transaction table 
        private void addTransaction()
        {
            string tranType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert into Transaction_Tb1 values('" + Acc + "','" + tranType + "','" + WdAmtTb.Text + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        //Back Button
        private void label12_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        int newBalance;
        //Withdraw Button 
        private void button1_Click(object sender, EventArgs e)
        {
            if(WdAmtTb.Text == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else if(Convert.ToInt32(WdAmtTb.Text) <= 0)
            {
                MessageBox.Show("Enter A Valid Amount.");
            }
            else if(Convert.ToInt32(WdAmtTb.Text) > bal)
            {
                MessageBox.Show("Balance Cannot Be Negative.");
            }
            else
            {
                newBalance = bal - Convert.ToInt32(WdAmtTb.Text);

                try
                {
                    Con.Open();
                    string query = "update Account_Tb1 set Balance=" + newBalance + " where Acc_Num='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Withdraw");
                    Con.Close();
                    addTransaction();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Balancelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
