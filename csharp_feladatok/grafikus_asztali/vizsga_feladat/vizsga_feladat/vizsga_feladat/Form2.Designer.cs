namespace vizsga_feladat
{
    partial class frm_szerzo_szerkesztese
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_megse = new Button();
            lb_szerzo_neve = new Label();
            lb_szulev = new Label();
            lb_halev = new Label();
            lb_nemzetisege = new Label();
            tb_szerzo_neve = new TextBox();
            tb_nemzetisege = new TextBox();
            tb_halev = new TextBox();
            tb_szulev = new TextBox();
            bt_mentes = new Button();
            SuspendLayout();
            // 
            // bt_megse
            // 
            bt_megse.Location = new Point(215, 261);
            bt_megse.Name = "bt_megse";
            bt_megse.Size = new Size(75, 23);
            bt_megse.TabIndex = 0;
            bt_megse.Text = "Mégse";
            bt_megse.UseVisualStyleBackColor = true;
            bt_megse.Click += bt_megse_Click;
            // 
            // lb_szerzo_neve
            // 
            lb_szerzo_neve.AutoSize = true;
            lb_szerzo_neve.Location = new Point(51, 51);
            lb_szerzo_neve.Name = "lb_szerzo_neve";
            lb_szerzo_neve.Size = new Size(71, 15);
            lb_szerzo_neve.TabIndex = 1;
            lb_szerzo_neve.Text = "Szerző neve:";
            // 
            // lb_szulev
            // 
            lb_szulev.AutoSize = true;
            lb_szulev.Location = new Point(51, 100);
            lb_szulev.Name = "lb_szulev";
            lb_szulev.Size = new Size(76, 15);
            lb_szulev.TabIndex = 2;
            lb_szulev.Text = "Születési éve:";
            // 
            // lb_halev
            // 
            lb_halev.AutoSize = true;
            lb_halev.Location = new Point(51, 149);
            lb_halev.Name = "lb_halev";
            lb_halev.Size = new Size(83, 15);
            lb_halev.TabIndex = 3;
            lb_halev.Text = "Halálának éve:";
            // 
            // lb_nemzetisege
            // 
            lb_nemzetisege.AutoSize = true;
            lb_nemzetisege.Location = new Point(51, 194);
            lb_nemzetisege.Name = "lb_nemzetisege";
            lb_nemzetisege.Size = new Size(78, 15);
            lb_nemzetisege.TabIndex = 4;
            lb_nemzetisege.Text = "Nemzetisége:";
            // 
            // tb_szerzo_neve
            // 
            tb_szerzo_neve.Location = new Point(165, 48);
            tb_szerzo_neve.Name = "tb_szerzo_neve";
            tb_szerzo_neve.Size = new Size(125, 23);
            tb_szerzo_neve.TabIndex = 5;
            // 
            // tb_nemzetisege
            // 
            tb_nemzetisege.Location = new Point(165, 191);
            tb_nemzetisege.Name = "tb_nemzetisege";
            tb_nemzetisege.Size = new Size(125, 23);
            tb_nemzetisege.TabIndex = 6;
            // 
            // tb_halev
            // 
            tb_halev.Location = new Point(165, 146);
            tb_halev.Name = "tb_halev";
            tb_halev.Size = new Size(125, 23);
            tb_halev.TabIndex = 7;
            // 
            // tb_szulev
            // 
            tb_szulev.Location = new Point(165, 97);
            tb_szulev.Name = "tb_szulev";
            tb_szulev.Size = new Size(125, 23);
            tb_szulev.TabIndex = 8;
            // 
            // bt_mentes
            // 
            bt_mentes.Location = new Point(51, 261);
            bt_mentes.Name = "bt_mentes";
            bt_mentes.Size = new Size(75, 23);
            bt_mentes.TabIndex = 9;
            bt_mentes.Text = "Mentés";
            bt_mentes.UseVisualStyleBackColor = true;
            bt_mentes.Click += bt_mentes_Click;
            // 
            // frm_szerzo_szerkesztese
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 316);
            Controls.Add(bt_mentes);
            Controls.Add(tb_szulev);
            Controls.Add(tb_halev);
            Controls.Add(tb_nemzetisege);
            Controls.Add(tb_szerzo_neve);
            Controls.Add(lb_nemzetisege);
            Controls.Add(lb_halev);
            Controls.Add(lb_szulev);
            Controls.Add(lb_szerzo_neve);
            Controls.Add(bt_megse);
            Name = "frm_szerzo_szerkesztese";
            Text = "Szerző szerkesztése";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_megse;
        private Label lb_szerzo_neve;
        private Label lb_szulev;
        private Label lb_halev;
        private Label lb_nemzetisege;
        private TextBox tb_szerzo_neve;
        private TextBox tb_nemzetisege;
        private TextBox tb_halev;
        private TextBox tb_szulev;
        private Button bt_mentes;
    }
}