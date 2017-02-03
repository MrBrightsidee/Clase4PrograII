Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CbxNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxNum.SelectedIndexChanged
        Dim figura As Integer = CbxNum.SelectedIndex()
        Select Case figura
            Case 0

                CbxNum.Visible = True
                txtLado.Visible = True
                lbllado1.Visible = True
                lbllado1.Text = "Lado"
                lbllado2.Visible = False
                txtLado2.Visible = False

            Case 1

                CbxNum.Visible = True
                txtLado.Visible = True
                lbllado1.Visible = True
                lbllado2.Visible = True
                txtLado2.Visible = True
                lbllado1.Text = "Lado"
                lbllado2.Text = "Ancho"


            Case 2

                CbxNum.Visible = True
                txtLado.Visible = True
                lbllado1.Visible = True
                lbllado2.Visible = True
                txtLado2.Visible = True
                lbllado1.Text = "Lado"
                lbllado2.Text = "Ancho"

            Case 3

                CbxNum.Visible = True
                txtLado.Visible = True
                lbllado1.Visible = True
                lbllado2.Visible = True
                txtLado2.Visible = True
                lbllado1.Text = "Lado"
                lbllado2.Text = "Ancho"

            Case 4

                CbxNum.Visible = True
                txtLado.Visible = True
                lbllado1.Visible = True
                lbllado2.Visible = True
                txtLado2.Visible = True
                lbllado1.Text = "Lado"
                lbllado2.Text = "Ancho"



        End Select


    End Sub

    Private Sub txtLado_TextChanged(sender As Object, e As EventArgs) Handles txtLado.TextChanged

    End Sub

    Private Sub txtAncho_TextChanged(sender As Object, e As EventArgs) Handles txtLado2.TextChanged

    End Sub

    Private Sub txtResultado_TextChanged(sender As Object, e As EventArgs) Handles txtResultado.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim area As Integer

        Select Case CbxNum.SelectedIndex()
            Case 0
                area = Int(txtLado.Text) * Int(txtLado.Text)
            Case 1
                area = Int(txtLado.Text) * Int(txtLado2.Text)
            Case 2
                area = (Int(txtLado.Text) * Int(txtLado2.Text)) / 2
            Case 3
                area = Int(txtLado.Text) * Int(txtLado2.Text)
        End Select
        txtResultado.Visible = True
        txtResultado.Text = "El area de la figura es: " & area
    End Sub
End Class
