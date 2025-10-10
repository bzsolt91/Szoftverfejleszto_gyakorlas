using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuggohidak
{
    public partial class kereses : Form
    {
        Form frm;
        List<Fuggohid> hidak;
        public kereses(Form frm, List<Fuggohid> hidak)
        {
            InitializeComponent();
            this.frm = frm;
            this.hidak = hidak;
        }

        private void kereses_Load(object sender, EventArgs e)
        {
            betoltes();
        }
        private void betoltes()
        {
            foreach (var elem in hidak)
            {
                if (!cmb_orszag.Items.Contains(elem.Orszag))
                {
                    cmb_orszag.Items.Add(elem.Orszag);
                }
            }
        }
        private List<string> orszagKereses(string orszag, bool km)
        {
            List<string> lista = new List<string>();
            foreach (var elem in hidak)
            {

                if (elem.Orszag == orszag && km)
                {
                    if (elem.Hossz > 1000)
                        lista.Add(elem.ToString());
                }
                else if (elem.Orszag == orszag)
                    lista.Add(elem.ToString());
            }
            return lista;
        }

        private void btn_kereses_Click(object sender, EventArgs e)
        {
            lbx_kereses.Items.Clear();
            if (cmb_orszag.Text != "")
                if (cb_1kmnelhosszabbak.Checked)
                    lbx_kereses.Items.AddRange(orszagKereses(cmb_orszag.Text, true).ToArray());
                else
                    lbx_kereses.Items.AddRange(orszagKereses(cmb_orszag.Text, false).ToArray());
        }

        private void btn_kilepes_Click(object sender, EventArgs e)
        {
            frm.Show();
            this.Close();
        }
    }
}
