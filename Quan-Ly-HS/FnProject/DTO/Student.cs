using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FnProject.DTO
{
    public class Student
    {
        public Student(string mssv, string lastName, string firstName, string classId, string yearOfIntake, string modeOfTraining, string dateOfBirth)
        {
            this.ClassId = classId;
            this.Mssv = mssv;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.YearOfIntake = yearOfIntake;
            this.ModeOfTraining = modeOfTraining;
            this.DateOfBirth = dateOfBirth;
        }

        public Student(DataRow row)
        {
            this.ClassId = row["classId"].ToString();
            this.Mssv = row["mssv"].ToString();
            this.FirstName = row["firstName"].ToString();
            this.LastName = row["lastName"].ToString();
            this.YearOfIntake = row["yearOfIntake"].ToString();
            this.ModeOfTraining = row["modeOfTraining"].ToString();
            this.DateOfBirth = row["dateOfBirth"].ToString();
        }

        private string classId;

        public string ClassId
        {
            get { return classId; }
            set { classId = value; }
        }
        private string mssv;

        public string Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set {lastName = value; }
        }
        private string yearOfIntake;

        public string YearOfIntake
        {
            get { return yearOfIntake; }
            set { yearOfIntake = value; }
        }

        private string modeOfTraining;

        public string ModeOfTraining
        {
            get { return modeOfTraining; }
            set { modeOfTraining = value; }
        }

        private string dateOfBirth;

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
    }
}
