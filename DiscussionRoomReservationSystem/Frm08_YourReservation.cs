using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    public partial class Frm08_YourReservation : Form
    {
        private readonly string username = User.username;
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDatabase"].ToString());
        public Frm08_YourReservation()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Frm09_CancelReservation frm07 = new Frm09_CancelReservation();
            Hide();
            frm07.ShowDialog();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Frm11_ChangeReservation frm10 = new Frm11_ChangeReservation();
            Hide();
            frm10.ShowDialog();
            Show();
        }

        private void Frm08_YourReservation_Load(object sender, EventArgs e)
        {
            Room room = new Room();
            DataTable dt = room.refreshYourReservation();
            UserPendingOrdersGridview.DataSource = dt;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            DataTable dt = room.refreshYourReservation();
            UserPendingOrdersGridview.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm04_StudentMain frm4 = new Frm04_StudentMain();
            Hide();
            frm4.ShowDialog();
        }
    }
}
