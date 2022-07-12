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

namespace ITSS02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter sda;
        SqlCommand com;

        public void ConnectDatabase()
        {
            try
            {
                string st = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=ITSS02DATA;Integrated Security=True";
                con = new SqlConnection(st);
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connect database fail");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectDatabase();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter Username");
                    txtUsername.Focus();
                }
                else if(txtPassword.Text=="")
                {
                    MessageBox.Show("Please enter Password");
                    txtPassword.Focus();
                }
                else
                {
                    string sql="select * from employees where username='"+txtUsername.Text+"'";
                    com = new SqlCommand(sql, con);
                    SqlDataReader dtr = com.ExecuteReader();
                    if (dtr.HasRows)
                    {
                        dtr.Close();
                        string sql2 = "select isadmin, id from employees where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'";
                        com = new SqlCommand(sql2, con);
                        SqlDataReader dtr2 = com.ExecuteReader();
                        if (dtr2.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dtr2);
                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                MessageBox.Show("Only allow Accountable Party login");
                            }
                            else
                            {
                                EMManagement frm = new EMManagement(dt.Rows[0][1].ToString());
                                frm.Show();
                            }
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect account or password");
                        }
                        dtr2.Close();
                    }
                    else
                    {
                        dtr.Close();
                        MessageBox.Show("Account not exit");
                    }
                }
            }
        }
    }
}
