
Public Class Form1
    Dim objNetwork, strComputer, objComputer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objNetwork = CreateObject("WScript.Network")
        strComputer = objNetwork.ComputerName
        objComputer = GetObject("winmgmts:{impersonationLevel=Impersonate}!\\" & strComputer & "\root\cimv2:Win32_ComputerSystem.Name='" & strComputer & "'")


        If objComputer.PartOfDomain = True Then
            Label2.Text = "Curent Domain:"
        End If


        txtCurCompName.Text = strComputer
    End Sub
End Class
