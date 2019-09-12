<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTopBar = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkbxAutoDownload = New System.Windows.Forms.CheckBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnSysInfo = New System.Windows.Forms.Button()
        Me.btnMembersPage = New System.Windows.Forms.Button()
        Me.btnWebsite = New System.Windows.Forms.Button()
        Me.btnStopDownload = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbxDownloadLog = New System.Windows.Forms.ListBox()
        Me.lblSize1 = New System.Windows.Forms.Label()
        Me.lblPrecentageCompleted = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTopBar
        '
        Me.lblTopBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTopBar.Location = New System.Drawing.Point(14, 14)
        Me.lblTopBar.Name = "lblTopBar"
        Me.lblTopBar.Size = New System.Drawing.Size(568, 23)
        Me.lblTopBar.TabIndex = 0
        Me.lblTopBar.Text = "Waiting"
        Me.lblTopBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(14, 41)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(568, 163)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("http://talesofeterniaonline.com/downloader", System.UriKind.Absolute)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Overall Progress"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(101, 210)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(269, 13)
        Me.ProgressBar1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkbxAutoDownload)
        Me.Panel1.Controls.Add(Me.btnCheck)
        Me.Panel1.Controls.Add(Me.btnOptions)
        Me.Panel1.Controls.Add(Me.btnSysInfo)
        Me.Panel1.Controls.Add(Me.btnMembersPage)
        Me.Panel1.Controls.Add(Me.btnWebsite)
        Me.Panel1.Controls.Add(Me.btnStopDownload)
        Me.Panel1.Controls.Add(Me.btnDownload)
        Me.Panel1.Location = New System.Drawing.Point(260, 320)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 112)
        Me.Panel1.TabIndex = 5
        '
        'chkbxAutoDownload
        '
        Me.chkbxAutoDownload.AutoSize = True
        Me.chkbxAutoDownload.Location = New System.Drawing.Point(3, 85)
        Me.chkbxAutoDownload.Name = "chkbxAutoDownload"
        Me.chkbxAutoDownload.Size = New System.Drawing.Size(123, 17)
        Me.chkbxAutoDownload.TabIndex = 1
        Me.chkbxAutoDownload.Text = "Auto Download Files"
        Me.chkbxAutoDownload.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(3, 58)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(106, 21)
        Me.btnCheck.TabIndex = 0
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Location = New System.Drawing.Point(168, 85)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(147, 21)
        Me.btnOptions.TabIndex = 0
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnSysInfo
        '
        Me.btnSysInfo.Location = New System.Drawing.Point(168, 58)
        Me.btnSysInfo.Name = "btnSysInfo"
        Me.btnSysInfo.Size = New System.Drawing.Size(147, 21)
        Me.btnSysInfo.TabIndex = 0
        Me.btnSysInfo.Text = "System Info"
        Me.btnSysInfo.UseVisualStyleBackColor = True
        '
        'btnMembersPage
        '
        Me.btnMembersPage.Location = New System.Drawing.Point(168, 31)
        Me.btnMembersPage.Name = "btnMembersPage"
        Me.btnMembersPage.Size = New System.Drawing.Size(147, 21)
        Me.btnMembersPage.TabIndex = 0
        Me.btnMembersPage.Text = "Members Page"
        Me.btnMembersPage.UseVisualStyleBackColor = True
        '
        'btnWebsite
        '
        Me.btnWebsite.Location = New System.Drawing.Point(168, 4)
        Me.btnWebsite.Name = "btnWebsite"
        Me.btnWebsite.Size = New System.Drawing.Size(147, 21)
        Me.btnWebsite.TabIndex = 0
        Me.btnWebsite.Text = "Website"
        Me.btnWebsite.UseVisualStyleBackColor = True
        '
        'btnStopDownload
        '
        Me.btnStopDownload.Enabled = False
        Me.btnStopDownload.Location = New System.Drawing.Point(3, 31)
        Me.btnStopDownload.Name = "btnStopDownload"
        Me.btnStopDownload.Size = New System.Drawing.Size(106, 21)
        Me.btnStopDownload.TabIndex = 0
        Me.btnStopDownload.Text = "Stop"
        Me.btnStopDownload.UseVisualStyleBackColor = True
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(3, 4)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(106, 21)
        Me.btnDownload.TabIndex = 0
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(156, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Downloader by Yuvi"
        '
        'lbxDownloadLog
        '
        Me.lbxDownloadLog.FormattingEnabled = True
        Me.lbxDownloadLog.Location = New System.Drawing.Point(14, 229)
        Me.lbxDownloadLog.Name = "lbxDownloadLog"
        Me.lbxDownloadLog.Size = New System.Drawing.Size(568, 82)
        Me.lbxDownloadLog.TabIndex = 7
        '
        'lblSize1
        '
        Me.lblSize1.AutoSize = True
        Me.lblSize1.Location = New System.Drawing.Point(415, 210)
        Me.lblSize1.Name = "lblSize1"
        Me.lblSize1.Size = New System.Drawing.Size(94, 13)
        Me.lblSize1.TabIndex = 8
        Me.lblSize1.Text = "Size: 0 MB / 0 MB"
        '
        'lblPrecentageCompleted
        '
        Me.lblPrecentageCompleted.AutoSize = True
        Me.lblPrecentageCompleted.Location = New System.Drawing.Point(376, 210)
        Me.lblPrecentageCompleted.Name = "lblPrecentageCompleted"
        Me.lblPrecentageCompleted.Size = New System.Drawing.Size(21, 13)
        Me.lblPrecentageCompleted.TabIndex = 8
        Me.lblPrecentageCompleted.Text = "0%"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TalesofEterniaOnline___Downloader.My.Resources.Resources.banner_toeo_240
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 320)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TalesofEterniaOnline___Downloader.My.Resources.Resources.bg_use
        Me.PictureBox2.Location = New System.Drawing.Point(588, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(140, 418)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 435)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPrecentageCompleted)
        Me.Controls.Add(Me.lblSize1)
        Me.Controls.Add(Me.lbxDownloadLog)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.lblTopBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Tales of Eternia Online - Downloader"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTopBar As Label
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkbxAutoDownload As CheckBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents btnMembersPage As Button
    Friend WithEvents btnWebsite As Button
    Friend WithEvents btnDownload As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnSysInfo As Button
    Friend WithEvents lbxDownloadLog As ListBox
    Friend WithEvents lblSize1 As Label
    Friend WithEvents lblPrecentageCompleted As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents btnStopDownload As Button
End Class
