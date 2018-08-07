Public Class frm_calculadora

    Private Sub lbl_Num1_Click(sender As Object, e As EventArgs) Handles lbl_Num1.Click

    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click


        Calcular(Convert.ToString(cbx_operador.SelectedItem))



    End Sub

    Private Sub btn_restar_Click(sender As Object, e As EventArgs) Handles btn_restar.Click
        'Se puede usar Val para convertir
        txt_resultado.Text = CDec(txt_num1.Text) - CDec(txt_num2.Text)
    End Sub

    Private Sub btn_multiplicar_Click(sender As Object, e As EventArgs) Handles btn_multiplicar.Click
        'Se puede usar Val para convertir
        txt_resultado.Text = CDec(txt_num1.Text) * CDec(txt_num2.Text)
    End Sub

    Private Sub btn_dividir_Click(sender As Object, e As EventArgs) Handles btn_dividir.Click
        'Se puede usar Val para convertir
        txt_resultado.Text = CDec(txt_num1.Text) / CDec(txt_num2.Text)
    End Sub

    Private Sub Calcular(valor As String)

        Select Case valor

            Case "+"
                txt_resultado.Text = CDec(txt_num1.Text) + CDec(txt_num2.Text)
            Case "-"
                txt_resultado.Text = CDec(txt_num1.Text) - CDec(txt_num2.Text)
            Case "*"
                txt_resultado.Text = CDec(txt_num1.Text) * CDec(txt_num2.Text)
            Case "/"
                txt_resultado.Text = CDec(txt_num1.Text) / CDec(txt_num2.Text)
            Case Else
                MsgBox("Operador No valido!")
        End Select

    End Sub

End Class
