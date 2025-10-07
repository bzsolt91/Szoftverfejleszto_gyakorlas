namespace vizsga_feladat
{
    partial class frm_szerzok
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mc_mysqlcon = new MySqlConnector.MySqlConnection();
            lb_kapcsolat_allapota_felirat = new Label();
            bt_kapcsolat_teszt = new Button();
            bt_kilepes = new Button();
            lb_kapcsolat_allapota = new Label();
            gb_szerzok = new GroupBox();
            bt_legjobb_helyezes = new Button();
            bt_szerzo_szerkesztese = new Button();
            bt_szerzok_listazasa = new Button();
            dgw_szerzok = new DataGridView();
            gb_szerzok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_szerzok).BeginInit();
            SuspendLayout();
            // 
            // mc_mysqlcon
            // 
            mc_mysqlcon.ProvideClientCertificatesCallback = null;
            mc_mysqlcon.ProvidePasswordCallback = null;
            mc_mysqlcon.RemoteCertificateValidationCallback = null;
            // 
            // lb_kapcsolat_allapota_felirat
            // 
            lb_kapcsolat_allapota_felirat.AutoSize = true;
            lb_kapcsolat_allapota_felirat.Location = new Point(268, 29);
            lb_kapcsolat_allapota_felirat.Name = "lb_kapcsolat_allapota_felirat";
            lb_kapcsolat_allapota_felirat.Size = new Size(106, 15);
            lb_kapcsolat_allapota_felirat.TabIndex = 0;
            lb_kapcsolat_allapota_felirat.Text = "Kapcsolat állapota:";            
            // 
            // bt_kapcsolat_teszt
            // 
            bt_kapcsolat_teszt.Location = new Point(30, 25);
            bt_kapcsolat_teszt.Name = "bt_kapcsolat_teszt";
            bt_kapcsolat_teszt.Size = new Size(207, 23);
            bt_kapcsolat_teszt.TabIndex = 1;
            bt_kapcsolat_teszt.Text = "MySQL kapcsolat tesztelése";
            bt_kapcsolat_teszt.UseVisualStyleBackColor = true;
            bt_kapcsolat_teszt.Click += bt_kapcsolat_teszt_Click;
            // 
            // bt_kilepes
            // 
            bt_kilepes.Location = new Point(711, 603);
            bt_kilepes.Name = "bt_kilepes";
            bt_kilepes.Size = new Size(75, 23);
            bt_kilepes.TabIndex = 2;
            bt_kilepes.Text = "Kilépés";
            bt_kilepes.UseVisualStyleBackColor = true;
            bt_kilepes.Click += bt_kilepes_Click;
            // 
            // lb_kapcsolat_allapota
            // 
            lb_kapcsolat_allapota.AutoSize = true;
            lb_kapcsolat_allapota.Location = new Point(380, 29);
            lb_kapcsolat_allapota.Name = "lb_kapcsolat_allapota";
            lb_kapcsolat_allapota.Size = new Size(62, 15);
            lb_kapcsolat_allapota.TabIndex = 3;
            lb_kapcsolat_allapota.Text = "Ismeretlen";
            lb_kapcsolat_allapota.Click += lb_kapcsolat_allapota_Click;
            // 
            // gb_szerzok
            // 
            gb_szerzok.Controls.Add(bt_legjobb_helyezes);
            gb_szerzok.Controls.Add(bt_szerzo_szerkesztese);
            gb_szerzok.Controls.Add(bt_szerzok_listazasa);
            gb_szerzok.Controls.Add(dgw_szerzok);
            gb_szerzok.Enabled = false;
            gb_szerzok.Location = new Point(30, 85);
            gb_szerzok.Name = "gb_szerzok";
            gb_szerzok.Size = new Size(726, 450);
            gb_szerzok.TabIndex = 6;
            gb_szerzok.TabStop = false;
            gb_szerzok.Text = "Szerzők";
            // 
            // bt_legjobb_helyezes
            // 
            bt_legjobb_helyezes.Location = new Point(417, 400);
            bt_legjobb_helyezes.Name = "bt_legjobb_helyezes";
            bt_legjobb_helyezes.Size = new Size(245, 23);
            bt_legjobb_helyezes.TabIndex = 9;
            bt_legjobb_helyezes.Text = "Kiválasztott szerző legjobb helyezése";
            bt_legjobb_helyezes.UseVisualStyleBackColor = true;
            bt_legjobb_helyezes.Click += bt_legjobb_helyezes_Click;
            // 
            // bt_szerzo_szerkesztese
            // 
            bt_szerzo_szerkesztese.Location = new Point(24, 400);
            bt_szerzo_szerkesztese.Name = "bt_szerzo_szerkesztese";
            bt_szerzo_szerkesztese.Size = new Size(245, 23);
            bt_szerzo_szerkesztese.TabIndex = 8;
            bt_szerzo_szerkesztese.Text = "Kiválasztott szerző szerkesztése";
            bt_szerzo_szerkesztese.UseVisualStyleBackColor = true;
            bt_szerzo_szerkesztese.Click += bt_szerzo_szerkesztese_Click;
            // 
            // bt_szerzok_listazasa
            // 
            bt_szerzok_listazasa.Location = new Point(21, 33);
            bt_szerzok_listazasa.Name = "bt_szerzok_listazasa";
            bt_szerzok_listazasa.Size = new Size(205, 23);
            bt_szerzok_listazasa.TabIndex = 7;
            bt_szerzok_listazasa.Text = "Szerzők listázása";
            bt_szerzok_listazasa.UseVisualStyleBackColor = true;
            bt_szerzok_listazasa.Click += bt_szerzok_listazasa_Click;
            // 
            // dgw_szerzok
            // 
            dgw_szerzok.AllowUserToAddRows = false;
            dgw_szerzok.AllowUserToDeleteRows = false;
            dgw_szerzok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_szerzok.Location = new Point(21, 71);
            dgw_szerzok.MultiSelect = false;
            dgw_szerzok.Name = "dgw_szerzok";
            dgw_szerzok.ReadOnly = true;
            dgw_szerzok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_szerzok.Size = new Size(641, 299);
            dgw_szerzok.TabIndex = 6;
            dgw_szerzok.CellDoubleClick += dgw_szerzok_CellDoubleClick;
            // 
            // frm_szerzok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 638);
            Controls.Add(gb_szerzok);
            Controls.Add(lb_kapcsolat_allapota);
            Controls.Add(bt_kilepes);
            Controls.Add(bt_kapcsolat_teszt);
            Controls.Add(lb_kapcsolat_allapota_felirat);
            Name = "frm_szerzok";
            Text = "Szerzők";
            gb_szerzok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgw_szerzok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MySqlConnector.MySqlConnection mc_mysqlcon;
        private Label lb_kapcsolat_allapota_felirat;
        private Button bt_kapcsolat_teszt;
        private Button bt_kilepes;
        private Label lb_kapcsolat_allapota;
        private GroupBox gb_szerzok;
        private Button bt_szerzok_listazasa;
        private DataGridView dgw_szerzok;
        private Button bt_szerzo_szerkesztese;
        private Button bt_legjobb_helyezes;
    }
}
