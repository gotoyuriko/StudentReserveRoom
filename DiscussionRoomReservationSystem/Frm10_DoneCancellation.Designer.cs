
namespace DiscussionRoomReservationSystem
{
    partial class Frm10_DoneCancellation
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
            this.BackMenubtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabl
            // 
            this.TitleLabl.AutoSize = true;
            this.TitleLabl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabl.ForeColor = System.Drawing.Color.Black;
            this.TitleLabl.Location = new System.Drawing.Point(64, 111);
            this.TitleLabl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabl.Name = "TitleLabl";
            this.TitleLabl.Size = new System.Drawing.Size(592, 38);
            this.TitleLabl.TabIndex = 3;
            this.TitleLabl.Text = "Your reservation has been cancelled.";
            this.TitleLabl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackMenubtn
            // 
            this.BackMenubtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackMenubtn.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.bg_ioop;
            this.BackMenubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackMenubtn.ForeColor = System.Drawing.Color.Black;
            this.BackMenubtn.Location = new System.Drawing.Point(227, 195);
            this.BackMenubtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BackMenubtn.Name = "BackMenubtn";
            this.BackMenubtn.Size = new System.Drawing.Size(133, 36);
            this.BackMenubtn.TabIndex = 15;
            this.BackMenubtn.Text = "Back to Menu";
            this.BackMenubtn.UseVisualStyleBackColor = false;
            this.BackMenubtn.Click += new System.EventHandler(this.BackMenubtn_Click);
            // 
            // Frm10_DoneCancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.undraw_Relaxing_at_home_re_mror;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.BackMenubtn);
            this.Controls.Add(this.TitleLabl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm10_DoneCancellation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm13_DoneCancellation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabl;
        private System.Windows.Forms.Button BackMenubtn;
    }
}