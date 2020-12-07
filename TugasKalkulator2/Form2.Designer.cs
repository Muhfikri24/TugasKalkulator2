
namespace TugasKalkulator2
{
    partial class Form2
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
            this.cmbOperasi = new System.Windows.Forms.ComboBox();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.Operasi = new System.Windows.Forms.Label();
            this.NilaiA = new System.Windows.Forms.Label();
            this.NilaiB = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbOperasi
            // 
            this.cmbOperasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperasi.FormattingEnabled = true;
            this.cmbOperasi.Items.AddRange(new object[] {
            "Pemjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.cmbOperasi.Location = new System.Drawing.Point(139, 15);
            this.cmbOperasi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOperasi.Name = "cmbOperasi";
            this.cmbOperasi.Size = new System.Drawing.Size(248, 33);
            this.cmbOperasi.TabIndex = 0;
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNilaiA.Location = new System.Drawing.Point(139, 86);
            this.txtNilaiA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(248, 30);
            this.txtNilaiA.TabIndex = 1;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNilaiB.Location = new System.Drawing.Point(139, 161);
            this.txtNilaiB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(248, 30);
            this.txtNilaiB.TabIndex = 2;
            // 
            // Operasi
            // 
            this.Operasi.AutoSize = true;
            this.Operasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operasi.Location = new System.Drawing.Point(21, 22);
            this.Operasi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Operasi.Name = "Operasi";
            this.Operasi.Size = new System.Drawing.Size(68, 20);
            this.Operasi.TabIndex = 4;
            this.Operasi.Text = "Operasi";
            // 
            // NilaiA
            // 
            this.NilaiA.AutoSize = true;
            this.NilaiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NilaiA.Location = new System.Drawing.Point(21, 94);
            this.NilaiA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(49, 18);
            this.NilaiA.TabIndex = 5;
            this.NilaiA.Text = "Nilai A";
            // 
            // NilaiB
            // 
            this.NilaiB.AutoSize = true;
            this.NilaiB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NilaiB.Location = new System.Drawing.Point(21, 169);
            this.NilaiB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(50, 18);
            this.NilaiB.TabIndex = 6;
            this.NilaiB.Text = "Nilai B";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(260, 231);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 41);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 287);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.Operasi);
            this.Controls.Add(this.txtNilaiB);
            this.Controls.Add(this.txtNilaiA);
            this.Controls.Add(this.cmbOperasi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOperasi;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.Label Operasi;
        private System.Windows.Forms.Label NilaiA;
        private System.Windows.Forms.Label NilaiB;
        private System.Windows.Forms.Button btnSubmit;
    }
}