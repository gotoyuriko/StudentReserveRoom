
namespace DiscussionRoomReservationSystem
{
    partial class Frm09_CancelReservation
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RoomLbl = new System.Windows.Forms.Label();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.RoomTypeCmb = new System.Windows.Forms.ComboBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.DateTimeCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Black;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(293, 393);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(172, 40);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "Cancel Room";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.ReserveBtn_Click);
            // 
            // RoomLbl
            // 
            this.RoomLbl.AutoSize = true;
            this.RoomLbl.BackColor = System.Drawing.Color.Transparent;
            this.RoomLbl.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomLbl.ForeColor = System.Drawing.Color.Black;
            this.RoomLbl.Location = new System.Drawing.Point(144, 252);
            this.RoomLbl.Name = "RoomLbl";
            this.RoomLbl.Size = new System.Drawing.Size(108, 21);
            this.RoomLbl.TabIndex = 8;
            this.RoomLbl.Text = "Room Type";
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.Black;
            this.TitleLbl.Location = new System.Drawing.Point(224, 87);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(332, 39);
            this.TitleLbl.TabIndex = 7;
            this.TitleLbl.Text = "Cancel Reservation";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RoomTypeCmb
            // 
            this.RoomTypeCmb.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTypeCmb.FormattingEnabled = true;
            this.RoomTypeCmb.Location = new System.Drawing.Point(266, 247);
            this.RoomTypeCmb.Name = "RoomTypeCmb";
            this.RoomTypeCmb.Size = new System.Drawing.Size(393, 31);
            this.RoomTypeCmb.TabIndex = 14;
            this.RoomTypeCmb.SelectedIndexChanged += new System.EventHandler(this.RoomTypeCmb_SelectedIndexChanged);
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.BackColor = System.Drawing.Color.Transparent;
            this.DateLbl.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLbl.ForeColor = System.Drawing.Color.Black;
            this.DateLbl.Location = new System.Drawing.Point(144, 308);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(102, 21);
            this.DateLbl.TabIndex = 11;
            this.DateLbl.Text = "Date/Time";
            // 
            // DateTimeCmb
            // 
            this.DateTimeCmb.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeCmb.FormattingEnabled = true;
            this.DateTimeCmb.Location = new System.Drawing.Point(266, 303);
            this.DateTimeCmb.Name = "DateTimeCmb";
            this.DateTimeCmb.Size = new System.Drawing.Size(393, 31);
            this.DateTimeCmb.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(231, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Please select your resercvation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Back To Your Reservation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DiscussionRoomReservationSystem.Properties.Resources.icons8_back_to_100;
            this.pictureBox1.Location = new System.Drawing.Point(102, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm09_CancelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.bg_ioop;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimeCmb);
            this.Controls.Add(this.RoomTypeCmb);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.RoomLbl);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm09_CancelReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm7_CancelReservation";
            this.Load += new System.EventHandler(this.Frm07_CancelReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label RoomLbl;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.ComboBox RoomTypeCmb;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.ComboBox DateTimeCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}