using System;
namespace ListsandLinq
{
    public class Contact
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int number { get; set; }
        public int yearsExperience { get; set; }
        public DateTime birthday { get; set; }


        public string FullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
        }

        public Contact()
        {
        }
    }
}

