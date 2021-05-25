
namespace DiscussionRoomReservationSystem
{
    partial class Frm09_CheckYourReservation
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
            this.ReservationGbox = new System.Windows.Forms.GroupBox();
            this.RoomTitleLbl = new System.Windows.Forms.Label();
            this.DateReservedLbl = new System.Windows.Forms.Label();
            this.TimeReservedLbl = new System.Windows.Forms.Label();
            this.CapacityLbl = new System.Windows.Forms.Label();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ReservationGbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TitleLbl.Location = new System.Drawing.Point(216, 57);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(343, 32);
            this.TitleLbl.TabIndex = 1;
            this.TitleLbl.Text = "Check Your Reservation";
            // 
            // ReservationGbox
            // 
            this.ReservationGbox.Controls.Add(this.CapacityLbl);
            this.ReservationGbox.Controls.Add(this.TimeReservedLbl);
            this.ReservationGbox.Controls.Add(this.DateReservedLbl);
            this.ReservationGbox.Controls.Add(this.RoomTitleLbl);
            this.ReservationGbox.Location = new System.Drawing.Point(151, 119);
            this.ReservationGbox.Name = "ReservationGbox";
            this.ReservationGbox.Size = new System.Drawing.Size(481, 241);
            this.ReservationGbox.TabIndex = 2;
            this.ReservationGbox.TabStop = false;
            // 
            // RoomTitleLbl
            // 
            this.RoomTitleLbl.AutoSize = true;
            this.RoomTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTitleLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomTitleLbl.Location = new System.Drawing.Point(152, 35);
            this.RoomTitleLbl.Name = "RoomTitleLbl";
            this.RoomTitleLbl.Size = new System.Drawing.Size(181, 32);
            this.RoomTitleLbl.TabIndex = 3;
            this.RoomTitleLbl.Text = "Room Name";
            // 
            // DateReservedLbl
            // 
            this.DateReservedLbl.AutoSize = true;
            this.DateReservedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateReservedLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DateReservedLbl.Location = new System.Drawing.Point(116, 97);
            this.DateReservedLbl.Name = "DateReservedLbl";
            this.DateReservedLbl.Size = new System.Drawing.Size(238, 20);
            this.DateReservedLbl.TabIndex = 4;
            this.DateReservedLbl.Text = "Reserved Date: DD/MM/YY";
            // 
            // TimeReservedLbl
            // 
            this.TimeReservedLbl.AutoSize = true;
            this.TimeReservedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeReservedLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TimeReservedLbl.Location = new System.Drawing.Point(96, 137);
            this.TimeReservedLbl.Name = "TimeReservedLbl";
            this.TimeReservedLbl.Size = new System.Drawing.Size(282, 20);
            this.TimeReservedLbl.TabIndex = 5;
            this.TimeReservedLbl.Text = "Reserved Time: HH:MM-HH:MM";
            // 
            // CapacityLbl
            // 
            this.CapacityLbl.AutoSize = true;
            this.CapacityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CapacityLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.CapacityLbl.Location = new System.Drawing.Point(154, 182);
            this.CapacityLbl.Name = "CapacityLbl";
            this.CapacityLbl.Size = new System.Drawing.Size(170, 20);
            this.CapacityLbl.TabIndex = 6;
            this.CapacityLbl.Text = "Capacity: N People";
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.White;
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ConfirmBtn.Location = new System.Drawing.Point(309, 385);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(183, 39);
            this.ConfirmBtn.TabIndex = 14;
            this.ConfirmBtn.Text = "Confirm Reservation";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            // 
            // Frm09_CheckYourReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.ReservationGbox);
            this.Controls.Add(this.TitleLbl);
            this.Name = "Frm09_CheckYourReservation";
            this.Text = "Frm9_CheckYourReservation";
            this.ReservationGbox.ResumeLayout(false);
            this.ReservationGbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.GroupBox ReservationGbox;
        private System.Windows.Forms.Label RoomTitleLbl;
        private System.Windows.Forms.Label CapacityLbl;
        private System.Windows.Forms.Label TimeReservedLbl;
        private System.Windows.Forms.Label DateReservedLbl;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}