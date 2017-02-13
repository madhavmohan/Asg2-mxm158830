using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using Asg2_mxm158830.DL;
using Asg2_mxm158830.UILayer;

namespace Asg2_mxm158830
{
    public partial class frmrebateprocessing : Form
    {
        //the list of persons variable that hold the list of persons in the application
        List<Person> persons = new List<Person>();
        private ListViewColumnSorter lvwColumnSorter;
        int lstviewselindex;
        //the start time variable activated in add mode.
        // 1 for add mode, 2 for modify mode, 3 for delete mode
        int mode;
        DateTime starttime = new DateTime();
        DateTime endtime = new DateTime();
        public frmrebateprocessing()
        {
            InitializeComponent();
            // Create an instance of a ListView column sorter and assign it 
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.listviewpersons.ListViewItemSorter = lvwColumnSorter;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            CenterToScreen();
            Person person = new Person();
            toolStripStatusLabel1.Text = "Add Mode";
            mode = 1;
            
            foreach (Person person1 in person.ReadPersonsFromFileIntoList())
            {
                persons.Add(person1);
                
                String fullname = person1.Firstname + " " + person1.Middleinitial + " " + person1.Lname;
                string[] row = { fullname, person1.Phonenumber };

                var listviewitem = new ListViewItem(row);
                listviewpersons.Items.Add(listviewitem);
                listviewpersons.Refresh();

            }
           
           

        }
       
        
        //Field level validations
        private Boolean CheckforValidationsForName( System.Windows.Forms.TextBox txtbox)
        {
            Person person = new Person();
            
            try
            {
               //person level rules
                if ((person.checkNameNotBlankRule(txtbox.Text)))
                {
                    errprovidervalidation.SetError(txtbox, "Please enter a value, the name cannot be blank");
                    txtbox.BackColor = Color.Pink;
                    return false;

                }
                else if ((person.CheckNoNumberAndSpecialsRuleForName(txtbox.Text)))
                {
                    errprovidervalidation.SetError(txtbox, "Please do not enter numbers or special characters in your name");
                    txtbox.BackColor = Color.Pink;
                    return false;
                }
                else
                {
                    errprovidervalidation.SetError(txtbox, "");
                    txtbox.BackColor = Color.White;
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Field level validations
        private Boolean CheckforMiddleInitial()
        {
            Person person = new Person();
            try
            {
                String middleintial = txtboxmiddleinitial.Text;
                //Check for special characters only
                if ((person.CheckforMidleInitNoNumAndSpecialsRule(middleintial))){
                    errprovidervalidation.SetError(txtboxmiddleinitial, "Please do not enter numbers or special characters in your name");
                    txtboxmiddleinitial.BackColor = Color.Pink;
                    return false;
                }else
                {
                    errprovidervalidation.SetError(txtboxmiddleinitial, "");
                    txtboxmiddleinitial.BackColor = Color.Yellow;
                    return true;
                }


            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private void txtboxfname_TextChanged(object sender, EventArgs e)
        {
            CheckforValidationsForName(txtboxfname);
            
        }
        private void txtboxfname_Validating(object sender, CancelEventArgs e)
        {
            
            CheckforValidationsForName(txtboxfname);


        }
        //Field level validations
        private Boolean CheckforAddressLine1()
        {
            Person person = new Person();
            try
            {
                String addressline1 = txtboxaddressline1.Text;



               
                if ((person.CheckforAddressLine1Rules(addressline1)))
                {
                    errprovidervalidation.SetError(txtboxaddressline1, "Please enter a value, the Address line 1 cannot be blank");
                    txtboxaddressline1.BackColor = Color.Pink;
                    return false;
                }
                else
                {
                    errprovidervalidation.SetError(txtboxaddressline1, "");
                    txtboxaddressline1.BackColor = Color.White;
                    return true;
                }


            }
            catch (Exception ex)
            {
                return false;
            }

        }
        private Boolean CheckforAddressLine2()
        {
            Person person = new Person();
            person.CheckforAdressLine2Rules();return true;

        }
        //Field level validations
        private Boolean CheckforCity()
        {
            //In case of key change the blank values need to be validated on the fly.
            //The following are validated: 
            //1. Blank values 
            //2. If the field contains special characters or numbers, which are not possible in a name.
            try
            {
                String city = txtboxcity.Text;

                Person person = new Person();
               
                if ((person.CheckforCityBlankRule(city)))
                {
                    errprovidervalidation.SetError(txtboxcity, "Please enter a value, the city cannot be blank");
                    txtboxcity.BackColor = Color.Pink;
                    return false;
                }
                else if ((person.CheckforCityNoNumberAndSpecials(city)))
                {
                    errprovidervalidation.SetError(txtboxcity, "Please do not enter numbers or special characters in your city");
                    txtboxcity.BackColor = Color.Pink;
                    return false;
                }
                else
                {
                    errprovidervalidation.SetError(txtboxcity, "");
                    txtboxcity.BackColor = Color.White;
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Field level validations
        private Boolean CheckforState()
        {
            Person person = new Person();
            try
            {
                String state = comboboxstate.Text;
                if ((person.CheckForStateBlankRule(state)) || person.CheckForStateOneCharacter(state))
                {
                    errprovidervalidation.SetError(comboboxstate, "Please enter a value, the state cannot be blank or single character");
                    comboboxstate.BackColor = Color.Pink;
                    return false;

                }else
                {
                    errprovidervalidation.SetError(comboboxstate, "");
                    comboboxstate.BackColor = Color.White;
                    return true;
                }
            }catch(Exception ex){
                return false;

            }

            
        }

        //Field level validations
        private Boolean CheckforZipcode()
        {
            Person person = new Person();
            try
            {
                String zip = txtboxzipcode.Text;
                
                if ((person.CheckForBlankZipRule(zip)))
                {
                    errprovidervalidation.SetError(txtboxzipcode, "Please enter a value, the zip cannot be blank");
                    txtboxzipcode.BackColor = Color.Pink;
                    return false;

                }else if ((person.CheckZipNoAlphabetsAndSpecialRule(zip)))
                {
                    errprovidervalidation.SetError(txtboxzipcode, "Please do not enter alphabets or special characters in your zip");
                    txtboxzipcode.BackColor = Color.Pink;
                    return false;
                }
                else
                {
                    errprovidervalidation.SetError(txtboxzipcode, "");
                    txtboxzipcode.BackColor = Color.White;
                    return true;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        //Field level validations
        private Boolean CheckforPhoneNumber()
        {
            Person person = new Person();
            try
            {
                String phonenum = txtboxphonenumber.Text;
                
                if ((person.CheckforBlankPhonenumberRule(phonenum)))
                {
                    errprovidervalidation.SetError(txtboxphonenumber, "Please enter a value, the phone number cannot be blank");
                    txtboxphonenumber.BackColor = Color.Pink;
                    return false;
                }else if ((person.CheckForPhoneNumberRule(phonenum)))
                {
                    errprovidervalidation.SetError(txtboxphonenumber, "Please do not enter alphabets or special characters in your phone number");
                    txtboxphonenumber.BackColor = Color.Pink;
                    return false;
                }else
                {
                    errprovidervalidation.SetError(txtboxphonenumber, "");
                    txtboxphonenumber.BackColor = Color.White;
                    return true;
                }
            }catch(Exception ex)
            {
                return false;
            }
        }

        //Field level validations
        private Boolean CheckforEmail()
        {
            Person person = new Person();
            try
            {
                String email = txtboxemail.Text;
                
                if ((person.CheckForEmailBlankRule(email)))
                {
                    errprovidervalidation.SetError(txtboxemail, "Please enter a value, the email id cannot be blank");
                    txtboxemail.BackColor = Color.Pink;
                    return false;
                }else if (!(person.CheckForEmailRule(email)))
                {
                    errprovidervalidation.SetError(txtboxemail, "Please check for email structure.");
                    txtboxemail.BackColor = Color.Pink;
                    return false;
                }else
                {
                    errprovidervalidation.SetError(txtboxemail, "");
                    txtboxemail.BackColor = Color.White;
                    return true;
                }
                

            }catch (Exception ex)
            {
                return false;
            }
        }

        //Field level validations
        private Boolean CheckforProof()
        {
            Person person = new Person();
            try
            {
                String proof = comboboxproof.Text;
                if ((person.CheckForProofBlankRule(proof)))
                {
                    errprovidervalidation.SetError(comboboxproof, "Please enter a value, the proof cannot be blank");
                    comboboxproof.BackColor = Color.Pink;
                    return false;
                }
                else
                {
                    errprovidervalidation.SetError(comboboxproof, "");
                    comboboxproof.BackColor = Color.White;
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        private void txtboxlname_TextChanged(object sender, EventArgs e)
        {
            CheckforValidationsForName(txtboxlname);
        }

        private void txtboxlname_Validating(object sender, CancelEventArgs e)
        {
            CheckforValidationsForName(txtboxlname);
        }

        private void txtboxmiddleinitial_TextChanged(object sender, EventArgs e)
        {
            CheckforMiddleInitial();
        }

        private void txtboxaddressline1_TextChanged(object sender, EventArgs e)
        {
            CheckforAddressLine1();
        }

        private void txtboxaddressline1_Validating(object sender, CancelEventArgs e)
        {
            CheckforAddressLine1();
        }

        private void txtboxaddressline2_TextChanged(object sender, EventArgs e)
        {
            CheckforAddressLine2();
        }



        private void txtboxaddressline2_Validating(object sender, CancelEventArgs e)
        {
            CheckforAddressLine2();
        }

        private void txtboxcity_TextChanged(object sender, EventArgs e)
        {
            CheckforCity();
        }

  
        private void txtboxcity_Validating(object sender, CancelEventArgs e)
        {
            CheckforCity();
        }

        private void comboboxstate_Validating(object sender, CancelEventArgs e)
        {
            CheckforState();
        }



        private void comboboxstate_TextChanged(object sender, EventArgs e)
        {
            CheckforState();
        }

        private void comboboxstate_KeyDown(object sender, KeyEventArgs e)
        {
            comboboxstate.DroppedDown = false;
        }

        private void txtboxzipcode_Validating(object sender, CancelEventArgs e)
        {
            CheckforZipcode();
        }

        private void txtboxzipcode_TextChanged(object sender, EventArgs e)
        {
            CheckforZipcode();
        }

        private void lbphonenumber_Click(object sender, EventArgs e)
        {

        }

        private void txtboxphonenumber_TextChanged(object sender, EventArgs e)
        {
            CheckforPhoneNumber();
        }

        private void txtboxphonenumber_Validating(object sender, CancelEventArgs e)
        {
            CheckforPhoneNumber();
        }

        private void txtboxemail_TextChanged(object sender, EventArgs e)
        {
            CheckforEmail();
        }

        private void txtboxemail_Validating(object sender, CancelEventArgs e)
        {
            CheckforEmail();
        }

        private void lbllname_Click(object sender, EventArgs e)
        {

        }

        private void lblmiddleinitial_Click(object sender, EventArgs e)
        {

        }

        private void lbladdressline1_Click(object sender, EventArgs e)
        {

        }

        private void lbladdressline2_Click(object sender, EventArgs e)
        {

        }

        private void lblcity_Click(object sender, EventArgs e)
        {

        }

        private void lblstate_Click(object sender, EventArgs e)
        {

        }

        private void lblzipcode_Click(object sender, EventArgs e)
        {

        }

        private void lblfirstname_Click(object sender, EventArgs e)
        {

        }

        private void comboboxproof_KeyDown(object sender, KeyEventArgs e)
        {
            comboboxproof.DroppedDown = false;
        }

        private void comboboxproof_Validating(object sender, CancelEventArgs e)
        {
            CheckforProof();
        }

        private void comboboxproof_TextChanged(object sender, EventArgs e)
        {
            CheckforProof();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {



        }
        //This function is to reset text boxes after the add or modification.
        private void ResetTextBoxes()
        {
            txtboxfname.Text = "";
            txtboxlname.Text = "";
            txtboxmiddleinitial.Text = "";
            txtboxaddressline1.Text = "";
            txtboxaddressline2.Text = "";
            txtboxcity.Text = "";
            txtboxzipcode.Text = "";
            txtboxphonenumber.Text = "";
            txtboxemail.Text = "";
            errprovidervalidation.SetError(txtboxfname, "");
            txtboxfname.BackColor = Color.White;
            errprovidervalidation.SetError(txtboxlname, "");
            txtboxlname.BackColor = Color.White;
            errprovidervalidation.SetError(txtboxmiddleinitial, "");
            txtboxmiddleinitial.BackColor = Color.White;
            errprovidervalidation.SetError(txtboxaddressline1, "");
            txtboxaddressline1.BackColor = Color.White;
            errprovidervalidation.SetError(txtboxaddressline2, "");
            txtboxaddressline2.BackColor = Color.White;
            errprovidervalidation.SetError(txtboxcity, "");
            txtboxcity.BackColor = Color.White;
            errprovidervalidation.SetError(txtboxzipcode, "");
            txtboxzipcode.BackColor = Color.White;
            errprovidervalidation.SetError(txtboxphonenumber, "");
            txtboxphonenumber.BackColor = Color.White;
            errprovidervalidation.SetError(txtboxemail, "");
            txtboxemail.BackColor = Color.White;




        }
        private void ResetComboboxes()
        {
            comboboxstate.Text = "";
            errprovidervalidation.SetError(comboboxstate, "");
            comboboxstate.BackColor = Color.White;
            comboboxproof.Text = "";
            errprovidervalidation.SetError(comboboxproof, "");
            comboboxproof.BackColor = Color.White;


        }
        //This function resets after adding/modifying is done.
        private void ResetAllTextBoxesAndStatusFlags()
        {
            ResetTextBoxes();
            ResetComboboxes();
            datetimepicker1.ResetText();
        }
        private void comboboxstate_TextUpdate(object sender, EventArgs e)
        {

            int i;
            if (comboboxstate.Text.Length == 2) {
                if (comboboxstate.Items.Contains((comboboxstate.Text.ToUpper())))
                {
                    for (i = 0; i < comboboxstate.Items.Count; i++)
                    {
                        string temp = comboboxstate.Text.ToUpper();
                        if (temp.Equals((string)(comboboxstate.Items[i])))
                        {
                            comboboxstate.Text = (String)comboboxstate.Items[i];
                        }

                    }

                }
                else
                {
                    comboboxstate.Text = "";
                }
            }
            

        }

        private void comboboxproof_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //This function is to make sure that combobox does not contain junk values.
        private void comboboxproof_TextUpdate(object sender, EventArgs e)
        {
            int i;
          

            if (comboboxproof.Text.Length ==3)
            {
                if (comboboxproof.Items.Contains((comboboxproof.Text.ToUpper())))
                {
                    for (i = 0; i < comboboxproof.Items.Count; i++)
                    {
                        string temp = comboboxproof.Text.ToUpper();
                        if (temp.Equals((string)(comboboxproof.Items[i])))
                        {
                            comboboxproof.Text = (String)comboboxproof.Items[i];
                        }

                    }

                }
                else
                {
                    comboboxproof.Text = "";
                }
            }


        }

        //Function to add values into the file

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            //Note down the time used up.
            endtime = DateTime.Now;
            //Verify all validations 
            
            Person person = new Person();
            if (CheckforAddressLine1() && CheckforAddressLine2() && CheckforCity() && CheckforEmail() && CheckforMiddleInitial()
                && CheckforPhoneNumber() && CheckforProof() && CheckforState() && CheckforValidationsForName(txtboxlname) && CheckforValidationsForName(txtboxfname)
                && CheckforZipcode())
            {
                if (person.CheckFnameLnameMiddle(txtboxfname.Text, txtboxlname.Text, txtboxmiddleinitial.Text,persons))
                {
                    
                    Person person1 = new Person(txtboxfname.Text, txtboxlname.Text,txtboxmiddleinitial.Text, txtboxaddressline1.Text, txtboxaddressline2.Text,txtboxcity.Text,
                                            (string)comboboxstate.Items[comboboxstate.SelectedIndex], txtboxzipcode.Text, txtboxphonenumber.Text, txtboxemail.Text, comboboxproof.Text, datetimepicker1.Value,
                                            starttime, endtime);
                    ListViewItem item = new ListViewItem();
                    String fullname=person1.Firstname + " " + person1.Middleinitial + " " + person1.Lname;
                    string[] row = { fullname, person1.Phonenumber };
                    
                    var listviewitem = new ListViewItem(row);
                    listviewpersons.Items.Add(listviewitem);
                    listviewpersons.Refresh();
                    persons.Add(person1);
                    //Add the persons list into the file. 
                    // Use the add method in the person class to add the full list into the file 
                    person1.addPersons(persons);
                    txtboxresponses.BackColor = Color.Green;
                    String starttimehour = person1.StartTime.Hour.ToString();
                    String starttimeminute = person1.StartTime.Minute.ToString();
                    String starttimesecond = person1.StartTime.Second.ToString();

                    String endtimehour = person1.EndTime.Hour.ToString();
                    String endtimeminute = person1.EndTime.Minute.ToString();
                    String endtimesecond = person1.EndTime.Second.ToString();
                    txtboxresponses.Text = "You Successfully added, " + "Start Time: " +
                        starttimehour + ":" + starttimeminute + ":" + starttimesecond + 
                        " End Time: " + endtimehour + ":" + endtimeminute + ":" + endtimesecond;
                    //Reset all text boxes after successful addition into the file
                    ResetAllTextBoxesAndStatusFlags();
                    GetCursorBackToFirstField();
                    mode = 1;
                    toolStripStatusLabel1.Text = "Add Mode";

                }
                else
                {
                    txtboxresponses.BackColor = Color.Red;
                    txtboxresponses.Text = "The person is already present";


                }
            }
            else
            {
                //If add failed, keep all values to enter again and display correct this time around
                txtboxresponses.BackColor = Color.Red;
                txtboxresponses.Text = "Please validate the data again"  ;


            }
        }

        private void GetCursorBackToFirstField()
        {
            txtboxfname.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //The date time is noted when key is pressed
        private void txtboxfname_KeyUp(object sender, KeyEventArgs e)
        {
            starttime = DateTime.Now;
        }

        private void listviewpersons_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listviewpersons.Sort();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Note down the time used up.
            endtime = DateTime.Now;
            //Verify all validations 

            Person person = new Person();
            if (listviewpersons.SelectedItems.Count > 0)
            {
                if (CheckforAddressLine1() && CheckforAddressLine2() && CheckforCity() && CheckforEmail() && CheckforMiddleInitial()
                && CheckforPhoneNumber() && CheckforProof() && CheckforState() && CheckforValidationsForName(txtboxlname) && CheckforValidationsForName(txtboxfname)
                && CheckforZipcode())
                {
                    if (person.CheckFnameLnameMiddle(txtboxfname.Text, txtboxlname.Text, txtboxmiddleinitial.Text, persons))
                    {

                        Person person1 = new Person(txtboxfname.Text, txtboxlname.Text, txtboxmiddleinitial.Text, txtboxaddressline1.Text, txtboxaddressline2.Text, txtboxcity.Text,
                                                (string)comboboxstate.Items[comboboxstate.SelectedIndex], txtboxzipcode.Text, txtboxphonenumber.Text, txtboxemail.Text, comboboxproof.Text, datetimepicker1.Value,
                                                starttime, endtime);
                        ListViewItem item = new ListViewItem();
                        String fullname = person1.Firstname + " " + person1.Middleinitial + " " + person1.Lname;
                        string[] row = { fullname, person1.Phonenumber };

                        var listviewitem = new ListViewItem(row);
                        //remove old item and append new item

                        listviewpersons.Items.RemoveAt(lstviewselindex);
                        listviewpersons.Refresh();
                        listviewpersons.Items.Add(listviewitem);
                        listviewpersons.Refresh();
                        persons.RemoveAt(lstviewselindex);
                        persons.Add(person1);
                        //Add the persons list into the file. 
                        // Use the add method in the person class to add the full list into the file 
                        person1.addPersons(persons);
                        txtboxresponses.BackColor = Color.Green;
                        txtboxresponses.Text = "You Successfully modified";
                        //Reset all text boxes after successful modification into the file
                        ResetAllTextBoxesAndStatusFlags();
                        GetCursorBackToFirstField();
                        //Change mode to add 
                        mode = 1;
                        toolStripStatusLabel1.Text = "Add Mode";

                    }
                    else
                    {
                        txtboxresponses.BackColor = Color.Red;
                        txtboxresponses.Text = "The person is already present";


                    }
                }
                else
                {
                    //If add failed, keep all values to enter again and display correct this time around
                    txtboxresponses.BackColor = Color.Red;
                    txtboxresponses.Text = "Please validate the data again";


                }
            }
            else
            {
                //If add failed, keep all values to enter again and display correct this time around
                txtboxresponses.BackColor = Color.Red;
                txtboxresponses.Text = "Cannot Modify, No item selected";
            }
        }

        private void listviewpersons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void StoreAllvaluesForModDeletion()
        {
            Person person = persons[lstviewselindex];
            listviewpersons.Refresh();
            txtboxfname.Text = person.Firstname;
            txtboxfname.Refresh();
            txtboxlname.Text = person.Lname;
            txtboxlname.Refresh();
            txtboxmiddleinitial.Text = person.Middleinitial;
            txtboxmiddleinitial.Refresh();
            txtboxaddressline1.Text = person.AddressLine1;
            txtboxaddressline1.Refresh();
            txtboxaddressline2.Text = person.AddressLine2;
            txtboxaddressline2.Refresh();
            txtboxcity.Text = person.City;
            txtboxcity.Refresh();
            comboboxstate.Text = person.State;
            comboboxstate.Refresh();
            txtboxzipcode.Text = person.Zipcode;
            txtboxzipcode.Refresh();
            txtboxphonenumber.Text = person.Phonenumber;
            txtboxphonenumber.Refresh();
            txtboxemail.Text = person.Emailid;
            txtboxemail.Refresh();
            comboboxproof.Text = person.Proof;
            datetimepicker1.Value = person.DateRecieved;
            datetimepicker1.Refresh();

        }

        private void listviewpersons_MouseClick(object sender, MouseEventArgs e)
        {
            if (listviewpersons.SelectedItems.Count > 0)
            {
                
                lstviewselindex =listviewpersons.Items.IndexOf( listviewpersons.SelectedItems[0]);
                mode = 2;
                toolStripStatusLabel1.Text = "Modification/Deletion";
                StoreAllvaluesForModDeletion();

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            Person person1 = new Person();
            if (listviewpersons.SelectedItems.Count > 0)
            {
                listviewpersons.Items.RemoveAt(lstviewselindex);
                listviewpersons.Refresh();
                persons.RemoveAt(lstviewselindex);
                person1.addPersons(persons);
                ResetAllTextBoxesAndStatusFlags();
                GetCursorBackToFirstField();
                txtboxresponses.Text = "Successfully Deleted";
                txtboxresponses.BackColor = Color.Green;
                //Change mode to add 
                mode = 1;
                toolStripStatusLabel1.Text = "Add Mode";
            }
            else
            {
                //If add failed, keep all values to enter again and display correct this time around
                txtboxresponses.BackColor = Color.Red;
                txtboxresponses.Text = "Cannot Delete, No item selected";
            }
                
        }
    }

}
