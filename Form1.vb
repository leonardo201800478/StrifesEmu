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
            Case "Consoles"
                Dim items As String() = New String() {"3DO Interactive Multiplayer", "Amiga CD32", "Apple Pippin", "Atari 2600", "Atari 5200", "Atari 7800", "Atari Jaguar", "Atari Jaguar CD",
                                                "Atari XEGS", "ColecoVision", "Commodore CDTV", "Emerson Arcadia 2001",
                                               "Epoch Super Cassette Vision", "Fairchild Channel F", "Fujitsu FM Towns Marty",
                                               "Magnavox Odyssey", "Magnavox Odyssey²", "Mattel Intellivision", "Microsoft Xbox", "Microsoft Xbox 360",
                                               "Nec PC Engine (TurboGrafx-16)", "Nec PC Engine CD (TurboGrafx-CD)", "Nec PC Engine SuperGrafx", "Nec PC-FX",
                                               "Nintendo 64", "Nintendo 64DD", "Nintendo Entertainment System", "Nintendo Famicom Disk System",
                                               "Nintendo GameCube", "Nintendo Satellaview", "Nintendo Sufami Turbo", "Nintendo Wii", "Nintendo Wii U",
                                               "Philips CD-i", "Sega 32X", "Sega CD", "Sega CD 32X", "Sega Dreamcast", "Sega Genesis",
                                               "Sega Master System", "Sega Saturn", "Sega SG-1000", "SNK Neo Geo AES", "SNK Neo Geo CD", "Sony PlayStation",
                                               "Sony PlayStation 2", "Sony PlayStation 3", "Super Cassette Vision", "Super Nintendo", "Nintendo Virtual Boy", "V.Smile",
                                               "VTech CreatiVision", "Zeebo"}
                comboBoxSistema.Items.AddRange(items)
            Case "Computers"
                Dim items1 As String() = New String() {"Acorn RISC machines", "Amstrad CPC", "Apple I", "Apple II line", "Apple IIGS",
                                               "Apple III line", "Apple Lisa", "Apple Macintosh", "Atari 8-bit (400, 800, XL, XE)", "Atari ST", "BBC Micro",
                                               "Commodore 128", "Commodore 64", "Commodore Amiga", "Commodore VIC-20", "Fujitsu FM-7", "Microsoft MSX",
                                               "Microsoft MSX2", "MS-DOS", "NEC PC-8801", "NEC PC-9801", "ScummVM", "Sega Pico", "Sharp X1",
                                               "Sharp X68000", "Sinclair ZX Spectrum", "Sinclair ZX-81", "Windows 3.X"}
                comboBoxSistema.Items.AddRange(items1)

            Case "Handhelds"
                Dim items2 As String() = New String() {"Atari Lynx", "Bandai WonderSwan", "Bandai WonderSwan Color", "Nintendo 3DS", "Nintendo DS",
                                               "Nintendo Game & Watch", "Nintendo Game Boy", "Nintendo Game Boy Advance", "Nintendo Game Boy Color",
                                               "Nintendo Pokemon mini", "Nintendo Switch", "Sega Game Gear", "SNK Neo Geo Pocket",
                                               "SNK Neo Geo Pocket Color", "Sony PlayStation Portable", "Sony PlayStation Vita", "Sony PocketStation",
                                               "Watara Super Vision"}
                comboBoxSistema.Items.AddRange(items2)
            Case "Arcade"
                Dim items As String() = New String() {"FB Neo", "MAME", "Cave CV1000", "Sammy Atomiswave", "Sega Hikaru", "Sega Model 2", "Sega Model 3", "Sega NAOMI",
                                               "Sega NAOMI 2", "Gaelco PowerVR", "Sega ST-V", "SNK Neo Geo MVS", "TeknoParrot"}
                comboBoxSistema.Items.AddRange(items)
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
            Case "Amiga CD32"
                comboBoxEmulador.Items.AddRange(New String() {"FS-UAE", "Retroarch", "WinUAE"})
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
                comboBoxEmulador.Items.AddRange(New String() {"BupSystem", "MAME", "A7800", "Retroarch", "EMU7800"})
            Case "Atari 8-bit (400, 800, XL, XE)"
                comboBoxEmulador.Items.AddRange(New String() {"Atari800", "Retroarch", "Altirra", "Atari++", "MAME"})
            Case "Atari Jaguar"
                comboBoxEmulador.Items.AddRange(New String() {"BigPEmu", "BizHawk", "Retroarch", "Phoenix"})
            Case "Atari Jaguar CD"
                comboBoxEmulador.Items.AddRange(New String() {"BigPEmu"})
            Case "Atari Lynx"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Mednafen", "MAME", "Felix"})
            Case "Atari ST"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Hatari", "Steem SSE", "ARAnyM"})
            Case "Atari XEGS "
                comboBoxEmulador.Items.AddRange(New String() {"Altirra", "MAME", "Retroarch"})
            Case "BBC Micro"
                comboBoxEmulador.Items.AddRange(New String() {"BeebEM", "B-em"})
            Case "ColecoVision"
                comboBoxEmulador.Items.AddRange(New String() {"BizHawk", "ColEm", "E.mul T.wo", "ADAMEm SDL", "Ares", "Retroarch"})
            Case "Commodore 128"
                comboBoxEmulador.Items.AddRange(New String() {"VICE", "Retroarch", "Z64K", "MAME"})
            Case "Commodore VIC-20"
                comboBoxEmulador.Items.AddRange(New String() {"VICE", "Z64K", "Retroarch", "MAME"})
            Case "Commodore 64"
                comboBoxEmulador.Items.AddRange(New String() {"Denise", "VICE", "Retroarch", "Hoxs64"})
            Case "Commodore Amiga"
                comboBoxEmulador.Items.AddRange(New String() {"FS-UAE", "Retroarch", "WinUAE"})
            Case "Commodore CDTV"
                comboBoxEmulador.Items.AddRange(New String() {"FS-UAE", "Retroarch", "WinUAE"})
            Case "VTech CreatiVision"
                comboBoxEmulador.Items.AddRange(New String() {"cvemu", "MAME", "Retroarch"})
            Case "Emerson Arcadia 2001"
                comboBoxEmulador.Items.AddRange(New String() {"WinArcadia", "MAME", "Retroarch"})
            Case "Epoch Super Cassette Vision"
                comboBoxEmulador.Items.AddRange(New String() {"eSCV", "MAME", "Retroarch"})
            Case "Fairchild Channel F"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "MAME", "FreeChaF", "FinalBurn Neo"})
            Case "FB Neo"
                comboBoxEmulador.Items.AddRange(New String() {"FinalBurn Neo", "Retroarch"})
            Case "Fujitsu FM Towns Marty"
                comboBoxEmulador.Items.AddRange(New String() {"Tsugaru", "UNZ", "Xe", "MAME", "Retroarch"})
            Case "Fujitsu FM-7"
                comboBoxEmulador.Items.AddRange(New String() {"Tsugaru", "DREAMM", "UNZ", "Xe", "MAME", "Retroarch"})
            Case "Nintendo Game Boy"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "SameBoy", "BGB", "BizHawk", "Emulicious", "Gambatte", "Mesen"})
            Case "Nintendo Game Boy Color"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "SameBoy", "BGB", "BizHawk", "Emulicious", "Gambatte", "Mesen"})
            Case "Nintendo Game Boy Advance"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "mGBA", "VBA-M"})
            Case "Nintendo Game & Watch"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Retroarch"})
            Case "Mattel Intellivision"
                comboBoxEmulador.Items.AddRange(New String() {"jzIntv", "Retroarch", "MAME"})
            Case "Magnavox Odyssey"
                comboBoxEmulador.Items.AddRange(New String() {"Odyemu", "Odyssey Now", "Magnavody"})
            Case "Magnavox Odyssey²"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Retroarch", "O2EM"})
            Case "MAME"
                comboBoxEmulador.Items.AddRange(New String() {"MAME"})
            Case "MS-DOS"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "DOSBox", "DOSBox-X", "DOSBox Staging"})
            Case "Microsoft MSX"
                comboBoxEmulador.Items.AddRange(New String() {"openMSX", "blueMSX", "Retroarch", "MAME", "fMSX"})
            Case "Microsoft MSX2"
                comboBoxEmulador.Items.AddRange(New String() {"openMSX", "blueMSX", "Retroarch", "MAME", "fMSX"})
            Case "Sega NAOMI"
                comboBoxEmulador.Items.AddRange(New String() {"DEmul", "Flycast", "Retroarch"})
            Case "Sega NAOMI 2"
                comboBoxEmulador.Items.AddRange(New String() {"DEmul", "Flycast", "Retroarch"})
            Case "Sega Hikaru"
                comboBoxEmulador.Items.AddRange(New String() {"DEmul"})
            Case "Cave CV1000"
                comboBoxEmulador.Items.AddRange(New String() {"FinalBurn Neo", "DEmul"})
            Case "Gaelco PowerVR"
                comboBoxEmulador.Items.AddRange(New String() {"DEmul"})
            Case "Sega Model 2"
                comboBoxEmulador.Items.AddRange(New String() {"Model 2 Emulator"})
            Case "Sammy Atomiswave"
                comboBoxEmulador.Items.AddRange(New String() {"DEmul", "Flycast", "Retroarch"})
            Case "Sega Model 3"
                comboBoxEmulador.Items.AddRange(New String() {"Supermodel"})
            Case "Nintendo DS"
                comboBoxEmulador.Items.AddRange(New String() {"melonDS", "Retroarch", "DeSmuME", "BizHawk"})
            Case "SNK Neo Geo MVS"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Retroarch", "FinalBurn Neo", "RAINE", "Ares"})
            Case "SNK Neo Geo AES"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Retroarch", "FinalBurn Neo", "RAINE", "Ares"})
            Case "SNK Neo Geo CD"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Retroarch", "RAINE"})
            Case "SNK Neo Geo Pocket"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Mednafen", "Retroarch", "FinalBurn Neo"})
            Case "SNK Neo Geo Pocket Color"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Mednafen", "Retroarch", "FinalBurn Neo"})
            Case "Nintendo 3DS"
                comboBoxEmulador.Items.AddRange(New String() {"Citra", "Lime3DS"})
            Case "Nintendo 64"
                comboBoxEmulador.Items.AddRange(New String() {"Mupen64Plus-Next", "Ares", "Retroarch", "simple64", "RMG", "BizHawk", "Project64"})
            Case "Nintendo 64DD"
                comboBoxEmulador.Items.AddRange(New String() {"Mupen64Plus-Next", "Ares", "Retroarch", "simple64", "RMG", "BizHawk", "Project64"})
            Case "Nintendo Entertainment System"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Mesen", "puNES", "Nestopia UE", "FCEUX", "Ares", "BizHawk"})
            Case "Nintendo Famicom Disk System"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Mesen", "puNES", "Nestopia UE", "FCEUX", "Ares", "BizHawk"})
            Case "Nintendo Pokemon mini"
                comboBoxEmulador.Items.AddRange(New String() {"GBE+", "Retroarch"})
            Case "Super Nintendo"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Bsnes", "Retroarch", "Mesen-S", "Mesen2", "Snes9x", "BizHawk", "Higan", "MAME"})
            Case "Nintendo Satellaview"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Snes9x"})
            Case "Nintendo Sufami Turbo"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Snes9x"})
            Case "Nintendo GameCube"
                comboBoxEmulador.Items.AddRange(New String() {"Dolphin", "Retroarch"})
            Case "Nintendo Wii"
                comboBoxEmulador.Items.AddRange(New String() {"Dolphin", "Retroarch"})
            Case "Nintendo Wii U"
                comboBoxEmulador.Items.AddRange(New String() {"Cemu"})
            Case "Nintendo Switch"
                comboBoxEmulador.Items.AddRange(New String() {"Ryujinx", "Sudachi"})
            Case "Nec PC Engine (TurboGrafx-16)"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Mednafen", "Ares", "Mesen", "BizHawk"})
            Case "Nec PC Engine CD (TurboGrafx-CD)"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Mednafen", "Ares", "Mesen", "BizHawk"})
            Case "Nec PC Engine SuperGrafx"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Mednafen", "Ares", "Mesen", "BizHawk"})
            Case "Nintendo Virtual Boy"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Mednafen", "VBjin"})
            Case "NEC PC-8801"
                comboBoxEmulador.Items.AddRange(New String() {"ePC8801MA Kai SE", "ePC-8001", "XM8", "M88 for OS/2", "PC88EM", "Retroarch"})
            Case "NEC PC-9801"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Neko Project II", "SL9821", "ePC-9801", "Anex86"})
            Case "ScummVM"
                comboBoxEmulador.Items.AddRange(New String() {"ScummVM", "Retroarch"})
            Case "Windows 3.X"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "DOSBox"})
            Case "NEC PC-FX"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Mednafen", "Ares", "Mesen", "BizHawk"})
            Case "Philips CD-i"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "MAME"})
            Case "Sony PlayStation"
                comboBoxEmulador.Items.AddRange(New String() {"DuckStation", "Mednafen", "Retroarch"})
            Case "Sony PlayStation 2"
                comboBoxEmulador.Items.AddRange(New String() {"PCSX2", "Retroarch"})
            Case "Sony PlayStation 3"
                comboBoxEmulador.Items.AddRange(New String() {"RPCS3"})
            Case "Sony PlayStation Portable"
                comboBoxEmulador.Items.AddRange(New String() {"PPSSPP", "Retroarch", "JPCSP"})
            Case "Sony PlayStation Vita"
                comboBoxEmulador.Items.AddRange(New String() {"Vita3K"})
            Case "Sony PocketStation"
                comboBoxEmulador.Items.AddRange(New String() {"PK201", "MAME", "Retroarch"})
            Case "Sega Dreamcast"
                comboBoxEmulador.Items.AddRange(New String() {"Flycast", "Retroarch", "redream", "DEmul"})
            Case "Sega Game Gear"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "MAME", "Ares", "Emulicius", "BizHawk", "Mesen", "Kega Fusion"})
            Case "Sega Master System"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "MAME", "Ares", "Emulicius", "BizHawk", "Mesen", "Kega Fusion"})
            Case "Sega Pico"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Kega Fusion"})
            Case "Sega Genesis"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "BlastEm", "Ares", "BizHawk", "Kega Fusion"})
            Case "Sega 32X"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Ares", "BizHawk", "Kega Fusion"})
            Case "Sega CD"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Ares", "MAME", "Kega Fusion"})
            Case "Sega CD 32X"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Ares", "Kega Fusion"})
            Case "Sega Saturn"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Mednafen", "Kronos", "BizHawk", "SSF"})
            Case "Sega ST-V"
                comboBoxEmulador.Items.AddRange(New String() {"Retroarch", "Mednafen", "MAME", "SSF"})
            Case "Sega SG-1000"
                comboBoxEmulador.Items.AddRange(New String() {"MasterGear", "Retroarch", "MAME", "Ares", "BizHawk", "Kega Fusion"})
            Case "Super Cassette Vision"
                comboBoxEmulador.Items.AddRange(New String() {"eSCV", "MAME", "Retroarch"})
            Case "Watara Super Vision"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Retroarch"})
            Case "TeknoParrot"
                comboBoxEmulador.Items.AddRange(New String() {"TeknoParrot"})
            Case "V.Smile"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Retroarch"})
            Case "Bandai WonderSwan"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Mednafen", "Retroarch", "BizHawk"})
            Case "Bandai WonderSwan Color"
                comboBoxEmulador.Items.AddRange(New String() {"Ares", "Mednafen", "Retroarch", "BizHawk"})
            Case "Sharp X1"
                comboBoxEmulador.Items.AddRange(New String() {"eX1", "Retroarch"})
            Case "Sharp X68000"
                comboBoxEmulador.Items.AddRange(New String() {"MAME", "Retroarch", "XM6"})
            Case "Microsoft Xbox"
                comboBoxEmulador.Items.AddRange(New String() {"xemu", "Cxbx-Reloaded"})
            Case "Microsoft Xbox 360"
                comboBoxEmulador.Items.AddRange(New String() {"Xenia"})
            Case "Zeebo"
                comboBoxEmulador.Items.AddRange(New String() {"Infuse"})
            Case "Sinclair ZX Spectrum"
                comboBoxEmulador.Items.AddRange(New String() {"EightyOne", "Retroarch", "FUSE", "Speccy", "ZEsarUX"})
            Case "Sinclair ZX-81"
                comboBoxEmulador.Items.AddRange(New String() {"CLK", "ZEsarUX", "Retroarch", "EightyOne"})
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
            Case "ADAMEm SDL"
                Dim FormADAMEmSDL As New FormADAMEmSDL()
                FormADAMEmSDL.Show()
            Case "Anex86"
                Dim FormAnex86 As New FormAnex86()
                FormAnex86.Show()
            Case "AppleWin"
                Dim FormAppleWin As New FormAppleWin()
                FormAppleWin.Show()
            Case "ARAnyM"
                Dim FormARAnyM As New FormARAnyM()
                FormARAnyM.Show()
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
            Case "Atari++"
                Dim FormAtariPlusPlus As New FormAtariPlusPlus()
                FormAtariPlusPlus.Show()
            Case "B-em"
                Dim FormBem As New FormBem()
                FormBem.Show()
            Case "BasiliskII"
                Dim FormBasiliskII As New FormBasiliskII()
                FormBasiliskII.Show()
            Case "BeebEM"
                Dim FormBeebEM As New FormBeebEM()
                FormBeebEM.Show()
            Case "BGB"
                Dim FormBGB As New FormBGB()
                FormBGB.Show()
            Case "BigPEmu"
                Dim FormBigPEmu As New FormBigPEmu()
                FormBigPEmu.Show()
            Case "BizHawk"
                Dim FormBizHawk As New FormBizHawk()
                FormBizHawk.Show()
            Case "BlastEm"
                Dim FormBlastEm As New FormBlastEm()
                FormBlastEm.Show()
            Case "blueMSX"
                Dim FormblueMSX As New FormblueMSX()
                FormblueMSX.Show()
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
            Case "Cxbx-Reloaded"
                Dim FormCxbxReloaded As New FormCxbxReloaded()
                FormCxbxReloaded.Show()
            Case "Cemu"
                Dim FormCemu As New FormCemu()
                FormCemu.Show()
            Case "CLK"
                Dim FormCLK As New FormCLK()
                FormCLK.Show()
            Case "Citra"
                Dim FormCitra As New FormCitra()
                FormCitra.Show()
            Case "ColEm"
                Dim FormColEm As New FormColEm()
                FormColEm.Show()
            Case "cvemu"
                Dim Formcvemu As New Formcvemu()
                Formcvemu.Show()
            Case "Denise"
                Dim FormDenise As New FormDenise()
                FormDenise.Show()
            Case "DEmul"
                Dim FormDEmul As New FormDEmul()
                FormDEmul.Show()
            Case "DeSmuME"
                Dim FormDeSmuME As New FormDeSmuME()
                FormDeSmuME.Show()
            Case "DingusPPC"
                Dim FormDingusPPC As New FormDingusPPC()
                FormDingusPPC.Show()
            Case "DREAMM"
                Dim FormDREAMM As New FormDREAMM()
                FormDREAMM.Show()
            Case "Dolphin"
                Dim FormDolphin As New FormDolphin()
                FormDolphin.Show()
            Case "DOSBox"
                Dim FormDOSBox As New FormDOSBox()
                FormDOSBox.Show()
            Case "DOSBox-X"
                Dim FormDOSBoxX As New FormDOSBoxX()
                FormDOSBoxX.Show()
            Case "DOSBox Staging"
                Dim FormDOSBoxStaging As New FormDOSBoxStaging()
                FormDOSBoxStaging.Show()
            Case "DuckStation"
                Dim FormDuckStation As New FormDuckStation()
                FormDuckStation.Show()
            Case "EightyOne"
                Dim FormEightyOne As New FormEightyOne()
                FormEightyOne.Show()
            Case "EMU7800"
                Dim FormEMU7800 As New FormEMU7800()
                FormEMU7800.Show()
            Case "Emulicious"
                Dim FormEmulicious As New FormEmulicious()
                FormEmulicious.Show()
            Case "E.mul T.wo"
                Dim FormEmulTwo As New FormEmulTwo()
                FormEmulTwo.Show()
            Case "ePC8801MA Kai SE"
                Dim FormePC8801MAKai As New FormePC8801MAKai()
                FormePC8801MAKai.Show()
            Case "ePC-8001"
                Dim FormePC8001 As New FormePC8001()
                FormePC8001.Show()
            Case "ePC-9801"
                Dim FormePC9801 As New FormePC9801()
                FormePC9801.Show()
            Case "eSCV"
                Dim FormeSCV As New FormeSCV()
                FormeSCV.Show()
            Case "eX1"
                Dim FormeX1 As New FormeX1()
                FormeX1.Show()
            Case "Felix"
                Dim FormFelix As New FormFelix()
                FormFelix.Show()
            Case "FreeChaF"
                Dim FormFreeChaF As New FormFreeChaF()
                FormFreeChaF.Show()
            Case "FinalBurn Neo"
                Dim FormFBNeo As New FormFBNeo()
                FormFBNeo.Show()
            Case "Flycast"
                Dim FormFlycast As New FormFlycast()
                FormFlycast.Show()
            Case "FS-UAE"
                Dim FormFSUAE As New FormFSUAE()
                FormFSUAE.Show()
            Case "FCEUX"
                Dim FormFCEUX As New FormFCEUX()
                FormFCEUX.Show()
            Case "FUSE"
                Dim FormFUSE As New FormFUSE()
                FormFUSE.Show()
            Case "Gambatte"
                Dim FormGambatte As New FormGambatte()
                FormGambatte.Show()
            Case "GBE+"
                Dim FormGBEPlus As New FormGBEPlus()
                FormGBEPlus.Show()
            Case "Hatari"
                Dim FormHatari As New FormHatari()
                FormHatari.Show()
            Case "Higan"
                Dim FormHigan As New FormHigan()
                FormHigan.Show()
            Case "Hoxs64"
                Dim FormHoxs64 As New FormHoxs64()
                FormHoxs64.Show()
            Case "Infuse"
                Dim FormInfuse As New FormInfuse()
                FormInfuse.Show()
            Case "JPCSP"
                Dim FormJPCSP As New FormJPCSP()
                FormJPCSP.Show()
            Case "jzIntv"
                Dim FormjzIntv As New FormjzIntv()
                FormjzIntv.Show()
            Case "Lime3DS"
                Dim FormLime3DS As New FormLime3DS()
                FormLime3DS.Show()
            Case "LisaEm"
                Dim FormLisaEm As New FormLisaEm()
                FormLisaEm.Show()
            Case "Kega Fusion"
                Dim FormKegaFusion As New FormKegaFusion()
                FormKegaFusion.Show()
            Case "M88 for OS/2"
                Dim FormM88 As New FormM88()
                FormM88.Show()
            Case "Magnavody"
                Dim FormMagnavody As New FormMagnavody()
                FormMagnavody.Show()
            Case "MAME"
                Dim FormMAME As New FormMAME()
                FormMAME.Show()
            Case "MasterGear"
                Dim FormMasterGear As New FormMasterGear()
                FormMasterGear.Show()
            Case "melonDS"
                Dim FormmelonDS As New FormmelonDS()
                FormmelonDS.Show()
            Case "Mednafen"
                Dim FormMednafen As New FormMednafen()
                FormMednafen.Show()
            Case "Mesen"
                Dim FormMesen As New FormMesen()
                FormMesen.Show()
            Case "Mesen2"
                Dim FormMesen2 As New FormMesen2()
                FormMesen2.Show()
            Case "Mesen-S"
                Dim FormMesenS As New FormMesenS()
                FormMesenS.Show()
            Case "mGBA"
                Dim FormmGBA As New FormmGBA()
                FormmGBA.Show()
            Case "Model 2 Emulator"
                Dim FormModel2 As New FormModel2()
                FormModel2.Show()
            Case "Mupen64Plus-Next"
                Dim FormMupen64PlusNext As New FormMupen64PlusNext()
                FormMupen64PlusNext.Show()
            Case "Neko Project II"
                Dim FormNekoProjectII As New FormNekoProjectII()
                FormNekoProjectII.Show()
            Case "Nestopia UE"
                Dim FormNestopia As New FormNestopia()
                FormNestopia.Show()
            Case "O2EM"
                Dim FormO2EM As New FormO2EM()
                FormO2EM.Show()
            Case "Odyemu"
                Dim FormOdyemu As New FormOdyemu()
                FormOdyemu.Show()
            Case "Odyssey Now"
                Dim FormOdysseyNow As New FormOdysseyNow()
                FormOdysseyNow.Show()
            Case "openMSX"
                Dim FormopenMSX As New FormopenMSX()
                FormopenMSX.Show()
            Case "PC88EM"
                Dim FormPC88EM As New FormPC88EM()
                FormPC88EM.Show()
            Case "PCSX2"
                Dim FormPCSX2 As New FormPCSX2()
                FormPCSX2.Show()
            Case "Phoenix"
                Dim FormPhoenix As New FormPhoenix()
                FormPhoenix.Show()
            Case "PK201"
                Dim FormPK201 As New FormPK201()
                FormPK201.Show()
            Case "PPSSPP"
                Dim FormPPSSPP As New FormPPSSPP()
                FormPPSSPP.Show()
            Case "Project64"
                Dim FormProject64 As New FormProject64()
                FormProject64.Show()
            Case "puNES"
                Dim FormpuNES As New FormpuNES()
                FormpuNES.Show()
            Case "RAINE"
                Dim FormRAINE As New FormRAINE()
                FormRAINE.Show()
            Case "redream"
                Dim Formredream As New Formredream()
                Formredream.Show()
            Case "Retroarch"
                Dim FormRetroarch As New FormRetroarch()
                FormRetroarch.Show()
            Case "RMG"
                Dim FormRMG As New FormRMG()
                FormRMG.Show()
            Case "Ryujinx"
                Dim FormRyujinx As New FormRyujinx()
                FormRyujinx.Show()
            Case "SameBoy"
                Dim FormSameBoy As New FormSameBoy()
                FormSameBoy.Show()
            Case "ScummVM"
                Dim FormScummVM As New FormScummVM()
                FormScummVM.Show()
            Case "SheepShaver"
                Dim FormSheepShaver As New FormSheepShaver()
                FormSheepShaver.Show()
            Case "simple64"
                Dim Formsimple64 As New Formsimple64()
                Formsimple64.Show()
            Case "SL9821"
                Dim FormSL9821 As New FormSL9821()
                FormSL9821.Show()
            Case "Snes9x"
                Dim FormSnes9x As New FormSnes9x()
                FormSnes9x.Show()
            Case "Stella"
                Dim FormStella As New FormStella()
                FormStella.Show()
            Case "Speccy"
                Dim FormSpeccy As New FormSpeccy()
                FormSpeccy.Show()
            Case "Steem SSE"
                Dim FormSteemSSE As New FormSteemSSE()
                FormSteemSSE.Show()
            Case "SpecEmu"
                Dim FormSpecEmu As New FormSpecEmu()
                FormSpecEmu.Show()
            Case "Supermodel"
                Dim FormSupermodel As New FormSupermodel()
                FormSupermodel.Show()
            Case "Sudachi"
                Dim FormSudachi As New FormSudachi()
                FormSudachi.Show()
            Case "Tsugaru"
                Dim FormTsugaru As New FormTsugaru()
                FormTsugaru.Show()
            Case "UNZ"
                Dim FormUNZ As New FormUNZ()
                FormUNZ.Show()
            Case "VBjin"
                Dim FormVBjin As New FormVBjin()
                FormVBjin.Show()
            Case "VBA-M"
                Dim FormVBAM As New FormVBAM()
                FormVBAM.Show()
            Case "VICE"
                Dim FormVICE As New FormVICE()
                FormVICE.Show()
            Case "Vita3K"
                Dim FormVita3K As New FormVita3K()
                FormVita3K.Show()
            Case "xemu"
                Dim Formxemu As New Formxemu()
                Formxemu.Show()
            Case "Xenia"
                Dim FormXenia As New FormXenia()
                FormXenia.Show()
            Case "Xe"
                Dim FormXe As New FormXe()
                FormXe.Show()
            Case "XM6"
                Dim FormXM6 As New FormXM6()
                FormXM6.Show()
            Case "XM8"
                Dim FormXM8 As New FormXM8()
                FormXM8.Show()
            Case "WinArcadia"
                Dim FormWinArcadia As New FormWinArcadia()
                FormWinArcadia.Show()
            Case "WinUAE"
                Dim FormWinUAE As New FormWinUAE()
                FormWinUAE.Show()
            Case "ZEsarUX"
                Dim FormZEsarUX As New FormZEsarUX()
                FormZEsarUX.Show()
            Case "Z64K"
                Dim FormZ64K As New FormZ64K()
                FormZ64K.Show()
        End Select
    End Sub
End Class
