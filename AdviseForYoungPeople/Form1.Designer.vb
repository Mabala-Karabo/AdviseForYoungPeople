<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        txtAdvise = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtPart2 = New TextBox()
        txtPart3 = New TextBox()
        txtPart1 = New TextBox()
        tittleBar = New Label()
        txtTittle = New TextBox()
        SuspendLayout()
        ' 
        ' txtAdvise
        ' 
        txtAdvise.Location = New Point(654, 310)
        txtAdvise.Name = "txtAdvise"
        txtAdvise.Size = New Size(211, 60)
        txtAdvise.TabIndex = 0
        txtAdvise.Text = "Get Message"
        txtAdvise.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 129)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 25)
        Label1.TabIndex = 1
        Label1.Text = "Part1 of the Message==>"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(215, 25)
        Label2.TabIndex = 2
        Label2.Text = "Part2 of the Message==>"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(215, 25)
        Label3.TabIndex = 3
        Label3.Text = "Part3 of the Message==>"
        ' 
        ' txtPart2
        ' 
        txtPart2.Location = New Point(240, 190)
        txtPart2.Name = "txtPart2"
        txtPart2.Size = New Size(875, 31)
        txtPart2.TabIndex = 4
        ' 
        ' txtPart3
        ' 
        txtPart3.Location = New Point(240, 245)
        txtPart3.Name = "txtPart3"
        txtPart3.Size = New Size(875, 31)
        txtPart3.TabIndex = 5
        ' 
        ' txtPart1
        ' 
        txtPart1.Location = New Point(240, 129)
        txtPart1.Name = "txtPart1"
        txtPart1.Size = New Size(875, 31)
        txtPart1.TabIndex = 6
        ' 
        ' tittleBar
        ' 
        tittleBar.AutoSize = True
        tittleBar.Location = New Point(168, 21)
        tittleBar.Name = "tittleBar"
        tittleBar.Size = New Size(50, 25)
        tittleBar.TabIndex = 7
        tittleBar.Text = "Tittle"
        ' 
        ' txtTittle
        ' 
        txtTittle.Location = New Point(236, 21)
        txtTittle.Name = "txtTittle"
        txtTittle.Size = New Size(729, 31)
        txtTittle.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1127, 450)
        Controls.Add(txtTittle)
        Controls.Add(tittleBar)
        Controls.Add(txtPart1)
        Controls.Add(txtPart3)
        Controls.Add(txtPart2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtAdvise)
        Name = "Form1"
        Text = "AdviseForYoungPeople"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtAdvise As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPart2 As TextBox
    Friend WithEvents txtPart3 As TextBox
    Friend WithEvents txtPart1 As TextBox
    Friend WithEvents tittleBar As Label
    Friend WithEvents txtTittle As TextBox
End Class
