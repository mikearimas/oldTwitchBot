Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frm_master


    Dim frmconfig, frmchat As New Form
    Dim goBot As cls_irc
    ' Dim userChatCommands As mod_chatcommands
    Dim botNick, streamName, authKey, serverName, portNum, streamMessage, newMessage, chatMessage, chtFirstParseCollon, chtSecondParse, chatSpeaker, json_url, streamJson, streamTmiJson, tmi_url As String
    Dim streamJson2, json_url2 As String
    Dim chtCmdID = "PRIVMSG"
    Private threadChatTask As Thread
    Dim twitchtv, twitchtv2 As cls_twitchTV
    Dim tmitv As cls_tmiTwitchTV
    Dim m_webclient, m_webclient2 As New WebClient
    Dim m_running As Boolean = False
    Dim threadrunning As Boolean = True
    Dim threadChatRunning As Boolean = False
    Public currentTime = DateTime.Now
    Dim threadcounter As Integer = 0
    Dim imgList As ImageList
    Dim viewerList As New ArrayList
    Dim viewerlistold As New ArrayList
    Dim viewerlistcounter As Integer = 0

    Dim userlist_file As String = My.Settings.UserFiles & streamName & ".csv"
    Dim userlist_fstream As FileStream
    Dim userlist_streamwriter As StreamWriter = Nothing

    Dim userlistRPG_file As String = My.Settings.RPGUserFiles & streamName & ".csv"
    Dim userlistRPG_fstream As FileStream
    Dim userlistRPG_streamwriter As StreamWriter = Nothing
    Dim rpgThreadRunning As Boolean = False



    Dim monsterExist As Boolean = False
    Dim monsterhp, remainingMonsterHp As Integer
    Dim playerDamageGenerator As System.Random = New Random
    Dim playerDamage = playerDamageGenerator.Next(1, 100)
    Dim lootGenerator As System.Random = New Random
    Dim lootChance = lootGenerator.Next(1, 100)

    Private Sub frm_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        threadChatTask = New Thread(New ThreadStart(AddressOf loadtwitchapi))
        'threatGoRPGTask = New Thread(New ThreadStart(AddressOf goRPG))
        Try

            txt_botUserName.Text = My.Settings.BotUserName
            txt_serverName.Text = My.Settings.ServerName
            txt_authKey.Text = My.Settings.AuthenticationKey
            txt_streamName.Text = My.Settings.StreamName
            cmb_portNum.Text = My.Settings.PortNumber
        Catch ex As Exception

        End Try

        Dim imgList As New ImageList
        ' imgList.Images.Add("Staff", Image.FromFile(""))


    End Sub


    Private Sub frm_master_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If bw_readChat.IsBusy Then
            bw_readChat.CancelAsync()
        End If

        If Not IsNothing(pingTimer) Then
            pingTimer.Stop()
        End If

        If Not IsNothing(goBot) Then
            chatAndConnectionTimer.Stop()
        End If

        If threadrunning = True Then
            threadrunning = False
        End If

        If threadChatRunning = True Then
            threadChatRunning = False
        End If

        If Not IsNothing(goBot) Then
            goBot.Disconnect()
        End If

        Try
            userlist_fstream.Close()
            userlist_streamwriter.Close()
        Catch ex As Exception

        End Try

    End Sub



    Public Sub checkConnection()
        If (goBot.tcpClie.Connected = False) Then
            goBot.Disconnect()
            goBot.Connect()
        End If
    End Sub


    Public Sub pingTimer_tick(sender As Object, e As EventArgs) Handles pingTimer.Tick
        goBot.sendIRCping("PING")
    End Sub

    Private Sub listUser_MouseDown(sender As Object, e As MouseEventArgs) Handles listUser.MouseDown
        If (e.Button = MouseButtons.Right) Then
            listUser.SelectedIndex = listUser.IndexFromPoint(e.X, e.Y)
        End If
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        Debug.Print(listUser.SelectedItem.ToString)
    End Sub

    Private Sub chatAndConnectionTimer_Tick(sender As Object, e As EventArgs) Handles chatAndConnectionTimer.Tick
        ' readChatTask()
        checkConnection()
        Me.toolStripStatus_Connection.Text = goBot.updateStatus
    End Sub

    Private Sub InvokeUpdateChatRoom(ByVal chatSpeaker As String, ByVal chatMessage As String)
        If Me.InvokeRequired Then
            Dim d As New UpdateChatRoomDelegate(AddressOf Me.updateChatRoom)
            Try
                Me.Invoke(d, chatSpeaker, chatMessage)
            Catch
            End Try
        Else
            Me.updateChatRoom(chatSpeaker, chatMessage)
        End If
    End Sub
    Private Delegate Sub UpdateChatRoomDelegate(ByVal chatSpeaker As String, ByVal chatMessage As String) 'HELLO FIX THIS LATER

    Private Sub updateChatRoom(ByVal chatSpeaker As String, ByVal chatMessage As String)

        If chatMessage.StartsWith("!") Then
            txtbox_chatRoom.AppendText(chatSpeaker & ":" & " " & chatMessage & vbCrLf)
            Me.checkCommands(chatMessage, chatSpeaker)
        Else
            txtbox_chatRoom.AppendText(chatSpeaker & ":" & " " & chatMessage & vbCrLf)
        End If

    End Sub

    Private Sub bw_readChat_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw_readChat.DoWork
        bw_readChat.WorkerSupportsCancellation = True

        While (goBot.tcpClie.Available > 0) Or (goBot.streamReader.Peek() >= 0) AndAlso threadChatRunning = True And Not bw_readChat.CancellationPending
            Do
                Try
                    Console.ReadLine()
                    newMessage = goBot.streamReader.ReadLine
                Catch
                End Try
                chtFirstParseCollon = newMessage.IndexOf(":", 1)

                If (chtFirstParseCollon > 0) Then
                    chtSecondParse = newMessage.Substring(1, chtFirstParseCollon)
                    If (chtSecondParse.Contains(goBot.chtCMDID)) Then
                        Dim userGet = chtSecondParse.IndexOf("!")
                        If (userGet > 0) Then
                            chatSpeaker = chtSecondParse.Substring(0, userGet)
                            chatMessage = newMessage.Substring(chtFirstParseCollon + 1)

                            Me.InvokeUpdateChatRoom(chatSpeaker:=chatSpeaker, chatMessage:=chatMessage)

                            If bw_readChat.CancellationPending Then
                                ' bw_readChat.CancelAsync()
                                e.Cancel = True
                                Return
                            End If

                        End If

                    End If

                End If
            Loop
            If bw_readChat.CancellationPending Then
                ' bw_readChat.CancelAsync()
                e.Cancel = True
                Return
            End If
        End While

    End Sub

    Private Sub txtbox_sendMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_sendMessage.KeyDown
        If e.KeyCode = Keys.Enter Then
            streamMessage = txtbox_sendMessage.Text
            goBot.sendChatMessage(streamMessage)
            txtbox_chatRoom.AppendText("GoBot_Alpha: " & streamMessage & vbCrLf)
            txtbox_sendMessage.Text = ""

        End If
    End Sub



    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click

        If btn_connect.Text = "Connect" Then
            Try
                botNick = txt_botUserName.Text
                streamName = txt_streamName.Text
                authKey = txt_authKey.Text
                serverName = txt_serverName.Text
                portNum = CInt(cmb_portNum.SelectedItem.ToString)

                goBot = New cls_irc(serverName, streamName, botNick, authKey, portNum, False)
                'goBot.setConnectionInfo(serverName, streamName, botNick, authKey, portNum, False)
                goBot.Connect()
                Debug.Print(goBot.updateStatus)
                txt_connectedChanName.Text = goBot.channelName


                If m_running = False And threadrunning = False Then

                    Try
                        threadChatTask = New Thread(New ThreadStart(AddressOf loadtwitchapi))

                        m_running = True
                        threadrunning = True
                    Catch ex As Exception

                    End Try

                ElseIf m_running = False And threadrunning = True Then


                    m_running = True
                    threadrunning = True
                End If


                If threadChatRunning = False Then
                    threadChatRunning = True
                End If

                Try
                    threadChatTask.Start() 'testing using backgroundworker
                    'bw_checkConnection.RunWorkerAsync()
                Catch

                End Try


                chatAndConnectionTimer.Enabled = True
                pingTimer.Enabled = True

                My.Settings.BotUserName = botNick
                My.Settings.StreamName = streamName
                My.Settings.AuthenticationKey = authKey
                My.Settings.ServerName = serverName
                My.Settings.PortNumber = portNum


                If bw_readChat.IsBusy Then
                    bw_readChat.CancelAsync()
                End If
                If Not bw_readChat.IsBusy Then
                    bw_readChat.RunWorkerAsync()
                End If

                checkConnection()
                Me.toolStripStatus_Connection.Text = goBot.updateStatus
                Try
                    userlist_file = My.Settings.UserFiles & streamName & ".csv"
                    createCSVUserFile(userlist_file)
                Catch
                End Try

                json_url2 = String.Format("https://api.twitch.tv/kraken/streams/{0}", streamName)

                    Try
                        streamJson2 = m_webclient2.DownloadString(json_url2)

                    Catch ex As Exception
                        Me.invokeUpdateViewerNumber("Twitch API currently offline")
                        txtbox_chatRoom.AppendText(String.Format("An error occured when connecting to the Twitch API: {0}" & vbCrLf, ex))
                    End Try

                    twitchtv2 = JsonConvert.DeserializeObject(Of cls_twitchTV)(streamJson2)
                    txtbox_streamInfo_Title.Text = twitchtv2.stream.channel.status.ToString
                    cmb_streamInfo_Playing.Text = twitchtv2.stream.game.ToString

                    txtbox_chatRoom.AppendText(String.Format("Successfully connected to Channel: {0}" & vbCrLf, streamName))
                    btn_connect.Text = "Disconnect" 'keep this at end to ensure that full method run before disconnect options i
                Catch ex As Exception

                End Try


        ElseIf btn_connect.Text = "Disconnect" Then
            Try

                If bw_readChat.IsBusy Then
                    bw_readChat.CancelAsync()
                End If

                If Not IsNothing(pingTimer) Then

                    pingTimer.Stop()

                End If

                If Not IsNothing(goBot) Then
                    chatAndConnectionTimer.Stop()
                End If


                If threadrunning = True Then
                    threadrunning = False
                End If

                If m_running = True Then
                    m_running = False
                End If

                If threadChatRunning = True Then
                    threadChatRunning = False
                End If


                If Not IsNothing(goBot) Then
                    goBot.Disconnect()
                    ' goBot.tcpClie.Close()
                End If

                Try
                    userlist_fstream.Close()
                    userlist_streamwriter.Close()
                Catch ex As Exception

                End Try

                btn_connect.Text = "Connect"
                Debug.Print("Disconnected to Server")
                Me.toolStripStatus_Connection.Text = goBot.updateStatus
                Me.invokeUpdateViewerNumber("Not Online")
                threadcounter = 0
                listUser.Items.Clear()

            Catch ex As Exception
                MsgBox("An exception has occured:" & vbCrLf & ex.Message)

            End Try


        End If

    End Sub

    Private Sub goRPG()

        Dim userRPG As New cls_users

        Do





        Loop While rpgThreadRunning = True


    End Sub
    Public Sub loadtwitchapi()
        Do
            json_url = String.Format("https://api.twitch.tv/kraken/streams/{0}", streamName)
            tmi_url = String.Format("https://tmi.twitch.tv/group/user/{0}/chatters", streamName)
            'Debug.Print(json_url)
            Try
                streamJson = m_webclient.DownloadString(json_url)
                streamTmiJson = m_webclient.DownloadString(tmi_url)
            Catch
                Me.invokeUpdateViewerNumber("Twitch API currently offline")

            End Try
            Try
                twitchtv = JsonConvert.DeserializeObject(Of cls_twitchTV)(streamJson)
                tmitv = JsonConvert.DeserializeObject(Of cls_tmiTwitchTV)(streamTmiJson)
            Catch ex As Exception

            End Try

            Try
                Me.invokeUpdateChatterNumber(tmitv.chatter_count.ToString)
                Me.invokeUpdateChatter(tmitv.chatters.moderators, tmitv.chatters.staff, tmitv.chatters.admins, tmitv.chatters.viewers)
                Me.invokeUpdateViewerNumber(twitchtv.stream.viewers.ToString)

            Catch

            End Try

            If IsNothing(twitchtv.stream) Then

                Debug.Print("The Stream Is Not Online")
                Me.invokeUpdateViewerNumber("Not Online")

            End If

            Thread.Sleep(5000)
        Loop While m_running = True And threadrunning = True
        'close thread
        'threadChatTask.Close()

    End Sub

    Private Sub invokeUpdateChatter(ByVal moderator As String(), ByVal staff As String(), ByVal admins As String(), ByVal viewers As String())
        If Me.InvokeRequired Then
            Dim d As New updateChatterDelegate(AddressOf Me.updateChatter)
            Me.Invoke(d, moderator, staff, admins, viewers)
        Else
            Me.updateChatter(_moderator:=moderator, _staff:=staff, _admins:=admins, _viewers:=viewers)
        End If

    End Sub

    Private Delegate Sub updateChatterDelegate(ByVal moderator As String(), ByVal staff As String(), ByVal admins As String(), ByVal viewers As String())

    Private Sub updateChatter(ByVal _moderator As String(), ByVal _staff As String(), ByVal _admins As String(), ByVal _viewers As String())

        'listUser.Items.Clear()

        For Each moderator In _moderator
            If Not viewerList.Contains(moderator) Then
                viewerList.Add(moderator)
            End If
        Next

        For Each staff In _staff
            If Not viewerList.Contains(staff) Then
                viewerList.Add(staff)
            End If
        Next

        For Each admin In _admins
            If Not viewerList.Contains(admin) Then
                viewerList.Add(admin)
            End If
        Next

        For Each viewer As String In _viewers
            If Not viewerList.Contains(viewer) Then
                viewerList.Add(viewer)
            End If
        Next

        If viewerlistcounter = 0 Then

            For Each viewer As String In viewerList
                listUser.Items.Add(viewer)
            Next

            For i As Integer = 0 To viewerList.Count - 1
                viewerlistold.Add(viewerList(i))
            Next

            viewerlistcounter = 1

            Return

        Else

            For Each viewer As String In viewerList

                If viewerlistold.Contains(viewer) And viewerList.Contains(viewer) Then

                    'do nothing 

                ElseIf viewerlistold.Contains(viewer) And Not viewerList.Contains(viewer) Then

                    listUser.Items.Remove(viewer)

                ElseIf Not viewerlistold.Contains(viewer) And viewerList.Contains(viewer) And Not listUser.Items.Contains(viewer) Then

                    listUser.Items.Add(viewer)
                End If

            Next

            viewerlistold.Clear()

            For i As Integer = 0 To viewerList.Count - 1
                viewerlistold.Add(viewerList(i))
            Next

            viewerList.Clear()
        End If
    End Sub


    Private Sub invokeUpdateViewerNumber(ByVal viewerNumber As String)
        If Me.InvokeRequired Then
            Dim d As New updateViewerNumberDelegate(AddressOf Me.updateViewerNumber)
            Me.Invoke(d, viewerNumber)
        Else
            Me.updateViewerNumber(viewernumber:=viewerNumber)
        End If

    End Sub

    Private Delegate Sub updateViewerNumberDelegate(ByVal viewerNumber As String)

    Private Sub updateViewerNumber(ByVal viewernumber As String)

        Me.txtbox_totalViewers.Text = String.Format("Total Viewers: {0}", viewernumber)

    End Sub
    Private Sub invokeUpdateChatterNumber(ByVal chatterNumber As String)
        If Me.InvokeRequired Then
            Dim d As New updateViewerNumberDelegate(AddressOf Me.updateChatterNumber)
            Me.Invoke(d, chatterNumber)
        Else
            Me.updateChatterNumber(chatterNumber:=chatterNumber)
        End If

    End Sub

    Private Delegate Sub updateChatterNumberDelegate(ByVal chatterNumber As String)

    Private Sub updateChatterNumber(ByVal chatterNumber As String)

        Me.txtbox_totalChatters.Text = String.Format("Total Chatters: {0}", chatterNumber)

    End Sub
    Private Sub btn_introduce_Click(sender As Object, e As EventArgs)
        goBot.sendChatMessage("Hello everyone! I am GoNub Bot Alpha. Please Do Not mind Me For I am kawaii-desu~~ :3")
    End Sub

    Private Sub DebugPopulateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DebugPopulateToolStripMenuItem.Click
        txt_botUserName.Text = "alpha_gonubbot"
        txt_streamName.Text = "gonub"
        txt_authKey.Text = "oauth:2fvmjnxkssn94og0ouqdj2kg3jg21y"
        cmb_portNum.SelectedIndex = 0
    End Sub

    Public Sub createCSVUserFile(userlist_file As String)

        If Not My.Computer.FileSystem.FileExists(userlist_file) Then
            userlist_fstream = New FileStream(userlist_file, FileMode.Create, FileAccess.ReadWrite)
            userlist_streamwriter = New StreamWriter(userlist_fstream)

        Else
            userlist_fstream = New FileStream(userlist_file, FileMode.Open, FileAccess.ReadWrite)
            userlist_streamwriter = New StreamWriter(userlist_fstream)
        End If

    End Sub



    'Public Sub createRPGCSVUserFile(userlistRPG_file As String)

    '    If Not My.Computer.FileSystem.FileExists(userlistRPG_file) Then
    '        userlistRPG_fstream = New FileStream(userlistRPG_file, FileMode.Create, FileAccess.ReadWrite)
    '        userlistRPG_streamwriter = New StreamWriter(userlistRPG_fstream)

    '    Else
    '        userlistRPG_fstream = New FileStream(userlistRPG_file, FileMode.Open, FileAccess.ReadWrite)
    '        userlistRPG_streamwriter = New StreamWriter(userlistRPG_fstream)
    '    End If


    'End Sub





    Public Sub checkCommands(ByVal receivedMessage As String, ByVal username As String, Optional ByVal timereceived As String = Nothing, Optional ByVal channelName As String = Nothing)

        'list of chatcommands
        Select Case receivedMessage.ToLower
            Case "!testhello"
                goBot.sendChatMessage("Hello " & username)
            Case "!testgoodbye"
                goBot.sendChatMessage("Goodbye " & username)
            Case "!testtime"
                currentTime = DateTime.Now
                goBot.sendChatMessage("It is " & currentTime & " " & username)
            Case "!love"
                goBot.sendChatMessage("I love you too " & username)
            Case "!lynboo"
                goBot.sendChatMessage("She's that Mrs. New Booty HeyGuys " & username)
            Case "!testmaid"
                goBot.sendChatMessage("Never won an SG #truestory, " & username)
            Case "!riot"
                goBot.sendChatMessage("SwiftRage WHY ARE WE YELLING?!, " & username)
            Case "!jbut"
                goBot.sendChatMessage("I heard he can't shoot and sleeps in class, " & username)
            Case "!kaz"
                goBot.sendChatMessage("They say his back is strong from carrying all day, " & username)
            Case "!leggod"
                goBot.sendChatMessage("They say his legs once were featured on the cover of Playboy magazine and many a man fapped to them, " & username)
            Case "!commands"
                goBot.sendChatMessage("MrDestructoid Current Commands: !testhello, !testgoodbye, !testtime, !love, !coinflip, !battlemonster, !lynboo, !testmaid, !jbut, !kaz, !leggod, !commands")
            Case "!coinflip"

                Static randomGenerator As System.Random = New Random
                Dim resultFlip = randomGenerator.Next(0, 100000)

                If resultFlip > 49999 Then

                    goBot.sendChatMessage("The coin came up heads! Result Number: " & resultFlip & " out of 100000")
                Else

                    goBot.sendChatMessage("The coin came up tails! Result Number: " & resultFlip & " out of 100000")

                End If

            Case "!kamehameha"
                If monsterExist = True And username = "gonub" Then
                    playerDamage = playerDamageGenerator.Next(1000, 5000)
                    remainingMonsterHp = remainingMonsterHp - playerDamage
                    username = username.ToUpper
                    goBot.sendChatMessage(String.Format("{0} YELLS KAMEHAMEHA!!!! THE MONSTER DISAPPEARS FROM THE FACE OF THE EARTH AND IS HIT FOR ... {1}! Current HP: {2}", username, playerDamage, remainingMonsterHp))
                    goBot.sendChatMessage(String.Format("{0} has attacked and vanquished the monster with his ultimate might. He must be super strong! All Hail {1} ! PS. I think he cheated", username, username))


                    lootChance = lootGenerator.Next(1, 101)

                    If lootChance < 1000 Then

                        goBot.sendChatMessage(String.Format("{0} has found the best loot in the game!", username))
                        goBot.sendChatMessage(String.Format("!give {0} 10000", username))
                        goBot.sendChatMessage(String.Format("Kappa Kappa Kappa"))
                    End If

                    monsterExist = False
                    Return


                End If


            Case "!battlemonster"
                If monsterExist = False Then
                    monsterExist = True
                    goBot.sendChatMessage(String.Format("{0} has called upon a monster to fight!", username))
                    Static monsterlvlgenerator As System.Random = New Random
                    Dim monsterlvl = monsterlvlgenerator.Next(1, 100)
                    If monsterlvl > 0 And monsterlvl <= 25 Then
                        monsterhp = 100

                        goBot.sendChatMessage(String.Format("Oh.. it is only a tiny beast! This should be no problem! Current HP:{0}", monsterhp))
                        'Dim playerDamageGenerator As System.Random = New Random
                        playerDamage = playerDamageGenerator.Next(1, 100)
                        remainingMonsterHp = monsterhp - playerDamage



                        If remainingMonsterHp > 0 Then
                            goBot.sendChatMessage(String.Format("{0} has attacked the monster for... {1}! Current HP: {2}", username, playerDamage, remainingMonsterHp))
                        ElseIf remainingMonsterHp < 0 Then
                            goBot.sendChatMessage(String.Format("{0} has vanquished the monster! All Hail {1} !", username, username))
                            monsterExist = False

                        End If

                    ElseIf monsterlvl > 25 And monsterlvl <= 50 Then

                        monsterhp = 500
                        goBot.sendChatMessage(String.Format("Oh.. it is a medium beast! We should be ok!! Current HP:{0}", monsterhp))
                        playerDamage = playerDamageGenerator.Next(1, 100)
                        remainingMonsterHp = monsterhp - playerDamage

                        If remainingMonsterHp > 0 Then
                            goBot.sendChatMessage(String.Format("{0} has attacked the monster for... {1}! Current HP: {2}", username, playerDamage, remainingMonsterHp))
                        ElseIf remainingMonsterHp < 0 Then
                            goBot.sendChatMessage(String.Format("{0} has vanquished the monster! All Hail {1} !", username, username))
                            monsterExist = False
                        End If


                    ElseIf monsterlvl > 50 And monsterlvl <= 75 Then

                        monsterhp = 750
                        goBot.sendChatMessage(String.Format("Oh.. it is a big beast! I'm a tad worried... Current HP:{0}", monsterhp))
                        playerDamage = playerDamageGenerator.Next(1, 100)
                        remainingMonsterHp = monsterhp - playerDamage

                        If remainingMonsterHp > 0 Then
                            goBot.sendChatMessage(String.Format("{0} has attacked the monster for... {1}! Current HP: {2}", username, playerDamage, remainingMonsterHp))
                        ElseIf remainingMonsterHp < 0 Then
                            goBot.sendChatMessage(String.Format("{0} has vanquished the monster! All Hail {1} !", username, username))
                            monsterExist = False
                        End If



                    ElseIf monsterlvl > 75 And monsterlvl <= 100 Then


                        monsterhp = 1000
                        goBot.sendChatMessage(String.Format("WHAT THE FUCK IS THAT THING RUN FOR YOUR LIVES!! Current HP:{0}", monsterhp))
                        playerDamage = playerDamageGenerator.Next(1, 100)
                        remainingMonsterHp = monsterhp - playerDamage

                        If remainingMonsterHp > 0 Then
                            goBot.sendChatMessage(String.Format("{0} has attacked the monster for... {1}! Current HP: {2}", username, playerDamage, remainingMonsterHp))
                        ElseIf remainingMonsterHp < 0 Then
                            goBot.sendChatMessage(String.Format("{0} has vanquished the monster! All Hail {1} !", username, username))
                            monsterExist = False
                        End If


                    End If

                ElseIf monsterExist = True Then

                    'If username = "jbutler925" Then
                    '    playerDamage = playerDamageGenerator.Next(1, 5)
                    '    remainingMonsterHp = remainingMonsterHp - playerDamage
                    '    username = username.ToUpper
                    '    goBot.sendChatMessage(String.Format("{0} WHAT ARE YOU DOING?! YOU HIT THE MONSTER FOR ... {1}! Current HP: {2}", username, playerDamage, remainingMonsterHp))
                    '    Return
                    'End If

                    'If username = "big_secksi" Then
                    '    playerDamage = playerDamageGenerator.Next(5, 10)
                    '    remainingMonsterHp = remainingMonsterHp - playerDamage
                    '    goBot.sendChatMessage(String.Format("{0} at least you're doing better then butler... You sadly hit the monster for ... {1}! Current HP: {2}", username, playerDamage, remainingMonsterHp))
                    '    Return
                    'End If


                    'If username = "gonub" Then
                    '    playerDamage = playerDamageGenerator.Next(1001, 2000)
                    '    remainingMonsterHp = remainingMonsterHp - playerDamage
                    '    goBot.sendChatMessage(String.Format("I don't know who is stronger the beast or gonub! gonub has attacked the monster for {0}", playerDamage))
                    '    goBot.sendChatMessage(String.Format("{0} has attacked and vanquished the monster with his ultimate might. He must be super strong! All Hail {1} ! PS. I think he cheated", username, username))
                    '    Return
                    'End If


                    playerDamage = playerDamageGenerator.Next(1, 101)
                    remainingMonsterHp = remainingMonsterHp - playerDamage

                    If remainingMonsterHp > 0 Then
                        goBot.sendChatMessage(String.Format("{0} has attacked the monster for... {1}! Current HP: {2}", username, playerDamage, remainingMonsterHp))
                    ElseIf remainingMonsterHp < 0 Then
                        goBot.sendChatMessage(String.Format("{0} has vanquished the monster! All Hail {1} !", username, username))
                        lootChance = lootGenerator.Next(1, 101)




                        If lootChance < 50 Then

                            goBot.sendChatMessage(String.Format("{0} has found some loot!", username))
                            goBot.sendChatMessage(String.Format("!give {0} 1", username))

                        ElseIf lootChance = 1 Then
                            goBot.sendChatMessage(String.Format("{0} has found A HUGE CHEST FULL OF LOOT!", username))
                            goBot.sendChatMessage(String.Format("!give {0} 100", username))

                        ElseIf lootChance < 10 And lootChance > 2 Then
                            goBot.sendChatMessage(String.Format("{0} has found a medium chest full of loot!", username))
                            goBot.sendChatMessage(String.Format("!give {0} 10", username))
                        End If



                        monsterExist = False
                    End If




                End If



        End Select

    End Sub
End Class

