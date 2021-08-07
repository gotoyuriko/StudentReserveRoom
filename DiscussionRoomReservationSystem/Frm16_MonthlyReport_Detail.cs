using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    public partial class Frm16_MonthlyReport_Detail : Form
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDatabase"].ToString());

        public Frm16_MonthlyReport_Detail()
        {
            InitializeComponent();
        }

        private void Frrm19_MonthlyReport_Detail_Load(object sender, EventArgs e)
        {
            Room room = new Room();
            DataTable dt = room.loadMonthlyReport();
            monthlyDataGridView.DataSource = dt;
        }

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            Frm13_AdminMain frm14 = new Frm13_AdminMain();
            Hide();
            frm14.ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
            DataGridView monthGrid = monthlyDataGridView;
            string searchmonth = selectMonthcomboBox.SelectedItem.ToString();
            Room room = new Room();
            bool searchvalidation = room.searchMonthlyReport(searchmonth);
            if (searchvalidation)
            {
                room.DisplayMonthlyReport(monthGrid);
            }
            
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            Frm13_AdminMain frm14 = new Frm13_AdminMain();
            Hide();
            frm14.ShowDialog();
        }

        
    }
}
