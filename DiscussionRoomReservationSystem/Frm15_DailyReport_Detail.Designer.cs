
namespace DiscussionRoomReservationSystem
{
    partial class Frm15_DailyReport_Detail
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
            this.dailyDataGridView = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.searchDailyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dailyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.Black;
            this.TitleLbl.Location = new System.Drawing.Point(182, 25);
            this.TitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(285, 32);
            this.TitleLbl.TabIndex = 16;
            this.TitleLbl.Text = "Daily Room Reports";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dailyDataGridView
            // 
            this.dailyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyDataGridView.Location = new System.Drawing.Point(61, 126);
            this.dailyDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dailyDataGridView.Name = "dailyDataGridView";
            this.dailyDataGridView.RowHeadersWidth = 51;
            this.dailyDataGridView.RowTemplate.Height = 24;
            this.dailyDataGridView.Size = new System.Drawing.Size(483, 250);
            this.dailyDataGridView.TabIndex = 17;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Black;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(202, 383);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(186, 39);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Search Reports";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // searchDailyDateTimePicker
            // 
            this.searchDailyDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDailyDateTimePicker.Location = new System.Drawing.Point(149, 91);
            this.searchDailyDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchDailyDateTimePicker.Name = "searchDailyDateTimePicker";
            this.searchDailyDateTimePicker.Size = new System.Drawing.Size(299, 30);
            this.searchDailyDateTimePicker.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Back To Menu";
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.MenuBtn.Image = global::DiscussionRoomReservationSystem.Properties.Resources.icons8_back_to_100;
            this.MenuBtn.Location = new System.Drawing.Point(46, 25);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(30, 34);
            this.MenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuBtn.TabIndex = 23;
            this.MenuBtn.TabStop = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(213, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Please select date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frm15_DailyReport_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.bg_ioop;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.searchDailyDateTimePicker);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dailyDataGridView);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Frm15_DailyReport_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm17_DailyReport_Detail";
            this.Load += new System.EventHandler(this.Frm17_DailyReport_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dailyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.DataGridView dailyDataGridView;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DateTimePicker searchDailyDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox MenuBtn;
        private System.Windows.Forms.Label label1;
    }
}