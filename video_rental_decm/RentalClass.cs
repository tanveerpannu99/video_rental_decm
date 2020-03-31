using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_rental_decm
{
   public class RentalClass
    {

        //Conn Instance Object of SQl Connection Class
        SqlConnection conn;
        //String ConnectionString for Making the Connection between the Class and Database
        String conStr = "Data Source=LAPTOP-NN2QR8SO\\SQLEXPRESS;Initial Catalog=VideoRentalDecm;Integrated Security=True";
        //Cmd Instance Object to Create the Relation between  the Commad to execute the sql Command 
        SqlCommand cmd;
        // DReader is instance to read the data from the database and pass to the Class
        SqlDataReader DReader;


        

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


        //issue   the movie on rent but there are some condition like one customer can have only 2 cd one time and copies must be issued less then or equal to the copies 
        public int rentalAdd(int VideoId,int CustomerId,String IssueDate) {
            DataTable tbl = new DataTable();
            tbl = srchRecord("select * from RentalTable where CustomerId="+CustomerId+" and ReturnDate='Booked'");

            if (tbl.Rows.Count < 2)
            {
                int copies = 0;
                tbl = new DataTable();

                tbl = srchRecord("select * from VideoTable where id="+VideoId+"");
                copies =Convert.ToInt32( tbl.Rows[tbl.Rows.Count - 1]["Copies"].ToString());

                tbl = new DataTable();
                tbl = srchRecord("select * from RentalTable where VideoID="+VideoId+" and ReturnDate='Booked'");
                if (tbl.Rows.Count < copies)
                {
                    SqlQuery("insert into RentalTable(VideoID,CustomerID,VideoDate,ReturnDate) values ("+VideoId+","+CustomerId+",'"+IssueDate+"','Booked')");

                    return 1;
                }
                else {
                    MessageBox.Show("All video are  booked ");
                    return 2;
                }

            }
            else {
                MessageBox.Show("Customer Already have 2 videos on rent ");
                return 0;
            }
        }

        //record delete from the rental table 
        public int rentalDelete(int ID) {
            SqlQuery("delete from RentalTable where id="+ID+"");
            return 1;  
        }


        public int rentalUpdate(int id, int VideoId, int CustomerId, String IssueDate,String ReturnDate) {

            DataTable tbl = new DataTable();
            int cost = 0;

            tbl = srchRecord("select * from VideoTable where id=" + VideoId + "");
            cost =Convert.ToInt32( tbl.Rows[tbl.Rows.Count - 1]["Cost"].ToString());


            DateTime new_date = Convert.ToDateTime(ReturnDate); 

            //convert the old date from string to Date fromat
            DateTime prev_date = Convert.ToDateTime(IssueDate);


            //get the difference in the days fromat
            String Daysdiff = (new_date - prev_date).TotalDays.ToString();


            // calculate the round off value 
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));



            int Price = Convert.ToInt32(DaysInterval) * cost;




            SqlQuery("Update RentalTable set VideoID="+VideoId+",CustomerID="+CustomerId+",VideoDate='"+IssueDate+"',ReturnDate='"+ReturnDate+"' where id="+id+"");

            MessageBox.Show("Your total Charges is =$" + Price);
            return 1;

        }

        //gett the data and pass to the data grid view 
        public void RentalData(DataGridView dataGridView)
        {
            DataTable tbl = new DataTable();
            tbl = srchRecord("Select * from RentalTable ");
            dataGridView.DataSource = tbl;
        }





    }
}
