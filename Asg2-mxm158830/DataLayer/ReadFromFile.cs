using Asg2_mxm158830.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//This class contains function to read from a file and return a list of persons in the file
namespace Asg2_mxm158830.DataLayer
{
    class ReadFromFile
    {
        public List<Person> ReadPersonsFromFile()
        {
            
            string line;
            List < Person > pers= new List<Person>();
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"CS6326Asg2.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split('\t');
                Person person = new Person();
                
                person.Firstname = words[0];
                person.Lname = words[1];
                person.Middleinitial = words[2];
                person.AddressLine1 = words[3];
                person.AddressLine2 = words[4];
                person.City = words[5];
                person.State = words[6];
                person.Zipcode = words[7];
                person.Phonenumber = words[8];
                person.Emailid = words[9];
                person.Proof = words[10];
                person.DateRecieved = DateTime.Parse(words[11]);
                pers.Add(person);


            }
            
            file.Close();
            return pers;
           
        }
    }
}
