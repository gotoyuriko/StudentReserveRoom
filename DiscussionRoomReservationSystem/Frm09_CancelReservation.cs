using System;
using System.Windows.Forms;


namespace DiscussionRoomReservationSystem
{
    public partial class Frm09_CancelReservation : Form
    {
        public Frm09_CancelReservation()
        {
            InitializeComponent();
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            ComboBox roomTypeCmb = RoomTypeCmb;
            ComboBox dateTimeCmb = DateTimeCmb;
            Room room = new Room();
            room.checkCancelInputsAreValidated(roomTypeCmb, dateTimeCmb);

            Frm10_DoneCancellation frm13 = new Frm10_DoneCancellation();
            Hide();
            frm13.ShowDialog();
            Show();
        }

        private void Frm07_CancelReservation_Load(object sender, EventArgs e)
        {
            ComboBox roomType = RoomTypeCmb;
            Room room = new Room();
            room.cancelReserved(roomType);
        }

        private void RoomTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clear selected items
            DateTimeCmb.Items.Clear();
            ComboBox roomType2 = RoomTypeCmb;
            ComboBox dateTime = DateTimeCmb;
            Room room2 = new Room();
            room2.cancelRoomIsSelected(roomType2, dateTime);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm08_YourReservation frm8 = new Frm08_YourReservation();
            Hide();
            frm8.ShowDialog();
        }
    }
}
