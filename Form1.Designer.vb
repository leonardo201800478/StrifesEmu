<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        labelTitulo = New Label()
        labelModalidade = New Label()
        labelSistema = New Label()
        labelEmulador = New Label()
        comboBoxModalidade = New ComboBox()
        comboBoxSistema = New ComboBox()
        comboBoxEmulador = New ComboBox()
        buttonSelecionarEmulador = New Button()
        SuspendLayout()
        ' 
        ' labelTitulo
        ' 
        labelTitulo.AutoSize = True
        labelTitulo.Font = New Font("Arial", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTitulo.Location = New Point(175, 23)
        labelTitulo.Margin = New Padding(4, 0, 4, 0)
        labelTitulo.Name = "labelTitulo"
        labelTitulo.Size = New Size(600, 37)
        labelTitulo.TabIndex = 0
        labelTitulo.Text = "Instalação e Download de Emuladores"
        ' 
        ' labelModalidade
        ' 
        labelModalidade.AutoSize = True
        labelModalidade.Font = New Font("Arial", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelModalidade.Location = New Point(58, 115)
        labelModalidade.Margin = New Padding(4, 0, 4, 0)
        labelModalidade.Name = "labelModalidade"
        labelModalidade.Size = New Size(127, 26)
        labelModalidade.TabIndex = 1
        labelModalidade.Text = "Modalidade"
        ' 
        ' labelSistema
        ' 
        labelSistema.AutoSize = True
        labelSistema.Font = New Font("Arial", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelSistema.Location = New Point(58, 231)
        labelSistema.Margin = New Padding(4, 0, 4, 0)
        labelSistema.Name = "labelSistema"
        labelSistema.Size = New Size(94, 26)
        labelSistema.TabIndex = 2
        labelSistema.Text = "Sistema"
        ' 
        ' labelEmulador
        ' 
        labelEmulador.AutoSize = True
        labelEmulador.Font = New Font("Arial", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelEmulador.Location = New Point(58, 346)
        labelEmulador.Margin = New Padding(4, 0, 4, 0)
        labelEmulador.Name = "labelEmulador"
        labelEmulador.Size = New Size(110, 26)
        labelEmulador.TabIndex = 3
        labelEmulador.Text = "Emulador"
        ' 
        ' comboBoxModalidade
        ' 
        comboBoxModalidade.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxModalidade.Font = New Font("Arial", 14.0F)
        comboBoxModalidade.FormattingEnabled = True
        comboBoxModalidade.Items.AddRange(New Object() {"Arcade", "Computers", "Consoles", "Handhelds"})
        comboBoxModalidade.Location = New Point(292, 115)
        comboBoxModalidade.Margin = New Padding(4, 3, 4, 3)
        comboBoxModalidade.Name = "comboBoxModalidade"
        comboBoxModalidade.Size = New Size(233, 30)
        comboBoxModalidade.TabIndex = 4
        ' 
        ' comboBoxSistema
        ' 
        comboBoxSistema.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxSistema.Font = New Font("Arial", 14.0F)
        comboBoxSistema.FormattingEnabled = True
        comboBoxSistema.Location = New Point(292, 231)
        comboBoxSistema.Margin = New Padding(4, 3, 4, 3)
        comboBoxSistema.Name = "comboBoxSistema"
        comboBoxSistema.Size = New Size(233, 30)
        comboBoxSistema.TabIndex = 5
        ' 
        ' comboBoxEmulador
        ' 
        comboBoxEmulador.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxEmulador.Font = New Font("Arial", 14.0F)
        comboBoxEmulador.FormattingEnabled = True
        comboBoxEmulador.Items.AddRange(New Object() {"Ares", "Retroarch", "Cemu"})
        comboBoxEmulador.Location = New Point(292, 346)
        comboBoxEmulador.Margin = New Padding(4, 3, 4, 3)
        comboBoxEmulador.Name = "comboBoxEmulador"
        comboBoxEmulador.Size = New Size(233, 30)
        comboBoxEmulador.TabIndex = 6
        ' 
        ' buttonSelecionarEmulador
        ' 
        buttonSelecionarEmulador.Font = New Font("Arial", 14.0F, FontStyle.Bold)
        buttonSelecionarEmulador.Location = New Point(292, 462)
        buttonSelecionarEmulador.Margin = New Padding(4, 3, 4, 3)
        buttonSelecionarEmulador.Name = "buttonSelecionarEmulador"
        buttonSelecionarEmulador.Size = New Size(233, 46)
        buttonSelecionarEmulador.TabIndex = 7
        buttonSelecionarEmulador.Text = "Emulador selecionado"
        buttonSelecionarEmulador.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(846, 565)
        Controls.Add(buttonSelecionarEmulador)
        Controls.Add(comboBoxEmulador)
        Controls.Add(comboBoxSistema)
        Controls.Add(comboBoxModalidade)
        Controls.Add(labelEmulador)
        Controls.Add(labelSistema)
        Controls.Add(labelModalidade)
        Controls.Add(labelTitulo)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Strifes Emulator"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents labelTitulo As Label
    Friend WithEvents labelModalidade As Label
    Friend WithEvents labelSistema As Label
    Friend WithEvents labelEmulador As Label
    Friend WithEvents comboBoxModalidade As ComboBox
    Friend WithEvents comboBoxSistema As ComboBox
    Friend WithEvents comboBoxEmulador As ComboBox
    Friend WithEvents buttonSelecionarEmulador As Button
End Class
