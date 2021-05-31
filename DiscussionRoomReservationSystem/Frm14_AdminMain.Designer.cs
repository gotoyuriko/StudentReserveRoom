
namespace DiscussionRoomReservationSystem
{
    partial class Frm14_AdminMain
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
            this.DailyBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.MonthlyBtn = new System.Windows.Forms.Button();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.LogooutLbl = new System.Windows.Forms.Label();
            this.LogoutPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DailyBtn
            // 
            this.DailyBtn.BackColor = System.Drawing.Color.White;
            this.DailyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DailyBtn.Location = new System.Drawing.Point(312, 121);
            this.DailyBtn.Name = "DailyBtn";
            this.DailyBtn.Size = new System.Drawing.Size(163, 49);
            this.DailyBtn.TabIndex = 13;
            this.DailyBtn.Text = "Daily Reports";
            this.DailyBtn.UseVisualStyleBackColor = false;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TitleLbl.Location = new System.Drawing.Point(229, 38);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(329, 32);
            this.TitleLbl.TabIndex = 12;
            this.TitleLbl.Text = "Welcome Administrator";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MonthlyBtn
            // 
            this.MonthlyBtn.BackColor = System.Drawing.Color.White;
            this.MonthlyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MonthlyBtn.Location = new System.Drawing.Point(312, 198);
            this.MonthlyBtn.Name = "MonthlyBtn";
            this.MonthlyBtn.Size = new System.Drawing.Size(163, 49);
            this.MonthlyBtn.TabIndex = 14;
            this.MonthlyBtn.Text = "Monthly Reports";
            this.MonthlyBtn.UseVisualStyleBackColor = false;
            // 
            // RequestBtn
            // 
            this.RequestBtn.BackColor = System.Drawing.Color.White;
            this.RequestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RequestBtn.Location = new System.Drawing.Point(312, 272);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(163, 49);
            this.RequestBtn.TabIndex = 15;
            this.RequestBtn.Text = "Pending Request";
            this.RequestBtn.UseVisualStyleBackColor = false;
            // 
            // LogooutLbl
            // 
            this.LogooutLbl.AutoSize = true;
            this.LogooutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogooutLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LogooutLbl.Location = new System.Drawing.Point(25, 61);
            this.LogooutLbl.Name = "LogooutLbl";
            this.LogooutLbl.Size = new System.Drawing.Size(58, 17);
            this.LogooutLbl.TabIndex = 16;
            this.LogooutLbl.Text = "Logout";
            // 
            // LogoutPicBox
            // 
            this.LogoutPicBox.Image = global::DiscussionRoomReservationSystem.Properties.Resources.logout;
            this.LogoutPicBox.Location = new System.Drawing.Point(28, 11);
            this.LogoutPicBox.Name = "LogoutPicBox";
            this.LogoutPicBox.Size = new System.Drawing.Size(55, 47);
            this.LogoutPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoutPicBox.TabIndex = 17;
            this.LogoutPicBox.TabStop = false;
            // 
            // Frm14_AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutPicBox);
            this.Controls.Add(this.LogooutLbl);
            this.Controls.Add(this.RequestBtn);
            this.Controls.Add(this.MonthlyBtn);
            this.Controls.Add(this.DailyBtn);
            this.Controls.Add(this.TitleLbl);
            this.Name = "Frm14_AdminMain";
            this.Text = "Frm14_AdminMain";
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DailyBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button MonthlyBtn;
        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.Label LogooutLbl;
        private System.Windows.Forms.PictureBox LogoutPicBox;
    }
}