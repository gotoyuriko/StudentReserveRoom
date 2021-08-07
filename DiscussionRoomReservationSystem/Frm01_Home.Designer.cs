
namespace DiscussionRoomReservationSystem
{
    partial class Frm01_Home
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
            this.titleLabl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabl
            // 
            this.titleLabl.AutoSize = true;
            this.titleLabl.BackColor = System.Drawing.Color.Transparent;
            this.titleLabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.titleLabl.ForeColor = System.Drawing.Color.Black;
            this.titleLabl.Location = new System.Drawing.Point(74, 88);
            this.titleLabl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabl.Name = "titleLabl";
            this.titleLabl.Size = new System.Drawing.Size(588, 32);
            this.titleLabl.TabIndex = 0;
            this.titleLabl.Text = "Welcome to Discussion Room Reservation";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(134, 231);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(110, 36);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.signUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.signUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.signUpBtn.ForeColor = System.Drawing.Color.Black;
            this.signUpBtn.Location = new System.Drawing.Point(366, 231);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(110, 36);
            this.signUpBtn.TabIndex = 2;
            this.signUpBtn.Text = "Sign Up";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.Image = global::DiscussionRoomReservationSystem.Properties.Resources.icons8_exit_100;
            this.exitBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exitBtn.Location = new System.Drawing.Point(500, 42);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 43);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitBtn.TabIndex = 3;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Frm01_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.undraw_conversation_h12g;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.titleLabl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm01_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wai";
            this.Load += new System.EventHandler(this.Frm01_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.PictureBox exitBtn;
    }
}

