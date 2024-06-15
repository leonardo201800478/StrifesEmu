Imports System.IO
Imports System.IO.Compression
Imports System.Net.Http
Imports Octokit

Public Class FormEMU7800
    Inherits System.Windows.Forms.Form

    ' Inicialização do Formulário
    Public Sub New()
        ' Este código de inicialização é necessário para o designer de formulários.
        InitializeComponent()

        ' Configurações iniciais
        VersionLabel.Text = "Emulador EMU7800"
        InstallationFolderLabel.Text = "Pasta de instalação:"
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

    ' Evento de clique no botão de download
    Private Async Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        If String.IsNullOrEmpty(FolderPathTextBox.Text) Then
            MessageBox.Show("Por favor, selecione a pasta de destino.")
            Return
        End If

        ' Crie um cliente GitHub anônimo
        Dim client As New GitHubClient(New ProductHeaderValue("Ares"))

        ' Defina o proprietário e o nome do repositório
        Dim owner As String = "emu7800" ' Substitua pelo nome do proprietário do repositório
        Dim repositoryName As String = "emu7800.github.io" ' Substitua pelo nome do repositório

        ' Obtenha a versão mais recente
        Dim releases = Await client.Repository.Release.GetAll(owner, repositoryName)
        Dim release As Release = releases.FirstOrDefault(Function(r) Not r.Prerelease)

        ' Verifique se há pelo menos 1 asset na release
        If release IsNot Nothing AndAlso release.Assets.Count >= 1 Then
            ' Pegue o primeiro asset da lista
            Dim asset As ReleaseAsset = release.Assets(0)

            ' Inicie o download e atualize a barra de progresso
            If asset IsNot Nothing Then
                Dim tempPath As String = Path.GetTempPath()
                Dim filePath As String = Path.Combine(tempPath, asset.Name)
                Await DownloadFileAsync(asset.BrowserDownloadUrl, filePath)

                ' Descompacta os arquivos diretamente na pasta de instalação, sobrescrevendo arquivos existentes
                ExtractZipFile(filePath, FolderPathTextBox.Text)

                ' Limpa os arquivos temporários
                File.Delete(filePath)

                MessageBox.Show("Download e instalação concluídos.")
            Else
                MessageBox.Show("Ativo não encontrado.")
            End If
        Else
            MessageBox.Show("Nenhum asset encontrado na release.")
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

    ' Método auxiliar para descompactar arquivos, sobrescrevendo se necessário
    Private Sub ExtractZipFile(zipFilePath As String, extractPath As String)
        Using archive As ZipArchive = ZipFile.OpenRead(zipFilePath)
            For Each entry As ZipArchiveEntry In archive.Entries
                Dim destinationPath As String = Path.Combine(extractPath, entry.FullName)
                Dim destinationDir As String = Path.GetDirectoryName(destinationPath)

                If Not Directory.Exists(destinationDir) Then
                    Directory.CreateDirectory(destinationDir)
                End If

                ' Sobrescreve o arquivo se ele já existir
                If Not String.IsNullOrEmpty(entry.Name) Then
                    entry.ExtractToFile(destinationPath, True)
                End If
            Next
        End Using
    End Sub

    ' Evento de clique no botão Sobre o Emulador
    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        ' Abre a página da web sobre o emulador
        Dim psi As New ProcessStartInfo()
        psi.UseShellExecute = True
        psi.FileName = "https://github.com/emu7800/emu7800.github.io"
        Try
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Não foi possível abrir o URL no navegador. Erro: " & ex.Message)
        End Try
    End Sub

End Class
