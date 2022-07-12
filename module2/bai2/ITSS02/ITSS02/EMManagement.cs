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
    public partial class EMManagement : Form
    {
        public EMManagement(string str)
        {
            InitializeComponent();
            isadmin = str;
            loaddtgv();
        }
        public string isadmin = "";
        public string assetname = "";
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

        void loaddtgv()
        {
            ConnectDatabase();
            if (con.State == ConnectionState.Open)
            {
                string query = "";
                if (isadmin == "")
                {
                    query = "select assetsn,assetname,emenddate,(select count(*) from emergencymaintenances where assetid=em.assetid ) as numem from assets a,emergencymaintenances em where a.id=em.assetid and emenddate =(select max(emenddate) from emergencymaintenances where assetid=a.id) order by assetid asc";
                }
                else
                {
                    query = "select assetsn,assetname,emenddate,(select count(*) from emergencymaintenances where assetid=em.assetid ) as numem from assets a,emergencymaintenances em where a.id=em.assetid and a.employeeid= '" + isadmin + "' and emenddate =(select max(emenddate) from emergencymaintenances where assetid=a.id) order by assetid asc";
                }
                sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.Rows.Clear();
                foreach(DataRow dr in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    if (dr[2].ToString() == "")
                    {
                        dataGridView1.Rows[n].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                }
            }
        }
        public void test()
        {
            dataGridView1.Rows.Clear();
        }
        private void EMManagement_Load(object sender, EventArgs e)
        {

        }
        public void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            loaddtgv();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            assetname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show(assetname);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            ConnectDatabase();
            if (con.State == ConnectionState.Open)
            {
                if (assetname != "")
                {
                    string sql = "select assetname,assetsn,d.name,a.id from assets a,departments d,departmentlocations dl where a.departmentlocationid=dl.id and dl.departmentid=d.id and assetname='" + assetname + "'";
                    sda = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    foreach(DataRow dr in dt.Rows)
                    {
                        EMRequest  frm = new EMRequest(dr[0].ToString(),dr[1].ToString(),dr[2].ToString(),dr[3].ToString());
                        frm.FormClosing += new FormClosingEventHandler(ChildFormClosing);
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("No row selected");
                }
            }
        }
    }
}
