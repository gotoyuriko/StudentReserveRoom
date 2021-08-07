using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    public partial class Frm14_PendingRequest : Form
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDatabase"].ToString());

        public Frm14_PendingRequest()
        {
            InitializeComponent();
        }



        private void Approve1Btn_Click(object sender, EventArgs e)
        {
           DataGridView approveReservation = PendingRequestDataGridView;
           Room room = new Room();
           bool approveValidation = room.approveReservation(approveReservation);
            if (approveValidation)
            {
                DataTable dt = room.updateAfterApprove();
                PendingRequestDataGridView.DataSource = dt;
            }

        }

        

        private void Reject1Btn_Click(object sender, EventArgs e)
        {
            DataGridView rejectReservation = PendingRequestDataGridView;
            Room room2 = new Room();
            room2.rejectReservation(rejectReservation);
        }

        private void Frm14_PendingRequest_Load(object sender, EventArgs e)
        {
            Room room = new Room();
            DataTable dt = room.displayPendingorders();
            PendingRequestDataGridView.DataSource = dt;
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            Frm13_AdminMain frm14 = new Frm13_AdminMain();
            Hide();
            frm14.ShowDialog();
        }
    }
}
