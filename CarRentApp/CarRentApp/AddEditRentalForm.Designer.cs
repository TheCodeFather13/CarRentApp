
namespace CarRentApp
{
    partial class AddEditRentalForm
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
            this.lCustomeName = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lCost = new System.Windows.Forms.Label();
            this.lDateRented = new System.Windows.Forms.Label();
            this.lDateReturned = new System.Windows.Forms.Label();
            this.lTypesOfCar = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDataRented = new System.Windows.Forms.DateTimePicker();
            this.dtpDataReturned = new System.Windows.Forms.DateTimePicker();
            this.cbTypeOfCar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lCustomeName
            // 
            this.lCustomeName.AutoSize = true;
            this.lCustomeName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lCustomeName.Font = new System.Drawing.Font("Meat Buckets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCustomeName.Location = new System.Drawing.Point(12, 45);
            this.lCustomeName.Name = "lCustomeName";
            this.lCustomeName.Size = new System.Drawing.Size(152, 23);
            this.lCustomeName.TabIndex = 0;
            this.lCustomeName.Text = "Customer Name";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCustomerName.Location = new System.Drawing.Point(194, 45);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(200, 29);
            this.tbCustomerName.TabIndex = 1;
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCost.Location = new System.Drawing.Point(194, 116);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(200, 29);
            this.tbCost.TabIndex = 3;
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lCost.Font = new System.Drawing.Font("Meat Buckets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCost.Location = new System.Drawing.Point(12, 116);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(51, 23);
            this.lCost.TabIndex = 2;
            this.lCost.Text = "Cost";
            // 
            // lDateRented
            // 
            this.lDateRented.AutoSize = true;
            this.lDateRented.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lDateRented.Font = new System.Drawing.Font("Meat Buckets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDateRented.Location = new System.Drawing.Point(12, 190);
            this.lDateRented.Name = "lDateRented";
            this.lDateRented.Size = new System.Drawing.Size(121, 23);
            this.lDateRented.TabIndex = 4;
            this.lDateRented.Text = "Date Rented";
            // 
            // lDateReturned
            // 
            this.lDateReturned.AutoSize = true;
            this.lDateReturned.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lDateReturned.Font = new System.Drawing.Font("Meat Buckets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDateReturned.Location = new System.Drawing.Point(12, 263);
            this.lDateReturned.Name = "lDateReturned";
            this.lDateReturned.Size = new System.Drawing.Size(138, 23);
            this.lDateReturned.TabIndex = 6;
            this.lDateReturned.Text = "Date Returned";
            // 
            // lTypesOfCar
            // 
            this.lTypesOfCar.AutoSize = true;
            this.lTypesOfCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTypesOfCar.Font = new System.Drawing.Font("Meat Buckets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTypesOfCar.Location = new System.Drawing.Point(12, 335);
            this.lTypesOfCar.Name = "lTypesOfCar";
            this.lTypesOfCar.Size = new System.Drawing.Size(134, 23);
            this.lTypesOfCar.TabIndex = 8;
            this.lTypesOfCar.Text = "Types of Cars";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(471, 152);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(251, 134);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDataRented
            // 
            this.dtpDataRented.Location = new System.Drawing.Point(194, 193);
            this.dtpDataRented.Name = "dtpDataRented";
            this.dtpDataRented.Size = new System.Drawing.Size(200, 20);
            this.dtpDataRented.TabIndex = 11;
            // 
            // dtpDataReturned
            // 
            this.dtpDataReturned.Location = new System.Drawing.Point(194, 263);
            this.dtpDataReturned.Name = "dtpDataReturned";
            this.dtpDataReturned.Size = new System.Drawing.Size(200, 20);
            this.dtpDataReturned.TabIndex = 12;
            // 
            // cbTypeOfCar
            // 
            this.cbTypeOfCar.Font = new System.Drawing.Font("Goudy Stout", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTypeOfCar.FormattingEnabled = true;
            this.cbTypeOfCar.Location = new System.Drawing.Point(194, 337);
            this.cbTypeOfCar.Name = "cbTypeOfCar";
            this.cbTypeOfCar.Size = new System.Drawing.Size(200, 31);
            this.cbTypeOfCar.TabIndex = 13;
            // 
            // AddEditRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentApp.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(1027, 535);
            this.Controls.Add(this.cbTypeOfCar);
            this.Controls.Add(this.dtpDataReturned);
            this.Controls.Add(this.dtpDataRented);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lTypesOfCar);
            this.Controls.Add(this.lDateReturned);
            this.Controls.Add(this.lDateRented);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.lCost);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.lCustomeName);
            this.Name = "AddEditRentalForm";
            this.Text = "AddEditRentalForm";
            this.Load += new System.EventHandler(this.AddEditRentalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCustomeName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.Label lDateRented;
        private System.Windows.Forms.Label lDateReturned;
        private System.Windows.Forms.Label lTypesOfCar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDataRented;
        private System.Windows.Forms.DateTimePicker dtpDataReturned;
        private System.Windows.Forms.ComboBox cbTypeOfCar;
    }
}