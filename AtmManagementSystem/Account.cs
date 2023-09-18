using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace AtmManagementSystem
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
       SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-5A7M4IO\SQLEXPRESS;Initial Catalog=ATM_db;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (AccNameTb.Text == "" ||  AccNumTb.Text == "" || FnameTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "" || OccupationTb.Text == "" || PinTb.Text == "")
            {
                MessageBox.Show("Missing iformation.");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Account_Tb1 values('" + AccNumTb.Text + "','" + AccNameTb.Text + "','" + FnameTb.Text + "','" +DobDate.Value.Date+ "','" + PhoneTb.Text + "','" + AddressTb.Text + "','" + EducationTb.SelectedItem.ToString() + "','" + OccupationTb.Text + "','" + PinTb.Text + "','"+bal+"')";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully.");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
           
            
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
