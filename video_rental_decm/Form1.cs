using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video_rental_decm
{
    public partial class Form1 : Form
    {
        int optn = 0;
        int rentId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void VideoAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VideoName.Text.ToString().Equals("") && !VideoRatting.Text.ToString().Equals("") && !VideoDate.Text.ToString().Equals("") && !VideoCopies.Text.ToString().Equals(""))
                {
                    VideoClass obj_Video = new VideoClass();
                    if (obj_Video.AddVideo(VideoName.Text, VideoRatting.Text, Convert.ToInt32(VideoDate.Text.ToString()), Convert.ToInt32(VideoCopies.Text.ToString())) == 1)
                    {
                        MessageBox.Show("Video is SAved ");
                        VideoName.Text = "";
                        VideoRatting.Text = "";
                        VideoDate.Text = "";
                        VideoCost.Text = "";
                        VideoCopies.Text = "";
                    }
                    else {
                        MessageBox.Show("Check your details once again ");
                    }

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Verify the Details Once ");
            }
        }

        private void VideoDelete_Click(object sender, EventArgs e)
        {
            if (!VideoPkID.Text.ToString().Equals(""))
            {
                VideoClass obj_Video = new VideoClass();
                if (obj_Video.VideoDelete(Convert.ToInt32(VideoPkID.Text.ToString())) == 1)
                {
                    MessageBox.Show("Video is deleted from the POrtal ");
                }
                else
                {
                    MessageBox.Show("Video is already issued on Rent  ");
                }

                VideoPkID.Text = "";
                VideoName.Text = "";
                VideoRatting.Text = "";
                VideoDate.Text = "";
                VideoCost.Text = "";
                VideoCopies.Text = "";


            }
            else {
                MessageBox.Show("Check the Id Once or Select the Id first ");
            }
        }

        private void VideoUpdate_Click(object sender, EventArgs e)
        {
            //record to update the data of the video 
            if (!VideoPkID.Text.ToString().Equals("") && !VideoName.Text.ToString().Equals("") && !VideoRatting.Text.ToString().Equals("") && !VideoDate.Text.ToString().Equals("") && !VideoCopies.Text.ToString().Equals(""))
            {
                //create the instance of the class file 
                VideoClass obj_Video = new VideoClass();
                //calling the method and pasing the argument 
                if (obj_Video.VideoUdpate(Convert.ToInt32(VideoPkID.Text.ToString()), VideoName.Text.ToString(), VideoRatting.Text.ToString(), Convert.ToInt32(VideoDate.Text.ToString()), Convert.ToInt32(VideoCost.Text.ToString()), Convert.ToInt32(VideoCopies.Text.ToString())) == 1)
                {
                    MessageBox.Show("Video Data is Updated ");
                    //reset the boxes 
                    VideoPkID.Text = "";
                    VideoName.Text = "";
                    VideoRatting.Text = "";
                    VideoDate.Text = "";
                    VideoCost.Text = "";
                    VideoCopies.Text = "";
                }
                else {
                    MessageBox.Show("Check details once ");
                }

            }
            else {
                MessageBox.Show("Fill all the details of the record to update ");
            }

        }

        private void CustomerAdd_Click(object sender, EventArgs e)
        {
            if (!CustomerName.Text.ToString().Equals("") && !CustomerCity.Text.ToString().Equals("") && !CustomerContact.Text.ToString().Equals("") && !CustomerCountry.Text.ToString().Equals(""))
            {
                CustomerClass obj_Class = new CustomerClass();
                if (obj_Class.CusotmerAdd(CustomerName.Text.ToString(), CustomerCity.Text.ToString(), CustomerContact.Text.ToString(), CustomerCountry.Text.ToString()) == 1)
                {
                    MessageBox.Show("Customer Record is saved ");
                    CustomerName.Text = "";
                    CustomerCity.Text = "";
                    CustomerCountry.Text = "";
                    CustomerContact.Text = "";
                        


                }
                else
                {
                    MessageBox.Show("There is an error check the record once ");
                }
            }
            else {
                MessageBox.Show("Fill all the details ");
            }
        }

        private void CustomerDelete_Click(object sender, EventArgs e)
        {
            /// condition to pass the id and check the id 
            if (!CustomerPkID.Text.ToString().Equals(""))
            {
                CustomerClass obj_Class = new CustomerClass();
                //after that pas the id to delete method if the return value is 1 
                if (obj_Class.CustomerDelete(Convert.ToInt32(CustomerPkID.Text.ToString())) == 1)
                {
                    MessageBox.Show("Customer Record is deleted ");
                    CustomerPkID.Text = "";
                    CustomerName.Text = "";
                    CustomerCity.Text = "";
                    CustomerCountry.Text = "";
                    CustomerContact.Text = "";

                }
                else {
                    MessageBox.Show("You already have an video on rent ");
                }
            }
            else {
                MessageBox.Show("Select the Customer Record to Delete ");
            }
        }

        private void CustomerUpdate_Click(object sender, EventArgs e)
        {
            //pass the record to update the details of the customer 
            if (!CustomerPkID.Text.ToString().Equals("") && !CustomerName.Text.ToString().Equals("") && !CustomerCity.Text.ToString().Equals("") && !CustomerContact.Text.ToString().Equals("") && !CustomerCountry.Text.ToString().Equals("")) {

                CustomerClass obj_Class = new CustomerClass();
                if (obj_Class.CusotmerUpdate(Convert.ToInt32(CustomerPkID.Text.ToString()),CustomerName.Text.ToString(), CustomerCity.Text.ToString(), CustomerContact.Text.ToString(), CustomerCountry.Text.ToString()) == 1)
                {
                    MessageBox.Show("Customer Record is Updated ");

                    CustomerName.Text = "";
                    CustomerCity.Text = "";
                    CustomerCountry.Text = "";
                    CustomerContact.Text = "";
                    CustomerPkID.Text = "";


                }
                else
                {
                    MessageBox.Show("There is an error check the record once ");
                }

            }
            else {
                MessageBox.Show("Fill all the Values to Update the record ");
            }
        }

        private void VideoData_Click(object sender, EventArgs e)
        {
            VideoClass obj = new VideoClass();
            obj.VideoData(dataGridView2);
            optn = 1;

        }

        private void CustomerData_Click(object sender, EventArgs e)
        {
            CustomerClass obj = new CustomerClass();
            obj.CustomerData(dataGridView2);
            optn = 2;

        }

        private void VideoIssue_Click(object sender, EventArgs e)
        {
            //verfy the Id of the Video and Customer 
            if (!VideoPkID.Text.ToString().Equals("") && !CustomerPkID.Text.ToString().Equals(""))
            {
                RentalClass obj_rent = new RentalClass();
                if (obj_rent.rentalAdd(Convert.ToInt32(VideoPkID.Text.ToString()), Convert.ToInt32(CustomerPkID.Text.ToString()), RentalIssueDate.Text.ToString()) == 1) {
                    MessageBox.Show("Video is issued on rent ");
                }
                    VideoPkID.Text = "";
                    VideoName.Text = "";
                    VideoRatting.Text = "";
                    VideoDate.Text = "";
                    VideoCost.Text = "";
                    VideoCopies.Text = "";

                    CustomerPkID.Text = "";
                    CustomerName.Text = "";
                    CustomerCity.Text = "";
                    CustomerCountry.Text = "";
                    CustomerContact.Text = "";
                    
                    





                
            }
            else {
                MessageBox.Show("Select the Video to book on rent ");
            }

        }

        private void RetnalVideoDelete_Click(object sender, EventArgs e)
        {
            if (rentId == 0)
            {
                RentalClass obj_rent = new RentalClass();
                if (obj_rent.rentalDelete(rentId) == 1)
                {
                    MessageBox.Show(" Rental Record is deleted");
                }

                VideoPkID.Text = "";
                VideoName.Text = "";
                VideoRatting.Text = "";
                VideoDate.Text = "";
                VideoCost.Text = "";
                VideoCopies.Text = "";

                CustomerPkID.Text = "";
                CustomerName.Text = "";
                CustomerCity.Text = "";
                CustomerCountry.Text = "";
                CustomerContact.Text = "";



            }
            else {
                MessageBox.Show("Select the rental video to delete ");
            }

        }

        private void VideoReturn_Click(object sender, EventArgs e)
        {
            if (rentId>0 && !VideoPkID.Text.ToString().Equals("") && !CustomerPkID.Text.ToString().Equals("")) {
                RentalClass obj_Rent = new RentalClass();

                if (obj_Rent.rentalUpdate(rentId, Convert.ToInt32(VideoPkID.Text.ToString()), Convert.ToInt32(CustomerPkID.Text.ToString()), RentalIssueDate.Text.ToString(), RentalReturnDate.Text.ToString()) == 1)
                {

                }
                else {
                    MessageBox.Show("Check your record once ");

                }


                VideoPkID.Text = "";
                VideoName.Text = "";
                VideoRatting.Text = "";
                VideoDate.Text = "";
                VideoCost.Text = "";
                VideoCopies.Text = "";

                CustomerPkID.Text = "";
                CustomerName.Text = "";
                CustomerCity.Text = "";
                CustomerCountry.Text = "";
                CustomerContact.Text = "";

            }


        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            if (optn==1) {
                VideoPkID.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                VideoName.Text= dataGridView2.CurrentRow.Cells[1].Value.ToString();
                VideoRatting.Text= dataGridView2.CurrentRow.Cells[2].Value.ToString();
                VideoDate.Text= dataGridView2.CurrentRow.Cells[3].Value.ToString();
                VideoCost.Text= dataGridView2.CurrentRow.Cells[4].Value.ToString();
                VideoCopies.Text= dataGridView2.CurrentRow.Cells[5].Value.ToString();

            }

            if (optn==2) {
                CustomerPkID.Text= dataGridView2.CurrentRow.Cells[0].Value.ToString();
                CustomerName.Text= dataGridView2.CurrentRow.Cells[1].Value.ToString();
                CustomerCity.Text= dataGridView2.CurrentRow.Cells[2].Value.ToString();
                CustomerContact.Text= dataGridView2.CurrentRow.Cells[3].Value.ToString();
                CustomerCountry.Text= dataGridView2.CurrentRow.Cells[4].Value.ToString();


            }


            if (optn==3) {

                rentId=Convert.ToInt32( dataGridView2.CurrentRow.Cells[0].Value.ToString());

                VideoPkID.Text= dataGridView2.CurrentRow.Cells[1].Value.ToString();
                CustomerPkID.Text= dataGridView2.CurrentRow.Cells[2].Value.ToString();
                RentalIssueDate.Text= dataGridView2.CurrentRow.Cells[3].Value.ToString();


            }


            optn = 0;



        }

        private void RentalData_Click(object sender, EventArgs e)
        {
            RentalClass obj_rent = new RentalClass();
            obj_rent.RentalData(dataGridView2);
            optn = 3;

        }

        private void PopularVideo_Click(object sender, EventArgs e)
        {
            //print the name of the popular video 
            VideoClass obj_video = new VideoClass();
            obj_video.popularVideo();

        }

        private void PopularCustomer_Click(object sender, EventArgs e)
        {
            //print the name of the popular customer  
            CustomerClass obj_customer = new CustomerClass();
            obj_customer.popularCustomer();

        }
    }
}
