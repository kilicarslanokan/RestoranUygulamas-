namespace RestoranUygulaması
{
    partial class frmRezervasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyon));
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.cmbMasaNo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bunibtnRezerveEt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtSaat = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(175, 187);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(134, 27);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // cmbMasaNo
            // 
            this.cmbMasaNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbMasaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.cmbMasaNo.FormattingEnabled = true;
            this.cmbMasaNo.Location = new System.Drawing.Point(175, 318);
            this.cmbMasaNo.Name = "cmbMasaNo";
            this.cmbMasaNo.Size = new System.Drawing.Size(134, 36);
            this.cmbMasaNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tel No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Masa No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saat";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.txtTelefon.Location = new System.Drawing.Point(175, 251);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(134, 30);
            this.txtTelefon.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.BackgroundImage = global::RestoranUygulaması.Properties.Resources.back_jpg;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(833, 648);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 56);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(911, 648);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 56);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunibtnRezerveEt
            // 
            this.bunibtnRezerveEt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunibtnRezerveEt.BackColor = System.Drawing.Color.Transparent;
            this.bunibtnRezerveEt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunibtnRezerveEt.BorderRadius = 0;
            this.bunibtnRezerveEt.ButtonText = "Rezerve Et";
            this.bunibtnRezerveEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunibtnRezerveEt.DisabledColor = System.Drawing.Color.Gray;
            this.bunibtnRezerveEt.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunibtnRezerveEt.Iconcolor = System.Drawing.Color.Transparent;
            this.bunibtnRezerveEt.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunibtnRezerveEt.Iconimage")));
            this.bunibtnRezerveEt.Iconimage_right = null;
            this.bunibtnRezerveEt.Iconimage_right_Selected = null;
            this.bunibtnRezerveEt.Iconimage_Selected = null;
            this.bunibtnRezerveEt.IconMarginLeft = 0;
            this.bunibtnRezerveEt.IconMarginRight = 0;
            this.bunibtnRezerveEt.IconRightVisible = true;
            this.bunibtnRezerveEt.IconRightZoom = 0D;
            this.bunibtnRezerveEt.IconVisible = false;
            this.bunibtnRezerveEt.IconZoom = 90D;
            this.bunibtnRezerveEt.IsTab = false;
            this.bunibtnRezerveEt.Location = new System.Drawing.Point(94, 488);
            this.bunibtnRezerveEt.Margin = new System.Windows.Forms.Padding(5);
            this.bunibtnRezerveEt.Name = "bunibtnRezerveEt";
            this.bunibtnRezerveEt.Normalcolor = System.Drawing.Color.Transparent;
            this.bunibtnRezerveEt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunibtnRezerveEt.OnHoverTextColor = System.Drawing.Color.White;
            this.bunibtnRezerveEt.selected = false;
            this.bunibtnRezerveEt.Size = new System.Drawing.Size(166, 40);
            this.bunibtnRezerveEt.TabIndex = 14;
            this.bunibtnRezerveEt.Text = "Rezerve Et";
            this.bunibtnRezerveEt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunibtnRezerveEt.Textcolor = System.Drawing.Color.SeaGreen;
            this.bunibtnRezerveEt.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunibtnRezerveEt.Click += new System.EventHandler(this.bunibtnRezerveEt_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 35;
            this.bunifuElipse2.TargetControl = this.bunibtnRezerveEt;
            // 
            // txtSaat
            // 
            this.txtSaat.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.txtSaat.Location = new System.Drawing.Point(175, 391);
            this.txtSaat.Mask = "00:00";
            this.txtSaat.Name = "txtSaat";
            this.txtSaat.Size = new System.Drawing.Size(69, 34);
            this.txtSaat.TabIndex = 15;
            this.txtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1015, 739);
            this.Controls.Add(this.txtSaat);
            this.Controls.Add(this.bunibtnRezerveEt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMasaNo);
            this.Controls.Add(this.txtAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmRezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRezervasyon";
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuFlatButton bunibtnRezerveEt;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        public System.Windows.Forms.ComboBox cmbMasaNo;
        public System.Windows.Forms.TextBox txtAdSoyad;
        public System.Windows.Forms.MaskedTextBox txtTelefon;
        public System.Windows.Forms.MaskedTextBox txtSaat;
    }
}