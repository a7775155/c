namespace MyLibrary
{
    partial class MainForm
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
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabPageBooks = new System.Windows.Forms.TabPage();
            this.BtnClearBookFields = new System.Windows.Forms.Button();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            this.BtnEditBook = new System.Windows.Forms.Button();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.TxtBookCopies = new System.Windows.Forms.TextBox();
            this.LblBookCopies = new System.Windows.Forms.Label();
            this.TxtBookYear = new System.Windows.Forms.TextBox();
            this.LblBookYear = new System.Windows.Forms.Label();
            this.TxtBookAuthor = new System.Windows.Forms.TextBox();
            this.LblBookAuthor = new System.Windows.Forms.Label();
            this.TxtBookTitle = new System.Windows.Forms.TextBox();
            this.LblBookTitle = new System.Windows.Forms.Label();
            this.BtnSearchBooks = new System.Windows.Forms.Button();
            this.TxtBookSearch = new System.Windows.Forms.TextBox();
            this.LblBookSearch = new System.Windows.Forms.Label();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.TabPageBorrowers = new System.Windows.Forms.TabPage();
            this.BtnClearBorrowerFields = new System.Windows.Forms.Button();
            this.BtnDeleteBorrower = new System.Windows.Forms.Button();
            this.BtnEditBorrower = new System.Windows.Forms.Button();
            this.BtnAddBorrower = new System.Windows.Forms.Button();
            this.TxtBorrowerPhone = new System.Windows.Forms.TextBox();
            this.LblBorrowerPhone = new System.Windows.Forms.Label();
            this.TxtBorrowerEmail = new System.Windows.Forms.TextBox();
            this.LblBorrowerEmail = new System.Windows.Forms.Label();
            this.TxtBorrowerName = new System.Windows.Forms.TextBox();
            this.LblBorrowerName = new System.Windows.Forms.Label();
            this.BtnSearchBorrowers = new System.Windows.Forms.Button();
            this.TxtBorrowerSearch = new System.Windows.Forms.TextBox();
            this.LblBorrowerSearch = new System.Windows.Forms.Label();
            this.DgvBorrowers = new System.Windows.Forms.DataGridView();
            this.TabPageIssuedBooks = new System.Windows.Forms.TabPage();
            this.ChkShowReturned = new System.Windows.Forms.CheckBox();
            this.BtnSearchIssuedBooks = new System.Windows.Forms.Button();
            this.TxtIssuedBookSearch = new System.Windows.Forms.TextBox();
            this.LblIssuedBookSearch = new System.Windows.Forms.Label();
            this.BtnReturnBook = new System.Windows.Forms.Button();
            this.BtnIssueBook = new System.Windows.Forms.Button();
            this.DtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.LblDueDate = new System.Windows.Forms.Label();
            this.DtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.LblIssueDate = new System.Windows.Forms.Label();
            this.CmbBorrowers = new System.Windows.Forms.ComboBox();
            this.LblSelectBorrower = new System.Windows.Forms.Label();
            this.CmbBooks = new System.Windows.Forms.ComboBox();
            this.LblSelectBook = new System.Windows.Forms.Label();
            this.DgvIssuedBooks = new System.Windows.Forms.DataGridView();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.TabControlMain.SuspendLayout();
            this.TabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.TabPageBorrowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBorrowers)).BeginInit();
            this.TabPageIssuedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIssuedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.TabPageBooks);
            this.TabControlMain.Controls.Add(this.TabPageBorrowers);
            this.TabControlMain.Controls.Add(this.TabPageIssuedBooks);
            this.TabControlMain.Location = new System.Drawing.Point(18, 18);
            this.TabControlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(1164, 655);
            this.TabControlMain.TabIndex = 0;
            // 
            // TabPageBooks
            // 
            this.TabPageBooks.Controls.Add(this.BtnClearBookFields);
            this.TabPageBooks.Controls.Add(this.BtnDeleteBook);
            this.TabPageBooks.Controls.Add(this.BtnEditBook);
            this.TabPageBooks.Controls.Add(this.BtnAddBook);
            this.TabPageBooks.Controls.Add(this.TxtBookCopies);
            this.TabPageBooks.Controls.Add(this.LblBookCopies);
            this.TabPageBooks.Controls.Add(this.TxtBookYear);
            this.TabPageBooks.Controls.Add(this.LblBookYear);
            this.TabPageBooks.Controls.Add(this.TxtBookAuthor);
            this.TabPageBooks.Controls.Add(this.LblBookAuthor);
            this.TabPageBooks.Controls.Add(this.TxtBookTitle);
            this.TabPageBooks.Controls.Add(this.LblBookTitle);
            this.TabPageBooks.Controls.Add(this.BtnSearchBooks);
            this.TabPageBooks.Controls.Add(this.TxtBookSearch);
            this.TabPageBooks.Controls.Add(this.LblBookSearch);
            this.TabPageBooks.Controls.Add(this.DgvBooks);
            this.TabPageBooks.Location = new System.Drawing.Point(4, 29);
            this.TabPageBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPageBooks.Name = "TabPageBooks";
            this.TabPageBooks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPageBooks.Size = new System.Drawing.Size(1156, 622);
            this.TabPageBooks.TabIndex = 0;
            this.TabPageBooks.Text = "Books";
            this.TabPageBooks.UseVisualStyleBackColor = true;
            this.TabPageBooks.Click += new System.EventHandler(this.TabPageBooks_Click);
            // 
            // BtnClearBookFields
            // 
            this.BtnClearBookFields.Location = new System.Drawing.Point(1040, 338);
            this.BtnClearBookFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClearBookFields.Name = "BtnClearBookFields";
            this.BtnClearBookFields.Size = new System.Drawing.Size(112, 35);
            this.BtnClearBookFields.TabIndex = 15;
            this.BtnClearBookFields.Text = "Clear";
            this.BtnClearBookFields.UseVisualStyleBackColor = true;
            this.BtnClearBookFields.Click += new System.EventHandler(this.BtnClearBookFields_Click);
            // 
            // BtnDeleteBook
            // 
            this.BtnDeleteBook.Location = new System.Drawing.Point(906, 338);
            this.BtnDeleteBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDeleteBook.Name = "BtnDeleteBook";
            this.BtnDeleteBook.Size = new System.Drawing.Size(112, 35);
            this.BtnDeleteBook.TabIndex = 14;
            this.BtnDeleteBook.Text = "Delete";
            this.BtnDeleteBook.UseVisualStyleBackColor = true;
            this.BtnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // BtnEditBook
            // 
            this.BtnEditBook.Location = new System.Drawing.Point(776, 338);
            this.BtnEditBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditBook.Name = "BtnEditBook";
            this.BtnEditBook.Size = new System.Drawing.Size(112, 35);
            this.BtnEditBook.TabIndex = 13;
            this.BtnEditBook.Text = "Edit";
            this.BtnEditBook.UseVisualStyleBackColor = true;
            this.BtnEditBook.Click += new System.EventHandler(this.BtnEditBook_Click);
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.Location = new System.Drawing.Point(656, 338);
            this.BtnAddBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(112, 35);
            this.BtnAddBook.TabIndex = 12;
            this.BtnAddBook.Text = "Add";
            this.BtnAddBook.UseVisualStyleBackColor = true;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAddBook_Click);
            // 
            // TxtBookCopies
            // 
            this.TxtBookCopies.Location = new System.Drawing.Point(802, 277);
            this.TxtBookCopies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBookCopies.Name = "TxtBookCopies";
            this.TxtBookCopies.Size = new System.Drawing.Size(306, 26);
            this.TxtBookCopies.TabIndex = 11;
            // 
            // LblBookCopies
            // 
            this.LblBookCopies.AutoSize = true;
            this.LblBookCopies.Location = new System.Drawing.Point(671, 283);
            this.LblBookCopies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBookCopies.Name = "LblBookCopies";
            this.LblBookCopies.Size = new System.Drawing.Size(62, 20);
            this.LblBookCopies.TabIndex = 10;
            this.LblBookCopies.Text = "Copies:";
            // 
            // TxtBookYear
            // 
            this.TxtBookYear.Location = new System.Drawing.Point(802, 237);
            this.TxtBookYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBookYear.Name = "TxtBookYear";
            this.TxtBookYear.Size = new System.Drawing.Size(306, 26);
            this.TxtBookYear.TabIndex = 9;
            this.TxtBookYear.TextChanged += new System.EventHandler(this.TxtBookYear_TextChanged);
            // 
            // LblBookYear
            // 
            this.LblBookYear.AutoSize = true;
            this.LblBookYear.Location = new System.Drawing.Point(686, 240);
            this.LblBookYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBookYear.Name = "LblBookYear";
            this.LblBookYear.Size = new System.Drawing.Size(47, 20);
            this.LblBookYear.TabIndex = 8;
            this.LblBookYear.Text = "Year:";
            // 
            // TxtBookAuthor
            // 
            this.TxtBookAuthor.Location = new System.Drawing.Point(802, 197);
            this.TxtBookAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBookAuthor.Name = "TxtBookAuthor";
            this.TxtBookAuthor.Size = new System.Drawing.Size(306, 26);
            this.TxtBookAuthor.TabIndex = 7;
            // 
            // LblBookAuthor
            // 
            this.LblBookAuthor.AutoSize = true;
            this.LblBookAuthor.Location = new System.Drawing.Point(671, 197);
            this.LblBookAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBookAuthor.Name = "LblBookAuthor";
            this.LblBookAuthor.Size = new System.Drawing.Size(61, 20);
            this.LblBookAuthor.TabIndex = 6;
            this.LblBookAuthor.Text = "Author:";
            // 
            // TxtBookTitle
            // 
            this.TxtBookTitle.Location = new System.Drawing.Point(802, 157);
            this.TxtBookTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBookTitle.Name = "TxtBookTitle";
            this.TxtBookTitle.Size = new System.Drawing.Size(306, 26);
            this.TxtBookTitle.TabIndex = 5;
            // 
            // LblBookTitle
            // 
            this.LblBookTitle.AutoSize = true;
            this.LblBookTitle.Location = new System.Drawing.Point(686, 157);
            this.LblBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBookTitle.Name = "LblBookTitle";
            this.LblBookTitle.Size = new System.Drawing.Size(42, 20);
            this.LblBookTitle.TabIndex = 4;
            this.LblBookTitle.Text = "Title:";
            // 
            // BtnSearchBooks
            // 
            this.BtnSearchBooks.Location = new System.Drawing.Point(512, 35);
            this.BtnSearchBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearchBooks.Name = "BtnSearchBooks";
            this.BtnSearchBooks.Size = new System.Drawing.Size(112, 35);
            this.BtnSearchBooks.TabIndex = 3;
            this.BtnSearchBooks.Text = "Search";
            this.BtnSearchBooks.UseVisualStyleBackColor = true;
            this.BtnSearchBooks.Click += new System.EventHandler(this.BtnSearchBooks_Click);
            // 
            // TxtBookSearch
            // 
            this.TxtBookSearch.Location = new System.Drawing.Point(164, 38);
            this.TxtBookSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBookSearch.Name = "TxtBookSearch";
            this.TxtBookSearch.Size = new System.Drawing.Size(337, 26);
            this.TxtBookSearch.TabIndex = 2;
            // 
            // LblBookSearch
            // 
            this.LblBookSearch.AutoSize = true;
            this.LblBookSearch.Location = new System.Drawing.Point(42, 43);
            this.LblBookSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBookSearch.Name = "LblBookSearch";
            this.LblBookSearch.Size = new System.Drawing.Size(113, 20);
            this.LblBookSearch.TabIndex = 1;
            this.LblBookSearch.Text = "Search Books:";
            // 
            // DgvBooks
            // 
            this.DgvBooks.AllowUserToAddRows = false;
            this.DgvBooks.AllowUserToDeleteRows = false;
            this.DgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBooks.Location = new System.Drawing.Point(42, 80);
            this.DgvBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvBooks.MultiSelect = false;
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.ReadOnly = true;
            this.DgvBooks.RowHeadersWidth = 62;
            this.DgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBooks.Size = new System.Drawing.Size(606, 502);
            this.DgvBooks.TabIndex = 0;
            this.DgvBooks.SelectionChanged += new System.EventHandler(this.DgvBooks_SelectionChanged);
            // 
            // TabPageBorrowers
            // 
            this.TabPageBorrowers.Controls.Add(this.BtnClearBorrowerFields);
            this.TabPageBorrowers.Controls.Add(this.BtnDeleteBorrower);
            this.TabPageBorrowers.Controls.Add(this.BtnEditBorrower);
            this.TabPageBorrowers.Controls.Add(this.BtnAddBorrower);
            this.TabPageBorrowers.Controls.Add(this.TxtBorrowerPhone);
            this.TabPageBorrowers.Controls.Add(this.LblBorrowerPhone);
            this.TabPageBorrowers.Controls.Add(this.TxtBorrowerEmail);
            this.TabPageBorrowers.Controls.Add(this.LblBorrowerEmail);
            this.TabPageBorrowers.Controls.Add(this.TxtBorrowerName);
            this.TabPageBorrowers.Controls.Add(this.LblBorrowerName);
            this.TabPageBorrowers.Controls.Add(this.BtnSearchBorrowers);
            this.TabPageBorrowers.Controls.Add(this.TxtBorrowerSearch);
            this.TabPageBorrowers.Controls.Add(this.LblBorrowerSearch);
            this.TabPageBorrowers.Controls.Add(this.DgvBorrowers);
            this.TabPageBorrowers.Location = new System.Drawing.Point(4, 29);
            this.TabPageBorrowers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPageBorrowers.Name = "TabPageBorrowers";
            this.TabPageBorrowers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPageBorrowers.Size = new System.Drawing.Size(1156, 622);
            this.TabPageBorrowers.TabIndex = 1;
            this.TabPageBorrowers.Text = "Borrowers";
            this.TabPageBorrowers.UseVisualStyleBackColor = true;
            // 
            // BtnClearBorrowerFields
            // 
            this.BtnClearBorrowerFields.Location = new System.Drawing.Point(998, 338);
            this.BtnClearBorrowerFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClearBorrowerFields.Name = "BtnClearBorrowerFields";
            this.BtnClearBorrowerFields.Size = new System.Drawing.Size(112, 35);
            this.BtnClearBorrowerFields.TabIndex = 15;
            this.BtnClearBorrowerFields.Text = "Clear";
            this.BtnClearBorrowerFields.UseVisualStyleBackColor = true;
            this.BtnClearBorrowerFields.Click += new System.EventHandler(this.BtnClearBorrowerFields_Click);
            // 
            // BtnDeleteBorrower
            // 
            this.BtnDeleteBorrower.Location = new System.Drawing.Point(876, 338);
            this.BtnDeleteBorrower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDeleteBorrower.Name = "BtnDeleteBorrower";
            this.BtnDeleteBorrower.Size = new System.Drawing.Size(112, 35);
            this.BtnDeleteBorrower.TabIndex = 14;
            this.BtnDeleteBorrower.Text = "Delete";
            this.BtnDeleteBorrower.UseVisualStyleBackColor = true;
            this.BtnDeleteBorrower.Click += new System.EventHandler(this.BtnDeleteBorrower_Click);
            // 
            // BtnEditBorrower
            // 
            this.BtnEditBorrower.Location = new System.Drawing.Point(754, 338);
            this.BtnEditBorrower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditBorrower.Name = "BtnEditBorrower";
            this.BtnEditBorrower.Size = new System.Drawing.Size(112, 35);
            this.BtnEditBorrower.TabIndex = 13;
            this.BtnEditBorrower.Text = "Edit";
            this.BtnEditBorrower.UseVisualStyleBackColor = true;
            this.BtnEditBorrower.Click += new System.EventHandler(this.BtnEditBorrower_Click);
            // 
            // BtnAddBorrower
            // 
            this.BtnAddBorrower.Location = new System.Drawing.Point(633, 338);
            this.BtnAddBorrower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddBorrower.Name = "BtnAddBorrower";
            this.BtnAddBorrower.Size = new System.Drawing.Size(112, 35);
            this.BtnAddBorrower.TabIndex = 12;
            this.BtnAddBorrower.Text = "Add";
            this.BtnAddBorrower.UseVisualStyleBackColor = true;
            this.BtnAddBorrower.Click += new System.EventHandler(this.BtnAddBorrower_Click);
            // 
            // TxtBorrowerPhone
            // 
            this.TxtBorrowerPhone.Location = new System.Drawing.Point(754, 197);
            this.TxtBorrowerPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBorrowerPhone.Name = "TxtBorrowerPhone";
            this.TxtBorrowerPhone.Size = new System.Drawing.Size(354, 26);
            this.TxtBorrowerPhone.TabIndex = 11;
            // 
            // LblBorrowerPhone
            // 
            this.LblBorrowerPhone.AutoSize = true;
            this.LblBorrowerPhone.Location = new System.Drawing.Point(633, 202);
            this.LblBorrowerPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBorrowerPhone.Name = "LblBorrowerPhone";
            this.LblBorrowerPhone.Size = new System.Drawing.Size(59, 20);
            this.LblBorrowerPhone.TabIndex = 10;
            this.LblBorrowerPhone.Text = "Phone:";
            // 
            // TxtBorrowerEmail
            // 
            this.TxtBorrowerEmail.Location = new System.Drawing.Point(754, 157);
            this.TxtBorrowerEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBorrowerEmail.Name = "TxtBorrowerEmail";
            this.TxtBorrowerEmail.Size = new System.Drawing.Size(354, 26);
            this.TxtBorrowerEmail.TabIndex = 9;
            // 
            // LblBorrowerEmail
            // 
            this.LblBorrowerEmail.AutoSize = true;
            this.LblBorrowerEmail.Location = new System.Drawing.Point(633, 162);
            this.LblBorrowerEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBorrowerEmail.Name = "LblBorrowerEmail";
            this.LblBorrowerEmail.Size = new System.Drawing.Size(52, 20);
            this.LblBorrowerEmail.TabIndex = 8;
            this.LblBorrowerEmail.Text = "Email:";
            // 
            // TxtBorrowerName
            // 
            this.TxtBorrowerName.Location = new System.Drawing.Point(754, 117);
            this.TxtBorrowerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBorrowerName.Name = "TxtBorrowerName";
            this.TxtBorrowerName.Size = new System.Drawing.Size(354, 26);
            this.TxtBorrowerName.TabIndex = 5;
            // 
            // LblBorrowerName
            // 
            this.LblBorrowerName.AutoSize = true;
            this.LblBorrowerName.Location = new System.Drawing.Point(633, 122);
            this.LblBorrowerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBorrowerName.Name = "LblBorrowerName";
            this.LblBorrowerName.Size = new System.Drawing.Size(55, 20);
            this.LblBorrowerName.TabIndex = 4;
            this.LblBorrowerName.Text = "Name:";
            // 
            // BtnSearchBorrowers
            // 
            this.BtnSearchBorrowers.Location = new System.Drawing.Point(512, 35);
            this.BtnSearchBorrowers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearchBorrowers.Name = "BtnSearchBorrowers";
            this.BtnSearchBorrowers.Size = new System.Drawing.Size(112, 35);
            this.BtnSearchBorrowers.TabIndex = 3;
            this.BtnSearchBorrowers.Text = "Search";
            this.BtnSearchBorrowers.UseVisualStyleBackColor = true;
            this.BtnSearchBorrowers.Click += new System.EventHandler(this.BtnSearchBorrowers_Click);
            // 
            // TxtBorrowerSearch
            // 
            this.TxtBorrowerSearch.Location = new System.Drawing.Point(164, 38);
            this.TxtBorrowerSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBorrowerSearch.Name = "TxtBorrowerSearch";
            this.TxtBorrowerSearch.Size = new System.Drawing.Size(337, 26);
            this.TxtBorrowerSearch.TabIndex = 2;
            // 
            // LblBorrowerSearch
            // 
            this.LblBorrowerSearch.AutoSize = true;
            this.LblBorrowerSearch.Location = new System.Drawing.Point(42, 43);
            this.LblBorrowerSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblBorrowerSearch.Name = "LblBorrowerSearch";
            this.LblBorrowerSearch.Size = new System.Drawing.Size(140, 20);
            this.LblBorrowerSearch.TabIndex = 1;
            this.LblBorrowerSearch.Text = "Search Borrowers:";
            // 
            // DgvBorrowers
            // 
            this.DgvBorrowers.AllowUserToAddRows = false;
            this.DgvBorrowers.AllowUserToDeleteRows = false;
            this.DgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBorrowers.Location = new System.Drawing.Point(42, 80);
            this.DgvBorrowers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvBorrowers.MultiSelect = false;
            this.DgvBorrowers.Name = "DgvBorrowers";
            this.DgvBorrowers.ReadOnly = true;
            this.DgvBorrowers.RowHeadersWidth = 62;
            this.DgvBorrowers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBorrowers.Size = new System.Drawing.Size(582, 502);
            this.DgvBorrowers.TabIndex = 0;
            this.DgvBorrowers.SelectionChanged += new System.EventHandler(this.DgvBorrowers_SelectionChanged);
            // 
            // TabPageIssuedBooks
            // 
            this.TabPageIssuedBooks.Controls.Add(this.ChkShowReturned);
            this.TabPageIssuedBooks.Controls.Add(this.BtnSearchIssuedBooks);
            this.TabPageIssuedBooks.Controls.Add(this.TxtIssuedBookSearch);
            this.TabPageIssuedBooks.Controls.Add(this.LblIssuedBookSearch);
            this.TabPageIssuedBooks.Controls.Add(this.BtnReturnBook);
            this.TabPageIssuedBooks.Controls.Add(this.BtnIssueBook);
            this.TabPageIssuedBooks.Controls.Add(this.DtpDueDate);
            this.TabPageIssuedBooks.Controls.Add(this.LblDueDate);
            this.TabPageIssuedBooks.Controls.Add(this.DtpIssueDate);
            this.TabPageIssuedBooks.Controls.Add(this.LblIssueDate);
            this.TabPageIssuedBooks.Controls.Add(this.CmbBorrowers);
            this.TabPageIssuedBooks.Controls.Add(this.LblSelectBorrower);
            this.TabPageIssuedBooks.Controls.Add(this.CmbBooks);
            this.TabPageIssuedBooks.Controls.Add(this.LblSelectBook);
            this.TabPageIssuedBooks.Controls.Add(this.DgvIssuedBooks);
            this.TabPageIssuedBooks.Location = new System.Drawing.Point(4, 29);
            this.TabPageIssuedBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPageIssuedBooks.Name = "TabPageIssuedBooks";
            this.TabPageIssuedBooks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabPageIssuedBooks.Size = new System.Drawing.Size(1156, 622);
            this.TabPageIssuedBooks.TabIndex = 2;
            this.TabPageIssuedBooks.Text = "Issued Books";
            this.TabPageIssuedBooks.UseVisualStyleBackColor = true;
            this.TabPageIssuedBooks.Click += new System.EventHandler(this.TabPageIssuedBooks_Click);
            // 
            // ChkShowReturned
            // 
            this.ChkShowReturned.AutoSize = true;
            this.ChkShowReturned.Location = new System.Drawing.Point(754, 46);
            this.ChkShowReturned.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkShowReturned.Name = "ChkShowReturned";
            this.ChkShowReturned.Size = new System.Drawing.Size(195, 24);
            this.ChkShowReturned.TabIndex = 14;
            this.ChkShowReturned.Text = "Show Returned Books";
            this.ChkShowReturned.UseVisualStyleBackColor = true;
            // 
            // BtnSearchIssuedBooks
            // 
            this.BtnSearchIssuedBooks.Location = new System.Drawing.Point(512, 35);
            this.BtnSearchIssuedBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSearchIssuedBooks.Name = "BtnSearchIssuedBooks";
            this.BtnSearchIssuedBooks.Size = new System.Drawing.Size(112, 35);
            this.BtnSearchIssuedBooks.TabIndex = 13;
            this.BtnSearchIssuedBooks.Text = "Search";
            this.BtnSearchIssuedBooks.UseVisualStyleBackColor = true;
            this.BtnSearchIssuedBooks.Click += new System.EventHandler(this.BtnSearchIssuedBooks_Click);
            // 
            // TxtIssuedBookSearch
            // 
            this.TxtIssuedBookSearch.Location = new System.Drawing.Point(164, 38);
            this.TxtIssuedBookSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIssuedBookSearch.Name = "TxtIssuedBookSearch";
            this.TxtIssuedBookSearch.Size = new System.Drawing.Size(337, 26);
            this.TxtIssuedBookSearch.TabIndex = 12;
            // 
            // LblIssuedBookSearch
            // 
            this.LblIssuedBookSearch.AutoSize = true;
            this.LblIssuedBookSearch.Location = new System.Drawing.Point(42, 43);
            this.LblIssuedBookSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIssuedBookSearch.Name = "LblIssuedBookSearch";
            this.LblIssuedBookSearch.Size = new System.Drawing.Size(116, 20);
            this.LblIssuedBookSearch.TabIndex = 11;
            this.LblIssuedBookSearch.Text = "Search Issued:";
            // 
            // BtnReturnBook
            // 
            this.BtnReturnBook.Enabled = false;
            this.BtnReturnBook.Location = new System.Drawing.Point(876, 338);
            this.BtnReturnBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnReturnBook.Name = "BtnReturnBook";
            this.BtnReturnBook.Size = new System.Drawing.Size(112, 35);
            this.BtnReturnBook.TabIndex = 10;
            this.BtnReturnBook.Text = "Return Book";
            this.BtnReturnBook.UseVisualStyleBackColor = true;
            this.BtnReturnBook.Click += new System.EventHandler(this.BtnReturnBook_Click);
            // 
            // BtnIssueBook
            // 
            this.BtnIssueBook.Location = new System.Drawing.Point(754, 338);
            this.BtnIssueBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnIssueBook.Name = "BtnIssueBook";
            this.BtnIssueBook.Size = new System.Drawing.Size(112, 35);
            this.BtnIssueBook.TabIndex = 9;
            this.BtnIssueBook.Text = "Issue Book";
            this.BtnIssueBook.UseVisualStyleBackColor = true;
            this.BtnIssueBook.Click += new System.EventHandler(this.BtnIssueBook_Click);
            // 
            // DtpDueDate
            // 
            this.DtpDueDate.Location = new System.Drawing.Point(754, 197);
            this.DtpDueDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpDueDate.Name = "DtpDueDate";
            this.DtpDueDate.Size = new System.Drawing.Size(354, 26);
            this.DtpDueDate.TabIndex = 8;
            // 
            // LblDueDate
            // 
            this.LblDueDate.AutoSize = true;
            this.LblDueDate.Location = new System.Drawing.Point(633, 202);
            this.LblDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDueDate.Name = "LblDueDate";
            this.LblDueDate.Size = new System.Drawing.Size(82, 20);
            this.LblDueDate.TabIndex = 7;
            this.LblDueDate.Text = "Due Date:";
            // 
            // DtpIssueDate
            // 
            this.DtpIssueDate.Location = new System.Drawing.Point(754, 157);
            this.DtpIssueDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpIssueDate.Name = "DtpIssueDate";
            this.DtpIssueDate.Size = new System.Drawing.Size(354, 26);
            this.DtpIssueDate.TabIndex = 6;
            // 
            // LblIssueDate
            // 
            this.LblIssueDate.AutoSize = true;
            this.LblIssueDate.Location = new System.Drawing.Point(633, 162);
            this.LblIssueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIssueDate.Name = "LblIssueDate";
            this.LblIssueDate.Size = new System.Drawing.Size(91, 20);
            this.LblIssueDate.TabIndex = 5;
            this.LblIssueDate.Text = "Issue Date:";
            // 
            // CmbBorrowers
            // 
            this.CmbBorrowers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBorrowers.FormattingEnabled = true;
            this.CmbBorrowers.Location = new System.Drawing.Point(754, 117);
            this.CmbBorrowers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbBorrowers.Name = "CmbBorrowers";
            this.CmbBorrowers.Size = new System.Drawing.Size(354, 28);
            this.CmbBorrowers.TabIndex = 4;
            // 
            // LblSelectBorrower
            // 
            this.LblSelectBorrower.AutoSize = true;
            this.LblSelectBorrower.Location = new System.Drawing.Point(633, 122);
            this.LblSelectBorrower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSelectBorrower.Name = "LblSelectBorrower";
            this.LblSelectBorrower.Size = new System.Drawing.Size(126, 20);
            this.LblSelectBorrower.TabIndex = 3;
            this.LblSelectBorrower.Text = "Select Borrower:";
            // 
            // CmbBooks
            // 
            this.CmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBooks.FormattingEnabled = true;
            this.CmbBooks.Location = new System.Drawing.Point(754, 77);
            this.CmbBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbBooks.Name = "CmbBooks";
            this.CmbBooks.Size = new System.Drawing.Size(354, 28);
            this.CmbBooks.TabIndex = 2;
            // 
            // LblSelectBook
            // 
            this.LblSelectBook.AutoSize = true;
            this.LblSelectBook.Location = new System.Drawing.Point(633, 82);
            this.LblSelectBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSelectBook.Name = "LblSelectBook";
            this.LblSelectBook.Size = new System.Drawing.Size(99, 20);
            this.LblSelectBook.TabIndex = 1;
            this.LblSelectBook.Text = "Select Book:";
            // 
            // DgvIssuedBooks
            // 
            this.DgvIssuedBooks.AllowUserToAddRows = false;
            this.DgvIssuedBooks.AllowUserToDeleteRows = false;
            this.DgvIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvIssuedBooks.Location = new System.Drawing.Point(42, 80);
            this.DgvIssuedBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvIssuedBooks.MultiSelect = false;
            this.DgvIssuedBooks.Name = "DgvIssuedBooks";
            this.DgvIssuedBooks.ReadOnly = true;
            this.DgvIssuedBooks.RowHeadersWidth = 62;
            this.DgvIssuedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvIssuedBooks.Size = new System.Drawing.Size(582, 502);
            this.DgvIssuedBooks.TabIndex = 0;
            this.DgvIssuedBooks.SelectionChanged += new System.EventHandler(this.DgvIssuedBooks_SelectionChanged);
            // 
            // BtnLogout
            // 
            this.BtnLogout.Location = new System.Drawing.Point(1070, 683);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(112, 35);
            this.BtnLogout.TabIndex = 1;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 737);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.TabControlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "My Library Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControlMain.ResumeLayout(false);
            this.TabPageBooks.ResumeLayout(false);
            this.TabPageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.TabPageBorrowers.ResumeLayout(false);
            this.TabPageBorrowers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBorrowers)).EndInit();
            this.TabPageIssuedBooks.ResumeLayout(false);
            this.TabPageIssuedBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvIssuedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage TabPageBooks;
        private System.Windows.Forms.TabPage TabPageBorrowers;
        private System.Windows.Forms.TabPage TabPageIssuedBooks;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.Button BtnSearchBooks;
        private System.Windows.Forms.TextBox TxtBookSearch;
        private System.Windows.Forms.Label LblBookSearch;
        private System.Windows.Forms.Button BtnClearBookFields;
        private System.Windows.Forms.Button BtnDeleteBook;
        private System.Windows.Forms.Button BtnEditBook;
        private System.Windows.Forms.Button BtnAddBook;
        private System.Windows.Forms.TextBox TxtBookCopies;
        private System.Windows.Forms.Label LblBookCopies;
        private System.Windows.Forms.TextBox TxtBookYear;
        private System.Windows.Forms.Label LblBookYear;
        private System.Windows.Forms.TextBox TxtBookAuthor;
        private System.Windows.Forms.Label LblBookAuthor;
        private System.Windows.Forms.TextBox TxtBookTitle;
        private System.Windows.Forms.Label LblBookTitle;
        private System.Windows.Forms.Button BtnClearBorrowerFields;
        private System.Windows.Forms.Button BtnDeleteBorrower;
        private System.Windows.Forms.Button BtnEditBorrower;
        private System.Windows.Forms.Button BtnAddBorrower;
        private System.Windows.Forms.TextBox TxtBorrowerPhone;
        private System.Windows.Forms.Label LblBorrowerPhone;
        private System.Windows.Forms.TextBox TxtBorrowerEmail;
        private System.Windows.Forms.Label LblBorrowerEmail;
        private System.Windows.Forms.TextBox TxtBorrowerName; // Corrected
        private System.Windows.Forms.Label LblBorrowerName; // Corrected
        private System.Windows.Forms.Button BtnSearchBorrowers;
        private System.Windows.Forms.TextBox TxtBorrowerSearch;
        private System.Windows.Forms.Label LblBorrowerSearch;
        private System.Windows.Forms.DataGridView DgvBorrowers;
        private System.Windows.Forms.ComboBox CmbBooks;
        private System.Windows.Forms.Label LblSelectBook;
        private System.Windows.Forms.DataGridView DgvIssuedBooks;
        private System.Windows.Forms.DateTimePicker DtpDueDate;
        private System.Windows.Forms.Label LblDueDate;
        private System.Windows.Forms.DateTimePicker DtpIssueDate;
        private System.Windows.Forms.Label LblIssueDate;
        private System.Windows.Forms.ComboBox CmbBorrowers;
        private System.Windows.Forms.Label LblSelectBorrower;
        private System.Windows.Forms.Button BtnReturnBook;
        private System.Windows.Forms.Button BtnIssueBook;
        private System.Windows.Forms.CheckBox ChkShowReturned;
        private System.Windows.Forms.Button BtnSearchIssuedBooks;
        private System.Windows.Forms.TextBox TxtIssuedBookSearch;
        private System.Windows.Forms.Label LblIssuedBookSearch;
    }
}
