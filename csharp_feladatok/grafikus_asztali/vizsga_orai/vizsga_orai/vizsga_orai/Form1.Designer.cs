namespace vizsga_orai
{
    partial class frm_foform
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
            lb_kapcs_tesztű = new Label();
            bt_kapcs_teszt = new Button();
            lb_kapcs_allapot = new Label();
            gb_szerzok = new GroupBox();
            bt_szerzolista = new Button();
            bt_legjobb = new Button();
            bt_szerzo_szerkesztese = new Button();
            dgw_szerzok = new DataGridView();
            bt_kilepes = new Button();
            mc_mysqlcon = new MySqlConnector.MySqlConnection();
            bt_osszes_muve = new Button();
            gb_szerzok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_szerzok).BeginInit();
            SuspendLayout();
            // 
            // lb_kapcs_tesztű
            // 
            lb_kapcs_tesztű.AutoSize = true;
            lb_kapcs_tesztű.Location = new Point(250, 33);
            lb_kapcs_tesztű.Name = "lb_kapcs_tesztű";
            lb_kapcs_tesztű.Size = new Size(71, 15);
            lb_kapcs_tesztű.TabIndex = 0;
            lb_kapcs_tesztű.Text = "Kapcs. teszt:";
            // 
            // bt_kapcs_teszt
            // 
            bt_kapcs_teszt.Location = new Point(40, 29);
            bt_kapcs_teszt.Name = "bt_kapcs_teszt";
            bt_kapcs_teszt.Size = new Size(161, 23);
            bt_kapcs_teszt.TabIndex = 1;
            bt_kapcs_teszt.Text = "Kapcs. teszt";
            bt_kapcs_teszt.UseVisualStyleBackColor = true;
            bt_kapcs_teszt.Click += bt_kapcs_teszt_Click;
            // 
            // lb_kapcs_allapot
            // 
            lb_kapcs_allapot.AutoSize = true;
            lb_kapcs_allapot.Location = new Point(370, 33);
            lb_kapcs_allapot.Name = "lb_kapcs_allapot";
            lb_kapcs_allapot.Size = new Size(62, 15);
            lb_kapcs_allapot.TabIndex = 2;
            lb_kapcs_allapot.Text = "Ismeretlen";
            // 
            // gb_szerzok
            // 
            gb_szerzok.Controls.Add(bt_osszes_muve);
            gb_szerzok.Controls.Add(bt_szerzolista);
            gb_szerzok.Controls.Add(bt_legjobb);
            gb_szerzok.Controls.Add(bt_szerzo_szerkesztese);
            gb_szerzok.Controls.Add(dgw_szerzok);
            gb_szerzok.Enabled = false;
            gb_szerzok.Location = new Point(40, 78);
            gb_szerzok.Name = "gb_szerzok";
            gb_szerzok.Size = new Size(710, 395);
            gb_szerzok.TabIndex = 3;
            gb_szerzok.TabStop = false;
            gb_szerzok.Text = "Szerzők";
            // 
            // bt_szerzolista
            // 
            bt_szerzolista.Location = new Point(15, 22);
            bt_szerzolista.Name = "bt_szerzolista";
            bt_szerzolista.Size = new Size(157, 23);
            bt_szerzolista.TabIndex = 3;
            bt_szerzolista.Text = "Szerzők listásása";
            bt_szerzolista.UseVisualStyleBackColor = true;
            bt_szerzolista.Click += bt_szerzolista_Click;
            // 
            // bt_legjobb
            // 
            bt_legjobb.Location = new Point(455, 338);
            bt_legjobb.Name = "bt_legjobb";
            bt_legjobb.Size = new Size(193, 23);
            bt_legjobb.TabIndex = 2;
            bt_legjobb.Text = "Kijelölt szerző legjobb helyezése";
            bt_legjobb.UseVisualStyleBackColor = true;
            bt_legjobb.Click += bt_legjobb_Click;
            // 
            // bt_szerzo_szerkesztese
            // 
            bt_szerzo_szerkesztese.Location = new Point(15, 338);
            bt_szerzo_szerkesztese.Name = "bt_szerzo_szerkesztese";
            bt_szerzo_szerkesztese.Size = new Size(157, 23);
            bt_szerzo_szerkesztese.TabIndex = 1;
            bt_szerzo_szerkesztese.Text = "Kijelölt szerző szerkesztése";
            bt_szerzo_szerkesztese.UseVisualStyleBackColor = true;
            bt_szerzo_szerkesztese.Click += bt_szerzo_szerkesztese_Click;
            // 
            // dgw_szerzok
            // 
            dgw_szerzok.AllowUserToAddRows = false;
            dgw_szerzok.AllowUserToDeleteRows = false;
            dgw_szerzok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_szerzok.Location = new Point(15, 51);
            dgw_szerzok.MultiSelect = false;
            dgw_szerzok.Name = "dgw_szerzok";
            dgw_szerzok.ReadOnly = true;
            dgw_szerzok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw_szerzok.Size = new Size(633, 281);
            dgw_szerzok.TabIndex = 0;
            dgw_szerzok.CellDoubleClick += dgw_szerzok_CellDoubleClick;
            // 
            // bt_kilepes
            // 
            bt_kilepes.Location = new Point(675, 479);
            bt_kilepes.Name = "bt_kilepes";
            bt_kilepes.Size = new Size(75, 23);
            bt_kilepes.TabIndex = 4;
            bt_kilepes.Text = "Kilépés";
            bt_kilepes.UseVisualStyleBackColor = true;
            bt_kilepes.Click += bt_kilepes_Click;
            // 
            // mc_mysqlcon
            // 
            mc_mysqlcon.ProvideClientCertificatesCallback = null;
            mc_mysqlcon.ProvidePasswordCallback = null;
            mc_mysqlcon.RemoteCertificateValidationCallback = null;
            // 
            // bt_osszes_muve
            // 
            bt_osszes_muve.Location = new Point(227, 338);
            bt_osszes_muve.Name = "bt_osszes_muve";
            bt_osszes_muve.Size = new Size(193, 23);
            bt_osszes_muve.TabIndex = 4;
            bt_osszes_muve.Text = "Kijelölt szerző összes műve";
            bt_osszes_muve.UseVisualStyleBackColor = true;
            bt_osszes_muve.Click += bt_osszes_muve_Click;
            // 
            // frm_foform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(bt_kilepes);
            Controls.Add(gb_szerzok);
            Controls.Add(lb_kapcs_allapot);
            Controls.Add(bt_kapcs_teszt);
            Controls.Add(lb_kapcs_tesztű);
            Name = "frm_foform";
            Text = "Szerzők";
            gb_szerzok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgw_szerzok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_kapcs_tesztű;
        private Button bt_kapcs_teszt;
        private Label lb_kapcs_allapot;
        private GroupBox gb_szerzok;
        private Button bt_legjobb;
        private Button bt_szerzo_szerkesztese;
        private DataGridView dgw_szerzok;
        private Button bt_kilepes;
        private MySqlConnector.MySqlConnection mc_mysqlcon;
        private Button bt_szerzolista;
        private Button bt_osszes_muve;
    }
}
