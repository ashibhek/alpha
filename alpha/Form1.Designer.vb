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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        PLAYBUTTON = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Rockwell", 49.8000031F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label1.Location = New Point(136, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(667, 101)
        Label1.TabIndex = 0
        Label1.Text = "Learn and Play"
        ' 
        ' PLAYBUTTON
        ' 
        PLAYBUTTON.BackColor = Color.LightCoral
        PLAYBUTTON.BackgroundImageLayout = ImageLayout.Stretch
        PLAYBUTTON.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PLAYBUTTON.ForeColor = Color.DarkRed
        PLAYBUTTON.Location = New Point(346, 316)
        PLAYBUTTON.Name = "PLAYBUTTON"
        PLAYBUTTON.Size = New Size(219, 65)
        PLAYBUTTON.TabIndex = 1
        PLAYBUTTON.Text = "ALPHABETS"
        PLAYBUTTON.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightCoral
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.DarkRed
        Button1.Location = New Point(346, 222)
        Button1.Name = "Button1"
        Button1.Size = New Size(219, 66)
        Button1.TabIndex = 2
        Button1.Text = "NUMBERS"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(900, 453)
        Controls.Add(Button1)
        Controls.Add(PLAYBUTTON)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Learn and Play"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PLAYBUTTON As Button
    Friend WithEvents Button1 As Button

End Class
