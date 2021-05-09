
namespace MovieRentalSystem
{
    partial class MovieOperations
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textReleaseYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textGenreName = new System.Windows.Forms.TextBox();
            this.numericRating = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textMovieTitle = new System.Windows.Forms.TextBox();
            this.gridMovie = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(895, 659);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(402, 54);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete Movie";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(452, 659);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(402, 54);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Movie";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 659);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(402, 54);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add New Movie";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textReleaseYear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textGenreName);
            this.panel1.Controls.Add(this.numericRating);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textMovieTitle);
            this.panel1.Location = new System.Drawing.Point(12, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 161);
            this.panel1.TabIndex = 15;
            // 
            // textReleaseYear
            // 
            this.textReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReleaseYear.Location = new System.Drawing.Point(917, 104);
            this.textReleaseYear.Name = "textReleaseYear";
            this.textReleaseYear.Size = new System.Drawing.Size(301, 30);
            this.textReleaseYear.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(688, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Release Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Genre Name:";
            // 
            // textGenreName
            // 
            this.textGenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGenreName.Location = new System.Drawing.Point(240, 104);
            this.textGenreName.Name = "textGenreName";
            this.textGenreName.Size = new System.Drawing.Size(402, 30);
            this.textGenreName.TabIndex = 12;
            // 
            // numericRating
            // 
            this.numericRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericRating.Location = new System.Drawing.Point(917, 18);
            this.numericRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericRating.Name = "numericRating";
            this.numericRating.Size = new System.Drawing.Size(301, 30);
            this.numericRating.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(684, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Movie Rating:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Movie Title:";
            // 
            // textMovieTitle
            // 
            this.textMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMovieTitle.Location = new System.Drawing.Point(240, 17);
            this.textMovieTitle.Name = "textMovieTitle";
            this.textMovieTitle.Size = new System.Drawing.Size(402, 30);
            this.textMovieTitle.TabIndex = 3;
            // 
            // gridMovie
            // 
            this.gridMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMovie.Location = new System.Drawing.Point(12, 12);
            this.gridMovie.Name = "gridMovie";
            this.gridMovie.ReadOnly = true;
            this.gridMovie.RowHeadersWidth = 51;
            this.gridMovie.RowTemplate.Height = 24;
            this.gridMovie.Size = new System.Drawing.Size(1285, 433);
            this.gridMovie.TabIndex = 14;
            this.gridMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMovie_CellClick);
            // 
            // MovieOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 735);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridMovie);
            this.MaximizeBox = false;
            this.Name = "MovieOperations";
            this.Text = "Movie Operations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MovieOperations_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textReleaseYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textGenreName;
        private System.Windows.Forms.NumericUpDown numericRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMovieTitle;
        private System.Windows.Forms.DataGridView gridMovie;
    }
}