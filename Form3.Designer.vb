<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        MenuStrip1 = New MenuStrip()
        MenúToolStripMenuItem = New ToolStripMenuItem()
        AltaToolStripMenuItem = New ToolStripMenuItem()
        MantenimientoToolStripMenuItem = New ToolStripMenuItem()
        BajaToolStripMenuItem = New ToolStripMenuItem()
        ModifiaciónToolStripMenuItem = New ToolStripMenuItem()
        VolverToolStripMenuItem = New ToolStripMenuItem()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenúToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenúToolStripMenuItem
        ' 
        MenúToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AltaToolStripMenuItem, MantenimientoToolStripMenuItem, VolverToolStripMenuItem})
        MenúToolStripMenuItem.Name = "MenúToolStripMenuItem"
        MenúToolStripMenuItem.Size = New Size(50, 20)
        MenúToolStripMenuItem.Text = "Menú"
        ' 
        ' AltaToolStripMenuItem
        ' 
        AltaToolStripMenuItem.Name = "AltaToolStripMenuItem"
        AltaToolStripMenuItem.Size = New Size(180, 22)
        AltaToolStripMenuItem.Text = "Alta"
        ' 
        ' MantenimientoToolStripMenuItem
        ' 
        MantenimientoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BajaToolStripMenuItem, ModifiaciónToolStripMenuItem})
        MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        MantenimientoToolStripMenuItem.Size = New Size(180, 22)
        MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        ' 
        ' BajaToolStripMenuItem
        ' 
        BajaToolStripMenuItem.Name = "BajaToolStripMenuItem"
        BajaToolStripMenuItem.Size = New Size(138, 22)
        BajaToolStripMenuItem.Text = "Baja"
        ' 
        ' ModifiaciónToolStripMenuItem
        ' 
        ModifiaciónToolStripMenuItem.Name = "ModifiaciónToolStripMenuItem"
        ModifiaciónToolStripMenuItem.Size = New Size(138, 22)
        ModifiaciónToolStripMenuItem.Text = "Modifiación"
        ' 
        ' VolverToolStripMenuItem
        ' 
        VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        VolverToolStripMenuItem.Size = New Size(180, 22)
        VolverToolStripMenuItem.Text = "Volver"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(44, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(44, 130)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(44, 209)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 3
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(44, 287)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 4
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(44, 364)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(171, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 6
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(171, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 7
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(171, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 8
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(171, 290)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 9
        Label4.Text = "Label4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(171, 367)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 10
        Label5.Text = "Label5"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form3"
        Text = "Form3"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AltaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifiaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
