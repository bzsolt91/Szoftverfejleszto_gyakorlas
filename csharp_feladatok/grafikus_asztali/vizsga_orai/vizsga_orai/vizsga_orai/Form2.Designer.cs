namespace vizsga_orai
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
            bt_mentes = new Button();
            bt_megse = new Button();
            tb_szerzo_neve = new TextBox();
            tb_halev = new TextBox();
            tb_nemzetisege = new TextBox();
            tb_szulev = new TextBox();
            SuspendLayout();
            // 
            // bt_mentes
            // 
            bt_mentes.Location = new Point(69, 297);
            bt_mentes.Name = "bt_mentes";
            bt_mentes.Size = new Size(75, 23);
            bt_mentes.TabIndex = 0;
            bt_mentes.Text = "Mentés";
            bt_mentes.UseVisualStyleBackColor = true;
            bt_mentes.Click += bt_mentes_Click;
            // 
            // bt_megse
            // 
            bt_megse.Location = new Point(243, 297);
            bt_megse.Name = "bt_megse";
            bt_megse.Size = new Size(75, 23);
            bt_megse.TabIndex = 1;
            bt_megse.Text = "Mégse";
            bt_megse.UseVisualStyleBackColor = true;
            bt_megse.Click += bt_megse_Click;
            // 
            // tb_szerzo_neve
            // 
            tb_szerzo_neve.Location = new Point(119, 63);
            tb_szerzo_neve.Name = "tb_szerzo_neve";
            tb_szerzo_neve.Size = new Size(147, 23);
            tb_szerzo_neve.TabIndex = 2;
            // 
            // tb_halev
            // 
            tb_halev.Location = new Point(119, 177);
            tb_halev.Name = "tb_halev";
            tb_halev.Size = new Size(147, 23);
            tb_halev.TabIndex = 3;
            // 
            // tb_nemzetisege
            // 
            tb_nemzetisege.Location = new Point(119, 234);
            tb_nemzetisege.Name = "tb_nemzetisege";
            tb_nemzetisege.Size = new Size(147, 23);
            tb_nemzetisege.TabIndex = 4;
            // 
            // tb_szulev
            // 
            tb_szulev.Location = new Point(119, 120);
            tb_szulev.Name = "tb_szulev";
            tb_szulev.Size = new Size(147, 23);
            tb_szulev.TabIndex = 6;
            // 
            // frm_szerzo_szerkesztese
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 349);
            Controls.Add(tb_szulev);
            Controls.Add(tb_nemzetisege);
            Controls.Add(tb_halev);
            Controls.Add(tb_szerzo_neve);
            Controls.Add(bt_megse);
            Controls.Add(bt_mentes);
            Name = "frm_szerzo_szerkesztese";
            Text = "Szerző szerkesztése";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_mentes;
        private Button bt_megse;
        private TextBox tb_szerzo_neve;
        private TextBox tb_halev;
        private TextBox tb_nemzetisege;
        private TextBox tb_szulev;
    }
}