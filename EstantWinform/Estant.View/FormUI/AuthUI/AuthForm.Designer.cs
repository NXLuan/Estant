
namespace Estant.View.FormUI.AuthUI
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.tabForm = new System.Windows.Forms.TabControl();
            this.tabSignIn = new System.Windows.Forms.TabPage();
            this.lbCreateAccount = new System.Windows.Forms.Label();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.tbPassword = new Estant.View.CustomControl.TextboxCustom();
            this.tbEmail = new Estant.View.CustomControl.TextboxCustom();
            this.label3 = new System.Windows.Forms.Label();
            this.tabSigUp = new System.Windows.Forms.TabPage();
            this.pbBackFromSignUp = new System.Windows.Forms.PictureBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new Estant.View.CustomControl.TextboxCustom();
            this.tbPasswordSignUp = new Estant.View.CustomControl.TextboxCustom();
            this.tbEmailSignUp = new Estant.View.CustomControl.TextboxCustom();
            this.tbName = new Estant.View.CustomControl.TextboxCustom();
            this.tabResetPassword = new System.Windows.Forms.TabPage();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.pbBackFromReset = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmailReset = new Estant.View.CustomControl.TextboxCustom();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabForm.SuspendLayout();
            this.tabSignIn.SuspendLayout();
            this.tabSigUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFromSignUp)).BeginInit();
            this.tabResetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFromReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabForm
            // 
            this.tabForm.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabForm.Controls.Add(this.tabSignIn);
            this.tabForm.Controls.Add(this.tabSigUp);
            this.tabForm.Controls.Add(this.tabResetPassword);
            this.tabForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabForm.ItemSize = new System.Drawing.Size(0, 1);
            this.tabForm.Location = new System.Drawing.Point(410, 0);
            this.tabForm.Multiline = true;
            this.tabForm.Name = "tabForm";
            this.tabForm.Padding = new System.Drawing.Point(0, 0);
            this.tabForm.SelectedIndex = 0;
            this.tabForm.Size = new System.Drawing.Size(416, 560);
            this.tabForm.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabForm.TabIndex = 1;
            // 
            // tabSignIn
            // 
            this.tabSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.tabSignIn.Controls.Add(this.lbCreateAccount);
            this.tabSignIn.Controls.Add(this.lbForgotPassword);
            this.tabSignIn.Controls.Add(this.label4);
            this.tabSignIn.Controls.Add(this.btnSignIn);
            this.tabSignIn.Controls.Add(this.tbPassword);
            this.tabSignIn.Controls.Add(this.tbEmail);
            this.tabSignIn.Controls.Add(this.label3);
            this.tabSignIn.Location = new System.Drawing.Point(4, 5);
            this.tabSignIn.Name = "tabSignIn";
            this.tabSignIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabSignIn.Size = new System.Drawing.Size(408, 551);
            this.tabSignIn.TabIndex = 0;
            this.tabSignIn.Text = "tabPage1";
            // 
            // lbCreateAccount
            // 
            this.lbCreateAccount.AutoSize = true;
            this.lbCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCreateAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.lbCreateAccount.Location = new System.Drawing.Point(141, 501);
            this.lbCreateAccount.Name = "lbCreateAccount";
            this.lbCreateAccount.Size = new System.Drawing.Size(126, 23);
            this.lbCreateAccount.TabIndex = 11;
            this.lbCreateAccount.Text = "Create account";
            this.lbCreateAccount.Click += new System.EventHandler(this.lbCreateAccount_Click);
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgotPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lbForgotPassword.Location = new System.Drawing.Point(126, 390);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(151, 23);
            this.lbForgotPassword.TabIndex = 10;
            this.lbForgotPassword.Text = " Forgot password?";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(108, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Don\'t have an account?";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(111, 332);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(189, 44);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.tbPassword.Location = new System.Drawing.Point(43, 222);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PassChar = '●';
            this.tbPassword.Size = new System.Drawing.Size(323, 77);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.Title = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.tbEmail.Location = new System.Drawing.Point(43, 121);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PassChar = '\0';
            this.tbEmail.Size = new System.Drawing.Size(323, 78);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.Title = "Email address";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Welcome!";
            // 
            // tabSigUp
            // 
            this.tabSigUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.tabSigUp.Controls.Add(this.pbBackFromSignUp);
            this.tabSigUp.Controls.Add(this.btnSignUp);
            this.tabSigUp.Controls.Add(this.label5);
            this.tabSigUp.Controls.Add(this.tbConfirmPassword);
            this.tabSigUp.Controls.Add(this.tbPasswordSignUp);
            this.tabSigUp.Controls.Add(this.tbEmailSignUp);
            this.tabSigUp.Controls.Add(this.tbName);
            this.tabSigUp.Location = new System.Drawing.Point(4, 5);
            this.tabSigUp.Name = "tabSigUp";
            this.tabSigUp.Size = new System.Drawing.Size(408, 551);
            this.tabSigUp.TabIndex = 1;
            this.tabSigUp.Text = "tabPage1";
            // 
            // pbBackFromSignUp
            // 
            this.pbBackFromSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBackFromSignUp.Image = ((System.Drawing.Image)(resources.GetObject("pbBackFromSignUp.Image")));
            this.pbBackFromSignUp.Location = new System.Drawing.Point(41, 27);
            this.pbBackFromSignUp.Name = "pbBackFromSignUp";
            this.pbBackFromSignUp.Size = new System.Drawing.Size(51, 27);
            this.pbBackFromSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackFromSignUp.TabIndex = 11;
            this.pbBackFromSignUp.TabStop = false;
            this.pbBackFromSignUp.Click += new System.EventHandler(this.pbBackFromSignUp_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(113, 479);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(189, 44);
            this.btnSignUp.TabIndex = 10;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(101, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Create Account";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.tbConfirmPassword.Location = new System.Drawing.Point(47, 366);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PassChar = '●';
            this.tbConfirmPassword.Size = new System.Drawing.Size(318, 77);
            this.tbConfirmPassword.TabIndex = 9;
            this.tbConfirmPassword.Title = "Confirm password";
            // 
            // tbPasswordSignUp
            // 
            this.tbPasswordSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.tbPasswordSignUp.Location = new System.Drawing.Point(47, 265);
            this.tbPasswordSignUp.Name = "tbPasswordSignUp";
            this.tbPasswordSignUp.PassChar = '●';
            this.tbPasswordSignUp.Size = new System.Drawing.Size(318, 79);
            this.tbPasswordSignUp.TabIndex = 8;
            this.tbPasswordSignUp.Title = "Password";
            // 
            // tbEmailSignUp
            // 
            this.tbEmailSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.tbEmailSignUp.Location = new System.Drawing.Point(47, 169);
            this.tbEmailSignUp.Name = "tbEmailSignUp";
            this.tbEmailSignUp.PassChar = '\0';
            this.tbEmailSignUp.Size = new System.Drawing.Size(318, 76);
            this.tbEmailSignUp.TabIndex = 7;
            this.tbEmailSignUp.Title = "Email address";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.tbName.Location = new System.Drawing.Point(47, 75);
            this.tbName.Name = "tbName";
            this.tbName.PassChar = '\0';
            this.tbName.Size = new System.Drawing.Size(318, 74);
            this.tbName.TabIndex = 6;
            this.tbName.Title = "Name";
            // 
            // tabResetPassword
            // 
            this.tabResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.tabResetPassword.Controls.Add(this.btnResetPassword);
            this.tabResetPassword.Controls.Add(this.pbBackFromReset);
            this.tabResetPassword.Controls.Add(this.label6);
            this.tabResetPassword.Controls.Add(this.tbEmailReset);
            this.tabResetPassword.Location = new System.Drawing.Point(4, 5);
            this.tabResetPassword.Name = "tabResetPassword";
            this.tabResetPassword.Size = new System.Drawing.Size(408, 551);
            this.tabResetPassword.TabIndex = 2;
            this.tabResetPassword.Text = "tabPage1";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(190)))), ((int)(((byte)(77)))));
            this.btnResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(120, 291);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(189, 44);
            this.btnResetPassword.TabIndex = 14;
            this.btnResetPassword.Text = "Reset password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // pbBackFromReset
            // 
            this.pbBackFromReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBackFromReset.Image = ((System.Drawing.Image)(resources.GetObject("pbBackFromReset.Image")));
            this.pbBackFromReset.Location = new System.Drawing.Point(45, 32);
            this.pbBackFromReset.Name = "pbBackFromReset";
            this.pbBackFromReset.Size = new System.Drawing.Size(51, 27);
            this.pbBackFromReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBackFromReset.TabIndex = 13;
            this.pbBackFromReset.TabStop = false;
            this.pbBackFromReset.Click += new System.EventHandler(this.pbBackFromReset_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(105, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Forgot password";
            // 
            // tbEmailReset
            // 
            this.tbEmailReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(106)))), ((int)(((byte)(77)))));
            this.tbEmailReset.Location = new System.Drawing.Point(51, 178);
            this.tbEmailReset.Name = "tbEmailReset";
            this.tbEmailReset.PassChar = '\0';
            this.tbEmailReset.Size = new System.Drawing.Size(323, 78);
            this.tbEmailReset.TabIndex = 7;
            this.tbEmailReset.Title = "Email address";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = " Improve your English instantly";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estant";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthForm_FormClosed);
            this.tabForm.ResumeLayout(false);
            this.tabSignIn.ResumeLayout(false);
            this.tabSignIn.PerformLayout();
            this.tabSigUp.ResumeLayout(false);
            this.tabSigUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFromSignUp)).EndInit();
            this.tabResetPassword.ResumeLayout(false);
            this.tabResetPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackFromReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabForm;
        private System.Windows.Forms.TabPage tabSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private CustomControl.TextboxCustom tbEmail;
        private CustomControl.TextboxCustom tbPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lbForgotPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCreateAccount;
        private System.Windows.Forms.TabPage tabSigUp;
        private CustomControl.TextboxCustom tbConfirmPassword;
        private CustomControl.TextboxCustom tbPasswordSignUp;
        private CustomControl.TextboxCustom tbEmailSignUp;
        private CustomControl.TextboxCustom tbName;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox pbBackFromSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabResetPassword;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.PictureBox pbBackFromReset;
        private System.Windows.Forms.Label label6;
        private CustomControl.TextboxCustom tbEmailReset;
    }
}