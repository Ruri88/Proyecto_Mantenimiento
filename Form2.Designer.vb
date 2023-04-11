<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Button1 = New Button()
        Button2 = New Button()
        Logo = New PictureBox()
        CType(Logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(140, 306)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Alta"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(547, 306)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 23)
        Button2.TabIndex = 2
        Button2.Text = "Mantenimiento"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Logo
        ' 
        Logo.Image = CType(resources.GetObject("Logo.Image"), Image)
        Logo.Location = New Point(197, 5)
        Logo.Name = "Logo"
        Logo.Size = New Size(367, 295)
        Logo.SizeMode = PictureBoxSizeMode.Zoom
        Logo.TabIndex = 3
        Logo.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Logo)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Form2"
        CType(Logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Logo As PictureBox
End Class
