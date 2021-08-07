
namespace DiscussionRoomReservationSystem
{
    partial class Frm08_YourReservation
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.userOrdersViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userDatabaseDataSet = new DiscussionRoomReservationSystem.UserDatabaseDataSet();
            this.userOrdersViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userOrdersView = new DiscussionRoomReservationSystem.UserOrdersView();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.userReservedRoom = new DiscussionRoomReservationSystem.UserReservedRoom();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new DiscussionRoomReservationSystem.UserReservedRoomTableAdapters.OrdersTableAdapter();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userOrdersViewTableAdapter = new DiscussionRoomReservationSystem.UserOrdersViewTableAdapters.UserOrdersViewTableAdapter();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.userOrdersViewTableAdapter1 = new DiscussionRoomReservationSystem.UserDatabaseDataSetTableAdapters.UserOrdersViewTableAdapter();
            this.UserPendingOrdersGridview = new System.Windows.Forms.DataGridView();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userOrdersViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userOrdersViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userOrdersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userReservedRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPendingOrdersGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Black;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(51, 425);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(219, 49);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Cancel Reservation";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.Black;
            this.TitleLbl.Location = new System.Drawing.Point(183, 54);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(451, 39);
            this.TitleLbl.TabIndex = 10;
            this.TitleLbl.Text = "YOUR RESERVED ROOM";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userOrdersViewBindingSource1
            // 
            this.userOrdersViewBindingSource1.DataMember = "UserOrdersView";
            this.userOrdersViewBindingSource1.DataSource = this.userDatabaseDataSet;
            // 
            // userDatabaseDataSet
            // 
            this.userDatabaseDataSet.DataSetName = "UserDatabaseDataSet";
            this.userDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userOrdersViewBindingSource
            // 
            this.userOrdersViewBindingSource.DataMember = "UserOrdersView";
            this.userOrdersViewBindingSource.DataSource = this.userOrdersView;
            // 
            // userOrdersView
            // 
            this.userOrdersView.DataSetName = "UserOrdersView";
            this.userOrdersView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.BackColor = System.Drawing.Color.Black;
            this.ChangeBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeBtn.ForeColor = System.Drawing.Color.White;
            this.ChangeBtn.Location = new System.Drawing.Point(508, 427);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(259, 49);
            this.ChangeBtn.TabIndex = 13;
            this.ChangeBtn.Text = "Change Reservation";
            this.ChangeBtn.UseVisualStyleBackColor = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // userReservedRoom
            // 
            this.userReservedRoom.DataSetName = "UserReservedRoom";
            this.userReservedRoom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.userReservedRoom;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.userReservedRoom;
            // 
            // userOrdersViewTableAdapter
            // 
            this.userOrdersViewTableAdapter.ClearBeforeFill = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.White;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.ForeColor = System.Drawing.Color.Black;
            this.refreshBtn.Location = new System.Drawing.Point(317, 427);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(167, 49);
            this.refreshBtn.TabIndex = 14;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // userOrdersViewTableAdapter1
            // 
            this.userOrdersViewTableAdapter1.ClearBeforeFill = true;
            // 
            // UserPendingOrdersGridview
            // 
            this.UserPendingOrdersGridview.AutoGenerateColumns = false;
            this.UserPendingOrdersGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UserPendingOrdersGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserPendingOrdersGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNameDataGridViewTextBoxColumn,
            this.startDateTimeDataGridViewTextBoxColumn,
            this.endDateTimeDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn});
            this.UserPendingOrdersGridview.DataSource = this.userOrdersViewBindingSource1;
            this.UserPendingOrdersGridview.Location = new System.Drawing.Point(135, 97);
            this.UserPendingOrdersGridview.Name = "UserPendingOrdersGridview";
            this.UserPendingOrdersGridview.ReadOnly = true;
            this.UserPendingOrdersGridview.RowHeadersWidth = 51;
            this.UserPendingOrdersGridview.RowTemplate.Height = 24;
            this.UserPendingOrdersGridview.Size = new System.Drawing.Size(547, 303);
            this.UserPendingOrdersGridview.TabIndex = 15;
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
            // startDateTimeDataGridViewTextBoxColumn
            // 
            this.startDateTimeDataGridViewTextBoxColumn.DataPropertyName = "startDateTime";
            this.startDateTimeDataGridViewTextBoxColumn.HeaderText = "startDateTime";
            this.startDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateTimeDataGridViewTextBoxColumn.Name = "startDateTimeDataGridViewTextBoxColumn";
            this.startDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startDateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endDateTimeDataGridViewTextBoxColumn
            // 
            this.endDateTimeDataGridViewTextBoxColumn.DataPropertyName = "endDateTime";
            this.endDateTimeDataGridViewTextBoxColumn.HeaderText = "endDateTime";
            this.endDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endDateTimeDataGridViewTextBoxColumn.Name = "endDateTimeDataGridViewTextBoxColumn";
            this.endDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endDateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "orderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "orderStatus";
            this.orderStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Back To Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DiscussionRoomReservationSystem.Properties.Resources.icons8_back_to_100;
            this.pictureBox1.Location = new System.Drawing.Point(63, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Frm08_YourReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.bg_ioop;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserPendingOrdersGridview);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm08_YourReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm8_YourReservation";
            this.Load += new System.EventHandler(this.Frm08_YourReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userOrdersViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userOrdersViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userOrdersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userReservedRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPendingOrdersGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Button ChangeBtn;
        private UserReservedRoom userReservedRoom;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private UserReservedRoomTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private UserOrdersView userOrdersView;
        private System.Windows.Forms.BindingSource userOrdersViewBindingSource;
        private UserOrdersViewTableAdapters.UserOrdersViewTableAdapter userOrdersViewTableAdapter;
        private System.Windows.Forms.Button refreshBtn;
        private UserDatabaseDataSet userDatabaseDataSet;
        private System.Windows.Forms.BindingSource userOrdersViewBindingSource1;
        private UserDatabaseDataSetTableAdapters.UserOrdersViewTableAdapter userOrdersViewTableAdapter1;
        private System.Windows.Forms.DataGridView UserPendingOrdersGridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}