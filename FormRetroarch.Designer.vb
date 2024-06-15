<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRetroarch
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
        SelectFolderButton = New Button()
        FolderPathTextBox = New TextBox()
        VersionLabel = New Label()
        InstallationFolderLabel = New Label()
        ProgressBar = New ProgressBar()
        ProgressBarLabel = New Label()
        EmulatorDownloadButton = New Button()
        CoreDownloadButton = New Button()
        FirmwareDownloadButton = New Button()
        AboutButton = New Button()
        SuspendLayout()
        ' 
        ' SelectFolderButton
        ' 
        SelectFolderButton.Location = New Point(14, 42)
        SelectFolderButton.Margin = New Padding(4, 3, 4, 3)
        SelectFolderButton.Name = "SelectFolderButton"
        SelectFolderButton.Size = New Size(122, 27)
        SelectFolderButton.TabIndex = 0
        SelectFolderButton.Text = "Selecionar Pasta"
        SelectFolderButton.UseVisualStyleBackColor = True
        ' 
        ' FolderPathTextBox
        ' 
        FolderPathTextBox.Location = New Point(144, 44)
        FolderPathTextBox.Margin = New Padding(4, 3, 4, 3)
        FolderPathTextBox.Name = "FolderPathTextBox"
        FolderPathTextBox.ReadOnly = True
        FolderPathTextBox.Size = New Size(404, 23)
        FolderPathTextBox.TabIndex = 1
        ' 
        ' VersionLabel
        ' 
        VersionLabel.AutoSize = True
        VersionLabel.Location = New Point(14, 10)
        VersionLabel.Margin = New Padding(4, 0, 4, 0)
        VersionLabel.Name = "VersionLabel"
        VersionLabel.Size = New Size(112, 15)
        VersionLabel.TabIndex = 2
        VersionLabel.Text = "Emulador Retroarch"
        ' 
        ' InstallationFolderLabel
        ' 
        InstallationFolderLabel.AutoSize = True
        InstallationFolderLabel.Location = New Point(144, 26)
        InstallationFolderLabel.Margin = New Padding(4, 0, 4, 0)
        InstallationFolderLabel.Name = "InstallationFolderLabel"
        InstallationFolderLabel.Size = New Size(110, 15)
        InstallationFolderLabel.TabIndex = 3
        InstallationFolderLabel.Text = "Pasta de instalação:"
        ' 
        ' ProgressBar
        ' 
        ProgressBar.Location = New Point(164, 97)
        ProgressBar.Margin = New Padding(4, 3, 4, 3)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(405, 27)
        ProgressBar.TabIndex = 4
        ' 
        ' ProgressBarLabel
        ' 
        ProgressBarLabel.AutoSize = True
        ProgressBarLabel.Location = New Point(22, 97)
        ProgressBarLabel.Margin = New Padding(4, 0, 4, 0)
        ProgressBarLabel.Name = "ProgressBarLabel"
        ProgressBarLabel.Size = New Size(134, 15)
        ProgressBarLabel.TabIndex = 5
        ProgressBarLabel.Text = "Progresso de download:"
        ' 
        ' EmulatorDownloadButton
        ' 
        EmulatorDownloadButton.Location = New Point(14, 140)
        EmulatorDownloadButton.Margin = New Padding(4, 3, 4, 3)
        EmulatorDownloadButton.Name = "EmulatorDownloadButton"
        EmulatorDownloadButton.Size = New Size(144, 27)
        EmulatorDownloadButton.TabIndex = 7
        EmulatorDownloadButton.Text = "Baixar Emulador"
        EmulatorDownloadButton.UseVisualStyleBackColor = True
        ' 
        ' CoreDownloadButton
        ' 
        CoreDownloadButton.Location = New Point(164, 140)
        CoreDownloadButton.Margin = New Padding(4, 3, 4, 3)
        CoreDownloadButton.Name = "CoreDownloadButton"
        CoreDownloadButton.Size = New Size(144, 27)
        CoreDownloadButton.TabIndex = 8
        CoreDownloadButton.Text = "Baixar Core"
        CoreDownloadButton.UseVisualStyleBackColor = True
        ' 
        ' FirmwareDownloadButton
        ' 
        FirmwareDownloadButton.Location = New Point(315, 140)
        FirmwareDownloadButton.Margin = New Padding(4, 3, 4, 3)
        FirmwareDownloadButton.Name = "FirmwareDownloadButton"
        FirmwareDownloadButton.Size = New Size(144, 27)
        FirmwareDownloadButton.TabIndex = 9
        FirmwareDownloadButton.Text = "Baixar Firmware"
        FirmwareDownloadButton.UseVisualStyleBackColor = True
        ' 
        ' AboutButton
        ' 
        AboutButton.Location = New Point(465, 140)
        AboutButton.Margin = New Padding(4, 3, 4, 3)
        AboutButton.Name = "AboutButton"
        AboutButton.Size = New Size(144, 27)
        AboutButton.TabIndex = 10
        AboutButton.Text = "Sobre o Emulador"
        AboutButton.UseVisualStyleBackColor = True
        ' 
        ' FormRetroarch
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 183)
        Controls.Add(AboutButton)
        Controls.Add(FirmwareDownloadButton)
        Controls.Add(CoreDownloadButton)
        Controls.Add(EmulatorDownloadButton)
        Controls.Add(ProgressBarLabel)
        Controls.Add(ProgressBar)
        Controls.Add(InstallationFolderLabel)
        Controls.Add(VersionLabel)
        Controls.Add(FolderPathTextBox)
        Controls.Add(SelectFolderButton)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormRetroarch"
        Text = "FormRetroarch"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents SelectFolderButton As Button
    Friend WithEvents FolderPathTextBox As TextBox
    Friend WithEvents VersionLabel As Label
    Friend WithEvents InstallationFolderLabel As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents ProgressBarLabel As Label
    Friend WithEvents EmulatorDownloadButton As Button
    Friend WithEvents CoreDownloadButton As Button
    Friend WithEvents FirmwareDownloadButton As Button
    Friend WithEvents AboutButton As Button

End Class

