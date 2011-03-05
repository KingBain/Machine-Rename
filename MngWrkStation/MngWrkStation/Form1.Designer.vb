<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rbutWrkGrp = New System.Windows.Forms.RadioButton()
        Me.rbutDomain = New System.Windows.Forms.RadioButton()
        Me.rbutRename = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurDomain = New System.Windows.Forms.TextBox()
        Me.txtCurCompName = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.cmbContainer = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbutWrkGrp
        '
        Me.rbutWrkGrp.AutoSize = True
        Me.rbutWrkGrp.Location = New System.Drawing.Point(100, 101)
        Me.rbutWrkGrp.Name = "rbutWrkGrp"
        Me.rbutWrkGrp.Size = New System.Drawing.Size(100, 17)
        Me.rbutWrkGrp.TabIndex = 8
        Me.rbutWrkGrp.TabStop = True
        Me.rbutWrkGrp.Text = "Join Workgroup"
        Me.rbutWrkGrp.UseVisualStyleBackColor = True
        '
        'rbutDomain
        '
        Me.rbutDomain.AutoSize = True
        Me.rbutDomain.Location = New System.Drawing.Point(100, 85)
        Me.rbutDomain.Name = "rbutDomain"
        Me.rbutDomain.Size = New System.Drawing.Size(83, 17)
        Me.rbutDomain.TabIndex = 9
        Me.rbutDomain.TabStop = True
        Me.rbutDomain.Text = "Join Domain"
        Me.rbutDomain.UseVisualStyleBackColor = True
        '
        'rbutRename
        '
        Me.rbutRename.AutoSize = True
        Me.rbutRename.Location = New System.Drawing.Point(100, 68)
        Me.rbutRename.Name = "rbutRename"
        Me.rbutRename.Size = New System.Drawing.Size(113, 17)
        Me.rbutRename.TabIndex = 10
        Me.rbutRename.TabStop = True
        Me.rbutRename.Text = "Rename Computer"
        Me.rbutRename.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Computer Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCurDomain
        '
        Me.txtCurDomain.Enabled = False
        Me.txtCurDomain.Location = New System.Drawing.Point(100, 37)
        Me.txtCurDomain.Name = "txtCurDomain"
        Me.txtCurDomain.Size = New System.Drawing.Size(197, 20)
        Me.txtCurDomain.TabIndex = 4
        '
        'txtCurCompName
        '
        Me.txtCurCompName.Enabled = False
        Me.txtCurCompName.Location = New System.Drawing.Point(100, 11)
        Me.txtCurCompName.Name = "txtCurCompName"
        Me.txtCurCompName.Size = New System.Drawing.Size(197, 20)
        Me.txtCurCompName.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 178)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(330, 79)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(79, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Machine Renamer"
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Location = New System.Drawing.Point(7, 62)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(7, 95)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(75, 23)
        Me.btnCan.TabIndex = 13
        Me.btnCan.Text = "Close"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'cmbContainer
        '
        Me.cmbContainer.Enabled = False
        Me.cmbContainer.FormattingEnabled = True
        Me.cmbContainer.Location = New System.Drawing.Point(7, 133)
        Me.cmbContainer.Name = "cmbContainer"
        Me.cmbContainer.Size = New System.Drawing.Size(290, 21)
        Me.cmbContainer.TabIndex = 14
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.Black
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(97, 207)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(81, 13)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Program loaded"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Workgroup Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 257)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmbContainer)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rbutWrkGrp)
        Me.Controls.Add(Me.rbutDomain)
        Me.Controls.Add(Me.rbutRename)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCurDomain)
        Me.Controls.Add(Me.txtCurCompName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Machine Renamer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbutWrkGrp As System.Windows.Forms.RadioButton
    Friend WithEvents rbutDomain As System.Windows.Forms.RadioButton
    Friend WithEvents rbutRename As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCurDomain As System.Windows.Forms.TextBox
    Friend WithEvents txtCurCompName As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCan As System.Windows.Forms.Button
    Friend WithEvents cmbContainer As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
