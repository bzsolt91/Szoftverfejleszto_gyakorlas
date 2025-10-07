using MySqlConnector;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace vizsga_feladat
{
    public partial class frm_szerzok : Form
    {
        String constr;

        public frm_szerzok()
        {
            InitializeComponent();
            constr = String.Format("Server={0};User ID={1};Password={2};Database={3}", "127.0.0.1", "root", "", "vizsgafeladat");
        }

        private void bt_kapcsolat_teszt_Click(object sender, EventArgs e)
        {
            try
            {
                mc_mysqlcon = new MySqlConnection(constr);
                mc_mysqlcon.Open();
                mc_mysqlcon.Close();
                lb_kapcsolat_allapota.Text = "Sikeres kapcsolat felépítés!";
                lb_kapcsolat_allapota.ForeColor = Color.Green;
                gb_szerzok.Enabled = true;
            }
            catch (MySqlConnector.MySqlException)
            {
                lb_kapcsolat_allapota.Text = "Hiba a kapcsolat felépítésében!";
                lb_kapcsolat_allapota.ForeColor = Color.Red;
            }
        }

        private void bt_kilepes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadData()
        {
            using (var mc_mysqlcon = new MySqlConnection(constr))
            {
                var dt = new DataTable();
                String sql = "SELECT id as Sorszám, nev as Név, szulEv as 'Születési éve', halEv as 'Halálának éve', nemzetiseg as Nemzetisége FROM szerzok";
                var cmd = new MySqlCommand(sql, mc_mysqlcon);
                //var cmd = new MySqlCommand("SELECT * FROM szerzok", mc_mysqlcon);
                var da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                dgw_szerzok.DataSource = dt;
            }
        }

        private void bt_szerzok_listazasa_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bt_szerzo_szerkesztese_Click(object sender, EventArgs e)
        {
            szerzo_szerkesztese();
        }

        private void szerzo_szerkesztese()
        {
            if (dgw_szerzok.SelectedRows.Count > 0)
            {
                var row = dgw_szerzok.SelectedRows[0];
                /*
                int id = Convert.ToInt32(row.Cells["id"].Value);
                String nev = Convert.ToString(row.Cells["nev"].Value);
                int szulEv = Convert.ToInt32(row.Cells["szulEv"].Value);
                int halEv = Convert.ToInt32(row.Cells["halEv"].Value);
                String nemzetiseg = Convert.ToString(row.Cells["nemzetiseg"].Value);
                */
                /*
                int id = Convert.ToInt32(row.Cells["Sorszám"].Value);
                String nev = Convert.ToString(row.Cells["Név"].Value);
                int szulEv = Convert.ToInt32(row.Cells["Születési éve"].Value);
                int halEv = Convert.ToInt32(row.Cells["Halálának éve"].Value);
                String nemzetiseg = Convert.ToString(row.Cells["Nemzetisége"].Value);
                */
                int id = Convert.ToInt32(row.Cells[0].Value);
                String nev = Convert.ToString(row.Cells[1].Value);
                int szulEv = Convert.ToInt32(row.Cells[2].Value);
                int halEv = Convert.ToInt32(row.Cells[3].Value);
                String nemzetiseg = Convert.ToString(row.Cells[4].Value);

                var form2 = new frm_szerzo_szerkesztese(constr, id, nev, szulEv, halEv, nemzetiseg);
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Kérlek, válassz ki egy sort!");
            }
        }

        private void dgw_szerzok_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                szerzo_szerkesztese();
        }

        private void bt_legjobb_helyezes_Click(object sender, EventArgs e)
        {
            if (dgw_szerzok.SelectedRows.Count > 0)
            {
                var row = dgw_szerzok.SelectedRows[0];

                using (var mc_mysqlcon = new MySqlConnection(constr))
                {
                    mc_mysqlcon.Open();
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    String sql = "select min(helyezes) as legjobb from muvek where szerzoid = @szerzoid";
                    var cmd = new MySqlCommand(sql, mc_mysqlcon);
                    cmd.Parameters.AddWithValue("@szerzoid", id);
                    //using (MySqlDataReader reader = cmd.ExecuteReader())
                    using (var reader = cmd.ExecuteReader())
                    {
                        //while (reader.Read()) {}
                        reader.Read();
                        //int legjobb_helyezes = reader.GetInt32(0);
                        int legjobb_helyezes = reader.GetInt32("legjobb");
                        MessageBox.Show($"A szerzõ legjobb helyezése: {legjobb_helyezes}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Kérlek, válassz ki egy sort!");
            }
        }

        private void lb_kapcsolat_allapota_Click(object sender, EventArgs e)
        {

        }
    }
}
