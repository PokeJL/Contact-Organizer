using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT712_Contact_Organizer
{
    public partial class PasswordForm : Form
    {
        public string passString;
        public PasswordForm()
        {
            InitializeComponent();
            InitializeMyControl();
            passString = string.Empty;
        }


        //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-create-a-password-text-box-with-the-windows-forms-textbox-control?view=netframeworkdesktop-4.8
        private void InitializeMyControl()
        {
            // Set to no text.
            passwordTXT.Text = "";
            // The password character is an asterisk.
            passwordTXT.PasswordChar = '*';
        }

        private void showPassCHB_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCHB.Checked == false)
                passwordTXT.PasswordChar = '*';
            else
                passwordTXT.PasswordChar = '\0';
        }

        private void okayBTN_Click(object sender, EventArgs e)
        {
            passString = passwordTXT.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
