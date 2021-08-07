using System;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    public partial class Frm13_AdminMain : Form
    {

        public Frm13_AdminMain()
        {
            InitializeComponent();
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            Frm14_PendingRequest frm15 = new Frm14_PendingRequest();
            Hide();
            frm15.ShowDialog();
            Show();
        }

        private void LogoutPicBox_Click(object sender, EventArgs e)
        {
            Frm01_Home frm1 = new Frm01_Home();
            Hide();
            frm1.ShowDialog();
            Show();
        }

        private void DailyBtn_Click(object sender, EventArgs e)
        {
            Frm15_DailyReport_Detail frm17 = new Frm15_DailyReport_Detail();
            Hide();
            frm17.ShowDialog();
            Show();
        }

        private void MonthlyBtn_Click(object sender, EventArgs e)
        {
            Frm16_MonthlyReport_Detail frm19 = new Frm16_MonthlyReport_Detail();
            Hide();
            frm19.ShowDialog();
            Show();
        }

        private void Frm13_AdminMain_Load(object sender, EventArgs e)
        {

        }
    }
}
