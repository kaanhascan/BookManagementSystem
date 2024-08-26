namespace BookManagementSystem
{
    partial class BorrowBook
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
            this.availableview = new System.Windows.Forms.DataGridView();
            this.showavailablebooksbutton = new System.Windows.Forms.Button();
            this.borrowlabel = new System.Windows.Forms.Label();
            this.bookidlabel = new System.Windows.Forms.Label();
            this.bookidtext = new System.Windows.Forms.MaskedTextBox();
            this.borrowbutton = new System.Windows.Forms.Button();
            this.memberidlabel = new System.Windows.Forms.Label();
            this.memberidtext = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.availableview)).BeginInit();
            this.SuspendLayout();
            // 
            // availableview
            // 
            this.availableview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableview.Location = new System.Drawing.Point(13, 4);
            this.availableview.Name = "availableview";
            this.availableview.Size = new System.Drawing.Size(307, 376);
            this.availableview.TabIndex = 0;
            // 
            // showavailablebooksbutton
            // 
            this.showavailablebooksbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.showavailablebooksbutton.Location = new System.Drawing.Point(111, 425);
            this.showavailablebooksbutton.Name = "showavailablebooksbutton";
            this.showavailablebooksbutton.Size = new System.Drawing.Size(116, 42);
            this.showavailablebooksbutton.TabIndex = 1;
            this.showavailablebooksbutton.Text = "Show Available Books";
            this.showavailablebooksbutton.UseVisualStyleBackColor = false;
            this.showavailablebooksbutton.Click += new System.EventHandler(this.showavailablebooksbutton_Click);
            // 
            // borrowlabel
            // 
            this.borrowlabel.AutoSize = true;
            this.borrowlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borrowlabel.Location = new System.Drawing.Point(416, 18);
            this.borrowlabel.Name = "borrowlabel";
            this.borrowlabel.Size = new System.Drawing.Size(82, 24);
            this.borrowlabel.TabIndex = 2;
            this.borrowlabel.Text = "Borrow ";
            // 
            // bookidlabel
            // 
            this.bookidlabel.AutoSize = true;
            this.bookidlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookidlabel.Location = new System.Drawing.Point(326, 59);
            this.bookidlabel.Name = "bookidlabel";
            this.bookidlabel.Size = new System.Drawing.Size(255, 16);
            this.bookidlabel.TabIndex = 3;
            this.bookidlabel.Text = "Enter the id of the book you want to borrow";
            // 
            // bookidtext
            // 
            this.bookidtext.Location = new System.Drawing.Point(372, 78);
            this.bookidtext.Mask = "00";
            this.bookidtext.Name = "bookidtext";
            this.bookidtext.Size = new System.Drawing.Size(173, 20);
            this.bookidtext.TabIndex = 4;
            // 
            // borrowbutton
            // 
            this.borrowbutton.Location = new System.Drawing.Point(396, 217);
            this.borrowbutton.Name = "borrowbutton";
            this.borrowbutton.Size = new System.Drawing.Size(123, 23);
            this.borrowbutton.TabIndex = 5;
            this.borrowbutton.Text = "Borrow Now";
            this.borrowbutton.UseVisualStyleBackColor = true;
            this.borrowbutton.Click += new System.EventHandler(this.borrowbutton_Click);
            // 
            // memberidlabel
            // 
            this.memberidlabel.AutoSize = true;
            this.memberidlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memberidlabel.Location = new System.Drawing.Point(393, 115);
            this.memberidlabel.Name = "memberidlabel";
            this.memberidlabel.Size = new System.Drawing.Size(133, 16);
            this.memberidlabel.TabIndex = 6;
            this.memberidlabel.Text = "Enter your MemberID";
            // 
            // memberidtext
            // 
            this.memberidtext.Location = new System.Drawing.Point(372, 150);
            this.memberidtext.Mask = "00";
            this.memberidtext.Name = "memberidtext";
            this.memberidtext.Size = new System.Drawing.Size(173, 20);
            this.memberidtext.TabIndex = 7;
            // 
            // BorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(582, 547);
            this.Controls.Add(this.memberidtext);
            this.Controls.Add(this.memberidlabel);
            this.Controls.Add(this.borrowbutton);
            this.Controls.Add(this.bookidtext);
            this.Controls.Add(this.bookidlabel);
            this.Controls.Add(this.borrowlabel);
            this.Controls.Add(this.showavailablebooksbutton);
            this.Controls.Add(this.availableview);
            this.Name = "BorrowBook";
            this.Text = "BorrowBook";
            ((System.ComponentModel.ISupportInitialize)(this.availableview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView availableview;
        private System.Windows.Forms.Button showavailablebooksbutton;
        private System.Windows.Forms.Label borrowlabel;
        private System.Windows.Forms.Label bookidlabel;
        private System.Windows.Forms.MaskedTextBox bookidtext;
        private System.Windows.Forms.Button borrowbutton;
        private System.Windows.Forms.Label memberidlabel;
        private System.Windows.Forms.MaskedTextBox memberidtext;
    }
}