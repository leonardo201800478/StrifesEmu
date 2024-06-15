Imports System.IO
Imports System.IO.Compression
Imports System.Net.Http
Imports SevenZipExtractor

Public Class FormRetroarch
    Inherits System.Windows.Forms.Form

    Private Const RetroarchUrl As String = "https://buildbot.libretro.com/nightly/windows/x86_64/RetroArch.7z"
    Private Const RetroarchCoresUrl As String = "https://buildbot.libretro.com/nightly/windows/x86_64/RetroArch_cores.7z"
    Private Const FirmwareUrl As String = "https://archive.org/download/system_20240614/system.zip"

    Public Sub New()
        InitializeComponent()
        VersionLabel.Text = "Emulador Retroarch"
        InstallationFolderLabel.Text = "Pasta de instalação:"
        ProgressBarLabel.Text = "Progresso de download:"
        EmulatorDownloadButton.Enabled = False
        CoreDownloadButton.Enabled = False
        FirmwareDownloadButton.Enabled = False
    End Sub

    Private Sub SelectFolderButton_Click(sender As Object, e As EventArgs) Handles SelectFolderButton.Click
        Using folderBrowserDialog As New FolderBrowserDialog()
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                FolderPathTextBox.Text = folderBrowserDialog.SelectedPath
                EmulatorDownloadButton.Enabled = True
                CoreDownloadButton.Enabled = True
                FirmwareDownloadButton.Enabled = True
            End If
        End Using
    End Sub

    Private Async Function EmulatorDownloadButton_ClickAsync(sender As Object, e As EventArgs) As Task Handles EmulatorDownloadButton.Click
        Await DownloadAndExtractAsync(RetroarchUrl, "RetroArch.7z", "RetroArch-Win64")
    End Function

    Private Async Function CoreDownloadButton_ClickAsync(sender As Object, e As EventArgs) As Task Handles CoreDownloadButton.Click
        Await DownloadAndExtractAsync(RetroarchCoresUrl, "RetroArch_cores.7z", "RetroArch-Win64")
    End Function

    Private Async Function FirmwareDownloadButton_ClickAsync(sender As Object, e As EventArgs) As Task Handles FirmwareDownloadButton.Click
        Await DownloadAndExtractAsync(FirmwareUrl, "system.zip")
    End Function

    Private Async Function DownloadAndExtractAsync(url As String, fileName As String, Optional extractFolder As String = Nothing) As Task
        Dim tempPath As String = Path.GetTempPath()
        Dim filePath As String = Path.Combine(tempPath, fileName)
        Dim extractPath As String = If(extractFolder IsNot Nothing, Path.Combine(tempPath, extractFolder), tempPath)
        Dim destinationPath As String = FolderPathTextBox.Text

        ' Faz o download do arquivo
        Await DownloadFileAsync(url, filePath)

        ' Extrai o arquivo
        Try
            If fileName.EndsWith(".7z") Then
                Using archive As New ArchiveFile(filePath)
                    archive.Extract(extractPath)
                End Using
            Else
                ZipFile.ExtractToDirectory(filePath, extractPath)
            End If
        Catch ex As Exception
            MessageBox.Show($"Ocorreu um erro durante a extração: {ex.Message}")
        End Try

        ' Move o conteúdo para o diretório desejado
        MoveFilesRecursively(extractPath, destinationPath)

        ' Deleta os arquivos temporários
        File.Delete(filePath)
        If Directory.Exists(extractPath) Then
            Directory.Delete(extractPath, True)
        End If
    End Function

    Private Async Function DownloadFileAsync(url As String, destinationPath As String) As Task
        Using client As New HttpClient()
            Using response As HttpResponseMessage = Await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead)
                response.EnsureSuccessStatusCode()

                Using fileStream As New FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize:=8192, useAsync:=True)
                    Using httpStream As Stream = Await response.Content.ReadAsStreamAsync()
                        Dim buffer As Byte() = New Byte(8191) {}
                        Dim bytesRead As Integer
                        Dim totalBytesRead As Long = 0
                        Dim totalBytes As Long = response.Content.Headers.ContentLength.GetValueOrDefault()

                        Do
                            bytesRead = Await httpStream.ReadAsync(buffer, 0, buffer.Length)
                            If bytesRead = 0 Then Exit Do

                            Await fileStream.WriteAsync(buffer, 0, bytesRead)
                            totalBytesRead += bytesRead
                            ProgressBar.Value = CInt((totalBytesRead * 100L) / totalBytes)
                            ProgressBarLabel.Text = $"{ProgressBar.Value}%"
                        Loop
                    End Using
                End Using
            End Using
        End Using
    End Function

    Private Sub MoveFilesRecursively(sourcePath As String, destinationPath As String)
        If Not Directory.Exists(destinationPath) Then
            Directory.CreateDirectory(destinationPath)
        End If

        For Each file As String In Directory.GetFiles(sourcePath, "*", SearchOption.AllDirectories)
            Dim relativePath As String = Path.GetRelativePath(sourcePath, file)
            Dim destFilePath As String = Path.Combine(destinationPath, relativePath)
            Dim destDir As String = Path.GetDirectoryName(destFilePath)

            If Not Directory.Exists(destDir) Then
                Directory.CreateDirectory(destDir)
            End If

            System.IO.File.Move(file, destFilePath)
        Next
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
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
