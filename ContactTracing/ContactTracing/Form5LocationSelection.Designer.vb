<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5LocationSelection
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
        Me.btnLocPark = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLocPark
        '
        Me.btnLocPark.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLocPark.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLocPark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocPark.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocPark.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLocPark.Location = New System.Drawing.Point(566, 169)
        Me.btnLocPark.Name = "btnLocPark"
        Me.btnLocPark.Size = New System.Drawing.Size(278, 247)
        Me.btnLocPark.TabIndex = 0
        Me.btnLocPark.Text = "SM City Manila"
        Me.btnLocPark.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(181, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(278, 247)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Robinsons Place Manila"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBack.Location = New System.Drawing.Point(24, 21)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 39)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Form5LocationSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 596)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLocPark)
        Me.Name = "Form5LocationSelection"
        Me.Text = "Form5LocationSelection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLocPark As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBack As Button
End Class
