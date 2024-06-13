Imports System.Windows.Forms.DataFormats

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa a comboBoxSistema e comboBoxEmulador
        AddHandler comboBoxModalidade.SelectedIndexChanged, AddressOf ComboBoxModalidade_SelectedIndexChanged
        AddHandler comboBoxSistema.SelectedIndexChanged, AddressOf ComboBoxSistema_SelectedIndexChanged
    End Sub

    Private Sub ComboBoxModalidade_SelectedIndexChanged(sender As Object, e As EventArgs)
        comboBoxSistema.Items.Clear()
        comboBoxEmulador.Items.Clear()
        Select Case comboBoxModalidade.SelectedItem.ToString()
            Case "Arcade"
                Dim items As String() = New String() {"FB Neo", "MAME", "Sammy Atomiswave", "Sega Model 2", "Sega Model 3", "Sega NAOMI",
                                               "Sega NAOMI 2", "Sega ST-V", "SNK Neo Geo MVS", "TeknoParrot"}
                comboBoxSistema.Items.AddRange(items)
            Case "Computers"
                Dim items1 As String() = New String() {"Acorn RISC machines", "Amstrad CPC", "Apple I", "Apple II line", "Apple IIGS",
                                               "Apple III line", "Apple Lisa", "Apple Macintosh", "Atari 8-bit (400, 800, XL, XE)", "Atari ST", "BBC Micro",
                                               "Commodore 128", "Commodore 64", "Commodore Amiga", "Commodore VIC-20", "Fujitsu FM-7", "Microsoft MSX",
                                               "Microsoft MSX2", "MS-DOS", "NEC PC-8801", "NEC PC-9801", "ScummVM", "Sega Pico", "Sharp X1",
                                               "Sharp X68000", "Sinclair ZX Spectrum", "Sinclair ZX-81", "Windows 3.X"}
                comboBoxSistema.Items.AddRange(items1)
            Case "Consoles"
                Dim items2 As String() = New String() {"Apple Pippin", "Atari 2600", "Atari 5200", "Atari 7800", "Atari Jaguar", "Atari Jaguar CD", "Casio Loopy",
                                               "Casio PV-1000", "ColecoVision", "Commodore CD32", "Commodore CDTV", "Emerson Arcadia 2001",
                                               "Entex Adventure Vision", "Epoch Super Cassette Vision", "Fairchild Channel F", "Fujitsu FM Towns Marty",
                                               "Magnavox Odyssey", "Magnavox Odyssey²", "Mattel Intellivision", "Microsoft Xbox", "Microsoft Xbox 360",
                                               "Nec PC Engine (TurboGrafx-16)", "Nec PC Engine CD (TurboGrafx-CD)", "Nec PC Engine SuperGrafx", "Nec PC-FX",
                                               "Nintendo 64", "Nintendo 64DD", "Nintendo Entertainment System", "Nintendo Famicom Disk System",
                                               "Nintendo GameCube", "Nintendo Satellaview", "Nintendo Sufami Turbo", "Nintendo Wii", "Nintendo Wii U",
                                               "3DO Interactive Multiplayer", "Philips CD-i", "Sega 32X", "Sega CD", "Sega CD 32X", "Sega Dreamcast", "Sega Genesis",
                                               "Sega Master System", "Sega Saturn", "Sega SG-1000", "SNK Neo Geo AES", "SNK Neo Geo CD", "Sony PlayStation",
                                               "Sony PlayStation 2", "Sony PlayStation 3", "Super Cassette Vision", "Super Nintendo", "V.Flash", "V.Smile",
                                               "VTech CreatiVision", "Zeebo"}
                comboBoxSistema.Items.AddRange(items2)
            Case "Handhelds"
                Dim items3 As String() = New String() {"Atari Lynx", "Bandai WonderSwan", "Bandai WonderSwan Color", "Nintendo 3DS", "Nintendo DS",
                                               "Nintendo Game & Watch", "Nintendo Game Boy", "Nintendo Game Boy Advance", "Nintendo Game Boy Color",
                                               "Nintendo Pokemon mini", "Nintendo Switch", "Nintendo Virtua Boy", "Sega Game Gear", "SNK Neo Geo Pocket",
                                               "SNK Neo Geo Pocket Color", "Sony PlayStation Portable", "Sony PlayStation Vita", "Sony PocketStation",
                                               "Watara Super Vision"}
                comboBoxSistema.Items.AddRange(items3)
        End Select
    End Sub

    Private Sub ComboBoxSistema_SelectedIndexChanged(sender As Object, e As EventArgs)
        comboBoxEmulador.Items.Clear()
        Select Case comboBoxSistema.SelectedItem.ToString()
            ' Adicione cases para outros emuladores aqui, seguindo o mesmo padrão
            Case "3DO Interactive Multiplayer"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Phoenix", "4DO"})
                ' Continue adicionando para cada emulador...
            Case "Acorn RISC machines"
                comboBoxEmulador.Items.AddRange(New String() {"Arculator"})
            Case "Amstrad CPC"
                comboBoxEmulador.Items.AddRange(New String() {"ACE", "Arnold", "Retroarch", "CaPriCe32"})
            Case "Apple I"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Retroarch"})
            Case "Apple II line"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Retroarch", "AppleWin"})
            Case "Apple IIGS"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Retroarch", "AppleWin"})
            Case "Apple III line"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Retroarch"})
            Case "Apple Lisa"
                comboBoxEmulador.Items.AddRange(New String() {"LisaEm"})
            Case "Apple Macintosh"
                comboBoxEmulador.Items.AddRange(New String() {"BasiliskII"})
            Case "Apple Pippin"
                comboBoxEmulador.Items.AddRange(New String() {"DingusPPC", "SheepShaver"})
            Case "Atari 2600"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Stella", "MAME"})
            Case "Atari 5200"
                comboBoxEmulador.Items.AddRange(New String() {"Altirra", "Retroarch"})
            Case "Atari 7800"
                comboBoxEmulador.Items.AddRange(New String() {"BupSystem", "MAME", "A7800", "Retroarch"})
            Case "Atari 8-bit (400, 800, XL, XE)"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Atari Jaguar"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Atari Jaguar CD"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Atari Lynx"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Atari ST"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "BBC Micro"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Casio Loopy"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Casio PV-1000"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "ColecoVision"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Commodore 128"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Commodore 64"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Commodore Amiga"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Commodore CD32"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Commodore CDTV"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "VTech CreatiVision"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Emerson Arcadia 2001"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Entex Adventure Vision"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Epoch Super Cassette Vision"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Fairchild Channel F"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "FB Neo"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Fujitsu FM Towns Marty"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Fujitsu FM-7"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Game Boy"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Game Boy Color"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Game Boy Advance"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega Game Gear"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Mattel Intellivision"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Magnavox Odyssey"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Magnavox Odyssey²"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "MAME"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega Master System"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "MS-DOS"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Microsoft MSX"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Microsoft MSX2"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega NAOMI"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega NAOMI 2"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo DS"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "SNK Neo Geo MVS"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "SNK Neo Geo AES"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "SNK Neo Geo CD"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "SNK Neo Geo Pocket"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "SNK Neo Geo Pocket Color"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo 3DS"
                comboBoxEmulador.Items.AddRange(New String() {"Citra", "Lime3DS"})
            Case "Nintendo 64"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo 64DD"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo Entertainment System"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo Famicom Disk System"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo Satellaview"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo Sufami Turbo"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo GameCube"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo Switch"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nec PC Engine (TurboGrafx-16)"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nec PC Engine CD (TurboGrafx-CD)"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nec PC Engine SuperGrafx"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo Virtua Boy"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo Switch"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "NEC PC-8801"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "NEC PC-9801"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "ScummVM"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega Pico"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Windows 3.X"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "NEC PC-FX"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Philips CD-i"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sony PlayStation"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sony PlayStation 2"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sony PlayStation 3"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sony PlayStation Portable"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sony PlayStation Vita"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sony PocketStation"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo Pokemon mini"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega Dreamcast"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega Genesis"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega 32X"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega CD"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega CD 32X"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega Model 2"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sammy Atomiswave"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega Model 3"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega Pico"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega Saturn"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega ST-V"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sega SG-1000"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Super Cassette Vision"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Super Nintendo"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Watara Super Vision"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "TeknoParrot"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "V.Flash"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "V.Smile"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Commodore VIC-20"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo Wii"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Nintendo Wii U"
                comboBoxEmulador.Items.AddRange(New String() {"Cemu"})
            Case "Bandai WonderSwan"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Bandai WonderSwan Color"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sharp X1"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sharp X68000"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Microsoft Xbox"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Microsoft Xbox 360"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Zeebo"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S"})
            Case "Sinclair ZX Spectrum"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Retroarch"})
            Case "Sinclair ZX-81"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Retroarch"})
            Case Else
                MessageBox.Show("Sistema não suportado ainda.")
        End Select
    End Sub

    Private Sub buttonSelecionarEmulador_Click(sender As Object, e As EventArgs) Handles buttonSelecionarEmulador.Click
        Dim selectedEmulator As String = comboBoxEmulador.SelectedItem?.ToString()

        If String.IsNullOrEmpty(selectedEmulator) Then
            MessageBox.Show("Por favor, selecione um emulador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Select Case selectedEmulator
            Case "4DO"
                Dim Form4DO As New Form4DO()
                Form4DO.Show()
            Case "A7800"
                Dim FormA7800 As New FormA7800()
                FormA7800.Show()
            Case "ACE"
                Dim FormACE As New FormACE()
                FormACE.Show()
            Case "AppleWin"
                Dim FormAppleWin As New FormAppleWin()
                FormAppleWin.Show()
            Case "Arculator"
                Dim FormArculator As New FormArculator()
                FormArculator.Show()
            Case "Ares"
                Dim FormAres As New FormAres()
                FormAres.Show()
            Case "Arnold"
                Dim FormArnold As New FormArnold()
                FormArnold.Show()
            Case "Altirra"
                Dim FormAltirra As New FormAltirra()
                FormAltirra.Show()
            Case "BasiliskII"
                Dim FormBasiliskII As New FormBasiliskII()
                FormBasiliskII.Show()
            Case "Bsnes"
                Dim FormBsnes As New FormBsnes()
                FormBsnes.Show()
            Case "BsnesNightly"
                Dim FormBsnesNightly As New FormBsnesNightly()
                FormBsnesNightly.Show()
            Case "BupSystem"
                Dim FormBupSystem As New FormBupSystem()
                FormBupSystem.Show()
            Case "CaPriCe32"
                Dim FormCaPriCe32 As New FormCaPriCe32()
                FormCaPriCe32.Show()
            Case "Cemu"
                Dim FormCemu As New FormCemu()
                FormCemu.Show()
            Case "Citra"
                Dim FormCitra As New FormCitra()
                FormCitra.Show()
            Case "DingusPPC"
                Dim FormDingusPPC As New FormDingusPPC()
                FormDingusPPC.Show()
            Case "Higan"
                Dim FormHigan As New FormRetroarch()
                FormHigan.Show()
            Case "Lime3DS"
                Dim FormLime3DS As New FormLime3DS()
                FormLime3DS.Show()
            Case "LisaEm"
                Dim FormLisaEm As New FormLisaEm()
                FormLisaEm.Show()
            Case "Mesen-S"
                Dim FormMesenS As New FormRetroarch()
                FormMesenS.Show()
            Case "Phoenix"
                Dim FormPhoenix As New FormPhoenix()
                FormPhoenix.Show()
            Case "Retroarch"
                Dim FormRetroarch As New FormRetroarch()
                FormRetroarch.Show()
            Case "SheepShaver"
                Dim FormSheepShaver As New FormSheepShaver()
                FormSheepShaver.Show()
            Case "Stella"
                Dim FormStella As New FormStella()
                FormStella.Show()
        End Select
    End Sub
End Class
