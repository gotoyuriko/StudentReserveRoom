
namespace WindowsFormsApp1
{
    partial class Form3
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

            this.TitleLbl = new System.Windows.Forms.Label();
            this.SignupLbl = new System.Windows.Forms.Label();
            this.UsernameTxtbox = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswordTxtbox = new System.Windows.Forms.TextBox();
            this.ConfirmpassTxtbox = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.ConfirmpassLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TitleLbl.Location = new System.Drawing.Point(108, 46);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(588, 32);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Welcome to Discussion Room Reservation";
            this.TitleLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // SignupLbl
            // 
            this.SignupLbl.AutoSize = true;
            this.SignupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SignupLbl.Location = new System.Drawing.Point(185, 95);
            this.SignupLbl.Name = "SignupLbl";
            this.SignupLbl.Size = new System.Drawing.Size(123, 32);
            this.SignupLbl.TabIndex = 1;
            this.SignupLbl.Text = "Sign Up";
            this.SignupLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // UsernameTxtbox
            // 
            this.UsernameTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxtbox.ForeColor = System.Drawing.Color.Silver;
            this.UsernameTxtbox.Location = new System.Drawing.Point(204, 176);
            this.UsernameTxtbox.Name = "UsernameTxtbox";
            this.UsernameTxtbox.Size = new System.Drawing.Size(378, 30);
            this.UsernameTxtbox.TabIndex = 2;
            this.UsernameTxtbox.Text = "Required Field";
            this.UsernameTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.UsernameLbl.Location = new System.Drawing.Point(201, 142);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(88, 17);
            this.UsernameLbl.TabIndex = 3;
            this.UsernameLbl.Text = "User Name";
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxtbox.ForeColor = System.Drawing.Color.Silver;
            this.PasswordTxtbox.Location = new System.Drawing.Point(204, 249);
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.Size = new System.Drawing.Size(378, 30);
            this.PasswordTxtbox.TabIndex = 4;
            this.PasswordTxtbox.Text = "Required Field";
            // 
            // ConfirmpassTxtbox
            // 
            this.ConfirmpassTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmpassTxtbox.ForeColor = System.Drawing.Color.Silver;
            this.ConfirmpassTxtbox.Location = new System.Drawing.Point(204, 325);
            this.ConfirmpassTxtbox.Name = "ConfirmpassTxtbox";
            this.ConfirmpassTxtbox.Size = new System.Drawing.Size(378, 30);
            this.ConfirmpassTxtbox.TabIndex = 5;
            this.ConfirmpassTxtbox.Text = "Required Field";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PasswordLbl.Location = new System.Drawing.Point(201, 219);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(77, 17);
            this.PasswordLbl.TabIndex = 6;
            this.PasswordLbl.Text = "Password";
            // 
            // ConfirmpassLbl
            // 
            this.ConfirmpassLbl.AutoSize = true;
            this.ConfirmpassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmpassLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ConfirmpassLbl.Location = new System.Drawing.Point(201, 294);
            this.ConfirmpassLbl.Name = "ConfirmpassLbl";
            this.ConfirmpassLbl.Size = new System.Drawing.Size(137, 17);
            this.ConfirmpassLbl.TabIndex = 7;
            this.ConfirmpassLbl.Text = "Confirm Password";
            this.ConfirmpassLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.Location = new System.Drawing.Point(334, 387);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(138, 39);
            this.LoginBtn.TabIndex = 8;
            this.LoginBtn.Text = "Sign Up";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ConfirmpassLbl);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.ConfirmpassTxtbox);
            this.Controls.Add(this.PasswordTxtbox);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.UsernameTxtbox);
            this.Controls.Add(this.SignupLbl);
            this.Controls.Add(this.TitleLbl);
            this.Name = "Form3";
            this.Text = "Sign up Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label SignupLbl;
        private System.Windows.Forms.TextBox UsernameTxtbox;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.TextBox PasswordTxtbox;
        private System.Windows.Forms.TextBox ConfirmpassTxtbox;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.Label ConfirmpassLbl;
        private System.Windows.Forms.Button LoginBtn;

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form3";
        }

        #endregion

    }
}