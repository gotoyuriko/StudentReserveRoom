using System;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    public partial class Frm02_Login : Form
    {

        public Frm02_Login()
        {
            InitializeComponent();
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            /*
             * IF the username and password matches with Database you can go to the frm4
             */
            User user = new User(usernameTxtbox.Text, passwordMaskedTxtbox.Text);
            string userRole = user.userLogin();

            if (userRole == "admin")
            {
                Frm13_AdminMain frm14 = new Frm13_AdminMain();
                Hide();
                frm14.ShowDialog();
            }
            else if (userRole == "student")
            {
                Frm04_StudentMain frm4 = new Frm04_StudentMain();
                Hide();
                frm4.ShowDialog();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Frm01_Home frm1 = new Frm01_Home();
            Hide();
            frm1.ShowDialog();
            Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Frm03_SignUp frm3 = new Frm03_SignUp();
            Hide();
            frm3.ShowDialog();
        }
    }
}
