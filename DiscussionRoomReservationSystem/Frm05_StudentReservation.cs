using System;
using System.Windows.Forms;


namespace DiscussionRoomReservationSystem
{
    public partial class Frm05_StudentReservation : Form
    {
        private readonly string username = User.username;
        private string roomType;
        public Frm05_StudentReservation()
        {
            InitializeComponent();
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            //current time
            DateTime dtNow = DateTime.Now;
            //start date time and end date time
            DateTime dStart = StartDateTimePicker.Value;
            DateTime dEnd = EndDateTimePicker.Value;

            if (RoomTypeCmb.SelectedItem == null)
            {
                MessageBox.Show("Please Select a room to reserve");
                return;
            }
            else
            {
                roomType = RoomTypeCmb.SelectedItem.ToString();
            }

            Room room = new Room(dStart, dEnd);
            //compare start time and end time
            bool checkStartEnd = room.checkStartEnd();
            //compare current time and start time
            bool checkNowStart = room.checkNowStart(dtNow);
            //check whether is under six hours
            bool checkUnderSix = room.checkUnderSixHours();
            //check whether the reservation date is not whithin 2days
            bool checkReservationDate = room.checkReservationDate(dtNow);

            //when all inputs are validated
            if (checkStartEnd && checkNowStart && checkUnderSix && checkReservationDate)
            {
                //check double booking
                Room room2 = new Room(dStart, dEnd, roomType);
                bool doubleBooking = room2.checkDoubleBooking();
                if (doubleBooking)
                {
                    Frm06_CheckYourReservation frm9 = new Frm06_CheckYourReservation(dStart, dEnd, roomType, username);
                    Hide();
                    frm9.ShowDialog();
                    Show();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm04_StudentMain frm4 = new Frm04_StudentMain();
            Hide();
            frm4.ShowDialog();
        }

        private void Frm05_StudentReservation_Load(object sender, EventArgs e)
        {

        }
    }
}
