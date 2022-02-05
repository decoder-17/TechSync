<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.events = New System.Windows.Forms.TextBox()
        Me.dept = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pid = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.events)
        Me.GroupBox1.Controls.Add(Me.dept)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.pid)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cno)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cname)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.pname)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(707, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 629)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'events
        '
        Me.events.Enabled = False
        Me.events.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.events.Location = New System.Drawing.Point(24, 476)
        Me.events.Multiline = True
        Me.events.Name = "events"
        Me.events.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.events.Size = New System.Drawing.Size(488, 134)
        Me.events.TabIndex = 18
        '
        'dept
        '
        Me.dept.Enabled = False
        Me.dept.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dept.Location = New System.Drawing.Point(230, 334)
        Me.dept.Multiline = True
        Me.dept.Name = "dept"
        Me.dept.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dept.Size = New System.Drawing.Size(282, 31)
        Me.dept.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(19, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 29)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Department:"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.concept_design_manufacturing_and_logistics_flex_black_and_blue_png_1920_1080
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(185, 414)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(196, 36)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "VIEW EVENTS"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(19, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "PARTICIPANT'S ID :"
        '
        'pid
        '
        Me.pid.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pid.Location = New System.Drawing.Point(207, 78)
        Me.pid.Name = "pid"
        Me.pid.Size = New System.Drawing.Size(305, 35)
        Me.pid.TabIndex = 14
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.concept_design_manufacturing_and_logistics_flex_black_and_blue_png_1920_1080
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Location = New System.Drawing.Point(112, 147)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 36)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "VIEW"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.concept_design_manufacturing_and_logistics_flex_black_and_blue_png_1920_1080
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(325, 150)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 36)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(19, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Participant's Name :"
        '
        'cno
        '
        Me.cno.Enabled = False
        Me.cno.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cno.Location = New System.Drawing.Point(230, 297)
        Me.cno.Multiline = True
        Me.cno.Name = "cno"
        Me.cno.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.cno.Size = New System.Drawing.Size(282, 31)
        Me.cno.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label8.Location = New System.Drawing.Point(19, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 29)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Contact No:"
        '
        'cname
        '
        Me.cname.Enabled = False
        Me.cname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname.Location = New System.Drawing.Point(230, 257)
        Me.cname.Name = "cname"
        Me.cname.Size = New System.Drawing.Size(282, 35)
        Me.cname.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Impact", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label9.Location = New System.Drawing.Point(19, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 29)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "College Name:"
        '
        'pname
        '
        Me.pname.Enabled = False
        Me.pname.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pname.Location = New System.Drawing.Point(230, 218)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(282, 35)
        Me.pname.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(698, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(607, 53)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "REGISTERED PARTICIPANTS"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.concept_design_manufacturing_and_logistics_flex_black_and_blue_png_1920_1080
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(12, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 36)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "LOGOUT"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.concept_design_manufacturing_and_logistics_flex_black_and_blue_png_1920_1080
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button6.Location = New System.Drawing.Point(12, 881)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 36)
        Me.Button6.TabIndex = 32
        Me.Button6.Text = "BACK"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(1755, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(3)
        Me.Button1.Size = New System.Drawing.Size(142, 40)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "EXIT"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(853, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 53)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "PHOENIX 2.0"
        '
        'Display
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Background_Selection_Page1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1823, 929)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.DoubleBuffered = True
        Me.Name = "Display"
        Me.Text = "Display"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cno As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cname As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents pname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents pid As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dept As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents events As TextBox
End Class
