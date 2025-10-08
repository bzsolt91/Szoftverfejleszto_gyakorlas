using MySqlConnector;
using System.Data;

namespace mysql_gyakorlas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_kapcsolodas_Click(object sender, EventArgs e)
        {
        
            string kapcsolatstring = string.Format("Server={0};User Id={1};Password={2};Database={3}","localhost","root","","futoverseny");

            using (var kapcsolat = new MySqlConnection(kapcsolatstring))
            {
                var dt = new DataTable();
                kapcsolat.Open();
                string sql = "SELECT * FROM versenyek WHERE verseny_neve LIKE @vnev";
                MySqlCommand cmd = new MySqlCommand(sql,kapcsolat);
                cmd.Parameters.AddWithValue("@vnev","%"+textBox1.Text+"%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

    }
}
