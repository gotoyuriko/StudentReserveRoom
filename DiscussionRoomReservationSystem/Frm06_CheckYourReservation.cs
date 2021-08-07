using System;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    public partial class Frm06_CheckYourReservation : Form
    {
        public static string roomname;
        public static DateTime startime;
        public static DateTime endtime;
        string username  = User.username;
        public Frm06_CheckYourReservation(DateTime st, DateTime et, string rn, string us)
        {
            InitializeComponent();
            roomname = rn;
            startime = st;
            endtime = et;
            username = us;

        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {

            Room room = new Room(roomname, startime, endtime);

            //add new reservation
            room.newReservationAdd();

            Frm07_DoneStudentReservation frm11 = new Frm07_DoneStudentReservation();
            Hide();
            frm11.ShowDialog();
        }


        //Display Inputs from Users
        private void Frm09_CheckYourReservation_Load(object sender, EventArgs e)
        {
            RoomTitleLbl.Text = roomname.ToString();
            StartTimeLbl.Text = "Start Time/Date:  " + startime.ToString();
            EndTimeLbl.Text = "End Time/Date:  " + endtime.ToString();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Frm05_StudentReservation frm5 = new Frm05_StudentReservation();
            Hide();
            frm5.ShowDialog();
        }
    }
    }
