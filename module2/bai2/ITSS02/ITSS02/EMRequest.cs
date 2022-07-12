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
    public partial class EMRequest : Form
    {
        public EMRequest(string asN, string assN, string dp, string asID)
        {
            InitializeComponent();
            assetname = asN;
            assetsn = assN;
            department = dp;
            assetid = asID;
            loadcmb();
        }
        public string assetname;
        public string assetsn;
        public string department;
        public string assetid;
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
                MessageBox.Show("Connect database fail!");
            }
        }
        void loadcmb()
        {
            ConnectDatabase();
            if (con.State == ConnectionState.Open)
            {
                string sql = "select * from priorites";
                sda = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                cmbP.DataSource = dt;
                cmbP.DisplayMember = "name";
                cmbP.ValueMember = "id";
            }

        }
        private void EMRequest_Load(object sender, EventArgs e)
        {
            lbAN.Text = assetsn;
            lbASN.Text = assetname;
            lbDP.Text = department;
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                string sql= "insert emergencymaintenances values('" + assetid + "','" + cmbP.SelectedValue.ToString() + "', '" + txtDE.Text + "','" + txtOC.Text + "', (select cast (getdate() as date )), '','','')";
                com = new SqlCommand(sql, con);
                int n = com.ExecuteNonQuery();
                if (n > 0)
                {
                    this.Close();
                    MessageBox.Show("Insert successfuly");
                }
                else
                {
                    MessageBox.Show("Something wrong!");
                }
            }

             
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
      
    
}
