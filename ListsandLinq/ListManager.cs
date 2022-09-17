using System;
namespace ListsandLinq
{
    public class ListManager
    {
        public static List<Contact> LoadSampleData
        {
            get
            {
                List<Contact> Output = new List<Contact>();


                Output.Add(new Contact { firstName = "Elijah", lastName = "Amoako", number = 0549554412, birthday = Convert.ToDateTime("14/03/1997"), yearsExperience = 5 });
                Output.Add(new Contact { firstName = "Prince", lastName = "Kwarteng", number = 0540553412, birthday = Convert.ToDateTime("07/02/1996"), yearsExperience = 3 });
                Output.Add(new Contact { firstName = "Felicia", lastName = "Kwarteng", number = 0506754404, birthday = Convert.ToDateTime("20/11/1998"), yearsExperience = 7 });
                Output.Add(new Contact { firstName = "Joshua", lastName = "Asare", number = 0595737592, birthday = Convert.ToDateTime("30/12/1997"), yearsExperience = 15 });
                Output.Add(new Contact { firstName = "Kofi", lastName = "Mushud", number = 0547583445, birthday = Convert.ToDateTime("09/06/1999"), yearsExperience = 17 });
                Output.Add(new Contact { firstName = "Selorm", lastName = "Zane", number = 0244842009, birthday = Convert.ToDateTime("17/08/1998"), yearsExperience = 8 });

                return Output;
            }
        }

        public ListManager()
        {
        }
    }
}

