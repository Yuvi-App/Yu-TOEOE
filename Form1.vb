Imports System.IO
Imports System.Net

Public Class Form1
    Public Class GlobalVariables
        Public Shared strWebsite As String = "http://talesofeterniaonline.com"
        Public Shared strInstalledLocation As String
        Public Shared strDownloaderiniLocation As String
        Public Shared strWebVersionIniLocation As String
    End Class

    'First time App Load set parameter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read Downloader.ini Config for varibles, If not found First load will trigger.
        Try
            Dim line As String() = IO.File.ReadAllLines("downloader.ini")
            GlobalVariables.strInstalledLocation = line(2)
            GlobalVariables.strDownloaderiniLocation = GlobalVariables.strInstalledLocation & "downloader.ini"
            lbxDownloadLog.Items.Add("DEBUG: TOE Location: " & GlobalVariables.strInstalledLocation)
            lbxDownloadLog.Items.Add("DEBUG: TOE ini Location: " & GlobalVariables.strDownloaderiniLocation)
        Catch ex As Exception
            MsgBox("First Run Detected")
        End Try


        ' First Load Deteced Create Config
        Try
            If Not System.IO.File.Exists(GlobalVariables.strInstalledLocation & "downloader.ini") Then
                MessageBox.Show("Please set the following information for downloader to work")
                Dim fldrInstallLocation As New FolderBrowserDialog
                MessageBox.Show("Select an Install Location for Tales of Eternia Online")
                fldrInstallLocation.ShowDialog()
                Using writer As StreamWriter =
                    New StreamWriter(fldrInstallLocation.SelectedPath & "\downloader.ini")
                    writer.WriteLine("-----Downloader Config-----")
                    writer.WriteLine("[InstallLocation]")
                    writer.WriteLine(fldrInstallLocation.SelectedPath & "\")
                    writer.WriteLine("[AutoDownload]")
                    writer.WriteLine("True")
                    writer.WriteLine("[Version]")
                    writer.WriteLine("0.1")
                End Using
                GlobalVariables.strInstalledLocation = fldrInstallLocation.SelectedPath & "\"
                GlobalVariables.strDownloaderiniLocation = GlobalVariables.strInstalledLocation & "downloader.ini"
                lbxDownloadLog.Items.Add("DEBUG: TOE Location: " & GlobalVariables.strInstalledLocation)
                lbxDownloadLog.Items.Add("DEBUG: TOE ini Location: " & GlobalVariables.strDownloaderiniLocation)
            End If
        Catch ex As Exception
            MsgBox("Please choose a Folder Location")
            Application.Restart()
        End Try

        Try
            'Read Local Version Number for patch validation
            Dim LocalVersionLine As String() = IO.File.ReadAllLines(GlobalVariables.strDownloaderiniLocation)
            Dim LocalVersion = LocalVersionLine(6)

            'Download & Read Online Version number for patch validation
            Try
                If IO.File.Exists(GlobalVariables.strInstalledLocation & "version.ini") Then IO.File.Delete(GlobalVariables.strInstalledLocation & "version.ini")
                My.Computer.Network.DownloadFile("http://talesofeterniaonline.com/downloader/version.ini", GlobalVariables.strInstalledLocation & "version.ini")
            Catch ex As Exception
                MsgBox("Failed to Download Version File from Server, Please check Internet Connectivity or try again later")
            End Try

            Dim OnlineVersionLocation = GlobalVariables.strInstalledLocation & "version.ini"
            Dim OnlineVersionLine As String() = IO.File.ReadAllLines(OnlineVersionLocation)
            Dim OnlineVersion = OnlineVersionLine(1)

            lbxDownloadLog.Items.Add("DEBUG: TOEO Downloader Local Version:  " & LocalVersion)
            lbxDownloadLog.Items.Add("DEBUG: TOEO Downloader Online Version:  " & OnlineVersion)

            'Compare two versions 
            If LocalVersion = OnlineVersion And System.IO.File.Exists(GlobalVariables.strInstalledLocation & "ToEOnline.exe") Then
                btnDownload.Text = "Start Game"
            Else
                MessageBox.Show("ERROR: Patch needed, Please start download to play")
            End If

        Catch ex As Exception
            MsgBox("version.ini Not Found, Please delete downloader.ini from TOEO Installation folder ( " & GlobalVariables.strDownloaderiniLocation & " )")
            Application.Exit()
        End Try


        ' Reloads Downloader Website Cache


    End Sub

    'BUTTON SECTION'
    Private Sub BtnWebsite_Click(sender As Object, e As EventArgs) Handles btnWebsite.Click
        Dim Website As String = "www.talesofeterniaonline.com"
        System.Diagnostics.Process.Start(Website)
    End Sub
    Private Sub BtnMembersPage_Click(sender As Object, e As EventArgs) Handles btnMembersPage.Click
        Dim Website As String = "www.talesofeterniaonline.com/members/5-0.html"
        System.Diagnostics.Process.Start(Website)
    End Sub
    Private Sub BtnSysInfo_Click(sender As Object, e As EventArgs) Handles btnSysInfo.Click
        Try
            System.Diagnostics.Process.Start(GlobalVariables.strInstalledLocation & "Checker.exe")
        Catch ex As FileNotFoundException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        Try
            System.Diagnostics.Process.Start(GlobalVariables.strInstalledLocation & "ToEO_Option.exe")
        Catch ex As FileNotFoundException
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Website As String = "https://yuvi.app"
        System.Diagnostics.Process.Start(Website)
    End Sub
    Private Sub BtnStopDownload_Click(sender As Object, e As EventArgs) Handles btnStopDownload.Click
        Downloader.CancelAsync()
        btnStopDownload.Enabled = False
        btnDownload.Enabled = True
    End Sub

    'FILE DOWNLOAD and GAME START SECTION'
    Public WithEvents Downloader As WebClient
    Private Sub BtnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim InstallDownloadLocation As String = "http://talesofeterniaonline.com/downloader/Install Files/"
        Dim InstallDownloadFilesNames As String = "toeo_installer.exe"
        Dim PatchDownloadLocation As String = "http://talesofeterniaonline.com/downloader/Patch Files/"
        Dim PatchDownloadFilesNames As String = "test.txt"

        'Full Download Paths
        Dim InstallFullDownloadLocation As String = InstallDownloadLocation & InstallDownloadFilesNames
        Dim PatchFullDownloadLocation As String = PatchDownloadLocation & PatchDownloadFilesNames

        Try
            If btnDownload.Text = "Start Game" Then
                lbxDownloadLog.Items.Add("DEBUG: Starting Game at " & GlobalVariables.strInstalledLocation & "ToEO_CL.dat")
                Process.Start("CMD.exe", "/C ToEO_CL.dat")
            ElseIf btnDownload.Text = "Download" Then
                If System.IO.File.Exists(GlobalVariables.strInstalledLocation & "ToEOnline.exe") Then
                    lbxDownloadLog.Items.Add("Starting Patch Download")
                    Downloader = New WebClient
                    AddHandler Downloader.DownloadProgressChanged, AddressOf ShowDownloadProgress
                    AddHandler Downloader.DownloadFileCompleted, AddressOf OnDownloadComplete
                    Downloader.DownloadFileAsync(New Uri(PatchFullDownloadLocation), GlobalVariables.strInstalledLocation & PatchDownloadFilesNames)
                    lblTopBar.Text = "Downloading"
                    btnStopDownload.Enabled = True
                    btnDownload.Enabled = False
                Else
                    lbxDownloadLog.Items.Add("Starting Installation File Download")
                    Downloader = New WebClient
                    AddHandler Downloader.DownloadProgressChanged, AddressOf ShowDownloadProgress
                    AddHandler Downloader.DownloadFileCompleted, AddressOf OnDownloadComplete
                    Downloader.DownloadFileAsync(New Uri(InstallFullDownloadLocation), GlobalVariables.strInstalledLocation & InstallDownloadFilesNames)
                    lblTopBar.Text = "Downloading"
                    btnStopDownload.Enabled = True
                    btnDownload.Enabled = False
                End If
            End If
        Catch
            MessageBox.Show("Error Starting Download")
            lblTopBar.Text = "Waiting"
            btnStopDownload.Enabled = False
            btnDownload.Enabled = True
        End Try
    End Sub

    ' Webclient Configuration
    Private Sub ShowDownloadProgress(ByVal sender As System.Object, ByVal e As DownloadProgressChangedEventArgs) Handles Downloader.DownloadProgressChanged
        Dim MBReceived = Math.Round((e.BytesReceived / 1000000), 1)
        Dim MBTotal = Math.Round((e.TotalBytesToReceive / 1000000), 1)
        lblPrecentageCompleted.Text = e.ProgressPercentage & "%"
        lblSize1.Text = "Size: " & MBReceived & " MB / " & MBTotal & " MB"
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub OnDownloadComplete(ByVal sender As System.Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles Downloader.DownloadFileCompleted
        If Not e.Cancelled AndAlso e.Error Is Nothing Then
            lblTopBar.Text = "Waiting"
            lbxDownloadLog.Items.Add("Download Completed")
            btnStopDownload.Enabled = False
            btnDownload.Enabled = True
            btnDownload.Text = "Start Game"
        Else
            lblTopBar.Text = "Waiting"
            lbxDownloadLog.Items.Add("Error Downloading Files")
            btnStopDownload.Enabled = False
            btnDownload.Enabled = True
            lblPrecentageCompleted.Text = "0%"
            lblSize1.Text = "Size: 0 MB / 0 MB"
            ProgressBar1.Value = 0
        End If
    End Sub

End Class
