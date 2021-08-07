
namespace DiscussionRoomReservationSystem
{
    partial class Frm04_StudentMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm04_StudentMain));
            this.RoomRBtn = new System.Windows.Forms.Button();
            this.YourRBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.roomCheckDataGridView = new System.Windows.Forms.DataGridView();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainMenuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userDatabaseDataSet2 = new DiscussionRoomReservationSystem.UserDatabaseDataSet2();
            this.mainMenuDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuDatabase = new DiscussionRoomReservationSystem.MainMenuDatabase();
            this.checkRoomComboBox = new System.Windows.Forms.ComboBox();
            this.CheckRButton = new System.Windows.Forms.Button();
            this.userDatabaseDataSet1 = new DiscussionRoomReservationSystem.UserDatabaseDataSet1();
            this.mainMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainMenuTableAdapter = new DiscussionRoomReservationSystem.UserDatabaseDataSet1TableAdapters.MainMenuTableAdapter();
            this.mainMenuTableAdapter1 = new DiscussionRoomReservationSystem.UserDatabaseDataSet2TableAdapters.MainMenuTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCheckDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuDatabaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomRBtn
            // 
            this.RoomRBtn.BackColor = System.Drawing.Color.Black;
            this.RoomRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomRBtn.ForeColor = System.Drawing.Color.White;
            this.RoomRBtn.Location = new System.Drawing.Point(118, 444);
            this.RoomRBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoomRBtn.Name = "RoomRBtn";
            this.RoomRBtn.Size = new System.Drawing.Size(176, 41);
            this.RoomRBtn.TabIndex = 3;
            this.RoomRBtn.Text = "Room Reservation";
            this.RoomRBtn.UseVisualStyleBackColor = false;
            this.RoomRBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // YourRBtn
            // 
            this.YourRBtn.BackColor = System.Drawing.Color.Black;
            this.YourRBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourRBtn.ForeColor = System.Drawing.Color.White;
            this.YourRBtn.Location = new System.Drawing.Point(494, 444);
            this.YourRBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.YourRBtn.Name = "YourRBtn";
            this.YourRBtn.Size = new System.Drawing.Size(176, 41);
            this.YourRBtn.TabIndex = 6;
            this.YourRBtn.Text = "Your Reservation";
            this.YourRBtn.UseVisualStyleBackColor = false;
            this.YourRBtn.Click += new System.EventHandler(this.YourRBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(737, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.welcomeLabel.Location = new System.Drawing.Point(209, 24);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(170, 38);
            this.welcomeLabel.TabIndex = 23;
            this.welcomeLabel.Text = "Welcome,";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomCheckDataGridView
            // 
            this.roomCheckDataGridView.AutoGenerateColumns = false;
            this.roomCheckDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.roomCheckDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomCheckDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNameDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.roomCheckDataGridView.DataSource = this.mainMenuBindingSource1;
            this.roomCheckDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.roomCheckDataGridView.Location = new System.Drawing.Point(118, 122);
            this.roomCheckDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.roomCheckDataGridView.Name = "roomCheckDataGridView";
            this.roomCheckDataGridView.ReadOnly = true;
            this.roomCheckDataGridView.RowHeadersWidth = 51;
            this.roomCheckDataGridView.Size = new System.Drawing.Size(552, 314);
            this.roomCheckDataGridView.TabIndex = 24;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "roomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "roomName";
            this.roomNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            this.roomNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "startTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "startTime";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "endTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "endTime";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // mainMenuBindingSource1
            // 
            this.mainMenuBindingSource1.DataMember = "MainMenu";
            this.mainMenuBindingSource1.DataSource = this.userDatabaseDataSet2;
            // 
            // userDatabaseDataSet2
            // 
            this.userDatabaseDataSet2.DataSetName = "UserDatabaseDataSet2";
            this.userDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainMenuDatabaseBindingSource
            // 
            this.mainMenuDatabaseBindingSource.DataSource = this.mainMenuDatabase;
            this.mainMenuDatabaseBindingSource.Position = 0;
            // 
            // mainMenuDatabase
            // 
            this.mainMenuDatabase.DataSetName = "MainMenuDatabase";
            this.mainMenuDatabase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkRoomComboBox
            // 
            this.checkRoomComboBox.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRoomComboBox.FormattingEnabled = true;
            this.checkRoomComboBox.Items.AddRange(new object[] {
            "Amber1",
            "Amber2",
            "Amber3",
            "Amber4",
            "Amber5",
            "BlackThorn1",
            "BlacktThorn2",
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
            this.checkRoomComboBox.Location = new System.Drawing.Point(216, 81);
            this.checkRoomComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.checkRoomComboBox.Name = "checkRoomComboBox";
            this.checkRoomComboBox.Size = new System.Drawing.Size(176, 31);
            this.checkRoomComboBox.TabIndex = 25;
            this.checkRoomComboBox.Text = "Select a Room";
            // 
            // CheckRButton
            // 
            this.CheckRButton.BackColor = System.Drawing.Color.White;
            this.CheckRButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheckRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckRButton.ForeColor = System.Drawing.Color.Black;
            this.CheckRButton.Location = new System.Drawing.Point(399, 73);
            this.CheckRButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckRButton.Name = "CheckRButton";
            this.CheckRButton.Size = new System.Drawing.Size(176, 41);
            this.CheckRButton.TabIndex = 26;
            this.CheckRButton.Text = "Check";
            this.CheckRButton.UseVisualStyleBackColor = false;
            this.CheckRButton.Click += new System.EventHandler(this.CheckRButton_Click);
            // 
            // userDatabaseDataSet1
            // 
            this.userDatabaseDataSet1.DataSetName = "UserDatabaseDataSet1";
            this.userDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainMenuBindingSource
            // 
            this.mainMenuBindingSource.DataMember = "MainMenu";
            this.mainMenuBindingSource.DataSource = this.userDatabaseDataSet1;
            // 
            // mainMenuTableAdapter
            // 
            this.mainMenuTableAdapter.ClearBeforeFill = true;
            // 
            // mainMenuTableAdapter1
            // 
            this.mainMenuTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DiscussionRoomReservationSystem.Properties.Resources.undraw_Crypto_flowers_bjmo_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(21, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // Frm04_StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.bg_ioop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.CheckRButton);
            this.Controls.Add(this.checkRoomComboBox);
            this.Controls.Add(this.roomCheckDataGridView);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.YourRBtn);
            this.Controls.Add(this.RoomRBtn);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm04_StudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm04_StudentMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomCheckDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuDatabaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RoomRBtn;
        private System.Windows.Forms.Button YourRBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.DataGridView roomCheckDataGridView;
        private System.Windows.Forms.BindingSource mainMenuDatabaseBindingSource;
        private MainMenuDatabase mainMenuDatabase;
        private System.Windows.Forms.ComboBox checkRoomComboBox;
        private System.Windows.Forms.Button CheckRButton;
        private UserDatabaseDataSet1 userDatabaseDataSet1;
        private System.Windows.Forms.BindingSource mainMenuBindingSource;
        private UserDatabaseDataSet1TableAdapters.MainMenuTableAdapter mainMenuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private UserDatabaseDataSet2 userDatabaseDataSet2;
        private System.Windows.Forms.BindingSource mainMenuBindingSource1;
        private UserDatabaseDataSet2TableAdapters.MainMenuTableAdapter mainMenuTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}