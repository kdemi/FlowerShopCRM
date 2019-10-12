namespace WFA_Kwiaciarnia
{
    partial class Otworz_baze_WF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Otworz_baze_WF));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Main_dGV = new System.Windows.Forms.DataGridView();
            this.checkBcolumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Save_changes_column = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.add_tslbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_tslbl = new System.Windows.Forms.ToolStripLabel();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.delete_tslbl = new System.Windows.Forms.ToolStripLabel();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.supply_tlsl_MGV = new System.Windows.Forms.ToolStripLabel();
            this.tlStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.Main_dGV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Main_dGV
            // 
            this.Main_dGV.AllowUserToAddRows = false;
            this.Main_dGV.AllowUserToDeleteRows = false;
            this.Main_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Main_dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBcolumn,
            this.Save_changes_column});
            this.Main_dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_dGV.Location = new System.Drawing.Point(3, 25);
            this.Main_dGV.Name = "Main_dGV";
            this.Main_dGV.Size = new System.Drawing.Size(388, 203);
            this.Main_dGV.TabIndex = 1;
            this.Main_dGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Main_dGV_CellClick);
            // 
            // checkBcolumn
            // 
            this.checkBcolumn.HeaderText = "";
            this.checkBcolumn.Name = "checkBcolumn";
            this.checkBcolumn.ReadOnly = true;
            this.checkBcolumn.Width = 20;
            // 
            // Save_changes_column
            // 
            this.Save_changes_column.HeaderText = "";
            this.Save_changes_column.Image = ((System.Drawing.Image)(resources.GetObject("Save_changes_column.Image")));
            this.Save_changes_column.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Save_changes_column.Name = "Save_changes_column";
            this.Save_changes_column.Visible = false;
            this.Save_changes_column.Width = 20;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_tslbl,
            this.toolStripSeparator3,
            this.edit_tslbl,
            this.tsSeparator1,
            this.delete_tslbl,
            this.tsSeparator2,
            this.supply_tlsl_MGV,
            this.tlStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(394, 22);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // add_tslbl
            // 
            this.add_tslbl.Name = "add_tslbl";
            this.add_tslbl.Size = new System.Drawing.Size(29, 19);
            this.add_tslbl.Text = "Add";
            this.add_tslbl.Click += new System.EventHandler(this.Add_tslbl_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 22);
            // 
            // edit_tslbl
            // 
            this.edit_tslbl.BackColor = System.Drawing.SystemColors.Control;
            this.edit_tslbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.edit_tslbl.Name = "edit_tslbl";
            this.edit_tslbl.Size = new System.Drawing.Size(27, 19);
            this.edit_tslbl.Text = "Edit";
            this.edit_tslbl.Visible = false;
            this.edit_tslbl.Click += new System.EventHandler(this.Edit_tslbl_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 22);
            this.tsSeparator1.Visible = false;
            // 
            // delete_tslbl
            // 
            this.delete_tslbl.Name = "delete_tslbl";
            this.delete_tslbl.Size = new System.Drawing.Size(40, 19);
            this.delete_tslbl.Text = "Delete";
            this.delete_tslbl.Visible = false;
            this.delete_tslbl.Click += new System.EventHandler(this.Delete_tslbl_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 22);
            this.tsSeparator2.Visible = false;
            // 
            // supply_tlsl_MGV
            // 
            this.supply_tlsl_MGV.Name = "supply_tlsl_MGV";
            this.supply_tlsl_MGV.Size = new System.Drawing.Size(43, 19);
            this.supply_tlsl_MGV.Text = "Supply";
            this.supply_tlsl_MGV.Visible = false;
            this.supply_tlsl_MGV.Click += new System.EventHandler(this.Supply_tlsl_MGV_Click);
            // 
            // tlStripSeparator1
            // 
            this.tlStripSeparator1.Name = "tlStripSeparator1";
            this.tlStripSeparator1.Size = new System.Drawing.Size(6, 22);
            this.tlStripSeparator1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Main_dGV, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.565217F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.43478F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 231);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Otworz_baze_WF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 231);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Otworz_baze_WF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otworz_baze_WF";
            ((System.ComponentModel.ISupportInitialize)(this.Main_dGV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView Main_dGV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel add_tslbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel edit_tslbl;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripLabel delete_tslbl;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBcolumn;
        private System.Windows.Forms.DataGridViewImageColumn Save_changes_column;
        private System.Windows.Forms.ToolStripLabel supply_tlsl_MGV;
        private System.Windows.Forms.ToolStripSeparator tlStripSeparator1;
    }
}