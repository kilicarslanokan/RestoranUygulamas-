namespace RestoranUygulaması
{
    partial class frmPaketServis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaketServis));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPaketSiparisAl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtAdSoyad.Location = new System.Drawing.Point(148, 223);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(118, 19);
            this.txtAdSoyad.TabIndex = 0;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.ForeColor = System.Drawing.Color.Black;
            this.txtTelNo.Location = new System.Drawing.Point(148, 280);
            this.txtTelNo.Mask = "(999) 000-0000";
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(118, 23);
            this.txtTelNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tel No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.ForeColor = System.Drawing.Color.Black;
            this.txtAdres.Location = new System.Drawing.Point(148, 334);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(118, 118);
            this.txtAdres.TabIndex = 8;
            this.txtAdres.Text = "";
            this.txtAdres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdres_KeyDown);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::RestoranUygulaması.Properties.Resources.back_jpg;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(794, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 56);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::RestoranUygulaması.Properties.Resources.close;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(875, 635);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 56);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPaketSiparisAl
            // 
            this.btnPaketSiparisAl.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPaketSiparisAl.BackColor = System.Drawing.Color.Transparent;
            this.btnPaketSiparisAl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaketSiparisAl.BorderRadius = 0;
            this.btnPaketSiparisAl.ButtonText = "Sipariş Al";
            this.btnPaketSiparisAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaketSiparisAl.DisabledColor = System.Drawing.Color.Gray;
            this.btnPaketSiparisAl.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaketSiparisAl.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPaketSiparisAl.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPaketSiparisAl.Iconimage")));
            this.btnPaketSiparisAl.Iconimage_right = null;
            this.btnPaketSiparisAl.Iconimage_right_Selected = null;
            this.btnPaketSiparisAl.Iconimage_Selected = null;
            this.btnPaketSiparisAl.IconMarginLeft = 0;
            this.btnPaketSiparisAl.IconMarginRight = 0;
            this.btnPaketSiparisAl.IconRightVisible = true;
            this.btnPaketSiparisAl.IconRightZoom = 0D;
            this.btnPaketSiparisAl.IconVisible = false;
            this.btnPaketSiparisAl.IconZoom = 90D;
            this.btnPaketSiparisAl.IsTab = false;
            this.btnPaketSiparisAl.Location = new System.Drawing.Point(72, 506);
            this.btnPaketSiparisAl.Margin = new System.Windows.Forms.Padding(5);
            this.btnPaketSiparisAl.Name = "btnPaketSiparisAl";
            this.btnPaketSiparisAl.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPaketSiparisAl.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPaketSiparisAl.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPaketSiparisAl.selected = false;
            this.btnPaketSiparisAl.Size = new System.Drawing.Size(166, 40);
            this.btnPaketSiparisAl.TabIndex = 15;
            this.btnPaketSiparisAl.Text = "Sipariş Al";
            this.btnPaketSiparisAl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPaketSiparisAl.Textcolor = System.Drawing.Color.SeaGreen;
            this.btnPaketSiparisAl.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPaketSiparisAl.Click += new System.EventHandler(this.btnPaketSiparisAl_Click_1);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 35;
            this.bunifuElipse2.TargetControl = this.btnPaketSiparisAl;
            // 
            // frmPaketServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::RestoranUygulaması.Properties.Resources.Cikis;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1015, 739);
            this.Controls.Add(this.btnPaketSiparisAl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmPaketServis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPaketServis";
            this.Load += new System.EventHandler(this.frmPaketServis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.MaskedTextBox txtTelNo;
        public System.Windows.Forms.TextBox txtAdSoyad;
        public System.Windows.Forms.RichTextBox txtAdres;
        private Bunifu.Framework.UI.BunifuFlatButton btnPaketSiparisAl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}