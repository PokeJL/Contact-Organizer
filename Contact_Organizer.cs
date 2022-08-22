using Models.Models;
using Controller;
using System.Security;
using System.Configuration;
using Controller;
using Models.Models;
using Models.DataAccess;
using Microsoft.IdentityModel.Protocols;
using Microsoft.EntityFrameworkCore;

namespace ICT712_Contact_Organizer
{
    public partial class Contact_Organizer : Form
    {
        string path;
        bool currList;
        bool DBConnect;
        bool error;
        int indexFix;
        Contacts masterContact;
        Contacts tempList;
        DB database;
        public Contact_Organizer()
        {
            InitializeComponent();

            path = string.Empty;
            currList = true;
            DBConnect = false;
            error = false;
            indexFix = 0;
            masterContact = new Contacts();
            tempList = new Contacts();
            database = new DB(ConfigurationManager.ConnectionStrings["ContactsDatabaseConnectionAzure"].ConnectionString);

            object[] search = new object[18];
            search[0] = "None";

            search[1] = "Search for full first name";
            search[2] = "Search for part of first name";
            search[3] = "Search for first name starting with";
            search[4] = "Search for first name ending with";

            search[5] = "Search for full last name";
            search[6] = "Search for part of last name";
            search[7] = "Search for last name starting with";
            search[8] = "Search for last name ending with";

            search[9] = "Search by phone number";
            search[10] = "Search for part of phone number";
            search[11] = "Search by city";
            search[12] = "Search by province";
            search[13] = "Search by organization";

            search[14] = "Search by nickname";
            search[15] = "Search for part of nickname";
            search[16] = "Search for nickname starting with";
            search[17] = "Search for nickname ending with";

            search1CB.Items.AddRange(search);
            search1CB.SelectedIndex = 0;
            search2CB.Items.AddRange(search);
            search2CB.SelectedIndex = 0;

            object[] sort = new object[5];
            sort[0] = "None";
            sort[1] = "Sort by first name";
            sort[2] = "Reverse sort by first name";
            sort[3] = "Sort by last name";
            sort[4] = "Reverse sort by last name";
            sortCB.Items.AddRange(sort);
            sortCB.SelectedIndex = 0;

            orgaddCB.SelectedIndex = 0;
            provaddCB.SelectedIndex = 0;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileOpen();
                updateContactBTN.Enabled = true;
                indexFix = 0;
                DBConnect = false;
                saveToDBToolStripMenuItem.Enabled = false;
                readingFromLBL.Text = "File";
            }
        }

        //Loads data from file
        private void FileOpen()
        {
            SaveFiles saveFiles = new SaveFiles();
            bool fill = true;
            try
            {
                var sr = new StreamReader(openFileDialog1.FileName);
                path = (string.Format("{0}", openFileDialog1.FileName));
                FileInfo fi = new(path);
                sr.Close();
                if (path.EndsWith("encjson"))
                {

                    using (PasswordForm pw = new PasswordForm())
                    {

                        if (pw.ShowDialog() == DialogResult.OK)
                        {
                            masterContact = EncryptedFiles.OpenFile(path, pw.passString);
                            contactBindingSource.DataSource = masterContact;
                        }
                    }
                }
                else
                {
                    masterContact = saveFiles.OpenFile(path);
                    contactBindingSource.DataSource = masterContact;
                }

            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
            }
        }

        private void addConTXT_Click(object sender, EventArgs e)
        {
            if (InfoCheck(emailaddTXT.Text, fnaTXT.Text, lnaTXT.Text, 
                phoneaddTXT.Text, pcaddTXT.Text))
            {
                contactBindingSource.DataSource = masterContact;
                currList = true;
                int count = contactBindingSource.Count + 1;
                var contact = new Contact()
                {
                    Id = masterContact.GenerateID(masterContact),
                    Fname = fnaTXT.Text,
                    Lname = lnaTXT.Text,
                    Nickname = nickaddTXT.Text,
                    Organization = orgaddCB.Text,
                    Address = addressaddTXT.Text,
                    City = cityaddTXT.Text,
                    Province = provaddCB.Text,
                    Phone = phoneaddTXT.Text,
                    Email = emailaddTXT.Text,
                    PostalCode = pcaddTXT.Text,
                    CreatedOn = DateTime.Now,
                    UpdatedOn = DateTime.Now
                };

                if (DBConnect == true)
                {
                    ContactsContext context = new ContactsContext();
                    contact.Id = 0;
                    database.Contacts.Add(contact);
                }
                contactBindingSource.Add(contact);

                orgaddCB.SelectedIndex = 0;
                provaddCB.SelectedIndex = 0;
                fnaTXT.Text = string.Empty;
                lnaTXT.Text = string.Empty;
                nickaddTXT.Text = string.Empty;
                addressaddTXT.Text = string.Empty;
                cityaddTXT.Text = string.Empty;
                phoneaddTXT.Text = string.Empty;
                emailaddTXT.Text = string.Empty;
                pcaddTXT.Text = string.Empty;

                updateContactBTN.Enabled = true;
            }
        }

