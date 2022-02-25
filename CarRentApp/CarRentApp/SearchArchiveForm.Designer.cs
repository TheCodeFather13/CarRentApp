
namespace CarRentApp
{
    partial class SearchArchiveForm
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
            this.lSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.dgvCarRents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarRents)).BeginInit();
            this.SuspendLayout();
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSearch.Location = new System.Drawing.Point(69, 22);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(75, 25);
            this.lSearch.TabIndex = 0;
            this.lSearch.Text = "Search";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(181, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(318, 30);
            this.tbSearch.TabIndex = 2;
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProcess.Location = new System.Drawing.Point(544, 12);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(209, 77);
            this.btnProcess.TabIndex = 3;
            this.btnProcess.Text = "Process";
            this.btnProcess.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // dgvCarRents
            // 
            this.dgvCarRents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarRents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarRents.Location = new System.Drawing.Point(12, 95);
            this.dgvCarRents.Name = "dgvCarRents";
            this.dgvCarRents.Size = new System.Drawing.Size(776, 343);
            this.dgvCarRents.TabIndex = 4;
            // 
            // SearchArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCarRents);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lSearch);
            this.Name = "SearchArchiveForm";
            this.Text = "SearchArchiveForm";
            this.Load += new System.EventHandler(this.SearchArchiveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarRents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.DataGridView dgvCarRents;
    }
}