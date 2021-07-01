using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Data.OleDb;


namespace ElevatorControl
{
    public partial class Form1 : Form
    {
        //variables

        int y_up = 63;
        int y_down = 376;
        int x_door_left_close = 74;
        int x_door_left_open = 12;
        int x_door_right_close = 139;
        int x_door_right_open = 200;

        bool go_up = false;
        bool go_down = false;

        bool arrived_G = false;
        bool arrived_1 = false;

        //object 
        SpeechSynthesizer reader = new SpeechSynthesizer();
 


        public Form1()
        {
            InitializeComponent();
        }

        private void timer_lift_down_Tick(object sender, EventArgs e)
        {
            
            if (picture_lift.Top <= y_down)
            {
                picture_lift.Top += 1;
            }
            else
            {
                timer_lift_down.Enabled = false;
                btn_up.Enabled = true;
                btn_1.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = true;
                btn_down.BackColor = Color.White;
                btn_G.BackColor = Color.White;
                

                door_open_down();
                arrived_G = true;

                picture_lift.Image = global::ElevatorControl.Properties.Resources.Inside_of_the_lift;

                display_panel.Image = global::ElevatorControl.Properties.Resources.G;
                display_top.Image = global::ElevatorControl.Properties.Resources.G;
                display_bottom.Image = global::ElevatorControl.Properties.Resources.G;
            }
        }

        private void timer_lift_up_Tick(object sender, EventArgs e)
        {
            if (picture_lift.Top >= y_up)
            {
                picture_lift.Top -= 1;
            }
            else
            {

                timer_lift_up.Enabled = false;
                btn_down.Enabled = true;
                btn_G.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = true;
                btn_up.BackColor = Color.White;
                btn_1.BackColor = Color.White;

                door_open_up();
                arrived_1 = true;


                picture_lift.Image = global::ElevatorControl.Properties.Resources.Inside_of_the_lift;

                display_panel.Image = global::ElevatorControl.Properties.Resources._1;
                display_top.Image = global::ElevatorControl.Properties.Resources._1;
                display_bottom.Image = global::ElevatorControl.Properties.Resources._1;
            }
        }

        private void door_open_down_Tick(object sender, EventArgs e)
        {
            if (door_left_down.Left >= x_door_left_open && door_right_down.Left <= x_door_right_open)
            {
                door_left_down.Left -= 1;
                door_right_down.Left += 1;
            }
            else
            {

                timer_door_open_down.Enabled = false;

            }
        }

        private void door_close_down_Tick(object sender, EventArgs e)
        {
            if (door_left_down.Left <= x_door_left_close && door_right_down.Left >= x_door_right_close)
            {
                door_left_down.Left += 1;
                door_right_down.Left -= 1;
            }
            else
            {
                timer_door_close_down.Enabled = false;
                

                if (go_up == true)
                {
                    picture_lift.Image = global::ElevatorControl.Properties.Resources.lift_transparent;

                    display_panel.Image = global::ElevatorControl.Properties.Resources.up;
                    display_top.Image = global::ElevatorControl.Properties.Resources.up;
                    display_bottom.Image = global::ElevatorControl.Properties.Resources.up;

                    reader.Speak("Go ing up");

                    timer_lift_up.Enabled = true;
                    go_up = false;
                }
            }
        }

        private void timer_door_open_up_Tick(object sender, EventArgs e)
        {
            if (door_left_up.Left >= x_door_left_open && door_right_up.Left <= x_door_right_open)
            {
                door_left_up.Left -= 1;
                door_right_up.Left += 1;
            }
            else
            {
                timer_door_open_up.Enabled = false;

            }
        }

        private void timer_door_close_up_Tick(object sender, EventArgs e)
        {
            if (door_left_up.Left <= x_door_left_close && door_right_up.Left >= x_door_right_close)
            {
                door_left_up.Left += 1;
                door_right_up.Left -= 1;
            }
            else
            {
                timer_door_close_up.Enabled = false;

                
                if (go_down == true)
                {
                    picture_lift.Image = global::ElevatorControl.Properties.Resources.lift_transparent;

                    display_panel.Image = global::ElevatorControl.Properties.Resources.down;
                    display_top.Image = global::ElevatorControl.Properties.Resources.down;
                    display_bottom.Image = global::ElevatorControl.Properties.Resources.down;

                    
                    reader.Speak("Go ing  down");

                    timer_lift_down.Enabled = true;
                    go_down = false;
                }
            }
        }