        private void updateContactBTN_Click(object sender, EventArgs e)
        {
            int index = 0;

            if (InfoCheck(emailTXT.Text, fNameTXT.Text, lNameTXT.Text, 
                phoneTXT.Text, postalCodeTXT.Text))
            {
                index = FindIndex();

                if (currList == false)
                {
                    tempList[indexFix].Fname = fNameTXT.Text;
                    tempList[indexFix].Lname = lNameTXT.Text;
                    tempList[indexFix].Nickname = nicknameTXT.Text;
                    tempList[indexFix].Organization = orgCB.Text;
                    tempList[indexFix].Address = addressTXT.Text;
                    tempList[indexFix].City = cityTXT.Text;
                    tempList[indexFix].Province = provinceCB.Text;
                    tempList[indexFix].Phone = phoneTXT.Text;
                    tempList[indexFix].Email = emailTXT.Text;
                    tempList[indexFix].PostalCode = postalCodeTXT.Text;
                    tempList[indexFix].UpdatedOn = DateTime.Now;
                }

                masterContact[index].Fname = fNameTXT.Text;
                masterContact[index].Lname = lNameTXT.Text;
                masterContact[index].Nickname = nicknameTXT.Text;
                masterContact[index].Organization = orgCB.Text;
                masterContact[index].Address = addressTXT.Text;
                masterContact[index].City = cityTXT.Text;
                masterContact[index].Province = provinceCB.Text;
                masterContact[index].Phone = phoneTXT.Text;
                masterContact[index].Email = emailTXT.Text;
                masterContact[index].PostalCode = postalCodeTXT.Text;
                masterContact[index].UpdatedOn = DateTime.Now;

                if (DBConnect == true)
                {
                    database.Contacts.Update(masterContact[index]);
                }
            }
        }

        private int FindIndex()
        {
            int index = 0;

            if (currList == false)
            {
                for (int i = 0; i < masterContact.Count; i++)
                {
                    if (tempList[indexFix].Id == masterContact[i].Id)
                    {
                        index = i;
                        break;
                    }
                }
            }
            else
            {
                index = indexFix;
            }

            return index;
        }

