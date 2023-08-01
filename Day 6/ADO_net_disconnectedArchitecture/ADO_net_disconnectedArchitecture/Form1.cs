using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace ADO_net_disconnectedArchitecture
{
    public partial class Form1 : Form
    {


        SqlConnection _con;
        SqlDataAdapter adptAccounts;
        DataSet _ds = new DataSet();
        DataView _dvAccounts = new DataView();
        SqlCommandBuilder _buildAccounts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             _con = new SqlConnection("server=(localdb)\\MSSQLLocalDB;database=bankingDB;integrated security=true");
             adptAccounts = new SqlDataAdapter("select * from AccountDetails", _con);
            _buildAccounts = new SqlCommandBuilder(adptAccounts);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adptAccounts.Fill(_ds);
            _dvAccounts = _ds.Tables[0].DefaultView;
            dataGridView1.DataSource = _ds.Tables[0];

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dvAccounts.RowFilter = "accType = '" + comboBox1.Text + "'";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _dvAccounts.RowFilter = "accName like '" + textBox1.Text + "%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ds.Tables[0].WriteXml("accounts.xml");
            MessageBox.Show("Data Saved As XMl");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adptAccounts.Update(_ds.Tables[0]);
            MessageBox.Show("Database updated successfully");
        }
    }
}