<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.butlogin = New System.Windows.Forms.Button()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblreg = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(69, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(69, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(22, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 45)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Login"
        '
        'butlogin
        '
        Me.butlogin.Location = New System.Drawing.Point(359, 175)
        Me.butlogin.Name = "butlogin"
        Me.butlogin.Size = New System.Drawing.Size(75, 23)
        Me.butlogin.TabIndex = 5
        Me.butlogin.Text = "Submit"
        Me.butlogin.UseVisualStyleBackColor = True
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(168, 103)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(266, 23)
        Me.txtuname.TabIndex = 7
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(168, 134)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(266, 23)
        Me.txtpass.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Don't have an account? Click "
        '
        'lblreg
        '
        Me.lblreg.AutoSize = True
        Me.lblreg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblreg.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblreg.ForeColor = System.Drawing.Color.Blue
        Me.lblreg.Location = New System.Drawing.Point(178, 220)
        Me.lblreg.Margin = New System.Windows.Forms.Padding(0)
        Me.lblreg.Name = "lblreg"
        Me.lblreg.Size = New System.Drawing.Size(30, 15)
        Me.lblreg.TabIndex = 10
        Me.lblreg.Text = "here"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "to register"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(501, 261)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblreg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.butlogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.Text = "login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents butlogin As Button
    Friend WithEvents txtuname As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblreg As Label
    Friend WithEvents Label5 As Label
End Class
