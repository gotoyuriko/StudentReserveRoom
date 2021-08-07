
namespace DiscussionRoomReservationSystem
{
    partial class Frm14_PendingRequest
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
            this.Approve1Btn = new System.Windows.Forms.Button();
            this.Reject1Btn = new System.Windows.Forms.Button();
            this.PendingRequestDataGridView = new System.Windows.Forms.DataGridView();
            this.pendingCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuBtn = new System.Windows.Forms.PictureBox();
            this.descritionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PendingRequestDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.Black;
            this.TitleLbl.Location = new System.Drawing.Point(179, 19);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(282, 38);
            this.TitleLbl.TabIndex = 4;
            this.TitleLbl.Text = "Pending Request";
            // 
            // Approve1Btn
            // 
            this.Approve1Btn.BackColor = System.Drawing.Color.Olive;
            this.Approve1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Approve1Btn.ForeColor = System.Drawing.Color.White;
            this.Approve1Btn.Location = new System.Drawing.Point(362, 380);
            this.Approve1Btn.Name = "Approve1Btn";
            this.Approve1Btn.Size = new System.Drawing.Size(111, 43);
            this.Approve1Btn.TabIndex = 10;
            this.Approve1Btn.Text = "Approve";
            this.Approve1Btn.UseVisualStyleBackColor = false;
            this.Approve1Btn.Click += new System.EventHandler(this.Approve1Btn_Click);
            // 
            // Reject1Btn
            // 
            this.Reject1Btn.BackColor = System.Drawing.Color.Red;
            this.Reject1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reject1Btn.ForeColor = System.Drawing.Color.White;
            this.Reject1Btn.Location = new System.Drawing.Point(142, 380);
            this.Reject1Btn.Name = "Reject1Btn";
            this.Reject1Btn.Size = new System.Drawing.Size(111, 43);
            this.Reject1Btn.TabIndex = 11;
            this.Reject1Btn.Text = "Reject";
            this.Reject1Btn.UseVisualStyleBackColor = false;
            this.Reject1Btn.Click += new System.EventHandler(this.Reject1Btn_Click);
            // 
            // PendingRequestDataGridView
            // 
            this.PendingRequestDataGridView.AllowUserToAddRows = false;
            this.PendingRequestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PendingRequestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pendingCheckBox});
            this.PendingRequestDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.PendingRequestDataGridView.Location = new System.Drawing.Point(23, 94);
            this.PendingRequestDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PendingRequestDataGridView.Name = "PendingRequestDataGridView";
            this.PendingRequestDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.PendingRequestDataGridView.RowHeadersWidth = 51;
            this.PendingRequestDataGridView.RowTemplate.Height = 24;
            this.PendingRequestDataGridView.Size = new System.Drawing.Size(557, 281);
            this.PendingRequestDataGridView.TabIndex = 14;
            // 
            // pendingCheckBox
            // 
            this.pendingCheckBox.HeaderText = "";
            this.pendingCheckBox.MinimumWidth = 6;
            this.pendingCheckBox.Name = "pendingCheckBox";
            this.pendingCheckBox.Width = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Back To Menu";
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.MenuBtn.Image = global::DiscussionRoomReservationSystem.Properties.Resources.icons8_back_to_100;
            this.MenuBtn.Location = new System.Drawing.Point(46, 19);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(30, 34);
            this.MenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuBtn.TabIndex = 21;
            this.MenuBtn.TabStop = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // descritionLbl
            // 
            this.descritionLbl.AutoSize = true;
            this.descritionLbl.BackColor = System.Drawing.Color.Transparent;
            this.descritionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descritionLbl.Location = new System.Drawing.Point(202, 61);
            this.descritionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descritionLbl.Name = "descritionLbl";
            this.descritionLbl.Size = new System.Drawing.Size(227, 24);
            this.descritionLbl.TabIndex = 23;
            this.descritionLbl.Text = "Pelase select one by one.";
            // 
            // Frm14_PendingRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.bg_ioop;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.descritionLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MenuBtn);
            this.Controls.Add(this.PendingRequestDataGridView);
            this.Controls.Add(this.Reject1Btn);
            this.Controls.Add(this.Approve1Btn);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm14_PendingRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm15_PendingRequest";
            this.Load += new System.EventHandler(this.Frm14_PendingRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PendingRequestDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button Approve1Btn;
        private System.Windows.Forms.Button Reject1Btn;
        private System.Windows.Forms.DataGridView PendingRequestDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pendingCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox MenuBtn;
        private System.Windows.Forms.Label descritionLbl;
    }
}