namespace EClerx.ADO.Day16
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
            this.DdlTestScore = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.GridCandidates = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridCandidates)).BeginInit();
            this.SuspendLayout();
            // 
            // DdlTestScore
            // 
            this.DdlTestScore.FormattingEnabled = true;
            this.DdlTestScore.Location = new System.Drawing.Point(464, 34);
            this.DdlTestScore.Name = "DdlTestScore";
            this.DdlTestScore.Size = new System.Drawing.Size(216, 28);
            this.DdlTestScore.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Test Score Range";
            // 
            // BtnSearch
            // 
            this.BtnSearch.AutoSize = true;
            this.BtnSearch.Location = new System.Drawing.Point(686, 32);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 30);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // GridCandidates
            // 
            this.GridCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCandidates.Location = new System.Drawing.Point(58, 139);
            this.GridCandidates.Name = "GridCandidates";
            this.GridCandidates.RowHeadersWidth = 51;
            this.GridCandidates.RowTemplate.Height = 24;
            this.GridCandidates.Size = new System.Drawing.Size(882, 307);
            this.GridCandidates.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 495);
            this.Controls.Add(this.GridCandidates);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DdlTestScore);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCandidates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DdlTestScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView GridCandidates;
    }
}

