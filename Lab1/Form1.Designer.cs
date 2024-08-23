namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.btnSearchByTitle = new System.Windows.Forms.Button();
            this.btnSearchByAuthor = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.DimGray;
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddBook.Location = new System.Drawing.Point(266, 359);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(181, 40);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "AddBook";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(12, 73);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(181, 40);
            this.btnRemoveBook.TabIndex = 1;
            this.btnRemoveBook.Text = "RemoveBook";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            // 
            // btnSearchByTitle
            // 
            this.btnSearchByTitle.Location = new System.Drawing.Point(266, 73);
            this.btnSearchByTitle.Name = "btnSearchByTitle";
            this.btnSearchByTitle.Size = new System.Drawing.Size(181, 40);
            this.btnSearchByTitle.TabIndex = 2;
            this.btnSearchByTitle.Text = "SearchByTitle";
            this.btnSearchByTitle.UseVisualStyleBackColor = true;
            // 
            // btnSearchByAuthor
            // 
            this.btnSearchByAuthor.Location = new System.Drawing.Point(533, 73);
            this.btnSearchByAuthor.Name = "btnSearchByAuthor";
            this.btnSearchByAuthor.Size = new System.Drawing.Size(181, 40);
            this.btnSearchByAuthor.TabIndex = 3;
            this.btnSearchByAuthor.Text = "SearchByAuthor";
            this.btnSearchByAuthor.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(147, 135);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(181, 40);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "Title";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(147, 181);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(181, 40);
            this.txtAuthor.TabIndex = 5;
            this.txtAuthor.Text = "Author";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(147, 227);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(181, 40);
            this.txtYear.TabIndex = 6;
            this.txtYear.Text = "Year";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(147, 283);
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(181, 38);
            this.txtISBN.TabIndex = 7;
            this.txtISBN.Text = "ISBN";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.Items.AddRange(new object[] {
            ""});
            this.lstBooks.Location = new System.Drawing.Point(381, 135);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(204, 186);
            this.lstBooks.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(726, 440);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSearchByAuthor);
            this.Controls.Add(this.btnSearchByTitle);
            this.Controls.Add(this.btnRemoveBook);
            this.Controls.Add(this.btnAddBook);
            this.Name = "Form1";
            this.Text = "Бібліотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.Button btnSearchByTitle;
        private System.Windows.Forms.Button btnSearchByAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.ListBox lstBooks;
    }
}

