using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public string SchoolCity { get; set; }
        public string SchoolState { get; set; }
        public string SchoolZip { get; set; }
        public string PhoneNumber { get; set; }
        private string twitterAddress;
        public string TwitterAddress
        {
            // Make sure twitterAddress starts with @
            get { return twitterAddress; }
            set
            {
                if(value.StartsWith("@"))
                {
                    twitterAddress = value;
                }
                else
                {
                    twitterAddress = "NA";
                }
            }
        }

        public School()
        {
            SchoolName = "NA";
            SchoolAddress = "NA";
            SchoolCity = "NA";
            SchoolState = "NA";
            SchoolZip = "NA";
            PhoneNumber = "NA";
            TwitterAddress = "NA";
        }

        public School(string SchoolName, string SchoolAddress, string SchoolCity, string SchoolState, string SchoolZip, string PhoneNumber, string TwitterAddress)
        {
            this.SchoolName = SchoolName;
            this.SchoolAddress = SchoolAddress;
            this.SchoolCity = SchoolCity;
            this.SchoolState = SchoolState;
            this.SchoolZip = SchoolZip;
            this.PhoneNumber = PhoneNumber;
            this.TwitterAddress = TwitterAddress;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(SchoolName);
            sb.AppendLine(SchoolAddress);
            sb.AppendLine(SchoolCity);
            sb.AppendLine(SchoolState);
            sb.AppendLine(SchoolZip);
            sb.AppendLine(PhoneNumber);
            sb.AppendLine(TwitterAddress);

            return sb.ToString();
        }
    }
}
