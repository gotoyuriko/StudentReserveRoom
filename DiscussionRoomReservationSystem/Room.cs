using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DiscussionRoomReservationSystem
{
    internal class Room
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDatabase"].ToString());
        DataTable dt;
        string username = User.username;




        /*==============================MEMBER FIELD====================================*/
        private string roomname;
        private DateTime startDateTime;
        private DateTime endDateTime;
        private DateTime oldstartDateTime;
        private DateTime oldendDateTime;
        private DateTime newstartDateTime;
        private DateTime newendDateTime;
        private string status;





        /*==============================GET AND SET METHOD====================================*/
        public string Roomname { get => roomname; set => roomname = value; }
        public DateTime StartDateTime { get => startDateTime; set => startDateTime = value; }
        public DateTime EndDateTime { get => endDateTime; set => endDateTime = value; }
        public DateTime OldstartDateTime { get => oldstartDateTime; set => oldstartDateTime = value; }
        public DateTime OldendDateTime { get => oldendDateTime; set => oldendDateTime = value; }
        public DateTime NewstartDateTime { get => newstartDateTime; set => newstartDateTime = value; }
        public DateTime NewendDateTime { get => newendDateTime; set => newendDateTime = value; }
        public string Status { get => status; set => status = value; }





        /*==============================CONSTRUCTOR====================================*/
        public Room()
        {

        }

        public Room(string rn)
        {
            roomname = rn;
        }

        public Room(DateTime st, DateTime et)
        {
            startDateTime = st;
            endDateTime = et;
        }

        public Room(DateTime st, DateTime et, string rn)
        {
            startDateTime = st;
            endDateTime = et;
            roomname = rn;
        }

        public Room(DateTime st)
        {
            startDateTime = st;
        }

        public Room(string nm, DateTime nst, DateTime net)
        {
            roomname = nm;
            startDateTime = nst;
            endDateTime = net;
        }

        public Room(string rn, DateTime ost, DateTime oet, string st)
        {
            roomname = rn;
            oldstartDateTime = ost;
            oldendDateTime = oet;
            status = st;
        }

        public Room(string rn, DateTime ost, DateTime oet, DateTime nst, DateTime net)
        {
            roomname = rn;
            oldstartDateTime = ost;
            oldendDateTime = oet;
            newstartDateTime = nst;
            newendDateTime = net;
        }





        /*==============================METHOD====================================*/

        /*******************************Frm1****************************************/
        /*To check whether the reservation is already done after the current time*/
        public void checkReservationIsDone()
        {
            //Get Current Time
            DateTime dtNow = DateTime.Now;

            /*==Order Tables==*/
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Orders Where orderStatus = 'reserved'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                //endDateTime is before current time
                if (rd.GetDateTime(4).CompareTo(dtNow) == -1)
                {
                    /*==Table Pending Orders==*/
                    SqlCommand cmd2 = new SqlCommand("DELETE from PendingOrders Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and roomName = @roomname and oldstartDateTime = @startTime and oldendDateTime = @endTime ", con);
                    cmd2.Parameters.AddWithValue("@username", rd.GetString(1)); //username
                    cmd2.Parameters.AddWithValue("@roomname", rd.GetString(2)); //roomName
                    cmd2.Parameters.AddWithValue("@startTime", rd.GetDateTime(3)); //oldStartDateTime
                    cmd2.Parameters.AddWithValue("@endTime", rd.GetDateTime(4)); //oldEndDateTime
                    cmd2.ExecuteNonQuery();

                    /*==Table Orders==*/
                    SqlCommand cmd3 = new SqlCommand("Select * from Orders UPDATE Orders SET orderStatus = 'done' Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and roomName = @roomname and startDateTime = @startTime and endDateTime = @endTime ", con);
                    cmd3.Parameters.AddWithValue("@username", rd.GetString(1)); //username
                    cmd3.Parameters.AddWithValue("@roomname", rd.GetString(2)); //roomName
                    cmd3.Parameters.AddWithValue("@startTime", rd.GetDateTime(3)); //startDateTime
                    cmd3.Parameters.AddWithValue("@endTime", rd.GetDateTime(4)); //endDateTime
                    cmd3.ExecuteNonQuery();
                }
            }
            con.Close();
        }






        /*******************************Frm4****************************************/
        public void studentMenuDataBase()
        {
            con.Open();
            //delete MainMenu table first
            SqlCommand cmd3 = new SqlCommand("TRUNCATE TABLE MainMenu", con);
            cmd3.ExecuteNonQuery();

            /*==Orders Table==*/
            SqlCommand cmd = new SqlCommand("select * from Orders", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string roomvalidation = rd.GetString(2); //roomName
                                                         //if roomName equals to selected Room
                if (roomvalidation == roomname)
                {
                    /*==MainMenu table==*/
                    SqlCommand cmd2 = new SqlCommand("insert into MainMenu (roomName, startTime, endTime, status) values(@roomname, @startTime, @endTime, 'reserved')", con);
                    cmd2.Parameters.AddWithValue("@roomname", roomvalidation); //roomName
                    cmd2.Parameters.AddWithValue("@startTime", rd.GetDateTime(3)); //startDateTime
                    cmd2.Parameters.AddWithValue("@endTime", rd.GetDateTime(4)); //endDateTime
                    cmd2.ExecuteNonQuery();
                }
            }
            con.Close();
        }

        public DataTable displayRoomsStudentMenu()
        {
            SqlDataAdapter adapt = new SqlDataAdapter("select * from MainMenu", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }







        /*******************************Frm5 & Frm9****************************************/
        //Check whether start time and end time is validated
        public bool checkStartEnd()
        {
            switch (startDateTime.CompareTo(endDateTime))
            {
                case -1:
                    return true;
                case 0:
                    MessageBox.Show("Start time and end Time is the same. Please try again.");
                    return false;
                case 1:
                    MessageBox.Show("You set start time after end Time. Please try again.");
                    return false;
            }
            return false;
        }

        //Check whether start and now is validated
        public bool checkNowStart(DateTime ct)
        {
            switch (ct.CompareTo(startDateTime))
            {
                case -1:
                    return true;
                case 0:
                    MessageBox.Show("Your current time and start Time is the same. Please try again.");
                    return false;
                case 1:
                    MessageBox.Show("Your current time is after start Time. Please try again.");
                    return false;
            }
            return false;
        }


        //check whether time differece is unders
        public bool checkUnderSixHours()
        {
            TimeSpan hours = endDateTime - startDateTime;

            if (hours.TotalHours <= 6)
            {
                return true;
            }
            else
            {
                MessageBox.Show("The length of time should be under 6 hours. Please try again.");
                return false;
            }
        }


        //cehck whether you could reserve room 2 days prior
        public bool checkReservationDate(DateTime ct)
        {
            TimeSpan hours = startDateTime - ct;

            if (hours.TotalHours <= 48)
            {
                MessageBox.Show("You need to reserve room 2 days prior");
                return false;
            }
            else
            {
                return true;
            }
        }

        //check whether the room type is double booking or not.
        public bool checkDoubleBooking()
        {
            //string date
            string yourDate = startDateTime.ToString("yyyy/MM/dd");

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Orders where orderStatus = 'reserved'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string roomName = rd.GetString(2);
                DateTime checkStartTime = rd.GetDateTime(3);
                DateTime checkEndTime = rd.GetDateTime(4);
                string checkDate = checkStartTime.ToString("yyyy/MM/dd");

                if (roomName == roomname && yourDate == checkDate)
                {
                    if (checkStartTime < endDateTime && startDateTime < checkEndTime)
                    {
                        MessageBox.Show("The room is already reserved. Please try another room.");
                        return false;
                    }
                }
            }
            con.Close();
            return true;
        }







        /*******************************Frm6****************************************/
        //Add new Reservation from Students
        public void newReservationAdd()
        {
            con.Open();
            /*==Orders==*/
            SqlCommand cmd = new SqlCommand("Insert into Orders (username, roomname, startDateTime, endDateTime, orderStatus) values(@username, @roomname, @startTime, @endTime, 'reserved')", con);
            cmd.Parameters.AddWithValue("@startTime", startDateTime);
            cmd.Parameters.AddWithValue("@endTime", endDateTime);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@roomname", roomname);
            cmd.ExecuteNonQuery();
            con.Close();
        }





        /*******************************Frm8****************************************/

        public DataTable refreshYourReservation()
        {
            con.Open();
            SqlDataAdapter userordersview = new SqlDataAdapter("Select * from Orders Where username = '" + username + "' COLLATE SQL_Latin1_General_CP1_CS_AS and orderStatus != 'done'", con);
            DataTable dt = new DataTable();
            userordersview.Fill(dt);
            con.Close();
            return dt;
        }




        /*******************************Frm9****************************************/
        public void checkCancelInputsAreValidated(ComboBox roomTypeCmb, ComboBox dateTimeCmb)
        {
            //start date time and end date time
            DateTime dStart;
            string roomType;

            if (roomTypeCmb.SelectedItem == null || dateTimeCmb.SelectedItem == null)
            {
                MessageBox.Show("Please Select a room to cancel");
                return;
            }
            else
            {
                dStart = DateTime.Parse(dateTimeCmb.SelectedItem.ToString());
                roomType = roomTypeCmb.SelectedItem.ToString();
            }


                DialogResult result = MessageBox.Show("Are you sure you want to cancel your reservation?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    cancelReservation(username, roomType, dStart);
                }
            
        }

        //Cancel Reservation
        public void cancelReservation(string username, string roomType, DateTime dStart)
        {
            con.Open();

            /*==Orders Table==*/
            SqlCommand cmd5 = new SqlCommand("DELETE from Orders Where roomName = @roomname and username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and startDateTime = @startTime", con);
            cmd5.Parameters.AddWithValue("@username", username);
            cmd5.Parameters.AddWithValue("@roomname", roomType);
            cmd5.Parameters.AddWithValue("@startTime", dStart);
            cmd5.ExecuteNonQuery();

            /*==PendingOrders Table==*/
            SqlCommand cmd6 = new SqlCommand("DELETE from PendingOrders Where roomName = @roomname and username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and oldstartDateTime = @startTime", con);
            cmd6.Parameters.AddWithValue("@username", username);
            cmd6.Parameters.AddWithValue("@roomname", roomType);
            cmd6.Parameters.AddWithValue("@startTime", dStart);
            cmd6.ExecuteNonQuery();

            con.Close();
        }


        //When you load cancel reservation page, check whetehr combobox contain username
        public void cancelReserved(ComboBox roomType)
        {
            con.Open();
            //reserved Orders Table
            SqlCommand cmd = new SqlCommand("Select * from Orders Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and orderStatus = 'reserved'", con);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (!roomType.Items.Contains(rd.GetString(2)))
                {
                    roomType.Items.Add(rd.GetString(2));
                }
            }
            con.Close();

            con.Open();
            //pending Orders Table
            //COLLATE SQL_Latin1_General_CP1_CS_AS means case sensitive
            SqlCommand cmd2 = new SqlCommand("Select * from Orders Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and orderStatus = 'pending'", con);
            cmd2.Parameters.AddWithValue("@username", username);
            SqlDataReader rd2 = cmd2.ExecuteReader();
            while (rd2.Read())
            {
                if (!roomType.Items.Contains(rd2.GetString(2)))
                {
                    roomType.Items.Add(rd2.GetString(2));
                }
            }
            con.Close();
        }


        //when you select roomType, you can scope date and time that you reserved.
        public void cancelRoomIsSelected(ComboBox roomType2, ComboBox dateTime)
        {
            /*==Orders Table==*/
            con.Open();
            //reserved
            SqlCommand cmd3 = new SqlCommand("Select * from Orders Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and orderStatus = 'reserved' and roomName = @roomname", con);
            cmd3.Parameters.AddWithValue("@username", username);
            cmd3.Parameters.AddWithValue("@roomname", roomType2.SelectedItem);
            SqlDataReader rd3 = cmd3.ExecuteReader();
            while (rd3.Read())
            {
                dateTime.Items.Add(rd3.GetDateTime(3));
            }

            /*==Orders Table==*/
            //pending
            SqlCommand cmd4 = new SqlCommand("Select * from Orders Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and orderStatus = 'pending' and roomName = @roomname", con);
            cmd4.Parameters.AddWithValue("@username", username);
            cmd4.Parameters.AddWithValue("@roomname", roomType2.SelectedItem);
            SqlDataReader rd4 = cmd4.ExecuteReader();
            while (rd4.Read())
            {
                dateTime.Items.Add(rd4.GetDateTime(3));
            }
            con.Close();
        }





        /*******************************Frm11****************************************/
        //when you change reservation
        public void changeReservation(ComboBox oldStartDateTime, ComboBox oldEndDateTime)
        {
            con.Open();
            /*==PendingOrders==*/
            SqlCommand cmd = new SqlCommand("Insert into PendingOrders (username, roomName, oldstartDateTime, oldendDateTime, newstartDateTime, newendDateTime) values(@username, @roomname, @oldstartTime, @oldendTime, @newstartTime, @newendTime)", con);
            cmd.Parameters.AddWithValue("@oldendTime", oldEndDateTime.SelectedItem);
            cmd.Parameters.AddWithValue("@oldstartTime", oldStartDateTime.SelectedItem);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@roomname", roomname);
            cmd.Parameters.AddWithValue("@newstartTime", startDateTime);
            cmd.Parameters.AddWithValue("@newendTime", endDateTime);
            cmd.ExecuteNonQuery();

            /*==Orders==*/
            SqlCommand cmd2 = new SqlCommand("Select * from Orders UPDATE Orders SET orderStatus = 'pending' where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and roomName = @roomname and startDateTime = @startTime", con);
            cmd2.Parameters.AddWithValue("@username", username);
            cmd2.Parameters.AddWithValue("@roomname", roomname);
            cmd2.Parameters.AddWithValue("@startTime", oldStartDateTime.SelectedItem);
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        //when you load change reservation page
        public void loadChangeReservation(ComboBox roomType)
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("Select * from Orders Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and orderStatus = 'reserved'", con);
            cmd3.Parameters.AddWithValue("@username", username);
            SqlDataReader rd = cmd3.ExecuteReader();
            while (rd.Read())
            {
                if (!roomType.Items.Contains(rd.GetString(2)))
                {
                    roomType.Items.Add(rd.GetString(2));
                }
            }
            con.Close();
        }

        //when you select roomtype and scope old start date time
        public void changeRoomIsselected(ComboBox roomType, ComboBox oldStartDateTime)
        {
            con.Open();
            SqlCommand cmd4 = new SqlCommand("Select * from Orders Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and orderStatus = 'reserved' and roomName = @roomname", con);
            cmd4.Parameters.AddWithValue("@username", username);
            cmd4.Parameters.AddWithValue("@roomname", roomType.SelectedItem);
            SqlDataReader rd3 = cmd4.ExecuteReader();
            while (rd3.Read())
            {
                oldStartDateTime.Items.Add(rd3.GetDateTime(3));
            }
            con.Close();
        }

        //when you select start date
        public void changeOldStartTime(ComboBox roomType, ComboBox oldStartDateTime, ComboBox oldEndDateTime)
        {
            con.Open();
            SqlCommand cmd5 = new SqlCommand("Select * from Orders Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and orderStatus = 'reserved' and roomName = @roomname and startDateTime = @starttime", con);
            cmd5.Parameters.AddWithValue("@username", username);
            cmd5.Parameters.AddWithValue("@roomname", roomType.SelectedItem);
            cmd5.Parameters.AddWithValue("@starttime", oldStartDateTime.SelectedItem);
            SqlDataReader rd3 = cmd5.ExecuteReader();
            while (rd3.Read())
            {
                oldEndDateTime.Items.Add(rd3.GetDateTime(4));
            }
            con.Close();
        }



        /*******************************Frm14****************************************/
        public DataTable displayPendingorders()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from PendingOrders", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        //When you approve reservation
        public bool approveReservation(DataGridView pendingrequestgrid)
        {
            foreach (DataGridViewRow eachRow in pendingrequestgrid.Rows)
            {
                bool isSelected = Convert.ToBoolean(eachRow.Cells["pendingCheckBox"].Value);

                if (isSelected)
                {
                    DialogResult result = MessageBox.Show("You will approve the change of reservation", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        //Get from DataGridView (pending request)
                        string usernamePending = eachRow.Cells[2].Value.ToString();
                        string roomNamePending = eachRow.Cells[3].Value.ToString();
                        DateTime oldstartTimePending = Convert.ToDateTime(eachRow.Cells[4].Value);
                        DateTime oldendTimePending = Convert.ToDateTime(eachRow.Cells[5].Value);
                        DateTime newstartTimePending = Convert.ToDateTime(eachRow.Cells[6].Value);
                        DateTime newendTimePending = Convert.ToDateTime(eachRow.Cells[7].Value);
                        bool flag1 = false;
                        bool flag2 = false;


                        if (pendingrequest(roomNamePending, newstartTimePending, newendTimePending, flag1, flag2))
                        {
                            MessageBox.Show("Conflicting Data Found in The Database. Rejecting Changes");
                            adminApprovedConflict(usernamePending, roomNamePending, oldstartTimePending, oldendTimePending);
                        }
                        else
                        {
                            MessageBox.Show("Room Approved Successfully");
                            adminApproveSuccess1(usernamePending, roomNamePending, oldstartTimePending, oldendTimePending, "pending");

                            adminApproveSuccess2(usernamePending, roomNamePending, newstartTimePending, newendTimePending, "reserved");

                            adminApproveSuccess3(usernamePending, roomNamePending, oldstartTimePending, oldendTimePending, newstartTimePending, newendTimePending);
                        }
                        con.Close();
                        return true;
                    }
                }
            }
            return false;
        }

        public DataTable updateAfterApprove()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from PendingOrders", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }



        //when you approve pending request, check whether the pending time is overlapping with Orders.
        public bool pendingrequest(string roomNamePending, DateTime newstartTimePending, DateTime newendTimePending, bool flag1, bool flag2)
        {
            //Get from DataGridView (pending request)
            con.Open();
            SqlCommand cmd5 = new SqlCommand("Select * from Orders Where orderStatus != 'done' and roomName = @roomname", con);
            cmd5.Parameters.AddWithValue("@roomname", roomNamePending);
            SqlDataReader rd = cmd5.ExecuteReader();

            while (rd.Read())
            {
                if (rd.GetDateTime(3).CompareTo(newstartTimePending) == -1 && newstartTimePending.CompareTo(rd.GetDateTime(4)) == -1)
                {
                    flag1 = true;
                }
                if (rd.GetDateTime(3).CompareTo(newendTimePending) == -1 && newendTimePending.CompareTo(rd.GetDateTime(4)) == -1)
                {
                    flag2 = true;
                }
            }
            con.Close();

            if (flag1 == true || flag2 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //after pendingrequest(), if there is conflict the database is below.
        public void adminApprovedConflict(string usernamePending, string roomNamePending, DateTime oldstartTimePending, DateTime oldendTimePending)
        {
            con.Open();
            SqlCommand cmd4 = new SqlCommand("DELETE from PendingOrders Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and roomName = @roomname and oldstartDateTime = @startTime and oldendDateTime = @endTime ", con);
            cmd4.Parameters.AddWithValue("@username", usernamePending);
            cmd4.Parameters.AddWithValue("@roomname", roomNamePending);
            cmd4.Parameters.AddWithValue("@startTime", oldstartTimePending);
            cmd4.Parameters.AddWithValue("@endTime", oldendTimePending);
            cmd4.ExecuteNonQuery();
            SqlCommand cmd6 = new SqlCommand("Select * from Orders UPDATE Orders SET orderStatus = 'reserved' Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and roomName = @roomname and startDateTime = @startTime and endDateTime = @endTime ", con);
            cmd6.Parameters.AddWithValue("@username", usernamePending);
            cmd6.Parameters.AddWithValue("@roomname", roomNamePending);
            cmd6.Parameters.AddWithValue("@startTime", oldstartTimePending);
            cmd6.Parameters.AddWithValue("@endTime", oldendTimePending);
            cmd6.ExecuteNonQuery();
            con.Close();
        }


        public void adminApproveSuccess1(string usernamePending,string roomNamePending,DateTime oldstartTimePending, DateTime oldendTimePending, string status)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE from Orders Where orderStatus = @status and username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and roomName = @roomname and startDateTime = @startTime and endDateTime = @endTime ", con);
            cmd.Parameters.AddWithValue("@username", usernamePending);
            cmd.Parameters.AddWithValue("@roomname", roomNamePending);
            cmd.Parameters.AddWithValue("@startTime", oldstartTimePending);
            cmd.Parameters.AddWithValue("@endTime", oldendTimePending);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void adminApproveSuccess2(string usernamePending, string roomNamePending, DateTime newStartTimePending, DateTime newEndTimePending, string status)
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Insert into Orders (username, roomname, startDateTime, endDateTime, orderStatus) values(@username, @roomname, @startTime, @endTime, 'reserved')", con);
            cmd2.Parameters.AddWithValue("@username", usernamePending);
            cmd2.Parameters.AddWithValue("@roomname", roomNamePending);
            cmd2.Parameters.AddWithValue("@startTime", newStartTimePending);
            cmd2.Parameters.AddWithValue("@endTime", newEndTimePending);
            cmd2.Parameters.AddWithValue("@status", status);
            cmd2.ExecuteNonQuery();
            con.Close();
        }

        public void adminApproveSuccess3(string usernamePending, string roomNamePending, DateTime oldstartTimePending, DateTime oldendTimePending, DateTime newstartTimePending, DateTime newendTimePending)
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("DELETE from PendingOrders Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and roomName = @roomname and oldstartDateTime = @oldstartdatetime and oldendDateTime = @oldenddatetime and newstartDateTime = @newstartdatetime and newendDateTime = @newenddatetime", con);
            cmd3.Parameters.AddWithValue("@username", usernamePending);
            cmd3.Parameters.AddWithValue("@roomname", roomNamePending);
            cmd3.Parameters.AddWithValue("@oldstartDateTime", oldstartTimePending);
            cmd3.Parameters.AddWithValue("@oldendDateTime", oldendTimePending);
            cmd3.Parameters.AddWithValue("@newstartDateTime", newstartTimePending);
            cmd3.Parameters.AddWithValue("@newendDateTime", newendTimePending);
            cmd3.ExecuteNonQuery();
            con.Close();
        }


        public void rejectReservation(DataGridView rejectReservation)
        {
            foreach (DataGridViewRow eachRow in rejectReservation.Rows)
            {
                bool isSelected = Convert.ToBoolean(eachRow.Cells["pendingCheckBox"].Value);

                if (isSelected)
                {
                    DialogResult result = MessageBox.Show("You will deny the change of reservation", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        DataTable dt = adminReject(eachRow);
                        rejectReservation.DataSource = dt;
                    }
                }
            }
        }
        public DataTable adminReject(DataGridViewRow eachRow)
        {
            con.Open();
            string usernamePending = eachRow.Cells[2].Value.ToString();
            string roomNamePending = eachRow.Cells[3].Value.ToString();
            DateTime oldstartTimePending = Convert.ToDateTime(eachRow.Cells[4].Value);
            DateTime oldendTimePending = Convert.ToDateTime(eachRow.Cells[5].Value);
            SqlCommand cmd7 = new SqlCommand("DELETE from PendingOrders Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and roomName = @roomname and oldstartDateTime = @startTime and oldendDateTime = @endTime ", con);
            cmd7.Parameters.AddWithValue("@username", usernamePending);
            cmd7.Parameters.AddWithValue("@roomname", roomNamePending);
            cmd7.Parameters.AddWithValue("@startTime", oldstartTimePending);
            cmd7.Parameters.AddWithValue("@endTime", oldendTimePending);
            cmd7.ExecuteNonQuery();

            SqlCommand cmd8 = new SqlCommand("Select * from Orders UPDATE Orders SET orderStatus = 'reserved' Where username = @username COLLATE SQL_Latin1_General_CP1_CS_AS and roomName = @roomname and startDateTime = @startTime and endDateTime = @endTime ", con);
            cmd8.Parameters.AddWithValue("@username", usernamePending);
            cmd8.Parameters.AddWithValue("@roomname", roomNamePending);
            cmd8.Parameters.AddWithValue("@startTime", oldstartTimePending);
            cmd8.Parameters.AddWithValue("@endTime", oldendTimePending);
            cmd8.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from PendingOrders", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }




        /*******************************Frm16****************************************/

        public DataTable searchDailyReport(string strsearchdate)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Orders", con);
            SqlDataReader rd = cmd.ExecuteReader();
            bool flag = true;
            

            //delete Daily table first
            SqlCommand cmd3 = new SqlCommand("TRUNCATE TABLE Daily", con);
            cmd3.ExecuteNonQuery();

            while (rd.Read())
            {
                string datevalidation = rd.GetDateTime(3).ToString("yyyy / MM / dd");
                if (datevalidation == strsearchdate)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into Daily (roomName, startDateTime, endDateTime, userID) values(@roomname, @startDateTime, @endDateTime, @username)", con);
                    cmd2.Parameters.AddWithValue("@roomname", rd.GetString(2));
                    cmd2.Parameters.AddWithValue("@startDateTime", rd.GetDateTime(3));
                    cmd2.Parameters.AddWithValue("@endDateTime", rd.GetDateTime(4));
                    cmd2.Parameters.AddWithValue("@username", rd.GetString(1));
                    cmd2.ExecuteNonQuery();
                    flag = false;
                }

            }


            if (flag)
            {
                MessageBox.Show("Data not found, please try again");
            }
            else
            {
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Daily", con);
                dt = new DataTable();
                adapt.Fill(dt);
                
            }
            con.Close();

            return dt;
        }

        public DataTable loadDailyReport()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from Orders", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        public bool searchMonthlyReport(string searchmonth)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Orders", con);
            SqlDataReader rd = cmd.ExecuteReader();
            bool flag = true;

            //delete Daily table first
            SqlCommand cmd3 = new SqlCommand("TRUNCATE TABLE Monthly", con);
            cmd3.ExecuteNonQuery();

            while (rd.Read())
            {
                string monthvalidation = rd.GetDateTime(3).ToString("MMMM");
                if (monthvalidation == searchmonth)
                {
                    SqlCommand cmd2 = new SqlCommand("insert into Monthly (roomName, startDateTime, endDateTime, userID) values(@roomname, @startDateTime, @endDateTime, @username)", con);
                    cmd2.Parameters.AddWithValue("@roomname", rd.GetString(2));
                    cmd2.Parameters.AddWithValue("@startDateTime", rd.GetDateTime(3));
                    cmd2.Parameters.AddWithValue("@endDateTime", rd.GetDateTime(4));
                    cmd2.Parameters.AddWithValue("@username", rd.GetString(1));
                    cmd2.ExecuteNonQuery();
                    flag = false;
                }

            }
            con.Close();

            if (flag)
            {
                MessageBox.Show("Data not found, please try again.");
                return false;
            }
            else
            {
                
                return true;
            }
            
        }

        public void DisplayMonthlyReport(DataGridView dataGridView)
        {
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from Monthly", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        public DataTable loadMonthlyReport()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from Orders", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
