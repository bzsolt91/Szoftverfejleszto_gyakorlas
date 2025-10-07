using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizsga_feladat
{
    public partial class frm_szerzo_szerkesztese : Form
    {

        private readonly String conStr;
        private readonly int id;
        public frm_szerzo_szerkesztese(String conStr, int id, String nev, int szulEv, int halEv, String nemzetiseg)
        {
            InitializeComponent();
            this.conStr = conStr;
            this.id = id;
            tb_szerzo_neve.Text = nev;
            tb_szulev.Text = szulEv.ToString();
            tb_halev.Text = halEv.ToString();
            tb_nemzetisege.Text = nemzetiseg;

        }

        private void bt_megse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void bt_mentes_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(conStr))
            {
                conn.Open();
                String sql = "UPDATE szerzok SET nev = @nev, szulEv = @szulEv, halEv = @halEv, nemzetiseg = @nemzetiseg WHERE id = @id";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nev", tb_szerzo_neve.Text);
                cmd.Parameters.AddWithValue("@szulEv", tb_szulev.Text);
                cmd.Parameters.AddWithValue("@halEv", tb_halev.Text);
                cmd.Parameters.AddWithValue("@nemzetiseg", tb_nemzetisege.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();                
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
   
}
