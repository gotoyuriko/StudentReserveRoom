using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 


namespace DiscussionRoomReservationSystem
{
    public partial class Frm05_StudentReservation : Form
    {
        string username = User.username;
        private string roomType;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDatabase"].ToString());
        public Frm05_StudentReservation()
        {
            InitializeComponent();
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            /*
             * Check whether start time and end time is validated
             * Check whether start and now is validated 
             * check whether time differece is unders
             * check whether the room type is available or not
             * 
             * When successful, go to page
             * When fail, it shows pop up
             */



            //date time format
            /*
             ("yyyy / MM / dd");
             ("HH: mm:ss");
             ("HH: mm:ss");
            */

            //current time
            DateTime dtNow = DateTime.Now;
            //start date time and end date time
            DateTime dStart = StartDateTimePicker.Value;
            DateTime dEnd = EndDateTimePicker.Value;

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
            bool checkStartEnd = room.checkStartEnd(dStart, dEnd);
            bool checkNowStart = room.checkNowStart(dtNow, dStart);
            bool checkUnderSix = room.checkUnderSixHours(dStart, dEnd);
            bool checkReservationDate = room.checkReservationDate(dtNow, dStart);

            //when all inputs are validated
            if (checkStartEnd && checkNowStart && checkUnderSix && checkReservationDate)
            {
                
                bool doubleBooking = room.checkDoubleBooking(dStart, dEnd, roomType);
                if (doubleBooking)
                {
                    Frm09_CheckYourReservation frm9 = new Frm09_CheckYourReservation(dStart, dEnd, roomType, username);
                    this.Hide();
                    frm9.ShowDialog();
                    this.Show();
                }
            }  
        }

        private void Frm05_StudentReservation_Load(object sender, EventArgs e)
        {
        }

        private void DateLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
