using System;
using System.Windows.Forms;


namespace DiscussionRoomReservationSystem
{
    public partial class Frm11_ChangeReservation : Form
    {
        private string roomType;
        public Frm11_ChangeReservation()
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
            //old start date time and end date time
            ComboBox oldStartDateTime = oldStartDateTimeCmb;
            ComboBox oldEndDateTime = oldEndDateTimeCmb;

            //roomtype
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
            bool checkStartEnd = room.checkStartEnd();
            bool checkNowStart = room.checkNowStart(dtNow);
            bool checkUnderSix = room.checkUnderSixHours();
            bool checkReservationDate = room.checkReservationDate(dtNow);

            //when all inputs are validated
            if (checkStartEnd && checkNowStart && checkUnderSix && checkReservationDate)
            {
                Room room2 = new Room(dStart, dEnd, roomType);
                bool doubleBooking = room2.checkDoubleBooking();
                if (doubleBooking)
                {
                    Room room3 = new Room(roomType, dStart, dEnd);
                    //change Reservation
                    room3.changeReservation(oldStartDateTime, oldEndDateTime);

                    Frm12_DoneChangeReservation frm12 = new Frm12_DoneChangeReservation();
                    Hide();
                    frm12.ShowDialog();
                    Show();
                }
            }
        }

 

        private void RoomTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox roomType = RoomTypeCmb;
            ComboBox oldStartDateTime = oldStartDateTimeCmb;
            oldStartDateTimeCmb.Items.Clear();
            //roomtype is selected
            Room room5 = new Room();
            room5.changeRoomIsselected(roomType, oldStartDateTime);
        }

        private void oldStartDateTimeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            oldEndDateTimeCmb.Items.Clear();
            ComboBox roomType = RoomTypeCmb;
            ComboBox oldStartDateTime = oldStartDateTimeCmb;
            ComboBox oldEndDateTime = oldEndDateTimeCmb;
            Room room6 = new Room();
            room6.changeOldStartTime(roomType, oldStartDateTime, oldEndDateTime);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm08_YourReservation frm8 = new Frm08_YourReservation();
            Hide();
            frm8.ShowDialog();
        }

        private void Frm11_ChangeReservation_Load(object sender, EventArgs e)
        {
            ComboBox roomType = RoomTypeCmb;
            Room room4 = new Room();
            room4.loadChangeReservation(roomType);
        }
    }
}
