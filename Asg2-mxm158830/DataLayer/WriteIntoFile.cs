using Asg2_mxm158830.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg2_mxm158830.BLL
{
    class WriteIntoFile
    {
        //This class contains function to write a person into a file.
        public void WritePersonsListIntoFile(List<Person> persons)
        {

            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"CS6326Asg2.txt"))
            {
                foreach (Person person1 in persons)
                {

                    String daterec = person1.DateRecieved.ToString();
                    String starttimehour = person1.StartTime.Hour.ToString();
                    String starttimeminute = person1.StartTime.Minute.ToString();
                    String starttimesecond = person1.StartTime.Second.ToString();

                    String endtimehour = person1.EndTime.Hour.ToString();
                    String endtimeminute = person1.EndTime.Minute.ToString();
                    String endtimesecond = person1.EndTime.Second.ToString();

                    String line = string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t {12}:{13}:{14}\t{15}:{16}:{17}"
                        , person1.Firstname ,person1.Lname ,person1.Middleinitial, person1.AddressLine1,
                        person1.AddressLine2, person1.City, person1.State, person1.Zipcode,person1.Phonenumber, person1.Emailid,
                        person1.Proof, daterec,starttimehour,starttimeminute,starttimesecond,endtimehour,endtimeminute,endtimesecond);


                    file.WriteLine(line);
                }
                
            }
        }
    }
}
