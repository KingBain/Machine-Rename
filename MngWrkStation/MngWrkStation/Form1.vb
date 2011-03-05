
Public Class Form1
    Dim objNetwork, strComputer, objComputer, ErrCode
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objNetwork = CreateObject("WScript.Network")
        strComputer = objNetwork.ComputerName
        objComputer = GetObject("winmgmts:{impersonationLevel=Impersonate}!\\" & strComputer & "\root\cimv2:Win32_ComputerSystem.Name='" & strComputer & "'")


        If objComputer.PartOfDomain = True Then
            Label2.Text = "Curent Domain:"
        End If

        txtCurCompName.Text = objNetwork.ComputerName
        txtCurDomain.Text = objComputer.Domain
    End Sub

    Private Sub btnCan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCan.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        ErrCode = objComputer.Rename(txtCurCompName.Text)
        If ErrCode = 0 Then
            lblStatus.Text = "Computer renamed correctly."
        Else
            lblStatus.Text = "Error changing computer name."
        End If

    End Sub




    Private Sub rbutRename_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbutRename.CheckedChanged
        txtCurCompName.Enabled = True
        txtCurCompName.Focus()
        btnOK.Enabled = True




    End Sub


End Class
