﻿Imports System.IO
Imports System.IO.Compression
Imports System.Net.Http

Public Class Form4DO
    Inherits System.Windows.Forms.Form

    ' Inicialização do Formulário
    Public Sub New()
        ' Este código de inicialização é necessário para o designer de formulários.
        InitializeComponent()

        ' Configurações iniciais
        VersionLabel.Text = "Emulador 4DO"
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

    ' Evento de clique no botão de download do Emulador
    Private Async Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        Dim Url As String = "https://archive.org/download/4-do_20240614/4DO.zip"
        Dim fileName As String = Path.GetFileName(Url)
        Dim tempPath As String = Path.GetTempPath()
        Dim downloadPath As String = Path.Combine(tempPath, fileName)

        Try
            Await DownloadFileAsync(Url, downloadPath)

            ' Descompacta os arquivos do Emulador
            Dim extractPath As String = Path.Combine(tempPath, Path.GetFileNameWithoutExtension(fileName))
            ZipFile.ExtractToDirectory(downloadPath, extractPath)

            ' Move os arquivos extraídos para o diretório de instalação
            MoveFilesToInstallationDirectory(extractPath, FolderPathTextBox.Text)

            ' Limpa os arquivos temporários
            Directory.Delete(extractPath, True)
            File.Delete(downloadPath)

            MessageBox.Show("Emulador baixado e instalado com sucesso.")
        Catch ex As Exception
            MessageBox.Show($"Erro durante o download e instalação do emulador: {ex.Message}")
        End Try
    End Sub

    ' Método auxiliar para download de arquivos com progresso
    Private Async Function DownloadFileAsync(url As String, destinationPath As String) As Task
        Using clientHandler As New HttpClientHandler()
            Using httpClient As New HttpClient(clientHandler)
                Using response As HttpResponseMessage = Await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead)
                    response.EnsureSuccessStatusCode()

                    Using fileStream As New FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, True)
                        Using httpStream As Stream = Await response.Content.ReadAsStreamAsync()
                            Dim buffer As Byte() = New Byte(8191) {}
                            Dim bytesRead As Integer
                            Dim totalBytesRead As Long = 0
                            Dim totalBytes As Long = response.Content.Headers.ContentLength.Value
                            ProgressBar.Maximum = 100
                            ProgressBar.Minimum = 0

                            Do
                                bytesRead = Await httpStream.ReadAsync(buffer, 0, buffer.Length)
                                If bytesRead = 0 Then Exit Do

                                Await fileStream.WriteAsync(buffer, 0, bytesRead)
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
        ' Move todos os arquivos da pasta extraída para o diretório de instalação
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

    ' Evento de clique no botão Sobre o Emulador
    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        ' Abre a página da web sobre o emulador
        Dim psi As New ProcessStartInfo()
        psi.UseShellExecute = True
        psi.FileName = "https://emulation.gametechwiki.com/index.php/4DO"
        Try
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Não foi possível abrir o URL no navegador. Erro: " & ex.Message)
        End Try
    End Sub

End Class
