using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class MainForm : Form
    {
        // Connection string for the SQL Server database.
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyLibraryDB;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the MainForm.
        /// Initiates the login process before loading other data.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Show the login dialog first.
          

            // If login is successful, proceed with loading application data.
            LoadBooks();
            LoadBorrowers();
            LoadIssuedBooks();
            LoadBooksComboBox();
            LoadBorrowersComboBox();

            // Set default values for issue and due dates.
            DtpIssueDate.Value = DateTime.Now;
            DtpDueDate.Value = DateTime.Now.AddDays(14); // Default due date is 14 days from issue.
        }

        /// <summary>
        /// Displays a modal login dialog.
        /// </summary>
        /// <returns>True if login is successful, false otherwise.</returns>
       
            
           

        /// <summary>
        /// Handles the Click event of the Logout button.
        /// Closes the current form.
        /// </summary>
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the main form.
        }

        /// <summary>
        /// Handles the Click event for the TabPageBooks.
        /// This method is required because the designer file references it.
        /// It can be left empty if no specific action is needed when this tab is clicked.
        /// </summary>
        private void TabPageBooks_Click(object sender, EventArgs e)
        {
            // No specific action needed for now, but the method must exist.
        }

        #region Books Management

        /// <summary>
        /// Loads all books from the database into the dgvBooks DataGridView.
        /// </summary>
        private void LoadBooks()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to select all relevant book information.
                string query = "SELECT BookID, Title, Author, Year, AvailableCopies FROM Books";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table); // Fill the DataTable with data from the database.
                DgvBooks.DataSource = table; // Set the DataTable as the DataSource for the DataGridView.
            }
        }

        /// <summary>
        /// Handles the Click event of the Search Books button.
        /// Filters books based on the search term in Title or Author.
        /// </summary>
        private void BtnSearchBooks_Click(object sender, EventArgs e)
        {
            string searchTerm = TxtBookSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadBooks(); // If search term is empty, load all books.
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to search for books by Title or Author using LIKE operator.
                string query = "SELECT BookID, Title, Author, Year, AvailableCopies FROM Books " +
                               "WHERE Title LIKE @search OR Author LIKE @search";
                SqlCommand command = new SqlCommand(query, connection);
                // Add parameter to prevent SQL injection.
                command.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DgvBooks.DataSource = table;
            }
        }

        /// <summary>
        /// Handles the Click event of the Clear Book Fields button.
        /// Clears all text fields in the Books Management section.
        /// </summary>
        private void BtnClearBookFields_Click(object sender, EventArgs e)
        {
            TxtBookTitle.Clear();
            TxtBookAuthor.Clear();
            TxtBookYear.Clear();
            TxtBookCopies.Clear();
        }

        /// <summary>
        /// Validates the input fields for adding or editing a book.
        /// Displays error messages if validation fails.
        /// </summary>
        /// <returns>True if all fields are valid, false otherwise.</returns>
        private bool ValidateBookFields()
        {
            if (string.IsNullOrWhiteSpace(TxtBookTitle.Text))
            {
                MessageBox.Show("Please enter a book title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtBookAuthor.Text))
            {
                MessageBox.Show("Please enter an author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Year: must be an integer, non-negative, and not in the future.
            if (!int.TryParse(TxtBookYear.Text, out int year) || year < 0 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate Copies: must be an integer and non-negative.
            if (!int.TryParse(TxtBookCopies.Text, out int copies) || copies < 0)
            {
                MessageBox.Show("Please enter a valid number of copies.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Handles the Click event of the Add Book button.
        /// Adds a new book record to the database after validation.
        /// </summary>
        private void BtnAddBook_Click(object sender, EventArgs e)
        {
            if (ValidateBookFields())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL query to insert a new book.
                    string query = "INSERT INTO Books (Title, Author, Year, AvailableCopies) " +
                                   "VALUES (@title, @author, @year, @copies)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters for safe insertion.
                    command.Parameters.AddWithValue("@title", TxtBookTitle.Text);
                    command.Parameters.AddWithValue("@author", TxtBookAuthor.Text);
                    command.Parameters.AddWithValue("@year", int.Parse(TxtBookYear.Text));
                    command.Parameters.AddWithValue("@copies", int.Parse(TxtBookCopies.Text));

                    connection.Open(); // Open the database connection.
                    command.ExecuteNonQuery(); // Execute the insert command.
                }

                // Refresh data and clear fields after adding.
                LoadBooks();
                BtnClearBookFields_Click(sender, e);
                LoadBooksComboBox(); // Refresh the books combo box as well.
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the dgvBooks DataGridView.
        /// Populates the book input fields with data from the selected row.
        /// </summary>
        private void DgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgvBooks.SelectedRows[0];
                TxtBookTitle.Text = row.Cells["Title"].Value.ToString();
                TxtBookAuthor.Text = row.Cells["Author"].Value.ToString();
                TxtBookYear.Text = row.Cells["Year"].Value.ToString();
                TxtBookCopies.Text = row.Cells["AvailableCopies"].Value.ToString();
            }
        }

        /// <summary>
        /// Handles the Click event of the Edit Book button.
        /// Updates an existing book record in the database after validation.
        /// </summary>
        private void BtnEditBook_Click(object sender, EventArgs e)
        {
            if (DgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidateBookFields())
            {
                // Get the BookID of the selected row.
                int bookId = Convert.ToInt32(DgvBooks.SelectedRows[0].Cells["BookID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL query to update an existing book.
                    string query = "UPDATE Books SET Title = @title, Author = @author, " +
                                   "Year = @year, AvailableCopies = @copies WHERE BookID = @id";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters for safe update.
                    command.Parameters.AddWithValue("@title", TxtBookTitle.Text);
                    command.Parameters.AddWithValue("@author", TxtBookAuthor.Text);
                    command.Parameters.AddWithValue("@year", int.Parse(TxtBookYear.Text));
                    command.Parameters.AddWithValue("@copies", int.Parse(TxtBookCopies.Text));
                    command.Parameters.AddWithValue("@id", bookId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Refresh data and clear fields after editing.
                LoadBooks();
                BtnClearBookFields_Click(sender, e);
                LoadBooksComboBox(); // Refresh the books combo box.
            }
        }

        /// <summary>
        /// Handles the Click event of the Delete Book button.
        /// Deletes a book record from the database after confirmation and checks.
        /// </summary>
        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            if (DgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion with the user.
            if (MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int bookId = Convert.ToInt32(DgvBooks.SelectedRows[0].Cells["BookID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // First, check if the book is currently issued to anyone (Returned = 0).
                    string checkQuery = "SELECT COUNT(*) FROM IssuedBooks WHERE BookID = @id AND Returned = 0";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@id", bookId);

                    int issuedCount = (int)checkCommand.ExecuteScalar();

                    if (issuedCount > 0)
                    {
                        MessageBox.Show("Cannot delete this book as it is currently issued to borrowers.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // If not issued, proceed with deletion.
                    string deleteQuery = "DELETE FROM Books WHERE BookID = @id";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@id", bookId);
                    deleteCommand.ExecuteNonQuery();
                }

                // Refresh data and clear fields after deletion.
                LoadBooks();
                BtnClearBookFields_Click(sender, e);
                LoadBooksComboBox(); // Refresh the books combo box.
            }
        }

        #endregion

        #region Borrowers Management

        /// <summary>
        /// Loads all borrowers from the database into the dgvBorrowers DataGridView.
        /// Adapted to use the 'Name' column.
        /// </summary>
        private void LoadBorrowers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to select all relevant borrower information, using 'Name'.
                string query = "SELECT BorrowerID, Name, Email, Phone FROM Borrowers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DgvBorrowers.DataSource = table;
            }
        }

        /// <summary>
        /// Handles the Click event of the Search Borrowers button.
        /// Filters borrowers based on the search term in Name or Email.
        /// </summary>
        private void BtnSearchBorrowers_Click(object sender, EventArgs e)
        {
            string searchTerm = TxtBorrowerSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadBorrowers(); // If search term is empty, load all borrowers.
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to search for borrowers by Name or Email.
                string query = "SELECT BorrowerID, Name, Email, Phone FROM Borrowers " +
                               "WHERE Name LIKE @search OR Email LIKE @search";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DgvBorrowers.DataSource = table;
            }
        }

        /// <summary>
        /// Handles the Click event of the Clear Borrower Fields button.
        /// Clears all text fields in the Borrowers Management section.
        /// Adapted to use the 'Name' column.
        /// </summary>
        private void BtnClearBorrowerFields_Click(object sender, EventArgs e)
        {
            TxtBorrowerName.Clear();
            TxtBorrowerEmail.Clear();
            TxtBorrowerPhone.Clear();
        }

        /// <summary>
        /// Validates the input fields for adding or editing a borrower.
        /// Displays error messages if validation fails.
        /// Adapted to use the 'Name' column and 'Phone' as NOT NULL.
        /// </summary>
        /// <returns>True if all fields are valid, false otherwise.</returns>
        private bool ValidateBorrowerFields()
        {
            if (string.IsNullOrWhiteSpace(TxtBorrowerName.Text))
            {
                MessageBox.Show("Please enter a borrower name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxtBorrowerEmail.Text))
            {
                MessageBox.Show("Please enter an email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Basic email format validation (can be enhanced with Regex for stricter validation)
            if (!TxtBorrowerEmail.Text.Contains("@") || !TxtBorrowerEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Phone is now NOT NULL
            if (string.IsNullOrWhiteSpace(TxtBorrowerPhone.Text))
            {
                MessageBox.Show("Please enter a phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Handles the Click event of the Add Borrower button.
        /// Adds a new borrower record to the database after validation.
        /// Adapted to use the 'Name' column.
        /// </summary>
        private void BtnAddBorrower_Click(object sender, EventArgs e)
        {
            if (ValidateBorrowerFields())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL query to insert a new borrower, using 'Name'.
                    string query = "INSERT INTO Borrowers (Name, Email, Phone) " +
                                   "VALUES (@name, @email, @phone)";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters.
                    command.Parameters.AddWithValue("@name", TxtBorrowerName.Text);
                    command.Parameters.AddWithValue("@email", TxtBorrowerEmail.Text);
                    command.Parameters.AddWithValue("@phone", TxtBorrowerPhone.Text); // Phone is NOT NULL

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Refresh data and clear fields after adding.
                LoadBorrowers();
                BtnClearBorrowerFields_Click(sender, e);
                LoadBorrowersComboBox(); // Refresh the borrowers combo box.
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the dgvBorrowers DataGridView.
        /// Populates the borrower input fields with data from the selected row.
        /// Adapted to use the 'Name' column.
        /// </summary>
        private void DgvBorrowers_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvBorrowers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgvBorrowers.SelectedRows[0];
                TxtBorrowerName.Text = row.Cells["Name"].Value.ToString();
                TxtBorrowerEmail.Text = row.Cells["Email"].Value.ToString();
                TxtBorrowerPhone.Text = row.Cells["Phone"].Value.ToString(); // Phone is now NOT NULL
            }
        }

        /// <summary>
        /// Handles the Click event of the Edit Borrower button.
        /// Updates an existing borrower record in the database after validation.
        /// Adapted to use the 'Name' column.
        /// </summary>
        private void BtnEditBorrower_Click(object sender, EventArgs e)
        {
            if (DgvBorrowers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrower to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidateBorrowerFields())
            {
                int borrowerId = Convert.ToInt32(DgvBorrowers.SelectedRows[0].Cells["BorrowerID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // SQL query to update an existing borrower, using 'Name'.
                    string query = "UPDATE Borrowers SET Name = @name, Email = @email, " +
                                   "Phone = @phone WHERE BorrowerID = @id";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameters.
                    command.Parameters.AddWithValue("@name", TxtBorrowerName.Text);
                    command.Parameters.AddWithValue("@email", TxtBorrowerEmail.Text);
                    command.Parameters.AddWithValue("@phone", TxtBorrowerPhone.Text); // Phone is NOT NULL
                    command.Parameters.AddWithValue("@id", borrowerId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Refresh data and clear fields after editing.
                LoadBorrowers();
                BtnClearBorrowerFields_Click(sender, e);
                LoadBorrowersComboBox(); // Refresh the borrowers combo box.
            }
        }

        /// <summary>
        /// Handles the Click event of the Delete Borrower button.
        /// Deletes a borrower record from the database after confirmation and checks.
        /// </summary>
        private void BtnDeleteBorrower_Click(object sender, EventArgs e)
        {
            if (DgvBorrowers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrower to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirm deletion with the user.
            if (MessageBox.Show("Are you sure you want to delete this borrower?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int borrowerId = Convert.ToInt32(DgvBorrowers.SelectedRows[0].Cells["BorrowerID"].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // First, check if the borrower has any books not returned (Returned = 0).
                    string checkQuery = "SELECT COUNT(*) FROM IssuedBooks WHERE BorrowerID = @id AND Returned = 0";
                    SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@id", borrowerId);

                    int issuedCount = (int)checkCommand.ExecuteScalar();

                    if (issuedCount > 0)
                    {
                        MessageBox.Show("Cannot delete this borrower as they have books that haven't been returned.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // If no unreturned books, proceed with deletion.
                    string deleteQuery = "DELETE FROM Borrowers WHERE BorrowerID = @id";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@id", borrowerId);
                    deleteCommand.ExecuteNonQuery();
                }

                // Refresh data and clear fields after deletion.
                LoadBorrowers();
                BtnClearBorrowerFields_Click(sender, e);
                LoadBorrowersComboBox(); // Refresh the borrowers combo box.
            }
        }

        #endregion

        #region Issued Books Management

        /// <summary>
        /// Loads all issued book records from the database into the dgvIssuedBooks DataGridView.
        /// Includes joined data from Books and Borrowers tables.
        /// Adapted to use the 'Returned' BIT column.
        /// </summary>
        private void LoadIssuedBooks()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL query to get issued book details, including book title, borrower name, and status.
                // Uses 'br.Name' and 'i.Returned' (BIT) for status.
                string query = @"SELECT i.IssueID, b.Title AS BookTitle, br.Name AS BorrowerName,
                                 i.IssueDate, i.DueDate, i.Returned,
                                 CASE WHEN i.Returned = 0 THEN 'Issued' ELSE 'Returned' END AS Status
                                 FROM IssuedBooks i
                                 JOIN Books b ON i.BookID = b.BookID
                                 JOIN Borrowers br ON i.BorrowerID = br.BorrowerID
                                 ORDER BY i.IssueDate DESC"; // Order by most recent issue date.
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DgvIssuedBooks.DataSource = table;
            }
        }

        /// <summary>
        /// Loads available books into the cmbBooks ComboBox for issuing.
        /// Only includes books with AvailableCopies > 0.
        /// </summary>
        private void LoadBooksComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BookID, Title FROM Books WHERE AvailableCopies > 0 ORDER BY Title";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                CmbBooks.DataSource = table;
                CmbBooks.DisplayMember = "Title"; // Text displayed in the ComboBox.
                CmbBooks.ValueMember = "BookID";   // Actual value associated with the selected item.
            }
        }

        /// <summary>
        /// Loads all borrowers into the cmbBorrowers ComboBox for issuing.
        /// Adapted to use the 'Name' column.
        /// </summary>
        private void LoadBorrowersComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT BorrowerID, Name AS FullName FROM Borrowers ORDER BY Name"; // Using 'Name'
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                CmbBorrowers.DataSource = table;
                CmbBorrowers.DisplayMember = "FullName"; // Display full name.
                CmbBorrowers.ValueMember = "BorrowerID"; // Use BorrowerID as the value.
            }
        }

        /// <summary>
        /// Handles the Click event of the Issue Book button.
        /// Records a new book issue and decrements available copies, using a transaction.
        /// </summary>
        private void BtnIssueBook_Click(object sender, EventArgs e)
        {
            if (CmbBooks.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a book to issue.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CmbBorrowers.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a borrower.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected BookID and BorrowerID from ComboBoxes.
            int bookId = (int)CmbBooks.SelectedValue;
            int borrowerId = (int)CmbBorrowers.SelectedValue;
            DateTime issueDate = DtpIssueDate.Value;
            DateTime dueDate = DtpDueDate.Value;

            if (dueDate <= issueDate)
            {
                MessageBox.Show("Due date must be after issue date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if book is available (redundant check but good for immediate feedback).
                string checkQuery = "SELECT AvailableCopies FROM Books WHERE BookID = @bookId";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@bookId", bookId);

                int availableCopies = (int)checkCommand.ExecuteScalar();

                if (availableCopies < 1)
                {
                    MessageBox.Show("No available copies of this book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Use a SQL transaction to ensure atomicity of operations (issue and decrement copies).
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert issued book record. 'Returned' defaults to 0 (false).
                        string issueQuery = @"INSERT INTO IssuedBooks (BookID, BorrowerID, IssueDate, DueDate)
                                              VALUES (@bookId, @borrowerId, @issueDate, @dueDate)";
                        SqlCommand issueCommand = new SqlCommand(issueQuery, connection, transaction);
                        issueCommand.Parameters.AddWithValue("@bookId", bookId);
                        issueCommand.Parameters.AddWithValue("@borrowerId", borrowerId);
                        issueCommand.Parameters.AddWithValue("@issueDate", issueDate);
                        issueCommand.Parameters.AddWithValue("@dueDate", dueDate);
                        issueCommand.ExecuteNonQuery();

                        // Decrement available copies of the book.
                        string updateQuery = "UPDATE Books SET AvailableCopies = AvailableCopies - 1 WHERE BookID = @bookId";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
                        updateCommand.Parameters.AddWithValue("@bookId", bookId);
                        updateCommand.ExecuteNonQuery();

                        transaction.Commit(); // Commit the transaction if all operations succeed.

                        MessageBox.Show("Book issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh all relevant data displays.
                        LoadIssuedBooks();
                        LoadBooksComboBox();
                        LoadBooks();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Rollback on error to maintain data integrity.
                        MessageBox.Show("Error issuing book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the dgvIssuedBooks DataGridView.
        /// Enables or disables the Return Book button based on whether the selected book has been returned.
        /// Adapted to use the 'Returned' BIT column.
        /// </summary>
        private void DgvIssuedBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvIssuedBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DgvIssuedBooks.SelectedRows[0];

                // Check if 'Returned' column is true (1).
                bool isReturned = Convert.ToBoolean(row.Cells["Returned"].Value);
                BtnReturnBook.Enabled = !isReturned; // Enable if not returned (false), disable if already returned (true).
            }
            else
            {
                // If no row is selected, disable the return button.
                BtnReturnBook.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the Return Book button.
        /// Records a book return and increments available copies, using a transaction.
        /// Adapted to use the 'Returned' BIT column.
        /// </summary>
        private void BtnReturnBook_Click(object sender, EventArgs e)
        {
            if (DgvIssuedBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an issued book to return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = DgvIssuedBooks.SelectedRows[0];

            // Check if the book has already been returned.
            if (Convert.ToBoolean(row.Cells["Returned"].Value))
            {
                MessageBox.Show("This book has already been returned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int issueId = Convert.ToInt32(row.Cells["IssueID"].Value);

            // Retrieve BookID from IssuedBooks table to update AvailableCopies in Books table.
            int bookId;
            using (SqlConnection tempConnection = new SqlConnection(connectionString))
            {
                tempConnection.Open();
                SqlCommand getBookIdCommand = new SqlCommand("SELECT BookID FROM IssuedBooks WHERE IssueID = @issueId", tempConnection);
                getBookIdCommand.Parameters.AddWithValue("@issueId", issueId);
                bookId = (int)getBookIdCommand.ExecuteScalar();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Use a SQL transaction for atomicity (return and increment copies).
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Update issued book record: set Returned to 1 (true).
                        string returnQuery = "UPDATE IssuedBooks SET Returned = 1 WHERE IssueID = @issueId";
                        SqlCommand returnCommand = new SqlCommand(returnQuery, connection, transaction);
                        returnCommand.Parameters.AddWithValue("@issueId", issueId);
                        returnCommand.ExecuteNonQuery();

                        // Increment available copies of the book.
                        string updateQuery = "UPDATE Books SET AvailableCopies = AvailableCopies + 1 WHERE BookID = @bookId";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction);
                        updateCommand.Parameters.AddWithValue("@bookId", bookId);
                        updateCommand.ExecuteNonQuery();

                        transaction.Commit(); // Commit the transaction.

                        MessageBox.Show("Book returned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh all relevant data displays.
                        LoadIssuedBooks();
                        LoadBooksComboBox();
                        LoadBooks();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Rollback on error.
                        MessageBox.Show("Error returning book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the Search Issued Books button.
        /// Filters issued books based on search term and 'Show Returned' checkbox.
        /// Adapted to use the 'Returned' BIT column.
        /// </summary>
        private void BtnSearchIssuedBooks_Click(object sender, EventArgs e)
        {
            string searchTerm = TxtIssuedBookSearch.Text.Trim();
            bool showReturned = ChkShowReturned.Checked;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Base query for issued books, similar to LoadIssuedBooks.
                // Uses 'br.Name' and 'i.Returned' (BIT) for status.
                string query = @"SELECT i.IssueID, b.Title AS BookTitle, br.Name AS BorrowerName,
                                 i.IssueDate, i.DueDate, i.Returned,
                                 CASE WHEN i.Returned = 0 THEN 'Issued' ELSE 'Returned' END AS Status
                                 FROM IssuedBooks i
                                 JOIN Books b ON i.BookID = b.BookID
                                 JOIN Borrowers br ON i.BorrowerID = br.BorrowerID
                                 WHERE (b.Title LIKE @search OR br.Name LIKE @search)"; // Search by book title or borrower name

                // Conditionally add filter for unreturned books (Returned = 0).
                if (!showReturned)
                {
                    query += " AND i.Returned = 0";
                }

                query += " ORDER BY i.IssueDate DESC"; // Always order by issue date.

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DgvIssuedBooks.DataSource = table;
            }
        }

        #endregion

        private void TabPageIssuedBooks_Click(object sender, EventArgs e)
        {

        }

        private void TxtBookYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
