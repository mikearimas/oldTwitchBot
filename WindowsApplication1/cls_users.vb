Imports System.IO
Public Class cls_users

    Private _sTwitchName As String
    Private _sClass As String
    Private _sLevel As Integer
    Private _sExp As Integer
    Private _sHP As Integer
    Private _sATK As Integer
    Private _sDEF As Integer
    Private _sItemfind As Integer

    Dim userlistRPG_file As String
    Dim userlistRPG_fstream As FileStream

    Dim userlistRPG_streamReader As StreamReader = Nothing
    Dim userlistRPG_streamwriter As StreamWriter = Nothing

    Public messageReceive As String = String.Empty 'messaged received



    Public Sub createRPGCSVUserFile(userlistRPG_file As String)

        If Not My.Computer.FileSystem.FileExists(userlistRPG_file) Then
            userlistRPG_fstream = New FileStream(userlistRPG_file, FileMode.Create, FileAccess.ReadWrite)
            userlistRPG_streamwriter = New StreamWriter(userlistRPG_fstream)
            userlistRPG_streamreader = New StreamReader(userlistRPG_fstream)

        Else
            userlistRPG_fstream = New FileStream(userlistRPG_file, FileMode.Open, FileAccess.ReadWrite)
            userlistRPG_streamwriter = New StreamWriter(userlistRPG_fstream)
            userlistRPG_streamreader = New StreamReader(userlistRPG_fstream)
        End If

    End Sub

    'Public Sub createRPGChar(ByVal twitchUserName As String)

    '    userlistRPG_streamReader.ReadToEnd()

    '    userlistRPG_streamReader.


    'End Sub

End Class

'Public Sub New(ByVal twitchUserName As String, ByVal userclass As String, ByVal expPoints As Integer, ByVal userLevel As Integer, ByVal userHP As Integer, ByVal userATK As Integer, ByVal userDEF As Integer, ByVal itemFindPercent As Integer)
'    Me._sTwitchName = twitchUserName
'    Me._sClass = userclass
'    Me._sExp = expPoints
'    Me._sLevel = userLevel
'    Me._sHP = userHP
'    Me._sATK = userATK
'    Me._sDEF = userDEF
'    Me._sItemfind = itemFindPercent
'End Sub


