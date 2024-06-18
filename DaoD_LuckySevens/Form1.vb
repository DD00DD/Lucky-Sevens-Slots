'***********************************************************************
'	PROGRAMME NAME	    :	EX04 Lucky Sevens
'
'	PROGRAMME OUTLINE	:	This programme allows the user to play a slot
'                           machine, the program will spin until they get
'                           3 lucky sevens and it will keep count of the
'                           amount of spins it take.
'                           
'
'	PROGRAMMER		    :	Derek Dao
'
'	DATE				:	Oct 30, 2019
'
'***********************************************************************
Public Class Form1

    Private num As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("To Play: Click the Play button." & Environment.NewLine &
                        "To Win: Get three 7 7 7 pictures!", "Instructions",
                         MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim slot() As PictureBox = {picOne, picTwo, picThree}
        Dim randOne As New Random
        Dim rand(2) As Integer

        num = 0
        lblWin.Text = Nothing
        lblWin.BackColor = Color.White

        Do
            For i = 0 To slot.Length - 1
                rand(i) = randOne.Next(1, 5)
                Call ShowImage(rand(i), slot(i))
            Next
            Threading.Thread.Sleep(150)
            Refresh()

            num += 1
            lblCount.BackColor = Color.Yellow
            lblCount.Text = "Play Count: " & num
        Loop Until rand(0) = 4 And rand(1) = 4 And rand(2) = 4

        lblWin.BackColor = Color.Yellow
        lblWin.Text = "You WIN!"
    End Sub

    Private Sub ShowImage(rand As Integer, slot As PictureBox)
        Select Case rand
            Case 1
                slot.Image = My.Resources.apple
            Case 2
                slot.Image = My.Resources.banana
            Case 3
                slot.Image = My.Resources.peach
            Case 4
                slot.Image = My.Resources.luckySeven
        End Select
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class