        private void door_close_down()
        {
            reader.Speak("doors closing");
            insertdata("Doors Closing @Ground Floor");
            timer_door_close_down.Enabled = true;
            timer_door_open_down.Enabled = false;
        }

        private void door_open_down()
        {
            reader.Speak("Ground floor, doors open ing");
            insertdata("Doors Opening @Ground Floor");
            timer_door_close_down.Enabled = false;
            timer_door_open_down.Enabled = true;
        }

        private void door_close_up()
        {
            reader.Speak("doors closing");
            insertdata("Doors Closing @First Floor");
            timer_door_close_up.Enabled = true;
            timer_door_open_up.Enabled = false;
        }

        private void door_open_up()
        {
            reader.Speak("First floor , doors open ing");
            insertdata("Doors Opening @First Floor");
            timer_door_close_up.Enabled = false;
            timer_door_open_up.Enabled = true;
        }

        private void going_up()
        {
            go_up = true;
            door_close_down();
            btn_G.Enabled = false;
            btn_down.Enabled = false;
            btn_close.Enabled = false;
            btn_open.Enabled = false;
            arrived_G = false;
            insertdata("Lift Going Up");

        }


        private void going_down()
        {
            go_down = true;
            door_close_up();

            btn_1.Enabled = false;
            btn_up.Enabled = false;
            btn_close.Enabled = false;
            btn_open.Enabled = false;
            arrived_1 = false;
            insertdata("Lift Going Down");

            
        }


        private void btn_down_Click(object sender, EventArgs e)
        {
            btn_up.BackColor = Color.Red;
            going_up();

        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            btn_down.BackColor = Color.Red;
            going_down();
        }


        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_1.BackColor = Color.Red;
            going_up();
        }

        private void btn_G_Click(object sender, EventArgs e)
        {
            btn_G.BackColor = Color.OrangeRed;
            going_down();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (arrived_G == true)
            {
                door_close_down();
            }
            else if (arrived_1 == true)
            {
                door_close_up();
            }

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if (arrived_G == true)
            {
                door_open_down();
            }
            else if (arrived_1 == true)
            {
                door_open_up();
            }

        }
       
        /*
         * Database Code
         *
         */

        //Database Variables and instantiations
        private bool filled;
        public DataSet ds = new DataSet();
        


        private void btn_displaylog_Click(object sender, EventArgs e)
        {
            try
            {
                string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ElevatorDatabase.accdb;";
                string dbcommand = "Select * from Actions;";
                OleDbConnection conn = new OleDbConnection(dbconnection);
                OleDbCommand comm = new OleDbCommand(dbcommand, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(comm);

                //cnn.Open();
                conn.Open();
                //MessageBox.Show("Connection Open ! ");
                while (filled == false)
                {
                    adapter.Fill(ds);
                    filled = true;
                }
                //cnn.Close();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
                string message = "Error in connection to datasource";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }

            database_listbox.Items.Clear();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                database_listbox.Items.Add(row["Date"] + "\t\t" + row["Time"] + "\t\t" + row["Action"]);
            }

        }

        private void insertdata(string action)
        {
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = ElevatorDatabase.accdb;";
            string dbcommand = "insert into [Actions] ([Date],[Time],[Action]) values (@date, @time, @action)";
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToLongTimeString();
            

            database_listbox.Items.Add(date + "\t\t" + time + "\t\t" + action);



            OleDbConnection conn_db = new OleDbConnection(dbconnection);
            OleDbCommand comm_insert = new OleDbCommand(dbcommand, conn_db);
            OleDbDataAdapter adapter_insert = new OleDbDataAdapter(comm_insert);
            comm_insert.Parameters.AddWithValue("@date", date);
            comm_insert.Parameters.AddWithValue("@time", time);
            comm_insert.Parameters.AddWithValue("@action", action);




            conn_db.Open();

            comm_insert.ExecuteNonQuery();

            conn_db.Close();
        }

        private void btn_clearlog_Click(object sender, EventArgs e)
        {
            database_listbox.Items.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        
   

    }
}