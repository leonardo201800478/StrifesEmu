Imports System.IO
Imports System.IO.Compression
Imports System.Net.Http
Imports Octokit

Public Class FormAres
    Inherits System.Windows.Forms.Form

    ' Inicialização do Formulário
    Public Sub New()
        ' Este código de inicialização é necessário para o designer de formulários.
        InitializeComponent()

        ' Configurações iniciais
        VersionLabel.Text = "Emulador Ares"
        InstallationFolderLabel.Text = "Pasta de instalação:"
        SelectVersionLabel.Text = "Selecione a versão:"
        FirmwareLinkLabel.Text = "Link do Firmware:"
        FirmwareUrlTextBox.Text = "https://github.com/leonardo201800478/BizHawk_Firmware/releases/download/BizHawk/Firmware.zip"
        ReleaseSelector.SelectedItem = "Estável"
        ProgressBarLabel.Text = "Progresso de download:"
        DownloadButton.Enabled = False ' Desabilita o botão de download até que um diretório de instalação seja selecionado
    End Sub

    ' Evento de clique no botão de seleção de pasta
    Private Sub SelectFolderButton_Click(sender As Object, e As EventArgs) Handles SelectFolderButton.Click
        Using folderBrowserDialog As New FolderBrowserDialog()
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                FolderPathTextBox.Text = folderBrowserDialog.SelectedPath
                DownloadButton.Enabled = True ' Habilita o botão de download após selecionar o diretório de instalação
            End If
        End Using
    End Sub

    ' Evento de clique no botão de download do firmware
    Private Async Sub FirmwareDownloadButton_Click(sender As Object, e As EventArgs) Handles FirmwareDownloadButton.Click
        Dim firmwareUrl As String = "https://github.com/leonardo201800478/BizHawk_Firmware/releases/download/BizHawk/Firmware.zip"
        If String.IsNullOrEmpty(firmwareUrl) OrElse String.IsNullOrEmpty(FolderPathTextBox.Text) Then
            MessageBox.Show("Por favor, insira a URL do firmware e selecione a pasta de destino.")
            Return
        End If

        Dim fileName As String = Path.GetFileName(firmwareUrl)
        Dim tempPath As String = Path.GetTempPath()
        Dim downloadPath As String = Path.Combine(tempPath, fileName)

        Await DownloadFileAsync(firmwareUrl, downloadPath)

        ' Descompacta os arquivos do firmware
        Dim extractPath As String = Path.Combine(tempPath, Path.GetFileNameWithoutExtension(fileName))
        ZipFile.ExtractToDirectory(downloadPath, extractPath)

        ' Move os arquivos extraídos para o diretório de instalação
        MoveFilesToInstallationDirectory(extractPath, FolderPathTextBox.Text)

        ' Limpa os arquivos temporários
        Directory.Delete(extractPath, True)
        File.Delete(downloadPath)

        MessageBox.Show("Firmware baixado e instalado com sucesso.")
    End Sub

    ' Evento de clique no botão de download
    Private Async Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        If String.IsNullOrEmpty(FolderPathTextBox.Text) Then
            MessageBox.Show("Por favor, selecione a pasta de destino.")
            Return
        End If

        ' Crie um cliente GitHub anônimo
        Dim client As New GitHubClient(New ProductHeaderValue("Ares"))

        ' Defina o proprietário e o nome do repositório
        Dim owner As String = "ares-emulator" ' Substitua pelo nome do proprietário do repositório
        Dim repositoryName As String = "ares" ' Substitua pelo nome do repositório

        ' Obtenha a versão mais recente com base na seleção do usuário
        Dim releases = Await client.Repository.Release.GetAll(owner, repositoryName)
        Dim release As Release
        If ReleaseSelector.SelectedItem.ToString() = "Estável" Then
            release = releases.FirstOrDefault(Function(r) Not r.Prerelease)
        Else
            release = releases.FirstOrDefault(Function(r) r.Prerelease)
        End If

        ' Verifique se há pelo menos 4 assets na release
        If release.Assets.Count >= 4 Then
            ' Pegue o quarto asset da lista
            Dim asset As ReleaseAsset = release.Assets(3) ' Índice 3 para o quarto asset (baseado em zero)

            ' Inicie o download e atualize a barra de progresso
            If asset IsNot Nothing Then
                Dim tempPath As String = Path.GetTempPath()
                Dim filePath As String = Path.Combine(tempPath, asset.Name)
                Await DownloadFileAsync(asset.BrowserDownloadUrl, filePath)

                ' Descompacta os arquivos
                Dim extractPath As String = Path.Combine(tempPath, Path.GetFileNameWithoutExtension(asset.Name))
                ZipFile.ExtractToDirectory(filePath, extractPath)

                ' Move os arquivos extraídos para o diretório de instalação
                MoveFilesToInstallationDirectory(extractPath, FolderPathTextBox.Text)

                ' Limpa os arquivos temporários
                Directory.Delete(extractPath, True)
                File.Delete(filePath)

                MessageBox.Show("Download e instalação concluídos.")
            Else
                MessageBox.Show("Ativo não encontrado.")
            End If
        Else
            MessageBox.Show("Menos de 4 assets encontrados na release.")
        End If
    End Sub

    ' Método auxiliar para download de arquivos com progresso
    Private Async Function DownloadFileAsync(url As String, destinationPath As String) As Task
        Using clientHandler As New HttpClientHandler()
            Using httpClient As New HttpClient(clientHandler)
                Using response As HttpResponseMessage = Await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead)
                    response.EnsureSuccessStatusCode()

                    Using fileStream As New FileStream(destinationPath, IO.FileMode.Create, FileAccess.Write, FileShare.None, 8192, True)
                        Using httpStream As Stream = Await response.Content.ReadAsStreamAsync()
                            Dim buffer As Byte() = New Byte(8191) {}
                            Dim bytesRead As Integer
                            Dim totalBytesRead As Long = 0
                            Dim totalBytes As Long = response.Content.Headers.ContentLength.Value
                            ProgressBar.Maximum = 100
                            ProgressBar.Minimum = 0

                            Do
                                bytesRead = Await httpStream.ReadAsync(buffer)
                                If bytesRead = 0 Then Exit Do

                                Await fileStream.WriteAsync(buffer.AsMemory(0, bytesRead))
                                totalBytesRead += bytesRead
                                ProgressBar.Value = Convert.ToInt32((totalBytesRead * 100L) / totalBytes)
                                ProgressBarLabel.Text = $"{ProgressBar.Value}%"
                            Loop
                        End Using
                    End Using
                End Using
            End Using
        End Using
    End Function

    ' Método auxiliar para mover arquivos extraídos para o diretório de instalação
    Private Sub MoveFilesToInstallationDirectory(sourceDirectory As String, destinationDirectory As String)
        ' Verifica se há pasta específica para copiar para a raiz do diretório de instalação
        Dim versionFolderName As String = GetVersionFolderName(sourceDirectory)
        If Not String.IsNullOrEmpty(versionFolderName) Then
            Dim versionFolderPath As String = Path.Combine(sourceDirectory, versionFolderName)
            If Directory.Exists(versionFolderPath) Then
                ' Copia os arquivos para a raiz do diretório de instalação
                For Each file In Directory.GetFiles(versionFolderPath, "*", SearchOption.AllDirectories)
                    Dim relativePath As String = file.Substring(versionFolderPath.Length + 1)
                    Dim destinationPath As String = Path.Combine(destinationDirectory, relativePath)

                    Dim destinationDir As String = Path.GetDirectoryName(destinationPath)
                    If Not Directory.Exists(destinationDir) Then
                        Directory.CreateDirectory(destinationDir)
                    End If

                    If System.IO.File.Exists(destinationPath) Then
                        System.IO.File.Delete(destinationPath)
                    End If
                    System.IO.File.Move(file, destinationPath)
                Next

                ' Verifica se a pasta de versão está vazia e a exclui
                If Directory.GetFiles(versionFolderPath, "*", SearchOption.AllDirectories).Length = 0 Then
                    Directory.Delete(versionFolderPath, True)
                End If
            End If
        End If

        ' Move os arquivos restantes para o diretório de instalação
        For Each file In Directory.GetFiles(sourceDirectory, "*", SearchOption.AllDirectories)
            Dim relativePath As String = file.Substring(sourceDirectory.Length + 1)
            Dim destinationPath As String = Path.Combine(destinationDirectory, relativePath)

            Dim destinationDir As String = Path.GetDirectoryName(destinationPath)
            If Not Directory.Exists(destinationDir) Then
                Directory.CreateDirectory(destinationDir)
            End If

            If System.IO.File.Exists(destinationPath) Then
                System.IO.File.Delete(destinationPath)
            End If
            System.IO.File.Move(file, destinationPath)
        Next
    End Sub

    ' Método auxiliar para obter o nome da pasta de versão específica
    Private Function GetVersionFolderName(directoryPath As String) As String
        ' Verifica se existe a pasta "ares-v" para versão estável
        Dim stableVersionFolder = Directory.GetDirectories(directoryPath, "ares-v*", SearchOption.TopDirectoryOnly).FirstOrDefault()
        If Not String.IsNullOrEmpty(stableVersionFolder) Then
            Return Path.GetFileName(stableVersionFolder)
        End If

        ' Verifica se existe a pasta "ares-nightly" para versão de pré-lançamento
        Dim nightlyVersionFolder = Directory.GetDirectories(directoryPath, "ares-nightly", SearchOption.TopDirectoryOnly).FirstOrDefault()
        If Not String.IsNullOrEmpty(nightlyVersionFolder) Then
            Return "ares-nightly"
        End If

        Return Nothing
    End Function

    ' Evento de clique no botão de Salvar Configurações
    Private Sub SaveSettingsButton_Click(sender As Object, e As EventArgs) Handles SaveSettingsButton.Click
        ' Salva o diretório de instalação e o link do firmware em algum lugar (exemplo: arquivo de configuração, banco de dados, etc.)
        ' Aqui, vamos apenas exibir uma mensagem de sucesso simulada
        MessageBox.Show("Configurações salvas com sucesso.")
    End Sub

    ' Evento de clique no botão Default
    Private Sub DefaultButton_Click(sender As Object, e As EventArgs) Handles DefaultButton.Click
        ' Restaura as configurações padrão (exemplo: limpa os campos de texto)
        FolderPathTextBox.Text = ""
        FirmwareUrlTextBox.Text = "https://github.com/leonardo201800478/BizHawk_Firmware/releases/download/BizHawk/Firmware.zip"
        ReleaseSelector.SelectedItem = "Estável"
        DownloadButton.Enabled = False ' Desabilita o botão de download após restaurar as configurações padrão
        MessageBox.Show("Configurações padrão restauradas.")
    End Sub

    ' Evento de clique no botão Sobre o Emulador
    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        ' Abre a página da web sobre o emulador
        Dim psi As New ProcessStartInfo()
        psi.UseShellExecute = True
        psi.FileName = "https://emulation.gametechwiki.com/index.php/Ares"
        Try
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Não foi possível abrir o URL no navegador. Erro: " & ex.Message)
        End Try
    End Sub

End Class

