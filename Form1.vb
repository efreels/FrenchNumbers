Public Class frmNumbers
    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        'Displays the french word for One
        lblFrench.Visible = True
        lblFrench.Text = "un"
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        'Displays the french word for Two
        lblFrench.Visible = True
        lblFrench.Text = "deux"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        'Displays the french word for Three
        lblFrench.Visible = True
        lblFrench.Text = "trois"
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        'Displays the french word for Four
        lblFrench.Visible = True
        lblFrench.Text = "quatre"
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        'Displays the french word for Five
        lblFrench.Visible = True
        lblFrench.Text = "cinq"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the form/ends the program
        Close()
    End Sub

    Private Sub frmNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The label for the french words is not visible on program start
        lblFrench.Visible = False
    End Sub
End Class
