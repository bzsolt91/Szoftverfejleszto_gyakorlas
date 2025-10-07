using Microsoft.Data.SqlClient;

namespace ablakos_belepes
{
    public partial class frm_belepes : Form
    {
        public frm_belepes()
        {
            InitializeComponent();
        }

        private void bt_kilepes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_belepes_Click(object sender, EventArgs e)
        {            
            string connectionString = "Server=127.0.0.1;Database=oktav;User Id=sa;Password=MVChez_dbs_13;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = "select valodi_nev from ugyintezok where nev = @nev and jelszo = @jelszo and aktiv = 'i' and torolve is null";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nev", tb_fnev.Text);
                command.Parameters.AddWithValue("@jelszo", tb_jelszo.Text);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            MessageBox.Show($"Üdv {reader["valodi_nev"].ToString()}!");   
                        }
                        else
                        {
                            MessageBox.Show($"Hibás név vagy jelszó!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba történt: " + ex.Message);
                }
            }
        }
    }
}
