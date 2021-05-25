
namespace DiscussionRoomReservationSystem
{
    partial class Frm13_DoneCancellation
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
            this.TitleLabl = new System.Windows.Forms.Label();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabl
            // 
            this.TitleLabl.AutoSize = true;
            this.TitleLabl.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleLabl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.TitleLabl.Location = new System.Drawing.Point(98, 103);
            this.TitleLabl.Name = "TitleLabl";
            this.TitleLabl.Size = new System.Drawing.Size(614, 56);
            this.TitleLabl.TabIndex = 3;
            this.TitleLabl.Text = "Your cancellation will be requredsted to Admin.\r\nPlease wait for a while.";
            this.TitleLabl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfirmBtn.Font = new System.Drawing.Font("MS UI Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ConfirmBtn.Location = new System.Drawing.Point(304, 265);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(177, 42);
            this.ConfirmBtn.TabIndex = 15;
            this.ConfirmBtn.Text = "Back to Menu";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            // 
            // Frm13_DoneCancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.TitleLabl);
            this.Name = "Frm13_DoneCancellation";
            this.Text = "Frm13_DoneCancellation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabl;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}