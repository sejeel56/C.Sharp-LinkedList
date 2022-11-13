namespace AssesedExercise1C
{
    partial class Form1
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
            this.typeBookNametxtBox = new System.Windows.Forms.TextBox();
            this.addBookbtn = new System.Windows.Forms.Button();
            this.listOfBooks = new System.Windows.Forms.ListBox();
            this.RemoveBookbtn = new System.Windows.Forms.Button();
            this.sortBookbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.typeISBNtxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // typeBookNametxtBox
            // 
            this.typeBookNametxtBox.Location = new System.Drawing.Point(532, 210);
            this.typeBookNametxtBox.Multiline = true;
            this.typeBookNametxtBox.Name = "typeBookNametxtBox";
            this.typeBookNametxtBox.Size = new System.Drawing.Size(228, 48);
            this.typeBookNametxtBox.TabIndex = 0;
            this.typeBookNametxtBox.TextChanged += new System.EventHandler(this.typeBookNametxtBox_TextChanged);
            // 
            // addBookbtn
            // 
            this.addBookbtn.Location = new System.Drawing.Point(690, 280);
            this.addBookbtn.Name = "addBookbtn";
            this.addBookbtn.Size = new System.Drawing.Size(228, 51);
            this.addBookbtn.TabIndex = 1;
            this.addBookbtn.Text = "Add Book";
            this.addBookbtn.UseVisualStyleBackColor = true;
            this.addBookbtn.Click += new System.EventHandler(this.addBookbtn_Click);
            // 
            // listOfBooks
            // 
            this.listOfBooks.FormattingEnabled = true;
            this.listOfBooks.ItemHeight = 20;
            this.listOfBooks.Location = new System.Drawing.Point(44, 112);
            this.listOfBooks.Name = "listOfBooks";
            this.listOfBooks.Size = new System.Drawing.Size(368, 184);
            this.listOfBooks.TabIndex = 2;
            this.listOfBooks.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RemoveBookbtn
            // 
            this.RemoveBookbtn.Location = new System.Drawing.Point(105, 363);
            this.RemoveBookbtn.Name = "RemoveBookbtn";
            this.RemoveBookbtn.Size = new System.Drawing.Size(212, 51);
            this.RemoveBookbtn.TabIndex = 3;
            this.RemoveBookbtn.Text = "Remove Book";
            this.RemoveBookbtn.UseVisualStyleBackColor = true;
            this.RemoveBookbtn.Click += new System.EventHandler(this.RemoveBookbtn_Click);
            // 
            // sortBookbtn
            // 
            this.sortBookbtn.Location = new System.Drawing.Point(105, 461);
            this.sortBookbtn.Name = "sortBookbtn";
            this.sortBookbtn.Size = new System.Drawing.Size(212, 52);
            this.sortBookbtn.TabIndex = 4;
            this.sortBookbtn.Text = "Sort books by ISBN";
            this.sortBookbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "List of Books with ISBN number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(504, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter a book name to add:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "*Select which book to remove";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(808, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter the ISBN of the book:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(513, 50);
            this.label5.TabIndex = 10;
            this.label5.Text = "*To enter a book please ensure you type the book name \r\nand also enter the ISBN o" +
    "f the book, then press add Book.\r\n";
            // 
            // typeISBNtxtBox
            // 
            this.typeISBNtxtBox.Location = new System.Drawing.Point(813, 210);
            this.typeISBNtxtBox.Multiline = true;
            this.typeISBNtxtBox.Name = "typeISBNtxtBox";
            this.typeISBNtxtBox.Size = new System.Drawing.Size(228, 48);
            this.typeISBNtxtBox.TabIndex = 11;
            this.typeISBNtxtBox.TextChanged += new System.EventHandler(this.typeISBNtxtBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 746);
            this.Controls.Add(this.typeISBNtxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortBookbtn);
            this.Controls.Add(this.RemoveBookbtn);
            this.Controls.Add(this.listOfBooks);
            this.Controls.Add(this.addBookbtn);
            this.Controls.Add(this.typeBookNametxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox typeBookNametxtBox;
        private System.Windows.Forms.Button addBookbtn;
        private System.Windows.Forms.ListBox listOfBooks;
        private System.Windows.Forms.Button RemoveBookbtn;
        private System.Windows.Forms.Button sortBookbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox typeISBNtxtBox;
    }
}

