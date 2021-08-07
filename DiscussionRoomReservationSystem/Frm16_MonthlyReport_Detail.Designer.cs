
namespace DiscussionRoomReservationSystem
{
    partial class Frm16_MonthlyReport_Detail
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
            this.selectMonthcomboBox = new System.Windows.Forms.ComboBox();
            this.monthlyDataGridView = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.Black;
            this.TitleLbl.Location = new System.Drawing.Point(167, 25);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(323, 32);
            this.TitleLbl.TabIndex = 5;
            this.TitleLbl.Text = "Monthly Room Reports";
            // 
            // selectMonthcomboBox
            // 
            this.selectMonthcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMonthcomboBox.ForeColor = System.Drawing.Color.Black;
            this.selectMonthcomboBox.FormattingEnabled = true;
            this.selectMonthcomboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.selectMonthcomboBox.Location = new System.Drawing.Point(223, 84);
            this.selectMonthcomboBox.Name = "selectMonthcomboBox";
            this.selectMonthcomboBox.Size = new System.Drawing.Size(139, 33);
            this.selectMonthcomboBox.TabIndex = 7;
            this.selectMonthcomboBox.Text = "January";
          
            // 
            // monthlyDataGridView
            // 
            this.monthlyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthlyDataGridView.Location = new System.Drawing.Point(50, 116);
            this.monthlyDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.monthlyDataGridView.Name = "monthlyDataGridView";
            this.monthlyDataGridView.RowHeadersWidth = 51;
            this.monthlyDataGridView.RowTemplate.Height = 24;
            this.monthlyDataGridView.Size = new System.Drawing.Size(483, 250);
            this.monthlyDataGridView.TabIndex = 8;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Black;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(215, 380);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(153, 39);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "Search Month";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Back To Menu";
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.MenuBtn.Image = global::DiscussionRoomReservationSystem.Properties.Resources.icons8_back_to_100;
            this.MenuBtn.Location = new System.Drawing.Point(41, 20);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(30, 34);
            this.MenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuBtn.TabIndex = 25;
            this.MenuBtn.TabStop = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(210, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Please select month.";
            // 
            // Frm16_MonthlyReport_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.bg_ioop;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.monthlyDataGridView);
            this.Controls.Add(this.selectMonthcomboBox);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm16_MonthlyReport_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frrm19_MonthlyReport_Detail";
            this.Load += new System.EventHandler(this.Frrm19_MonthlyReport_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.ComboBox selectMonthcomboBox;
        private System.Windows.Forms.DataGridView monthlyDataGridView;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox MenuBtn;
        private System.Windows.Forms.Label label1;
    }
}