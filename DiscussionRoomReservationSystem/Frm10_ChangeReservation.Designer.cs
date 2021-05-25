
namespace DiscussionRoomReservationSystem
{
    partial class Frm10_ChangeReservation
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
            this.RoomTypeLbl = new System.Windows.Forms.Label();
            this.StudentsLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.StartTimeLbl = new System.Windows.Forms.Label();
            this.EndTimeLbl = new System.Windows.Forms.Label();
            this.StudentsNum = new System.Windows.Forms.NumericUpDown();
            this.RoomTypeCBox = new System.Windows.Forms.ComboBox();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DateSelectPicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeselectPicker = new System.Windows.Forms.ComboBox();
            this.EndTimeSelectPicker = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsNum)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabl
            // 
            this.TitleLabl.AutoSize = true;
            this.TitleLabl.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TitleLabl.Location = new System.Drawing.Point(255, 54);
            this.TitleLabl.Name = "TitleLabl";
            this.TitleLabl.Size = new System.Drawing.Size(265, 28);
            this.TitleLabl.TabIndex = 2;
            this.TitleLabl.Text = "Change Reservation";
            this.TitleLabl.Click += new System.EventHandler(this.TitleLabl_Click);
            // 
            // RoomTypeLbl
            // 
            this.RoomTypeLbl.AutoSize = true;
            this.RoomTypeLbl.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RoomTypeLbl.Location = new System.Drawing.Point(143, 137);
            this.RoomTypeLbl.Name = "RoomTypeLbl";
            this.RoomTypeLbl.Size = new System.Drawing.Size(82, 14);
            this.RoomTypeLbl.TabIndex = 4;
            this.RoomTypeLbl.Text = "Room Type";
            // 
            // StudentsLbl
            // 
            this.StudentsLbl.AutoSize = true;
            this.StudentsLbl.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StudentsLbl.Location = new System.Drawing.Point(158, 161);
            this.StudentsLbl.Name = "StudentsLbl";
            this.StudentsLbl.Size = new System.Drawing.Size(67, 14);
            this.StudentsLbl.TabIndex = 5;
            this.StudentsLbl.Text = "Students";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DateLbl.Location = new System.Drawing.Point(186, 197);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(39, 14);
            this.DateLbl.TabIndex = 6;
            this.DateLbl.Text = "Date";
            this.DateLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // StartTimeLbl
            // 
            this.StartTimeLbl.AutoSize = true;
            this.StartTimeLbl.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartTimeLbl.Location = new System.Drawing.Point(146, 218);
            this.StartTimeLbl.Name = "StartTimeLbl";
            this.StartTimeLbl.Size = new System.Drawing.Size(79, 14);
            this.StartTimeLbl.TabIndex = 7;
            this.StartTimeLbl.Text = "Start Time";
            this.StartTimeLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // EndTimeLbl
            // 
            this.EndTimeLbl.AutoSize = true;
            this.EndTimeLbl.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndTimeLbl.Location = new System.Drawing.Point(156, 252);
            this.EndTimeLbl.Name = "EndTimeLbl";
            this.EndTimeLbl.Size = new System.Drawing.Size(69, 14);
            this.EndTimeLbl.TabIndex = 8;
            this.EndTimeLbl.Text = "End Time";
            this.EndTimeLbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // StudentsNum
            // 
            this.StudentsNum.Location = new System.Drawing.Point(241, 161);
            this.StudentsNum.Name = "StudentsNum";
            this.StudentsNum.Size = new System.Drawing.Size(326, 22);
            this.StudentsNum.TabIndex = 9;
            // 
            // RoomTypeCBox
            // 
            this.RoomTypeCBox.FormattingEnabled = true;
            this.RoomTypeCBox.Items.AddRange(new object[] {
            "Amber",
            "Cedar",
            "Black Throne",
            "Daphne"});
            this.RoomTypeCBox.Location = new System.Drawing.Point(241, 132);
            this.RoomTypeCBox.Name = "RoomTypeCBox";
            this.RoomTypeCBox.Size = new System.Drawing.Size(327, 23);
            this.RoomTypeCBox.TabIndex = 10;
            // 
            // RequestBtn
            // 
            this.RequestBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RequestBtn.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.RequestBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RequestBtn.Location = new System.Drawing.Point(308, 342);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(177, 42);
            this.RequestBtn.TabIndex = 14;
            this.RequestBtn.Text = "Request to Librarian";
            this.RequestBtn.UseVisualStyleBackColor = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackBtn.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BackBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BackBtn.Location = new System.Drawing.Point(92, 342);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(91, 42);
            this.BackBtn.TabIndex = 15;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            // 
            // DateSelectPicker
            // 
            this.DateSelectPicker.Location = new System.Drawing.Point(240, 189);
            this.DateSelectPicker.Name = "DateSelectPicker";
            this.DateSelectPicker.Size = new System.Drawing.Size(327, 22);
            this.DateSelectPicker.TabIndex = 16;
            // 
            // startTimeselectPicker
            // 
            this.startTimeselectPicker.FormattingEnabled = true;
            this.startTimeselectPicker.Items.AddRange(new object[] {
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM"});
            this.startTimeselectPicker.Location = new System.Drawing.Point(240, 217);
            this.startTimeselectPicker.Name = "startTimeselectPicker";
            this.startTimeselectPicker.Size = new System.Drawing.Size(327, 23);
            this.startTimeselectPicker.TabIndex = 17;
            // 
            // EndTimeSelectPicker
            // 
            this.EndTimeSelectPicker.FormattingEnabled = true;
            this.EndTimeSelectPicker.Items.AddRange(new object[] {
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            "12:30 PM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM",
            "5:00 PM"});
            this.EndTimeSelectPicker.Location = new System.Drawing.Point(240, 247);
            this.EndTimeSelectPicker.Name = "EndTimeSelectPicker";
            this.EndTimeSelectPicker.Size = new System.Drawing.Size(327, 23);
            this.EndTimeSelectPicker.TabIndex = 18;
            // 
            // Frm10_ChangeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndTimeSelectPicker);
            this.Controls.Add(this.startTimeselectPicker);
            this.Controls.Add(this.DateSelectPicker);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.RequestBtn);
            this.Controls.Add(this.RoomTypeCBox);
            this.Controls.Add(this.StudentsNum);
            this.Controls.Add(this.EndTimeLbl);
            this.Controls.Add(this.StartTimeLbl);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.StudentsLbl);
            this.Controls.Add(this.RoomTypeLbl);
            this.Controls.Add(this.TitleLabl);
            this.Name = "Frm10_ChangeReservation";
            this.Text = "Change Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabl;
        private System.Windows.Forms.Label RoomTypeLbl;
        private System.Windows.Forms.Label StudentsLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label StartTimeLbl;
        private System.Windows.Forms.Label EndTimeLbl;
        private System.Windows.Forms.NumericUpDown StudentsNum;
        private System.Windows.Forms.ComboBox RoomTypeCBox;
        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DateTimePicker DateSelectPicker;
        private System.Windows.Forms.ComboBox startTimeselectPicker;
        private System.Windows.Forms.ComboBox EndTimeSelectPicker;
    }
}