Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Octokit

Public Class FormAres
    Inherits System.Windows.Forms.Form

    ' Inicialização do Formulário
    Public Sub New()
        ' Este código de inicialização é necessário para o designer de formulários.
        InitializeComponent()
    End Sub

    ' Evento de clique no botão de download
    Private Async Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        ' Crie um cliente GitHub anônimo
        Dim client As New GitHubClient(New Headers.ProductHeaderValue("Ares"))

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
                Dim clientHandler As New HttpClientHandler()
                Dim httpClient As New HttpClient(clientHandler)

                Using response As HttpResponseMessage = Await httpClient.GetAsync(asset.BrowserDownloadUrl, HttpCompletionOption.ResponseHeadersRead)
                    response.EnsureSuccessStatusCode()

                    ' Crie o arquivo no disco
                    Dim filePath As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), asset.Name)
                    Using fileStream As New System.IO.FileStream(filePath, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None, 8192, True)
                        Using httpStream As IO.Stream = Await response.Content.ReadAsStreamAsync()
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
                            Loop
                        End Using
                    End Using
                End Using

                MessageBox.Show("Download concluído e salvo na área de trabalho.")
            Else
                MessageBox.Show("Ativo não encontrado.")
            End If
        Else
            MessageBox.Show("Menos de 4 assets encontrados na release.")
        End If
    End Sub
End Class