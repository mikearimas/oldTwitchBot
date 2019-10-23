<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_master
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_master))
        Me.tab_user = New System.Windows.Forms.TabControl()
        Me.tab_config = New System.Windows.Forms.TabPage()
        Me.cms_config = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DebugPopulateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_refreshStreamInfo = New System.Windows.Forms.Button()
        Me.btn_updateStreamInfo = New System.Windows.Forms.Button()
        Me.lbl_currentGame = New System.Windows.Forms.Label()
        Me.lbl_streamTitle = New System.Windows.Forms.Label()
        Me.cmb_streamInfo_Playing = New System.Windows.Forms.ComboBox()
        Me.txtbox_streamInfo_Title = New System.Windows.Forms.TextBox()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.cmb_portNum = New System.Windows.Forms.ComboBox()
        Me.lbl_portNum = New System.Windows.Forms.Label()
        Me.lbl_serverName = New System.Windows.Forms.Label()
        Me.txt_serverName = New System.Windows.Forms.TextBox()
        Me.lbl_authKey = New System.Windows.Forms.Label()
        Me.txt_authKey = New System.Windows.Forms.TextBox()
        Me.lbl_StreamName = New System.Windows.Forms.Label()
        Me.txt_streamName = New System.Windows.Forms.TextBox()
        Me.lbl_botUser = New System.Windows.Forms.Label()
        Me.txt_botUserName = New System.Windows.Forms.TextBox()
        Me.grpbox_Login = New System.Windows.Forms.GroupBox()
        Me.tab_chat = New System.Windows.Forms.TabPage()
        Me.txtbox_totalChatters = New System.Windows.Forms.TextBox()
        Me.txtbox_totalViewers = New System.Windows.Forms.TextBox()
        Me.listUser = New System.Windows.Forms.ListBox()
        Me.cms_listUser = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblChatName = New System.Windows.Forms.Label()
        Me.txt_connectedChanName = New System.Windows.Forms.TextBox()
        Me.txtbox_sendMessage = New System.Windows.Forms.TextBox()
        Me.txtbox_chatRoom = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_User = New System.Windows.Forms.DataGridView()
        Me.dgvuser_twitchName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgv_RPG = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bw_checkConnection = New System.ComponentModel.BackgroundWorker()
        Me.status_connection = New System.Windows.Forms.StatusStrip()
        Me.toolStripStatus_version = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStrip_spaces = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStripStatus_Connection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.chatAndConnectionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.bw_readChat = New System.ComponentModel.BackgroundWorker()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New System.Data.DataSet()
        Me.tab_user.SuspendLayout()
        Me.tab_config.SuspendLayout()
        Me.cms_config.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tab_chat.SuspendLayout()
        Me.cms_listUser.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_User, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_RPG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.status_connection.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab_user
        '
        Me.tab_user.Controls.Add(Me.tab_config)
        Me.tab_user.Controls.Add(Me.tab_chat)
        Me.tab_user.Controls.Add(Me.TabPage1)
        Me.tab_user.Controls.Add(Me.TabPage2)
        Me.tab_user.Location = New System.Drawing.Point(0, 45)
        Me.tab_user.Name = "tab_user"
        Me.tab_user.SelectedIndex = 0
        Me.tab_user.Size = New System.Drawing.Size(1478, 531)
        Me.tab_user.TabIndex = 0
        '
        'tab_config
        '
        Me.tab_config.BackColor = System.Drawing.SystemColors.Control
        Me.tab_config.ContextMenuStrip = Me.cms_config
        Me.tab_config.Controls.Add(Me.GroupBox1)
        Me.tab_config.Controls.Add(Me.btn_connect)
        Me.tab_config.Controls.Add(Me.cmb_portNum)
        Me.tab_config.Controls.Add(Me.lbl_portNum)
        Me.tab_config.Controls.Add(Me.lbl_serverName)
        Me.tab_config.Controls.Add(Me.txt_serverName)
        Me.tab_config.Controls.Add(Me.lbl_authKey)
        Me.tab_config.Controls.Add(Me.txt_authKey)
        Me.tab_config.Controls.Add(Me.lbl_StreamName)
        Me.tab_config.Controls.Add(Me.txt_streamName)
        Me.tab_config.Controls.Add(Me.lbl_botUser)
        Me.tab_config.Controls.Add(Me.txt_botUserName)
        Me.tab_config.Controls.Add(Me.grpbox_Login)
        Me.tab_config.Location = New System.Drawing.Point(4, 22)
        Me.tab_config.Name = "tab_config"
        Me.tab_config.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_config.Size = New System.Drawing.Size(1470, 505)
        Me.tab_config.TabIndex = 0
        Me.tab_config.Text = "Configuration"
        '
        'cms_config
        '
        Me.cms_config.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DebugPopulateToolStripMenuItem})
        Me.cms_config.Name = "cms_config"
        Me.cms_config.Size = New System.Drawing.Size(160, 26)
        '
        'DebugPopulateToolStripMenuItem
        '
        Me.DebugPopulateToolStripMenuItem.Name = "DebugPopulateToolStripMenuItem"
        Me.DebugPopulateToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.DebugPopulateToolStripMenuItem.Text = "Debug Populate"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_refreshStreamInfo)
        Me.GroupBox1.Controls.Add(Me.btn_updateStreamInfo)
        Me.GroupBox1.Controls.Add(Me.lbl_currentGame)
        Me.GroupBox1.Controls.Add(Me.lbl_streamTitle)
        Me.GroupBox1.Controls.Add(Me.cmb_streamInfo_Playing)
        Me.GroupBox1.Controls.Add(Me.txtbox_streamInfo_Title)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(980, 79)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stream Information"
        '
        'btn_refreshStreamInfo
        '
        Me.btn_refreshStreamInfo.Location = New System.Drawing.Point(6, 19)
        Me.btn_refreshStreamInfo.Name = "btn_refreshStreamInfo"
        Me.btn_refreshStreamInfo.Size = New System.Drawing.Size(82, 47)
        Me.btn_refreshStreamInfo.TabIndex = 32
        Me.btn_refreshStreamInfo.Text = "Refresh"
        Me.btn_refreshStreamInfo.UseVisualStyleBackColor = True
        '
        'btn_updateStreamInfo
        '
        Me.btn_updateStreamInfo.Location = New System.Drawing.Point(838, 19)
        Me.btn_updateStreamInfo.Name = "btn_updateStreamInfo"
        Me.btn_updateStreamInfo.Size = New System.Drawing.Size(127, 47)
        Me.btn_updateStreamInfo.TabIndex = 27
        Me.btn_updateStreamInfo.Text = "Update Stream Information"
        Me.btn_updateStreamInfo.UseVisualStyleBackColor = True
        '
        'lbl_currentGame
        '
        Me.lbl_currentGame.AutoSize = True
        Me.lbl_currentGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currentGame.Location = New System.Drawing.Point(487, 32)
        Me.lbl_currentGame.Name = "lbl_currentGame"
        Me.lbl_currentGame.Size = New System.Drawing.Size(63, 20)
        Me.lbl_currentGame.TabIndex = 31
        Me.lbl_currentGame.Text = "Playing:"
        '
        'lbl_streamTitle
        '
        Me.lbl_streamTitle.AutoSize = True
        Me.lbl_streamTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_streamTitle.Location = New System.Drawing.Point(101, 32)
        Me.lbl_streamTitle.Name = "lbl_streamTitle"
        Me.lbl_streamTitle.Size = New System.Drawing.Size(98, 20)
        Me.lbl_streamTitle.TabIndex = 30
        Me.lbl_streamTitle.Text = "Stream Title:"
        '
        'cmb_streamInfo_Playing
        '
        Me.cmb_streamInfo_Playing.FormattingEnabled = True
        Me.cmb_streamInfo_Playing.Location = New System.Drawing.Point(556, 32)
        Me.cmb_streamInfo_Playing.Name = "cmb_streamInfo_Playing"
        Me.cmb_streamInfo_Playing.Size = New System.Drawing.Size(235, 21)
        Me.cmb_streamInfo_Playing.TabIndex = 28
        '
        'txtbox_streamInfo_Title
        '
        Me.txtbox_streamInfo_Title.Location = New System.Drawing.Point(211, 32)
        Me.txtbox_streamInfo_Title.Name = "txtbox_streamInfo_Title"
        Me.txtbox_streamInfo_Title.Size = New System.Drawing.Size(270, 20)
        Me.txtbox_streamInfo_Title.TabIndex = 27
        '
        'btn_connect
        '
        Me.btn_connect.Location = New System.Drawing.Point(846, 33)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(127, 52)
        Me.btn_connect.TabIndex = 24
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.UseVisualStyleBackColor = True
        '
        'cmb_portNum
        '
        Me.cmb_portNum.FormattingEnabled = True
        Me.cmb_portNum.Items.AddRange(New Object() {"6667", "443"})
        Me.cmb_portNum.Location = New System.Drawing.Point(665, 84)
        Me.cmb_portNum.Name = "cmb_portNum"
        Me.cmb_portNum.Size = New System.Drawing.Size(121, 21)
        Me.cmb_portNum.TabIndex = 23
        '
        'lbl_portNum
        '
        Me.lbl_portNum.AutoSize = True
        Me.lbl_portNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_portNum.Location = New System.Drawing.Point(613, 85)
        Me.lbl_portNum.Name = "lbl_portNum"
        Me.lbl_portNum.Size = New System.Drawing.Size(59, 20)
        Me.lbl_portNum.TabIndex = 22
        Me.lbl_portNum.Text = "Port #: "
        '
        'lbl_serverName
        '
        Me.lbl_serverName.AutoSize = True
        Me.lbl_serverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_serverName.Location = New System.Drawing.Point(458, 85)
        Me.lbl_serverName.Name = "lbl_serverName"
        Me.lbl_serverName.Size = New System.Drawing.Size(59, 20)
        Me.lbl_serverName.TabIndex = 21
        Me.lbl_serverName.Text = "Server:"
        '
        'txt_serverName
        '
        Me.txt_serverName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_serverName.Location = New System.Drawing.Point(523, 81)
        Me.txt_serverName.Name = "txt_serverName"
        Me.txt_serverName.Size = New System.Drawing.Size(84, 24)
        Me.txt_serverName.TabIndex = 20
        Me.txt_serverName.Text = "irc.twitch.tv"
        '
        'lbl_authKey
        '
        Me.lbl_authKey.AutoSize = True
        Me.lbl_authKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_authKey.Location = New System.Drawing.Point(17, 81)
        Me.lbl_authKey.Name = "lbl_authKey"
        Me.lbl_authKey.Size = New System.Drawing.Size(146, 20)
        Me.lbl_authKey.TabIndex = 19
        Me.lbl_authKey.Text = "Authentication Key:"
        '
        'txt_authKey
        '
        Me.txt_authKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_authKey.Location = New System.Drawing.Point(169, 79)
        Me.txt_authKey.Name = "txt_authKey"
        Me.txt_authKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_authKey.Size = New System.Drawing.Size(235, 24)
        Me.txt_authKey.TabIndex = 18
        '
        'lbl_StreamName
        '
        Me.lbl_StreamName.AutoSize = True
        Me.lbl_StreamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StreamName.Location = New System.Drawing.Point(447, 33)
        Me.lbl_StreamName.Name = "lbl_StreamName"
        Me.lbl_StreamName.Size = New System.Drawing.Size(111, 20)
        Me.lbl_StreamName.TabIndex = 17
        Me.lbl_StreamName.Text = "Stream Name:"
        '
        'txt_streamName
        '
        Me.txt_streamName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_streamName.Location = New System.Drawing.Point(564, 29)
        Me.txt_streamName.Name = "txt_streamName"
        Me.txt_streamName.Size = New System.Drawing.Size(235, 24)
        Me.txt_streamName.TabIndex = 16
        '
        'lbl_botUser
        '
        Me.lbl_botUser.AutoSize = True
        Me.lbl_botUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_botUser.Location = New System.Drawing.Point(35, 33)
        Me.lbl_botUser.Name = "lbl_botUser"
        Me.lbl_botUser.Size = New System.Drawing.Size(122, 20)
        Me.lbl_botUser.TabIndex = 15
        Me.lbl_botUser.Text = "Bot User Name:"
        '
        'txt_botUserName
        '
        Me.txt_botUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_botUserName.Location = New System.Drawing.Point(169, 29)
        Me.txt_botUserName.Name = "txt_botUserName"
        Me.txt_botUserName.Size = New System.Drawing.Size(235, 24)
        Me.txt_botUserName.TabIndex = 14
        '
        'grpbox_Login
        '
        Me.grpbox_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbox_Login.Location = New System.Drawing.Point(8, 15)
        Me.grpbox_Login.Name = "grpbox_Login"
        Me.grpbox_Login.Size = New System.Drawing.Size(980, 100)
        Me.grpbox_Login.TabIndex = 26
        Me.grpbox_Login.TabStop = False
        Me.grpbox_Login.Text = "Bot Login"
        '
        'tab_chat
        '
        Me.tab_chat.BackColor = System.Drawing.SystemColors.Control
        Me.tab_chat.Controls.Add(Me.txtbox_totalChatters)
        Me.tab_chat.Controls.Add(Me.txtbox_totalViewers)
        Me.tab_chat.Controls.Add(Me.listUser)
        Me.tab_chat.Controls.Add(Me.lblChatName)
        Me.tab_chat.Controls.Add(Me.txt_connectedChanName)
        Me.tab_chat.Controls.Add(Me.txtbox_sendMessage)
        Me.tab_chat.Controls.Add(Me.txtbox_chatRoom)
        Me.tab_chat.Location = New System.Drawing.Point(4, 22)
        Me.tab_chat.Name = "tab_chat"
        Me.tab_chat.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_chat.Size = New System.Drawing.Size(1470, 505)
        Me.tab_chat.TabIndex = 1
        Me.tab_chat.Text = "Chat"
        '
        'txtbox_totalChatters
        '
        Me.txtbox_totalChatters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_totalChatters.Location = New System.Drawing.Point(1258, 41)
        Me.txtbox_totalChatters.Name = "txtbox_totalChatters"
        Me.txtbox_totalChatters.Size = New System.Drawing.Size(189, 22)
        Me.txtbox_totalChatters.TabIndex = 25
        Me.txtbox_totalChatters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbox_totalViewers
        '
        Me.txtbox_totalViewers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_totalViewers.Location = New System.Drawing.Point(1258, 14)
        Me.txtbox_totalViewers.Name = "txtbox_totalViewers"
        Me.txtbox_totalViewers.Size = New System.Drawing.Size(189, 22)
        Me.txtbox_totalViewers.TabIndex = 23
        Me.txtbox_totalViewers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'listUser
        '
        Me.listUser.ContextMenuStrip = Me.cms_listUser
        Me.listUser.FormattingEnabled = True
        Me.listUser.Location = New System.Drawing.Point(1258, 67)
        Me.listUser.MultiColumn = True
        Me.listUser.Name = "listUser"
        Me.listUser.Size = New System.Drawing.Size(189, 381)
        Me.listUser.TabIndex = 21
        '
        'cms_listUser
        '
        Me.cms_listUser.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
        Me.cms_listUser.Name = "cms_listUser"
        Me.cms_listUser.Size = New System.Drawing.Size(96, 26)
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'lblChatName
        '
        Me.lblChatName.AutoSize = True
        Me.lblChatName.Location = New System.Drawing.Point(8, 431)
        Me.lblChatName.Name = "lblChatName"
        Me.lblChatName.Size = New System.Drawing.Size(78, 13)
        Me.lblChatName.TabIndex = 20
        Me.lblChatName.Text = "Connected To:"
        '
        'txt_connectedChanName
        '
        Me.txt_connectedChanName.Location = New System.Drawing.Point(91, 428)
        Me.txt_connectedChanName.Name = "txt_connectedChanName"
        Me.txt_connectedChanName.Size = New System.Drawing.Size(141, 20)
        Me.txt_connectedChanName.TabIndex = 19
        '
        'txtbox_sendMessage
        '
        Me.txtbox_sendMessage.Location = New System.Drawing.Point(238, 428)
        Me.txtbox_sendMessage.Name = "txtbox_sendMessage"
        Me.txtbox_sendMessage.Size = New System.Drawing.Size(1006, 20)
        Me.txtbox_sendMessage.TabIndex = 18
        '
        'txtbox_chatRoom
        '
        Me.txtbox_chatRoom.Location = New System.Drawing.Point(8, 40)
        Me.txtbox_chatRoom.Multiline = True
        Me.txtbox_chatRoom.Name = "txtbox_chatRoom"
        Me.txtbox_chatRoom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbox_chatRoom.Size = New System.Drawing.Size(1234, 379)
        Me.txtbox_chatRoom.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.dgv_User)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1470, 505)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "User Database"
        '
        'dgv_User
        '
        Me.dgv_User.AllowUserToAddRows = False
        Me.dgv_User.AllowUserToDeleteRows = False
        Me.dgv_User.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_User.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvuser_twitchName, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgv_User.Location = New System.Drawing.Point(8, 50)
        Me.dgv_User.Name = "dgv_User"
        Me.dgv_User.Size = New System.Drawing.Size(1395, 387)
        Me.dgv_User.TabIndex = 0
        '
        'dgvuser_twitchName
        '
        Me.dgvuser_twitchName.HeaderText = "Twitch Name"
        Me.dgvuser_twitchName.Name = "dgvuser_twitchName"
        Me.dgvuser_twitchName.Width = 150
        '
        'Column1
        '
        Me.Column1.HeaderText = "Class"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Battle Tag"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Points"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Rank"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Hours Watched"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Date Joined"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'Column8
        '
        Me.Column8.HeaderText = "VIP Expiry"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 150
        '
        'Column9
        '
        Me.Column9.HeaderText = "Note"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 150
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.dgv_RPG)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1470, 505)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "RPG Database"
        '
        'dgv_RPG
        '
        Me.dgv_RPG.AllowUserToAddRows = False
        Me.dgv_RPG.AllowUserToDeleteRows = False
        Me.dgv_RPG.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv_RPG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_RPG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dgv_RPG.Location = New System.Drawing.Point(8, 50)
        Me.dgv_RPG.Name = "dgv_RPG"
        Me.dgv_RPG.Size = New System.Drawing.Size(1000, 387)
        Me.dgv_RPG.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Twitch Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Class"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Experience Points"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Level"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Health Points"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Attack Points"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Defence Points"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Item Find Percentage"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'bw_checkConnection
        '
        Me.bw_checkConnection.WorkerReportsProgress = True
        Me.bw_checkConnection.WorkerSupportsCancellation = True
        '
        'status_connection
        '
        Me.status_connection.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatus_version, Me.toolStrip_spaces, Me.toolStripStatus_Connection})
        Me.status_connection.Location = New System.Drawing.Point(0, 554)
        Me.status_connection.Name = "status_connection"
        Me.status_connection.Size = New System.Drawing.Size(1478, 22)
        Me.status_connection.TabIndex = 27
        Me.status_connection.Text = "StatusStrip1"
        '
        'toolStripStatus_version
        '
        Me.toolStripStatus_version.BackColor = System.Drawing.SystemColors.Control
        Me.toolStripStatus_version.Name = "toolStripStatus_version"
        Me.toolStripStatus_version.Size = New System.Drawing.Size(170, 17)
        Me.toolStripStatus_version.Text = "Welcome to GoNub Alpha v1.0"
        '
        'toolStrip_spaces
        '
        Me.toolStrip_spaces.BackColor = System.Drawing.SystemColors.Control
        Me.toolStrip_spaces.Name = "toolStrip_spaces"
        Me.toolStrip_spaces.Size = New System.Drawing.Size(119, 17)
        Me.toolStrip_spaces.Text = "   Connection Status: "
        '
        'toolStripStatus_Connection
        '
        Me.toolStripStatus_Connection.BackColor = System.Drawing.Color.Transparent
        Me.toolStripStatus_Connection.Name = "toolStripStatus_Connection"
        Me.toolStripStatus_Connection.Size = New System.Drawing.Size(88, 17)
        Me.toolStripStatus_Connection.Text = "Not Connected"
        '
        'chatAndConnectionTimer
        '
        Me.chatAndConnectionTimer.Interval = 5000
        '
        'pingTimer
        '
        Me.pingTimer.Interval = 300000
        '
        'bw_readChat
        '
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'frm_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1478, 576)
        Me.Controls.Add(Me.status_connection)
        Me.Controls.Add(Me.tab_user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frm_master"
        Me.Text = "Alpha GoNubBot"
        Me.tab_user.ResumeLayout(False)
        Me.tab_config.ResumeLayout(False)
        Me.tab_config.PerformLayout()
        Me.cms_config.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tab_chat.ResumeLayout(False)
        Me.tab_chat.PerformLayout()
        Me.cms_listUser.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_User, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_RPG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.status_connection.ResumeLayout(False)
        Me.status_connection.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tab_config As TabPage
    Friend WithEvents tab_chat As TabPage
    Friend WithEvents btn_connect As Button
    Friend WithEvents cmb_portNum As ComboBox
    Friend WithEvents lbl_portNum As Label
    Friend WithEvents lbl_serverName As Label
    Friend WithEvents txt_serverName As TextBox
    Friend WithEvents lbl_authKey As Label
    Friend WithEvents txt_authKey As TextBox
    Friend WithEvents lbl_StreamName As Label
    Friend WithEvents txt_streamName As TextBox
    Friend WithEvents lbl_botUser As Label
    Friend WithEvents txt_botUserName As TextBox
    Friend WithEvents cms_config As ContextMenuStrip
    Friend WithEvents DebugPopulateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblChatName As Label
    Friend WithEvents txt_connectedChanName As TextBox
    Friend WithEvents txtbox_sendMessage As TextBox
    Friend WithEvents txtbox_chatRoom As TextBox
    Friend WithEvents bw_checkConnection As System.ComponentModel.BackgroundWorker
    Friend WithEvents status_connection As StatusStrip
    Friend WithEvents toolStripStatus_version As ToolStripStatusLabel
    Friend WithEvents toolStripStatus_Connection As ToolStripStatusLabel
    Friend WithEvents toolStrip_spaces As ToolStripStatusLabel
    Friend WithEvents chatAndConnectionTimer As Timer
    Friend WithEvents grpbox_Login As GroupBox
    Friend WithEvents pingTimer As Timer
    Friend WithEvents listUser As ListBox
    Friend WithEvents bw_readChat As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtbox_totalViewers As TextBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgv_User As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_refreshStreamInfo As Button
    Friend WithEvents btn_updateStreamInfo As Button
    Friend WithEvents lbl_currentGame As Label
    Friend WithEvents lbl_streamTitle As Label
    Friend WithEvents cmb_streamInfo_Playing As ComboBox
    Friend WithEvents txtbox_streamInfo_Title As TextBox
    Friend WithEvents cms_listUser As ContextMenuStrip
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtbox_totalChatters As TextBox
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents tab_user As TabControl
    Friend WithEvents dgv_RPG As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents dgvuser_twitchName As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet1 As DataSet
End Class
