
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
            this.TitleLabl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabl
            // 
            this.TitleLabl.AutoSize = true;
            this.TitleLabl.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TitleLabl.Location = new System.Drawing.Point(129, 115);
            this.TitleLabl.Name = "TitleLabl";
            this.TitleLabl.Size = new System.Drawing.Size(545, 28);
            this.TitleLabl.TabIndex = 0;
            this.TitleLabl.Text = "Welcome to Discussion Room Reservation";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginBtn.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LoginBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LoginBtn.Location = new System.Drawing.Point(193, 275);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(147, 42);
            this.LoginBtn.TabIndex = 1;
            this.LoginBtn.Text = "Log In";
            this.LoginBtn.UseVisualStyleBackColor = false;
            // 
            // SignupBtn
            // 
            this.SignupBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignupBtn.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SignupBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SignupBtn.Location = new System.Drawing.Point(447, 275);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(147, 42);
            this.SignupBtn.TabIndex = 2;
            this.SignupBtn.Text = "Sign Up";
            this.SignupBtn.UseVisualStyleBackColor = false;
            // 
            // Frm01_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignupBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.TitleLabl);
            this.Name = "Frm01_Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button SignupBtn;
    }
}

