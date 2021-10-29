using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    
    public partial class FormMain : Form

    {

        private User m_LoggedInUser;
        private LoginResult m_LoginResult;

        private PictureBox m_PictureBoxAlbum;
        private PictureBox m_PictureBoxProfile;
        private ListBox m_ListBoxAlbums;
        private Button m_ButtonLogin;
        private ListBox m_ListBoxEvents;
        private Label m_Label3;
        private TextBox m_TextBoxStatus;
        private Button m_ButtonSetStatus;
        private ListBox m_ListBoxPosts;
        private PictureBox m_PictureBoxEvent;
        private LinkLabel m_LinkAlbums;
        private LinkLabel m_LabelEvents;
        private LinkLabel m_LinkPosts;
        private LinkLabel m_LinkFavoriteTeams;
        private ListBox m_ListBoxFavoriteTeams;
        private TabControl m_TabControl1;
        private TabPage m_TabPage1;
        private PictureBox m_PictureBoxPage;
        private ListBox m_ListBoxPages;
        private LinkLabel m_LinkPages;
        private TabPage m_TabPage2;
        private ComboBox m_ComboBoxActionType;
        private DataGridView m_DataGridViewActions;
        private LinkLabel m_LinkUserActions;
        private Button m_ButtonLogout;
        private PictureBox m_PictureBoxFavoriteTeam;
        private PictureBox m_PictureBoxGroup;
        private ListBox m_ListBoxGroups;
        private LinkLabel m_LinkLabelFetchGroups;





        public FormMain()
        {
            initializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
        }


        private void initializeComponent()
        {
            this.m_PictureBoxAlbum = new PictureBox();
            this.m_PictureBoxProfile = new PictureBox();
            this.m_ListBoxAlbums = new ListBox();
            this.m_ButtonLogin = new Button();
            this.m_ListBoxEvents = new ListBox();
            this.m_Label3 = new Label();
            this.m_TextBoxStatus = new TextBox();
            this.m_ButtonSetStatus = new Button();
            this.m_ListBoxPosts = new ListBox();
            this.m_PictureBoxEvent = new PictureBox();
            this.m_LinkAlbums = new LinkLabel();
            this.m_LabelEvents = new LinkLabel();
            this.m_LinkPosts = new LinkLabel();
            this.m_LinkFavoriteTeams = new LinkLabel();
            this.m_ListBoxFavoriteTeams = new ListBox();
            this.m_TabControl1 = new TabControl();
            this.m_TabPage1 = new TabPage();
            this.m_PictureBoxFavoriteTeam = new PictureBox();
            this.m_ButtonLogout = new Button();
            this.m_PictureBoxPage = new PictureBox();
            this.m_PictureBoxGroup = new PictureBox();
            this.m_ListBoxPages = new ListBox();
            this.m_LinkPages = new LinkLabel();
            this.m_ListBoxGroups = new ListBox();
            this.m_LinkLabelFetchGroups = new LinkLabel();
            this.m_TabPage2 = new TabPage();
            this.m_ComboBoxActionType = new ComboBox();
            this.m_DataGridViewActions = new DataGridView();
            this.m_LinkUserActions = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxEvent)).BeginInit();
            this.m_TabControl1.SuspendLayout();
            this.m_TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxFavoriteTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxGroup)).BeginInit();
            this.m_TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewActions)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAlbum
            // 
            this.m_PictureBoxAlbum.BackColor = System.Drawing.Color.Gainsboro;
            this.m_PictureBoxAlbum.Location = new System.Drawing.Point(206, 494);
            this.m_PictureBoxAlbum.Margin = new Padding(4, 5, 4, 5);
            this.m_PictureBoxAlbum.Name = "m_PictureBoxAlbum";
            this.m_PictureBoxAlbum.Size = new System.Drawing.Size(116, 105);
            this.m_PictureBoxAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxAlbum.TabIndex = 42;
            this.m_PictureBoxAlbum.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.m_PictureBoxProfile.Location = new System.Drawing.Point(12, 78);
            this.m_PictureBoxProfile.Margin = new Padding(4, 5, 4, 5);
            this.m_PictureBoxProfile.Name = "m_PictureBoxProfile";
            this.m_PictureBoxProfile.Size = new System.Drawing.Size(254, 207);
            this.m_PictureBoxProfile.SizeMode = PictureBoxSizeMode.Zoom;
            this.m_PictureBoxProfile.TabIndex = 41;
            this.m_PictureBoxProfile.TabStop = false;
            // 
            // listBoxAlbums
            // 
            this.m_ListBoxAlbums.FormattingEnabled = true;
            this.m_ListBoxAlbums.ItemHeight = 20;
            this.m_ListBoxAlbums.Location = new System.Drawing.Point(12, 372);
            this.m_ListBoxAlbums.Margin = new Padding(4, 5, 4, 5);
            this.m_ListBoxAlbums.Name = "m_ListBoxAlbums";
            this.m_ListBoxAlbums.Size = new System.Drawing.Size(307, 224);
            this.m_ListBoxAlbums.TabIndex = 37;
            this.m_ListBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonLogin
            // 
            this.m_ButtonLogin.Location = new System.Drawing.Point(12, 9);
            this.m_ButtonLogin.Margin = new Padding(4, 5, 4, 5);
            this.m_ButtonLogin.Name = "m_ButtonLogin";
            this.m_ButtonLogin.Size = new System.Drawing.Size(112, 35);
            this.m_ButtonLogin.TabIndex = 36;
            this.m_ButtonLogin.Text = "Login";
            this.m_ButtonLogin.UseVisualStyleBackColor = true;
            this.m_ButtonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // listBoxEvents
            // 
            this.m_ListBoxEvents.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.m_ListBoxEvents.DisplayMember = "name";
            this.m_ListBoxEvents.FormattingEnabled = true;
            this.m_ListBoxEvents.ItemHeight = 20;
            this.m_ListBoxEvents.Location = new System.Drawing.Point(330, 372);
            this.m_ListBoxEvents.Margin = new Padding(4, 5, 4, 5);
            this.m_ListBoxEvents.Name = "m_ListBoxEvents";
            this.m_ListBoxEvents.Size = new System.Drawing.Size(344, 224);
            this.m_ListBoxEvents.TabIndex = 40;
            this.m_ListBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // label3
            // 
            this.m_Label3.AutoSize = true;
            this.m_Label3.Location = new System.Drawing.Point(678, 20);
            this.m_Label3.Margin = new Padding(4, 0, 4, 0);
            this.m_Label3.Name = "m_Label3";
            this.m_Label3.Size = new System.Drawing.Size(96, 20);
            this.m_Label3.TabIndex = 44;
            this.m_Label3.Text = "Post Status:";
            // 
            // textBoxStatus
            // 
            this.m_TextBoxStatus.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.m_TextBoxStatus.Location = new System.Drawing.Point(783, 15);
            this.m_TextBoxStatus.Margin = new Padding(4, 5, 4, 5);
            this.m_TextBoxStatus.Name = "m_TextBoxStatus";
            this.m_TextBoxStatus.Size = new System.Drawing.Size(330, 26);
            this.m_TextBoxStatus.TabIndex = 45;
            // 
            // buttonSetStatus
            // 
            this.m_ButtonSetStatus.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            this.m_ButtonSetStatus.Location = new System.Drawing.Point(1124, 12);
            this.m_ButtonSetStatus.Margin = new Padding(4, 5, 4, 5);
            this.m_ButtonSetStatus.Name = "m_ButtonSetStatus";
            this.m_ButtonSetStatus.Size = new System.Drawing.Size(112, 35);
            this.m_ButtonSetStatus.TabIndex = 46;
            this.m_ButtonSetStatus.Text = "Post";
            this.m_ButtonSetStatus.UseVisualStyleBackColor = true;
            this.m_ButtonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // listBoxPosts
            // 
            this.m_ListBoxPosts.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.m_ListBoxPosts.DisplayMember = "name";
            this.m_ListBoxPosts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ListBoxPosts.FormattingEnabled = true;
            this.m_ListBoxPosts.ItemHeight = 29;
            this.m_ListBoxPosts.Location = new System.Drawing.Point(324, 78);
            this.m_ListBoxPosts.Margin = new Padding(4, 5, 4, 5);
            this.m_ListBoxPosts.Name = "m_ListBoxPosts";
            this.m_ListBoxPosts.Size = new System.Drawing.Size(910, 207);
            this.m_ListBoxPosts.TabIndex = 40;
            //this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // pictureBoxEvent
            // 
            this.m_PictureBoxEvent.BackColor = System.Drawing.Color.Gainsboro;
            this.m_PictureBoxEvent.Location = new System.Drawing.Point(566, 494);
            this.m_PictureBoxEvent.Margin = new Padding(4, 5, 4, 5);
            this.m_PictureBoxEvent.Name = "m_PictureBoxEvent";
            this.m_PictureBoxEvent.Size = new System.Drawing.Size(111, 105);
            this.m_PictureBoxEvent.SizeMode = PictureBoxSizeMode.Zoom;
            this.m_PictureBoxEvent.TabIndex = 42;
            this.m_PictureBoxEvent.TabStop = false;
            // 
            // linkAlbums
            // 
            this.m_LinkAlbums.AutoSize = true;
            this.m_LinkAlbums.LinkArea = new LinkArea(0, 13);
            this.m_LinkAlbums.Location = new System.Drawing.Point(12, 328);
            this.m_LinkAlbums.Margin = new Padding(4, 0, 4, 0);
            this.m_LinkAlbums.Name = "m_LinkAlbums";
            this.m_LinkAlbums.Size = new System.Drawing.Size(300, 42);
            this.m_LinkAlbums.TabIndex = 47;
            this.m_LinkAlbums.TabStop = true;
            this.m_LinkAlbums.Text = "Fetch Albums\r\n(Click an album to view its cover picture)";
            this.m_LinkAlbums.UseCompatibleTextRendering = true;
            this.m_LinkAlbums.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkFriends_LinkClicked);
            // 
            // labelEvents
            // 
            this.m_LabelEvents.AutoSize = true;
            this.m_LabelEvents.LinkArea = new LinkArea(0, 13);
            this.m_LabelEvents.Location = new System.Drawing.Point(330, 328);
            this.m_LabelEvents.Margin = new Padding(4, 0, 4, 0);
            this.m_LabelEvents.Name = "m_LabelEvents";
            this.m_LabelEvents.Size = new System.Drawing.Size(276, 42);
            this.m_LabelEvents.TabIndex = 48;
            this.m_LabelEvents.TabStop = true;
            this.m_LabelEvents.Text = "Fetch Events \r\n(Click on an event to view it\'s picture)";
            this.m_LabelEvents.UseCompatibleTextRendering = true;
            this.m_LabelEvents.LinkClicked += new LinkLabelLinkClickedEventHandler(this.labelEvents_LinkClicked);
            // 
            // linkPosts
            // 
            this.m_LinkPosts.AutoSize = true;
            this.m_LinkPosts.LinkArea = new LinkArea(0, 12);
            this.m_LinkPosts.Location = new System.Drawing.Point(326, 34);
            this.m_LinkPosts.Margin = new Padding(4, 0, 4, 0);
            this.m_LinkPosts.Name = "m_LinkPosts";
            this.m_LinkPosts.Size = new System.Drawing.Size(301, 42);
            this.m_LinkPosts.TabIndex = 49;
            this.m_LinkPosts.TabStop = true;
            this.m_LinkPosts.Text = "Fetch Posts\r\n(Click on a post to view the comments!)\r\n";
            this.m_LinkPosts.UseCompatibleTextRendering = true;
            this.m_LinkPosts.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkPosts_LinkClicked);
            // 
            // linkFavoriteTeams
            // 
            this.m_LinkFavoriteTeams.AutoSize = true;
            this.m_LinkFavoriteTeams.LinkArea = new LinkArea(0, 20);
            this.m_LinkFavoriteTeams.Location = new System.Drawing.Point(12, 629);
            this.m_LinkFavoriteTeams.Margin = new Padding(4, 0, 4, 0);
            this.m_LinkFavoriteTeams.Name = "m_LinkFavoriteTeams";
            this.m_LinkFavoriteTeams.Size = new System.Drawing.Size(179, 24);
            this.m_LinkFavoriteTeams.TabIndex = 50;
            this.m_LinkFavoriteTeams.TabStop = true;
            this.m_LinkFavoriteTeams.Text = "Fetch Favorite Teams \r\n";
            this.m_LinkFavoriteTeams.UseCompatibleTextRendering = true;
            this.m_LinkFavoriteTeams.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkFavoriteTeams_LinkClicked);
            // 
            // listBoxFavoriteTeams
            // 
            this.m_ListBoxFavoriteTeams.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)));
            this.m_ListBoxFavoriteTeams.DisplayMember = "name";
            this.m_ListBoxFavoriteTeams.FormattingEnabled = true;
            this.m_ListBoxFavoriteTeams.ItemHeight = 20;
            this.m_ListBoxFavoriteTeams.Location = new System.Drawing.Point(12, 669);
            this.m_ListBoxFavoriteTeams.Margin = new Padding(4, 5, 4, 5);
            this.m_ListBoxFavoriteTeams.Name = "m_ListBoxFavoriteTeams";
            this.m_ListBoxFavoriteTeams.Size = new System.Drawing.Size(307, 264);
            this.m_ListBoxFavoriteTeams.TabIndex = 40;
            this.m_ListBoxFavoriteTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxFavoriteTeams_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.m_TabControl1.Controls.Add(this.m_TabPage1);
            this.m_TabControl1.Controls.Add(this.m_TabPage2);
            this.m_TabControl1.Dock = DockStyle.Fill;
            this.m_TabControl1.Location = new System.Drawing.Point(0, 0);
            this.m_TabControl1.Margin = new Padding(4, 5, 4, 5);
            this.m_TabControl1.Name = "m_TabControl1";
            this.m_TabControl1.SelectedIndex = 0;
            this.m_TabControl1.Size = new System.Drawing.Size(1263, 1011);
            this.m_TabControl1.TabIndex = 51;
            // 
            // tabPage1
            // 
            this.m_TabPage1.Controls.Add(this.m_PictureBoxFavoriteTeam);
            this.m_TabPage1.Controls.Add(this.m_PictureBoxAlbum);
            this.m_TabPage1.Controls.Add(this.m_ButtonLogout);
            this.m_TabPage1.Controls.Add(this.m_PictureBoxPage);
            this.m_TabPage1.Controls.Add(this.m_PictureBoxGroup);
            this.m_TabPage1.Controls.Add(this.m_PictureBoxEvent);
            this.m_TabPage1.Controls.Add(this.m_ButtonLogin);
            this.m_TabPage1.Controls.Add(this.m_LinkFavoriteTeams);
            this.m_TabPage1.Controls.Add(this.m_ListBoxAlbums);
            this.m_TabPage1.Controls.Add(this.m_ListBoxPages);
            this.m_TabPage1.Controls.Add(this.m_LinkPages);
            this.m_TabPage1.Controls.Add(this.m_ListBoxGroups);
            this.m_TabPage1.Controls.Add(this.m_LinkLabelFetchGroups);
            this.m_TabPage1.Controls.Add(this.m_ListBoxEvents);
            this.m_TabPage1.Controls.Add(this.m_LabelEvents);
            this.m_TabPage1.Controls.Add(this.m_ListBoxFavoriteTeams);
            this.m_TabPage1.Controls.Add(this.m_LinkAlbums);
            this.m_TabPage1.Controls.Add(this.m_ListBoxPosts);
            this.m_TabPage1.Controls.Add(this.m_ButtonSetStatus);
            this.m_TabPage1.Controls.Add(this.m_PictureBoxProfile);
            this.m_TabPage1.Controls.Add(this.m_TextBoxStatus);
            this.m_TabPage1.Controls.Add(this.m_Label3);
            this.m_TabPage1.Controls.Add(this.m_LinkPosts);
            this.m_TabPage1.Location = new System.Drawing.Point(4, 29);
            this.m_TabPage1.Margin = new Padding(4, 5, 4, 5);
            this.m_TabPage1.Name = "Home Page";
            this.m_TabPage1.Padding = new Padding(4, 5, 4, 5);
            this.m_TabPage1.Size = new System.Drawing.Size(1255, 978);
            this.m_TabPage1.TabIndex = 1;
            this.m_TabPage1.Text = "Home Page";
            this.m_TabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFavoriteTeam
            // 
            this.m_PictureBoxFavoriteTeam.BackColor = System.Drawing.Color.Gainsboro;
            this.m_PictureBoxFavoriteTeam.Location = new System.Drawing.Point(210, 831);
            this.m_PictureBoxFavoriteTeam.Margin = new Padding(4, 5, 4, 5);
            this.m_PictureBoxFavoriteTeam.Name = "m_PictureBoxFavoriteTeam";
            this.m_PictureBoxFavoriteTeam.Size = new System.Drawing.Size(111, 105);
            this.m_PictureBoxFavoriteTeam.SizeMode = PictureBoxSizeMode.Zoom;
            this.m_PictureBoxFavoriteTeam.TabIndex = 53;
            this.m_PictureBoxFavoriteTeam.TabStop = false;
            // 
            // buttonLogout
            // 
            this.m_ButtonLogout.Location = new System.Drawing.Point(134, 9);
            this.m_ButtonLogout.Margin = new Padding(4, 5, 4, 5);
            this.m_ButtonLogout.Name = "m_ButtonLogout";
            this.m_ButtonLogout.Size = new System.Drawing.Size(112, 35);
            this.m_ButtonLogout.TabIndex = 52;
            this.m_ButtonLogout.Text = "Logout";
            this.m_ButtonLogout.UseVisualStyleBackColor = true;
            this.m_ButtonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxPage
            // 
            this.m_PictureBoxPage.BackColor = System.Drawing.Color.Gainsboro;
            this.m_PictureBoxPage.Location = new System.Drawing.Point(566, 831);
            this.m_PictureBoxPage.Margin = new Padding(4, 5, 4, 5);
            this.m_PictureBoxPage.Name = "m_PictureBoxPage";
            this.m_PictureBoxPage.Size = new System.Drawing.Size(111, 105);
            this.m_PictureBoxPage.SizeMode = PictureBoxSizeMode.Zoom;
            this.m_PictureBoxPage.TabIndex = 42;
            this.m_PictureBoxPage.TabStop = false;
            // 
            // pictureBoxGroup
            // 
            this.m_PictureBoxGroup.BackColor = System.Drawing.Color.Gainsboro;
            this.m_PictureBoxGroup.Location = new System.Drawing.Point(921, 494);
            this.m_PictureBoxGroup.Margin = new Padding(4, 5, 4, 5);
            this.m_PictureBoxGroup.Name = "m_PictureBoxGroup";
            this.m_PictureBoxGroup.Size = new System.Drawing.Size(111, 105);
            this.m_PictureBoxGroup.SizeMode = PictureBoxSizeMode.Zoom;
            this.m_PictureBoxGroup.TabIndex = 42;
            this.m_PictureBoxGroup.TabStop = false;
            // 
            // listBoxPages
            // 
            this.m_ListBoxPages.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.m_ListBoxPages.DisplayMember = "name";
            this.m_ListBoxPages.FormattingEnabled = true;
            this.m_ListBoxPages.ItemHeight = 20;
            this.m_ListBoxPages.Location = new System.Drawing.Point(330, 669);
            this.m_ListBoxPages.Margin = new Padding(4, 5, 4, 5);
            this.m_ListBoxPages.Name = "m_ListBoxPages";
            this.m_ListBoxPages.Size = new System.Drawing.Size(344, 264);
            this.m_ListBoxPages.TabIndex = 40;
            this.m_ListBoxPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // linkPages
            // 
            this.m_LinkPages.AutoSize = true;
            this.m_LinkPages.LinkArea = new LinkArea(0, 17);
            this.m_LinkPages.Location = new System.Drawing.Point(330, 625);
            this.m_LinkPages.Margin = new Padding(4, 0, 4, 0);
            this.m_LinkPages.Name = "m_LinkPages";
            this.m_LinkPages.Size = new System.Drawing.Size(264, 42);
            this.m_LinkPages.TabIndex = 48;
            this.m_LinkPages.TabStop = true;
            this.m_LinkPages.Text = "Fetch Liked Pages \r\n(Click on a page to view it\'s picture)";
            this.m_LinkPages.UseCompatibleTextRendering = true;
            this.m_LinkPages.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkPages_LinkClicked);
            // 
            // listBoxGroups
            // 
            this.m_ListBoxGroups.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.m_ListBoxGroups.DisplayMember = "name";
            this.m_ListBoxGroups.FormattingEnabled = true;
            this.m_ListBoxGroups.ItemHeight = 20;
            this.m_ListBoxGroups.Location = new System.Drawing.Point(686, 372);
            this.m_ListBoxGroups.Margin = new Padding(4, 5, 4, 5);
            this.m_ListBoxGroups.Name = "m_ListBoxGroups";
            this.m_ListBoxGroups.Size = new System.Drawing.Size(344, 224);
            this.m_ListBoxGroups.TabIndex = 40;
            this.m_ListBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // linkLabelFetchGroups
            // 
            this.m_LinkLabelFetchGroups.AutoSize = true;
            this.m_LinkLabelFetchGroups.LinkArea = new LinkArea(0, 13);
            this.m_LinkLabelFetchGroups.Location = new System.Drawing.Point(686, 328);
            this.m_LinkLabelFetchGroups.Margin = new Padding(4, 0, 4, 0);
            this.m_LinkLabelFetchGroups.Name = "m_LinkLabelFetchGroups";
            this.m_LinkLabelFetchGroups.Size = new System.Drawing.Size(278, 42);
            this.m_LinkLabelFetchGroups.TabIndex = 48;
            this.m_LinkLabelFetchGroups.TabStop = true;
            this.m_LinkLabelFetchGroups.Text = "Fetch Groups \r\n(Click on an group to view it\'s picture)";
            this.m_LinkLabelFetchGroups.UseCompatibleTextRendering = true;
            this.m_LinkLabelFetchGroups.LinkClicked += new LinkLabelLinkClickedEventHandler(this.labelGroups_LinkClicked);
            // 
            // tabPage2
            // 
            this.m_TabPage2.Controls.Add(this.m_ComboBoxActionType);
            this.m_TabPage2.Controls.Add(this.m_DataGridViewActions);
            this.m_TabPage2.Controls.Add(this.m_LinkUserActions);
            this.m_TabPage2.Location = new System.Drawing.Point(4, 29);
            this.m_TabPage2.Margin = new Padding(4, 5, 4, 5);
            this.m_TabPage2.Name = "m_TabPage2";
            this.m_TabPage2.Padding = new Padding(4, 5, 4, 5);
            this.m_TabPage2.Size = new System.Drawing.Size(1255, 978);
            this.m_TabPage2.TabIndex = 2;
            this.m_TabPage2.Text = "tabPage2";
            this.m_TabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxActionType
            // 
            this.m_ComboBoxActionType.FormattingEnabled = true;
            this.m_ComboBoxActionType.Items.AddRange(new object[] {
            "music",
            "television",
            "movies",
            "books",
            "books.reads",
            "books.wants_to_read",
            "books.rates",
            "books.quotes",
            "fitness.runs",
            "fitness.walks",
            "fitness.bikes",
            "music.listens",
            "music.playlists",
            "news.reads",
            "news.publishes",
            "video.watches",
            "video.rates",
            "videos.wants_to_watch"});
            this.m_ComboBoxActionType.Location = new System.Drawing.Point(180, 9);
            this.m_ComboBoxActionType.Margin = new Padding(4, 5, 4, 5);
            this.m_ComboBoxActionType.Name = "m_ComboBoxActionType";
            this.m_ComboBoxActionType.Size = new System.Drawing.Size(246, 28);
            this.m_ComboBoxActionType.TabIndex = 23;
            // 
            // dataGridViewActions
            // 
            this.m_DataGridViewActions.AllowUserToAddRows = false;
            this.m_DataGridViewActions.AllowUserToDeleteRows = false;
            this.m_DataGridViewActions.AllowUserToOrderColumns = true;
            this.m_DataGridViewActions.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            this.m_DataGridViewActions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_DataGridViewActions.Location = new System.Drawing.Point(16, 51);
            this.m_DataGridViewActions.Margin = new Padding(4, 5, 4, 5);
            this.m_DataGridViewActions.Name = "m_DataGridViewActions";
            this.m_DataGridViewActions.ReadOnly = true;
            this.m_DataGridViewActions.RowHeadersWidth = 62;
            this.m_DataGridViewActions.Size = new System.Drawing.Size(1222, 878);
            this.m_DataGridViewActions.TabIndex = 22;
            // 
            // linkUserActions
            // 
            this.m_LinkUserActions.AutoSize = true;
            this.m_LinkUserActions.Location = new System.Drawing.Point(12, 14);
            this.m_LinkUserActions.Margin = new Padding(4, 0, 4, 0);
            this.m_LinkUserActions.Name = "m_LinkUserActions";
            this.m_LinkUserActions.Size = new System.Drawing.Size(145, 20);
            this.m_LinkUserActions.TabIndex = 14;
            this.m_LinkUserActions.TabStop = true;
            this.m_LinkUserActions.Text = "Fetch User Actions";
            this.m_LinkUserActions.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkUserActions_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 1011);
            this.Controls.Add(this.m_TabControl1);
            this.Margin = new Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Facebook Desktop Application";
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxEvent)).EndInit();
            this.m_TabControl1.ResumeLayout(false);
            this.m_TabPage1.ResumeLayout(false);
            this.m_TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxFavoriteTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxGroup)).EndInit();
            this.m_TabPage2.ResumeLayout(false);
            this.m_TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewActions)).EndInit();
            this.ResumeLayout(false);

        }

        /// <summary>
        /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
        /// You can then save the result.AccessToken for future auto-connect to this user:
        /// The documentation regarding facebook login and permissions can be found here: 
        /// <seealso cref="https://developers.facebook.com/docs/permissions/reference"/>
        /// </summary>
        /// <remarks>
        /// DEPRECATED_PERMISSIONS:
        /// publish_to_groups
        /// groups_access_member_info
        ///"user_about_me",
        ///"user_education_history",
        ///"user_actions.video",
        ///"user_actions.news",
        ///"user_actions.music",
        ///"user_actions.fitness",
        ///"user_actions.books",
        ///"user_games_activity",
        ///"user_managed_groups",
        ///"user_relationships",
        ///"user_relationship_details",
        ///"user_religion_politics",
        ///"user_tagged_places",
        ///"user_website",
        ///"user_work_history",
        ///"read_custom_friendlists",
        ///"read_page_mailboxes",
        ///"manage_pages",
        ///"publish_pages",
        ///"publish_actions",
        ///"rsvp_event"
        ///"read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
        ///"read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
        ///"manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
        ///</remarks>
        private void loginAndInit()
        {
            m_LoginResult = FacebookService.Login("287779573202574", /// (desig patter's "Design Patterns Course App 2.4" app)
					"email",
                    "public_profile",
                    "user_age_range",
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos",
                    "read_insights");

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void fetchUserInfo()
        {
            m_PictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            if (m_LoggedInUser.Posts.Count > 0)
            {
                m_TextBoxStatus.Text = m_LoggedInUser.Posts[0].Message;
            }
        }

        private void buttonLogin_Click(object i_Sender, EventArgs i_)
        {
            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            loginAndInit();
        }

        private void buttonSetStatus_Click(object i_Sender, EventArgs i_)
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(m_TextBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void linkPosts_LinkClicked(object i_Sender, LinkLabelLinkClickedEventArgs i_)
        {
            fetchPosts();
        }

        /// <summary>
        /// Fetching posts *** made by the logged in user ***:
        /// </summary>
        private void fetchPosts()
        {
            m_ListBoxPosts.Items.Clear();

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    m_ListBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    m_ListBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    m_ListBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (m_ListBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void linkFriends_LinkClicked(object i_Sender, LinkLabelLinkClickedEventArgs i_)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            m_ListBoxAlbums.Items.Clear();
            m_ListBoxAlbums.DisplayMember = "Name";
            foreach (Album album in m_LoggedInUser.Albums)
            {
                m_ListBoxAlbums.Items.Add(album);
                //album.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (m_ListBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void displaySelectedAlbum()
        {
            if (m_ListBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = m_ListBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    m_PictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    m_PictureBoxProfile.Image = m_PictureBoxProfile.ErrorImage;
                }
            }
        }

        private void labelEvents_LinkClicked(object i_Sender, LinkLabelLinkClickedEventArgs i_)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            m_ListBoxEvents.Items.Clear();
            m_ListBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                m_ListBoxEvents.Items.Add(fbEvent);
            }

            if (m_ListBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object i_Sender, EventArgs i_)
        {
            if (m_ListBoxFavoriteTeams.SelectedItems.Count == 1)
            {
                Page selectedTeam = m_ListBoxFavoriteTeams.SelectedItem as Page;
                m_PictureBoxFavoriteTeam.LoadAsync(selectedTeam.PictureNormalURL);
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object i_Sender, EventArgs i_)
        {
            if (m_ListBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = m_ListBoxEvents.SelectedItem as Event;
                m_PictureBoxEvent.LoadAsync(selectedEvent.Cover.SourceURL);
            }
        }

        private void linkFavoriteTeams_LinkClicked(object i_Sender, LinkLabelLinkClickedEventArgs i_)
        {
            fetchFavoriteTeams();
        }

        private void fetchFavoriteTeams()
        {
            m_ListBoxFavoriteTeams.Items.Clear();
            m_ListBoxFavoriteTeams.DisplayMember = "Name";
            foreach (Page team in m_LoggedInUser.FavofriteTeams)
            {
                m_ListBoxFavoriteTeams.Items.Add(team);
            }

            if (m_ListBoxFavoriteTeams.Items.Count == 0)
            {
                MessageBox.Show("No teams to retrieve :(");
            }
        }

        private void linkPages_LinkClicked(object i_Sender, LinkLabelLinkClickedEventArgs i_)
        {
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            m_ListBoxPages.Items.Clear();
            m_ListBoxPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    m_ListBoxPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (m_ListBoxPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void labelGroups_LinkClicked(object i_Sender, LinkLabelLinkClickedEventArgs i_)
        {
            m_ListBoxGroups.Items.Clear();
            m_ListBoxGroups.DisplayMember = "Name";

            try
            {
                foreach (Group group in m_LoggedInUser.Groups)
                {
                    m_ListBoxGroups.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (m_ListBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object i_Sender, EventArgs i_)
        {
            if (m_ListBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = m_ListBoxGroups.SelectedItem as Group;
                m_PictureBoxGroup.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }

        private void listBoxPages_SelectedIndexChanged(object i_Sender, EventArgs i_)
        {
            if (m_ListBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = m_ListBoxPages.SelectedItem as Page;
                m_PictureBoxPage.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void linkUserActions_LinkClicked(object i_Sender, LinkLabelLinkClickedEventArgs i_)
        {
            string actionType = m_ComboBoxActionType.SelectedItem.ToString();
            FacebookObjectCollection<Page> actions = FacebookService.GetCollection<Page>(actionType);
            dynamic actionsData = FacebookService.GetDynamicData(actionType);
            m_DataGridViewActions.DataSource = actions;
        }

        /// <summary>
        /// Fetching all comments *** made by the logged in user ***, to the selected post:
        /// </summary>
        //private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Post selected = m_LoggedInUser.Posts[listBoxPosts.SelectedIndex];
        //    listBoxPostComments.DisplayMember = "Message";
        //    listBoxPostComments.DataSource = selected.Comments;
        //}

        private void buttonLogout_Click(object i_Sender, EventArgs i_)
        {
            FacebookService.LogoutWithUI();
            m_LoginResult = null;
        }

        private void listBoxAlbums_SelectedIndexChanged(object i_Sender, EventArgs i_)
        {
            displaySelectedAlbum();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(569, 419);
            this.Name = "FormMain";
            this.ResumeLayout(false);

        }

        //        private void listBoxPostComments_DoubleClick(object sender, EventArgs e)
        //        {
        //            if (listBoxPostComments.SelectedItems.Count == 1)
        //            {
        //                try
        //                {
        //                    (listBoxPostComments.SelectedItem as Comment).Like();
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show(
        //@"posting LIKEs is no longer supported :(
        //(OAuthException - #3) 
        //Publishing likes through the API is only available for page access tokens");
        //                }
        //            }
        //        }

        //FormAppSettings m_FormAppSettings = null;
        //private void buttonSettings_Click(object sender, EventArgs e)
        //{
        //    if (m_FormAppSettings == null)
        //    {
        //        m_FormAppSettings = new FormAppSettings();
        //    }
        //    m_FormAppSettings.ShowDialog();
        //}
    }

}
