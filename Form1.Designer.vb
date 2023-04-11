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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Timer1 = New Timer(components)
        Logo = New PictureBox()
        Label1 = New Label()
        CType(Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        ' 
        ' Logo
        ' 
        Logo.Image = CType(resources.GetObject("Logo.Image"), Image)
        Logo.Location = New Point(223, 12)
        Logo.Name = "Logo"
        Logo.Size = New Size(367, 295)
        Logo.SizeMode = PictureBoxSizeMode.Zoom
        Logo.TabIndex = 0
        Logo.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(375, 344)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 1
        Label1.Text = "Bienvenido"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Logo)
        Name = "Form1"
        Text = "Form1"
        CType(Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Logo As PictureBox
    Friend WithEvents Label1 As Label
End Class
