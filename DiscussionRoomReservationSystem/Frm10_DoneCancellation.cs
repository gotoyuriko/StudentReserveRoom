using System;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    public partial class Frm10_DoneCancellation : Form
    {
        public Frm10_DoneCancellation()
        {
            InitializeComponent();
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Frm04_StudentMain frm04 = new Frm04_StudentMain();
            Hide();
            frm04.ShowDialog();
        }
    }
}
