<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusKoleksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblhapus = New System.Windows.Forms.Label()
        Me.btnconhapus = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(26, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah anda yakin ingin menghapus"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblhapus
        '
        Me.lblhapus.AutoSize = True
        Me.lblhapus.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblhapus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblhapus.Location = New System.Drawing.Point(133, 154)
        Me.lblhapus.Name = "lblhapus"
        Me.lblhapus.Size = New System.Drawing.Size(160, 45)
        Me.lblhapus.TabIndex = 1
        Me.lblhapus.Text = "Koleksi A"
        Me.lblhapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnconhapus
        '
        Me.btnconhapus.Location = New System.Drawing.Point(117, 289)
        Me.btnconhapus.Name = "btnconhapus"
        Me.btnconhapus.Size = New System.Drawing.Size(75, 23)
        Me.btnconhapus.TabIndex = 2
        Me.btnconhapus.Text = "Hapus"
        Me.btnconhapus.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(218, 289)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 3
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'HapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(464, 361)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnconhapus)
        Me.Controls.Add(Me.lblhapus)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "HapusKoleksi"
        Me.Text = "Hapus Koleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblhapus As Label
    Friend WithEvents btnconhapus As Button
    Friend WithEvents btncancel As Button
End Class
