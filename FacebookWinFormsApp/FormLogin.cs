using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.BrowserSubprocess;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private Button m_ButtonLogin;
        private CheckedListBox m_CheckedListBoxPermissions;
        private Label m_LabelPermissions;
        private LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private List<string> m_UserPermissionsSelection;

        private readonly string[] r_PermissionsList = new [] {
            "email",
            "public_profile",
            "user_age_range",
            "user_birthday",
            "user_friends",
            "user_gender",
            "user_hometown",
            "user_likes",
            "user_link",
            "user_location",
            "user_photos",
            "user_posts",
            "user_videos"
        };
      

        public FormLogin()
        {
            initializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.m_UserPermissionsSelection = m_CheckedListBoxPermissions.CheckedItems.Cast<string>().ToList();

            m_LoginResult = FacebookService.Login("287779573202574", this.m_UserPermissionsSelection.ToArray());
            
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;


            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }

        }


        private void initButtonLogin()
        {
            this.m_ButtonLogin = new Button();
            this.m_ButtonLogin.FlatStyle = FlatStyle.Flat;
            this.m_ButtonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonLogin.Location = new System.Drawing.Point(88, 340);
            this.m_ButtonLogin.Name = "m_ButtonLogin";
            this.m_ButtonLogin.Size = new System.Drawing.Size(248, 70);
            this.m_ButtonLogin.TabIndex = 0;
            this.m_ButtonLogin.Text = "Login";
            this.m_ButtonLogin.UseVisualStyleBackColor = true;
            this.m_ButtonLogin.Click += new System.EventHandler(this.button1_Click);
            this.Controls.Add(this.m_ButtonLogin);
        }


        private void initCheckListPermissions()
        {

            this.m_CheckedListBoxPermissions = new CheckedListBox();
            this.m_CheckedListBoxPermissions.FormattingEnabled = true;
            this.m_CheckedListBoxPermissions.Items.AddRange(this.r_PermissionsList);
            for (int i = 0; i < this.m_CheckedListBoxPermissions.Items.Count; i++)
            {
                this.m_CheckedListBoxPermissions.SetItemChecked(i, true);
            }
            this.m_CheckedListBoxPermissions.Location = new System.Drawing.Point(12, 74);
            this.m_CheckedListBoxPermissions.Size = new System.Drawing.Size(417, 234);
            this.m_CheckedListBoxPermissions.Sorted = true;
            this.m_CheckedListBoxPermissions.TabIndex = 1;
            this.Controls.Add(this.m_CheckedListBoxPermissions);
            
        }

        private void initLables()
        {
            this.m_LabelPermissions = new Label();
            this.m_LabelPermissions.AutoEllipsis = true;
            this.m_LabelPermissions.AutoSize = true;
            this.m_LabelPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_LabelPermissions.Location = new System.Drawing.Point(12, 21);
            this.m_LabelPermissions.Size = new System.Drawing.Size(271, 29);
            this.m_LabelPermissions.TabIndex = 2;
            this.m_LabelPermissions.Text = "Application Permissions";
            this.Controls.Add(this.m_LabelPermissions);
        }


        private void initializeComponent()
        {
            
            this.SuspendLayout();

            this.initButtonLogin();
            this.initCheckListPermissions();
            this.initLables();

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 442);
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
    }
}
