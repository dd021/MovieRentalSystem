
namespace MovieRentalSystem
{
    partial class MovieRentOperations
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioOut = new System.Windows.Forms.RadioButton();
            this.gridRent = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMovie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.pickerIssueDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.radioOut);
            this.groupBox1.Controls.Add(this.radioAll);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1327, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(211, 42);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(155, 33);
            this.radioAll.TabIndex = 1;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All Rented";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.radioAll_CheckedChanged);
            // 
            // radioOut
            // 
            this.radioOut.AutoSize = true;
            this.radioOut.Location = new System.Drawing.Point(893, 42);
            this.radioOut.Name = "radioOut";
            this.radioOut.Size = new System.Drawing.Size(166, 33);
            this.radioOut.TabIndex = 2;
            this.radioOut.TabStop = true;
            this.radioOut.Text = "Out Rented";
            this.radioOut.UseVisualStyleBackColor = true;
            this.radioOut.CheckedChanged += new System.EventHandler(this.radioOut_CheckedChanged);
            // 
            // gridRent
            // 
            this.gridRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRent.Location = new System.Drawing.Point(12, 132);
            this.gridRent.Name = "gridRent";
            this.gridRent.ReadOnly = true;
            this.gridRent.RowHeadersWidth = 51;
            this.gridRent.RowTemplate.Height = 24;
            this.gridRent.Size = new System.Drawing.Size(1327, 341);
            this.gridRent.TabIndex = 1;
            this.gridRent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRent_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.pickerIssueDate);
            this.panel1.Controls.Add(this.labelRent);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboMovie);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 326);
            this.panel1.TabIndex = 2;
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(863, 494);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(476, 81);
            this.btnIssue.TabIndex = 23;
            this.btnIssue.Text = "Issue Movie";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(863, 621);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(476, 75);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(863, 732);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(476, 88);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboCustomer
            // 
            this.comboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(238, 34);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(451, 33);
            this.comboCustomer.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer:";
            // 
            // comboMovie
            // 
            this.comboMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMovie.FormattingEnabled = true;
            this.comboMovie.Location = new System.Drawing.Point(238, 116);
            this.comboMovie.Name = "comboMovie";
            this.comboMovie.Size = new System.Drawing.Size(451, 33);
            this.comboMovie.TabIndex = 29;
            this.comboMovie.SelectedIndexChanged += new System.EventHandler(this.comboMovie_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Movie:";
            // 
            // labelRent
            // 
            this.labelRent.AutoSize = true;
            this.labelRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRent.Location = new System.Drawing.Point(303, 266);
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(63, 25);
            this.labelRent.TabIndex = 31;
            this.labelRent.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Movie Rental Cost $";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(78, 192);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(122, 25);
            this.labelDate.TabIndex = 33;
            this.labelDate.Text = "Issue Date:";
            // 
            // pickerIssueDate
            // 
            this.pickerIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerIssueDate.Location = new System.Drawing.Point(238, 187);
            this.pickerIssueDate.Name = "pickerIssueDate";
            this.pickerIssueDate.Size = new System.Drawing.Size(451, 30);
            this.pickerIssueDate.TabIndex = 32;
            // 
            // MovieRentOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 832);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridRent);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MovieRentOperations";
            this.Text = "Movie Rent Operations";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOut;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.DataGridView gridRent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker pickerIssueDate;
        private System.Windows.Forms.Label labelRent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMovie;
        private System.Windows.Forms.Label label2;
    }
}