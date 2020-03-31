using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace video_rental_decm
{
   public class VideoClass
    {

        //Conn Instance Object of SQl Connection Class
        SqlConnection conn;
        //String ConnectionString for Making the Connection between the Class and Database
        String conStr = "Data Source=LAPTOP-NN2QR8SO\\SQLEXPRESS;Initial Catalog=VideoRentalDecm;Integrated Security=True";
        //Cmd Instance Object to Create the Relation between  the Commad to execute the sql Command 
        SqlCommand cmd;
        // DReader is instance to read the data from the database and pass to the Class
        SqlDataReader DReader;


        String Name, Ratting;
        int Year, Cost, Copies;


        //this method is used to execute the sql query like insert delete update in the database tables
        public void SqlQuery(String query)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable srchRecord(String qry)
        {
            DataTable tbl = new DataTable();


            conn = new SqlConnection(conStr);

            conn.Open();
            cmd = new SqlCommand(qry, conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }

        public int AddVideo(String Name,String Ratting,int Year,int Copies) {

            try
            {

                //dislay the cost of the price of the video after adding the year of the video
                DateTime dateNow = DateTime.Now;

                //gett hte current year 
                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Year;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    Cost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    Cost = 5;
                }
                // this command is used to enter the record in the database to store video 
                String cmd = "insert into VideoTable(Name,Ratting,Year,Cost,Copies) values('"+Name+"','"+Ratting+"',"+Year+","+Cost+","+Copies+")";
                SqlQuery(cmd);


                MessageBox.Show("Video Cost is $" + Cost);

                return 1;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }


        //method to delete the selected video by caling the method of the sqlquery 
        public int VideoDelete(int VideoID) {

            DataTable tblsrch = new DataTable();
            string srch = "select * from RentalTable where VideoID="+VideoID+" and ReturnDate='Booked'";
            tblsrch = srchRecord(srch);
            if (tblsrch.Rows.Count == 0)
            {



                // get the id as argument and delete the video by passing the id 
                String cmd = "delete from VideoTable where id=" + VideoID + "";
                SqlQuery(cmd);
                return 1;
            }
            else {
                return 0;
            }
        }

        //code to update the record of the video easliy 
        public int VideoUdpate(int id, String Name, String Ratting, int Year,int Cost, int Copies) {

            DateTime dateNow = DateTime.Now;

            //gett hte current year 
            int Currentyear = dateNow.Year;

            int diffYear = Currentyear - Year;
            // MessageBox.Show(diff.ToString());
            if (diffYear >= 5)
            {
                Cost = 2;
            }
            if (diffYear >= 0 && diffYear < 5)
            {
                Cost = 5;
            }

            String cmd = "update VideoTable set Name='" + Name + "',Ratting='" + Ratting + "',Year=" + Year + ",Cost=" + Cost + ",Copies=" + Copies + " where id="+id+"";

            SqlQuery(cmd);
            return 1;
        }

        //gett the data and pass to the data grid view 
        public void VideoData(DataGridView dataGridView) {
            DataTable tbl = new DataTable();
            tbl = srchRecord("Select * from VideoTable ");
            dataGridView.DataSource = tbl;
        }



        public void popularVideo() {

            DataTable tblData = new DataTable();
            tblData = srchRecord("select * from VideoTable ");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = srchRecord("select * from RentalTable where VideoID=" + Convert.ToInt32(tblData.Rows[x]["id"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            MessageBox.Show("Top Ratting Video Movie Title is ==" + Title);


        }
    }
}
