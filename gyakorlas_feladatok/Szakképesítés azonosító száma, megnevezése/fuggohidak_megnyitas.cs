using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fuggohidak;
namespace fuggohidak
{
    public partial class frm_megnyitas : Form
    {
        Form fo_form;
        List<Fuggohid> hidak = new List<Fuggohid>();
        public frm_megnyitas(Form frm)
        {
            InitializeComponent();
            fo_form = frm;
        }

        private void frm_megnyitas_Load(object sender, EventArgs e)
        {
            beolvasas();
        }
        private void beolvasas()
        {
            string fejlec = "";
            try
            {

                using (var elem = new StreamReader("fuggohidak.csv", Encoding.UTF8))
                {
                    string sor = "";
                    fejlec = elem.ReadLine();
                    while ((sor = elem.ReadLine()) != null)
                    {
                        hidak.Add(new Fuggohid(sor));
                    }
                }


                foreach (var elemek in hidak)
                {
                    lbx_kereses.Items.Add(elemek);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void lbx_kereses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_kereses.SelectedIndex != -1)
            {
                Fuggohid hid = (Fuggohid)lbx_kereses.SelectedItems[0];
                tb_hely.Text = hid.Hely;
                tb_ev.Text = hid.AtadasEve.ToString();
                tb_hossz.Text = hid.Hossz.ToString();
                tb_orszag.Text = hid.Orszag;

            }
        }

        private void rb_2000elott_CheckedChanged(object sender, EventArgs e)
        {
            int szamlalo = 0;
            foreach (var elem in hidak)
            {
                if (elem.AtadasEve < 2000)
                    szamlalo++;
            }
            tb_darab.Text = szamlalo.ToString();
        }

        private void rb_2000utan_CheckedChanged(object sender, EventArgs e)
        {
            int szamlalo = 0;
            foreach (var elem in hidak)
            {
                if (elem.AtadasEve >= 2000)
                    szamlalo++;
            }
            tb_darab.Text = szamlalo.ToString();
        }

        private void smi_kilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void smi_kereses_Click(object sender, EventArgs e)
        {
            kereses krs = new kereses(this,hidak);
            krs.ShowDialog();
            this.Visible = false;
        }
    }
}
