Imports System.Data.OleDb
Module Module1
    Public cn As OleDbConnection
    Public Sub ConnectDB()
        cn = New OleDbConnection("Provider=Microsoft.ace.oledb.12.0;data _ 
source=C:\Users\HIMANI SONEWANE\Documents\Sign up new1.accdb")
        cn.Open()
    End Sub
End Module
