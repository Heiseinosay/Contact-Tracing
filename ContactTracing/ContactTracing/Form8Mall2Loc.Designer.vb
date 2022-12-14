<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8Mall2Loc
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
        Me.txtScanID = New System.Windows.Forms.TextBox()
        Me.btnTimeIn = New System.Windows.Forms.Button()
        Me.btnTimeOut = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStopScan = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtScanID
        '
        Me.txtScanID.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScanID.Location = New System.Drawing.Point(199, 410)
        Me.txtScanID.Name = "txtScanID"
        Me.txtScanID.Size = New System.Drawing.Size(208, 32)
        Me.txtScanID.TabIndex = 0
        '
        'btnTimeIn
        '
        Me.btnTimeIn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeIn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeIn.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTimeIn.Location = New System.Drawing.Point(199, 448)
        Me.btnTimeIn.Name = "btnTimeIn"
        Me.btnTimeIn.Size = New System.Drawing.Size(86, 35)
        Me.btnTimeIn.TabIndex = 1
        Me.btnTimeIn.Text = "TimeIn"
        Me.btnTimeIn.UseVisualStyleBackColor = False
        '
        'btnTimeOut
        '
        Me.btnTimeOut.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeOut.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOut.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTimeOut.Location = New System.Drawing.Point(321, 448)
        Me.btnTimeOut.Name = "btnTimeOut"
        Me.btnTimeOut.Size = New System.Drawing.Size(86, 35)
        Me.btnTimeOut.TabIndex = 2
        Me.btnTimeOut.Text = "Time out"
        Me.btnTimeOut.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(72, 35)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(126, 55)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(417, 281)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStart.Location = New System.Drawing.Point(166, 342)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(86, 35)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStopScan
        '
        Me.btnStopScan.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnStopScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopScan.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopScan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStopScan.Location = New System.Drawing.Point(258, 342)
        Me.btnStopScan.Name = "btnStopScan"
        Me.btnStopScan.Size = New System.Drawing.Size(86, 35)
        Me.btnStopScan.TabIndex = 6
        Me.btnStopScan.Text = "Stop/Scan"
        Me.btnStopScan.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Control
        Me.Button3.Location = New System.Drawing.Point(350, 342)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 35)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Load"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form8Mall2Loc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 536)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnStopScan)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnTimeOut)
        Me.Controls.Add(Me.btnTimeIn)
        Me.Controls.Add(Me.txtScanID)
        Me.Name = "Form8Mall2Loc"
        Me.Text = "Form8Mall2Loc"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtScanID As TextBox
    Friend WithEvents btnTimeIn As Button
    Friend WithEvents btnTimeOut As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStopScan As Button
    Friend WithEvents Button3 As Button
End Class
