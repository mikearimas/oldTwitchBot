Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class cls_twitchTV
    Public stream As jsonStream
    Public Class jsonStream
        Public game As String
        Public viewers As Integer

        Public channel As jsonChannel
        Public Class jsonChannel
            Public Property status As String
            Public Property followers As Integer
            Public Property views As Integer
        End Class
    End Class
End Class

Public Class cls_tmiTwitchTV
    Public chatter_count As Integer
    Public chatters As jsonchatters
    Public Class jsonchatters

        Public moderators() As String
        Public staff() As String
        Public admins() As String
        Public global_mods() As String
        Public viewers() As String

    End Class


End Class