namespace ICT712_Contact_Organizer
{
    partial class PasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passwordLBL = new System.Windows.Forms.Label();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.showPassCHB = new System.Windows.Forms.CheckBox();
            this.okayBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.BackColor = System.Drawing.Color.Transparent;
            this.passwordLBL.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordLBL.Location = new System.Drawing.Point(12, 9);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(60, 15);
            this.passwordLBL.TabIndex = 0;
            this.passwordLBL.Text = "Password:";
            // 
            // passwordTXT
            // 
            this.passwordTXT.Location = new System.Drawing.Point(12, 27);
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(205, 23);
            this.passwordTXT.TabIndex = 1;
            // 
            // showPassCHB
            // 
            this.showPassCHB.AutoSize = true;
            this.showPassCHB.BackColor = System.Drawing.Color.Transparent;
            this.showPassCHB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.showPassCHB.Location = new System.Drawing.Point(12, 65);
            this.showPassCHB.Name = "showPassCHB";
            this.showPassCHB.Size = new System.Drawing.Size(108, 19);
            this.showPassCHB.TabIndex = 2;
            this.showPassCHB.Text = "Show Password";
            this.showPassCHB.UseVisualStyleBackColor = false;
            this.showPassCHB.CheckedChanged += new System.EventHandler(this.showPassCHB_CheckedChanged);
            // 
            // okayBTN
            // 
            this.okayBTN.Location = new System.Drawing.Point(12, 105);
            this.okayBTN.Name = "okayBTN";
            this.okayBTN.Size = new System.Drawing.Size(75, 23);
            this.okayBTN.TabIndex = 3;
            this.okayBTN.Text = "Okay";
            this.okayBTN.UseVisualStyleBackColor = true;
            this.okayBTN.Click += new System.EventHandler(this.okayBTN_Click);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(229, 138);
            this.Controls.Add(this.okayBTN);
            this.Controls.Add(this.showPassCHB);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.passwordLBL);
            this.MaximumSize = new System.Drawing.Size(245, 177);
            this.MinimumSize = new System.Drawing.Size(245, 177);
            this.Name = "PasswordForm";
            this.Text = "PasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label passwordLBL;
        private TextBox passwordTXT;
        private CheckBox showPassCHB;
        private Button okayBTN;
    }
}