Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox23.Text = (Val(TextBox20.Text) * 100) / 55
        TextBox5.Text = (23 * 100) / 40
        TextBox6.Text = (Val(TextBox3.Text) * 100) / 40
        TextBox11.Text = (Val(TextBox8.Text) * 100) / 42
        TextBox12.Text = (Val(TextBox9.Text) * 100) / 42
        TextBox18.Text = (Val(TextBox15.Text) * 100) / 35
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox46.Text = TextBox26.Text
        TextBox44.Text = TextBox30.Text
        TextBox42.Text = TextBox34.Text
        TextBox28.Text = Val(TextBox25.Text) * Val(TextBox27.Text)
        TextBox32.Text = Val(TextBox29.Text) * Val(TextBox31.Text)
        TextBox36.Text = Val(TextBox33.Text) * Val(TextBox35.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
       


        If TextBox25.Text < TextBox48.Text Then
            MsgBox("La cantidad de compra no cubre con la cantidad de venta")
        Else
            TextBox43.Text = (Val(TextBox27.Text) * 0.2) + Val(TextBox27.Text)
            TextBox41.Text = Val(TextBox48.Text) * Val(TextBox43.Text)
        End If
        If TextBox29.Text < TextBox47.Text Then
            MsgBox("La cantidad de compra no cubre con la cantidad de venta")
        Else
            TextBox40.Text = (Val(TextBox31.Text) * 0.2) + Val(TextBox31.Text)
            TextBox39.Text = Val(TextBox47.Text) * Val(TextBox40.Text)
        End If
        If TextBox33.Text < TextBox45.Text Then
            MsgBox("La cantidad de compra no cubre con la cantidad de venta")
        Else
            TextBox38.Text = (Val(TextBox35.Text) * 0.2) + Val(TextBox35.Text)
            TextBox37.Text = Val(TextBox45.Text) * Val(TextBox38.Text)
        End If

    End Sub

    Private Sub TextBox34_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox34.TextChanged

    End Sub
End Class
