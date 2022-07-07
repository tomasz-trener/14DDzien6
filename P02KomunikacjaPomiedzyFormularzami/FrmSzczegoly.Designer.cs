namespace P02KomunikacjaPomiedzyFormularzami
{
    partial class FrmSzczegoly
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
            this.btnWyslij = new System.Windows.Forms.Button();
            this.txtDane = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(12, 12);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(75, 23);
            this.btnWyslij.TabIndex = 0;
            this.btnWyslij.Text = "Wyslij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // txtDane
            // 
            this.txtDane.Location = new System.Drawing.Point(12, 42);
            this.txtDane.Name = "txtDane";
            this.txtDane.Size = new System.Drawing.Size(238, 20);
            this.txtDane.TabIndex = 1;
            // 
            // FrmSzczegoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 90);
            this.Controls.Add(this.txtDane);
            this.Controls.Add(this.btnWyslij);
            this.Name = "FrmSzczegoly";
            this.Text = "FrmSzczegoly";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSzczegoly_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWyslij;
        private System.Windows.Forms.TextBox txtDane;
    }
}