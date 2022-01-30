Public Class Form1
    Const parroz As Double = 2.0
    Const pfrijol As Double = 1.75
    Const pazucar As Double = 2.5

    Const IVA As Double = 0.12
    Const descuento As Double = 0.025

    Dim psiva As Double = 0
    Dim viva As Double = 0
    Dim pciva As Double = 0
    Dim desc As Double = 0
    Dim pfinal As Double = 0



    Private Sub Acept1_Click(sender As Object, e As EventArgs) Handles Acept1.Click
        psiva = (Val(Texarroz.Text) * parroz) + (Val(Texfrijol.Text) * pfrijol) + (Val(Texazucar.Text) * pazucar)
        viva = psiva * IVA
        pciva = psiva + viva
        desc = pciva * descuento
        pfinal = pciva - desc

        totalsiniva.Text = psiva
        calciva.Text = viva
        totaciva.Text = pciva
        desprec.Text = desc
        todototal.Text = pfinal







    End Sub

    Private Sub Clean2_Click(sender As Object, e As EventArgs) Handles Clean2.Click
        Texarroz.Clear()
        Texfrijol.Clear()
        Texazucar.Clear()














    End Sub

    Private Sub Exit3_Click(sender As Object, e As EventArgs) Handles Exit3.Click
        If MsgBox("¿Desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If







    End Sub

    Private Sub Texfrijol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Texfrijol.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Texazucar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Texazucar.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Texarroz_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Texarroz.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class


