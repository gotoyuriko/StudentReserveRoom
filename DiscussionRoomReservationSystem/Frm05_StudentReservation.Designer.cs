
namespace DiscussionRoomReservationSystem
{
    partial class Frm05_StudentReservation
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
            this.StudentNumLbl = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.StartTimeLbl = new System.Windows.Forms.Label();
            this.EndTimeLbl = new System.Windows.Forms.Label();
            this.RoomTypeCmb = new System.Windows.Forms.ComboBox();
            this.StudentsCountNum = new System.Windows.Forms.NumericUpDown();
            this.DateSelectPicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimeSelectPicker = new System.Windows.Forms.DateTimePicker();
            this.EndTimeSelectPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsCountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ReserveBtn
            // 
            this.ReserveBtn.BackColor = System.Drawing.Color.White;
            this.ReserveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ReserveBtn.Location = new System.Drawing.Point(321, 349);
            this.ReserveBtn.Name = "ReserveBtn";
            this.ReserveBtn.Size = new System.Drawing.Size(132, 43);
            this.ReserveBtn.TabIndex = 9;
            this.ReserveBtn.Text = "Log In";
            this.ReserveBtn.UseVisualStyleBackColor = false;
            // 
            // RoomLbl
            // 
            this.RoomLbl.AutoSize = true;
            this.RoomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomLbl.Location = new System.Drawing.Point(155, 127);
            this.RoomLbl.Name = "RoomLbl";
            this.RoomLbl.Size = new System.Drawing.Size(90, 17);
            this.RoomLbl.TabIndex = 8;
            this.RoomLbl.Text = "Room Type";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TitleLbl.Location = new System.Drawing.Point(246, 57);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(292, 32);
            this.TitleLbl.TabIndex = 7;
            this.TitleLbl.Text = "Student Reservation";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StudentNumLbl
            // 
            this.StudentNumLbl.AutoSize = true;
            this.StudentNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentNumLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StudentNumLbl.Location = new System.Drawing.Point(155, 169);
            this.StudentNumLbl.Name = "StudentNumLbl";
            this.StudentNumLbl.Size = new System.Drawing.Size(133, 17);
            this.StudentNumLbl.TabIndex = 10;
            this.StudentNumLbl.Text = "Student Numbers";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DateLbl.Location = new System.Drawing.Point(155, 210);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(42, 17);
            this.DateLbl.TabIndex = 11;
            this.DateLbl.Text = "Date";
            // 
            // StartTimeLbl
            // 
            this.StartTimeLbl.AutoSize = true;
            this.StartTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StartTimeLbl.Location = new System.Drawing.Point(155, 253);
            this.StartTimeLbl.Name = "StartTimeLbl";
            this.StartTimeLbl.Size = new System.Drawing.Size(83, 17);
            this.StartTimeLbl.TabIndex = 12;
            this.StartTimeLbl.Text = "Start Time";
            // 
            // EndTimeLbl
            // 
            this.EndTimeLbl.AutoSize = true;
            this.EndTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EndTimeLbl.Location = new System.Drawing.Point(155, 290);
            this.EndTimeLbl.Name = "EndTimeLbl";
            this.EndTimeLbl.Size = new System.Drawing.Size(76, 17);
            this.EndTimeLbl.TabIndex = 13;
            this.EndTimeLbl.Text = "End Time";
            // 
            // RoomTypeCmb
            // 
            this.RoomTypeCmb.FormattingEnabled = true;
            this.RoomTypeCmb.Location = new System.Drawing.Point(321, 124);
            this.RoomTypeCmb.Name = "RoomTypeCmb";
            this.RoomTypeCmb.Size = new System.Drawing.Size(283, 24);
            this.RoomTypeCmb.TabIndex = 14;
            // 
            // StudentsCountNum
            // 
            this.StudentsCountNum.Location = new System.Drawing.Point(321, 168);
            this.StudentsCountNum.Name = "StudentsCountNum";
            this.StudentsCountNum.Size = new System.Drawing.Size(71, 22);
            this.StudentsCountNum.TabIndex = 15;
            // 
            // DateSelectPicker
            // 
            this.DateSelectPicker.Location = new System.Drawing.Point(321, 210);
            this.DateSelectPicker.Name = "DateSelectPicker";
            this.DateSelectPicker.Size = new System.Drawing.Size(283, 22);
            this.DateSelectPicker.TabIndex = 16;
            // 
            // StartTimeSelectPicker
            // 
            this.StartTimeSelectPicker.Location = new System.Drawing.Point(321, 251);
            this.StartTimeSelectPicker.Name = "StartTimeSelectPicker";
            this.StartTimeSelectPicker.Size = new System.Drawing.Size(283, 22);
            this.StartTimeSelectPicker.TabIndex = 17;
            // 
            // EndTimeSelectPicker
            // 
            this.EndTimeSelectPicker.Location = new System.Drawing.Point(321, 289);
            this.EndTimeSelectPicker.Name = "EndTimeSelectPicker";
            this.EndTimeSelectPicker.Size = new System.Drawing.Size(283, 22);
            this.EndTimeSelectPicker.TabIndex = 18;
            // 
            // Frm05_StudentReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndTimeSelectPicker);
            this.Controls.Add(this.StartTimeSelectPicker);
            this.Controls.Add(this.DateSelectPicker);
            this.Controls.Add(this.StudentsCountNum);
            this.Controls.Add(this.RoomTypeCmb);
            this.Controls.Add(this.EndTimeLbl);
            this.Controls.Add(this.StartTimeLbl);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.StudentNumLbl);
            this.Controls.Add(this.ReserveBtn);
            this.Controls.Add(this.RoomLbl);
            this.Controls.Add(this.TitleLbl);
            this.Name = "Frm05_StudentReservation";
            this.Text = "Frm5_StudentReservation";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsCountNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReserveBtn;
        private System.Windows.Forms.Label RoomLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label StudentNumLbl;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label StartTimeLbl;
        private System.Windows.Forms.Label EndTimeLbl;
        private System.Windows.Forms.ComboBox RoomTypeCmb;
        private System.Windows.Forms.NumericUpDown StudentsCountNum;
        private System.Windows.Forms.DateTimePicker DateSelectPicker;
        private System.Windows.Forms.DateTimePicker StartTimeSelectPicker;
        private System.Windows.Forms.DateTimePicker EndTimeSelectPicker;
    }
}