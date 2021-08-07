using System;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    public partial class Frm07_DoneStudentReservation : Form
    {
        public Frm07_DoneStudentReservation()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Frm04_StudentMain frm04 = new Frm04_StudentMain();
            Hide();
            frm04.ShowDialog();
        }
    }
}
