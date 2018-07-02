namespace KeyManager
{
    partial class frmKeyManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKeyManager));
            this.dtgvDatabase = new System.Windows.Forms.DataGridView();
            this.dtgvSearch = new System.Windows.Forms.DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDatabase
            // 
            this.dtgvDatabase.AllowUserToAddRows = false;
            this.dtgvDatabase.AllowUserToDeleteRows = false;
            this.dtgvDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDatabase.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDatabase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDatabase.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDatabase.Location = new System.Drawing.Point(3, 34);
            this.dtgvDatabase.Name = "dtgvDatabase";
            this.dtgvDatabase.Size = new System.Drawing.Size(348, 411);
            this.dtgvDatabase.TabIndex = 0;
            this.dtgvDatabase.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtgvDatabase_CellBeginEdit);
            this.dtgvDatabase.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDatabase_CellEndEdit);
            this.dtgvDatabase.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dtgvDatabase_RowPrePaint);
            // 
            // dtgvSearch
            // 
            this.dtgvSearch.AllowUserToAddRows = false;
            this.dtgvSearch.AllowUserToDeleteRows = false;
            this.dtgvSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSearch.ColumnHeadersVisible = false;
            this.dtgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clAddress,
            this.clDescription});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvSearch.Location = new System.Drawing.Point(3, 1);
            this.dtgvSearch.Name = "dtgvSearch";
            this.dtgvSearch.Size = new System.Drawing.Size(348, 27);
            this.dtgvSearch.TabIndex = 1;
            this.dtgvSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtgvSearch_KeyUp);
            // 
            // clID
            // 
            this.clID.HeaderText = "ID";
            this.clID.Name = "clID";
            // 
            // clAddress
            // 
            this.clAddress.HeaderText = "Address";
            this.clAddress.Name = "clAddress";
            // 
            // clDescription
            // 
            this.clDescription.HeaderText = "Description";
            this.clDescription.Name = "clDescription";
            // 
            // frmKeyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 444);
            this.Controls.Add(this.dtgvSearch);
            this.Controls.Add(this.dtgvDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKeyManager";
            this.Text = "Key Manager 1.0 - Southern Sky Realty";
            this.Load += new System.EventHandler(this.frmKeyManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDatabase;
        private System.Windows.Forms.DataGridView dtgvSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescription;
    }
}

