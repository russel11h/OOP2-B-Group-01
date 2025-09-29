namespace TTT
{
    partial class Book_Ticket
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
            this.bhx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bhx
            // 
            this.bhx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bhx.FlatAppearance.BorderSize = 0;
            this.bhx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bhx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhx.Location = new System.Drawing.Point(1042, 12);
            this.bhx.Name = "bhx";
            this.bhx.Size = new System.Drawing.Size(37, 33);
            this.bhx.TabIndex = 3;
            this.bhx.Text = "X";
            this.bhx.UseVisualStyleBackColor = true;
            this.bhx.Click += new System.EventHandler(this.bhx_Click);
            // 
            // Book_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1091, 617);
            this.Controls.Add(this.bhx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book_Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Ticket";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bhx;
    }
}