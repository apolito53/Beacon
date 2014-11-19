Imports System.IO

Public Class Beacon

    Dim intScore As Integer = 0
    Dim intLevel As Integer = 0
    Dim intBossHealth As Integer = 1
    Dim intPlayerHealth As Integer = 1
    Dim intDifficulty As Integer = 1
    Dim intLives As Integer = 3
    Dim Enemy1Defeated As Boolean
    Dim Enemy2Defeated As Boolean
    Dim Enemy3Defeated As Boolean
    Dim Enemy4Defeated As Boolean
    Dim intHSCount As Integer = 0

    Structure Highscore

        Dim strname As String
        Dim intscore As Integer

    End Structure

    Function PlayerStatus() As Boolean

        Dim PlayerDead As Boolean

        If Me.lblBeacon.Visible = False Then
            If intLevel > 0 Then
                If Me.picPlayerShip.Visible = False Then
                    PlayerDead = True
                ElseIf Me.picPlayerShip.Visible = True Then
                    PlayerDead = False
                End If
            End If
        End If

        Return PlayerDead

    End Function

    Function Round_Complete() As Boolean

        Dim RoundComplete As Boolean

        If Enemy1Defeated = True Then
            If Enemy2Defeated = True Then
                If Enemy3Defeated = True Then
                    If Enemy4Defeated = True Then
                        RoundComplete = True
                    End If
                End If
            End If
        End If

        Return RoundComplete

    End Function

    Function Boss_Defeat() As Boolean

        Dim Boss_Defeated As Boolean

        If Me.lblBeacon.Visible = False Then
            If Me.picBoss1.Visible = False Then
                Boss_Defeated = True
            End If
        End If

        Return Boss_Defeated

    End Function

    Sub BallStart()

        Me.picPlayerShip.Top = Me.Height - Me.picPlayerShip.Height - 40 'Position of player
        Me.picPlayerShip.Left = Me.Width / 2

        Me.picEnemy1.Left = Me.Width - Me.Width - Me.picEnemy1.Width 'Position of enemies
        Me.picEnemy2.Left = Me.Width + Me.picEnemy2.Width
        Me.picEnemy3.Left = Me.Width - Me.Width - Me.picEnemy3.Width
        Me.picEnemy4.Left = Me.Width + Me.picEnemy4.Width

        Me.picBoss1.Top = Me.Height + Me.picBoss1.Height

        Me.picEnemyMissle1.Visible = False
        Me.picEnemyMissle2.Visible = False
        Me.picEnemyMissle3.Visible = False
        Me.picEnemyMissle4.Visible = False
        Me.picMissle1.Visible = False
        Me.picMissle2.Visible = False

        Me.picBossShot1.Visible = False
        Me.picBossShot2.Visible = False
        Me.picBossShot3.Visible = False
        Me.picBossShot4.Visible = False
        Me.picBossShot1.Top = -300
        Me.picBossShot2.Top = -300
        Me.picBossShot3.Top = -300
        Me.picBossShot4.Top = -300

        Me.tmrEnemyShot1.Stop()
        Me.tmrEnemyShot2.Stop()
        Me.tmrEnemyShot3.Stop()
        Me.tmrEnemyShot4.Stop()

    End Sub

    Sub Begin()

        Me.picPlayerShip.Visible = True     'Player ship and enemies visible
        Me.picEnemy4.Visible = True
        Me.picEnemy3.Visible = True
        Me.picEnemy2.Visible = True
        Me.picEnemy1.Visible = True
        Me.picEnemy1.Image = My.Resources.Enemy1
        Me.picEnemy2.Image = My.Resources.Enemy1
        Me.picEnemy3.Image = My.Resources.Enemy1
        Me.picEnemy4.Image = My.Resources.Enemy1
        Me.picEnemyMissle1.Image = My.Resources.AlienShot1
        Me.picEnemyMissle2.Image = My.Resources.AlienShot1
        Me.picEnemyMissle3.Image = My.Resources.AlienShot1
        Me.picEnemyMissle4.Image = My.Resources.AlienShot1

        Me.tmrEnemy1.Start()                'Timers for enemies enabled
        Me.tmrEnemy2.Start()
        Me.tmrEnemy3.Start()
        Me.tmrEnemy4.Start()

        Enemy1Defeated = False
        Enemy2Defeated = False
        Enemy3Defeated = False
        Enemy4Defeated = False

        My.Computer.Audio.Play(My.Resources.Timer, AudioPlayMode.WaitToComplete) 'Timer sound plays before level starts

    End Sub

    Sub PlayerDeath()

        intLives -= 1

        If intLevel = 5 Then
            Call Boss1_Event()
            Me.tmrBossFireSequence.Start()
        Else
            Call BallStart()
        End If

        My.Computer.Audio.Play(My.Resources.Explosion_SoundBible_com_2019248186, AudioPlayMode.WaitToComplete)  'Explosion sound plays when player dies

        If intLives = 3 Or 2 Or 1 Then
            My.Computer.Audio.Play(My.Resources.Timer, AudioPlayMode.WaitToComplete)
        End If

        Me.picPlayerShip.Visible = True
        Me.picBossLaser.Top = -500

        If intDifficulty = 1 Then
            intPlayerHealth = 150
        ElseIf intDifficulty = 2 Then
            intPlayerHealth = 100
        ElseIf intDifficulty = 3 Then
            intPlayerHealth = 50
        End If

    End Sub

    Sub Boss1_Event()

        Call BallStart()

        Me.picBoss1.Visible = True
        Me.picBoss1.Image = My.Resources.Blue_Boss

        intBossHealth = 60

        Me.picEnemy1.Visible = False
        Me.picEnemy2.Visible = False
        Me.picEnemy3.Visible = False
        Me.picEnemy4.Visible = False
        Me.picBossLaser.Visible = False
        Me.tmrEnemy1.Stop()
        Me.tmrEnemy2.Stop()
        Me.tmrEnemy3.Stop()
        Me.tmrEnemy4.Stop()

        Me.picBoss1.Top = 0 - Me.picBoss1.Height
        Me.picBoss1.Left = (Me.Width / 2) - Me.picBoss1.Width
        Me.tmrBoss1.Start()

        Me.tmrBossFireSequence.Enabled = True
        Me.tmrBossFireSequence.Start()

    End Sub

    Sub GameOver()

        Me.tmrPlayerHealthTracker.Stop()

        Call BallStart()                                        'Sub for position of player and objects

        Me.lblGameOver.Visible = True

        Me.lblScore.Text = intScore
        Me.lblLevel.Text = intLevel

        Me.lblReady.Visible = False
        Me.lblBack.Visible = False

        Me.picPlayerShip.Image = My.Resources.SpaceShip         'Defines resources for game objects
        Me.picBoss1.Image = My.Resources.Boss
        Me.picMissle1.Image = My.Resources.PlayerShot
        Me.picMissle2.Image = My.Resources.PlayerShot

        Me.picPlayerShip.Visible = False                        'All player and enemy objects are hidden
        Me.picEnemy4.Visible = False
        Me.picEnemy3.Visible = False
        Me.picEnemy2.Visible = False
        Me.picEnemy1.Visible = False
        Me.picMissle1.Visible = False
        Me.picMissle2.Visible = False
        Me.picEnemyMissle1.Visible = False
        Me.picEnemyMissle2.Visible = False
        Me.picEnemyMissle3.Visible = False
        Me.picEnemyMissle4.Visible = False
        Me.picBoss1.Visible = False
        Me.picBossShot1.Visible = False
        Me.picBossShot2.Visible = False
        Me.picBossShot3.Visible = False
        Me.picBossShot4.Visible = False
        Me.picBossLaser.Visible = False
        Me.picFlash.Visible = False
        Me.picExplosion1.Visible = False

        Me.tmrBoss1.Stop()
        Me.tmrBossShot1.Stop()
        Me.tmrBossShot2.Stop()
        Me.tmrBossShot3.Stop()
        Me.tmrBossShot4.Stop()
        Me.tmrLaserFlash.Stop()
        Me.tmrLaserPosition.Stop()
        Me.tmrBossFireSequence.Stop()
        Me.tmrEnemy1.Stop()
        Me.tmrEnemy2.Stop()
        Me.tmrEnemy3.Stop()
        Me.tmrEnemy4.Stop()
        Me.tmrEnemy1Respawn.Stop()
        Me.tmrEnemy2Respawn.Stop()
        Me.tmrEnemy3Respawn.Stop()
        Me.tmrEnemy4Respawn.Stop()
        Me.tmrEnemyShot1.Stop()
        Me.tmrEnemyShot2.Stop()
        Me.tmrEnemyShot3.Stop()
        Me.tmrEnemyShot4.Stop()
        Me.tmrShot1.Stop()
        Me.tmrShot2.Stop()

        Me.lblScore.Visible = False                             'Score indicator is hidden
        Me.lblPreScore.Visible = False

        Me.lblLevel.Visible = False                             'Level indicator is hidden
        Me.lblPreLevel.Visible = False

        Me.lblHealth.Visible = False                            'Health indicator is hidden
        Me.lblPreHealth.Visible = False

        Me.lblEasy.Visible = False                              'Difficulty setting labels are hidden
        Me.lblNormal.Visible = False
        Me.lblHardcore.Visible = False

        Me.lblRoundComplete.Visible = False                     'Round complete label is hidden

        My.Computer.Audio.Play(My.Resources.Atmospheric_Pad, AudioPlayMode.BackgroundLoop) 'Music file loops in background on game start-up

    End Sub

    Private Sub Game_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Static intFireCounter As Integer = 0

        If e.KeyCode = Keys.Left Then                                   'Player moves left
            Me.tmrLeft.Start()
        ElseIf e.KeyCode = Keys.Right Then                              'Player moves right
            Me.tmrRight.Start()
        ElseIf e.KeyCode = Keys.Down Then                               'Player moves down
            Me.tmrDown.Start()
        ElseIf e.KeyCode = Keys.Up Then                                 'Player moves up
            Me.tmrUp.Start()
        ElseIf e.KeyCode = Keys.M Then                                  'Mutes the program
            My.Computer.Audio.Stop()
        End If

        If Me.picPlayerShip.Top < Me.Height - 150 Then
            Me.picPlayerShip.Top = Me.Height - 150
        ElseIf Me.picPlayerShip.Left <= 0 Then
            Me.picPlayerShip.Left = 0
        ElseIf Me.picPlayerShip.Left >= Me.Width - Me.picPlayerShip.Width Then
            Me.picPlayerShip.Left = Me.Width - Me.picPlayerShip.Width
        ElseIf Me.picPlayerShip.Top > Me.Height - (Me.picPlayerShip.Height * 2) Then
            Me.picPlayerShip.Top = Me.Height - (Me.picPlayerShip.Height * 2)
        End If

        If Me.lblBeacon.Visible = False Then
            If Me.lblGameOver.Visible = False Then
                If e.KeyCode = Keys.Space Then
                    intFireCounter += 1
                    If intFireCounter = 1 Then
                        Me.picMissle1.Left = Me.picPlayerShip.Left + 10
                        Me.picMissle1.Top = Me.picPlayerShip.Top
                        Me.picMissle1.Visible = True
                        Me.tmrShot1.Start()
                        Me.picFlash.Visible = True
                        Me.picFlash.Top = Me.picPlayerShip.Top
                        Me.picFlash.Left = Me.picPlayerShip.Left + 3
                        Me.tmrFlash.Start()
                        If Me.picBoss1.Visible = False Then
                            If Me.picExplosion1.Visible = False Then
                                If Me.picExplosion2.Visible = False Then
                                    If Me.picExplosion3.Visible = False Then
                                        If Me.picExplosion4.Visible = False Then
                                            If Me.lblRoundComplete.Visible = False Then
                                                My.Computer.Audio.Play(My.Resources.Free_Kick_Sample_12_912_Free_Loops_com, AudioPlayMode.Background)
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If intFireCounter = 2 Then
                        If Me.picMissle2.Visible = False Then
                            Me.picMissle2.Left = Me.picPlayerShip.Left + 20
                            Me.picMissle2.Top = Me.picPlayerShip.Top
                            Me.picMissle2.Visible = True
                            Me.tmrShot2.Start()
                            Me.picFlash.Visible = True
                            Me.picFlash.Top = Me.picPlayerShip.Top
                            Me.picFlash.Left = Me.picPlayerShip.Left + 15
                            Me.tmrFlash.Start()
                            If Me.picBoss1.Visible = False Then
                                If Me.picExplosion1.Visible = False Then
                                    If Me.picExplosion2.Visible = False Then
                                        If Me.picExplosion3.Visible = False Then
                                            If Me.picExplosion4.Visible = False Then
                                                If Me.lblRoundComplete.Visible = False Then
                                                    My.Computer.Audio.Play(My.Resources.Free_Kick_Sample_12_912_Free_Loops_com, AudioPlayMode.Background)
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If intFireCounter = 3 Then
                        intFireCounter -= 2
                        If Me.picMissle1.Visible = False Then
                            Me.picMissle1.Left = Me.picPlayerShip.Left + 10
                            Me.picMissle1.Top = Me.picPlayerShip.Top
                            Me.picMissle1.Visible = True
                            Me.tmrShot1.Start()
                            Me.picFlash.Visible = True
                            Me.picFlash.Top = Me.picPlayerShip.Top
                            Me.picFlash.Left = Me.picPlayerShip.Left + 3
                            Me.tmrFlash.Start()
                            If Me.picBoss1.Visible = False Then
                                If Me.picExplosion1.Visible = False Then
                                    If Me.picExplosion2.Visible = False Then
                                        If Me.picExplosion3.Visible = False Then
                                            If Me.picExplosion4.Visible = False Then
                                                If Me.lblRoundComplete.Visible = False Then
                                                    My.Computer.Audio.Play(My.Resources.Free_Kick_Sample_12_912_Free_Loops_com, AudioPlayMode.Background)
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Game_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.Up Then
            Me.tmrUp.Stop()
        ElseIf e.KeyCode = Keys.Down Then
            Me.tmrDown.Stop()
        ElseIf e.KeyCode = Keys.Right Then
            Me.tmrRight.Stop()
        ElseIf e.KeyCode = Keys.Left Then
            Me.tmrLeft.Stop()
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call BallStart()                                        'Sub for position of player and objects

        Me.tmrHighScoreScroll.Start()

        Me.lblScore.Text = intScore                             '
        Me.lblLevel.Text = intLevel

        Me.lblReady.Visible = False
        Me.lblBack.Visible = False

        Me.lblHighScores.Visible = False
        Me.lblContinue.Visible = False

        Me.picPlayerShip.Image = My.Resources.SpaceShip         'Defines resources for game objects
        Me.picBoss1.Image = My.Resources.Boss
        Me.picMissle1.Image = My.Resources.PlayerShot
        Me.picMissle2.Image = My.Resources.PlayerShot

        Me.picPlayerShip.Visible = False                        'All player and enemy objects are hidden
        Me.picEnemy4.Visible = False
        Me.picEnemy3.Visible = False
        Me.picEnemy2.Visible = False
        Me.picEnemy1.Visible = False
        Me.picMissle1.Visible = False
        Me.picMissle2.Visible = False
        Me.picEnemyMissle1.Visible = False
        Me.picEnemyMissle2.Visible = False
        Me.picEnemyMissle3.Visible = False
        Me.picEnemyMissle4.Visible = False
        Me.picBoss1.Visible = False
        Me.picBossShot1.Visible = False
        Me.picBossShot2.Visible = False
        Me.picBossShot3.Visible = False
        Me.picBossShot4.Visible = False
        Me.picBossLaser.Visible = False
        Me.picFlash.Visible = False
        Me.picExplosion1.Visible = False
        Me.picExplosion2.Visible = False
        Me.picExplosion3.Visible = False
        Me.picExplosion4.Visible = False
        Me.picLife1.Visible = False
        Me.picLife2.Visible = False

        Me.lblScore.Visible = False                             'Score indicator is hidden
        Me.lblPreScore.Visible = False

        Me.lblLevel.Visible = False                             'Level indicator is hidden
        Me.lblPreLevel.Visible = False

        Me.lblHealth.Visible = False                            'Health indicator is hidden
        Me.lblPreHealth.Visible = False
        Me.lblHealth.BackColor = Color.Transparent
        Me.lblPreHealth.BackColor = Color.Transparent

        Me.lblEasy.Visible = False                              'Difficulty setting labels are hidden
        Me.lblNormal.Visible = False
        Me.lblHardcore.Visible = False

        Me.lblGameOver.Visible = False

        Me.lblRoundComplete.Visible = False                     'Round complete label is hidden

        Me.lstHS.Visible = False

        My.Computer.Audio.Play(My.Resources.Game_Theme, AudioPlayMode.BackgroundLoop) 'Music file loops in background on game start-up

    End Sub

    Private Sub tmrEnemy1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemy1.Tick

        Me.picEnemy1.Left += 5                  'Enemy moves across the screen

        Static intCount As Integer = 0

        If Me.picEnemy1.Left + Me.picEnemy1.Width > Me.Width Then
            Me.picEnemy1.Left = Me.Width - Me.Width - Me.picEnemy1.Width
        End If

        Dim Left As Long
        Dim Right As Long

        Dim EnemyRight1 As Long
        Dim EnemyLeft1 As Long

        Dim LeftBetween As Boolean
        Dim RightBetween As Boolean

        Left = Me.picPlayerShip.Left
        Right = Me.picPlayerShip.Left + Me.picPlayerShip.Width

        EnemyLeft1 = Me.picEnemy1.Left
        EnemyRight1 = Me.picEnemy1.Left + Me.picEnemy1.Width

        If Left >= EnemyLeft1 And Left <= EnemyRight1 Then
            LeftBetween = True
            If Right >= EnemyLeft1 And Right <= EnemyRight1 Then
                RightBetween = True
            End If
        End If
        If LeftBetween = True Or RightBetween = True Then
            If Me.picEnemyMissle1.Visible = False Then
                Me.picEnemyMissle1.Left = Me.picEnemy1.Left + 10
                Me.picEnemyMissle1.Top = Me.picEnemy1.Top
                Me.picEnemyMissle1.Visible = True
                Me.tmrEnemyShot1.Start()
            End If
        End If

        Dim Top1 As Long                             'Collision between enemy and player missle
        Dim Bottom1 As Long
        Dim Left1 As Long
        Dim Right1 As Long

        Dim Top2 As Long
        Dim Bottom2 As Long
        Dim Left2 As Long
        Dim Right2 As Long

        Dim EnemyTop As Long
        Dim EnemyBottom As Long
        Dim EnemyLeft As Long
        Dim EnemyRight As Long

        Dim leftBetween1 As Boolean
        Dim rightBetween1 As Boolean
        Dim topBetween1 As Boolean
        Dim bottomBetween1 As Boolean

        Dim leftBetween2 As Boolean
        Dim rightBetween2 As Boolean
        Dim topBetween2 As Boolean
        Dim bottomBetween2 As Boolean

        Top1 = Me.picMissle1.Top
        Bottom1 = Me.picMissle1.Bottom + Me.picMissle1.Height
        Left1 = Me.picMissle1.Left
        Right1 = Me.picMissle1.Left + Me.picMissle1.Width

        Top2 = Me.picMissle2.Top
        Bottom2 = Me.picMissle2.Bottom + Me.picMissle1.Height
        Left2 = Me.picMissle2.Left
        Right2 = Me.picMissle2.Left + Me.picMissle1.Width

        EnemyTop = Me.picEnemy1.Top - 30
        EnemyBottom = Me.picEnemy1.Bottom + Me.picEnemy1.Height - 30
        EnemyLeft = Me.picEnemy1.Left
        EnemyRight = Me.picEnemy1.Left + Me.picEnemy1.Width

        If Left1 >= EnemyLeft And Left1 <= EnemyRight Then          'Boolean conditions for collision
            leftBetween1 = True
        End If
        If Right1 >= EnemyLeft And Right1 <= EnemyRight Then
            rightBetween1 = True
        End If
        If Top1 >= EnemyTop And Top1 <= EnemyBottom Then
            topBetween1 = True
        End If
        If Bottom1 >= EnemyTop And Bottom1 <= EnemyBottom Then
            bottomBetween1 = True
        End If

        If leftBetween1 = True Or rightBetween1 = True Then         'Result for collision between enemy and missle1
            If topBetween1 = True Or bottomBetween1 = True Then
                Me.picMissle1.Top = Me.picPlayerShip.Top
                Me.picMissle1.Left = Me.picPlayerShip.Left + 5
                Me.picMissle1.Visible = False
                Me.tmrShot1.Stop()
                Me.picEnemy1.Visible = False
                My.Computer.Audio.Play(My.Resources.Explosion_SoundBible_com_2019248186, AudioPlayMode.Background)
                Me.tmrExplosion1.Start()
                Me.picExplosion1.Visible = True
                Me.picExplosion1.Left = Me.picEnemy1.Left
                Me.picExplosion1.Top = Me.picEnemy1.Top
                If intDifficulty = 1 Then
                    intScore += 50
                ElseIf intDifficulty = 2 Then
                    intScore += 75
                ElseIf intDifficulty = 3 Then
                    intScore += 100
                End If
                Me.lblScore.Text = intScore
                intCount += 1
                If intCount = 1 Then
                    Me.tmrEnemy1Respawn.Start()
                    Me.picEnemy1.Image = My.Resources.Enemy2
                    Me.picEnemy1.Left = Me.Width - Me.Width - Me.picEnemy1.Width
                ElseIf intCount = 2 Then
                    Me.tmrEnemy1Respawn.Start()
                    Me.picEnemy1.Image = My.Resources.Enemy2
                    Me.picEnemy1.Left = Me.Width - Me.Width - Me.picEnemy1.Width
                ElseIf intCount = 3 Then
                    intCount -= intCount
                    Me.picEnemy1.Image = My.Resources.Enemy1
                    Me.tmrEnemy1.Stop()
                    Enemy1Defeated = True
                End If
                Me.tmrEnemy1.Stop()
                Me.lblScore.Text = intScore
            End If
        End If

        If Left2 >= EnemyLeft And Left2 <= EnemyRight Then          'Boolean condition for collisions
            leftBetween2 = True
        End If
        If Right2 >= EnemyLeft And Right2 <= EnemyRight Then
            rightBetween2 = True
        End If
        If Top2 >= EnemyTop And Top2 <= EnemyBottom Then
            topBetween2 = True
        End If
        If Bottom2 >= EnemyTop And Bottom2 <= EnemyBottom Then
            bottomBetween2 = True
        End If

        If leftBetween2 = True Or rightBetween2 = True Then         'Result for collision between enemy and missle2
            If topBetween2 = True Or bottomBetween2 = True Then
                Me.picMissle2.Top = Me.picPlayerShip.Top
                Me.picMissle2.Left = Me.picPlayerShip.Left + 5
                Me.picMissle2.Visible = False
                Me.tmrShot2.Stop()
                Me.picEnemy1.Visible = False
                My.Computer.Audio.Play(My.Resources.Explosion_SoundBible_com_2019248186, AudioPlayMode.Background)
                Me.tmrExplosion1.Start()
                Me.picExplosion1.Visible = True
                Me.picExplosion1.Left = Me.picEnemy1.Left
                Me.picExplosion1.Top = Me.picEnemy1.Top
                If intDifficulty = 1 Then
                    intScore += 50
                ElseIf intDifficulty = 2 Then
                    intScore += 75
                ElseIf intDifficulty = 3 Then
                    intScore += 100
                End If
                intCount += 1
                If intCount = 1 Then
                    Me.tmrEnemy1Respawn.Start()
                    Me.picEnemy1.Image = My.Resources.Enemy2
                    Me.picEnemy1.Left = Me.Width - Me.Width - Me.picEnemy1.Width
                ElseIf intCount = 2 Then
                    Me.tmrEnemy1Respawn.Start()
                    Me.picEnemy1.Image = My.Resources.Enemy3
                    Me.picEnemy1.Left = Me.Width - Me.Width - Me.picEnemy1.Width
                ElseIf intCount = 3 Then
                    intCount -= intCount
                    Me.picEnemy1.Image = My.Resources.Enemy1
                    Me.tmrEnemy1.Stop()
                    Enemy1Defeated = True
                End If
                Me.tmrEnemy1.Stop()
                Me.lblScore.Text = intScore
            End If
        End If

        Call Round_Complete()
        If Round_Complete() = True Then
            My.Computer.Audio.Play(My.Resources.Maniac_Single, AudioPlayMode.Background)
            Call BallStart()
            Me.lblRoundComplete.Visible = True
        End If

    End Sub

    Private Sub tmrEnemy2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemy2.Tick

        Me.picEnemy2.Left -= 7

        Static intCount As Integer = 0

        If Me.picEnemy2.Left - Me.picEnemy2.Width < Me.Width - Me.Width - Me.picEnemy2.Width Then
            Me.picEnemy2.Left = Me.Width - Me.picEnemy2.Width
        End If

        Dim Left As Long
        Dim Right As Long

        Dim EnemyRight1 As Long
        Dim EnemyLeft1 As Long

        Dim LeftBetween As Boolean
        Dim RightBetween As Boolean

        Left = Me.picPlayerShip.Left
        Right = Me.picPlayerShip.Left + Me.picPlayerShip.Width

        EnemyLeft1 = Me.picEnemy2.Left
        EnemyRight1 = Me.picEnemy2.Left + Me.picEnemy2.Width

        If Left >= EnemyLeft1 And Left <= EnemyRight1 Then
            LeftBetween = True
            If Right >= EnemyLeft1 And Right <= EnemyRight1 Then
                RightBetween = True
            End If
        End If

        If LeftBetween = True Or RightBetween = True Then
            If Me.picEnemyMissle2.Visible = False Then
                Me.picEnemyMissle2.Left = Me.picEnemy2.Left + 10
                Me.picEnemyMissle2.Top = Me.picEnemy2.Top
                Me.picEnemyMissle2.Visible = True
                Me.tmrEnemyShot2.Start()
            End If
        End If

        Dim Top1 As Long                             'Collision between enemy and player missle
        Dim Bottom1 As Long
        Dim Left1 As Long
        Dim Right1 As Long

        Dim Top2 As Long
        Dim Bottom2 As Long
        Dim Left2 As Long
        Dim Right2 As Long

        Dim EnemyTop As Long
        Dim EnemyBottom As Long
        Dim EnemyLeft As Long
        Dim EnemyRight As Long

        Dim leftBetween1 As Boolean
        Dim rightBetween1 As Boolean
        Dim topBetween1 As Boolean
        Dim bottomBetween1 As Boolean

        Dim leftBetween2 As Boolean
        Dim rightBetween2 As Boolean
        Dim topBetween2 As Boolean
        Dim bottomBetween2 As Boolean

        Top1 = Me.picMissle1.Top
        Bottom1 = Me.picMissle1.Bottom + Me.picMissle1.Height
        Left1 = Me.picMissle1.Left
        Right1 = Me.picMissle1.Left + Me.picMissle1.Width

        Top2 = Me.picMissle2.Top
        Bottom2 = Me.picMissle2.Bottom + Me.picMissle1.Height
        Left2 = Me.picMissle2.Left
        Right2 = Me.picMissle2.Left + Me.picMissle1.Width

        EnemyTop = Me.picEnemy2.Top - 30
        EnemyBottom = Me.picEnemy2.Bottom + Me.picEnemy2.Height - 30
        EnemyLeft = Me.picEnemy2.Left
        EnemyRight = Me.picEnemy2.Left + Me.picEnemy2.Width

        If Left1 >= EnemyLeft And Left1 <= EnemyRight Then          'Boolean conditions for collision
            leftBetween1 = True
        End If
        If Right1 >= EnemyLeft And Right1 <= EnemyRight Then
            rightBetween1 = True
        End If
        If Top1 >= EnemyTop And Top1 <= EnemyBottom Then
            topBetween1 = True
        End If
        If Bottom1 >= EnemyTop And Bottom1 <= EnemyBottom Then
            bottomBetween1 = True
        End If

        If leftBetween1 = True Or rightBetween1 = True Then         'Result for collision between enemy and missle1
            If topBetween1 = True Or bottomBetween1 = True Then
                Me.picMissle1.Top = Me.picPlayerShip.Top
                Me.picMissle1.Left = Me.picPlayerShip.Left + 5
                Me.picMissle1.Visible = False
                Me.tmrShot1.Stop()
                Me.picEnemy2.Visible = False
                My.Computer.Audio.Play(My.Resources.Explosion_SoundBible_com_2019248186, AudioPlayMode.Background)
                Me.tmrExplosion2.Start()
                Me.picExplosion2.Visible = True
                Me.picExplosion2.Left = Me.picEnemy2.Left
                Me.picExplosion2.Top = Me.picEnemy2.Top
                If intDifficulty = 1 Then
                    intScore += 50
                ElseIf intDifficulty = 2 Then
                    intScore += 75
                ElseIf intDifficulty = 3 Then
                    intScore += 100
                End If
                intCount += 1
                If intCount = 1 Then
                    Me.tmrEnemy2Respawn.Start()
                    Me.picEnemy2.Image = My.Resources.Enemy2
                    Me.picEnemy2.Left = Me.Width + Me.picEnemy2.Width
                ElseIf intCount = 2 Then
                    Me.tmrEnemy2Respawn.Start()
                    Me.picEnemy2.Image = My.Resources.Enemy3
                    Me.picEnemy2.Left = Me.Width + Me.picEnemy2.Width
                ElseIf intCount = 3 Then
                    intCount -= intCount
                    Me.picEnemy2.Image = My.Resources.Enemy1
                    Me.tmrEnemy2.Stop()
                    Enemy2Defeated = True
                End If
                Me.tmrEnemy2.Stop()
                Me.lblScore.Text = intScore
            End If
        End If

        If Left2 >= EnemyLeft And Left2 <= EnemyRight Then          'Boolean condition for collisions
            leftBetween2 = True
        End If
        If Right2 >= EnemyLeft And Right2 <= EnemyRight Then
            rightBetween2 = True
        End If
        If Top2 >= EnemyTop And Top2 <= EnemyBottom Then
            topBetween2 = True
        End If
        If Bottom2 >= EnemyTop And Bottom2 <= EnemyBottom Then
            bottomBetween2 = True
        End If

        If leftBetween2 = True Or rightBetween2 = True Then         'Result for collision between enemy and missle2
            If topBetween2 = True Or bottomBetween2 = True Then
                Me.picMissle2.Top = Me.picPlayerShip.Top
                Me.picMissle2.Left = Me.picPlayerShip.Left + 5
                Me.picMissle2.Visible = False
                Me.tmrShot2.Stop()
                Me.picEnemy2.Visible = False
                My.Computer.Audio.Play(My.Resources.Explosion_SoundBible_com_2019248186, AudioPlayMode.Background)
                Me.tmrExplosion2.Start()
                Me.picExplosion2.Visible = True
                Me.picExplosion2.Left = Me.picEnemy2.Left
                Me.picExplosion2.Top = Me.picEnemy2.Top
                If intDifficulty = 1 Then
                    intScore += 50
                ElseIf intDifficulty = 2 Then
                    intScore += 75
                ElseIf intDifficulty = 3 Then
                    intScore += 100
                End If
                intCount += 1
                If intCount = 1 Then
                    Me.tmrEnemy2Respawn.Start()
                    Me.picEnemy2.Image = My.Resources.Enemy2
                    Me.picEnemy2.Left = Me.Width + Me.picEnemy2.Width
                ElseIf intCount = 2 Then
                    Me.tmrEnemy2Respawn.Start()
                    Me.picEnemy2.Image = My.Resources.Enemy3
                    Me.picEnemy2.Left = Me.Width + Me.picEnemy2.Width
                ElseIf intCount = 3 Then
                    intCount -= intCount
                    Me.picEnemy2.Image = My.Resources.Enemy1
                    Me.tmrEnemy2.Stop()
                    Enemy2Defeated = True
                End If
                Me.tmrEnemy2.Stop()
                Me.lblScore.Text = intScore
            End If
        End If

        Call Round_Complete()
        If Round_Complete() = True Then
            My.Computer.Audio.Play(My.Resources.Maniac_Single, AudioPlayMode.Background)
            Call BallStart()
            Me.lblRoundComplete.Visible = True
        End If

    End Sub

    Private Sub tmrEnemy3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemy3.Tick

        Me.picEnemy3.Left += 8

        Static intCount As Integer = 0

        If Me.picEnemy3.Left + Me.picEnemy3.Width > Me.Width Then
            Me.picEnemy3.Left = Me.Width - Me.Width - Me.picEnemy3.Width
        End If

        Dim Left As Long
        Dim Right As Long

        Dim EnemyRight1 As Long
        Dim EnemyLeft1 As Long

        Dim LeftBetween As Boolean
        Dim RightBetween As Boolean

        Left = Me.picPlayerShip.Left
        Right = Me.picPlayerShip.Left + Me.picPlayerShip.Width

        EnemyLeft1 = Me.picEnemy3.Left
        EnemyRight1 = Me.picEnemy3.Left + Me.picEnemy1.Width

        If Left >= EnemyLeft1 And Left <= EnemyRight1 Then
            LeftBetween = True
            If Right >= EnemyLeft1 And Right <= EnemyRight1 Then
                RightBetween = True
            End If
        End If
        If LeftBetween = True Or RightBetween = True Then
            If Me.picEnemyMissle3.Visible = False Then
                Me.picEnemyMissle3.Left = Me.picEnemy3.Left + 10
                Me.picEnemyMissle3.Top = Me.picEnemy3.Top
                Me.picEnemyMissle3.Visible = True
                Me.tmrEnemyShot3.Start()
            End If
        End If

        Dim Top1 As Long                             'Collision between enemy and player missle
        Dim Bottom1 As Long
        Dim Left1 As Long
        Dim Right1 As Long

        Dim Top2 As Long
        Dim Bottom2 As Long
        Dim Left2 As Long
        Dim Right2 As Long

        Dim EnemyTop As Long
        Dim EnemyBottom As Long
        Dim EnemyLeft As Long
        Dim EnemyRight As Long

        Dim leftBetween1 As Boolean
        Dim rightBetween1 As Boolean
        Dim topBetween1 As Boolean
        Dim bottomBetween1 As Boolean

        Dim leftBetween2 As Boolean
        Dim rightBetween2 As Boolean
        Dim topBetween2 As Boolean
        Dim bottomBetween2 As Boolean

        Top1 = Me.picMissle1.Top
        Bottom1 = Me.picMissle1.Bottom + Me.picMissle1.Height
        Left1 = Me.picMissle1.Left
        Right1 = Me.picMissle1.Left + Me.picMissle1.Width

        Top2 = Me.picMissle2.Top
        Bottom2 = Me.picMissle2.Bottom + Me.picMissle1.Height
        Left2 = Me.picMissle2.Left
        Right2 = Me.picMissle2.Left + Me.picMissle1.Width

        EnemyTop = Me.picEnemy3.Top - 30
        EnemyBottom = Me.picEnemy3.Bottom + Me.picEnemy3.Height - 30
        EnemyLeft = Me.picEnemy3.Left
        EnemyRight = Me.picEnemy3.Left + Me.picEnemy3.Width

        If Left1 >= EnemyLeft And Left1 <= EnemyRight Then          'Boolean conditions for collision
            leftBetween1 = True
            If Right1 >= EnemyLeft And Right1 <= EnemyRight Then
                rightBetween1 = True
            End If
        End If
        If Top1 >= EnemyTop And Top1 <= EnemyBottom Then
            topBetween1 = True
        End If
        If Bottom1 >= EnemyTop And Bottom1 <= EnemyBottom Then
            bottomBetween1 = True
        End If

        If leftBetween1 = True Or rightBetween1 = True Then         'Result for collision between enemy and missle1
            If topBetween1 = True Or bottomBetween1 = True Then
                Me.picMissle1.Top = Me.picPlayerShip.Top
                Me.picMissle1.Left = Me.picPlayerShip.Left + 5
                Me.picMissle1.Visible = False
                Me.tmrShot1.Stop()
                Me.picEnemy3.Visible = False
                My.Computer.Audio.Play(My.Resources.Explosion_SoundBible_com_2019248186, AudioPlayMode.Background)
                Me.tmrExplosion3.Start()
                Me.picExplosion3.Visible = True
                Me.picExplosion3.Left = Me.picEnemy3.Left
                Me.picExplosion3.Top = Me.picEnemy3.Top
                If intDifficulty = 1 Then
                    intScore += 50
                ElseIf intDifficulty = 2 Then
                    intScore += 75
                ElseIf intDifficulty = 3 Then
                    intScore += 100
                End If
                intCount += 1
                If intCount = 1 Then
                    Me.tmrEnemy3Respawn.Start()
                    Me.picEnemy3.Image = My.Resources.Enemy2
                    Me.picEnemy3.Left = Me.Width + Me.picEnemy3.Width
                ElseIf intCount = 2 Then
                    Me.tmrEnemy3Respawn.Start()
                    Me.picEnemy3.Image = My.Resources.Enemy3
                    Me.picEnemy3.Left = Me.Width + Me.picEnemy3.Width
                ElseIf intCount = 3 Then
                    intCount -= intCount
                    Me.picEnemy3.Image = My.Resources.Enemy1
                    Me.tmrEnemy3.Stop()
                    Enemy3Defeated = True
                End If
                Me.tmrEnemy3.Stop()
                Me.lblScore.Text = intScore
            End If
        End If

        If Left2 >= EnemyLeft And Left2 <= EnemyRight Then          'Boolean condition for collisions
            leftBetween2 = True
        End If
        If Right2 >= EnemyLeft And Right2 <= EnemyRight Then
            rightBetween2 = True
        End If
        If Top2 >= EnemyTop And Top2 <= EnemyBottom Then
            topBetween2 = True
        End If
        If Bottom2 >= EnemyTop And Bottom2 <= EnemyBottom Then
            bottomBetween2 = True
        End If

        If leftBetween2 = True Or rightBetween2 = True Then         'Result for collision between enemy and missle2
            If topBetween2 = True Or bottomBetween2 = True Then
                Me.picMissle2.Top = Me.picPlayerShip.Top
                Me.picMissle2.Left = Me.picPlayerShip.Left + 5
                Me.picMissle2.Visible = False
                Me.tmrShot2.Stop()
                Me.picEnemy3.Visible = False
                My.Computer.Audio.Play(My.Resources.Explosion_SoundBible_com_2019248186, AudioPlayMode.Background)
                Me.tmrExplosion3.Start()
                Me.picExplosion3.Visible = True
                Me.picExplosion3.Left = Me.picEnemy3.Left
                Me.picExplosion3.Top = Me.picEnemy3.Top
                If intDifficulty = 1 Then
                    intScore += 50
                ElseIf intDifficulty = 2 Then
                    intScore += 75
                ElseIf intDifficulty = 3 Then
                    intScore += 100
                End If
                intCount += 1
                If intCount = 1 Then
                    Me.tmrEnemy3Respawn.Start()
                    Me.picEnemy3.Image = My.Resources.Enemy2
                    Me.picEnemy3.Left = Me.Width + Me.picEnemy3.Width
                ElseIf intCount = 2 Then
                    Me.tmrEnemy3Respawn.Start()
                    Me.picEnemy3.Image = My.Resources.Enemy3
                    Me.picEnemy3.Left = Me.Width + Me.picEnemy3.Width
                ElseIf intCount = 3 Then
                    intCount -= intCount
                    Me.picEnemy3.Image = My.Resources.Enemy1
                    Me.tmrEnemy3.Stop()
                    Enemy3Defeated = True
                End If
                Me.tmrEnemy3.Stop()
                Me.lblScore.Text = intScore
            End If
        End If

        Call Round_Complete()
        If Round_Complete() = True Then
            My.Computer.Audio.Play(My.Resources.Maniac_Single, AudioPlayMode.Background)
            Call BallStart()
            Me.lblRoundComplete.Visible = True
        End If

    End Sub

    Private Sub tmrEnemy4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemy4.Tick

        Me.picEnemy4.Left -= 9

        Static intCount As Integer = 0

        If Me.picEnemy4.Left - Me.picEnemy4.Width < Me.Width - Me.Width - Me.picEnemy4.Width Then
            Me.picEnemy4.Left = Me.Width - Me.picEnemy4.Width
        End If

        Dim Left As Long
        Dim Right As Long

        Dim EnemyRight1 As Long
        Dim EnemyLeft1 As Long

        Dim LeftBetween As Boolean
        Dim RightBetween As Boolean

        Left = Me.picPlayerShip.Left
        Right = Me.picPlayerShip.Left + Me.picPlayerShip.Width

        EnemyLeft1 = Me.picEnemy4.Left
        EnemyRight1 = Me.picEnemy4.Left + Me.picEnemy4.Width

        If Left >= EnemyLeft1 And Left <= EnemyRight1 Then
            LeftBetween = True
            If Right >= EnemyLeft1 And Right <= EnemyRight1 Then
                RightBetween = True
            End If
        End If
        If LeftBetween = True Or RightBetween = True Then
            If Me.picEnemyMissle4.Visible = False Then
                Me.picEnemyMissle4.Left = Me.picEnemy4.Left + 10
                Me.picEnemyMissle4.Top = Me.picEnemy4.Top
                Me.picEnemyMissle4.Visible = True
                Me.tmrEnemyShot4.Start()
            End If
        End If

        Dim Top1 As Long                             'Collision between enemy and player missle
        Dim Bottom1 As Long
        Dim Left1 As Long
        Dim Right1 As Long

        Dim Top2 As Long
        Dim Bottom2 As Long
        Dim Left2 As Long
        Dim Right2 As Long

        Dim EnemyTop As Long
        Dim EnemyBottom As Long
        Dim EnemyLeft As Long
        Dim EnemyRight As Long

        Dim leftBetween1 As Boolean
        Dim rightBetween1 As Boolean
        Dim topBetween1 As Boolean
        Dim bottomBetween1 As Boolean

        Dim leftBetween2 As Boolean
        Dim rightBetween2 As Boolean
        Dim topBetween2 As Boolean
        Dim bottomBetween2 As Boolean

        Top1 = Me.picMissle1.Top
        Bottom1 = Me.picMissle1.Bottom + Me.picMissle1.Height
        Left1 = Me.picMissle1.Left
        Right1 = Me.picMissle1.Left + Me.picMissle1.Width

        Top2 = Me.picMissle2.Top
        Bottom2 = Me.picMissle2.Bottom + Me.picMissle2.Height
        Left2 = Me.picMissle2.Left
        Right2 = Me.picMissle2.Left + Me.picMissle2.Width

        EnemyTop = Me.picEnemy4.Top - 30
        EnemyBottom = Me.picEnemy4.Bottom + Me.picEnemy4.Height - 30
        EnemyLeft = Me.picEnemy4.Left
        EnemyRight = Me.picEnemy4.Left + Me.picEnemy4.Width

        If Left1 >= EnemyLeft And Left1 <= EnemyRight Then          'Boolean conditions for collision
            leftBetween1 = True
        End If
        If Right1 >= EnemyLeft And Right1 <= EnemyRight Then
            rightBetween1 = True
        End If
        If Top1 >= EnemyTop And Top1 <= EnemyBottom Then
            topBetween1 = True
        End If
        If Bottom1 >= EnemyTop And Bottom1 <= EnemyBottom Then
            bottomBetween1 = True
        End If

        If leftBetween1 = True Or rightBetween1 = True Then         'Result for collision between enemy and missle1
            If topBetween1 = True Or bottomBetween1 = True Then
                Me.picMissle1.Top = Me.picPlayerShip.Top
                Me.picMissle1.Left = Me.picPlayerShip.Left + 5
                Me.picMissle1.Visible = False
                Me.tmrShot1.Stop()
                Me.picEnemy4.Visible = False
                My.Computer.Audio.Play(My.Resources.Explosion_SoundBible_com_2019248186, AudioPlayMode.Background)
                Me.tmrExplosion4.Start()
                Me.picExplosion4.Visible = True
                Me.picExplosion4.Left = Me.picEnemy4.Left
                Me.picExplosion4.Top = Me.picEnemy4.Top
                If intDifficulty = 1 Then
                    intScore += 50
                ElseIf intDifficulty = 2 Then
                    intScore += 75
                ElseIf intDifficulty = 3 Then
                    intScore += 100
                End If
                intCount += 1
                If intCount = 1 Then
                    Me.tmrEnemy4Respawn.Start()
                    Me.picEnemy4.Image = My.Resources.Enemy2
                    Me.picEnemy4.Left = Me.Width + Me.picEnemy4.Width
                ElseIf intCount = 2 Then
                    Me.tmrEnemy4Respawn.Start()
                    Me.picEnemy4.Image = My.Resources.Enemy3
                    Me.picEnemy4.Left = Me.Width + Me.picEnemy4.Width
                ElseIf intCount = 3 Then
                    intCount -= intCount
                    Me.picEnemy4.Image = My.Resources.Enemy1
                    Me.tmrEnemy4.Stop()
                    Enemy4Defeated = True
                End If
                Me.tmrEnemy4.Stop()
                Me.lblScore.Text = intScore
            End If
        End If

        If Left2 >= EnemyLeft And Left2 <= EnemyRight Then          'Boolean condition for collisions
            leftBetween2 = True
        End If
        If Right2 >= EnemyLeft And Right2 <= EnemyRight Then
            rightBetween2 = True
        End If
        If Top2 >= EnemyTop And Top2 <= EnemyBottom Then
            topBetween2 = True
        End If
        If Bottom2 >= EnemyTop And Bottom2 <= EnemyBottom Then
            bottomBetween2 = True
        End If

        If leftBetween2 = True Or rightBetween2 = True Then         'Result for collision between enemy and missle2
            If topBetween2 = True Or bottomBetween2 = True Then
                Me.picMissle2.Top = Me.picPlayerShip.Top
                Me.picMissle2.Left = Me.picPlayerShip.Left + 5
                Me.picMissle2.Visible = False
                Me.tmrShot2.Stop()
                Me.picEnemy4.Visible = False
                My.Computer.Audio.Play(My.Resources.Explosion_SoundBible_com_2019248186, AudioPlayMode.Background)
                Me.tmrExplosion4.Start()
                Me.picExplosion4.Visible = True
                Me.picExplosion4.Left = Me.picEnemy4.Left
                Me.picExplosion4.Top = Me.picEnemy4.Top
                If intDifficulty = 1 Then
                    intScore += 50
                ElseIf intDifficulty = 2 Then
                    intScore += 75
                ElseIf intDifficulty = 3 Then
                    intScore += 100
                End If
                intCount += 1
                If intCount = 1 Then
                    Me.tmrEnemy4Respawn.Start()
                    Me.picEnemy4.Image = My.Resources.Enemy2
                    Me.picEnemy4.Left = Me.Width + Me.picEnemy4.Width
                ElseIf intCount = 2 Then
                    Me.tmrEnemy4Respawn.Start()
                    Me.picEnemy4.Image = My.Resources.Enemy3
                    Me.picEnemy4.Left = Me.Width + Me.picEnemy4.Width
                ElseIf intCount = 3 Then
                    intCount -= intCount
                    Me.picEnemy4.Image = My.Resources.Enemy1
                    Me.tmrEnemy4.Stop()
                    Enemy4Defeated = True
                End If
                Me.tmrEnemy4.Stop()
                Me.lblScore.Text = intScore
            End If
        End If

        Call Round_Complete()
        If Round_Complete() = True Then
            My.Computer.Audio.Play(My.Resources.Maniac_Single, AudioPlayMode.Background)
            Call BallStart()
            Me.lblRoundComplete.Visible = True
        End If

    End Sub

    Private Sub tmrShot1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShot1.Tick

        Me.picMissle1.Top -= 10

        If Me.picMissle1.Top < 0 Then
            Me.picMissle1.Visible = False
            Me.tmrShot1.Stop()
        End If

    End Sub

    Private Sub tmrShot2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShot2.Tick

        Me.picMissle2.Top -= 10

        If Me.picMissle2.Top < 0 Then
            Me.picMissle2.Visible = False
            Me.tmrShot2.Stop()
        End If

    End Sub

    Private Sub lblCampaign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCampaign.Click

        BackgroundImage = Nothing

        Me.lblBeacon.BackColor = Color.Black
        Me.lblBeacon.ForeColor = Color.White

        Me.lblCampaign.Visible = False
        Me.lblInstructions.Visible = False

        Me.lblEasy.Visible = True
        Me.lblNormal.Visible = True
        Me.lblHardcore.Visible = True
        Me.lblBack.Visible = True

        Me.tmrHighScoreScroll.Stop()
        Me.tmrHighScoreScroll.Enabled = False
        Me.tmrPlayerHealthTracker.Start()

        Me.lstHS.Enabled = False

        intLevel = 1
        Me.lblLevel.Text = intLevel

    End Sub

    Private Sub lblCampaign_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCampaign.MouseEnter

        Me.lblCampaign.BackColor = Color.White
        Me.lblCampaign.ForeColor = Color.Black

    End Sub

    Private Sub lblCampaign_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCampaign.MouseLeave

        Me.lblCampaign.BackColor = Color.Black
        Me.lblCampaign.ForeColor = Color.White

    End Sub

    Private Sub lblRoundComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRoundComplete.Click

        Me.lblRoundComplete.Visible = False

        My.Computer.Audio.Stop()
        Me.tmrBossFireSequence.Stop()
        Me.tmrBossLaser.Stop()
        Me.tmrLaserFlash.Stop()
        Me.tmrLaserPosition.Stop()

        intLevel += 1
        Me.lblLevel.Text = intLevel

        If intLevel <> 10 Or 20 Or 30 Then
            Call Begin()
        End If

        If intLevel = 10 Then
            Call Boss1_Event()
        ElseIf intLevel = 20 Then
            Call Boss1_Event()
        ElseIf intLevel = 30 Then
            Call Boss1_Event()
        ElseIf intLevel = 40 Then
            Call Boss1_Event()
        End If

        If intLevel = 1 Then
            If intDifficulty = 1 Then
                intPlayerHealth = 150
            ElseIf intDifficulty = 2 Then
                intPlayerHealth = 100
            ElseIf intDifficulty = 3 Then
                intPlayerHealth = 50
            End If
        End If

    End Sub

    Private Sub lblRoundComplete_Mouse_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRoundComplete.MouseEnter

        Me.lblRoundComplete.BackColor = Color.White
        Me.lblRoundComplete.ForeColor = Color.Black

    End Sub

    Private Sub lblRoundComplete_Mouse_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblRoundComplete.MouseLeave

        Me.lblRoundComplete.BackColor = Color.Black
        Me.lblRoundComplete.ForeColor = Color.White

    End Sub

    Private Sub ReadyButton_Mouse_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReady.MouseEnter

        Me.lblReady.BackColor = Color.White
        Me.lblReady.ForeColor = Color.Black

    End Sub

    Private Sub ReadyButton_Mouse_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReady.MouseLeave

        Me.lblReady.BackColor = Color.Black
        Me.lblReady.ForeColor = Color.White

    End Sub

    Private Sub lblReady_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReady.Click

        Me.lblReady.Visible = False
        Me.lblBack.Visible = False
        Me.lblBeacon.Visible = False
        Me.lblCampaign.Visible = False

        Me.lblScore.Visible = True
        Me.lblPreScore.Visible = True
        Me.lblLevel.Visible = True
        Me.lblPreLevel.Visible = True
        Me.lblPreHealth.Visible = True
        Me.lblHealth.Visible = True

        Me.picLife1.Visible = True
        Me.picLife2.Visible = True

        Call Begin()
        intScore = 0

    End Sub

    Private Sub RestartGameToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartGameToolStripMenuItem1.Click

        Application.Restart()

    End Sub

    Private Sub ExitGameToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitGameToolStripMenuItem1.Click

        Application.Exit()

    End Sub

    Private Sub tmrEnemyShot1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemyShot1.Tick

        Me.picEnemyMissle1.Top += 5

        If Me.picEnemyMissle1.Top > Me.Height Then
            Me.tmrEnemyShot1.Stop()
            Me.picEnemyMissle1.Visible = False
        End If

        Dim Top As Long
        Dim Bottom As Long
        Dim Left As Long
        Dim Right As Long

        Dim EnemyMissleTop As Long
        Dim EnemyMissleBottom As Long
        Dim EnemyMissleLeft As Long
        Dim EnemyMissleRight As Long

        Dim leftBetween As Boolean
        Dim rightBetween As Boolean
        Dim topBetween As Boolean
        Dim bottomBetween As Boolean

        Top = Me.picPlayerShip.Top
        Bottom = Me.picPlayerShip.Bottom + Me.picPlayerShip.Height
        Left = Me.picPlayerShip.Left
        Right = Me.picPlayerShip.Left + Me.picPlayerShip.Width

        EnemyMissleTop = Me.picEnemyMissle1.Top
        EnemyMissleBottom = Me.picEnemyMissle1.Bottom + Me.picEnemyMissle1.Height
        EnemyMissleLeft = Me.picEnemyMissle1.Left
        EnemyMissleRight = Me.picEnemyMissle1.Left + Me.picEnemyMissle1.Width

        If EnemyMissleLeft >= Left And EnemyMissleLeft <= Right Then          'Boolean conditions for collision
            leftBetween = True
        End If
        If EnemyMissleRight >= Left And EnemyMissleRight <= Right Then
            rightBetween = True
        End If
        If EnemyMissleTop >= Top And EnemyMissleTop <= Bottom Then
            topBetween = True
        End If
        If EnemyMissleBottom >= Top And EnemyMissleBottom <= Bottom Then
            bottomBetween = True
        End If

        If leftBetween = True Or rightBetween = True Then
            If topBetween = True Or bottomBetween = True Then
                Me.picEnemyMissle1.Visible = False
                Me.tmrEnemyShot1.Stop()
                Me.tmrPlayerHit.Start()
                intPlayerHealth -= 25
            End If
        End If

    End Sub

    Private Sub tmrEnemyShot2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemyShot2.Tick

        Me.picEnemyMissle2.Top += 5

        If Me.picEnemyMissle2.Top > Me.Height Then
            Me.tmrEnemyShot2.Stop()
            Me.picEnemyMissle2.Visible = False
        End If

        Dim Top As Long
        Dim Bottom As Long
        Dim Left As Long
        Dim Right As Long

        Dim EnemyMissleTop As Long
        Dim EnemyMissleBottom As Long
        Dim EnemyMissleLeft As Long
        Dim EnemyMissleRight As Long

        Dim leftBetween As Boolean
        Dim rightBetween As Boolean
        Dim topBetween As Boolean
        Dim bottomBetween As Boolean

        Top = Me.picPlayerShip.Top
        Bottom = Me.picPlayerShip.Bottom + Me.picPlayerShip.Height
        Left = Me.picPlayerShip.Left
        Right = Me.picPlayerShip.Left + Me.picPlayerShip.Width

        EnemyMissleTop = Me.picEnemyMissle2.Top
        EnemyMissleBottom = Me.picEnemyMissle2.Bottom + Me.picEnemyMissle2.Height
        EnemyMissleLeft = Me.picEnemyMissle2.Left
        EnemyMissleRight = Me.picEnemyMissle2.Left + Me.picEnemyMissle2.Width

        If EnemyMissleLeft >= Left And EnemyMissleLeft <= Right Then          'Boolean conditions for collision
            leftBetween = True
        End If
        If EnemyMissleRight >= Left And EnemyMissleRight <= Right Then
            rightBetween = True
        End If
        If EnemyMissleTop >= Top And EnemyMissleTop <= Bottom Then
            topBetween = True
        End If
        If EnemyMissleBottom >= Top And EnemyMissleBottom <= Bottom Then
            bottomBetween = True
        End If

        If leftBetween = True Or rightBetween = True Then
            If topBetween = True Or bottomBetween = True Then
                Me.picEnemyMissle2.Visible = False
                Me.tmrEnemyShot2.Stop()
                Me.tmrPlayerHit.Start()
                intPlayerHealth -= 25
            End If
        End If

    End Sub

    Private Sub tmrEnemyShot3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemyShot3.Tick

        Me.picEnemyMissle3.Top += 5

        If Me.picEnemyMissle3.Top > Me.Height Then
            Me.tmrEnemyShot3.Stop()
            Me.picEnemyMissle3.Visible = False
        End If

        Dim Top As Long
        Dim Bottom As Long
        Dim Left As Long
        Dim Right As Long

        Dim EnemyMissleTop As Long
        Dim EnemyMissleBottom As Long
        Dim EnemyMissleLeft As Long
        Dim EnemyMissleRight As Long

        Dim leftBetween As Boolean
        Dim rightBetween As Boolean
        Dim topBetween As Boolean
        Dim bottomBetween As Boolean

        Top = Me.picPlayerShip.Top
        Bottom = Me.picPlayerShip.Bottom + Me.picPlayerShip.Height
        Left = Me.picPlayerShip.Left
        Right = Me.picPlayerShip.Left + Me.picPlayerShip.Width

        EnemyMissleTop = Me.picEnemyMissle3.Top
        EnemyMissleBottom = Me.picEnemyMissle3.Bottom + Me.picEnemyMissle3.Height
        EnemyMissleLeft = Me.picEnemyMissle3.Left
        EnemyMissleRight = Me.picEnemyMissle3.Left + Me.picEnemyMissle3.Width

        If EnemyMissleLeft >= Left And EnemyMissleLeft <= Right Then          'Boolean conditions for collision
            leftBetween = True
        End If
        If EnemyMissleRight >= Left And EnemyMissleRight <= Right Then
            rightBetween = True
        End If
        If EnemyMissleTop >= Top And EnemyMissleTop <= Bottom Then
            topBetween = True
        End If
        If EnemyMissleBottom >= Top And EnemyMissleBottom <= Bottom Then
            bottomBetween = True
        End If

        If leftBetween = True Or rightBetween = True Then
            If topBetween = True Or bottomBetween = True Then
                Me.picEnemyMissle3.Visible = False
                Me.tmrEnemyShot3.Stop()
                Me.tmrPlayerHit.Start()
                intPlayerHealth -= 25
            End If
        End If

    End Sub

    Private Sub tmrEnemyShot4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemyShot4.Tick

        Me.picEnemyMissle4.Top += 5

        If Me.picEnemyMissle4.Top > Me.Height Then
            Me.tmrEnemyShot4.Stop()
            Me.picEnemyMissle4.Visible = False
        End If

        Dim Top As Long
        Dim Bottom As Long
        Dim Left As Long
        Dim Right As Long

        Dim EnemyMissleTop As Long
        Dim EnemyMissleBottom As Long
        Dim EnemyMissleLeft As Long
        Dim EnemyMissleRight As Long

        Dim leftBetween As Boolean
        Dim rightBetween As Boolean
        Dim topBetween As Boolean
        Dim bottomBetween As Boolean

        Top = Me.picPlayerShip.Top
        Bottom = Me.picPlayerShip.Bottom + Me.picPlayerShip.Height
        Left = Me.picPlayerShip.Left
        Right = Me.picPlayerShip.Left + Me.picPlayerShip.Width

        EnemyMissleTop = Me.picEnemyMissle4.Top
        EnemyMissleBottom = Me.picEnemyMissle4.Bottom + Me.picEnemyMissle4.Height
        EnemyMissleLeft = Me.picEnemyMissle4.Left
        EnemyMissleRight = Me.picEnemyMissle4.Left + Me.picEnemyMissle4.Width

        If EnemyMissleLeft >= Left And EnemyMissleLeft <= Right Then          'Boolean conditions for collision
            leftBetween = True
        End If
        If EnemyMissleRight >= Left And EnemyMissleRight <= Right Then
            rightBetween = True
        End If
        If EnemyMissleTop >= Top And EnemyMissleTop <= Bottom Then
            topBetween = True
        End If
        If EnemyMissleBottom >= Top And EnemyMissleBottom <= Bottom Then
            bottomBetween = True
        End If

        If leftBetween = True Or rightBetween = True Then
            If topBetween = True Or bottomBetween = True Then
                Me.picEnemyMissle4.Visible = False
                Me.tmrEnemyShot4.Stop()
                Me.tmrPlayerHit.Start()
                intPlayerHealth -= 25
            End If
        End If

    End Sub

    Private Sub lblEasy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEasy.Click

        intDifficulty = 1

        Me.tmrEnemy1.Interval = 20
        Me.tmrEnemy2.Interval = 20
        Me.tmrEnemy3.Interval = 20
        Me.tmrEnemy4.Interval = 20

        Me.tmrEnemyShot1.Interval = 20
        Me.tmrEnemyShot2.Interval = 20
        Me.tmrEnemyShot3.Interval = 20
        Me.tmrEnemyShot4.Interval = 20

        Me.tmrBoss1.Interval = 40

        Me.tmrBossShot1.Interval = 40
        Me.tmrBossShot2.Interval = 40
        Me.tmrBossShot3.Interval = 40
        Me.tmrBossShot4.Interval = 40

        Me.lblEasy.Visible = False
        Me.lblNormal.Visible = False
        Me.lblHardcore.Visible = False
        Me.lblInstructions.Hide()
        Me.lblReady.Visible = True
        Me.lblBack.Visible = True

        intPlayerHealth = 150

    End Sub

    Private Sub lblNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNormal.Click

        intDifficulty = 2

        Me.tmrEnemy1.Interval = 20
        Me.tmrEnemy2.Interval = 20
        Me.tmrEnemy3.Interval = 20
        Me.tmrEnemy4.Interval = 20

        Me.tmrEnemyShot1.Interval = 10
        Me.tmrEnemyShot2.Interval = 10
        Me.tmrEnemyShot3.Interval = 10
        Me.tmrEnemyShot4.Interval = 10

        Me.tmrBossShot1.Interval = 25
        Me.tmrBossShot2.Interval = 25
        Me.tmrBossShot3.Interval = 25
        Me.tmrBossShot4.Interval = 25

        Me.lblEasy.Visible = False
        Me.lblNormal.Visible = False
        Me.lblHardcore.Visible = False

        Me.lblEasy.Visible = False
        Me.lblNormal.Visible = False
        Me.lblHardcore.Visible = False
        Me.lblInstructions.Hide()
        Me.lblReady.Visible = True
        Me.lblBack.Visible = True

        intPlayerHealth = 100

    End Sub

    Private Sub lblHardcore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHardcore.Click

        intDifficulty = 3

        Me.tmrEnemy1.Interval = 1
        Me.tmrEnemy2.Interval = 1
        Me.tmrEnemy3.Interval = 1
        Me.tmrEnemy4.Interval = 1

        Me.tmrEnemyShot1.Interval = 1
        Me.tmrEnemyShot2.Interval = 1
        Me.tmrEnemyShot3.Interval = 1
        Me.tmrEnemyShot4.Interval = 1

        Me.tmrBossShot1.Interval = 10
        Me.tmrBossShot2.Interval = 10
        Me.tmrBossShot3.Interval = 10
        Me.tmrBossShot4.Interval = 10

        Me.lblEasy.Visible = False
        Me.lblNormal.Visible = False
        Me.lblHardcore.Visible = False
        Me.lblInstructions.Hide()
        Me.lblReady.Visible = True
        Me.lblBack.Visible = True

        intPlayerHealth = 50

    End Sub

    Sub Easy_Button_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEasy.MouseEnter

        Me.lblEasy.BackColor = Color.White
        Me.lblEasy.ForeColor = Color.Black

    End Sub

    Sub Easy_Button_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEasy.MouseLeave

        Me.lblEasy.BackColor = Color.Black
        Me.lblEasy.ForeColor = Color.White

    End Sub

    Sub Normal_Button_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNormal.MouseEnter

        Me.lblNormal.BackColor = Color.White
        Me.lblNormal.ForeColor = Color.Black

    End Sub

    Sub Normal_Button_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNormal.MouseLeave

        Me.lblNormal.BackColor = Color.Black
        Me.lblNormal.ForeColor = Color.White

    End Sub

    Sub Hardcore_Button_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHardcore.MouseEnter

        Me.lblHardcore.BackColor = Color.White
        Me.lblHardcore.ForeColor = Color.Black

    End Sub

    Sub Hardcore_Button_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHardcore.MouseLeave

        Me.lblHardcore.BackColor = Color.Black
        Me.lblHardcore.ForeColor = Color.White

    End Sub

    Private Sub lblBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.Click

        If Me.lblReady.Visible = True Then
            Me.lblEasy.Visible = True
            Me.lblNormal.Visible = True
            Me.lblHardcore.Visible = True
            Me.lblReady.Visible = False
        ElseIf Me.lblEasy.Visible = True Then
            Me.lblCampaign.Visible = True
            Me.lblInstructions.Visible = True
            Me.BackgroundImage = My.Resources.EPIC
            Me.lblBeacon.BackColor = Color.Transparent
            Me.lblBeacon.ForeColor = Color.Black
            Me.lblBack.Visible = False
            Me.lblHardcore.Visible = False
            Me.lblNormal.Visible = False
            Me.lblEasy.Visible = False
        End If

    End Sub

    Private Sub lblBack_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.MouseEnter

        Me.lblBack.BackColor = Color.White
        Me.lblBack.ForeColor = Color.Black

    End Sub

    Private Sub lblBack_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBack.MouseLeave

        Me.lblBack.BackColor = Color.Black
        Me.lblBack.ForeColor = Color.White

    End Sub

    Private Sub tmrBoss1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBoss1.Tick

        Static intCount As Integer = 0

        If Me.picBoss1.Top < 50 Then
            Me.picBossLaser.Visible = False
            Me.picBoss1.Top += 1
        ElseIf intCount = 0 Then
            Me.picBoss1.Left -= 4
        ElseIf intCount = 1 Then
            Me.picBoss1.Left += 4
        Else
            Me.picBoss1.Left -= 4
        End If

        If Me.picBoss1.Left <= 0 Then
            intCount += 1
        ElseIf Me.picBoss1.Left >= Me.Width - Me.picBoss1.Width Then
            intCount += 1
        ElseIf intCount >= 2 Then
            intCount -= intCount
        End If

        If Me.picMissle1.Bounds.IntersectsWith(Me.picBoss1.Bounds) Then
            intBossHealth -= 1
            Me.picMissle1.Visible = False
            Me.tmrShot1.Stop()
            Me.picMissle1.Top = Me.picPlayerShip.Top
            Me.tmrBossHit.Start()
        ElseIf Me.picMissle2.Bounds.IntersectsWith(Me.picBoss1.Bounds) Then
            intBossHealth -= 1
            Me.picMissle2.Visible = False
            Me.tmrShot2.Stop()
            Me.picMissle2.Top = Me.picPlayerShip.Top
            Me.tmrBossHit.Start()
        End If

        Call Boss_Defeat()

        If intBossHealth <= 0 Then
            Me.picBoss1.Visible = False
            Me.picBoss1.Top = Me.Height + Me.picBoss1.Height
        End If

        If Boss_Defeat() = True Then
            If intDifficulty = 1 Then
                intScore += 2000
            ElseIf intDifficulty = 2 Then
                intScore += 4000
            ElseIf intDifficulty = 3 Then
                intScore += 6000
            End If
            My.Computer.Audio.Play(My.Resources.Explosion_SoundBible_com_2019248186, AudioPlayMode.WaitToComplete)
            My.Computer.Audio.Play(My.Resources.Maniac_Single, AudioPlayMode.Background)
            Call BallStart()
            Me.picBossLaser.Visible = False
            Me.lblRoundComplete.Visible = True
            Me.tmrBoss1.Enabled = False
        End If

    End Sub

    Private Sub TimerBossShot1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBossShot1.Tick

        Me.picBossShot1.Top += 5

        If Me.picBossShot1.Top > Me.Height + (Me.picBossShot1.Height + 10) Then
            Me.tmrBossShot1.Stop()
            Me.picBossShot1.Visible = False
        End If

        If Me.picBossShot1.Bounds.IntersectsWith(Me.picPlayerShip.Bounds) Then
            If intDifficulty = 1 Then
                Me.picBossShot1.Visible = False
                intPlayerHealth -= 100
            ElseIf intDifficulty = 2 Then
                Me.picBossShot1.Visible = False
                intPlayerHealth -= 50
            ElseIf intDifficulty = 3 Then
                intPlayerHealth -= intPlayerHealth
                Me.picPlayerShip.Visible = False
                Me.picBossShot1.Visible = False
                Call PlayerDeath()
                Call Boss1_Event()
            End If
        End If

    End Sub

    Private Sub TimerBossShot2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBossShot2.Tick

        Me.picBossShot2.Top += 5

        If Me.picBossShot2.Top > Me.Height Then
            Me.tmrBossShot2.Stop()
            Me.picBossShot2.Visible = False
        End If

        If Me.picBossShot2.Bounds.IntersectsWith(Me.picPlayerShip.Bounds) Then
            If intDifficulty = 1 Then
                Me.picBossShot2.Visible = False
                intPlayerHealth -= 100
            ElseIf intDifficulty = 2 Then
                Me.picBossShot2.Visible = False
                intPlayerHealth -= 50
            ElseIf intDifficulty = 3 Then
                Me.picPlayerShip.Visible = False
                Me.picBossShot2.Visible = False
                Call PlayerDeath()
                Call Boss1_Event()
            End If
        End If

    End Sub

    Private Sub TimerBossShot3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBossShot3.Tick

        Me.picBossShot3.Top += 5

        If Me.picBossShot3.Top > Me.Height Then
            Me.tmrBossShot3.Stop()
            Me.picBossShot3.Visible = False
        End If

        If Me.picBossShot3.Bounds.IntersectsWith(Me.picPlayerShip.Bounds) Then
            If intDifficulty = 1 Then
                Me.picBossShot3.Visible = False
                intPlayerHealth -= 100
            ElseIf intDifficulty = 2 Then
                Me.picBossShot3.Visible = False
                intPlayerHealth -= 50
            ElseIf intDifficulty = 3 Then
                Me.picPlayerShip.Visible = False
                Me.picBossShot3.Visible = False
                Call PlayerDeath()
                Call Boss1_Event()
            End If
        End If

    End Sub

    Private Sub TimerBossShot4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBossShot4.Tick

        Me.picBossShot4.Top += 5

        If Me.picBossShot4.Top > Me.Height Then
            Me.tmrBossShot4.Stop()
            Me.picBossShot4.Visible = False
        End If

        If Me.picBossShot4.Bounds.IntersectsWith(Me.picPlayerShip.Bounds) Then
            If intDifficulty = 1 Then
                Me.picBossShot4.Visible = False
                intPlayerHealth -= 100
            ElseIf intDifficulty = 2 Then
                Me.picBossShot4.Visible = False
                intPlayerHealth -= 50
            ElseIf intDifficulty = 3 Then
                Me.picPlayerShip.Visible = False
                Me.picBossShot4.Visible = False
                Call PlayerDeath()
                Call Boss1_Event()
            End If
        End If

    End Sub

    Private Sub tmrBossFireSequence_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBossFireSequence.Tick

        Static intCount As Integer = 0
        Static intLaserCount As Integer = 0
        intCount += 1

        If intCount = 1 Then
            If Me.picBossShot1.Visible = False Then
                Me.picBossShot1.Left = Me.picBoss1.Left
                Me.picBossShot1.Top = Me.picBoss1.Bottom
                Me.picBossShot1.Visible = True
                Me.tmrBossShot1.Start()
            End If
        ElseIf intCount = 2 Then
            If Me.picBossShot2.Visible = False Then
                Me.picBossShot2.Left = Me.picBoss1.Left + 20
                Me.picBossShot2.Top = Me.picBoss1.Bottom
                Me.picBossShot2.Visible = True
                Me.tmrBossShot2.Start()
            End If
        ElseIf intCount = 3 Then
            If Me.picBossShot3.Visible = False Then
                Me.picBossShot3.Left = Me.picBoss1.Right - 20
                Me.picBossShot3.Top = Me.picBoss1.Bottom
                Me.picBossShot3.Visible = True
                Me.tmrBossShot3.Start()
            End If
        ElseIf intCount = 4 Then
            If Me.picBossShot4.Visible = False Then
                Me.picBossShot4.Left = Me.picBoss1.Right
                Me.picBossShot4.Top = Me.picBoss1.Bottom
                Me.picBossShot4.Visible = True
                Me.tmrBossShot4.Start()
                intLaserCount += 1
                intCount -= intCount
            End If
        End If

        If intCount > 4 Then
            intCount -= intCount
            intLaserCount += 1
        End If

        If intLaserCount = 4 Then
            My.Computer.Audio.Play(My.Resources.Boss_Laser, AudioPlayMode.Background)
        End If

        If intLaserCount = 5 Then
            My.Computer.Audio.Play(My.Resources.Boss_Laser, AudioPlayMode.Background)
            Me.tmrBossLaser.Start()
            Me.tmrLaserPosition.Start()
            Me.picBossLaser.Visible = True
            intLaserCount -= intLaserCount
        End If

        Call PlayerStatus()
        If PlayerStatus() = True Then
            intCount -= intCount
            intLaserCount -= intCount
        End If

        Call Boss_Defeat()
        If Boss_Defeat() = True Then
            intCount -= intCount
            Me.tmrBossFireSequence.Stop()
            Me.tmrBossFireSequence.Enabled = False
        End If

    End Sub

    Private Sub tmrLaserPosition_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLaserPosition.Tick

        Me.picBossLaser.Left = Me.picBoss1.Left + (Me.picBoss1.Width / 2) - Me.picBossLaser.Width + 10
        Me.picBossLaser.Top = Me.picBoss1.Top + (Me.picBoss1.Height / 2)

    End Sub

    Private Sub tmrBossLaser_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBossLaser.Tick

        Static intCount As Integer = 0
        intCount += 1

        Me.tmrLaserFlash.Enabled = True
        Me.tmrLaserFlash.Start()

        If intCount = 7 Then
            My.Computer.Audio.Stop()
            Me.picBossLaser.Visible = False
            Me.tmrLaserPosition.Stop()
            Me.picBossLaser.Top = -100
            Me.tmrBossLaser.Stop()
            Me.tmrLaserFlash.Stop()
            intCount -= intCount
        End If

        If Me.picBossLaser.Bounds.IntersectsWith(Me.picPlayerShip.Bounds) Then
            Me.picPlayerShip.Visible = False
            Me.tmrLaserPosition.Stop()
            Me.picBossLaser.Visible = False
            intCount -= intCount
            Call PlayerDeath()
            Call Boss1_Event()
        End If

        Call PlayerStatus()
        If PlayerStatus() = True Then
            intCount -= intCount
        End If

        Call Boss_Defeat()
        If Boss_Defeat() = True Then
            intCount -= intCount
            Me.tmrBoss1.Stop()
            Me.tmrLaserPosition.Stop()
            Me.tmrBossLaser.Stop()
        End If

    End Sub

    Private Sub tmrFlash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFlash.Tick

        Static intCount As Integer = 0

        intCount += 1

        If intCount = 5 Then
            Me.picFlash.Visible = False
            intCount -= intCount
            Me.tmrFlash.Stop()
        End If

    End Sub

    Private Sub tmrLaserFlash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLaserFlash.Tick

        Static intCount As Integer = 0
        intCount += 1

        If Me.picBossLaser.Bounds.IntersectsWith(Me.picPlayerShip.Bounds) Then
            Me.tmrLaserPosition.Stop()
            intCount -= intCount
            Me.picBossLaser.Visible = False
            Call PlayerDeath()
            Call Boss1_Event()
        End If

        If intCount = 0 Then
            Me.picBossLaser.Image = My.Resources.Laser
        ElseIf intCount = 1 Then
            Me.picBossLaser.Image = My.Resources.FINAL_BEAM
        ElseIf intCount = 2 Then
            Me.picBossLaser.Image = My.Resources.Laser
            intCount -= intCount
        End If

    End Sub

    Private Sub lblInstructions_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblInstructions.Click

        Game.Instructions.Show()

        Me.lblCampaign.Visible = True

    End Sub

    Private Sub lblInstructions_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblInstructions.MouseEnter

        Me.lblInstructions.BackColor = Color.White
        Me.lblInstructions.ForeColor = Color.Black

    End Sub

    Private Sub lblInstructions_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblInstructions.MouseLeave

        Me.lblInstructions.BackColor = Color.Black
        Me.lblInstructions.ForeColor = Color.White

    End Sub

    Private Sub tmrExplosion1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrExplosion1.Tick

        Static intCount As Integer = 0
        intCount += 1

        If intCount = 1 Then
            Me.picExplosion1.Image = My.Resources.Explosion1
        ElseIf intCount = 2 Then
            Me.picExplosion1.Image = My.Resources.Explosion2
        ElseIf intCount = 3 Then
            Me.picExplosion1.Image = My.Resources.Explosion3
        ElseIf intCount = 4 Then
            Me.picExplosion1.Image = My.Resources.Explosion4
        ElseIf intCount = 5 Then
            Me.picExplosion1.Image = My.Resources.Explosion5
        ElseIf intCount = 6 Then
            Me.picExplosion1.Image = My.Resources.Explosion6
        ElseIf intCount = 7 Then
            Me.picExplosion1.Image = My.Resources.Explosion7
        ElseIf intCount = 8 Then
            Me.picExplosion1.Image = My.Resources.Explosion8
        ElseIf intCount = 9 Then
            Me.picExplosion1.Image = My.Resources.Explosion9
        ElseIf intCount = 10 Then
            Me.picExplosion1.Image = My.Resources.Explosion10
        ElseIf intCount = 11 Then
            Me.picExplosion1.Image = My.Resources.Explosion11
        ElseIf intCount = 12 Then
            Me.picExplosion1.Image = My.Resources.Explosion12
        ElseIf intCount = 13 Then
            Me.picExplosion1.Image = My.Resources.Explosion13
        ElseIf intCount = 14 Then
            Me.picExplosion1.Image = My.Resources.Explosion14
        ElseIf intCount = 15 Then
            Me.picExplosion1.Image = My.Resources.Explosion15
        ElseIf intCount = 16 Then
            Me.picExplosion1.Image = My.Resources.Explosion16
        ElseIf intCount = 17 Then
            Me.picExplosion1.Image = My.Resources.explosion17
        ElseIf intCount = 18 Then
            Me.picExplosion1.Image = My.Resources.Explosion18
        ElseIf intCount = 19 Then
            Me.picExplosion1.Image = My.Resources.Explosion19
        ElseIf intCount = 20 Then
            Me.picExplosion1.Image = My.Resources.Explosion20
        ElseIf intCount = 21 Then
            Me.picExplosion1.Image = My.Resources.Explosion21
        ElseIf intCount = 22 Then
            Me.picExplosion1.Image = My.Resources.Explosion22
        ElseIf intCount = 23 Then
            Me.picExplosion1.Image = My.Resources.Explosion23
        ElseIf intCount = 24 Then
            Me.picExplosion1.Image = My.Resources.Explosion24
        ElseIf intCount = 25 Then
            Me.picExplosion1.Visible = False
            Me.tmrExplosion1.Stop()
            intCount -= intCount
        End If


    End Sub

    Private Sub tmrPlayerHealthTracker_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayerHealthTracker.Tick

        Dim intCounter As Integer

        If intDifficulty = 1 Then
            intCounter = 150
        ElseIf intDifficulty = 2 Then
            intCounter = 100
        ElseIf intDifficulty = 3 Then
            intCounter = 50
        End If

        Me.lblHealth.Text = ((intPlayerHealth / intCounter) * 100) & " " & "%"

        If intPlayerHealth <= 0 Then
            Me.picPlayerShip.Visible = False
            Call PlayerDeath()
        End If

        If Me.lblBeacon.Visible = False Then
            If Me.lblHighScores.Visible = False Then
                If intLives = 3 Then
                    Me.picLife1.Visible = True
                    Me.picLife2.Visible = True
                ElseIf intLives = 2 Then
                    Me.picLife1.Visible = False
                    Me.picLife2.Visible = True
                ElseIf intLives = 1 Then
                    Me.picLife1.Visible = False
                    Me.picLife2.Visible = False
                ElseIf intLives = 0 Then
                    intPlayerHealth = 1
                    Call GameOver()
                End If
            End If
        End If

        Me.lblScore.Text = intScore

        Me.lblPreHealth.Left = Me.Width - 175
        Me.lblPreHealth.Top = Me.Height - 70
        Me.lblHealth.Left = Me.Width - 100
        Me.lblHealth.Top = Me.Height - 70

        Me.picLife2.Left = 35
        Me.picLife2.Top = Me.Height - 70
        Me.picLife1.Left = 15
        Me.picLife1.Top = Me.Height - 70

        Me.lblPreLevel.Top = 10
        Me.lblLevel.Top = 10
        Me.lblPreScore.Top = 10
        Me.lblScore.Top = 10
        Me.lblPreLevel.Left = Me.Width - 200
        Me.lblLevel.Left = Me.Width - 150
        Me.lblPreScore.Left = Me.Width - 100
        Me.lblScore.Left = Me.Width - 50

    End Sub

    Private Sub tmrPlayerHit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPlayerHit.Tick

        Static intCount As Integer = 0
        intCount += 1

        If intCount = 1 Then
            Me.picPlayerShip.Image = My.Resources.whitebox
        ElseIf intCount = 2 Then
            Me.picPlayerShip.Image = My.Resources.SpaceShip
            intCount -= intCount
            Me.tmrPlayerHit.Stop()
        End If

    End Sub

    Private Sub lblGameOver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGameOver.Click

        Me.lblGameOver.Visible = False
        Call CheckHS()
        Me.lstHS.Enabled = True
        Me.lblHighScores.Visible = True
        Me.lblContinue.Visible = True

    End Sub

    Private Sub lblGameOver_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGameOver.MouseEnter

        Me.lblGameOver.BackColor = Color.White
        Me.lblGameOver.ForeColor = Color.Black

    End Sub

    Private Sub lblGameOver_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGameOver.MouseLeave

        Me.lblGameOver.BackColor = Color.Black
        Me.lblGameOver.ForeColor = Color.White

    End Sub

    Private Sub tmrBossHit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBossHit.Tick

        Static intCount As Integer = 0
        intCount += 1

        If intCount = 1 Then
            Me.picBoss1.Image = My.Resources.whitebox
        ElseIf intCount = 2 Then
            Me.picBoss1.Image = My.Resources.Blue_Boss
            intCount -= intCount
            Me.tmrBossHit.Stop()
        End If

    End Sub

    Sub CheckHS()

        Dim strName As String
        Dim fs As New FileStream("Score.txt", FileMode.OpenOrCreate, FileAccess.Read)
        Dim textfile As New StreamReader(fs)
        Dim myhs(4) As Highscore
        Dim i As Integer
        Dim strTemp As String
        Dim intCount As Integer

        Do While textfile.Peek <> -1
            myhs(i).strname = textfile.ReadLine
            myhs(i).intscore = Val(textfile.ReadLine)
            i = i + 1
        Loop

        i -= 1

        textfile.Close()
        fs.Close()
        For intCount = 0 To myhs.Length - 1
            If myhs(i).intscore < intScore Then
                Do
                    strName = InputBox("You have a high score, please input initials (3)")
                Loop While strName.Length <> 3

                Call SaveFile(intScore, strName, myhs)

                intCount = myhs.Length + 10

            End If
        Next

        If intCount <= myhs.Length + 1 Then

            Me.lstHS.Visible = True

            For intC As Integer = 0 To myhs.Length - 1
                strTemp = " Player: " & myhs(intC).strname & vbTab & " Score: " & myhs(intC).intscore
                Me.lstHS.Items.Add(strTemp)
            Next

        End If

    End Sub

    Sub SaveFile(ByVal intScore As Integer, ByVal strName As String, ByRef myArray() As Highscore)

        Dim fs As New FileStream("Score.txt", FileMode.OpenOrCreate, FileAccess.Write)
        Dim textfile As New StreamWriter(fs)
        Dim i As Integer
        Dim strTemp As String

        Do While intScore < myArray(i).intscore
            i += 1
        Loop

        For intcount As Integer = myArray.Length - 1 To i Step -1
            If intcount <> i Then
                myArray(intcount).intscore = myArray(intcount - 1).intscore
                myArray(intcount).strname = myArray(intcount - 1).strname

            Else
                myArray(intcount).intscore = intScore
                myArray(intcount).strname = strName
            End If
        Next

        Me.lstHS.Visible = True

        For intcount As Integer = 0 To myArray.Length - 1
            strTemp = " Player: " & myArray(intcount).strname & vbTab & " Score: " & myArray(intcount).intscore
            Me.lstHS.Items.Add(strTemp)

            textfile.WriteLine(myArray(intcount).strname)
            textfile.WriteLine(myArray(intcount).intscore)
        Next

        textfile.Close()
        fs.Close()

    End Sub

    Sub lblContinue_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblContinue.MouseEnter

        Me.lblContinue.BackColor = Color.White
        Me.lblContinue.ForeColor = Color.Black

    End Sub

    Sub lblContinue_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblContinue.MouseLeave

        Me.lblContinue.BackColor = Color.Black
        Me.lblContinue.ForeColor = Color.White

    End Sub

    Private Sub lblContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblContinue.Click

        Me.lblHighScores.Visible = False
        Me.lblContinue.Visible = False
        Me.lstHS.Items.Clear()
        Me.lstHS.Visible = False
        Me.lstHS.Enabled = False

        Me.lblBeacon.Visible = True
        Me.lblBeacon.BackColor = Color.Transparent
        Me.lblBeacon.ForeColor = Color.Black
        Me.lblCampaign.Visible = True
        Me.lblInstructions.Visible = True

        Me.BackgroundImage = My.Resources.EPIC

        intLevel = 1
        intLives = 3
        intScore = 0

        Me.tmrHighScoreScroll.Enabled = True
        Me.tmrHighScoreScroll.Start()
        intHSCount -= intHSCount

        My.Computer.Audio.Play(My.Resources.Game_Theme, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub tmrHighScoreScroll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHighScoreScroll.Tick

        intHSCount += 1

        If intHSCount = 15 Then
            Call CheckHS()
            Me.lblBeacon.Visible = False
            Me.lblCampaign.Visible = False
            Me.lblInstructions.Visible = False
            Me.BackgroundImage = Nothing
            Me.BackColor = Color.Black
            Me.lblHighScores.Visible = True
            Me.lblContinue.Visible = True
            Me.lstHS.Enabled = True
        End If

        If intHSCount = 30 Then
            Me.lblBeacon.Visible = True
            Me.lblCampaign.Visible = True
            Me.lblInstructions.Visible = True
            Me.BackgroundImage = My.Resources.EPIC
            Me.lblHighScores.Visible = False
            Me.lstHS.Visible = False
            Me.lstHS.Items.Clear()
            Me.lstHS.Enabled = False
            Me.lblContinue.Visible = False
            intHSCount -= intHSCount
        End If

    End Sub

    Private Sub tmrEnemy1Respawn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemy1Respawn.Tick

        Static intCount As Integer = 0
        Static intPicCount As Integer = 0
        intCount += 1

        If intPicCount = 0 Then
            Me.picEnemy1.Image = My.Resources.Enemy2
            Me.picEnemyMissle1.Image = My.Resources.AlienShot2
        ElseIf intPicCount = 1 Then
            Me.picEnemy1.Image = My.Resources.Enemy3
            Me.picEnemyMissle1.Image = My.Resources.AlienShot3
        ElseIf intPicCount = 2 Then
            Me.picEnemy1.Image = My.Resources.Enemy1
            Me.picEnemyMissle1.Image = My.Resources.AlienShot1
            intPicCount -= intPicCount
        End If

        If intCount = 2 Then
            intPicCount += 1
            Me.picEnemy1.Visible = True
            Me.tmrEnemy1.Start()
            intCount -= intCount
            Me.tmrEnemy1Respawn.Stop()
        End If

    End Sub

    Private Sub tmrEnemy2Respawn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemy2Respawn.Tick

        Static intCount As Integer = 0
        Static intPicCount As Integer = 0
        intCount += 1

        If intPicCount = 0 Then
            Me.picEnemy2.Image = My.Resources.Enemy2
            Me.picEnemyMissle2.Image = My.Resources.AlienShot2
        ElseIf intPicCount = 1 Then
            Me.picEnemy2.Image = My.Resources.Enemy3
            Me.picEnemyMissle2.Image = My.Resources.AlienShot3
        ElseIf intPicCount = 2 Then
            Me.picEnemy2.Image = My.Resources.Enemy1
            Me.picEnemyMissle2.Image = My.Resources.AlienShot1
            intPicCount -= intPicCount
        End If

        If intCount = 2 Then
            intPicCount += 1
            Me.picEnemy2.Visible = True
            Me.tmrEnemy2.Start()
            intCount -= intCount
            Me.tmrEnemy2Respawn.Stop()
        End If

    End Sub

    Private Sub tmrEnemy3Respawn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemy3Respawn.Tick

        Static intCount As Integer = 0
        Static intPicCount As Integer = 0
        intCount += 1

        If intPicCount = 0 Then
            Me.picEnemy3.Image = My.Resources.Enemy2
            Me.picEnemyMissle3.Image = My.Resources.AlienShot2
        ElseIf intPicCount = 1 Then
            Me.picEnemy3.Image = My.Resources.Enemy3
            Me.picEnemyMissle3.Image = My.Resources.AlienShot3
        ElseIf intPicCount = 2 Then
            Me.picEnemy3.Image = My.Resources.Enemy1
            Me.picEnemyMissle3.Image = My.Resources.AlienShot1
            intPicCount -= intPicCount
        End If

        If intCount = 2 Then
            intPicCount += 1
            Me.picEnemy3.Visible = True
            Me.tmrEnemy3.Start()
            intCount -= intCount
            Me.tmrEnemy3Respawn.Stop()
        End If

    End Sub

    Private Sub tmrEnemy4Respawn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEnemy4Respawn.Tick

        Static intCount As Integer = 0
        Static intPicCount As Integer = 0
        intCount += 1

        If intPicCount = 0 Then
            Me.picEnemy4.Image = My.Resources.Enemy2
            Me.picEnemyMissle4.Image = My.Resources.AlienShot2
        ElseIf intPicCount = 1 Then
            Me.picEnemy4.Image = My.Resources.Enemy3
            Me.picEnemyMissle4.Image = My.Resources.AlienShot3
        ElseIf intPicCount = 2 Then
            Me.picEnemy4.Image = My.Resources.Enemy1
            Me.picEnemyMissle4.Image = My.Resources.AlienShot1
            intPicCount -= intPicCount
        End If

        If intCount = 2 Then
            intPicCount += 1
            Me.picEnemy4.Visible = True
            Me.tmrEnemy4.Start()
            intCount -= intCount
            Me.tmrEnemy4Respawn.Stop()
        End If

    End Sub

    Private Sub tmrExplosion2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrExplosion2.Tick

        Static intCount As Integer = 0
        intCount += 1

        If intCount = 1 Then
            Me.picExplosion2.Image = My.Resources.Explosion1
        ElseIf intCount = 2 Then
            Me.picExplosion2.Image = My.Resources.Explosion2
        ElseIf intCount = 3 Then
            Me.picExplosion2.Image = My.Resources.Explosion3
        ElseIf intCount = 4 Then
            Me.picExplosion2.Image = My.Resources.Explosion4
        ElseIf intCount = 5 Then
            Me.picExplosion2.Image = My.Resources.Explosion5
        ElseIf intCount = 6 Then
            Me.picExplosion2.Image = My.Resources.Explosion6
        ElseIf intCount = 7 Then
            Me.picExplosion2.Image = My.Resources.Explosion7
        ElseIf intCount = 8 Then
            Me.picExplosion2.Image = My.Resources.Explosion8
        ElseIf intCount = 9 Then
            Me.picExplosion2.Image = My.Resources.Explosion9
        ElseIf intCount = 10 Then
            Me.picExplosion2.Image = My.Resources.Explosion10
        ElseIf intCount = 11 Then
            Me.picExplosion2.Image = My.Resources.Explosion11
        ElseIf intCount = 12 Then
            Me.picExplosion2.Image = My.Resources.Explosion12
        ElseIf intCount = 13 Then
            Me.picExplosion2.Image = My.Resources.Explosion13
        ElseIf intCount = 14 Then
            Me.picExplosion2.Image = My.Resources.Explosion14
        ElseIf intCount = 15 Then
            Me.picExplosion2.Image = My.Resources.Explosion15
        ElseIf intCount = 16 Then
            Me.picExplosion2.Image = My.Resources.Explosion16
        ElseIf intCount = 17 Then
            Me.picExplosion2.Image = My.Resources.explosion17
        ElseIf intCount = 18 Then
            Me.picExplosion2.Image = My.Resources.Explosion18
        ElseIf intCount = 19 Then
            Me.picExplosion2.Image = My.Resources.Explosion19
        ElseIf intCount = 20 Then
            Me.picExplosion2.Image = My.Resources.Explosion20
        ElseIf intCount = 21 Then
            Me.picExplosion2.Image = My.Resources.Explosion21
        ElseIf intCount = 22 Then
            Me.picExplosion2.Image = My.Resources.Explosion22
        ElseIf intCount = 23 Then
            Me.picExplosion2.Image = My.Resources.Explosion23
        ElseIf intCount = 24 Then
            Me.picExplosion2.Image = My.Resources.Explosion24
        ElseIf intCount = 25 Then
            Me.picExplosion2.Visible = False
            Me.tmrExplosion2.Stop()
            intCount -= intCount
        End If

    End Sub

    Private Sub tmrExplosion3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrExplosion3.Tick

        Static intCount As Integer = 0
        intCount += 1

        If intCount = 1 Then
            Me.picExplosion3.Image = My.Resources.Explosion1
        ElseIf intCount = 2 Then
            Me.picExplosion3.Image = My.Resources.Explosion2
        ElseIf intCount = 3 Then
            Me.picExplosion3.Image = My.Resources.Explosion3
        ElseIf intCount = 4 Then
            Me.picExplosion3.Image = My.Resources.Explosion4
        ElseIf intCount = 5 Then
            Me.picExplosion3.Image = My.Resources.Explosion5
        ElseIf intCount = 6 Then
            Me.picExplosion3.Image = My.Resources.Explosion6
        ElseIf intCount = 7 Then
            Me.picExplosion3.Image = My.Resources.Explosion7
        ElseIf intCount = 8 Then
            Me.picExplosion3.Image = My.Resources.Explosion8
        ElseIf intCount = 9 Then
            Me.picExplosion3.Image = My.Resources.Explosion9
        ElseIf intCount = 10 Then
            Me.picExplosion3.Image = My.Resources.Explosion10
        ElseIf intCount = 11 Then
            Me.picExplosion3.Image = My.Resources.Explosion11
        ElseIf intCount = 12 Then
            Me.picExplosion3.Image = My.Resources.Explosion12
        ElseIf intCount = 13 Then
            Me.picExplosion3.Image = My.Resources.Explosion13
        ElseIf intCount = 14 Then
            Me.picExplosion3.Image = My.Resources.Explosion14
        ElseIf intCount = 15 Then
            Me.picExplosion3.Image = My.Resources.Explosion15
        ElseIf intCount = 16 Then
            Me.picExplosion3.Image = My.Resources.Explosion16
        ElseIf intCount = 17 Then
            Me.picExplosion3.Image = My.Resources.explosion17
        ElseIf intCount = 18 Then
            Me.picExplosion3.Image = My.Resources.Explosion18
        ElseIf intCount = 19 Then
            Me.picExplosion3.Image = My.Resources.Explosion19
        ElseIf intCount = 20 Then
            Me.picExplosion3.Image = My.Resources.Explosion20
        ElseIf intCount = 21 Then
            Me.picExplosion3.Image = My.Resources.Explosion21
        ElseIf intCount = 22 Then
            Me.picExplosion3.Image = My.Resources.Explosion22
        ElseIf intCount = 23 Then
            Me.picExplosion3.Image = My.Resources.Explosion23
        ElseIf intCount = 24 Then
            Me.picExplosion3.Image = My.Resources.Explosion24
        ElseIf intCount = 25 Then
            Me.picExplosion3.Visible = False
            Me.tmrExplosion3.Stop()
            intCount -= intCount
        End If

    End Sub

    Private Sub tmrExplosion4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrExplosion4.Tick

        Static intCount As Integer = 0
        intCount += 1

        If intCount = 1 Then
            Me.picExplosion4.Image = My.Resources.Explosion1
        ElseIf intCount = 2 Then
            Me.picExplosion4.Image = My.Resources.Explosion2
        ElseIf intCount = 3 Then
            Me.picExplosion4.Image = My.Resources.Explosion3
        ElseIf intCount = 4 Then
            Me.picExplosion4.Image = My.Resources.Explosion4
        ElseIf intCount = 5 Then
            Me.picExplosion4.Image = My.Resources.Explosion5
        ElseIf intCount = 6 Then
            Me.picExplosion4.Image = My.Resources.Explosion6
        ElseIf intCount = 7 Then
            Me.picExplosion4.Image = My.Resources.Explosion7
        ElseIf intCount = 8 Then
            Me.picExplosion4.Image = My.Resources.Explosion8
        ElseIf intCount = 9 Then
            Me.picExplosion4.Image = My.Resources.Explosion9
        ElseIf intCount = 10 Then
            Me.picExplosion4.Image = My.Resources.Explosion10
        ElseIf intCount = 11 Then
            Me.picExplosion4.Image = My.Resources.Explosion11
        ElseIf intCount = 12 Then
            Me.picExplosion4.Image = My.Resources.Explosion12
        ElseIf intCount = 13 Then
            Me.picExplosion4.Image = My.Resources.Explosion13
        ElseIf intCount = 14 Then
            Me.picExplosion4.Image = My.Resources.Explosion14
        ElseIf intCount = 15 Then
            Me.picExplosion4.Image = My.Resources.Explosion15
        ElseIf intCount = 16 Then
            Me.picExplosion4.Image = My.Resources.Explosion16
        ElseIf intCount = 17 Then
            Me.picExplosion4.Image = My.Resources.explosion17
        ElseIf intCount = 18 Then
            Me.picExplosion4.Image = My.Resources.Explosion18
        ElseIf intCount = 19 Then
            Me.picExplosion4.Image = My.Resources.Explosion19
        ElseIf intCount = 20 Then
            Me.picExplosion4.Image = My.Resources.Explosion20
        ElseIf intCount = 21 Then
            Me.picExplosion4.Image = My.Resources.Explosion21
        ElseIf intCount = 22 Then
            Me.picExplosion4.Image = My.Resources.Explosion22
        ElseIf intCount = 23 Then
            Me.picExplosion4.Image = My.Resources.Explosion23
        ElseIf intCount = 24 Then
            Me.picExplosion4.Image = My.Resources.Explosion24
        ElseIf intCount = 25 Then
            Me.picExplosion4.Visible = False
            Me.tmrExplosion4.Stop()
            intCount -= intCount
        End If

    End Sub

    Private Sub tmrUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrUp.Tick

        Me.picPlayerShip.Top -= 4

        If Me.picPlayerShip.Top < Me.Height - 150 Then
            Me.picPlayerShip.Top = Me.Height - 150
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDown.Tick

        Me.picPlayerShip.Top += 4

        If Me.picPlayerShip.Top > Me.Height - (Me.picPlayerShip.Height * 2) Then
            Me.picPlayerShip.Top = Me.Height - (Me.picPlayerShip.Height * 2)
        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrLeft.Tick

        Me.picPlayerShip.Left -= 4

        If Me.picPlayerShip.Left <= 0 Then
            Me.picPlayerShip.Left = 0
        End If

    End Sub

    Private Sub tmrRight_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRight.Tick

        Me.picPlayerShip.Left += 4

        If Me.picPlayerShip.Left >= Me.Width - Me.picPlayerShip.Width Then
            Me.picPlayerShip.Left = Me.Width - Me.picPlayerShip.Width
        End If

    End Sub

End Class
