Imports System.Net.Sockets
Imports System.Net
Imports System.IO
Imports System


Public Class cls_irc
    Private _sServer As String = String.Empty '-- IRC server name
    Private _sChannel As String = String.Empty '-- the channel you want to join (prefex with #)
    Private _sNickName As String = String.Empty '-- the nick name you want show up in the side bar
    Private _lPort As Int32 = 6667 '-- the port to connect to.  Default is 6667
    Private _bInvisible As Boolean = False '-- shows up as an invisible user.  Still working on this.
    Private _sRealName As String = "a_GoNubBot" '-- More naming
    Private _sUserName As String = "alpha_gonubbot" '-- Unique name so of the IRC network has a unique handle to you regardless of the nickname.
    Private _sAuthKey As String = String.Empty '--authkey needed to connect sort of like password
    Private _chatCMDID As String = "PRIVMSG"
    Private _chatMessageParse As String = ":" + _sUserName + "!" + _sUserName + "@" + _sUserName + ".tmi.twitch.tv " + _chatCMDID + " " + "#" + _sChannel + " " + ":"


    Private _tcpclientConnection As TcpClient = Nothing '-- main connection to the IRC network.
    Private _networkStream As NetworkStream = Nothing '-- break that connection down to a network stream.
    Public _streamWriter As StreamWriter = Nothing '-- provide a convenient access to writing commands.
    Public _streamReader As StreamReader = Nothing '-- provide a convenient access to reading commands.
    Public currentTime As DateTime

    Public messageReceive As String = String.Empty 'messaged received


    Public Property serverName As String
        Get
            Return _sServer
        End Get
        Set(value As String)
            _sServer = value
        End Set
    End Property

    Public Property channelName As String
        Get
            Return _sChannel
        End Get
        Set(value As String)
            _sChannel = value
        End Set
    End Property

    Public Property nickame As String
        Get
            Return _sNickName
        End Get
        Set(value As String)
            _sNickName = value
        End Set
    End Property

    Public Property authKey As String
        Get
            Return _sAuthKey
        End Get
        Set(value As String)
            _sAuthKey = value
        End Set
    End Property

    Public Property portNum As String
        Get
            Return _lPort
        End Get
        Set(value As String)
            _lPort = value
        End Set
    End Property

    Public Property tcpClie As TcpClient
        Get
            Return _tcpclientConnection
        End Get
        Set(value As TcpClient)
            _tcpclientConnection = value
        End Set
    End Property

    Public Property streamReader As StreamReader
        Get
            Return _streamReader
        End Get
        Set(value As StreamReader)
            _streamReader = value
        End Set
    End Property
    Public Property streamWriter As StreamWriter
        Get
            Return _streamWriter
        End Get
        Set(value As StreamWriter)
            _streamWriter = value
        End Set
    End Property

    Public Property chatParse As String
        Get
            Return _chatMessageParse
        End Get
        Set(value As String)
            _chatMessageParse = value
        End Set
    End Property

    Public Property chtCMDID As String
        Get
            Return _chatCMDID
        End Get
        Set(value As String)
            _chatCMDID = value
        End Set
    End Property
    Public Sub New(ByVal server As String, ByVal channel As String, ByVal nickname As String, ByVal authKey As String, ByVal port As Int32, ByVal invisible As Boolean)
        Me._sServer = server
        Me._sChannel = channel
        Me._sNickName = nickname
        Me._sAuthKey = authKey
        Me._lPort = port
        Me._bInvisible = invisible
    End Sub

    Public Sub Disconnect()

        _tcpclientConnection.Close()
        _tcpclientConnection.Client.Dispose()
        _streamReader.Close()
        _streamWriter.Close()
    End Sub
    Public Sub Connect()

        _tcpclientConnection = New TcpClient(_sServer, _lPort)
        _networkStream = _tcpclientConnection.GetStream
        tcpClie = _tcpclientConnection
        setStreamWriterAndReader(_networkStream)

        'connect to twitch chat
        _streamWriter.WriteLine("PASS " + _sAuthKey)
        _streamWriter.WriteLine("NICK " + _sNickName)
        _streamWriter.WriteLine("USER " + _sNickName + " 8 * :" + _sUserName)
        _streamWriter.Flush()


        'check people in chat
        _streamWriter.WriteLine("CAP REQ :twitch.tv/membership")

        'connect to channel
        _streamWriter.WriteLine("JOIN #" + _sChannel)
        _streamWriter.Flush()

        '_chatMessageParse = ":" + _sUserName + "!" + _sUserName + "@" + _sUserName + ".tmi.twitch.tv PRIVMSG #" + _sChannel + " " + ":"
        Me._chatMessageParse = ":" + _sUserName + "!" + _sUserName + "@" + _sUserName + ".tmi.twitch.tv " + _chatCMDID + " " + "#" + _sChannel + " " + ":"



    End Sub
    Public Sub sendChatMessage(ByVal message As String)
        ' _streamWriter.WriteLine(":" + _sUserName + "!" + _sUserName + "@" + _sUserName + ".tmi.twitch.tv PRIVMSG #" + _sChannel + " :" + message)
        _streamWriter.WriteLine(_chatMessageParse + message)
        _streamWriter.Flush()
    End Sub
    Public Sub sendIRCping(ByVal pingMessage As String)
        _streamWriter.WriteLine(pingMessage)
        _streamWriter.Flush()
    End Sub


    Public Sub setStreamWriterAndReader(ByRef netStream As NetworkStream)

        _streamReader = New StreamReader(netStream)
        _streamWriter = New StreamWriter(netStream)
    End Sub

    Public Function updateStatus()
        If (_tcpclientConnection.Connected = True) Then
            Return "Connected to Server"
        ElseIf (_tcpclientConnection.Connected = False) Then
            Return "Not Connected to Server"
        Else
            Return "Connecting to server..."
        End If
    End Function

    Public Function checkTCP()
        Return _tcpclientConnection
    End Function


End Class
