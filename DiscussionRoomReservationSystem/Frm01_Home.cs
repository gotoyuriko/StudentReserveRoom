using System;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    public partial class Frm01_Home : Form
    {
        public Frm01_Home()
        {
            InitializeComponent();
        }

        //When you click login button
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Frm02_Login frm2 = new Frm02_Login();
            Hide();
            frm2.ShowDialog();
        }

        //When you click sign up button
        

        //When you load Home Page
        private void Frm01_Home_Load(object sender, EventArgs e)
        {
            Room room = new Room();
            /*To check whether the reservation is already done after the current time*/
            room.checkReservationIsDone();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            Frm03_SignUp frm3 = new Frm03_SignUp();
            Hide();
            frm3.ShowDialog();
        }
    }
}
