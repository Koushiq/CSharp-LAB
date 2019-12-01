namespace WindowsFormsApplication2
{
    partial class Home
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.lblMovieSearch = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdbratting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releasedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtAutoSearch);
            this.pnlMain.Controls.Add(this.txtSearchBox);
            this.pnlMain.Controls.Add(this.lblMovieSearch);
            this.pnlMain.Controls.Add(this.btnShowAll);
            this.pnlMain.Controls.Add(this.dgvMain);
            this.pnlMain.Location = new System.Drawing.Point(3, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(774, 502);
            this.pnlMain.TabIndex = 0;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(9, 66);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(161, 20);
            this.txtSearchBox.TabIndex = 3;
            // 
            // lblMovieSearch
            // 
            this.lblMovieSearch.AutoSize = true;
            this.lblMovieSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieSearch.Location = new System.Drawing.Point(176, 62);
            this.lblMovieSearch.Name = "lblMovieSearch";
            this.lblMovieSearch.Size = new System.Drawing.Size(76, 24);
            this.lblMovieSearch.TabIndex = 2;
            this.lblMovieSearch.Text = "Search";
            this.lblMovieSearch.Click += new System.EventHandler(this.lblMovieSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(557, 58);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(96, 34);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "ShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.imdbratting,
            this.income,
            this.releasedate,
            this.genre});
            this.dgvMain.Location = new System.Drawing.Point(0, 98);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(653, 401);
            this.dgvMain.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Movie ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Movie Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // imdbratting
            // 
            this.imdbratting.DataPropertyName = "imdbratting";
            this.imdbratting.HeaderText = "IMDB Score";
            this.imdbratting.Name = "imdbratting";
            this.imdbratting.ReadOnly = true;
            // 
            // income
            // 
            this.income.DataPropertyName = "income";
            this.income.HeaderText = "Movie Income";
            this.income.Name = "income";
            this.income.ReadOnly = true;
            // 
            // releasedate
            // 
            this.releasedate.DataPropertyName = "releasedate";
            this.releasedate.HeaderText = "Premire";
            this.releasedate.Name = "releasedate";
            this.releasedate.ReadOnly = true;
            // 
            // genre
            // 
            this.genre.DataPropertyName = "genre";
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(285, 66);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(161, 20);
            this.txtAutoSearch.TabIndex = 4;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 508);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Text = "Form1";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblMovieSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdbratting;
        private System.Windows.Forms.DataGridViewTextBoxColumn income;
        private System.Windows.Forms.DataGridViewTextBoxColumn releasedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.TextBox txtAutoSearch;


    }
}

