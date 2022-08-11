Public Class Form1
    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Foodbtnpnl.Visible = True
        Drinksbtnpnl.Visible = False
        Desertbtnpnl.Visible = False
        Mycartbtnpnl.Visible = False
        Aboutbtnpnl.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles darkmode.Click
        If darkmode.Text = "Dark Mode" Then
            darkmode.ForeColor = Color.White
            darkmode.Text = "Light Mode"

            foodpnl.BackColor = Color.Black

            Foodlbl1.ForeColor = Color.White
            Foodlbl2.ForeColor = Color.White
            Foodlbl3.ForeColor = Color.White
            Foodlbl4.ForeColor = Color.White
            Foodlbl5.ForeColor = Color.White
            Foodlbl6.ForeColor = Color.White

            Foodprice1.ForeColor = Color.White
            Foodprice2.ForeColor = Color.White
            Foodprice3.ForeColor = Color.White
            Foodprice4.ForeColor = Color.White
            Foodprice5.ForeColor = Color.White
            Foodprice6.ForeColor = Color.White

            stars.ForeColor = Color.Black

        Else darkmode.Text = "Dark Mode"
            darkmode.ForeColor = Color.Black

            foodpnl.BackColor = Color.White

            Foodlbl1.ForeColor = Color.Black
            Foodlbl2.ForeColor = Color.Black
            Foodlbl3.ForeColor = Color.Black
            Foodlbl4.ForeColor = Color.Black
            Foodlbl5.ForeColor = Color.Black
            Foodlbl6.ForeColor = Color.Black

            Foodprice1.ForeColor = Color.Black
            Foodprice2.ForeColor = Color.Black
            Foodprice3.ForeColor = Color.Black
            Foodprice4.ForeColor = Color.Black
            Foodprice5.ForeColor = Color.Black
            Foodprice6.ForeColor = Color.Black

            stars.ForeColor = Color.White
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Close()
    End Sub

    Private Sub maximizebutton_Click(sender As Object, e As EventArgs) Handles maximizebutton.Click
        If WindowState = WindowState.Normal Then
            WindowState = WindowState.Maximized
            Foodbtnpnl.Top = Foodbtn.Top
            Drinksbtnpnl.Top = Drinksbtn.Top
            Desertbtnpnl.Top = Desertbtn.Top
            Mycartbtnpnl.Top = Mycartbtn.Top
            Aboutbtnpnl.Top = Aboutbtn.Top
        Else
            WindowState = WindowState.Normal
            Foodbtnpnl.Top = Foodbtn.Top
            Drinksbtnpnl.Top = Drinksbtn.Top
            Desertbtnpnl.Top = Desertbtn.Top
            Mycartbtnpnl.Top = Mycartbtn.Top
            Aboutbtnpnl.Top = Aboutbtn.Top
        End If
    End Sub

    Private Sub minimizebutton_Click(sender As Object, e As EventArgs) Handles minimizebutton.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub exitbutton_MouseEnter(sender As Object, e As EventArgs) Handles exitbutton.MouseEnter
        exitbutton.BackColor = Color.Red
    End Sub

    Private Sub exitbutton_MouseLeave(sender As Object, e As EventArgs) Handles exitbutton.MouseLeave
        exitbutton.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub maximizebutton_MouseEnter(sender As Object, e As EventArgs) Handles maximizebutton.MouseEnter
        maximizebutton.BackColor = Color.DarkOrange
    End Sub

    Private Sub maximizebutton_MouseLeave(sender As Object, e As EventArgs) Handles maximizebutton.MouseLeave
        maximizebutton.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub minimizebutton_MouseEnter(sender As Object, e As EventArgs) Handles minimizebutton.MouseEnter
        minimizebutton.BackColor = Color.LimeGreen
    End Sub

    Private Sub minimizebutton_MouseLeave(sender As Object, e As EventArgs) Handles minimizebutton.MouseLeave
        minimizebutton.BackColor = Color.DarkSlateGray
    End Sub

    Private Sub Foodbtn_Click(sender As Object, e As EventArgs) Handles Foodbtn.Click
        Foodbtnpnl.Visible = True
        Drinksbtnpnl.Visible = False
        Desertbtnpnl.Visible = False
        Mycartbtnpnl.Visible = False
        Aboutbtnpnl.Visible = False
    End Sub

    Private Sub Drinksbtn_Click(sender As Object, e As EventArgs) Handles Drinksbtn.Click
        Foodbtnpnl.Visible = False
        Drinksbtnpnl.Visible = True
        Desertbtnpnl.Visible = False
        Mycartbtnpnl.Visible = False
        Aboutbtnpnl.Visible = False
    End Sub

    Private Sub Desertbtn_Click(sender As Object, e As EventArgs) Handles Desertbtn.Click
        Foodbtnpnl.Visible = False
        Drinksbtnpnl.Visible = False
        Desertbtnpnl.Visible = True
        Mycartbtnpnl.Visible = False
        Aboutbtnpnl.Visible = False
    End Sub

    Private Sub Mycartbtn_Click(sender As Object, e As EventArgs) Handles Mycartbtn.Click
        Foodbtnpnl.Visible = False
        Drinksbtnpnl.Visible = False
        Desertbtnpnl.Visible = False
        Mycartbtnpnl.Visible = True
        Aboutbtnpnl.Visible = False
    End Sub

    Private Sub Aboutbtn_Click(sender As Object, e As EventArgs) Handles Aboutbtn.Click
        Foodbtnpnl.Visible = False
        Drinksbtnpnl.Visible = False
        Desertbtnpnl.Visible = False
        Mycartbtnpnl.Visible = False
        Aboutbtnpnl.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDoubleClick
        If Selectimage.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(Selectimage.FileName)
        End If
    End Sub
End Class
