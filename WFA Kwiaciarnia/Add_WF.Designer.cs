namespace WFA_Kwiaciarnia
{
    partial class Add_WF
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
            this.label1 = new System.Windows.Forms.Label();
            this.dodaj_ADD_B = new System.Windows.Forms.Button();
            this.nazwa_tB = new System.Windows.Forms.TextBox();
            this.ilosc_tB = new System.Windows.Forms.TextBox();
            this.cena_tB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nazwa :";
            // 
            // dodaj_ADD_B
            // 
            this.dodaj_ADD_B.Location = new System.Drawing.Point(144, 107);
            this.dodaj_ADD_B.Name = "dodaj_ADD_B";
            this.dodaj_ADD_B.Size = new System.Drawing.Size(107, 36);
            this.dodaj_ADD_B.TabIndex = 3;
            this.dodaj_ADD_B.Text = "Dodaj";
            this.dodaj_ADD_B.UseVisualStyleBackColor = true;
            this.dodaj_ADD_B.Click += new System.EventHandler(this.dodaj_ADD_B_Click);
            // 
            // nazwa_tB
            // 
            this.nazwa_tB.Location = new System.Drawing.Point(64, 13);
            this.nazwa_tB.Name = "nazwa_tB";
            this.nazwa_tB.Size = new System.Drawing.Size(187, 20);
            this.nazwa_tB.TabIndex = 6;
            // 
            // ilosc_tB
            // 
            this.ilosc_tB.Location = new System.Drawing.Point(64, 72);
            this.ilosc_tB.Name = "ilosc_tB";
            this.ilosc_tB.Size = new System.Drawing.Size(187, 20);
            this.ilosc_tB.TabIndex = 7;
            // 
            // cena_tB
            // 
            this.cena_tB.Location = new System.Drawing.Point(64, 43);
            this.cena_tB.Name = "cena_tB";
            this.cena_tB.Size = new System.Drawing.Size(187, 20);
            this.cena_tB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "cena :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ilość :";
            // 
            // Add_WF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 148);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cena_tB);
            this.Controls.Add(this.ilosc_tB);
            this.Controls.Add(this.nazwa_tB);
            this.Controls.Add(this.dodaj_ADD_B);
            this.Controls.Add(this.label1);
            this.Name = "Add_WF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_WF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dodaj_ADD_B;
        private System.Windows.Forms.TextBox nazwa_tB;
        private System.Windows.Forms.TextBox ilosc_tB;
        private System.Windows.Forms.TextBox cena_tB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}