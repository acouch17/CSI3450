namespace CSI3450_MovieDatabase
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
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.movieId = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.directorID = new System.Windows.Forms.TextBox();
            this.testBox = new System.Windows.Forms.ListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.movieDescriptionLabel = new System.Windows.Forms.Label();
            this.movieReleaseDateLabel = new System.Windows.Forms.Label();
            this.movieLengthLabel = new System.Windows.Forms.Label();
            this.movieIDLabel = new System.Windows.Forms.Label();
            this.movieDirectorIDLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(370, 368);
            this.btnLoadAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(56, 19);
            this.btnLoadAll.TabIndex = 0;
            this.btnLoadAll.Text = "Load";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // movieId
            // 
            this.movieId.Location = new System.Drawing.Point(125, 84);
            this.movieId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.movieId.Name = "movieId";
            this.movieId.Size = new System.Drawing.Size(119, 20);
            this.movieId.TabIndex = 3;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(125, 120);
            this.title.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(119, 20);
            this.title.TabIndex = 4;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(125, 154);
            this.description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(119, 20);
            this.description.TabIndex = 5;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(125, 186);
            this.length.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(119, 20);
            this.length.TabIndex = 7;
            // 
            // directorID
            // 
            this.directorID.Location = new System.Drawing.Point(125, 220);
            this.directorID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.directorID.Name = "directorID";
            this.directorID.Size = new System.Drawing.Size(119, 20);
            this.directorID.TabIndex = 8;
            // 
            // testBox
            // 
            this.testBox.FormattingEnabled = true;
            this.testBox.Location = new System.Drawing.Point(279, 10);
            this.testBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(585, 342);
            this.testBox.TabIndex = 10;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(121, 297);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(123, 20);
            this.searchBox.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(50, 297);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 19);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(151, 47);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.Location = new System.Drawing.Point(92, 123);
            this.movieTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(30, 13);
            this.movieTitleLabel.TabIndex = 16;
            this.movieTitleLabel.Text = "Title:";
            // 
            // movieDescriptionLabel
            // 
            this.movieDescriptionLabel.AutoSize = true;
            this.movieDescriptionLabel.Location = new System.Drawing.Point(58, 156);
            this.movieDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieDescriptionLabel.Name = "movieDescriptionLabel";
            this.movieDescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.movieDescriptionLabel.TabIndex = 17;
            this.movieDescriptionLabel.Text = "Description:";
            // 
            // movieReleaseDateLabel
            // 
            this.movieReleaseDateLabel.AutoSize = true;
            this.movieReleaseDateLabel.Location = new System.Drawing.Point(47, 252);
            this.movieReleaseDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieReleaseDateLabel.Name = "movieReleaseDateLabel";
            this.movieReleaseDateLabel.Size = new System.Drawing.Size(75, 13);
            this.movieReleaseDateLabel.TabIndex = 18;
            this.movieReleaseDateLabel.Text = "Release Date:";
            // 
            // movieLengthLabel
            // 
            this.movieLengthLabel.AutoSize = true;
            this.movieLengthLabel.Location = new System.Drawing.Point(66, 188);
            this.movieLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieLengthLabel.Name = "movieLengthLabel";
            this.movieLengthLabel.Size = new System.Drawing.Size(56, 13);
            this.movieLengthLabel.TabIndex = 19;
            this.movieLengthLabel.Text = "Run Time:";
            // 
            // movieIDLabel
            // 
            this.movieIDLabel.AutoSize = true;
            this.movieIDLabel.Location = new System.Drawing.Point(71, 87);
            this.movieIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieIDLabel.Name = "movieIDLabel";
            this.movieIDLabel.Size = new System.Drawing.Size(53, 13);
            this.movieIDLabel.TabIndex = 20;
            this.movieIDLabel.Text = "Movie ID:";
            // 
            // movieDirectorIDLabel
            // 
            this.movieDirectorIDLabel.AutoSize = true;
            this.movieDirectorIDLabel.Location = new System.Drawing.Point(62, 223);
            this.movieDirectorIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.movieDirectorIDLabel.Name = "movieDirectorIDLabel";
            this.movieDirectorIDLabel.Size = new System.Drawing.Size(61, 13);
            this.movieDirectorIDLabel.TabIndex = 21;
            this.movieDirectorIDLabel.Text = "Director ID:";
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(125, 252);
            this.dateBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(119, 20);
            this.dateBox.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(50, 332);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 19);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(121, 332);
            this.deleteBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(123, 20);
            this.deleteBox.TabIndex = 25;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(279, 368);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 19);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 428);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.deleteBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.movieDirectorIDLabel);
            this.Controls.Add(this.movieIDLabel);
            this.Controls.Add(this.movieLengthLabel);
            this.Controls.Add(this.movieReleaseDateLabel);
            this.Controls.Add(this.movieDescriptionLabel);
            this.Controls.Add(this.movieTitleLabel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.directorID);
            this.Controls.Add(this.length);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Controls.Add(this.movieId);
            this.Controls.Add(this.btnLoadAll);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "DBMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.TextBox movieId;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox directorID;
        private System.Windows.Forms.ListBox testBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Label movieDescriptionLabel;
        private System.Windows.Forms.Label movieReleaseDateLabel;
        private System.Windows.Forms.Label movieLengthLabel;
        private System.Windows.Forms.Label movieIDLabel;
        private System.Windows.Forms.Label movieDirectorIDLabel;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.Button btnUpdate;
    }
}

