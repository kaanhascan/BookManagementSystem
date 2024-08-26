namespace BookManagementSystem
{
    partial class ListingForm
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
            this.viewgrid = new System.Windows.Forms.DataGridView();
            this.listbooksbutton = new System.Windows.Forms.Button();
            this.listmembersbutton = new System.Windows.Forms.Button();
            this.listalreadyborrowedbutton = new System.Windows.Forms.Button();
            this.borrowbookbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewgrid
            // 
            this.viewgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewgrid.Location = new System.Drawing.Point(12, 12);
            this.viewgrid.Name = "viewgrid";
            this.viewgrid.Size = new System.Drawing.Size(905, 384);
            this.viewgrid.TabIndex = 0;
            // 
            // listbooksbutton
            // 
            this.listbooksbutton.BackColor = System.Drawing.Color.LawnGreen;
            this.listbooksbutton.Location = new System.Drawing.Point(70, 431);
            this.listbooksbutton.Name = "listbooksbutton";
            this.listbooksbutton.Size = new System.Drawing.Size(148, 23);
            this.listbooksbutton.TabIndex = 3;
            this.listbooksbutton.Text = "List Books";
            this.listbooksbutton.UseVisualStyleBackColor = false;
            this.listbooksbutton.Click += new System.EventHandler(this.listbooksbutton_Click);
            // 
            // listmembersbutton
            // 
            this.listmembersbutton.BackColor = System.Drawing.Color.LawnGreen;
            this.listmembersbutton.Location = new System.Drawing.Point(392, 431);
            this.listmembersbutton.Name = "listmembersbutton";
            this.listmembersbutton.Size = new System.Drawing.Size(148, 23);
            this.listmembersbutton.TabIndex = 4;
            this.listmembersbutton.Text = "List Members";
            this.listmembersbutton.UseVisualStyleBackColor = false;
            this.listmembersbutton.Click += new System.EventHandler(this.listmembersbutton_Click);
            // 
            // listalreadyborrowedbutton
            // 
            this.listalreadyborrowedbutton.BackColor = System.Drawing.Color.LawnGreen;
            this.listalreadyborrowedbutton.Location = new System.Drawing.Point(716, 431);
            this.listalreadyborrowedbutton.Name = "listalreadyborrowedbutton";
            this.listalreadyborrowedbutton.Size = new System.Drawing.Size(148, 23);
            this.listalreadyborrowedbutton.TabIndex = 5;
            this.listalreadyborrowedbutton.Text = "List Borrowed";
            this.listalreadyborrowedbutton.UseVisualStyleBackColor = false;
            this.listalreadyborrowedbutton.Click += new System.EventHandler(this.listalreadyborrowedbutton_Click);
            // 
            // borrowbookbutton
            // 
            this.borrowbookbutton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.borrowbookbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borrowbookbutton.Location = new System.Drawing.Point(294, 501);
            this.borrowbookbutton.Name = "borrowbookbutton";
            this.borrowbookbutton.Size = new System.Drawing.Size(338, 32);
            this.borrowbookbutton.TabIndex = 6;
            this.borrowbookbutton.Text = "Borrow one now!";
            this.borrowbookbutton.UseVisualStyleBackColor = false;
            this.borrowbookbutton.Click += new System.EventHandler(this.borrowbookbutton_Click);
            // 
            // ListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.borrowbookbutton);
            this.Controls.Add(this.listalreadyborrowedbutton);
            this.Controls.Add(this.listmembersbutton);
            this.Controls.Add(this.listbooksbutton);
            this.Controls.Add(this.viewgrid);
            this.Name = "ListingForm";
            this.Text = "ListingForm";
            ((System.ComponentModel.ISupportInitialize)(this.viewgrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewgrid;
        private System.Windows.Forms.Button listbooksbutton;
        private System.Windows.Forms.Button listmembersbutton;
        private System.Windows.Forms.Button listalreadyborrowedbutton;
        private System.Windows.Forms.Button borrowbookbutton;
    }
}

