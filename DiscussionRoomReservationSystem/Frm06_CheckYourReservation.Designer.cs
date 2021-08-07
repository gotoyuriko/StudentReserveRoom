
namespace DiscussionRoomReservationSystem
{
    partial class Frm06_CheckYourReservation
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
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.EndTimeLbl = new System.Windows.Forms.Label();
            this.StartTimeLbl = new System.Windows.Forms.Label();
            this.RoomTitleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.Black;
            this.TitleLbl.Location = new System.Drawing.Point(134, 66);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(395, 38);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Check Your Reservation";
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.Black;
            this.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmBtn.Location = new System.Drawing.Point(305, 344);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(183, 39);
            this.ConfirmBtn.TabIndex = 14;
            this.ConfirmBtn.Text = "Confirm Reservation";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.BackColor = System.Drawing.Color.White;
            this.ChangeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBtn.ForeColor = System.Drawing.Color.Black;
            this.ChangeBtn.Location = new System.Drawing.Point(90, 344);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(183, 39);
            this.ChangeBtn.TabIndex = 15;
            this.ChangeBtn.Text = "Change Reservation";
            this.ChangeBtn.UseVisualStyleBackColor = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // EndTimeLbl
            // 
            this.EndTimeLbl.AutoSize = true;
            this.EndTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.EndTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeLbl.ForeColor = System.Drawing.Color.Black;
            this.EndTimeLbl.Location = new System.Drawing.Point(136, 258);
            this.EndTimeLbl.Name = "EndTimeLbl";
            this.EndTimeLbl.Size = new System.Drawing.Size(324, 25);
            this.EndTimeLbl.TabIndex = 18;
            this.EndTimeLbl.Text = "Reserved Time: HH:MM-HH:MM";
            // 
            // StartTimeLbl
            // 
            this.StartTimeLbl.AutoSize = true;
            this.StartTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.StartTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLbl.ForeColor = System.Drawing.Color.Black;
            this.StartTimeLbl.Location = new System.Drawing.Point(136, 211);
            this.StartTimeLbl.Name = "StartTimeLbl";
            this.StartTimeLbl.Size = new System.Drawing.Size(324, 25);
            this.StartTimeLbl.TabIndex = 17;
            this.StartTimeLbl.Text = "Reserved Time: HH:MM-HH:MM";
            // 
            // RoomTitleLbl
            // 
            this.RoomTitleLbl.AutoSize = true;
            this.RoomTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.RoomTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTitleLbl.ForeColor = System.Drawing.Color.Black;
            this.RoomTitleLbl.Location = new System.Drawing.Point(136, 151);
            this.RoomTitleLbl.Name = "RoomTitleLbl";
            this.RoomTitleLbl.Size = new System.Drawing.Size(181, 32);
            this.RoomTitleLbl.TabIndex = 16;
            this.RoomTitleLbl.Text = "Room Name";
            // 
            // Frm06_CheckYourReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.bg_ioop;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.EndTimeLbl);
            this.Controls.Add(this.StartTimeLbl);
            this.Controls.Add(this.RoomTitleLbl);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm06_CheckYourReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm9_CheckYourReservation";
            this.Load += new System.EventHandler(this.Frm09_CheckYourReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Label EndTimeLbl;
        private System.Windows.Forms.Label StartTimeLbl;
        private System.Windows.Forms.Label RoomTitleLbl;
    }
}