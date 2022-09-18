using FnProject.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FnProject
{
    public partial class fClass : Form
    {
        public fClass()
        {
            InitializeComponent();
        }

        private void fClass_Load(object sender, EventArgs e)    
        {
            dgvListClass.DataSource = ClassDAO.Instance.GetListStudentByClass();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

            //DataGridViewCheckBoxColumn btn = new DataGridViewCheckBoxColumn(); 
            dgvListClass.Columns.Add(btn);
            btn.Name = "Detail";
            btn.Text = "Detail";
            btn.HeaderText = "Detail";
            btn.UseColumnTextForButtonValue = true;


        }

        private void btnInsertClass_Click(object sender, EventArgs e)
        {
            string classId = txtClassId.Text;
            string className = txtClassName.Text;

            if (className!="" && classId != "")
            {
                ClassDAO.Instance.InsertClass(classId, className);
                MessageBox.Show("Record Inserted Successfully");
                dgvListClass.DataSource = ClassDAO.Instance.GetListStudentByClass();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            string classId = txtClassId.Text;
            if (StudentDAO.Instance.CheckIdForSC(classId))
            {
                MessageBox.Show("Class cannot be deleted due to the remaining students.");
                return;
            }
            else
            {
                ClassDAO.Instance.DeleteClass(classId);
                MessageBox.Show("Delete Successfully");
                dgvListClass.DataSource = ClassDAO.Instance.GetListStudentByClass();
            }
            
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            string classId = txtClassId.Text;
            string className = txtClassName.Text;

            if (CheckClassId(classId))
            {
                ClassDAO.Instance.UpdateClass(classId, className);
                MessageBox.Show("Update Successfully");
                dgvListClass.DataSource = ClassDAO.Instance.GetListStudentByClass();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        bool CheckClassId(string classId)
        {
            return ClassDAO.Instance.CheckClassId(classId);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearchClass.Text;
            dgvListClass.DataSource = ClassDAO.Instance.SearchClass(search);
        }

        private void dgvCellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex==2)
            {
               
                DataGridViewRow index= dgvListClass.Rows[e.RowIndex];

                string temp = index.Cells[0].Value.ToString();
                this.Hide();
                fListStudents f = new fListStudents();
                f.GetClassIdByStudent(temp);
                f.ShowDialog();

            }
          
        }
        public int CountClassId()
        {
            return ClassDAO.Instance.CountClassId();
        }

        
    }
}
