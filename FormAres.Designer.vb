<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAres
    Inherits System.Windows.Forms.Form

    ' O método a seguir é necessário para o Designer do Windows Forms
    ' Pode ser modificado usando o Designer do Windows Forms.  
    ' Não o modifique com o editor de código.
    Private Sub InitializeComponent()
        DownloadButton = New Button()
        ReleaseSelector = New ComboBox()
        ProgressBar = New ProgressBar()
        SuspendLayout()
        ' 
        ' DownloadButton
        ' 
        DownloadButton.Location = New Point(12, 12)
        DownloadButton.Margin = New Padding(4, 3, 4, 3)
        DownloadButton.Name = "DownloadButton"
        DownloadButton.Size = New Size(117, 35)
        DownloadButton.TabIndex = 0
        DownloadButton.Text = "Download"
        DownloadButton.UseVisualStyleBackColor = True
        ' 
        ' ReleaseSelector
        ' 
        ReleaseSelector.FormattingEnabled = True
        ReleaseSelector.Items.AddRange(New Object() {"Estável", "Beta"})
        ReleaseSelector.Location = New Point(13, 63)
        ReleaseSelector.Margin = New Padding(4, 3, 4, 3)
        ReleaseSelector.Name = "ReleaseSelector"
        ReleaseSelector.Size = New Size(233, 23)
        ReleaseSelector.TabIndex = 1
        ReleaseSelector.SelectedIndex = 0 ' Seleciona "Estável" por padrão
        ' 
        ' ProgressBar
        ' 
        ProgressBar.Location = New Point(12, 104)
        ProgressBar.Margin = New Padding(4, 3, 4, 3)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(350, 27)
        ProgressBar.TabIndex = 2
        ' 
        ' FormAres
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(373, 150)
        Controls.Add(ProgressBar)
        Controls.Add(ReleaseSelector)
        Controls.Add(DownloadButton)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormAres"
        Text = "Ares Emulator"
        ResumeLayout(False)

    End Sub

    Friend WithEvents DownloadButton As Button
    Friend WithEvents ReleaseSelector As ComboBox
    Friend WithEvents ProgressBar As ProgressBar
End Class