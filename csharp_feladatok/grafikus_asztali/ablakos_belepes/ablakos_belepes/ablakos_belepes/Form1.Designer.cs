namespace ablakos_belepes
{
    partial class frm_belepes
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
            bt_belepes = new Button();
            bt_kilepes = new Button();
            lb_fnev = new Label();
            tb_fnev = new TextBox();
            tb_jelszo = new TextBox();
            lb_jelszo = new Label();
            SuspendLayout();
            // 
            // bt_belepes
            // 
            bt_belepes.Location = new Point(101, 109);
            bt_belepes.Name = "bt_belepes";
            bt_belepes.Size = new Size(75, 23);
            bt_belepes.TabIndex = 0;
            bt_belepes.Text = "&Belépés";
            bt_belepes.UseVisualStyleBackColor = true;
            bt_belepes.Click += bt_belepes_Click;
            // 
            // bt_kilepes
            // 
            bt_kilepes.Location = new Point(157, 157);
            bt_kilepes.Name = "bt_kilepes";
            bt_kilepes.Size = new Size(75, 23);
            bt_kilepes.TabIndex = 1;
            bt_kilepes.Text = "&Kilépés";
            bt_kilepes.UseVisualStyleBackColor = true;
            bt_kilepes.Click += bt_kilepes_Click;
            // 
            // lb_fnev
            // 
            lb_fnev.AutoSize = true;
            lb_fnev.Location = new Point(30, 29);
            lb_fnev.Name = "lb_fnev";
            lb_fnev.Size = new Size(96, 15);
            lb_fnev.TabIndex = 2;
            lb_fnev.Text = "Felhasználói név:";
            // 
            // tb_fnev
            // 
            tb_fnev.Location = new Point(132, 26);
            tb_fnev.Name = "tb_fnev";
            tb_fnev.Size = new Size(100, 23);
            tb_fnev.TabIndex = 3;
            // 
            // tb_jelszo
            // 
            tb_jelszo.Location = new Point(132, 70);
            tb_jelszo.Name = "tb_jelszo";
            tb_jelszo.PasswordChar = '*';
            tb_jelszo.Size = new Size(100, 23);
            tb_jelszo.TabIndex = 5;
            // 
            // lb_jelszo
            // 
            lb_jelszo.AutoSize = true;
            lb_jelszo.Location = new Point(30, 73);
            lb_jelszo.Name = "lb_jelszo";
            lb_jelszo.Size = new Size(40, 15);
            lb_jelszo.TabIndex = 4;
            lb_jelszo.Text = "Jelszó:";
            // 
            // frm_belepes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 199);
            Controls.Add(tb_jelszo);
            Controls.Add(lb_jelszo);
            Controls.Add(tb_fnev);
            Controls.Add(lb_fnev);
            Controls.Add(bt_kilepes);
            Controls.Add(bt_belepes);
            Name = "frm_belepes";
            Text = "Belépés";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_belepes;
        private Button bt_kilepes;
        private Label lb_fnev;
        private TextBox tb_fnev;
        private TextBox tb_jelszo;
        private Label lb_jelszo;
    }
}
