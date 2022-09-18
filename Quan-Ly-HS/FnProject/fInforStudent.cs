using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FnProject.DAO;
using FnProject.DTO;

namespace FnProject
{
    public partial class fInforStudent : Form
    {
        public fInforStudent()
        {
            InitializeComponent();
        }
        public void GetMssvFromListStudent(string mssv)
        {
            DataTable table = GetInformationStd(mssv);
            DataTable table1 = GetInforClass(mssv);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("No Personal information available:) ", "Notification");
                return;
            }  
           
            txtMssv.Text = table.Rows[0]["Mssv"].ToString();
            //Get Data from Table Student
            txtLastName.Text = table1.Rows[0]["LastName"].ToString();
            txtFirstName.Text = table1.Rows[0]["FirstName"].ToString();
            txtDateOfBirth.Text = table1.Rows[0]["DateOfBirth"].ToString();
            txtYearOfIntake.Text = table1.Rows[0]["YearOfIntake"].ToString();
            txtModeOfTraining.Text = table1.Rows[0]["ModeOfTraining"].ToString();

            // Get Data from Table Class
            txtGroup.Text = table1.Rows[0]["ClassId"].ToString();
            txtFaculy.Text = table1.Rows[0]["ClassName"].ToString();
            //txtMajor.Text = table.Rows[0]["Mssv"].ToString();
            


            //Get Data from table InformationStudent
            txtPlaceOfBirth.Text= table.Rows[0]["PlaceOfBirth"].ToString();
            txtTownOfOrigin.Text= table.Rows[0]["TownOfOrigin"].ToString();
            txtGender.Text= table.Rows[0]["Gender"].ToString();
            txtNationality.Text= table.Rows[0]["Nationality"].ToString();
            txtProviceOrCity.Text= table.Rows[0]["ProvinceOrCity"].ToString();
            txtDicstrict.Text= table.Rows[0]["Dicstrict"].ToString();
            txtWardOrTown.Text= table.Rows[0]["WardOrTown"].ToString();
            txtStreet.Text= table.Rows[0]["Street"].ToString();
            txtAddressNumber.Text= table.Rows[0]["AddressNumber"].ToString();
            txtStudentPhone.Text= table.Rows[0]["StudentPhone"].ToString();
            txtIdCard.Text= table.Rows[0]["IdCardNumber"].ToString();
            txtDateIdCard.Text= table.Rows[0]["DateIdCard"].ToString();
            txtPlaceIdCard.Text= table.Rows[0]["PlaceIdCard"].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string mssv = txtMssv.Text;
            string placeOfBirth = txtPlaceOfBirth.Text;
            string townOfOrigin = txtTownOfOrigin.Text;
            string gender = txtGender.Text;
            string nationality = txtNationality.Text;
            string provinceOrCity = txtProviceOrCity.Text;
            string dicstrict = txtDicstrict.Text;
            string wardOrTown = txtWardOrTown.Text;
            string street = txtStreet.Text;
            string addressNumber = txtAddressNumber.Text;
            string studentPhone = txtStudentPhone.Text;
            string idCardNumber = txtIdCard.Text;
            string dateIdCard = txtDateIdCard.Text;
            string placeIdCard = txtPlaceIdCard.Text;

            if(CheckMssv(mssv)==true)
            {
                InformationStdDAO.Instance.Update(mssv, placeOfBirth, townOfOrigin,gender, nationality, 
                    provinceOrCity, dicstrict,wardOrTown, street, addressNumber, studentPhone,idCardNumber, dateIdCard, placeIdCard);
                MessageBox.Show("Update Successfully");
                GetMssvFromListStudent(mssv);
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
            
        }
        bool CheckMssv(string mssv)
        {
            return StudentDAO.Instance.CheckMssv(mssv);
        }




        public DataTable GetInformationStd(string mssv)
        {

            return InformationStdDAO.Instance.GetInformationStudent(mssv);
        }
        public DataTable GetInforClass(String mssv)
        {
            return InformationStdDAO.Instance.GetClassFromStudent(mssv);
        }
    }
}
