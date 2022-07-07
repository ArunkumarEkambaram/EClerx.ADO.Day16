namespace EClerx.ADO.Day16
{
    partial class FrmExercise1
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
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFromPayDate = new System.Windows.Forms.DateTimePicker();
            this.DtpToPayDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.GridEmployees = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Date";
            // 
            // DtpFromPayDate
            // 
            this.DtpFromPayDate.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFromPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFromPayDate.Location = new System.Drawing.Point(133, 44);
            this.DtpFromPayDate.Name = "DtpFromPayDate";
            this.DtpFromPayDate.Size = new System.Drawing.Size(128, 28);
            this.DtpFromPayDate.TabIndex = 1;
            // 
            // DtpToPayDate
            // 
            this.DtpToPayDate.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpToPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpToPayDate.Location = new System.Drawing.Point(364, 43);
            this.DtpToPayDate.Name = "DtpToPayDate";
            this.DtpToPayDate.Size = new System.Drawing.Size(128, 28);
            this.DtpToPayDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(288, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Date";
            // 
            // GridEmployees
            // 
            this.GridEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEmployees.Location = new System.Drawing.Point(30, 111);
            this.GridEmployees.Name = "GridEmployees";
            this.GridEmployees.RowHeadersWidth = 51;
            this.GridEmployees.RowTemplate.Height = 24;
            this.GridEmployees.Size = new System.Drawing.Size(726, 277);
            this.GridEmployees.TabIndex = 5;
            // 
            // BtnSearch
            // 
            this.BtnSearch.AutoSize = true;
            this.BtnSearch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnSearch.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(514, 38);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 33);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FrmExercise1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.GridEmployees);
            this.Controls.Add(this.DtpToPayDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpFromPayDate);
            this.Controls.Add(this.label1);
            this.Name = "FrmExercise1";
            this.Text = "FrmExercise1";
            ((System.ComponentModel.ISupportInitialize)(this.GridEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFromPayDate;
        private System.Windows.Forms.DateTimePicker DtpToPayDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridEmployees;
        private System.Windows.Forms.Button BtnSearch;
    }
}