namespace WFA_Kwiaciarnia
{
    partial class Prepare_order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prepare_order));
            this.order_dGV = new System.Windows.Forms.DataGridView();
            this.quan_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pr_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dS_kwiaciarnia = new WFA_Kwiaciarnia.DS_kwiaciarnia();
            this.panel1 = new System.Windows.Forms.Panel();
            this.no_oreder_l = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.order_dGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_kwiaciarnia)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // order_dGV
            // 
            this.order_dGV.AllowUserToAddRows = false;
            this.order_dGV.AllowUserToDeleteRows = false;
            this.order_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quan_column,
            this.pr_column});
            this.order_dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.order_dGV.Location = new System.Drawing.Point(0, 0);
            this.order_dGV.Name = "order_dGV";
            this.order_dGV.ReadOnly = true;
            this.order_dGV.Size = new System.Drawing.Size(290, 266);
            this.order_dGV.TabIndex = 0;
            // 
            // quan_column
            // 
            this.quan_column.HeaderText = "opakowanie";
            this.quan_column.Name = "quan_column";
            this.quan_column.ReadOnly = true;
            // 
            // pr_column
            // 
            this.pr_column.HeaderText = "cena";
            this.pr_column.Name = "pr_column";
            this.pr_column.ReadOnly = true;
            // 
            // dS_kwiaciarnia
            // 
            this.dS_kwiaciarnia.DataSetName = "DS_kwiaciarnia";
            this.dS_kwiaciarnia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.no_oreder_l);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 266);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // no_oreder_l
            // 
            this.no_oreder_l.AutoSize = true;
            this.no_oreder_l.BackColor = System.Drawing.Color.Transparent;
            this.no_oreder_l.Font = new System.Drawing.Font("Lobster", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.no_oreder_l.ForeColor = System.Drawing.Color.White;
            this.no_oreder_l.Location = new System.Drawing.Point(47, 73);
            this.no_oreder_l.Name = "no_oreder_l";
            this.no_oreder_l.Size = new System.Drawing.Size(0, 28);
            this.no_oreder_l.TabIndex = 1;
            this.no_oreder_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.no_oreder_l.Visible = false;
            // 
            // Prepare_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(290, 266);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.order_dGV);
            this.Name = "Prepare_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prepare_order";
            ((System.ComponentModel.ISupportInitialize)(this.order_dGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_kwiaciarnia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView order_dGV;
        private DS_kwiaciarnia dS_kwiaciarnia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label no_oreder_l;
        private System.Windows.Forms.DataGridViewTextBoxColumn quan_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn pr_column;
    }
}