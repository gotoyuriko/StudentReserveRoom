using System;
using System.Data;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    public partial class Frm04_StudentMain : Form
    {
        private readonly string studentname = User.username;
        public Frm04_StudentMain()
        {
            InitializeComponent();
        }

        private void Frm04_StudentMain_Load(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Welcome, " + studentname;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Frm05_StudentReservation frm5 = new Frm05_StudentReservation();
            Hide();
            frm5.ShowDialog();
            Show();
        }

        private void YourRBtn_Click(object sender, EventArgs e)
        {
            Frm08_YourReservation frm8 = new Frm08_YourReservation();
            Hide();
            frm8.ShowDialog();
            Show();
        }

        private void CheckRButton_Click(object sender, EventArgs e)
        {
            if (checkRoomComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Room");
            }
            else
            {
                string searchroom = checkRoomComboBox.SelectedItem.ToString();

                Room room = new Room(searchroom);
                //Delete all data of MainMenu Table and Insert matched data from Orders Data
                room.studentMenuDataBase();

                Room room2 = new Room();
                /*==Dispaly DataGridView from MainMenu Table==*/
                DataTable dt = room2.displayRoomsStudentMenu();
                roomCheckDataGridView.DataSource = dt;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm01_Home frm1 = new Frm01_Home();
            Hide();
            frm1.ShowDialog();
            Show();
        }
    }
}
