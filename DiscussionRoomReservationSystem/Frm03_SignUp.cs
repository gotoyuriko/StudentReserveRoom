using System;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    public partial class Frm03_SignUp : Form
    {
        public Frm03_SignUp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Frm02_Login frm2 = new Frm02_Login();
            Hide();
            frm2.ShowDialog();
        }



        private void exitBtn_Click(object sender, EventArgs e)
        {
            Frm01_Home frm1 = new Frm01_Home();
            Hide();
            frm1.ShowDialog();
            Show();
        }

        private void signupBtn_Click(object sender, EventArgs e)
        {
            User user = new User(usernameTxtbox.Text, passwordMaskedTxtbox.Text, "student");
            //check user sign up
            bool status = user.userSignup(confirmpassMaskedTxtbox.Text);

            if (status)
            {
                Frm04_StudentMain frm4 = new Frm04_StudentMain();
                Hide();
                frm4.ShowDialog();
            }
        }
    }
}
