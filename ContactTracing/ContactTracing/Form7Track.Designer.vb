<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7Track
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtSearchBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dataGridContactRobinson = New System.Windows.Forms.DataGridView()
        Me.btnSearchContact = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.dataGridContactSM = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dataGridContactRobinson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridContactSM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchBox
        '
        Me.txtSearchBox.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBox.Location = New System.Drawing.Point(91, 122)
        Me.txtSearchBox.Name = "txtSearchBox"
        Me.txtSearchBox.Size = New System.Drawing.Size(200, 26)
        Me.txtSearchBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(86, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EnterID"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBack.Location = New System.Drawing.Point(25, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 34)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dataGridContactRobinson
        '
        Me.dataGridContactRobinson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridContactRobinson.Location = New System.Drawing.Point(89, 278)
        Me.dataGridContactRobinson.Name = "dataGridContactRobinson"
        Me.dataGridContactRobinson.Size = New System.Drawing.Size(1021, 228)
        Me.dataGridContactRobinson.TabIndex = 3
        '
        'btnSearchContact
        '
        Me.btnSearchContact.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSearchContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchContact.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchContact.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSearchContact.Location = New System.Drawing.Point(445, 118)
        Me.btnSearchContact.Name = "btnSearchContact"
        Me.btnSearchContact.Size = New System.Drawing.Size(75, 34)
        Me.btnSearchContact.TabIndex = 4
        Me.btnSearchContact.Text = "search"
        Me.btnSearchContact.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(313, 122)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(112, 26)
        Me.DateTimePicker1.TabIndex = 5
        '
        'dataGridContactSM
        '
        Me.dataGridContactSM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridContactSM.Location = New System.Drawing.Point(89, 561)
        Me.dataGridContactSM.Name = "dataGridContactSM"
        Me.dataGridContactSM.Size = New System.Drawing.Size(1021, 228)
        Me.dataGridContactSM.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(86, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Robinsons Place Manila"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(86, 534)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "SM City Manila"
        '
        'Form7Track
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 855)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dataGridContactSM)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnSearchContact)
        Me.Controls.Add(Me.dataGridContactRobinson)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearchBox)
        Me.Name = "Form7Track"
        Me.Text = "Form7Track"
        CType(Me.dataGridContactRobinson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridContactSM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearchBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents dataGridContactRobinson As DataGridView
    Friend WithEvents btnSearchContact As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dataGridContactSM As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
