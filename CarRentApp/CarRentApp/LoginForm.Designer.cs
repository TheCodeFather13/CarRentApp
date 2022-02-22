
namespace CarRentApp
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IUsername = new System.Windows.Forms.Label();
            this.IPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRentApp.Properties.Resources.mid_333368_689628;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 329);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IUsername
            // 
            this.IUsername.AutoSize = true;
            this.IUsername.Location = new System.Drawing.Point(666, 12);
            this.IUsername.Name = "IUsername";
            this.IUsername.Size = new System.Drawing.Size(97, 24);
            this.IUsername.TabIndex = 1;
            this.IUsername.Text = "Username";
            this.IUsername.Click += new System.EventHandler(this.IUsername_Click);
            // 
            // IPassword
            // 
            this.IPassword.AutoSize = true;
            this.IPassword.Location = new System.Drawing.Point(666, 186);
            this.IPassword.Name = "IPassword";
            this.IPassword.Size = new System.Drawing.Size(92, 24);
            this.IPassword.TabIndex = 2;
            this.IPassword.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(615, 39);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(200, 29);
            this.tbUsername.TabIndex = 3;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            this.tbUsername.Validating += new System.ComponentModel.CancelEventHandler(this.tbUsername_Validating);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(615, 231);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '$';
            this.tbPassword.Size = new System.Drawing.Size(200, 29);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.MouseLeave += new System.EventHandler(this.tbPassword_MouseLeave);
            this.tbPassword.Move += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Location = new System.Drawing.Point(665, 281);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(126, 60);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 831);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.IPassword);
            this.Controls.Add(this.IUsername);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label IUsername;
        private System.Windows.Forms.Label IPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}

