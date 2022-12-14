<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6MallLoc
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
        Me.btnTimeIn = New System.Windows.Forms.Button()
        Me.txtScanID = New System.Windows.Forms.TextBox()
        Me.btnTimeOut = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStopScan = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTimeIn
        '
        Me.btnTimeIn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnTimeIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeIn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeIn.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTimeIn.Location = New System.Drawing.Point(197, 414)
        Me.btnTimeIn.Name = "btnTimeIn"
        Me.btnTimeIn.Size = New System.Drawing.Size(87, 34)
        Me.btnTimeIn.TabIndex = 0
        Me.btnTimeIn.Text = "Time In"
        Me.btnTimeIn.UseVisualStyleBackColor = False
        '
        'txtScanID
        '
        Me.txtScanID.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScanID.Location = New System.Drawing.Point(197, 375)
        Me.txtScanID.Name = "txtScanID"
        Me.txtScanID.Size = New System.Drawing.Size(201, 32)
        Me.txtScanID.TabIndex = 1
        '
        'btnTimeOut
        '
        Me.btnTimeOut.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnTimeOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeOut.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOut.ForeColor = System.Drawing.SystemColors.Control
        Me.btnTimeOut.Location = New System.Drawing.Point(311, 414)
        Me.btnTimeOut.Name = "btnTimeOut"
        Me.btnTimeOut.Size = New System.Drawing.Size(87, 34)
        Me.btnTimeOut.TabIndex = 2
        Me.btnTimeOut.Text = "Time Out"
        Me.btnTimeOut.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBack.Location = New System.Drawing.Point(13, 13)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(68, 34)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(153, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 249)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStart.Location = New System.Drawing.Point(168, 300)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(87, 34)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStopScan
        '
        Me.btnStopScan.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnStopScan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStopScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStopScan.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopScan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStopScan.Location = New System.Drawing.Point(259, 300)
        Me.btnStopScan.Name = "btnStopScan"
        Me.btnStopScan.Size = New System.Drawing.Size(87, 34)
        Me.btnStopScan.TabIndex = 6
        Me.btnStopScan.Text = "Stop/Scan"
        Me.btnStopScan.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLoad.Location = New System.Drawing.Point(353, 300)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(87, 34)
        Me.btnLoad.TabIndex = 7
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'Form6MallLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 503)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnStopScan)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnTimeOut)
        Me.Controls.Add(Me.txtScanID)
        Me.Controls.Add(Me.btnTimeIn)
        Me.Name = "Form6MallLoc"
        Me.Text = "Form6MallLoc"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTimeIn As Button
    Friend WithEvents txtScanID As TextBox
    Friend WithEvents btnTimeOut As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStopScan As Button
    Friend WithEvents btnLoad As Button
End Class
