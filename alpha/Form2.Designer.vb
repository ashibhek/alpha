<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        LButton = New Button()
        RButton = New Button()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DarkRed
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 159)
        Label1.TabIndex = 2
        Label1.Text = "A"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(191, 50)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(444, 325)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        PictureBox1.UseWaitCursor = True
        ' 
        ' LButton
        ' 
        LButton.BackColor = Color.LightCoral
        LButton.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LButton.ForeColor = Color.DarkRed
        LButton.Location = New Point(12, 199)
        LButton.Name = "LButton"
        LButton.Size = New Size(173, 54)
        LButton.TabIndex = 4
        LButton.Text = "PREVIOUS"
        LButton.UseVisualStyleBackColor = False
        ' 
        ' RButton
        ' 
        RButton.BackColor = Color.LightCoral
        RButton.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RButton.ForeColor = Color.DarkRed
        RButton.Location = New Point(643, 213)
        RButton.Name = "RButton"
        RButton.Size = New Size(173, 54)
        RButton.TabIndex = 5
        RButton.Text = "NEXT"
        RButton.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightCoral
        Button1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.DarkRed
        Button1.Location = New Point(344, 381)
        Button1.Name = "Button1"
        Button1.Size = New Size(173, 54)
        Button1.TabIndex = 6
        Button1.Text = "HOME"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.DarkRed
        Label2.Location = New Point(304, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 38)
        Label2.TabIndex = 7
        Label2.Text = "Alphabets: A-Z"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DarkRed
        Label3.Location = New Point(665, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(151, 159)
        Label3.TabIndex = 8
        Label3.Text = "A"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(828, 501)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(RButton)
        Controls.Add(LButton)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "ALPHA LEARN"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LButton As Button
    Friend WithEvents RButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
