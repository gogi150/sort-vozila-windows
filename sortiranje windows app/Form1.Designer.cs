namespace sortiranje_windows_app
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
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.btnBriši = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(254, 83);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(125, 26);
            this.txtMarka.TabIndex = 0;
            this.txtMarka.TextChanged += new System.EventHandler(this.txtMarka_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(254, 149);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(125, 26);
            this.txtModel.TabIndex = 1;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(254, 226);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(125, 26);
            this.txtGodinaProizvodnje.TabIndex = 2;
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(254, 288);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(125, 26);
            this.txtKilometraza.TabIndex = 3;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(477, 83);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(280, 231);
            this.txtIspis.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Godina Proizvodnje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kilometraza";
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(245, 352);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(116, 42);
            this.btnUnos.TabIndex = 9;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(409, 352);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(108, 42);
            this.btnSortiraj.TabIndex = 10;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            // 
            // btnBriši
            // 
            this.btnBriši.Location = new System.Drawing.Point(568, 352);
            this.btnBriši.Name = "btnBriši";
            this.btnBriši.Size = new System.Drawing.Size(110, 42);
            this.btnBriši.TabIndex = 11;
            this.btnBriši.Text = "Briši";
            this.btnBriši.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBriši);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.Button btnBriši;
    }
}

