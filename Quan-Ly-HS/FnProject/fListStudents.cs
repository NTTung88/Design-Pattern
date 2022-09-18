using FnProject.DAO;
using FnProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace FnProject
{
    public partial class fListStudents : Form
    {

        public fListStudents()
        {
            InitializeComponent();
        }

        private void fListStudents_Load(object sender, EventArgs e)
        {

            //dgvListStudent.DataSource = StudentDAO.Instance.GetListStudentByClass();

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvListStudent.Columns.Add(btn);
            btn.Name = "Detail";
            btn.Text = "Detail";
            btn.HeaderText = "Detail";
            btn.UseColumnTextForButtonValue = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string classId = txtClassId.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string mssv = txtMssv.Text;
            string yearOfIntake = txtYearOfIntake.Text;
            string modeOfTraining = txtModeOfTraining.Text;
            string dateOfBirth = txtDateOfBirth.Text;
            if (CheckMssv(mssv) == false && CheckClassId(classId)==true)
            {
                StudentDAO.Instance.InsertStudent(mssv, lastName, firstName,classId, yearOfIntake,modeOfTraining,dateOfBirth);
                MessageBox.Show("Record Inserted Successfully");
                dgvListStudent.DataSource = StudentDAO.Instance.GetStudentFromClass(classId);

            }
            else
            {
                MessageBox.Show("Please re-enter Mssv Or Class");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string classId = txtClassId.Text;
            string mssv = txtMssv.Text;

            if (CheckMssv(mssv) == true)
            {
                StudentDAO.Instance.DeleteStudent(mssv);
                MessageBox.Show("Delete Successfully");
                dgvListStudent.DataSource = StudentDAO.Instance.GetStudentFromClass(classId);
            }
            else
            {
                MessageBox.Show("Please re-enter Mssv");
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string classId = txtClassId.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string mssv = txtMssv.Text;
            string yearOfIntake = txtYearOfIntake.Text;
            string modeOfTraining = txtModeOfTraining.Text;
            string dateOfBirth = txtDateOfBirth.Text;
            if (CheckMssv(mssv)==true && CheckClassId(classId)==true)
            {
                StudentDAO.Instance.UpdateStudent(mssv, lastName, firstName, classId, yearOfIntake, modeOfTraining, dateOfBirth);
                MessageBox.Show("Update Successfully");
                dgvListStudent.DataSource = StudentDAO.Instance.GetStudentFromClass(classId);
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
        bool CheckClassId(string classId)
        {
            return ClassDAO.Instance.CheckClassID(classId);
        }

        public void GetClassIdByStudent(string temp)
        {
            dgvListStudent.DataSource = StudentDAO.Instance.GetStudentFromClass(temp);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            fClass f = new fClass();
            this.Close();
            f.ShowDialog();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                DataGridViewRow index = dgvListStudent.Rows[e.RowIndex];

                string temp = index.Cells[0].Value.ToString();
                this.Hide();
                fInforStudent f = new fInforStudent();
                f.GetMssvFromListStudent(temp);
                f.ShowDialog();

            }
        }
    }
}
