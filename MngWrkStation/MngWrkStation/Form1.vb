
Public Class Form1
    Dim objNetwork, strComputer, objComputer, strOrigName, strOrigWrkGrp, ErrCode
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objNetwork = CreateObject("WScript.Network")
        strComputer = objNetwork.ComputerName
        objComputer = GetObject("winmgmts:{impersonationLevel=Impersonate}!\\" & strComputer & "\root\cimv2:Win32_ComputerSystem.Name='" & strComputer & "'")


        If objComputer.PartOfDomain = True Then
            Label2.Text = "Curent Domain:"
        End If

        strOrigName = objNetwork.ComputerName
        txtCurCompName.Text = strOrigName

        strOrigWrkGrp = objComputer.Domain
        txtCurDomain.Text = strOrigWrkGrp

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
        Label2.Text = "Workgroup Name:"
        txtCurCompName.Enabled = True
        txtCurDomain.Enabled = False
        txtCurCompName.Focus()
        'btnOK.Enabled = True
    End Sub


    Private Sub rbutDomain_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbutDomain.CheckedChanged
        Label2.Text = "Domain Name:"
        txtCurCompName.Enabled = False
        txtCurDomain.Enabled = True
        txtCurDomain.Focus()

    End Sub

    Private Sub rbutWrkGrp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbutWrkGrp.CheckedChanged
        Label2.Text = "Workgroup Name:"
        txtCurCompName.Enabled = False
        txtCurDomain.Enabled = True
        txtCurDomain.Focus()

    End Sub

    Private Sub txtCurCompName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurCompName.TextChanged
        If txtCurCompName.Text <> strOrigName Then
            btnOK.Enabled = True
        Else
            btnOK.Enabled = False
        End If
    End Sub

    Private Sub txtCurDomain_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurDomain.TextChanged
        If txtCurDomain.Text <> strOrigWrkGrp Then
            btnOK.Enabled = True
        Else
            btnOK.Enabled = False
        End If
    End Sub
End Class
