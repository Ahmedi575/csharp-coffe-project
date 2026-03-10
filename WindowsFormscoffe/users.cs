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

namespace WindowsFormscoffe
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\csharp projects\csharp-coffe-project\coffe_db.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            orders order = new orders();
            order.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into UsersTbl values('" + unameTb.Text + "','" + uphoneTb.Text + "','" + upasswordTb.Text + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("تم إضافة مستخدم بنجاح");

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
