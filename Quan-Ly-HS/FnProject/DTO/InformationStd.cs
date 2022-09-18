using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FnProject.DTO
{
    class InformationStd
    {
        public InformationStd(string mssv , string placeOfBirth,string townOfOrigin,
            string gender,string nationality,string provinceOrCity ,string dicstrict,
            string wardOrTown,string street, string addressNumber,string studentPhone,
            string idCardNumber,string dateIdCard,string placeIdCard)
        {
            this.Mssv = mssv;
            this.PlaceOfBirth = placeOfBirth;
            this.TownOfOrigin = townOfOrigin;
            this.Gender = gender;
            this.Nationality = nationality;
            this.ProvinceOrCity = provinceOrCity;
            this.Dicstrict = dicstrict;
            this.WardOrTown = wardOrTown;
            this.Street = street;
            this.AddressNumber = addressNumber;
            this.StudentPhone = studentPhone;
            this.IdCardNumber = idCardNumber;
            this.DateIdCard = dateIdCard;
            this.PlaceIdCard = placeIdCard;
        }public InformationStd(DataRow row)
        {
            this.Mssv = row["mssv"].ToString();
            this.PlaceOfBirth = row["placeOfBirth"].ToString();
            this.TownOfOrigin = row["townOfOrigin"].ToString();
            this.Gender =  row["gender"].ToString();
            this.Nationality =  row["nationality"].ToString();
            this.ProvinceOrCity =row["provinceOrCity"].ToString();
            this.Dicstrict = row["dicstrict"].ToString();
            this.WardOrTown = row["wardOrTown"].ToString();
            this.Street = row["street"].ToString();
            this.AddressNumber = row["addressNumber"].ToString();;
            this.StudentPhone = row["studentPhone"].ToString();
            this.IdCardNumber = row["idCardNumber"].ToString();
            this.DateIdCard =  row["dateIdCard"].ToString();
            this.PlaceIdCard = row["placeIdCard"].ToString();
        }
        private string mssv;

        public string Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }

        private string placeOfBirth;

        public string PlaceOfBirth
        {
            get { return placeOfBirth; }
            set { placeOfBirth = value; }
        }
        private string townOfOrigin;

        public string TownOfOrigin
        {
            get { return townOfOrigin; }
            set { townOfOrigin = value; }
        }
        private string gender;

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        private string nationality;

        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        private string provinceOrCity;

        public string ProvinceOrCity
        {
            get { return provinceOrCity; }
            set { provinceOrCity = value; }
        }
        private string dicstrict;

        public string Dicstrict
        {
            get { return dicstrict; }
            set { dicstrict = value; }
        }
        private string wardOrTown;

        public string WardOrTown
        {
            get { return wardOrTown; }
            set { wardOrTown = value; }
        }
        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        private string addressNumber;

        public string AddressNumber
        {
            get { return addressNumber; }
            set { addressNumber = value; }
        }
        private string studentPhone;

        public string StudentPhone
        {
            get { return studentPhone; }
            set { studentPhone = value; }
        }
        private string idCardNumber;

        public string IdCardNumber
        {
            get { return idCardNumber; }
            set { idCardNumber = value; }
        }
        private string dateIdCard;

        public string DateIdCard
        {
            get { return dateIdCard; }
            set { dateIdCard = value; }
        }
        private string placeIdCard;

        public string PlaceIdCard
        {
            get { return placeIdCard; }
            set { placeIdCard = value; }
        }

    }
}


