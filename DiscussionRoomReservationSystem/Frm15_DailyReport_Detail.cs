using System;
using System.Data;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    public partial class Frm15_DailyReport_Detail : Form
    {
        public Frm15_DailyReport_Detail()
        {
            InitializeComponent();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            DateTime searchdate = searchDailyDateTimePicker.Value;
            string strsearchdate = searchdate.ToString("yyyy / MM / dd");

            Room room = new Room();
            DataTable dt = room.searchDailyReport(strsearchdate);
            dailyDataGridView.DataSource = dt;

        }

        private void Frm17_DailyReport_Detail_Load(object sender, EventArgs e)
        {
            Room room1 = new Room();
            DataTable dt = room1.loadDailyReport();
            dailyDataGridView.DataSource = dt;
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            Frm13_AdminMain frm14 = new Frm13_AdminMain();
            Hide();
            frm14.ShowDialog();
        }
    }
}
