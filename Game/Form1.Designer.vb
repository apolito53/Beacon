<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Beacon
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Beacon))
        Me.tmrEnemy1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemy2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemy3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemy4 = New System.Windows.Forms.Timer(Me.components)
        Me.picEnemy1 = New System.Windows.Forms.PictureBox()
        Me.picEnemy4 = New System.Windows.Forms.PictureBox()
        Me.picEnemy2 = New System.Windows.Forms.PictureBox()
        Me.picEnemy3 = New System.Windows.Forms.PictureBox()
        Me.picPlayerShip = New System.Windows.Forms.PictureBox()
        Me.lblCampaign = New System.Windows.Forms.Label()
        Me.picMissle1 = New System.Windows.Forms.PictureBox()
        Me.tmrShot1 = New System.Windows.Forms.Timer(Me.components)
        Me.OptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartGameToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitGameToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPreScore = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblRoundComplete = New System.Windows.Forms.Label()
        Me.lblReady = New System.Windows.Forms.Label()
        Me.picMissle2 = New System.Windows.Forms.PictureBox()
        Me.tmrShot2 = New System.Windows.Forms.Timer(Me.components)
        Me.picEnemyMissle1 = New System.Windows.Forms.PictureBox()
        Me.picEnemyMissle4 = New System.Windows.Forms.PictureBox()
        Me.picEnemyMissle2 = New System.Windows.Forms.PictureBox()
        Me.picEnemyMissle3 = New System.Windows.Forms.PictureBox()
        Me.lblBeacon = New System.Windows.Forms.Label()
        Me.tmrEnemyShot1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemyShot2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemyShot3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemyShot4 = New System.Windows.Forms.Timer(Me.components)
        Me.lblPreLevel = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblEasy = New System.Windows.Forms.Label()
        Me.lblNormal = New System.Windows.Forms.Label()
        Me.lblHardcore = New System.Windows.Forms.Label()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.picBoss1 = New System.Windows.Forms.PictureBox()
        Me.tmrBoss1 = New System.Windows.Forms.Timer(Me.components)
        Me.picBossShot3 = New System.Windows.Forms.PictureBox()
        Me.picBossShot4 = New System.Windows.Forms.PictureBox()
        Me.picBossShot2 = New System.Windows.Forms.PictureBox()
        Me.picBossShot1 = New System.Windows.Forms.PictureBox()
        Me.tmrBossShot1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossShot2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossShot3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossShot4 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossFireSequence = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossLaser = New System.Windows.Forms.Timer(Me.components)
        Me.picBossLaser = New System.Windows.Forms.PictureBox()
        Me.tmrLaserPosition = New System.Windows.Forms.Timer(Me.components)
        Me.picFlash = New System.Windows.Forms.PictureBox()
        Me.tmrFlash = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLaserFlash = New System.Windows.Forms.Timer(Me.components)
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.picExplosion1 = New System.Windows.Forms.PictureBox()
        Me.tmrExplosion1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPlayerHealthTracker = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPlayerHit = New System.Windows.Forms.Timer(Me.components)
        Me.lblPreHealth = New System.Windows.Forms.Label()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.picLife1 = New System.Windows.Forms.PictureBox()
        Me.picLife2 = New System.Windows.Forms.PictureBox()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.tmrBossHit = New System.Windows.Forms.Timer(Me.components)
        Me.lstHS = New System.Windows.Forms.ListBox()
        Me.lblHighScores = New System.Windows.Forms.Label()
        Me.lblContinue = New System.Windows.Forms.Label()
        Me.tmrHighScoreScroll = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemy1Respawn = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemy2Respawn = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemy3Respawn = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemy4Respawn = New System.Windows.Forms.Timer(Me.components)
        Me.tmrExplosion2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrExplosion3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrExplosion4 = New System.Windows.Forms.Timer(Me.components)
        Me.picExplosion4 = New System.Windows.Forms.PictureBox()
        Me.picExplosion3 = New System.Windows.Forms.PictureBox()
        Me.picExplosion2 = New System.Windows.Forms.PictureBox()
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picEnemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayerShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMissle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMissle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemyMissle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemyMissle4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemyMissle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnemyMissle3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoss1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBossShot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBossShot4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBossShot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBossShot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBossLaser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFlash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplosion1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLife1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLife2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplosion4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplosion3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplosion2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrEnemy1
        '
        Me.tmrEnemy1.Interval = 17
        '
        'tmrEnemy2
        '
        Me.tmrEnemy2.Interval = 17
        '
        'tmrEnemy3
        '
        Me.tmrEnemy3.Interval = 17
        '
        'tmrEnemy4
        '
        Me.tmrEnemy4.Interval = 17
        '
        'picEnemy1
        '
        Me.picEnemy1.Location = New System.Drawing.Point(173, 128)
        Me.picEnemy1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picEnemy1.Name = "picEnemy1"
        Me.picEnemy1.Size = New System.Drawing.Size(31, 30)
        Me.picEnemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemy1.TabIndex = 4
        Me.picEnemy1.TabStop = False
        '
        'picEnemy4
        '
        Me.picEnemy4.Location = New System.Drawing.Point(637, 369)
        Me.picEnemy4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picEnemy4.Name = "picEnemy4"
        Me.picEnemy4.Size = New System.Drawing.Size(31, 30)
        Me.picEnemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemy4.TabIndex = 3
        Me.picEnemy4.TabStop = False
        '
        'picEnemy2
        '
        Me.picEnemy2.Location = New System.Drawing.Point(345, 212)
        Me.picEnemy2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picEnemy2.Name = "picEnemy2"
        Me.picEnemy2.Size = New System.Drawing.Size(31, 30)
        Me.picEnemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemy2.TabIndex = 2
        Me.picEnemy2.TabStop = False
        '
        'picEnemy3
        '
        Me.picEnemy3.Location = New System.Drawing.Point(413, 271)
        Me.picEnemy3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picEnemy3.Name = "picEnemy3"
        Me.picEnemy3.Size = New System.Drawing.Size(31, 30)
        Me.picEnemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemy3.TabIndex = 1
        Me.picEnemy3.TabStop = False
        '
        'picPlayerShip
        '
        Me.picPlayerShip.Image = Global.Game.My.Resources.Resources.SpaceShip
        Me.picPlayerShip.Location = New System.Drawing.Point(413, 46)
        Me.picPlayerShip.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picPlayerShip.Name = "picPlayerShip"
        Me.picPlayerShip.Size = New System.Drawing.Size(45, 53)
        Me.picPlayerShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayerShip.TabIndex = 0
        Me.picPlayerShip.TabStop = False
        '
        'lblCampaign
        '
        Me.lblCampaign.AutoSize = True
        Me.lblCampaign.BackColor = System.Drawing.Color.Black
        Me.lblCampaign.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.lblCampaign.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCampaign.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCampaign.Location = New System.Drawing.Point(139, 603)
        Me.lblCampaign.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCampaign.Name = "lblCampaign"
        Me.lblCampaign.Size = New System.Drawing.Size(188, 37)
        Me.lblCampaign.TabIndex = 6
        Me.lblCampaign.Text = "CAMPAIGN"
        Me.lblCampaign.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'picMissle1
        '
        Me.picMissle1.BackColor = System.Drawing.Color.White
        Me.picMissle1.Image = Global.Game.My.Resources.Resources.PlayerShot
        Me.picMissle1.Location = New System.Drawing.Point(59, 654)
        Me.picMissle1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMissle1.Name = "picMissle1"
        Me.picMissle1.Size = New System.Drawing.Size(5, 16)
        Me.picMissle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMissle1.TabIndex = 8
        Me.picMissle1.TabStop = False
        '
        'tmrShot1
        '
        Me.tmrShot1.Interval = 1
        '
        'OptionsToolStripMenuItem1
        '
        Me.OptionsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartGameToolStripMenuItem1, Me.ExitGameToolStripMenuItem1})
        Me.OptionsToolStripMenuItem1.Name = "OptionsToolStripMenuItem1"
        Me.OptionsToolStripMenuItem1.Size = New System.Drawing.Size(56, 20)
        Me.OptionsToolStripMenuItem1.Text = "Options"
        '
        'RestartGameToolStripMenuItem1
        '
        Me.RestartGameToolStripMenuItem1.Name = "RestartGameToolStripMenuItem1"
        Me.RestartGameToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.RestartGameToolStripMenuItem1.Text = "Restart Game"
        '
        'ExitGameToolStripMenuItem1
        '
        Me.ExitGameToolStripMenuItem1.Name = "ExitGameToolStripMenuItem1"
        Me.ExitGameToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.ExitGameToolStripMenuItem1.Text = "Exit Game"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartGameToolStripMenuItem, Me.ExitGameToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'RestartGameToolStripMenuItem
        '
        Me.RestartGameToolStripMenuItem.Name = "RestartGameToolStripMenuItem"
        Me.RestartGameToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RestartGameToolStripMenuItem.Text = "Restart Game"
        '
        'ExitGameToolStripMenuItem
        '
        Me.ExitGameToolStripMenuItem.Name = "ExitGameToolStripMenuItem"
        Me.ExitGameToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.ExitGameToolStripMenuItem.Text = "Exit Game"
        '
        'lblPreScore
        '
        Me.lblPreScore.AutoSize = True
        Me.lblPreScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPreScore.Location = New System.Drawing.Point(737, 11)
        Me.lblPreScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPreScore.Name = "lblPreScore"
        Me.lblPreScore.Size = New System.Drawing.Size(47, 16)
        Me.lblPreScore.TabIndex = 12
        Me.lblPreScore.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblScore.Location = New System.Drawing.Point(796, 11)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 16)
        Me.lblScore.TabIndex = 13
        '
        'lblRoundComplete
        '
        Me.lblRoundComplete.AutoSize = True
        Me.lblRoundComplete.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.lblRoundComplete.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoundComplete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblRoundComplete.Location = New System.Drawing.Point(332, 330)
        Me.lblRoundComplete.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRoundComplete.Name = "lblRoundComplete"
        Me.lblRoundComplete.Size = New System.Drawing.Size(157, 26)
        Me.lblRoundComplete.TabIndex = 14
        Me.lblRoundComplete.Text = "Round complete!"
        '
        'lblReady
        '
        Me.lblReady.AutoSize = True
        Me.lblReady.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.lblReady.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReady.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblReady.Location = New System.Drawing.Point(392, 374)
        Me.lblReady.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReady.Name = "lblReady"
        Me.lblReady.Size = New System.Drawing.Size(55, 20)
        Me.lblReady.TabIndex = 15
        Me.lblReady.Text = "Ready"
        '
        'picMissle2
        '
        Me.picMissle2.BackColor = System.Drawing.Color.White
        Me.picMissle2.Image = Global.Game.My.Resources.Resources.PlayerShot
        Me.picMissle2.Location = New System.Drawing.Point(72, 654)
        Me.picMissle2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picMissle2.Name = "picMissle2"
        Me.picMissle2.Size = New System.Drawing.Size(5, 16)
        Me.picMissle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMissle2.TabIndex = 16
        Me.picMissle2.TabStop = False
        '
        'tmrShot2
        '
        Me.tmrShot2.Interval = 1
        '
        'picEnemyMissle1
        '
        Me.picEnemyMissle1.BackColor = System.Drawing.Color.White
        Me.picEnemyMissle1.Image = Global.Game.My.Resources.Resources.MuzzleFlash
        Me.picEnemyMissle1.Location = New System.Drawing.Point(96, 640)
        Me.picEnemyMissle1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picEnemyMissle1.Name = "picEnemyMissle1"
        Me.picEnemyMissle1.Size = New System.Drawing.Size(13, 18)
        Me.picEnemyMissle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemyMissle1.TabIndex = 17
        Me.picEnemyMissle1.TabStop = False
        '
        'picEnemyMissle4
        '
        Me.picEnemyMissle4.BackColor = System.Drawing.Color.White
        Me.picEnemyMissle4.Image = Global.Game.My.Resources.Resources.MuzzleFlash
        Me.picEnemyMissle4.Location = New System.Drawing.Point(188, 640)
        Me.picEnemyMissle4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picEnemyMissle4.Name = "picEnemyMissle4"
        Me.picEnemyMissle4.Size = New System.Drawing.Size(13, 18)
        Me.picEnemyMissle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemyMissle4.TabIndex = 18
        Me.picEnemyMissle4.TabStop = False
        '
        'picEnemyMissle2
        '
        Me.picEnemyMissle2.BackColor = System.Drawing.Color.White
        Me.picEnemyMissle2.Image = Global.Game.My.Resources.Resources.MuzzleFlash
        Me.picEnemyMissle2.Location = New System.Drawing.Point(127, 640)
        Me.picEnemyMissle2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picEnemyMissle2.Name = "picEnemyMissle2"
        Me.picEnemyMissle2.Size = New System.Drawing.Size(13, 18)
        Me.picEnemyMissle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemyMissle2.TabIndex = 19
        Me.picEnemyMissle2.TabStop = False
        '
        'picEnemyMissle3
        '
        Me.picEnemyMissle3.BackColor = System.Drawing.Color.White
        Me.picEnemyMissle3.Image = Global.Game.My.Resources.Resources.MuzzleFlash
        Me.picEnemyMissle3.Location = New System.Drawing.Point(157, 640)
        Me.picEnemyMissle3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picEnemyMissle3.Name = "picEnemyMissle3"
        Me.picEnemyMissle3.Size = New System.Drawing.Size(13, 18)
        Me.picEnemyMissle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnemyMissle3.TabIndex = 20
        Me.picEnemyMissle3.TabStop = False
        '
        'lblBeacon
        '
        Me.lblBeacon.AutoSize = True
        Me.lblBeacon.BackColor = System.Drawing.Color.Transparent
        Me.lblBeacon.Font = New System.Drawing.Font("Impact", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeacon.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblBeacon.Location = New System.Drawing.Point(317, 321)
        Me.lblBeacon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBeacon.Name = "lblBeacon"
        Me.lblBeacon.Size = New System.Drawing.Size(168, 43)
        Me.lblBeacon.TabIndex = 21
        Me.lblBeacon.Text = "B e a c o n"
        '
        'tmrEnemyShot1
        '
        Me.tmrEnemyShot1.Interval = 1
        '
        'tmrEnemyShot2
        '
        Me.tmrEnemyShot2.Interval = 1
        '
        'tmrEnemyShot3
        '
        Me.tmrEnemyShot3.Interval = 1
        '
        'tmrEnemyShot4
        '
        Me.tmrEnemyShot4.Interval = 1
        '
        'lblPreLevel
        '
        Me.lblPreLevel.AutoSize = True
        Me.lblPreLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPreLevel.Location = New System.Drawing.Point(633, 11)
        Me.lblPreLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPreLevel.Name = "lblPreLevel"
        Me.lblPreLevel.Size = New System.Drawing.Size(41, 16)
        Me.lblPreLevel.TabIndex = 22
        Me.lblPreLevel.Text = "Level"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLevel.Location = New System.Drawing.Point(685, 11)
        Me.lblLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(0, 16)
        Me.lblLevel.TabIndex = 23
        '
        'lblEasy
        '
        Me.lblEasy.AutoSize = True
        Me.lblEasy.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.lblEasy.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEasy.Location = New System.Drawing.Point(395, 406)
        Me.lblEasy.Name = "lblEasy"
        Me.lblEasy.Size = New System.Drawing.Size(39, 16)
        Me.lblEasy.TabIndex = 24
        Me.lblEasy.Text = "Easy"
        '
        'lblNormal
        '
        Me.lblNormal.AutoSize = True
        Me.lblNormal.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.lblNormal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNormal.Location = New System.Drawing.Point(393, 441)
        Me.lblNormal.Name = "lblNormal"
        Me.lblNormal.Size = New System.Drawing.Size(52, 16)
        Me.lblNormal.TabIndex = 25
        Me.lblNormal.Text = "Normal"
        '
        'lblHardcore
        '
        Me.lblHardcore.AutoSize = True
        Me.lblHardcore.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.lblHardcore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHardcore.Location = New System.Drawing.Point(393, 478)
        Me.lblHardcore.Name = "lblHardcore"
        Me.lblHardcore.Size = New System.Drawing.Size(68, 16)
        Me.lblHardcore.TabIndex = 26
        Me.lblHardcore.Text = "Hardcore!"
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblBack.Location = New System.Drawing.Point(391, 535)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(51, 24)
        Me.lblBack.TabIndex = 27
        Me.lblBack.Text = "Back"
        '
        'picBoss1
        '
        Me.picBoss1.BackColor = System.Drawing.Color.Transparent
        Me.picBoss1.Location = New System.Drawing.Point(601, 458)
        Me.picBoss1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBoss1.Name = "picBoss1"
        Me.picBoss1.Size = New System.Drawing.Size(220, 124)
        Me.picBoss1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBoss1.TabIndex = 28
        Me.picBoss1.TabStop = False
        '
        'tmrBoss1
        '
        Me.tmrBoss1.Interval = 25
        '
        'picBossShot3
        '
        Me.picBossShot3.BackColor = System.Drawing.Color.White
        Me.picBossShot3.Image = Global.Game.My.Resources.Resources.Fireball
        Me.picBossShot3.Location = New System.Drawing.Point(160, 562)
        Me.picBossShot3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBossShot3.Name = "picBossShot3"
        Me.picBossShot3.Size = New System.Drawing.Size(20, 37)
        Me.picBossShot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBossShot3.TabIndex = 29
        Me.picBossShot3.TabStop = False
        '
        'picBossShot4
        '
        Me.picBossShot4.BackColor = System.Drawing.Color.White
        Me.picBossShot4.Image = Global.Game.My.Resources.Resources.Fireball
        Me.picBossShot4.Location = New System.Drawing.Point(195, 562)
        Me.picBossShot4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBossShot4.Name = "picBossShot4"
        Me.picBossShot4.Size = New System.Drawing.Size(20, 37)
        Me.picBossShot4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBossShot4.TabIndex = 30
        Me.picBossShot4.TabStop = False
        '
        'picBossShot2
        '
        Me.picBossShot2.BackColor = System.Drawing.Color.White
        Me.picBossShot2.Image = Global.Game.My.Resources.Resources.Fireball
        Me.picBossShot2.Location = New System.Drawing.Point(120, 562)
        Me.picBossShot2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBossShot2.Name = "picBossShot2"
        Me.picBossShot2.Size = New System.Drawing.Size(20, 37)
        Me.picBossShot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBossShot2.TabIndex = 31
        Me.picBossShot2.TabStop = False
        '
        'picBossShot1
        '
        Me.picBossShot1.BackColor = System.Drawing.Color.White
        Me.picBossShot1.Image = Global.Game.My.Resources.Resources.Fireball
        Me.picBossShot1.Location = New System.Drawing.Point(85, 562)
        Me.picBossShot1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBossShot1.Name = "picBossShot1"
        Me.picBossShot1.Size = New System.Drawing.Size(20, 37)
        Me.picBossShot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBossShot1.TabIndex = 32
        Me.picBossShot1.TabStop = False
        '
        'tmrBossShot1
        '
        Me.tmrBossShot1.Interval = 50
        '
        'tmrBossShot2
        '
        Me.tmrBossShot2.Interval = 50
        '
        'tmrBossShot3
        '
        Me.tmrBossShot3.Interval = 50
        '
        'tmrBossShot4
        '
        Me.tmrBossShot4.Interval = 50
        '
        'tmrBossFireSequence
        '
        Me.tmrBossFireSequence.Interval = 700
        '
        'tmrBossLaser
        '
        Me.tmrBossLaser.Interval = 750
        '
        'picBossLaser
        '
        Me.picBossLaser.Image = Global.Game.My.Resources.Resources.Laser
        Me.picBossLaser.Location = New System.Drawing.Point(16, 149)
        Me.picBossLaser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBossLaser.Name = "picBossLaser"
        Me.picBossLaser.Size = New System.Drawing.Size(35, 521)
        Me.picBossLaser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBossLaser.TabIndex = 33
        Me.picBossLaser.TabStop = False
        '
        'tmrLaserPosition
        '
        Me.tmrLaserPosition.Interval = 1
        '
        'picFlash
        '
        Me.picFlash.Image = Global.Game.My.Resources.Resources.MuzzleFlash
        Me.picFlash.Location = New System.Drawing.Point(236, 562)
        Me.picFlash.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picFlash.Name = "picFlash"
        Me.picFlash.Size = New System.Drawing.Size(19, 20)
        Me.picFlash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlash.TabIndex = 35
        Me.picFlash.TabStop = False
        '
        'tmrFlash
        '
        Me.tmrFlash.Enabled = True
        Me.tmrFlash.Interval = 1
        '
        'tmrLaserFlash
        '
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.White
        Me.lblInstructions.Location = New System.Drawing.Point(455, 603)
        Me.lblInstructions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(256, 37)
        Me.lblInstructions.TabIndex = 36
        Me.lblInstructions.Text = "INSTRUCTIONS"
        '
        'picExplosion1
        '
        Me.picExplosion1.Location = New System.Drawing.Point(167, 334)
        Me.picExplosion1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picExplosion1.Name = "picExplosion1"
        Me.picExplosion1.Size = New System.Drawing.Size(73, 68)
        Me.picExplosion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExplosion1.TabIndex = 37
        Me.picExplosion1.TabStop = False
        '
        'tmrExplosion1
        '
        Me.tmrExplosion1.Enabled = True
        Me.tmrExplosion1.Interval = 25
        '
        'tmrPlayerHealthTracker
        '
        Me.tmrPlayerHealthTracker.Enabled = True
        Me.tmrPlayerHealthTracker.Interval = 1
        '
        'tmrPlayerHit
        '
        Me.tmrPlayerHit.Enabled = True
        '
        'lblPreHealth
        '
        Me.lblPreHealth.AutoSize = True
        Me.lblPreHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreHealth.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPreHealth.Location = New System.Drawing.Point(707, 649)
        Me.lblPreHealth.Name = "lblPreHealth"
        Me.lblPreHealth.Size = New System.Drawing.Size(67, 20)
        Me.lblPreHealth.TabIndex = 38
        Me.lblPreHealth.Text = "Health:"
        '
        'lblHealth
        '
        Me.lblHealth.AutoSize = True
        Me.lblHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealth.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHealth.Location = New System.Drawing.Point(792, 649)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(63, 20)
        Me.lblHealth.TabIndex = 39
        Me.lblHealth.Text = "Label2"
        '
        'picLife1
        '
        Me.picLife1.Image = CType(resources.GetObject("picLife1.Image"), System.Drawing.Image)
        Me.picLife1.Location = New System.Drawing.Point(648, 649)
        Me.picLife1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picLife1.Name = "picLife1"
        Me.picLife1.Size = New System.Drawing.Size(27, 30)
        Me.picLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLife1.TabIndex = 41
        Me.picLife1.TabStop = False
        '
        'picLife2
        '
        Me.picLife2.Image = CType(resources.GetObject("picLife2.Image"), System.Drawing.Image)
        Me.picLife2.Location = New System.Drawing.Point(683, 649)
        Me.picLife2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picLife2.Name = "picLife2"
        Me.picLife2.Size = New System.Drawing.Size(27, 30)
        Me.picLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLife2.TabIndex = 42
        Me.picLife2.TabStop = False
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGameOver.Location = New System.Drawing.Point(303, 324)
        Me.lblGameOver.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(199, 33)
        Me.lblGameOver.TabIndex = 43
        Me.lblGameOver.Text = "GAME OVER"
        '
        'tmrBossHit
        '
        Me.tmrBossHit.Interval = 25
        '
        'lstHS
        '
        Me.lstHS.BackColor = System.Drawing.SystemColors.ControlText
        Me.lstHS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstHS.Enabled = False
        Me.lstHS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstHS.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lstHS.FormattingEnabled = True
        Me.lstHS.ItemHeight = 20
        Me.lstHS.Location = New System.Drawing.Point(236, 247)
        Me.lstHS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstHS.Name = "lstHS"
        Me.lstHS.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstHS.Size = New System.Drawing.Size(540, 180)
        Me.lstHS.TabIndex = 44
        Me.lstHS.TabStop = False
        '
        'lblHighScores
        '
        Me.lblHighScores.AutoSize = True
        Me.lblHighScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHighScores.Location = New System.Drawing.Point(340, 214)
        Me.lblHighScores.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHighScores.Name = "lblHighScores"
        Me.lblHighScores.Size = New System.Drawing.Size(124, 24)
        Me.lblHighScores.TabIndex = 45
        Me.lblHighScores.Text = "High Scores :"
        '
        'lblContinue
        '
        Me.lblContinue.AutoSize = True
        Me.lblContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContinue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblContinue.Location = New System.Drawing.Point(368, 494)
        Me.lblContinue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContinue.Name = "lblContinue"
        Me.lblContinue.Size = New System.Drawing.Size(86, 24)
        Me.lblContinue.TabIndex = 46
        Me.lblContinue.Text = "Continue"
        '
        'tmrHighScoreScroll
        '
        Me.tmrHighScoreScroll.Enabled = True
        Me.tmrHighScoreScroll.Interval = 1000
        '
        'tmrEnemy1Respawn
        '
        Me.tmrEnemy1Respawn.Interval = 1000
        '
        'tmrEnemy2Respawn
        '
        Me.tmrEnemy2Respawn.Interval = 1000
        '
        'tmrEnemy3Respawn
        '
        Me.tmrEnemy3Respawn.Interval = 1000
        '
        'tmrEnemy4Respawn
        '
        Me.tmrEnemy4Respawn.Interval = 1000
        '
        'tmrExplosion2
        '
        Me.tmrExplosion2.Interval = 25
        '
        'tmrExplosion3
        '
        Me.tmrExplosion3.Interval = 25
        '
        'tmrExplosion4
        '
        Me.tmrExplosion4.Interval = 25
        '
        'picExplosion4
        '
        Me.picExplosion4.Location = New System.Drawing.Point(120, 410)
        Me.picExplosion4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picExplosion4.Name = "picExplosion4"
        Me.picExplosion4.Size = New System.Drawing.Size(73, 68)
        Me.picExplosion4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExplosion4.TabIndex = 47
        Me.picExplosion4.TabStop = False
        '
        'picExplosion3
        '
        Me.picExplosion3.Location = New System.Drawing.Point(67, 330)
        Me.picExplosion3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picExplosion3.Name = "picExplosion3"
        Me.picExplosion3.Size = New System.Drawing.Size(73, 68)
        Me.picExplosion3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExplosion3.TabIndex = 48
        Me.picExplosion3.TabStop = False
        '
        'picExplosion2
        '
        Me.picExplosion2.Location = New System.Drawing.Point(131, 247)
        Me.picExplosion2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picExplosion2.Name = "picExplosion2"
        Me.picExplosion2.Size = New System.Drawing.Size(73, 68)
        Me.picExplosion2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExplosion2.TabIndex = 49
        Me.picExplosion2.TabStop = False
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 1
        '
        'tmrDown
        '
        Me.tmrDown.Interval = 1
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 1
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 1
        '
        'Beacon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Game.My.Resources.Resources.EPIC
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(876, 679)
        Me.Controls.Add(Me.picExplosion2)
        Me.Controls.Add(Me.picExplosion3)
        Me.Controls.Add(Me.picExplosion4)
        Me.Controls.Add(Me.lblContinue)
        Me.Controls.Add(Me.lblHighScores)
        Me.Controls.Add(Me.picLife2)
        Me.Controls.Add(Me.picLife1)
        Me.Controls.Add(Me.picExplosion1)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.picFlash)
        Me.Controls.Add(Me.picBoss1)
        Me.Controls.Add(Me.picBossLaser)
        Me.Controls.Add(Me.picBossShot1)
        Me.Controls.Add(Me.picBossShot2)
        Me.Controls.Add(Me.picBossShot4)
        Me.Controls.Add(Me.picBossShot3)
        Me.Controls.Add(Me.lblPreLevel)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.lblHardcore)
        Me.Controls.Add(Me.lblNormal)
        Me.Controls.Add(Me.lblEasy)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblBeacon)
        Me.Controls.Add(Me.picEnemyMissle3)
        Me.Controls.Add(Me.picEnemyMissle2)
        Me.Controls.Add(Me.picEnemyMissle4)
        Me.Controls.Add(Me.picEnemyMissle1)
        Me.Controls.Add(Me.picMissle2)
        Me.Controls.Add(Me.lblReady)
        Me.Controls.Add(Me.lblRoundComplete)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblPreScore)
        Me.Controls.Add(Me.picMissle1)
        Me.Controls.Add(Me.lblCampaign)
        Me.Controls.Add(Me.picEnemy1)
        Me.Controls.Add(Me.picEnemy4)
        Me.Controls.Add(Me.picEnemy2)
        Me.Controls.Add(Me.picEnemy3)
        Me.Controls.Add(Me.picPlayerShip)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.lstHS)
        Me.Controls.Add(Me.lblPreHealth)
        Me.Controls.Add(Me.lblHealth)
        Me.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Beacon"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beacon"
        CType(Me.picEnemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayerShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMissle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMissle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemyMissle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemyMissle4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemyMissle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnemyMissle3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoss1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBossShot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBossShot4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBossShot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBossShot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBossLaser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFlash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplosion1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLife1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLife2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplosion4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplosion3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplosion2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayerShip As System.Windows.Forms.PictureBox
    Friend WithEvents tmrEnemy1 As System.Windows.Forms.Timer
    Friend WithEvents picEnemy3 As System.Windows.Forms.PictureBox
    Friend WithEvents picEnemy2 As System.Windows.Forms.PictureBox
    Friend WithEvents picEnemy4 As System.Windows.Forms.PictureBox
    Friend WithEvents picEnemy1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrEnemy2 As System.Windows.Forms.Timer
    Friend WithEvents tmrEnemy3 As System.Windows.Forms.Timer
    Friend WithEvents tmrEnemy4 As System.Windows.Forms.Timer
    Friend WithEvents lblCampaign As System.Windows.Forms.Label
    Friend WithEvents picMissle1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrShot1 As System.Windows.Forms.Timer
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPreScore As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblRoundComplete As System.Windows.Forms.Label
    Friend WithEvents lblReady As System.Windows.Forms.Label
    Friend WithEvents OptionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartGameToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitGameToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picMissle2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrShot2 As System.Windows.Forms.Timer
    Friend WithEvents picEnemyMissle1 As System.Windows.Forms.PictureBox
    Friend WithEvents picEnemyMissle4 As System.Windows.Forms.PictureBox
    Friend WithEvents picEnemyMissle2 As System.Windows.Forms.PictureBox
    Friend WithEvents picEnemyMissle3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblBeacon As System.Windows.Forms.Label
    Friend WithEvents tmrEnemyShot1 As System.Windows.Forms.Timer
    Friend WithEvents tmrEnemyShot2 As System.Windows.Forms.Timer
    Friend WithEvents tmrEnemyShot3 As System.Windows.Forms.Timer
    Friend WithEvents tmrEnemyShot4 As System.Windows.Forms.Timer
    Friend WithEvents lblPreLevel As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblEasy As System.Windows.Forms.Label
    Friend WithEvents lblNormal As System.Windows.Forms.Label
    Friend WithEvents lblHardcore As System.Windows.Forms.Label
    Friend WithEvents lblBack As System.Windows.Forms.Label
    Friend WithEvents picBoss1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrBoss1 As System.Windows.Forms.Timer
    Friend WithEvents picBossShot3 As System.Windows.Forms.PictureBox
    Friend WithEvents picBossShot4 As System.Windows.Forms.PictureBox
    Friend WithEvents picBossShot2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBossShot1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrBossShot1 As System.Windows.Forms.Timer
    Friend WithEvents tmrBossShot2 As System.Windows.Forms.Timer
    Friend WithEvents tmrBossShot3 As System.Windows.Forms.Timer
    Friend WithEvents tmrBossShot4 As System.Windows.Forms.Timer
    Friend WithEvents tmrBossFireSequence As System.Windows.Forms.Timer
    Friend WithEvents tmrBossLaser As System.Windows.Forms.Timer
    Friend WithEvents picBossLaser As System.Windows.Forms.PictureBox
    Friend WithEvents tmrLaserPosition As System.Windows.Forms.Timer
    Friend WithEvents picFlash As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFlash As System.Windows.Forms.Timer
    Friend WithEvents tmrLaserFlash As System.Windows.Forms.Timer
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents picExplosion1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrExplosion1 As System.Windows.Forms.Timer
    Friend WithEvents tmrPlayerHealthTracker As System.Windows.Forms.Timer
    Friend WithEvents tmrPlayerHit As System.Windows.Forms.Timer
    Friend WithEvents lblPreHealth As System.Windows.Forms.Label
    Friend WithEvents lblHealth As System.Windows.Forms.Label
    Friend WithEvents picLife1 As System.Windows.Forms.PictureBox
    Friend WithEvents picLife2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblGameOver As System.Windows.Forms.Label
    Friend WithEvents tmrBossHit As System.Windows.Forms.Timer
    Friend WithEvents lstHS As System.Windows.Forms.ListBox
    Friend WithEvents lblHighScores As System.Windows.Forms.Label
    Friend WithEvents lblContinue As System.Windows.Forms.Label
    Friend WithEvents tmrHighScoreScroll As System.Windows.Forms.Timer
    Friend WithEvents tmrEnemy1Respawn As System.Windows.Forms.Timer
    Friend WithEvents tmrEnemy2Respawn As System.Windows.Forms.Timer
    Friend WithEvents tmrEnemy3Respawn As System.Windows.Forms.Timer
    Friend WithEvents tmrEnemy4Respawn As System.Windows.Forms.Timer
    Friend WithEvents tmrExplosion2 As System.Windows.Forms.Timer
    Friend WithEvents tmrExplosion3 As System.Windows.Forms.Timer
    Friend WithEvents tmrExplosion4 As System.Windows.Forms.Timer
    Friend WithEvents picExplosion4 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplosion3 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplosion2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrUp As System.Windows.Forms.Timer
    Friend WithEvents tmrDown As System.Windows.Forms.Timer
    Friend WithEvents tmrLeft As System.Windows.Forms.Timer
    Friend WithEvents tmrRight As System.Windows.Forms.Timer

End Class
