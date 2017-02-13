using Asg2_mxm158830.BLL;
using Asg2_mxm158830.DataLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Asg2_mxm158830.DL
{
   public class Person
    {
        String firstname;
        String lastname;
        String middleinitial;
        String addressline1;
        String addressline2;
        String city;
        String state;
        String zipcode;
        String phonenumber;
        String emailid;
        String proof;
        DateTime daterecieved;
        DateTime starttime;
        DateTime endtime;
        
        
        public String Firstname
        {
            get
            {
               return firstname ;
            }
            set
            {
                firstname = value;
            }
           
            
        }
        public String Lname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }


        }

        internal void ReadPersonsIntoList()
        {
            throw new NotImplementedException();
        }

        public String Middleinitial
        {
            get
            {
                return middleinitial;
            }
            set
            {
                middleinitial = value;
            }


        }
        public string Phonenumber
        {
            get
            {
                return phonenumber;

            }
            set
            {
                phonenumber = value;
            }
        }
        public string AddressLine1
        {
            get
            {
                return addressline1;

            }
            set
            {
                addressline1 = value;
            }
        }
        public string AddressLine2
        {
            get
            {
                return addressline2;

            }
            set
            {
                addressline2 = value;
            }
        }
        public string City
        {
            get
            {
                return city;

            }
            set
            {
                city = value;
            }
        }
        public string State
        {
            get
            {
                return state;

            }
            set
            {
                state = value;
            }
        }
        public string Zipcode
        {
            get
            {
                return zipcode;

            }
            set
            {
                zipcode = value;
            }
        }
        public string Emailid
        {
            get
            {
                return emailid;

            }
            set
            {
                emailid = value;
            }
        }
        public string Proof
        {
            get
            {
                return proof;

            }
            set
            {
                proof = value;
            }
        }
        public DateTime DateRecieved
        {
            get
            {
                return daterecieved;

            }
            set
            {
                daterecieved = value;
            }
        }
        public DateTime StartTime
        {
            get
            {
                return starttime;
            }
            set
            {
                starttime = value;
            }
        }
        public DateTime EndTime
        {
            get
            {
                return endtime;
            }
            set
            {
                endtime = value;
            }
        }
        public Person()
        {

        }
        public Person(string fname,string lname,string middleinitial, string addressline1, string addressline2, string city, 
            string state, string zipcode, string phonenumber, string emailid, string proof, DateTime daterecieved,
            DateTime starttime, DateTime endtime)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.middleinitial = middleinitial;
            this.addressline1 = addressline1;
            this.addressline2 = addressline2;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.phonenumber = phonenumber;
            this.emailid = emailid;
            this.proof = proof;
            this.daterecieved = daterecieved;
            this.starttime = starttime;
            this.endtime = endtime;
            


        }

        public Boolean CheckNoNumberAndSpecialsRuleForName(String name)
        {
            //In case of key change the blank values need to be validated on the fly.
            //The following are validated: 
            //1. Blank values 
            //2. If the field contains special characters or numbers, which are not possible in a name.
            String fname = name;
            String pat = "^([^0-9]*)$";

            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(pat, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Match m = r.Match(fname);
         
            if (!m.Success || name.Contains("@") || name.Contains("|"))
            {
                return true ;
            }
            else
            {
                return false;
            }


        }

        public Boolean checkNameNotBlankRule(string name)
        {
            //Check if the value in the text box is nil
            String fname = name;
            if (fname == "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean CheckforMidleInitNoNumAndSpecialsRule(string middleinitial)
        {
            

            String pat = "^([^0-9]*)$";

            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(pat, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Match m = r.Match(middleinitial);
            if (!m.Success || middleinitial.Contains("@") || middleinitial.Contains("|"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean CheckforAddressLine1Rules(string addressline1)
        {
            if (addressline1 == "")
            {
                return true;

            }else
            {
                return false;
            }
        }

        public void CheckforAdressLine2Rules()
        {
            
        }
  

        public bool CheckforCityBlankRule(string city)
        {
            if (city == "")
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        public bool CheckforCityNoNumberAndSpecials(string city)
        {
            String pat = "^([^0-9]*)$";

            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(pat, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Match m = r.Match(city);
            if (!m.Success || city.Contains("@") || city.Contains("|"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean CheckForStateBlankRule(string state)
        {
            if (state == "")
            {
                return true;
            }else
            {
                return false;
            }
        }

        public Boolean CheckZipNoAlphabetsAndSpecialRule(String zip)
        {
            String pat = "^([^a-z]*[^A-Z]*)$";
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(pat, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Match m = r.Match(zip);
            if (!m.Success || zip.Contains("@") || zip.Contains("|"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckForStateOneCharacter(string state)
        {
            if (state.Length == 1)
            { return true;
            }else
                return false;
        }

        public Boolean CheckForBlankZipRule(String zip)
        {
            if (zip == "")
            {
                return true;
            }else
            {
                return false;
            }
        }

        public Boolean CheckForPhoneNumberRule(String phonenum)
        {
            String pat = "^([^a-z]*[^A-Z]*)$";
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(pat, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            Match m = r.Match(phonenum);
            if (!m.Success || phonenum.Contains("@") || phonenum.Contains("|"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Boolean CheckforBlankPhonenumberRule(String phonenum)
        {
            if (phonenum == "")
                return true;
            else
                return false;
        }
        public Boolean CheckForEmailBlankRule(String email)
        {
            if (email == "")
            {
                return true;
            }else
            {
                return false;
            }
        }
        public Boolean CheckForEmailRule(String email)
        {
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            return isEmail;
        }
        public Boolean CheckForProofBlankRule(String proof)
        {
            if (proof == "")
            {
                return true;
            }else
            {
                return false;
            }
        }

        public Boolean CheckFnameLnameMiddle(string fname, string lname, string middleinitial,List<Person> persons)
        {
           foreach (Person person1 in persons)
            {
                if ((person1.Firstname.ToUpper().Equals(fname.ToUpper())) && (person1.Lname.ToUpper().Equals(lname.ToUpper())) && (person1.Middleinitial.ToUpper().Equals(middleinitial.ToUpper())))
                {
                    return false;
                }

            }
            return true;
        }
        public List<Person> ReadPersonsFromFileIntoList()
        {
            List<Person> persons = new List<Person>();
            ReadFromFile rf = new ReadFromFile();
            persons = rf.ReadPersonsFromFile();
            return persons;
        }
        public Boolean addPersons(List<Person> persons)
        {
            //Program to write the list into the file.
            //Write a function to get the attributes in the form of tab and person attributes. 
            WriteIntoFile wf = new WriteIntoFile();
            wf.WritePersonsListIntoFile(persons);
            return true;
        }
    }
}
