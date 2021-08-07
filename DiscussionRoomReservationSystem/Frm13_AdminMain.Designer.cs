
namespace DiscussionRoomReservationSystem
{
    partial class Frm13_AdminMain
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
            this.LogoutPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DailyBtn
            // 
            this.DailyBtn.BackColor = System.Drawing.Color.SaddleBrown;
            this.DailyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DailyBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyBtn.ForeColor = System.Drawing.Color.White;
            this.DailyBtn.Location = new System.Drawing.Point(96, 270);
            this.DailyBtn.Name = "DailyBtn";
            this.DailyBtn.Size = new System.Drawing.Size(193, 52);
            this.DailyBtn.TabIndex = 13;
            this.DailyBtn.Text = "Daily Reports";
            this.DailyBtn.UseVisualStyleBackColor = false;
            this.DailyBtn.Click += new System.EventHandler(this.DailyBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Century", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.Black;
            this.TitleLbl.Location = new System.Drawing.Point(195, 80);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(412, 39);
            this.TitleLbl.TabIndex = 12;
            this.TitleLbl.Text = "Welcome, Administrator";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MonthlyBtn
            // 
            this.MonthlyBtn.BackColor = System.Drawing.Color.Indigo;
            this.MonthlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthlyBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyBtn.ForeColor = System.Drawing.Color.White;
            this.MonthlyBtn.Location = new System.Drawing.Point(498, 270);
            this.MonthlyBtn.Name = "MonthlyBtn";
            this.MonthlyBtn.Size = new System.Drawing.Size(210, 52);
            this.MonthlyBtn.TabIndex = 14;
            this.MonthlyBtn.Text = "Monthly Reports";
            this.MonthlyBtn.UseVisualStyleBackColor = false;
            this.MonthlyBtn.Click += new System.EventHandler(this.MonthlyBtn_Click);
            // 
            // RequestBtn
            // 
            this.RequestBtn.BackColor = System.Drawing.Color.MistyRose;
            this.RequestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RequestBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestBtn.ForeColor = System.Drawing.Color.Black;
            this.RequestBtn.Location = new System.Drawing.Point(251, 368);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(267, 53);
            this.RequestBtn.TabIndex = 15;
            this.RequestBtn.Text = "Pending Request";
            this.RequestBtn.UseVisualStyleBackColor = false;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // LogoutPicBox
            // 
            this.LogoutPicBox.Image = global::DiscussionRoomReservationSystem.Properties.Resources.icons8_exit_100;
            this.LogoutPicBox.Location = new System.Drawing.Point(683, 35);
            this.LogoutPicBox.Name = "LogoutPicBox";
            this.LogoutPicBox.Size = new System.Drawing.Size(55, 63);
            this.LogoutPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoutPicBox.TabIndex = 17;
            this.LogoutPicBox.TabStop = false;
            this.LogoutPicBox.Click += new System.EventHandler(this.LogoutPicBox_Click);
            // 
            // Frm13_AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.undraw_Growth_analytics_re_pyxf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.LogoutPicBox);
            this.Controls.Add(this.RequestBtn);
            this.Controls.Add(this.MonthlyBtn);
            this.Controls.Add(this.DailyBtn);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm13_AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm14_AdminMain";
            this.Load += new System.EventHandler(this.Frm13_AdminMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DailyBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button MonthlyBtn;
        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.PictureBox LogoutPicBox;
    }
}