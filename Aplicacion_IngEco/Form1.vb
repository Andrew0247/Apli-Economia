Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Calcular_Click(sender As Object, e As EventArgs) Handles btn_Calcular.Click
        Dim capital, tiempo, monto As Integer
        Dim interes, V1, V2, x As Single
        V2 = 1.0
        'Dim FActual As List(Of Integer) = New List(Of Integer)
        capital = txt_Capital.Text
        tiempo = txt_Tiempo.Text
        interes = txt_Interes.Text
        interes = interes / 100
        If tiempo <= 12 Then

            If rbt_FechaAct.Checked = True Then
                If rbt_ReglaCom.Checked = True Then
                    If rbt_InteresSim.Checked = True Then
                        For i As Integer = 1 To tiempo Step 1
                            V1 += (1 + (i * interes))
                        Next
                        For h As Integer = 1 To tiempo Step 1
                            V2 *= (1 + (h * interes))
                        Next
                        V1 = V1 / V2
                        x = capital / V1
                        lbl_ValorCuo.Text = x
                    End If
                    If rbt_InteresComp.Checked = True Then
                        For i As Integer = 1 To tiempo Step 1
                            V1 += (1 + interes) ^ i
                        Next
                        For h As Integer = 1 To tiempo Step 1
                            V2 *= (1 + interes) ^ h
                        Next
                        V1 = V1 / V2
                        x = capital / V1
                        lbl_ValorCuo.Text = x
                    End If
                End If

            End If

            If rbt_FechaFin.Checked = True Then
                If rbt_ReglaCom.Checked = True Then
                    If rbt_InteresSim.Checked = True Then
                        capital *= (1 + (tiempo * interes))
                        tiempo -= 1
                        For i As Integer = tiempo To 1 Step -1
                            V1 += (1 + (i * interes))
                        Next
                        V1 += 1
                        x = capital / V1
                        lbl_ValorCuo.Text = x
                    End If
                    If rbt_InteresComp.Checked = True Then
                        capital *= (1 + interes) ^ tiempo
                        tiempo -= 1
                        For i As Integer = tiempo To 1 Step -1
                            V1 += ((1 + interes) ^ i)
                        Next
                        V1 += 1
                        x = capital / V1
                        lbl_ValorCuo.Text = x
                    End If
                End If

                If rbt_ReglaAme.Checked = True Then
                    If rbt_InteresSim.Checked = True Then
                        capital *= (1 + (tiempo * interes))
                        tiempo -= 1
                        For i As Integer = tiempo To 1 Step -1
                            V1 += (1 + (i * interes))
                        Next
                        V1 += 1
                        x = capital / V1
                        monto = capital
                        For i As Integer = 2 To tiempo Step 1
                            V2 = monto * interes
                            monto = (monto - x + V2)
                            'monto = V1
                        Next
                        V2 = monto * interes
                        monto += V2
                        lbl_ValorCuo.Text = monto
                    End If
                    If rbt_InteresComp.Checked = True Then
                        capital *= (1 + interes) ^ tiempo
                        tiempo -= 1
                        For i As Integer = tiempo To 1 Step -1
                            V1 += ((1 + interes) ^ i)
                        Next
                        V1 += 1
                        x = capital / V1
                        monto = capital
                        For i As Integer = 0 To tiempo Step 1
                            monto *= ((1 + interes) ^ tiempo)
                            monto -= x
                            'monto -= V2
                        Next
                        'V2 = monto * interes
                        'monto += V2
                        lbl_ValorCuo.Text = monto
                    End If
                End If
            End If
        Else
            MsgBox("Favor Introduzca Un Mes entre 1 y 12")
            txt_Tiempo.Clear()
            txt_Tiempo.Select()
        End If
    End Sub
End Class
