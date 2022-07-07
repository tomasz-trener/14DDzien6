namespace P01AplikacjaZawodnicy
{
    partial class FrmZawodnicy
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtSzukaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStrona = new System.Windows.Forms.TextBox();
            this.pbStronaPrawo = new System.Windows.Forms.PictureBox();
            this.pbStronaLewo = new System.Windows.Forms.PictureBox();
            this.lblLiczbaStron = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbStronaPrawo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStronaLewo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 77);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(237, 251);
            this.lbDane.TabIndex = 0;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 12);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(75, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Location = new System.Drawing.Point(174, 12);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(75, 23);
            this.btnSzczegoly.TabIndex = 2;
            this.btnSzczegoly.Text = "Szczegoly";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(93, 12);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtSzukaj
            // 
            this.txtSzukaj.Location = new System.Drawing.Point(149, 41);
            this.txtSzukaj.Name = "txtSzukaj";
            this.txtSzukaj.Size = new System.Drawing.Size(100, 20);
            this.txtSzukaj.TabIndex = 4;
            this.txtSzukaj.TextChanged += new System.EventHandler(this.txtSzukaj_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Szukaj";
            // 
            // txtStrona
            // 
            this.txtStrona.Location = new System.Drawing.Point(54, 343);
            this.txtStrona.Name = "txtStrona";
            this.txtStrona.Size = new System.Drawing.Size(36, 20);
            this.txtStrona.TabIndex = 8;
            this.txtStrona.Text = "1";
            this.txtStrona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbStronaPrawo
            // 
            this.pbStronaPrawo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStronaPrawo.Image = global::P01AplikacjaZawodnicy.Properties.Resources.arrowRight;
            this.pbStronaPrawo.Location = new System.Drawing.Point(96, 334);
            this.pbStronaPrawo.Name = "pbStronaPrawo";
            this.pbStronaPrawo.Size = new System.Drawing.Size(36, 37);
            this.pbStronaPrawo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStronaPrawo.TabIndex = 10;
            this.pbStronaPrawo.TabStop = false;
            this.pbStronaPrawo.Click += new System.EventHandler(this.pbStronaPrawo_Click);
            // 
            // pbStronaLewo
            // 
            this.pbStronaLewo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStronaLewo.Image = global::P01AplikacjaZawodnicy.Properties.Resources.arrowLeft;
            this.pbStronaLewo.Location = new System.Drawing.Point(12, 334);
            this.pbStronaLewo.Name = "pbStronaLewo";
            this.pbStronaLewo.Size = new System.Drawing.Size(36, 37);
            this.pbStronaLewo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStronaLewo.TabIndex = 9;
            this.pbStronaLewo.TabStop = false;
            this.pbStronaLewo.Click += new System.EventHandler(this.pbStronaLewo_Click);
            // 
            // lblLiczbaStron
            // 
            this.lblLiczbaStron.AutoSize = true;
            this.lblLiczbaStron.Location = new System.Drawing.Point(138, 347);
            this.lblLiczbaStron.Name = "lblLiczbaStron";
            this.lblLiczbaStron.Size = new System.Drawing.Size(35, 13);
            this.lblLiczbaStron.TabIndex = 11;
            this.lblLiczbaStron.Text = "label2";
            // 
            // FrmZawodnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 375);
            this.Controls.Add(this.lblLiczbaStron);
            this.Controls.Add(this.pbStronaPrawo);
            this.Controls.Add(this.pbStronaLewo);
            this.Controls.Add(this.txtStrona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSzukaj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnSzczegoly);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmZawodnicy";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbStronaPrawo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStronaLewo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnSzczegoly;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtSzukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStrona;
        private System.Windows.Forms.PictureBox pbStronaLewo;
        private System.Windows.Forms.PictureBox pbStronaPrawo;
        private System.Windows.Forms.Label lblLiczbaStron;
    }
}

