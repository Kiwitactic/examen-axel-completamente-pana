Public Class Form1


    'Multiplicacion 1 materia prima
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim multi As Integer
        valor1 = TextBox11.Text
        valor2 = TextBox9.Text
        multi = valor1 * valor2
        Label1.Text = multi
    End Sub

    'Multiplicacion 2 operarios
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim valor3 As Integer
        Dim valor4 As Integer
        Dim multi2 As Integer
        valor3 = TextBox14.Text
        valor4 = TextBox15.Text
        multi2 = valor3 * valor4
        Label2.Text = multi2
    End Sub

    'Multiplicacion 3 mantenimiento
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim valor5 As Integer
        Dim valor6 As Integer
        Dim multi3 As Integer
        valor5 = TextBox18.Text
        valor6 = TextBox19.Text
        multi3 = valor5 * valor6
        Label3.Text = multi3
    End Sub

    'multiplicacion 4 cremalleras
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim valor7 As Integer
        Dim valor8 As Integer
        Dim multi4 As Integer
        valor7 = TextBox21.Text
        valor8 = TextBox22.Text
        multi4 = valor7 * valor8
        Label4.Text = multi4
    End Sub


    'multiplicacion 5 botones
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim valor9 As Integer
        Dim valor10 As Integer
        Dim multi5 As Integer
        valor9 = TextBox24.Text
        valor10 = TextBox25.Text
        multi5 = valor9 * valor10
        Label5.Text = multi5
    End Sub


    'multiplicacion 6 servicios
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim valor11 As Integer
        Dim valor12 As Integer
        Dim multi6 As Integer
        valor11 = TextBox28.Text
        valor12 = TextBox27.Text
        multi6 = valor11 * valor12
        Label6.Text = multi6
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim valor20 As Integer
        Dim valor21 As Integer
        Dim suma As Integer
        valor20 = 750000
        valor21 = 7650
        suma = valor20 + valor21
        Label7.Text = suma
    End Sub



    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub
End Class
