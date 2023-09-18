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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-5A7M4IO\SQLEXPRESS;Initial Catalog=ATM_db;Integrated Security=True");
        private int bal;
        private string Acc = Login.AccNumber;
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
        
        private void addTransaction1()
        {
            string tranType = "Fast Cash";
            try
            {
                Con.Open();
                string query = "insert into Transaction_Tb1 values('" + Acc + "','" + tranType + "','" + 20 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addTransaction2()
        {
            string tranType = "Fast Cash";
            try
            {
                Con.Open();
                string query = "insert into Transaction_Tb1 values('" + Acc + "','" + tranType + "','" + 40 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addTransaction3()
        {
            string tranType = "Fast Cash";
            try
            {
                Con.Open();
                string query = "insert into Transaction_Tb1 values('" + Acc + "','" + tranType + "','" + 60 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addTransaction4()
        {
            string tranType = "Fast Cash";
            try
            {
                Con.Open();
                string query = "insert into Transaction_Tb1 values('" + Acc + "','" + tranType + "','" + 80 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addTransaction5()
        {
            string tranType = "Fast Cash";
            try
            {
                Con.Open();
                string query = "insert into Transaction_Tb1 values('" + Acc + "','" + tranType + "','" + 100 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void addTransaction6()
        {
            string tranType = "Fast Cash";
            try
            {
                Con.Open();
                string query = "insert into Transaction_Tb1 values('" + Acc + "','" + tranType + "','" + 120 + "','" + DateTime.Today.Date.ToString() + "')";
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
        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            getBalance();
        }

        private void TwentyTb_Click(object sender, EventArgs e)
        {
            if (bal < 20)
            {
                MessageBox.Show("Balance Cannot Be Negative.");
            }
            else
            {
                int newBalance = bal - 20;
                try
                {
                    Con.Open();
                    string query = "update Account_Tb1 set Balance=" + newBalance + " where Acc_Num='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Withdraw");
                    Con.Close();
                    addTransaction1();
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

        private void FourtyTb_Click(object sender, EventArgs e)
        {
            if (bal < 40)
            {
                MessageBox.Show("Balance Cannot Be Negative.");
            }
            else
            {
                int newBalance = bal - 40;
                try
                {
                    Con.Open();
                    string query = "update Account_Tb1 set Balance=" + newBalance + " where Acc_Num='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Withdraw");
                    Con.Close();
                    addTransaction2();
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

        private void SixtyTb_Click(object sender, EventArgs e)
        {
            if (bal < 60)
            {
                MessageBox.Show("Balance Cannot Be Negative.");
            }
            else
            {
                int newBalance = bal - 60;
                try
                {
                    Con.Open();
                    string query = "update Account_Tb1 set Balance=" + newBalance + " where Acc_Num='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Withdraw");
                    Con.Close();
                    addTransaction3();
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

        private void EightyTb_Click(object sender, EventArgs e)
        {
            if (bal < 80)
            {
                MessageBox.Show("Balance Cannot Be Negative.");
            }
            else
            {
                int newBalance = bal - 80;
                try
                {
                    Con.Open();
                    string query = "update Account_Tb1 set Balance=" + newBalance + " where Acc_Num='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Withdraw");
                    Con.Close();
                    addTransaction4();
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

        private void HundredTb_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("Balance Cannot Be Negative.");
            }
            else
            {
                int newBalance = bal - 100;
                try
                {
                    Con.Open();
                    string query = "update Account_Tb1 set Balance=" + newBalance + " where Acc_Num='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Withdraw");
                    Con.Close();
                    addTransaction5();
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

        private void OneTwentyTb_Click(object sender, EventArgs e)
        {
            if (bal < 120)
            {
                MessageBox.Show("Balance Cannot Be Negative.");
            }
            else
            {
                int newBalance = bal - 120;
                try
                {
                    Con.Open();
                    string query = "update Account_Tb1 set Balance=" + newBalance + " where Acc_Num='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful Withdraw");
                    Con.Close();
                    addTransaction6();
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
    }
}
