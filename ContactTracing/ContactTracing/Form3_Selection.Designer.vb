<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3_Selection
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
        Me.btnRegisterCitizen = New System.Windows.Forms.Button()
        Me.btnTrack = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRegisterCitizen
        '
        Me.btnRegisterCitizen.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRegisterCitizen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegisterCitizen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegisterCitizen.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegisterCitizen.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRegisterCitizen.Location = New System.Drawing.Point(171, 122)
        Me.btnRegisterCitizen.Name = "btnRegisterCitizen"
        Me.btnRegisterCitizen.Size = New System.Drawing.Size(210, 188)
        Me.btnRegisterCitizen.TabIndex = 0
        Me.btnRegisterCitizen.Text = "Add"
        Me.btnRegisterCitizen.UseVisualStyleBackColor = False
        '
        'btnTrack
        '
        Me.btnTrack.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnTrack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrack.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnTrack.Location = New System.Drawing.Point(431, 122)
        Me.btnTrack.Name = "btnTrack"
        Me.btnTrack.Size = New System.Drawing.Size(210, 188)
        Me.btnTrack.TabIndex = 1
        Me.btnTrack.Text = "Track"
        Me.btnTrack.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLogOut.Location = New System.Drawing.Point(12, 12)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(79, 35)
        Me.btnLogOut.TabIndex = 2
        Me.btnLogOut.Text = "Logout"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'Form3_Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnTrack)
        Me.Controls.Add(Me.btnRegisterCitizen)
        Me.Name = "Form3_Selection"
        Me.Text = "Form3_Selection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRegisterCitizen As Button
    Friend WithEvents btnTrack As Button
    Friend WithEvents btnLogOut As Button
End Class
