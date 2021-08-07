
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
            this.StartDateTimeLbl = new System.Windows.Forms.Label();
            this.EndDateTimeLbl = new System.Windows.Forms.Label();
            this.RoomTypeCmb = new System.Windows.Forms.ComboBox();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InstructionLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReserveBtn
            // 
            this.ReserveBtn.BackColor = System.Drawing.Color.Black;
            this.ReserveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReserveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveBtn.ForeColor = System.Drawing.Color.White;
            this.ReserveBtn.Location = new System.Drawing.Point(328, 425);
            this.ReserveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReserveBtn.Name = "ReserveBtn";
            this.ReserveBtn.Size = new System.Drawing.Size(132, 43);
            this.ReserveBtn.TabIndex = 9;
            this.ReserveBtn.Text = "Reserve";
            this.ReserveBtn.UseVisualStyleBackColor = false;
            this.ReserveBtn.Click += new System.EventHandler(this.ReserveBtn_Click);
            // 
            // RoomLbl
            // 
            this.RoomLbl.AutoSize = true;
            this.RoomLbl.BackColor = System.Drawing.Color.Transparent;
            this.RoomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomLbl.ForeColor = System.Drawing.Color.Black;
            this.RoomLbl.Location = new System.Drawing.Point(64, 240);
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
            this.TitleLbl.Location = new System.Drawing.Point(233, 76);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(332, 38);
            this.TitleLbl.TabIndex = 7;
            this.TitleLbl.Text = "Student Reservation";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StartDateTimeLbl
            // 
            this.StartDateTimeLbl.AutoSize = true;
            this.StartDateTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.StartDateTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateTimeLbl.ForeColor = System.Drawing.Color.Black;
            this.StartDateTimeLbl.Location = new System.Drawing.Point(64, 284);
            this.StartDateTimeLbl.Name = "StartDateTimeLbl";
            this.StartDateTimeLbl.Size = new System.Drawing.Size(143, 20);
            this.StartDateTimeLbl.TabIndex = 11;
            this.StartDateTimeLbl.Text = "Start Date/Time";
            // 
            // EndDateTimeLbl
            // 
            this.EndDateTimeLbl.AutoSize = true;
            this.EndDateTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.EndDateTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateTimeLbl.ForeColor = System.Drawing.Color.Black;
            this.EndDateTimeLbl.Location = new System.Drawing.Point(64, 331);
            this.EndDateTimeLbl.Name = "EndDateTimeLbl";
            this.EndDateTimeLbl.Size = new System.Drawing.Size(134, 20);
            this.EndDateTimeLbl.TabIndex = 12;
            this.EndDateTimeLbl.Text = "End Date/Time";
            // 
            // RoomTypeCmb
            // 
            this.RoomTypeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTypeCmb.FormattingEnabled = true;
            this.RoomTypeCmb.Items.AddRange(new object[] {
            "Amber1",
            "Amber2",
            "Amber3",
            "Amber4",
            "Amber5",
            "BlackThorn1",
            "BlackThorn2",
            "BlackThorn3",
            "BlackThorn4",
            "Cedar1",
            "Cedar2",
            "Cedar3",
            "Cedar4",
            "Cedar5",
            "Cedar6",
            "Daphne1",
            "Daphne2",
            "Daphne3",
            "Daphne4",
            "Daphne5"});
            this.RoomTypeCmb.Location = new System.Drawing.Point(227, 235);
            this.RoomTypeCmb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoomTypeCmb.Name = "RoomTypeCmb";
            this.RoomTypeCmb.Size = new System.Drawing.Size(469, 33);
            this.RoomTypeCmb.TabIndex = 14;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.CustomFormat = "MMMM, dd, yyyy - dddd HH:mm";
            this.StartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDateTimePicker.Location = new System.Drawing.Point(227, 276);
            this.StartDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(469, 30);
            this.StartDateTimePicker.TabIndex = 16;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.CustomFormat = "MMMM, dd, yyyy - dddd HH:mm";
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDateTimePicker.Location = new System.Drawing.Point(227, 321);
            this.EndDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(469, 30);
            this.EndDateTimePicker.TabIndex = 17;
            // 
            // InstructionLbl
            // 
            this.InstructionLbl.AutoSize = true;
            this.InstructionLbl.BackColor = System.Drawing.Color.Transparent;
            this.InstructionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLbl.ForeColor = System.Drawing.Color.Black;
            this.InstructionLbl.Location = new System.Drawing.Point(204, 150);
            this.InstructionLbl.Name = "InstructionLbl";
            this.InstructionLbl.Size = new System.Drawing.Size(404, 29);
            this.InstructionLbl.TabIndex = 18;
            this.InstructionLbl.Text = "Please Enter the following below.";
            this.InstructionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DiscussionRoomReservationSystem.Properties.Resources.icons8_back_to_100;
            this.pictureBox1.Location = new System.Drawing.Point(57, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Back To Menu";
            // 
            // Frm05_StudentReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.bg_ioop;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InstructionLbl);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.RoomTypeCmb);
            this.Controls.Add(this.EndDateTimeLbl);
            this.Controls.Add(this.StartDateTimeLbl);
            this.Controls.Add(this.ReserveBtn);
            this.Controls.Add(this.RoomLbl);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm05_StudentReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm5_StudentReservation";
            this.Load += new System.EventHandler(this.Frm05_StudentReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReserveBtn;
        private System.Windows.Forms.Label RoomLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label StartDateTimeLbl;
        private System.Windows.Forms.Label EndDateTimeLbl;
        private System.Windows.Forms.ComboBox RoomTypeCmb;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label InstructionLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}