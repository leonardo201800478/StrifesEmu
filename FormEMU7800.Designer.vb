<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEMU7800
    Inherits System.Windows.Forms.Form

    'Form substitui a memória limpeza para limpar os componentes.
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

    'Requerido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTA: o procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DownloadButton = New Button()
        FolderPathTextBox = New TextBox()
        ProgressBar = New ProgressBar()
        SelectFolderButton = New Button()
        AboutButton = New Button()
        VersionLabel = New Label()
        InstallationFolderLabel = New Label()
        ProgressBarLabel = New Label()
        SuspendLayout()
        ' 
        ' DownloadButton
        ' 
        DownloadButton.Location = New Point(280, 115)
        DownloadButton.Margin = New Padding(4, 3, 4, 3)
        DownloadButton.Name = "DownloadButton"
        DownloadButton.Size = New Size(152, 27)
        DownloadButton.TabIndex = 0
        DownloadButton.Text = "Baixar Emulador"
        DownloadButton.UseVisualStyleBackColor = True
        ' 
        ' FolderPathTextBox
        ' 
        FolderPathTextBox.Location = New Point(13, 53)
        FolderPathTextBox.Margin = New Padding(4, 3, 4, 3)
        FolderPathTextBox.Name = "FolderPathTextBox"
        FolderPathTextBox.Size = New Size(303, 23)
        FolderPathTextBox.TabIndex = 3
        ' 
        ' ProgressBar
        ' 
        ProgressBar.Location = New Point(13, 182)
        ProgressBar.Margin = New Padding(4, 3, 4, 3)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(416, 27)
        ProgressBar.TabIndex = 4
        ' 
        ' SelectFolderButton
        ' 
        SelectFolderButton.Location = New Point(323, 53)
        SelectFolderButton.Margin = New Padding(4, 3, 4, 3)
        SelectFolderButton.Name = "SelectFolderButton"
        SelectFolderButton.Size = New Size(107, 27)
        SelectFolderButton.TabIndex = 7
        SelectFolderButton.Text = "Selecionar Pasta"
        SelectFolderButton.UseVisualStyleBackColor = True
        ' 
        ' AboutButton
        ' 
        AboutButton.Location = New Point(169, 245)
        AboutButton.Margin = New Padding(4, 3, 4, 3)
        AboutButton.Name = "AboutButton"
        AboutButton.Size = New Size(136, 27)
        AboutButton.TabIndex = 10
        AboutButton.Text = "Sobre o Emulador"
        AboutButton.UseVisualStyleBackColor = True
        ' 
        ' VersionLabel
        ' 
        VersionLabel.AutoSize = True
        VersionLabel.Location = New Point(169, 9)
        VersionLabel.Margin = New Padding(4, 0, 4, 0)
        VersionLabel.Name = "VersionLabel"
        VersionLabel.Size = New Size(110, 15)
        VersionLabel.TabIndex = 11
        VersionLabel.Text = "Emulador EMU7800"
        ' 
        ' InstallationFolderLabel
        ' 
        InstallationFolderLabel.AutoSize = True
        InstallationFolderLabel.Location = New Point(15, 35)
        InstallationFolderLabel.Margin = New Padding(4, 0, 4, 0)
        InstallationFolderLabel.Name = "InstallationFolderLabel"
        InstallationFolderLabel.Size = New Size(110, 15)
        InstallationFolderLabel.TabIndex = 12
        InstallationFolderLabel.Text = "Pasta de instalação:"
        ' 
        ' ProgressBarLabel
        ' 
        ProgressBarLabel.AutoSize = True
        ProgressBarLabel.Location = New Point(15, 164)
        ProgressBarLabel.Margin = New Padding(4, 0, 4, 0)
        ProgressBarLabel.Name = "ProgressBarLabel"
        ProgressBarLabel.Size = New Size(134, 15)
        ProgressBarLabel.TabIndex = 15
        ProgressBarLabel.Text = "Progresso de download:"
        ' 
        ' FormEMU7800
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(457, 318)
        Controls.Add(ProgressBarLabel)
        Controls.Add(InstallationFolderLabel)
        Controls.Add(VersionLabel)
        Controls.Add(AboutButton)
        Controls.Add(SelectFolderButton)
        Controls.Add(ProgressBar)
        Controls.Add(FolderPathTextBox)
        Controls.Add(DownloadButton)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormEMU7800"
        Text = "Emulador EMU7800"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents DownloadButton As Button
    Friend WithEvents FolderPathTextBox As TextBox
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents SelectFolderButton As Button
    Friend WithEvents AboutButton As Button
    Friend WithEvents VersionLabel As Label
    Friend WithEvents InstallationFolderLabel As Label
    Friend WithEvents ProgressBarLabel As Label

End Class
