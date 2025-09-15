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
            this.bdata_refresh = new System.Windows.Forms.Button();
            this.lbldata_number = new System.Windows.Forms.Label();
            this.tdata_number = new System.Windows.Forms.TextBox();
            this.bdata_search = new System.Windows.Forms.Button();
            this.tdata_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(870, 239);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btshow
            // 
            this.btshow.Location = new System.Drawing.Point(416, 275);
            this.btshow.Name = "btshow";
            this.btshow.Size = new System.Drawing.Size(75, 23);
            this.btshow.TabIndex = 1;
            this.btshow.Text = "show";
            this.btshow.UseVisualStyleBackColor = true;
            this.btshow.Click += new System.EventHandler(this.btshow_Click);
            // 
            // tdata_username
            // 
            this.tdata_username.Location = new System.Drawing.Point(605, 349);
            this.tdata_username.Name = "tdata_username";
            this.tdata_username.Size = new System.Drawing.Size(235, 22);
            this.tdata_username.TabIndex = 2;
            // 
            // bdata_edit
            // 
            this.bdata_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdata_edit.Location = new System.Drawing.Point(605, 418);
            this.bdata_edit.Name = "bdata_edit";
            this.bdata_edit.Size = new System.Drawing.Size(75, 23);
            this.bdata_edit.TabIndex = 3;
            this.bdata_edit.Text = "Edit";
            this.bdata_edit.UseVisualStyleBackColor = true;
            this.bdata_edit.Click += new System.EventHandler(this.bdata_edit_Click);
            // 
            // lbldatausername
            // 
            this.lbldatausername.AutoSize = true;
            this.lbldatausername.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatausername.Location = new System.Drawing.Point(511, 352);
            this.lbldatausername.Name = "lbldatausername";
            this.lbldatausername.Size = new System.Drawing.Size(87, 19);
            this.lbldatausername.TabIndex = 4;
            this.lbldatausername.Text = "User Name:";
            this.lbldatausername.Click += new System.EventHandler(this.label1_Click);
            // 
            // bdata_delete
            // 
            this.bdata_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdata_delete.Location = new System.Drawing.Point(686, 418);
            this.bdata_delete.Name = "bdata_delete";
            this.bdata_delete.Size = new System.Drawing.Size(75, 23);
            this.bdata_delete.TabIndex = 5;
            this.bdata_delete.Text = "Delete";
            this.bdata_delete.UseVisualStyleBackColor = true;
            // 
            // bdata_refresh
            // 
            this.bdata_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdata_refresh.Location = new System.Drawing.Point(767, 418);
            this.bdata_refresh.Name = "bdata_refresh";
            this.bdata_refresh.Size = new System.Drawing.Size(75, 23);
            this.bdata_refresh.TabIndex = 6;
            this.bdata_refresh.Text = "Refresh";
            this.bdata_refresh.UseVisualStyleBackColor = true;
            this.bdata_refresh.Click += new System.EventHandler(this.bdata_refresh_Click);
            // 
            // lbldata_number
            // 
            this.lbldata_number.AutoSize = true;
            this.lbldata_number.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata_number.Location = new System.Drawing.Point(484, 387);
            this.lbldata_number.Name = "lbldata_number";
            this.lbldata_number.Size = new System.Drawing.Size(114, 19);
            this.lbldata_number.TabIndex = 7;
            this.lbldata_number.Text = "Phone Number:";
            // 
            // tdata_number
            // 
            this.tdata_number.Location = new System.Drawing.Point(605, 384);
            this.tdata_number.Name = "tdata_number";
            this.tdata_number.Size = new System.Drawing.Size(235, 22);
            this.tdata_number.TabIndex = 8;
            // 
            // bdata_search
            // 
            this.bdata_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdata_search.Location = new System.Drawing.Point(832, 275);
            this.bdata_search.Name = "bdata_search";
            this.bdata_search.Size = new System.Drawing.Size(75, 23);
            this.bdata_search.TabIndex = 9;
            this.bdata_search.Text = "Search";
            this.bdata_search.UseVisualStyleBackColor = true;
            this.bdata_search.Click += new System.EventHandler(this.bdata_search_Click);
            // 
            // tdata_search
            // 
            this.tdata_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tdata_search.Location = new System.Drawing.Point(591, 276);
            this.tdata_search.Name = "tdata_search";
            this.tdata_search.Size = new System.Drawing.Size(235, 22);
            this.tdata_search.TabIndex = 10;
            this.tdata_search.TextChanged += new System.EventHandler(this.tdata_search_TextChanged);
            // 
            // dataview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "dataview";
            this.Text = "dataview";
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
    }
}