        private void deleteContactBTN_Click(object sender, EventArgs e)
        {
            int index = FindIndex();
            
            if(currList == false)
            {
                tempList.Remove(tempList[indexFix]);
            }

            if (DBConnect == true)
            {
                database.Contacts.Remove(masterContact[index]);
            }

            masterContact.Remove(masterContact[index]);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = null;
            SaveFiles saveFiles = new SaveFiles();
            saveFileDialog1.Filter = "Binary|*.dat|JSON|*.json|XML|*.xml|Encrypted JSON|*.encjson";

            ActiveForm.BackColor = Color.FromArgb(255, 0, 0, 0);
            ActiveForm.Opacity = .50;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName.EndsWith("encjson"))
                {
                    using (PasswordForm pw = new PasswordForm())
                    {

                        if (pw.ShowDialog() == DialogResult.OK)
                        {
                            EncryptedFiles.SaveFile(masterContact, saveFileDialog1.FileName, pw.passString);
                        }
                    }
                }
                else
                    saveFiles.SaveFile(masterContact, saveFileDialog1.FileName);
            }

            ActiveForm.BackColor = Color.FromArgb(255, 53, 53, 53);
            ActiveForm.Opacity = 1;
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            if (search1CB.SelectedIndex != 0)
            {
                if (search1CB.SelectedIndex == 1)
                    tempList = masterContact.SearchFName(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 2)
                    tempList = masterContact.SearchFNameContains(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 3)
                    tempList = masterContact.SearchFNameStart(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 4)
                    tempList = masterContact.SearchFNameEnds(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 5)
                    tempList = masterContact.SearchLName(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 6)
                    tempList = masterContact.SearchLNameContains(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 7)
                    tempList = masterContact.SearchLNameStart(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 8)
                    tempList = masterContact.SearchLNameEnds(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 9)
                    tempList = masterContact.SearchPhone(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 10)
                    tempList = masterContact.SearchPhoneContains(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 11)
                    tempList = masterContact.SearchCity(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 12)
                    tempList = masterContact.SearchProvince(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 13)
                    tempList = masterContact.SearchOrganization(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 14)
                    tempList = masterContact.SearchNickname(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 15)
                    tempList = masterContact.SearchNicknameContains(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 16)
                    tempList = masterContact.SearchNicknameStart(masterContact, search1TXT.Text);
                else if (search1CB.SelectedIndex == 17)
                    tempList = masterContact.SearchNicknameEnds(masterContact, search1TXT.Text);

                if (search2CB.SelectedIndex != 0)
                {
                    if (search2CB.SelectedIndex == 1)
                        tempList = masterContact.SearchFName(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 2)
                        tempList = masterContact.SearchFNameContains(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 3)
                        tempList = masterContact.SearchFNameStart(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 4)
                        tempList = masterContact.SearchFNameEnds(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 5)
                        tempList = masterContact.SearchLName(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 6)
                        tempList = masterContact.SearchLNameContains(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 7)
                        tempList = masterContact.SearchLNameStart(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 8)
                        tempList = masterContact.SearchLNameEnds(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 9)
                        tempList = masterContact.SearchPhone(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 10)
                        tempList = masterContact.SearchPhoneContains(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 11)
                        tempList = masterContact.SearchCity(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 12)
                        tempList = masterContact.SearchProvince(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 13)
                        tempList = masterContact.SearchOrganization(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 14)
                        tempList = masterContact.SearchNickname(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 15)
                        tempList = masterContact.SearchNicknameContains(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 16)
                        tempList = masterContact.SearchNicknameStart(tempList, search2TXT.Text);
                    else if (search2CB.SelectedIndex == 17)
                        tempList = masterContact.SearchNicknameEnds(tempList, search2TXT.Text);
                }

                if (sortCB.SelectedIndex != 0)
                {
                    if (sortCB.SelectedIndex == 1)
                        tempList = masterContact.SortFNameAcc(tempList);
                    else if (sortCB.SelectedIndex == 2)
                        tempList = masterContact.SortFNameDec(tempList);
                    else if (sortCB.SelectedIndex == 3)
                        tempList = masterContact.SortLNameAcc(tempList);
                    else if (sortCB.SelectedIndex == 4)
                        tempList = masterContact.SortLNameDec(tempList);
                }
            }

            if (sortCB.SelectedIndex != 0 && search1CB.SelectedIndex == 0)
            {
                if (sortCB.SelectedIndex == 1)
                    tempList = masterContact.SortFNameAcc(masterContact);
                else if (sortCB.SelectedIndex == 2)
                    tempList = masterContact.SortFNameDec(masterContact);
                else if (sortCB.SelectedIndex == 3)
                    tempList = masterContact.SortLNameAcc(masterContact);
                else if (sortCB.SelectedIndex == 4)
                    tempList = masterContact.SortLNameDec(masterContact);
            }

            contactBindingSource.DataSource = tempList;
            currList = false;
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            contactBindingSource.DataSource = masterContact;
            currList = true;
        }

        private async void loadFromDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            masterContact.Clear();
            //database.Contacts.ToList().ForEach(n => masterContact.Add(n));

            var data = await database.Contacts.ToListAsync();
            data.ForEach(n => masterContact.Add(n));

            contactBindingSource.DataSource = masterContact;
            DBConnect = true;
            updateContactBTN.Enabled = true;
            saveToDBToolStripMenuItem.Enabled = true;
            readingFromLBL.Text = "Database";
        }

        private void NamesLB_Click(object sender, EventArgs e)
        {
            indexFix = NamesLB.SelectedIndex;
        }

        private async void saveToDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                await database.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
            }
            catch
            {
                MessageBox.Show("An error occured, changes NOT saved to database.");
            }
        }

        private bool InfoCheck(string mail, string fn, string ln, string phone, string postal)
        {
            string errorT = string.Empty;
            bool result = true;

            if(fn.TrimStart().TrimEnd() == string.Empty)
            {
                errorT += "A first name must be entered.\n";
                result = false;
            }

            if (ln.TrimStart().TrimEnd() == string.Empty)
            {
                errorT += "A last name must be entered.\n";
                result = false;
            }

            if (phone != string.Empty)
            {
                PhoneCheck(phone);
                if (error == true)
                {
                    errorT += "Phone number not entered correctly.\n";
                    result = false;
                }
                error = false;
            }

            if (postal != string.Empty)
            {
                PostalCodeCheck(postal);
                if (error == true)
                {
                    errorT += "Postal code is not formatted properly.\n";
                    result = false;
                }
                error = false;
            }

            if (mail != string.Empty)
            {
                EmailCheck(mail);
                if (error == true)
                {
                    errorT += "Email must contain a '@', '.', and 'com' or 'ca'.\n";
                    result = false;
                }
                error = false;
            }

            if (errorT != string.Empty)
                MessageBox.Show(errorT);

            return result;
        }

        private void postalCodeTXT_Leave(object sender, EventArgs e)
        {
            postalCodeTXT.Text = PostalCodeCheck(postalCodeTXT.Text);
            if (error == true)
                postalCodeTXT.BackColor = Color.FromArgb(255, 255, 0, 0);
            error = false;
        }

        private void pcaddTXT_Leave(object sender, EventArgs e)
        {
            pcaddTXT.Text = PostalCodeCheck(pcaddTXT.Text);
            if (error == true)
                pcaddTXT.BackColor = Color.FromArgb(255, 255, 0, 0);
            error = false;
        }

        private void postalCodeTXT_Enter(object sender, EventArgs e)
        {
            postalCodeTXT.BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        private void pcaddTXT_Enter(object sender, EventArgs e)
        {
            pcaddTXT.BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        //Formts postal code to be like F4F 4F4
        private string PostalCodeCheck(string postal)
        {
            string result = postal.TrimStart().TrimEnd().ToLower();

            if (result == string.Empty)
                return result;

            if (result.Length == 6 &&
                System.Text.RegularExpressions.Regex.IsMatch(result,
                       @"[a-z]\d[a-z]\d[a-z]\d") == true) //f4f4f4
            {
                result = result.ToUpper();
                result = result.Substring(0, 3) + " " + result.Substring(3, 3);
            }
            else if (result.Length == 7 &&
                System.Text.RegularExpressions.Regex.IsMatch(result,
                       @"[a-z]\d[a-z]\s\d[a-z]\d") == true) //f4f 4f4
            {
                result = result.ToUpper();
            }
            else
            {
                if (new System.Diagnostics.StackTrace().GetFrame(1).GetMethod().Name != "InfoCheck")
                    MessageBox.Show("Postal code is not formatted properly.");
                error = true;
            }

            return result;
        }

        private void phoneaddTXT_Leave(object sender, EventArgs e)
        {
            phoneaddTXT.Text = PhoneCheck(phoneaddTXT.Text);
            if (error == true)
                phoneaddTXT.BackColor = Color.FromArgb(255, 255, 0, 0);
            error = false;
        }

        private void phoneTXT_Leave(object sender, EventArgs e)
        {
            phoneTXT.Text = PhoneCheck(phoneTXT.Text);
            if (error == true)
                phoneTXT.BackColor = Color.FromArgb(255, 255, 0, 0);
            error = false;
        }

        private void phoneaddTXT_Enter(object sender, EventArgs e)
        {
            phoneaddTXT.BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        private void phoneTXT_Enter(object sender, EventArgs e)
        {
            phoneTXT.BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        //Formats phone number to be like (112) 345-6789
        private string PhoneCheck(string phone)
        {
            string result = phone.TrimStart().TrimEnd();
            string temp = string.Empty;

            if (result == string.Empty)
                return result;

            for (int i = 0; i < result.Length; i++)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(result.Substring(i, 1),
                       @"\d") == true)
                {
                    temp += result.Substring(i, 1);
                }
            }

            if (temp.Length == 10)
            {
                result = "(" + temp.Substring(0, 3) + ")"
                    + " " + temp.Substring(3, 3)
                    + "-" + temp.Substring(6, 4);
            }
            else
            {

                if (new System.Diagnostics.StackTrace().GetFrame(1).GetMethod().Name != "InfoCheck")
                    MessageBox.Show("Phone number not entered correctly.");
                error = true;
            }

            return result;
        }

        private void emailTXT_Leave(object sender, EventArgs e)
        {
            emailTXT.Text = EmailCheck(emailTXT.Text);
            if (error == true)
                emailTXT.BackColor = Color.FromArgb(255, 255, 0, 0);
            error = false;
        }

        private void emailaddTXT_Leave(object sender, EventArgs e)
        {
            emailaddTXT.Text = EmailCheck(emailaddTXT.Text);
            if (error == true)
                emailaddTXT.BackColor = Color.FromArgb(255, 255, 0, 0);
            error = false;
        }

        private void emailaddTXT_Enter(object sender, EventArgs e)
        {
            emailaddTXT.BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        private void emailTXT_Enter(object sender, EventArgs e)
        {
            emailTXT.BackColor = Color.FromKnownColor(KnownColor.Window);
        }

        private string EmailCheck(string mail)
        {
            string result = mail.TrimStart().TrimEnd();

            if (result == string.Empty)
                return result;

            //Regular expression from https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
            if ((
                System.Text.RegularExpressions.Regex.IsMatch(mail,
                       @"^[^@\s]+@[^@\s]+\.com") ||
                System.Text.RegularExpressions.Regex.IsMatch(mail,
                       @"^[^@\s]+@[^@\s]+\.ca")
                )
                == false)
            {
                if (new System.Diagnostics.StackTrace().GetFrame(1).GetMethod().Name != "InfoCheck")
                    MessageBox.Show("Email must contain a '@', '.', and 'com' or 'ca'.");
                error = true;
            }

            return result;
        }

        private void resetAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}