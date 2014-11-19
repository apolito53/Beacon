Public Class Instructions

    Private Sub lblGoBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBack.Click

        Game.Beacon.Show()
        Close()

    End Sub

    Private Sub lblGoBack_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBack.MouseEnter

        Me.lblBack.BackColor = Color.White
        Me.lblBack.ForeColor = Color.Black

    End Sub

    Private Sub lblGoBack_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblBack.MouseLeave

        Me.lblBack.BackColor = Color.Transparent
        Me.lblBack.ForeColor = Color.White

    End Sub

    Private Sub lblNext_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNext.MouseEnter

        Me.lblNext.BackColor = Color.White
        Me.lblNext.ForeColor = Color.Black

    End Sub

    Private Sub lblNext_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNext.MouseLeave

        Me.lblNext.BackColor = Color.Black
        Me.lblNext.ForeColor = Color.Transparent

    End Sub

    Private Sub Instructions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.lblBack.BackColor = Color.Transparent
        Me.lblNext.BackColor = Color.Transparent
        Me.PictureBox1.Visible = False
        Me.PictureBox2.Visible = False
        Me.picLife1.Visible = False
        Me.picLife2.Visible = False
        Me.lblPreHealth.Visible = False
        Me.lblHealth.Visible = False

    End Sub

    Private Sub lblNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNext.Click

        Me.lblTop.Text = "Enemies"
        Me.lblMoveLeft.Text = "This is your enemy."
        Me.lblMoveRight.Visible = False
        Me.lblMoveUp.Visible = False
        Me.lblMoveDown.Visible = False
        Me.lblSpaceBar.Text = "Destroy them to continue on to the next level."
        Me.lblObjectives.Text = "You"
        Me.lblBottom.Text = "The icons are your remaining lives, and the health indicator is how much health you have left."

        Me.PictureBox1.Visible = True
        Me.PictureBox2.Visible = True

        Me.picLife1.Visible = True
        Me.picLife2.Visible = True
        Me.lblPreHealth.Visible = True
        Me.lblHealth.Visible = True

        Me.lblNext.Visible = False

    End Sub

End Class