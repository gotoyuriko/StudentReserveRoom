
namespace DiscussionRoomReservationSystem
{
    partial class Frm17_DailyReport_Detail
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
            this.ChangeCBox = new System.Windows.Forms.ComboBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Username1Lbl = new System.Windows.Forms.Label();
            this.RoomEnd1Lbl = new System.Windows.Forms.Label();
            this.RoomStart1Lbl = new System.Windows.Forms.Label();
            this.RoomNum1Lbl = new System.Windows.Forms.Label();
            this.ReservedLbl = new System.Windows.Forms.Label();
            this.EndTimeLbl = new System.Windows.Forms.Label();
            this.StartTimeLbl = new System.Windows.Forms.Label();
            this.RoomNumberLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeCBox
            // 
            this.ChangeCBox.FormattingEnabled = true;
            this.ChangeCBox.Items.AddRange(new object[] {
            "Amber",
            "Cedar",
            "Black Thron",
            "Daphne"});
            this.ChangeCBox.Location = new System.Drawing.Point(569, 52);
            this.ChangeCBox.Name = "ChangeCBox";
            this.ChangeCBox.Size = new System.Drawing.Size(132, 23);
            this.ChangeCBox.TabIndex = 15;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TitleLbl.Location = new System.Drawing.Point(126, 49);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(408, 32);
            this.TitleLbl.TabIndex = 16;
            this.TitleLbl.Text = "*ROOM* Daily Room Reports";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitleLbl.Click += new System.EventHandler(this.TitleLbl_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.31677F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.68323F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.Controls.Add(this.Username1Lbl, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.RoomEnd1Lbl, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.RoomStart1Lbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RoomNum1Lbl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReservedLbl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.EndTimeLbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartTimeLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RoomNumberLbl, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(92, 153);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.83721F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.16279F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 206);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // Username1Lbl
            // 
            this.Username1Lbl.AutoSize = true;
            this.Username1Lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Username1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username1Lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Username1Lbl.Location = new System.Drawing.Point(455, 40);
            this.Username1Lbl.Name = "Username1Lbl";
            this.Username1Lbl.Size = new System.Drawing.Size(201, 41);
            this.Username1Lbl.TabIndex = 7;
            this.Username1Lbl.Text = "Username";
            this.Username1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomEnd1Lbl
            // 
            this.RoomEnd1Lbl.AutoSize = true;
            this.RoomEnd1Lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomEnd1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomEnd1Lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomEnd1Lbl.Location = new System.Drawing.Point(323, 40);
            this.RoomEnd1Lbl.Name = "RoomEnd1Lbl";
            this.RoomEnd1Lbl.Size = new System.Drawing.Size(126, 41);
            this.RoomEnd1Lbl.TabIndex = 6;
            this.RoomEnd1Lbl.Text = "HH:MM";
            this.RoomEnd1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomStart1Lbl
            // 
            this.RoomStart1Lbl.AutoSize = true;
            this.RoomStart1Lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomStart1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomStart1Lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomStart1Lbl.Location = new System.Drawing.Point(193, 40);
            this.RoomStart1Lbl.Name = "RoomStart1Lbl";
            this.RoomStart1Lbl.Size = new System.Drawing.Size(124, 41);
            this.RoomStart1Lbl.TabIndex = 5;
            this.RoomStart1Lbl.Text = "HH:MM";
            this.RoomStart1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomNum1Lbl
            // 
            this.RoomNum1Lbl.AutoSize = true;
            this.RoomNum1Lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomNum1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNum1Lbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomNum1Lbl.Location = new System.Drawing.Point(3, 40);
            this.RoomNum1Lbl.Name = "RoomNum1Lbl";
            this.RoomNum1Lbl.Size = new System.Drawing.Size(184, 41);
            this.RoomNum1Lbl.TabIndex = 4;
            this.RoomNum1Lbl.Text = "Room#1";
            this.RoomNum1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReservedLbl
            // 
            this.ReservedLbl.AutoSize = true;
            this.ReservedLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReservedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservedLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ReservedLbl.Location = new System.Drawing.Point(455, 0);
            this.ReservedLbl.Name = "ReservedLbl";
            this.ReservedLbl.Size = new System.Drawing.Size(201, 40);
            this.ReservedLbl.TabIndex = 3;
            this.ReservedLbl.Text = "Reserved by:";
            this.ReservedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndTimeLbl
            // 
            this.EndTimeLbl.AutoSize = true;
            this.EndTimeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.EndTimeLbl.Location = new System.Drawing.Point(323, 0);
            this.EndTimeLbl.Name = "EndTimeLbl";
            this.EndTimeLbl.Size = new System.Drawing.Size(126, 40);
            this.EndTimeLbl.TabIndex = 2;
            this.EndTimeLbl.Text = "End Time";
            this.EndTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartTimeLbl
            // 
            this.StartTimeLbl.AutoSize = true;
            this.StartTimeLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.StartTimeLbl.Location = new System.Drawing.Point(193, 0);
            this.StartTimeLbl.Name = "StartTimeLbl";
            this.StartTimeLbl.Size = new System.Drawing.Size(124, 40);
            this.StartTimeLbl.TabIndex = 1;
            this.StartTimeLbl.Text = "Start Time";
            this.StartTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomNumberLbl
            // 
            this.RoomNumberLbl.AutoSize = true;
            this.RoomNumberLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumberLbl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.RoomNumberLbl.Location = new System.Drawing.Point(3, 0);
            this.RoomNumberLbl.Name = "RoomNumberLbl";
            this.RoomNumberLbl.Size = new System.Drawing.Size(184, 40);
            this.RoomNumberLbl.TabIndex = 0;
            this.RoomNumberLbl.Text = "Room Number";
            this.RoomNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm17_DailyReport_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.ChangeCBox);
            this.Name = "Frm17_DailyReport_Detail";
            this.Text = "Frm17_DailyReport_Detail";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChangeCBox;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label EndTimeLbl;
        private System.Windows.Forms.Label StartTimeLbl;
        private System.Windows.Forms.Label RoomNumberLbl;
        private System.Windows.Forms.Label Username1Lbl;
        private System.Windows.Forms.Label RoomEnd1Lbl;
        private System.Windows.Forms.Label RoomStart1Lbl;
        private System.Windows.Forms.Label RoomNum1Lbl;
        private System.Windows.Forms.Label ReservedLbl;
    }
}