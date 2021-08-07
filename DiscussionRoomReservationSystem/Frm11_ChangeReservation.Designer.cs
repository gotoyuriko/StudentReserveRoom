
namespace DiscussionRoomReservationSystem
{
    partial class Frm11_ChangeReservation
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
            this.ReserveBtn = new System.Windows.Forms.Button();
            this.RoomLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.StartTimeLbl = new System.Windows.Forms.Label();
            this.EndTimeLbl = new System.Windows.Forms.Label();
            this.RoomTypeCmb = new System.Windows.Forms.ComboBox();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.oldStartDateTimeCmb = new System.Windows.Forms.ComboBox();
            this.OldStartTimeLbl = new System.Windows.Forms.Label();
            this.oldEndDateTimeCmb = new System.Windows.Forms.ComboBox();
            this.OldEndTimeLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReserveBtn
            // 
            this.ReserveBtn.BackColor = System.Drawing.Color.Black;
            this.ReserveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReserveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveBtn.ForeColor = System.Drawing.Color.White;
            this.ReserveBtn.Location = new System.Drawing.Point(166, 361);
            this.ReserveBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ReserveBtn.Name = "ReserveBtn";
            this.ReserveBtn.Size = new System.Drawing.Size(277, 35);
            this.ReserveBtn.TabIndex = 9;
            this.ReserveBtn.Text = "Apply Request to Admin";
            this.ReserveBtn.UseVisualStyleBackColor = false;
            this.ReserveBtn.Click += new System.EventHandler(this.ReserveBtn_Click);
            // 
            // RoomLbl
            // 
            this.RoomLbl.AutoSize = true;
            this.RoomLbl.BackColor = System.Drawing.Color.Transparent;
            this.RoomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomLbl.ForeColor = System.Drawing.Color.Black;
            this.RoomLbl.Location = new System.Drawing.Point(31, 125);
            this.RoomLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RoomLbl.Name = "RoomLbl";
            this.RoomLbl.Size = new System.Drawing.Size(103, 20);
            this.RoomLbl.TabIndex = 8;
            this.RoomLbl.Text = "Room Type";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.Black;
            this.TitleLbl.Location = new System.Drawing.Point(184, 43);
            this.TitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(333, 38);
            this.TitleLbl.TabIndex = 7;
            this.TitleLbl.Text = "Change Reservation";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartTimeLbl
            // 
            this.StartTimeLbl.AutoSize = true;
            this.StartTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.StartTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLbl.ForeColor = System.Drawing.Color.Black;
            this.StartTimeLbl.Location = new System.Drawing.Point(31, 257);
            this.StartTimeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartTimeLbl.Name = "StartTimeLbl";
            this.StartTimeLbl.Size = new System.Drawing.Size(185, 20);
            this.StartTimeLbl.TabIndex = 11;
            this.StartTimeLbl.Text = "New Start Date/Time";
            // 
            // EndTimeLbl
            // 
            this.EndTimeLbl.AutoSize = true;
            this.EndTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.EndTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeLbl.ForeColor = System.Drawing.Color.Black;
            this.EndTimeLbl.Location = new System.Drawing.Point(31, 296);
            this.EndTimeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndTimeLbl.Name = "EndTimeLbl";
            this.EndTimeLbl.Size = new System.Drawing.Size(176, 20);
            this.EndTimeLbl.TabIndex = 12;
            this.EndTimeLbl.Text = "New End Date/Time";
            // 
            // RoomTypeCmb
            // 
            this.RoomTypeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTypeCmb.FormattingEnabled = true;
            this.RoomTypeCmb.Location = new System.Drawing.Point(207, 119);
            this.RoomTypeCmb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RoomTypeCmb.Name = "RoomTypeCmb";
            this.RoomTypeCmb.Size = new System.Drawing.Size(348, 33);
            this.RoomTypeCmb.TabIndex = 14;
            this.RoomTypeCmb.SelectedIndexChanged += new System.EventHandler(this.RoomTypeCmb_SelectedIndexChanged);
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.CustomFormat = "MMMM, dd, yyyy - dddd HH:mm";
            this.StartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Location = new System.Drawing.Point(207, 248);
            this.StartDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(348, 30);
            this.StartDateTimePicker.TabIndex = 16;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.CustomFormat = "MMMM, dd, yyyy - dddd HH:mm";
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(207, 286);
            this.EndDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(348, 30);
            this.EndDateTimePicker.TabIndex = 17;
            // 
            // oldStartDateTimeCmb
            // 
            this.oldStartDateTimeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldStartDateTimeCmb.FormattingEnabled = true;
            this.oldStartDateTimeCmb.Location = new System.Drawing.Point(207, 152);
            this.oldStartDateTimeCmb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.oldStartDateTimeCmb.Name = "oldStartDateTimeCmb";
            this.oldStartDateTimeCmb.Size = new System.Drawing.Size(348, 33);
            this.oldStartDateTimeCmb.TabIndex = 19;
            this.oldStartDateTimeCmb.SelectedIndexChanged += new System.EventHandler(this.oldStartDateTimeCmb_SelectedIndexChanged);
            // 
            // OldStartTimeLbl
            // 
            this.OldStartTimeLbl.AutoSize = true;
            this.OldStartTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.OldStartTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldStartTimeLbl.ForeColor = System.Drawing.Color.Black;
            this.OldStartTimeLbl.Location = new System.Drawing.Point(31, 162);
            this.OldStartTimeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OldStartTimeLbl.Name = "OldStartTimeLbl";
            this.OldStartTimeLbl.Size = new System.Drawing.Size(212, 20);
            this.OldStartTimeLbl.TabIndex = 18;
            this.OldStartTimeLbl.Text = "Current Start Date/Time";
            // 
            // oldEndDateTimeCmb
            // 
            this.oldEndDateTimeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldEndDateTimeCmb.FormattingEnabled = true;
            this.oldEndDateTimeCmb.Location = new System.Drawing.Point(207, 183);
            this.oldEndDateTimeCmb.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.oldEndDateTimeCmb.Name = "oldEndDateTimeCmb";
            this.oldEndDateTimeCmb.Size = new System.Drawing.Size(348, 33);
            this.oldEndDateTimeCmb.TabIndex = 21;
            // 
            // OldEndTimeLbl
            // 
            this.OldEndTimeLbl.AutoSize = true;
            this.OldEndTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.OldEndTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldEndTimeLbl.ForeColor = System.Drawing.Color.Black;
            this.OldEndTimeLbl.Location = new System.Drawing.Point(31, 193);
            this.OldEndTimeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OldEndTimeLbl.Name = "OldEndTimeLbl";
            this.OldEndTimeLbl.Size = new System.Drawing.Size(203, 20);
            this.OldEndTimeLbl.TabIndex = 20;
            this.OldEndTimeLbl.Text = "Current End Date/Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Back To Your Reservation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DiscussionRoomReservationSystem.Properties.Resources.icons8_back_to_100;
            this.pictureBox1.Location = new System.Drawing.Point(70, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm11_ChangeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.bg_ioop;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.oldEndDateTimeCmb);
            this.Controls.Add(this.OldEndTimeLbl);
            this.Controls.Add(this.oldStartDateTimeCmb);
            this.Controls.Add(this.OldStartTimeLbl);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.RoomTypeCmb);
            this.Controls.Add(this.EndTimeLbl);
            this.Controls.Add(this.StartTimeLbl);
            this.Controls.Add(this.ReserveBtn);
            this.Controls.Add(this.RoomLbl);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm11_ChangeReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm11_ChangeReservation";
            this.Load += new System.EventHandler(this.Frm11_ChangeReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReserveBtn;
        private System.Windows.Forms.Label RoomLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label StartTimeLbl;
        private System.Windows.Forms.Label EndTimeLbl;
        private System.Windows.Forms.ComboBox RoomTypeCmb;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.ComboBox oldStartDateTimeCmb;
        private System.Windows.Forms.Label OldStartTimeLbl;
        private System.Windows.Forms.ComboBox oldEndDateTimeCmb;
        private System.Windows.Forms.Label OldEndTimeLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}