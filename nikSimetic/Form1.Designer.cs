namespace nikSimetic
{
    partial class Form1
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
            this.chbDorucak = new System.Windows.Forms.CheckBox();
            this.chbRucak = new System.Windows.Forms.CheckBox();
            this.chbVecera = new System.Windows.Forms.CheckBox();
            this.txtPrikaz = new System.Windows.Forms.TextBox();
            this.chbSakrijNarudbu = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chbDorucak
            // 
            this.chbDorucak.AutoSize = true;
            this.chbDorucak.Location = new System.Drawing.Point(52, 85);
            this.chbDorucak.Name = "chbDorucak";
            this.chbDorucak.Size = new System.Drawing.Size(67, 17);
            this.chbDorucak.TabIndex = 5;
            this.chbDorucak.Text = "Dorucak";
            this.chbDorucak.UseVisualStyleBackColor = true;
            // 
            // chbRucak
            // 
            this.chbRucak.AutoSize = true;
            this.chbRucak.Location = new System.Drawing.Point(52, 162);
            this.chbRucak.Name = "chbRucak";
            this.chbRucak.Size = new System.Drawing.Size(58, 17);
            this.chbRucak.TabIndex = 6;
            this.chbRucak.Text = "Rucak";
            this.chbRucak.UseVisualStyleBackColor = true;
            // 
            // chbVecera
            // 
            this.chbVecera.AutoSize = true;
            this.chbVecera.Location = new System.Drawing.Point(52, 262);
            this.chbVecera.Name = "chbVecera";
            this.chbVecera.Size = new System.Drawing.Size(60, 17);
            this.chbVecera.TabIndex = 7;
            this.chbVecera.Text = "Vecera";
            this.chbVecera.UseVisualStyleBackColor = true;
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Location = new System.Drawing.Point(274, 76);
            this.txtPrikaz.Multiline = true;
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.Size = new System.Drawing.Size(457, 203);
            this.txtPrikaz.TabIndex = 8;
            // 
            // chbSakrijNarudbu
            // 
            this.chbSakrijNarudbu.AutoSize = true;
            this.chbSakrijNarudbu.Location = new System.Drawing.Point(363, 367);
            this.chbSakrijNarudbu.Name = "chbSakrijNarudbu";
            this.chbSakrijNarudbu.Size = new System.Drawing.Size(96, 17);
            this.chbSakrijNarudbu.TabIndex = 9;
            this.chbSakrijNarudbu.Text = "Sakrij Narudbu";
            this.chbSakrijNarudbu.UseVisualStyleBackColor = true;
            this.chbSakrijNarudbu.CheckedChanged += new System.EventHandler(this.chbSakrijNarudbu_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Posalji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chbSakrijNarudbu);
            this.Controls.Add(this.txtPrikaz);
            this.Controls.Add(this.chbVecera);
            this.Controls.Add(this.chbRucak);
            this.Controls.Add(this.chbDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbDorucak;
        private System.Windows.Forms.CheckBox chbRucak;
        private System.Windows.Forms.CheckBox chbVecera;
        private System.Windows.Forms.TextBox txtPrikaz;
        private System.Windows.Forms.CheckBox chbSakrijNarudbu;
        private System.Windows.Forms.Button button1;
    }
}

