
namespace DiscussionRoomReservationSystem
{
    partial class Frm12_DoneChangeReservation
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
            this.label1 = new System.Windows.Forms.Label();
            this.BackMenubtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleLbl.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.ForeColor = System.Drawing.Color.Black;
            this.TitleLbl.Location = new System.Drawing.Point(57, 87);
            this.TitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(666, 39);
            this.TitleLbl.TabIndex = 2;
            this.TitleLbl.Text = "Your change will be requested to Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(225, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please wait for while";
            // 
            // BackMenubtn
            // 
            this.BackMenubtn.BackColor = System.Drawing.Color.White;
            this.BackMenubtn.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.bg_ioop;
            this.BackMenubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackMenubtn.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackMenubtn.ForeColor = System.Drawing.Color.Black;
            this.BackMenubtn.Location = new System.Drawing.Point(303, 260);
            this.BackMenubtn.Name = "BackMenubtn";
            this.BackMenubtn.Size = new System.Drawing.Size(163, 48);
            this.BackMenubtn.TabIndex = 13;
            this.BackMenubtn.Text = "Back to Menu";
            this.BackMenubtn.UseVisualStyleBackColor = false;
            this.BackMenubtn.Click += new System.EventHandler(this.BackMenubtn_Click);
            // 
            // Frm12_DoneChangeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscussionRoomReservationSystem.Properties.Resources.undraw_among_nature_p1xb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.BackMenubtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm12_DoneChangeReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm12_DoneChangeReservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackMenubtn;
    }
}