namespace ICT712_Contact_Organizer
{
    partial class Contact_Organizer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuMS = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabsTC = new System.Windows.Forms.TabControl();
            this.View = new System.Windows.Forms.TabPage();
            this.infoTXT = new System.Windows.Forms.TextBox();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Update = new System.Windows.Forms.TabPage();
            this.provinceCB = new System.Windows.Forms.ComboBox();
            this.postalCodeTXT = new System.Windows.Forms.TextBox();
            this.postalCodeLBL = new System.Windows.Forms.Label();
            this.orgCB = new System.Windows.Forms.ComboBox();
            this.emailLBL = new System.Windows.Forms.Label();
            this.phoneLBL = new System.Windows.Forms.Label();
            this.provinceLBL = new System.Windows.Forms.Label();
            this.cityLBL = new System.Windows.Forms.Label();
            this.addressLBL = new System.Windows.Forms.Label();
            this.organizationLBL = new System.Windows.Forms.Label();
            this.nicknameLBL = new System.Windows.Forms.Label();
            this.lNameLBL = new System.Windows.Forms.Label();
            this.fNmaeLBL = new System.Windows.Forms.Label();
            this.updateContactBTN = new System.Windows.Forms.Button();
            this.emailTXT = new System.Windows.Forms.TextBox();
            this.phoneTXT = new System.Windows.Forms.TextBox();
            this.cityTXT = new System.Windows.Forms.TextBox();
            this.addressTXT = new System.Windows.Forms.TextBox();
            this.nicknameTXT = new System.Windows.Forms.TextBox();
            this.lNameTXT = new System.Windows.Forms.TextBox();
            this.fNameTXT = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.TabPage();
            this.searchT2LBL = new System.Windows.Forms.Label();
            this.searchT1LBL = new System.Windows.Forms.Label();
            this.sortCB = new System.Windows.Forms.ComboBox();
            this.sortLBL = new System.Windows.Forms.Label();
            this.search2TXT = new System.Windows.Forms.TextBox();
            this.search2CB = new System.Windows.Forms.ComboBox();
            this.search2LBL = new System.Windows.Forms.Label();
            this.search1LBL = new System.Windows.Forms.Label();
            this.resetBTN = new System.Windows.Forms.Button();
            this.searchBTN = new System.Windows.Forms.Button();
            this.search1TXT = new System.Windows.Forms.TextBox();
            this.search1CB = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.TabPage();
            this.provaddCB = new System.Windows.Forms.ComboBox();
            this.pcaddTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orgaddCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addConTXT = new System.Windows.Forms.Button();
            this.emailaddTXT = new System.Windows.Forms.TextBox();
            this.phoneaddTXT = new System.Windows.Forms.TextBox();
            this.cityaddTXT = new System.Windows.Forms.TextBox();
            this.addressaddTXT = new System.Windows.Forms.TextBox();
            this.nickaddTXT = new System.Windows.Forms.TextBox();
            this.lnaTXT = new System.Windows.Forms.TextBox();
            this.fnaTXT = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.NamesLB = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deleteContactBTN = new System.Windows.Forms.Button();
            this.sourceLBL = new System.Windows.Forms.Label();
            this.readingFromLBL = new System.Windows.Forms.Label();
            this.menuMS.SuspendLayout();
            this.TabsTC.SuspendLayout();
            this.View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.Update.SuspendLayout();
            this.Search.SuspendLayout();
            this.Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMS
            // 
            this.menuMS.BackColor = System.Drawing.Color.Gray;
            this.menuMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuMS.Location = new System.Drawing.Point(0, 0);
            this.menuMS.Name = "menuMS";
            this.menuMS.Size = new System.Drawing.Size(529, 24);
            this.menuMS.TabIndex = 0;
            this.menuMS.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.loadFromDBToolStripMenuItem,
            this.saveToDBToolStripMenuItem,
            this.resetAppToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.loadToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // loadFromDBToolStripMenuItem
            // 
            this.loadFromDBToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.loadFromDBToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.loadFromDBToolStripMenuItem.Name = "loadFromDBToolStripMenuItem";
            this.loadFromDBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadFromDBToolStripMenuItem.Text = "Load From DB";
            this.loadFromDBToolStripMenuItem.Click += new System.EventHandler(this.loadFromDBToolStripMenuItem_Click);
            // 
            // saveToDBToolStripMenuItem
            // 
            this.saveToDBToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.saveToDBToolStripMenuItem.Enabled = false;
            this.saveToDBToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.saveToDBToolStripMenuItem.Name = "saveToDBToolStripMenuItem";
            this.saveToDBToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToDBToolStripMenuItem.Text = "Save to DB";
            this.saveToDBToolStripMenuItem.Click += new System.EventHandler(this.saveToDBToolStripMenuItem_Click);
            // 
            // resetAppToolStripMenuItem
            // 
            this.resetAppToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.resetAppToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.resetAppToolStripMenuItem.Name = "resetAppToolStripMenuItem";
            this.resetAppToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetAppToolStripMenuItem.Text = "Reset App";
            this.resetAppToolStripMenuItem.Click += new System.EventHandler(this.resetAppToolStripMenuItem_Click);
            // 
            // TabsTC
            // 
            this.TabsTC.Controls.Add(this.View);
            this.TabsTC.Controls.Add(this.Update);
            this.TabsTC.Controls.Add(this.Search);
            this.TabsTC.Controls.Add(this.Add);
            this.TabsTC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabsTC.Location = new System.Drawing.Point(12, 27);
            this.TabsTC.Name = "TabsTC";
            this.TabsTC.SelectedIndex = 0;
            this.TabsTC.Size = new System.Drawing.Size(239, 398);
            this.TabsTC.TabIndex = 1;
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.Gray;
            this.View.Controls.Add(this.infoTXT);
            this.View.Location = new System.Drawing.Point(4, 24);
            this.View.Name = "View";
            this.View.Padding = new System.Windows.Forms.Padding(3);
            this.View.Size = new System.Drawing.Size(231, 370);
            this.View.TabIndex = 0;
            this.View.Text = "View";
            // 
            // infoTXT
            // 
            this.infoTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "Info", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.infoTXT.Enabled = false;
            this.infoTXT.Location = new System.Drawing.Point(6, 6);
            this.infoTXT.Multiline = true;
            this.infoTXT.Name = "infoTXT";
            this.infoTXT.Size = new System.Drawing.Size(219, 358);
            this.infoTXT.TabIndex = 0;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(Models.Models.Contact);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Gray;
            this.Update.Controls.Add(this.provinceCB);
            this.Update.Controls.Add(this.postalCodeTXT);
            this.Update.Controls.Add(this.postalCodeLBL);
            this.Update.Controls.Add(this.orgCB);
            this.Update.Controls.Add(this.emailLBL);
            this.Update.Controls.Add(this.phoneLBL);
            this.Update.Controls.Add(this.provinceLBL);
            this.Update.Controls.Add(this.cityLBL);
            this.Update.Controls.Add(this.addressLBL);
            this.Update.Controls.Add(this.organizationLBL);
            this.Update.Controls.Add(this.nicknameLBL);
            this.Update.Controls.Add(this.lNameLBL);
            this.Update.Controls.Add(this.fNmaeLBL);
            this.Update.Controls.Add(this.updateContactBTN);
            this.Update.Controls.Add(this.emailTXT);
            this.Update.Controls.Add(this.phoneTXT);
            this.Update.Controls.Add(this.cityTXT);
            this.Update.Controls.Add(this.addressTXT);
            this.Update.Controls.Add(this.nicknameTXT);
            this.Update.Controls.Add(this.lNameTXT);
            this.Update.Controls.Add(this.fNameTXT);
            this.Update.Location = new System.Drawing.Point(4, 24);
            this.Update.Name = "Update";
            this.Update.Padding = new System.Windows.Forms.Padding(3);
            this.Update.Size = new System.Drawing.Size(231, 370);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            // 
            // provinceCB
            // 
            this.provinceCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "Province", true));
            this.provinceCB.FormattingEnabled = true;
            this.provinceCB.Items.AddRange(new object[] {
            "Alberta",
            "British Columbia",
            "Manitoba",
            "New Brunswick",
            "Newfoundland and Labrador",
            "Northwest Territories",
            "Nova Scotia",
            "Nunavut",
            "Ontario",
            "Prince Edward Island",
            "Quebec",
            "Saskatchewan",
            "Yukon"});
            this.provinceCB.Location = new System.Drawing.Point(6, 153);
            this.provinceCB.Name = "provinceCB";
            this.provinceCB.Size = new System.Drawing.Size(219, 23);
            this.provinceCB.TabIndex = 6;
            // 
            // postalCodeTXT
            // 
            this.postalCodeTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "PostalCode", true));
            this.postalCodeTXT.Location = new System.Drawing.Point(125, 197);
            this.postalCodeTXT.MaxLength = 7;
            this.postalCodeTXT.Name = "postalCodeTXT";
            this.postalCodeTXT.Size = new System.Drawing.Size(100, 23);
            this.postalCodeTXT.TabIndex = 8;
            this.postalCodeTXT.Enter += new System.EventHandler(this.postalCodeTXT_Enter);
            this.postalCodeTXT.Leave += new System.EventHandler(this.postalCodeTXT_Leave);
            // 
            // postalCodeLBL
            // 
            this.postalCodeLBL.AutoSize = true;
            this.postalCodeLBL.BackColor = System.Drawing.Color.Transparent;
            this.postalCodeLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.postalCodeLBL.Location = new System.Drawing.Point(125, 179);
            this.postalCodeLBL.Name = "postalCodeLBL";
            this.postalCodeLBL.Size = new System.Drawing.Size(73, 15);
            this.postalCodeLBL.TabIndex = 26;
            this.postalCodeLBL.Text = "Postal Code:";
            // 
            // orgCB
            // 
            this.orgCB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "Organization", true));
            this.orgCB.FormattingEnabled = true;
            this.orgCB.Items.AddRange(new object[] {
            "None",
            "School",
            "Personal",
            "Work",
            "Other"});
            this.orgCB.Location = new System.Drawing.Point(125, 65);
            this.orgCB.Name = "orgCB";
            this.orgCB.Size = new System.Drawing.Size(100, 23);
            this.orgCB.TabIndex = 3;
            // 
            // emailLBL
            // 
            this.emailLBL.AutoSize = true;
            this.emailLBL.BackColor = System.Drawing.Color.Transparent;
            this.emailLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.emailLBL.Location = new System.Drawing.Point(6, 179);
            this.emailLBL.Name = "emailLBL";
            this.emailLBL.Size = new System.Drawing.Size(84, 15);
            this.emailLBL.TabIndex = 24;
            this.emailLBL.Text = "Email Address:";
            // 
            // phoneLBL
            // 
            this.phoneLBL.AutoSize = true;
            this.phoneLBL.BackColor = System.Drawing.Color.Transparent;
            this.phoneLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.phoneLBL.Location = new System.Drawing.Point(6, 223);
            this.phoneLBL.Name = "phoneLBL";
            this.phoneLBL.Size = new System.Drawing.Size(91, 15);
            this.phoneLBL.TabIndex = 22;
            this.phoneLBL.Text = "Phone Number:";
            // 
            // provinceLBL
            // 
            this.provinceLBL.AutoSize = true;
            this.provinceLBL.BackColor = System.Drawing.Color.Transparent;
            this.provinceLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.provinceLBL.Location = new System.Drawing.Point(6, 135);
            this.provinceLBL.Name = "provinceLBL";
            this.provinceLBL.Size = new System.Drawing.Size(56, 15);
            this.provinceLBL.TabIndex = 21;
            this.provinceLBL.Text = "Province:";
            // 
            // cityLBL
            // 
            this.cityLBL.AutoSize = true;
            this.cityLBL.BackColor = System.Drawing.Color.Transparent;
            this.cityLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cityLBL.Location = new System.Drawing.Point(125, 91);
            this.cityLBL.Name = "cityLBL";
            this.cityLBL.Size = new System.Drawing.Size(31, 15);
            this.cityLBL.TabIndex = 20;
            this.cityLBL.Text = "City:";
            // 
            // addressLBL
            // 
            this.addressLBL.AutoSize = true;
            this.addressLBL.BackColor = System.Drawing.Color.Transparent;
            this.addressLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addressLBL.Location = new System.Drawing.Point(6, 91);
            this.addressLBL.Name = "addressLBL";
            this.addressLBL.Size = new System.Drawing.Size(52, 15);
            this.addressLBL.TabIndex = 19;
            this.addressLBL.Text = "Address:";
            // 
            // organizationLBL
            // 
            this.organizationLBL.AutoSize = true;
            this.organizationLBL.BackColor = System.Drawing.Color.Transparent;
            this.organizationLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.organizationLBL.Location = new System.Drawing.Point(125, 47);
            this.organizationLBL.Name = "organizationLBL";
            this.organizationLBL.Size = new System.Drawing.Size(78, 15);
            this.organizationLBL.TabIndex = 18;
            this.organizationLBL.Text = "Organization:";
            // 
            // nicknameLBL
            // 
            this.nicknameLBL.AutoSize = true;
            this.nicknameLBL.BackColor = System.Drawing.Color.Transparent;
            this.nicknameLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nicknameLBL.Location = new System.Drawing.Point(6, 47);
            this.nicknameLBL.Name = "nicknameLBL";
            this.nicknameLBL.Size = new System.Drawing.Size(64, 15);
            this.nicknameLBL.TabIndex = 17;
            this.nicknameLBL.Text = "Nickname:";
            // 
            // lNameLBL
            // 
            this.lNameLBL.AutoSize = true;
            this.lNameLBL.BackColor = System.Drawing.Color.Transparent;
            this.lNameLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lNameLBL.Location = new System.Drawing.Point(125, 3);
            this.lNameLBL.Name = "lNameLBL";
            this.lNameLBL.Size = new System.Drawing.Size(66, 15);
            this.lNameLBL.TabIndex = 16;
            this.lNameLBL.Text = "Last Name:";
            // 
            // fNmaeLBL
            // 
            this.fNmaeLBL.AutoSize = true;
            this.fNmaeLBL.BackColor = System.Drawing.Color.Transparent;
            this.fNmaeLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fNmaeLBL.Location = new System.Drawing.Point(6, 3);
            this.fNmaeLBL.Name = "fNmaeLBL";
            this.fNmaeLBL.Size = new System.Drawing.Size(67, 15);
            this.fNmaeLBL.TabIndex = 15;
            this.fNmaeLBL.Text = "First Name:";
            // 
            // updateContactBTN
            // 
            this.updateContactBTN.Enabled = false;
            this.updateContactBTN.Location = new System.Drawing.Point(6, 341);
            this.updateContactBTN.Name = "updateContactBTN";
            this.updateContactBTN.Size = new System.Drawing.Size(100, 23);
            this.updateContactBTN.TabIndex = 10;
            this.updateContactBTN.Text = "Update Contact";
            this.updateContactBTN.UseVisualStyleBackColor = true;
            this.updateContactBTN.Click += new System.EventHandler(this.updateContactBTN_Click);
            // 
            // emailTXT
            // 
            this.emailTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "Email", true));
            this.emailTXT.Location = new System.Drawing.Point(6, 197);
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.Size = new System.Drawing.Size(100, 23);
            this.emailTXT.TabIndex = 7;
            this.emailTXT.Enter += new System.EventHandler(this.emailTXT_Enter);
            this.emailTXT.Leave += new System.EventHandler(this.emailTXT_Leave);
            // 
            // phoneTXT
            // 
            this.phoneTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "Phone", true));
            this.phoneTXT.Location = new System.Drawing.Point(6, 241);
            this.phoneTXT.MaxLength = 14;
            this.phoneTXT.Name = "phoneTXT";
            this.phoneTXT.Size = new System.Drawing.Size(100, 23);
            this.phoneTXT.TabIndex = 9;
            this.phoneTXT.Enter += new System.EventHandler(this.phoneTXT_Enter);
            this.phoneTXT.Leave += new System.EventHandler(this.phoneTXT_Leave);
            // 
            // cityTXT
            // 
            this.cityTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "City", true));
            this.cityTXT.Location = new System.Drawing.Point(125, 109);
            this.cityTXT.Name = "cityTXT";
            this.cityTXT.Size = new System.Drawing.Size(100, 23);
            this.cityTXT.TabIndex = 5;
            // 
            // addressTXT
            // 
            this.addressTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "Address", true));
            this.addressTXT.Location = new System.Drawing.Point(6, 109);
            this.addressTXT.Name = "addressTXT";
            this.addressTXT.Size = new System.Drawing.Size(100, 23);
            this.addressTXT.TabIndex = 4;
            // 
            // nicknameTXT
            // 
            this.nicknameTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "Nickname", true));
            this.nicknameTXT.Location = new System.Drawing.Point(6, 65);
            this.nicknameTXT.Name = "nicknameTXT";
            this.nicknameTXT.Size = new System.Drawing.Size(100, 23);
            this.nicknameTXT.TabIndex = 2;
            // 
            // lNameTXT
            // 
            this.lNameTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "Lname", true));
            this.lNameTXT.Location = new System.Drawing.Point(125, 21);
            this.lNameTXT.Name = "lNameTXT";
            this.lNameTXT.Size = new System.Drawing.Size(100, 23);
            this.lNameTXT.TabIndex = 1;
            // 
            // fNameTXT
            // 
            this.fNameTXT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactBindingSource, "Fname", true));
            this.fNameTXT.Location = new System.Drawing.Point(6, 21);
            this.fNameTXT.Name = "fNameTXT";
            this.fNameTXT.Size = new System.Drawing.Size(100, 23);
            this.fNameTXT.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Gray;
            this.Search.Controls.Add(this.searchT2LBL);
            this.Search.Controls.Add(this.searchT1LBL);
            this.Search.Controls.Add(this.sortCB);
            this.Search.Controls.Add(this.sortLBL);
            this.Search.Controls.Add(this.search2TXT);
            this.Search.Controls.Add(this.search2CB);
            this.Search.Controls.Add(this.search2LBL);
            this.Search.Controls.Add(this.search1LBL);
            this.Search.Controls.Add(this.resetBTN);
            this.Search.Controls.Add(this.searchBTN);
            this.Search.Controls.Add(this.search1TXT);
            this.Search.Controls.Add(this.search1CB);
            this.Search.Location = new System.Drawing.Point(4, 24);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(231, 370);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            // 
            // searchT2LBL
            // 
            this.searchT2LBL.AutoSize = true;
            this.searchT2LBL.BackColor = System.Drawing.Color.Transparent;
            this.searchT2LBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchT2LBL.Location = new System.Drawing.Point(6, 135);
            this.searchT2LBL.Name = "searchT2LBL";
            this.searchT2LBL.Size = new System.Drawing.Size(69, 15);
            this.searchT2LBL.TabIndex = 10;
            this.searchT2LBL.Text = "Search Text:";
            // 
            // searchT1LBL
            // 
            this.searchT1LBL.AutoSize = true;
            this.searchT1LBL.BackColor = System.Drawing.Color.Transparent;
            this.searchT1LBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchT1LBL.Location = new System.Drawing.Point(6, 47);
            this.searchT1LBL.Name = "searchT1LBL";
            this.searchT1LBL.Size = new System.Drawing.Size(69, 15);
            this.searchT1LBL.TabIndex = 9;
            this.searchT1LBL.Text = "Search Text:";
            // 
            // sortCB
            // 
            this.sortCB.FormattingEnabled = true;
            this.sortCB.Location = new System.Drawing.Point(6, 197);
            this.sortCB.Name = "sortCB";
            this.sortCB.Size = new System.Drawing.Size(219, 23);
            this.sortCB.TabIndex = 4;
            // 
            // sortLBL
            // 
            this.sortLBL.AutoSize = true;
            this.sortLBL.BackColor = System.Drawing.Color.Transparent;
            this.sortLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sortLBL.Location = new System.Drawing.Point(6, 179);
            this.sortLBL.Name = "sortLBL";
            this.sortLBL.Size = new System.Drawing.Size(28, 15);
            this.sortLBL.TabIndex = 8;
            this.sortLBL.Text = "Sort";
            // 
            // search2TXT
            // 
            this.search2TXT.Location = new System.Drawing.Point(6, 153);
            this.search2TXT.Name = "search2TXT";
            this.search2TXT.Size = new System.Drawing.Size(219, 23);
            this.search2TXT.TabIndex = 3;
            // 
            // search2CB
            // 
            this.search2CB.FormattingEnabled = true;
            this.search2CB.Location = new System.Drawing.Point(6, 109);
            this.search2CB.Name = "search2CB";
            this.search2CB.Size = new System.Drawing.Size(219, 23);
            this.search2CB.TabIndex = 2;
            // 
            // search2LBL
            // 
            this.search2LBL.AutoSize = true;
            this.search2LBL.BackColor = System.Drawing.Color.Transparent;
            this.search2LBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.search2LBL.Location = new System.Drawing.Point(6, 91);
            this.search2LBL.Name = "search2LBL";
            this.search2LBL.Size = new System.Drawing.Size(51, 15);
            this.search2LBL.TabIndex = 5;
            this.search2LBL.Text = "Search 2";
            // 
            // search1LBL
            // 
            this.search1LBL.AutoSize = true;
            this.search1LBL.BackColor = System.Drawing.Color.Transparent;
            this.search1LBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.search1LBL.Location = new System.Drawing.Point(6, 3);
            this.search1LBL.Name = "search1LBL";
            this.search1LBL.Size = new System.Drawing.Size(51, 15);
            this.search1LBL.TabIndex = 4;
            this.search1LBL.Text = "Search 1";
            // 
            // resetBTN
            // 
            this.resetBTN.Location = new System.Drawing.Point(125, 341);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(100, 23);
            this.resetBTN.TabIndex = 6;
            this.resetBTN.Text = "Reset Contacts";
            this.resetBTN.UseVisualStyleBackColor = true;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // searchBTN
            // 
            this.searchBTN.Location = new System.Drawing.Point(6, 341);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(100, 23);
            this.searchBTN.TabIndex = 5;
            this.searchBTN.Text = "Search Contacts";
            this.searchBTN.UseVisualStyleBackColor = true;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // search1TXT
            // 
            this.search1TXT.Location = new System.Drawing.Point(6, 65);
            this.search1TXT.Name = "search1TXT";
            this.search1TXT.Size = new System.Drawing.Size(219, 23);
            this.search1TXT.TabIndex = 1;
            // 
            // search1CB
            // 
            this.search1CB.FormattingEnabled = true;
            this.search1CB.Location = new System.Drawing.Point(6, 21);
            this.search1CB.Name = "search1CB";
            this.search1CB.Size = new System.Drawing.Size(219, 23);
            this.search1CB.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Gray;
            this.Add.Controls.Add(this.provaddCB);
            this.Add.Controls.Add(this.pcaddTXT);
            this.Add.Controls.Add(this.label1);
            this.Add.Controls.Add(this.orgaddCB);
            this.Add.Controls.Add(this.label2);
            this.Add.Controls.Add(this.label3);
            this.Add.Controls.Add(this.label4);
            this.Add.Controls.Add(this.label5);
            this.Add.Controls.Add(this.label6);
            this.Add.Controls.Add(this.label7);
            this.Add.Controls.Add(this.label8);
            this.Add.Controls.Add(this.label9);
            this.Add.Controls.Add(this.label10);
            this.Add.Controls.Add(this.addConTXT);
            this.Add.Controls.Add(this.emailaddTXT);
            this.Add.Controls.Add(this.phoneaddTXT);
            this.Add.Controls.Add(this.cityaddTXT);
            this.Add.Controls.Add(this.addressaddTXT);
            this.Add.Controls.Add(this.nickaddTXT);
            this.Add.Controls.Add(this.lnaTXT);
            this.Add.Controls.Add(this.fnaTXT);
            this.Add.Location = new System.Drawing.Point(4, 24);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(231, 370);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            // 
            // provaddCB
            // 
            this.provaddCB.FormattingEnabled = true;
            this.provaddCB.Items.AddRange(new object[] {
            "Alberta",
            "British Columbia",
            "Manitoba",
            "New Brunswick",
            "Newfoundland and Labrador",
            "Northwest Territories",
            "Nova Scotia",
            "Nunavut",
            "Ontario",
            "Prince Edward Island",
            "Quebec",
            "Saskatchewan",
            "Yukon"});
            this.provaddCB.Location = new System.Drawing.Point(6, 153);
            this.provaddCB.Name = "provaddCB";
            this.provaddCB.Size = new System.Drawing.Size(219, 23);
            this.provaddCB.TabIndex = 6;
            // 
            // pcaddTXT
            // 
            this.pcaddTXT.Location = new System.Drawing.Point(125, 197);
            this.pcaddTXT.MaxLength = 7;
            this.pcaddTXT.Name = "pcaddTXT";
            this.pcaddTXT.Size = new System.Drawing.Size(100, 23);
            this.pcaddTXT.TabIndex = 8;
            this.pcaddTXT.Enter += new System.EventHandler(this.pcaddTXT_Enter);
            this.pcaddTXT.Leave += new System.EventHandler(this.pcaddTXT_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(125, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 47;
            this.label1.Text = "Postal Code:";
            // 
            // orgaddCB
            // 
            this.orgaddCB.FormattingEnabled = true;
            this.orgaddCB.Items.AddRange(new object[] {
            "None",
            "School",
            "Personal",
            "Work",
            "Other"});
            this.orgaddCB.Location = new System.Drawing.Point(125, 65);
            this.orgaddCB.Name = "orgaddCB";
            this.orgaddCB.Size = new System.Drawing.Size(100, 23);
            this.orgaddCB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(6, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Email Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(6, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(6, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 43;
            this.label4.Text = "Province:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(125, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 42;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(125, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Organization:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(6, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Nickname:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(125, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Last Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "First Name:";
            // 
            // addConTXT
            // 
            this.addConTXT.Location = new System.Drawing.Point(6, 341);
            this.addConTXT.Name = "addConTXT";
            this.addConTXT.Size = new System.Drawing.Size(100, 23);
            this.addConTXT.TabIndex = 10;
            this.addConTXT.Text = "Add Contact";
            this.addConTXT.UseVisualStyleBackColor = true;
            this.addConTXT.Click += new System.EventHandler(this.addConTXT_Click);
            // 
            // emailaddTXT
            // 
            this.emailaddTXT.Location = new System.Drawing.Point(6, 197);
            this.emailaddTXT.Name = "emailaddTXT";
            this.emailaddTXT.Size = new System.Drawing.Size(100, 23);
            this.emailaddTXT.TabIndex = 7;
            this.emailaddTXT.Enter += new System.EventHandler(this.emailaddTXT_Enter);
            this.emailaddTXT.Leave += new System.EventHandler(this.emailaddTXT_Leave);
            // 
            // phoneaddTXT
            // 
            this.phoneaddTXT.Location = new System.Drawing.Point(6, 241);
            this.phoneaddTXT.MaxLength = 14;
            this.phoneaddTXT.Name = "phoneaddTXT";
            this.phoneaddTXT.Size = new System.Drawing.Size(100, 23);
            this.phoneaddTXT.TabIndex = 9;
            this.phoneaddTXT.Enter += new System.EventHandler(this.phoneaddTXT_Enter);
            this.phoneaddTXT.Leave += new System.EventHandler(this.phoneaddTXT_Leave);
            // 
            // cityaddTXT
            // 
            this.cityaddTXT.Location = new System.Drawing.Point(125, 109);
            this.cityaddTXT.Name = "cityaddTXT";
            this.cityaddTXT.Size = new System.Drawing.Size(100, 23);
            this.cityaddTXT.TabIndex = 5;
            // 
            // addressaddTXT
            // 
            this.addressaddTXT.Location = new System.Drawing.Point(6, 109);
            this.addressaddTXT.Name = "addressaddTXT";
            this.addressaddTXT.Size = new System.Drawing.Size(100, 23);
            this.addressaddTXT.TabIndex = 4;
            // 
            // nickaddTXT
            // 
            this.nickaddTXT.Location = new System.Drawing.Point(6, 65);
            this.nickaddTXT.Name = "nickaddTXT";
            this.nickaddTXT.Size = new System.Drawing.Size(100, 23);
            this.nickaddTXT.TabIndex = 2;
            // 
            // lnaTXT
            // 
            this.lnaTXT.Location = new System.Drawing.Point(125, 21);
            this.lnaTXT.Name = "lnaTXT";
            this.lnaTXT.Size = new System.Drawing.Size(100, 23);
            this.lnaTXT.TabIndex = 1;
            // 
            // fnaTXT
            // 
            this.fnaTXT.Location = new System.Drawing.Point(6, 21);
            this.fnaTXT.Name = "fnaTXT";
            this.fnaTXT.Size = new System.Drawing.Size(100, 23);
            this.fnaTXT.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NamesLB
            // 
            this.NamesLB.BackColor = System.Drawing.Color.Gray;
            this.NamesLB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contactBindingSource, "Combo", true));
            this.NamesLB.DataSource = this.contactBindingSource;
            this.NamesLB.DisplayMember = "Combo";
            this.NamesLB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NamesLB.FormattingEnabled = true;
            this.NamesLB.ItemHeight = 15;
            this.NamesLB.Location = new System.Drawing.Point(278, 51);
            this.NamesLB.Name = "NamesLB";
            this.NamesLB.Size = new System.Drawing.Size(239, 364);
            this.NamesLB.TabIndex = 2;
            this.NamesLB.ValueMember = "Id";
            this.NamesLB.Click += new System.EventHandler(this.NamesLB_Click);
            // 
            // deleteContactBTN
            // 
            this.deleteContactBTN.Location = new System.Drawing.Point(417, 421);
            this.deleteContactBTN.Name = "deleteContactBTN";
            this.deleteContactBTN.Size = new System.Drawing.Size(100, 23);
            this.deleteContactBTN.TabIndex = 3;
            this.deleteContactBTN.TabStop = false;
            this.deleteContactBTN.Text = "Delete Contact";
            this.deleteContactBTN.UseVisualStyleBackColor = true;
            this.deleteContactBTN.Click += new System.EventHandler(this.deleteContactBTN_Click);
            // 
            // sourceLBL
            // 
            this.sourceLBL.AutoSize = true;
            this.sourceLBL.BackColor = System.Drawing.Color.Transparent;
            this.sourceLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sourceLBL.Location = new System.Drawing.Point(12, 429);
            this.sourceLBL.Name = "sourceLBL";
            this.sourceLBL.Size = new System.Drawing.Size(72, 15);
            this.sourceLBL.TabIndex = 4;
            this.sourceLBL.Text = "Data source:";
            // 
            // readingFromLBL
            // 
            this.readingFromLBL.AutoSize = true;
            this.readingFromLBL.BackColor = System.Drawing.Color.Transparent;
            this.readingFromLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.readingFromLBL.Location = new System.Drawing.Point(90, 429);
            this.readingFromLBL.Name = "readingFromLBL";
            this.readingFromLBL.Size = new System.Drawing.Size(36, 15);
            this.readingFromLBL.TabIndex = 5;
            this.readingFromLBL.Text = "None";
            // 
            // Contact_Organizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.readingFromLBL);
            this.Controls.Add(this.sourceLBL);
            this.Controls.Add(this.deleteContactBTN);
            this.Controls.Add(this.NamesLB);
            this.Controls.Add(this.TabsTC);
            this.Controls.Add(this.menuMS);
            this.MainMenuStrip = this.menuMS;
            this.MaximumSize = new System.Drawing.Size(545, 489);
            this.MinimumSize = new System.Drawing.Size(545, 489);
            this.Name = "Contact_Organizer";
            this.Text = "Contact Organizer";
            this.menuMS.ResumeLayout(false);
            this.menuMS.PerformLayout();
            this.TabsTC.ResumeLayout(false);
            this.View.ResumeLayout(false);
            this.View.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.Update.ResumeLayout(false);
            this.Update.PerformLayout();
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuMS;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private TabControl TabsTC;
        private TabPage View;
        private TabPage Update;
        private ToolStripMenuItem loadToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private TextBox infoTXT;
        private Button updateContactBTN;
        private TextBox emailTXT;
        private TextBox phoneTXT;
        private TextBox cityTXT;
        private TextBox addressTXT;
        private TextBox nicknameTXT;
        private TextBox lNameTXT;
        private TextBox fNameTXT;
        private SaveFileDialog saveFileDialog1;
        private Label emailLBL;
        private Label phoneLBL;
        private Label provinceLBL;
        private Label cityLBL;
        private Label addressLBL;
        private Label organizationLBL;
        private Label nicknameLBL;
        private Label lNameLBL;
        private Label fNmaeLBL;
        private ToolStripMenuItem loadFromDBToolStripMenuItem;
        private TabPage Search;
        private Button searchBTN;
        private TextBox search1TXT;
        private ComboBox search1CB;
        private ListBox NamesLB;
        private Button resetBTN;
        private TextBox search2TXT;
        private ComboBox search2CB;
        private Label search2LBL;
        private Label search1LBL;
        private ComboBox sortCB;
        private Label sortLBL;
        private ComboBox orgCB;
        private ComboBox provinceCB;
        private TextBox postalCodeTXT;
        private Label postalCodeLBL;
        private BindingSource bindingSource1;
        private TabPage Add;
        private ComboBox provaddCB;
        private TextBox pcaddTXT;
        private Label label1;
        private ComboBox orgaddCB;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button addConTXT;
        private TextBox emailaddTXT;
        private TextBox phoneaddTXT;
        private TextBox cityaddTXT;
        private TextBox addressaddTXT;
        private TextBox nickaddTXT;
        private TextBox lnaTXT;
        private TextBox fnaTXT;
        private Button deleteContactBTN;
        private BindingSource contactBindingSource;
        private ToolStripMenuItem saveToDBToolStripMenuItem;
        private Label sourceLBL;
        private Label readingFromLBL;
        private Label searchT2LBL;
        private Label searchT1LBL;
        private ToolStripMenuItem resetAppToolStripMenuItem;
    }
}