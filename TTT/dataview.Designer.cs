namespace TTT
{
    partial class dataview
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btshow = new System.Windows.Forms.Button();
            this.tdata_username = new System.Windows.Forms.TextBox();
            this.bdata_edit = new System.Windows.Forms.Button();
            this.lbldatausername = new System.Windows.Forms.Label();
            this.bdata_delete = new System.Windows.Forms.Button();
            this.lbldata_number = new System.Windows.Forms.Label();
            this.tdata_number = new System.Windows.Forms.TextBox();
            this.tdata_search = new System.Windows.Forms.TextBox();
            this.bdata_search = new System.Windows.Forms.Button();
            this.bdata_refresh = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(528, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(234, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btshow
            // 
            this.btshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btshow.Location = new System.Drawing.Point(17, 356);
            this.btshow.Name = "btshow";
            this.btshow.Size = new System.Drawing.Size(222, 41);
            this.btshow.TabIndex = 1;
            this.btshow.Text = "View Data";
            this.btshow.UseVisualStyleBackColor = true;
            this.btshow.Click += new System.EventHandler(this.btshow_Click);
            // 
            // tdata_username
            // 
            this.tdata_username.Location = new System.Drawing.Point(12, 118);
            this.tdata_username.Name = "tdata_username";
            this.tdata_username.Size = new System.Drawing.Size(222, 22);
            this.tdata_username.TabIndex = 2;
            this.tdata_username.TextChanged += new System.EventHandler(this.tdata_username_TextChanged);
            // 
            // bdata_edit
            // 
            this.bdata_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bdata_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdata_edit.Location = new System.Drawing.Point(17, 403);
            this.bdata_edit.Name = "bdata_edit";
            this.bdata_edit.Size = new System.Drawing.Size(222, 44);
            this.bdata_edit.TabIndex = 3;
            this.bdata_edit.Text = "Edit Account";
            this.bdata_edit.UseVisualStyleBackColor = true;
            this.bdata_edit.Click += new System.EventHandler(this.bdata_edit_Click);
            // 
            // lbldatausername
            // 
            this.lbldatausername.AutoSize = true;
            this.lbldatausername.BackColor = System.Drawing.Color.Transparent;
            this.lbldatausername.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatausername.Location = new System.Drawing.Point(12, 88);
            this.lbldatausername.Name = "lbldatausername";
            this.lbldatausername.Size = new System.Drawing.Size(125, 27);
            this.lbldatausername.TabIndex = 4;
            this.lbldatausername.Text = "User Name";
            this.lbldatausername.Click += new System.EventHandler(this.label1_Click);
            // 
            // bdata_delete
            // 
            this.bdata_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bdata_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdata_delete.Location = new System.Drawing.Point(17, 453);
            this.bdata_delete.Name = "bdata_delete";
            this.bdata_delete.Size = new System.Drawing.Size(222, 47);
            this.bdata_delete.TabIndex = 5;
            this.bdata_delete.Text = "Delete Account";
            this.bdata_delete.UseVisualStyleBackColor = true;
            this.bdata_delete.Click += new System.EventHandler(this.bdata_delete_Click);
            // 
            // lbldata_number
            // 
            this.lbldata_number.AutoSize = true;
            this.lbldata_number.BackColor = System.Drawing.Color.Transparent;
            this.lbldata_number.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata_number.Location = new System.Drawing.Point(12, 154);
            this.lbldata_number.Name = "lbldata_number";
            this.lbldata_number.Size = new System.Drawing.Size(165, 27);
            this.lbldata_number.TabIndex = 7;
            this.lbldata_number.Text = "Phone Number";
            // 
            // tdata_number
            // 
            this.tdata_number.Location = new System.Drawing.Point(12, 184);
            this.tdata_number.Name = "tdata_number";
            this.tdata_number.Size = new System.Drawing.Size(216, 22);
            this.tdata_number.TabIndex = 8;
            // 
            // tdata_search
            // 
            this.tdata_search.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tdata_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tdata_search.Location = new System.Drawing.Point(528, 61);
            this.tdata_search.Name = "tdata_search";
            this.tdata_search.Size = new System.Drawing.Size(235, 22);
            this.tdata_search.TabIndex = 10;
            this.tdata_search.TextChanged += new System.EventHandler(this.tdata_search_TextChanged);
            // 
            // bdata_search
            // 
            this.bdata_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bdata_search.BackgroundImage = global::TTT.Properties.Resources.Search_black;
            this.bdata_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bdata_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bdata_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdata_search.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bdata_search.Location = new System.Drawing.Point(769, 53);
            this.bdata_search.Name = "bdata_search";
            this.bdata_search.Size = new System.Drawing.Size(48, 38);
            this.bdata_search.TabIndex = 9;
            this.bdata_search.UseVisualStyleBackColor = false;
            this.bdata_search.Click += new System.EventHandler(this.bdata_search_Click);
            // 
            // bdata_refresh
            // 
            this.bdata_refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bdata_refresh.BackgroundImage = global::TTT.Properties.Resources.Refresh;
            this.bdata_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bdata_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bdata_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdata_refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bdata_refresh.Location = new System.Drawing.Point(855, 53);
            this.bdata_refresh.Name = "bdata_refresh";
            this.bdata_refresh.Size = new System.Drawing.Size(43, 38);
            this.bdata_refresh.TabIndex = 6;
            this.bdata_refresh.UseVisualStyleBackColor = false;
            this.bdata_refresh.Click += new System.EventHandler(this.bdata_refresh_Click);
            // 
            // dataview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::TTT.Properties.Resources.data_view;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 545);
            this.Controls.Add(this.tdata_search);
            this.Controls.Add(this.bdata_search);
            this.Controls.Add(this.tdata_number);
            this.Controls.Add(this.lbldata_number);
            this.Controls.Add(this.bdata_refresh);
            this.Controls.Add(this.bdata_delete);
            this.Controls.Add(this.lbldatausername);
            this.Controls.Add(this.bdata_edit);
            this.Controls.Add(this.tdata_username);
            this.Controls.Add(this.btshow);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "dataview";
            this.Text = "dataview";
            this.Load += new System.EventHandler(this.dataview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btshow;
        private System.Windows.Forms.TextBox tdata_username;
        private System.Windows.Forms.Button bdata_edit;
        private System.Windows.Forms.Label lbldatausername;
        private System.Windows.Forms.Button bdata_delete;
        private System.Windows.Forms.Button bdata_refresh;
        private System.Windows.Forms.Label lbldata_number;
        private System.Windows.Forms.TextBox tdata_number;
        private System.Windows.Forms.Button bdata_search;
        private System.Windows.Forms.TextBox tdata_search;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}