namespace RestoranUygulaması
{
    partial class frmSifreSıfırla
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
            this.components = new System.ComponentModel.Container();
            this.txtMailKontrol = new System.Windows.Forms.TextBox();
            this.btnSifreSifirla = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMailKontrol
            // 
            this.txtMailKontrol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMailKontrol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMailKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMailKontrol.Location = new System.Drawing.Point(105, 195);
            this.txtMailKontrol.Name = "txtMailKontrol";
            this.txtMailKontrol.Size = new System.Drawing.Size(346, 29);
            this.txtMailKontrol.TabIndex = 3;
            // 
            // btnSifreSifirla
            // 
            this.btnSifreSifirla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSifreSifirla.BackColor = System.Drawing.Color.Sienna;
            this.btnSifreSifirla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSifreSifirla.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.btnSifreSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifreSifirla.ForeColor = System.Drawing.Color.White;
            this.btnSifreSifirla.Location = new System.Drawing.Point(178, 283);
            this.btnSifreSifirla.Name = "btnSifreSifirla";
            this.btnSifreSifirla.Size = new System.Drawing.Size(200, 65);
            this.btnSifreSifirla.TabIndex = 7;
            this.btnSifreSifirla.Text = "ŞİFREYİ SIFIRLA";
            this.btnSifreSifirla.UseVisualStyleBackColor = false;
            this.btnSifreSifirla.Click += new System.EventHandler(this.btnSifreSifirla_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 35;
            this.bunifuElipse2.TargetControl = this.btnSifreSifirla;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(162, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lütfen Mail Adresinizi Giriniz";
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCikis.BackgroundImage = global::RestoranUygulaması.Properties.Resources.close;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Location = new System.Drawing.Point(473, 471);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(62, 56);
            this.btnCikis.TabIndex = 11;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGeri.BackgroundImage = global::RestoranUygulaması.Properties.Resources.back_jpg;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.Location = new System.Drawing.Point(405, 471);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(62, 56);
            this.btnGeri.TabIndex = 10;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // frmSifreSıfırla
            // 
            this.AcceptButton = this.btnSifreSifirla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(557, 552);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSifreSifirla);
            this.Controls.Add(this.txtMailKontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmSifreSıfırla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSİfreSıfırla";
            this.Load += new System.EventHandler(this.frmSifreSıfırla_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSifreSıfırla_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMailKontrol;
        private System.Windows.Forms.Button btnSifreSifirla;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeri;
    }
}