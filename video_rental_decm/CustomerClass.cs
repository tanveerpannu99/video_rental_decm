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
   public class CustomerClass
    {

        //Conn Instance Object of SQl Connection Class
        SqlConnection conn;
        //String ConnectionString for Making the Connection between the Class and Database
        String conStr = "Data Source=LAPTOP-NN2QR8SO\\SQLEXPRESS;Initial Catalog=VideoRentalDecm;Integrated Security=True";
        //Cmd Instance Object to Create the Relation between  the Commad to execute the sql Command 
        SqlCommand cmd;
        // DReader is instance to read the data from the database and pass to the Class
        SqlDataReader DReader;


        String Name, City, Contact, Country;

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


        public int CusotmerAdd(String Name,String City,String Contact,String Country) {
            String cmd = "insert into CustomerTable(Name,City,Contact,Country) values ('"+Name+"','"+City+"','"+Contact+"','"+Country+"')";
            SqlQuery(cmd);
            return 1;
        }

        //method to delete the selected Customer by caling the method of the sqlquery 
        public int CustomerDelete(int CustomerID)
        {

            DataTable tblsrch = new DataTable();
            string srch = "select * from RentalTable where CustomerID=" + CustomerID + " and ReturnDate='Booked'";
            tblsrch = srchRecord(srch);
            if (tblsrch.Rows.Count == 0)
            {



                // get the id as argument and delete the Customer by passing the id 
                String cmd = "delete from CustomerTable where id=" + CustomerID + "";
                SqlQuery(cmd);
                return 1;
            }
            else
            {
                return 0;
            }
        }


        public int CusotmerUpdate(int Id, String Name, String City, String Contact, String Country)
        {
            String cmd = "Update CustomerTable set Name='" + Name + "',City='" + City + "',Contact='" + Contact + "',Country='" + Country + "' where id="+Id+"";
            SqlQuery(cmd);
            return 1;
        }

        //gett the data and pass to the data grid view 
        public void CustomerData(DataGridView dataGridView)
        {
            DataTable tbl = new DataTable();
            tbl = srchRecord("Select * from CustomerTable ");
            dataGridView.DataSource = tbl;
        }

        //ge the name of the popular customer 
        public void popularCustomer() {
            DataTable tblData = new DataTable();
            tblData =srchRecord("select * from CustomerTable");
            int x = 0,  cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = srchRecord("select * from RentalTable where CustomerID=" + Convert.ToInt32(tblData.Rows[x]["id"].ToString()) + "");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }
            MessageBox.Show("Popular Cusotmer is ==" + Title);


        }

    }
}
