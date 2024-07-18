Public Class FPedidos
#Region "Estructuras"
    Structure Tipo_pedidos
        Dim cliente As String
        Dim direccion As String
        Dim telefono As String
        Dim CantLavandina As Integer
        Dim CantDetergente As Integer
        Dim CantDesodorante As Integer
        Dim CantPaño As Integer
        Dim CantEsponja As Integer
        Dim MlLavandina As String
        Dim MlDetergente As String
        Dim MlDesodorante As String
        Dim horario As String
    End Structure
#End Region
#Region "Variables globales"
    Dim tope As Integer = 8
    Dim ultimo As Integer = -1
    Dim Arpedidos(tope) As Tipo_pedidos
#End Region
#Region "Rutinas propias"
    Private Sub LlenarPedido(ByVal arreglo() As Tipo_pedidos, ByVal ultimo As Integer, ByVal hora As String)
        Dim lista As String = ""
        For j = 0 To ultimo

            If hora = RBTodosLista.Text OrElse (ExisteHorario(arreglo, ultimo, hora, j)) Then
                If arreglo(j).CantPaño > 0 Then
                    lista &= Arpedidos(j).CantPaño & " Paño" & vbNewLine
                End If
                If arreglo(j).CantEsponja > 0 Then
                    lista &= Arpedidos(j).CantEsponja & " Esponja" & vbNewLine
                End If
                If arreglo(j).CantLavandina > 0 Then
                    lista &= Arpedidos(j).CantLavandina & " Lavandina " & Arpedidos(j).MlLavandina & vbNewLine
                End If
                If arreglo(j).CantDetergente > 0 Then
                    lista &= Arpedidos(j).CantDetergente & " Detergente " & Arpedidos(j).MlDetergente & vbNewLine
                End If
                If arreglo(j).CantDesodorante > 0 Then
                    lista &= Arpedidos(j).CantDesodorante & " Desodorante " & Arpedidos(j).MlDesodorante
                End If
                MsgBox("Cliente: " & Arpedidos(j).cliente & " - " & Arpedidos(j).direccion & " - " & Arpedidos(j).telefono & vbNewLine & "Horario: " & Arpedidos(j).horario & vbNewLine & lista, MsgBoxStyle.Information, "Pedidos")
                lista = ""

            End If
        Next j
    End Sub
    Private Sub InsertarPedido(ByRef arreglo() As Tipo_pedidos, ByRef ultimo As Integer, ByVal tope As Integer, ByVal pedidoactual As Tipo_pedidos)
        Dim pos As Integer
        If ultimo < tope Then
            pos = ultimo
            arreglo(pos + 1) = pedidoactual
            ultimo += 1
        End If
    End Sub

    Private Function BuscarPedido(ByRef arreglo() As Tipo_pedidos, ByRef ultimo As Integer, ByVal tope As Integer, ByVal Buscado As String) As Integer
        'case o if para cliente direccion o telefono checkeado. (Boton mostrar)
        Dim pos As Integer = 0
        Dim encontrado As Boolean = False
        If ultimo > -1 Then

            If RBPorCliente.Checked Then
                While pos <= ultimo AndAlso encontrado = False
                    If arreglo(pos).cliente = Buscado Then
                        encontrado = True
                    Else
                        pos += 1
                    End If

                End While
            ElseIf RBPorDireccion.Checked Then
                While pos <= ultimo AndAlso encontrado = False
                    If arreglo(pos).direccion = Buscado Then
                        encontrado = True
                    Else
                        pos += 1
                    End If

                End While
            ElseIf RBPorTelefono.Checked Then
                While pos <= ultimo AndAlso encontrado = False
                    If arreglo(pos).telefono = Buscado Then
                        encontrado = True
                    Else
                        pos += 1
                    End If

                End While
            End If
        End If

        If encontrado = False Then
            pos = -1
        End If

        Return pos
    End Function
    Private Function ExistePedido(ByRef Arreglo() As Tipo_pedidos, ByVal ultimo As Integer, ByVal cliente As String, ByVal direccion As String, ByVal telefono As String) As Boolean
        Dim Existe As Boolean = False
        Dim pos As Integer = 0

        While Not Existe And pos <= ultimo
            If (Arreglo(pos).cliente = cliente) Or (Arreglo(pos).direccion = direccion) Or (Arreglo(pos).telefono = telefono) Then
                Existe = True
            Else
                pos = pos + 1
            End If
        End While

        Return Existe
    End Function

    Private Sub Eliminar(ByRef Arreglo() As Tipo_pedidos, ByRef ultimo As Integer, ByVal nombre As String)
        Dim pos As Integer

        pos = BuscarPedido(Arreglo, ultimo, tope, nombre)
        If (pos >= 0) Then
            Arreglo(pos) = Arreglo(ultimo)
            ultimo = ultimo - 1
        End If
    End Sub

    Private Sub ActualizarControles()
        If (ultimo < tope) Then
            TCliente.Clear()
            TDireccion.Clear()
            MTTelefono.Clear()
            NudEsponja.Visible = False
            NudPaño.Visible = False
            GBLavandina.Enabled = False
            GBDetergente.Enabled = False
            GBDesodorante.Enabled = False
            CheckPaño.Checked = False
            CheckLavandina.Checked = False
            CheckDetergente.Checked = False
            CheckEsponja.Checked = False
            CheckDesodorante.Checked = False
            RBHora8.Checked = True
            RB1lLavan.Checked = True
            RB500mlDeter.Checked = True
            RB750mlDeso.Checked = True
            NudLavandina.Value = 1
            NudDesodorante.Value = 1
            NudDetergente.Value = 1
            NudPaño.Value = 1
            NudEsponja.Value = 1
            RBPorCliente.Checked = True
            TBuscar.Clear()
        End If
    End Sub
    Private Function ExisteHorario(ByRef Arreglo() As Tipo_pedidos, ByVal ultimo As Integer, ByVal hora As String, ByVal pos As Integer) As Boolean
        Dim Existe As Boolean = False

        If (Arreglo(pos).horario = hora) Then
            Existe = True
        End If

        Return Existe
    End Function
    Private Function BuscarHorario(ByRef arreglo() As Tipo_pedidos, ByRef ultimo As Integer, ByVal tope As Integer, ByVal hora As String) As Integer
        Dim pos As Integer = 0
        Dim encontrado As Boolean = False

        If ultimo > -1 Then
            While pos <= ultimo AndAlso encontrado = False
                If arreglo(pos).horario = hora Then
                    encontrado = True
                Else
                    pos += 1
                End If
            End While
        End If
        If encontrado = False Then
            pos = -1
        End If

        Return pos
    End Function
#End Region
#Region "Eventos"

    Private Sub CheckPaño_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPaño.CheckedChanged
        If CheckPaño.Checked Then
            NudPaño.Visible = True
        Else
            NudPaño.Visible = False
        End If
    End Sub

    Private Sub CheckEsponja_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEsponja.CheckedChanged
        If CheckEsponja.Checked Then
            NudEsponja.Visible = True
        Else
            NudEsponja.Visible = False
        End If
    End Sub

    Private Sub CheckLavandina_CheckedChanged(sender As Object, e As EventArgs) Handles CheckLavandina.CheckedChanged

        If CheckLavandina.Checked Then
            GBLavandina.Enabled = True
        Else
            GBLavandina.Enabled = False
        End If
    End Sub

    Private Sub CheckDetergente_CheckedChanged(sender As Object, e As EventArgs) Handles CheckDetergente.CheckedChanged
        If CheckDetergente.Checked Then
            GBDetergente.Enabled = True
        Else
            GBDetergente.Enabled = False
        End If
    End Sub

    Private Sub CheckDesodorante_CheckedChanged(sender As Object, e As EventArgs) Handles CheckDesodorante.CheckedChanged
        If CheckDesodorante.Checked Then
            GBDesodorante.Enabled = True
        Else
            GBDesodorante.Enabled = False

        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim PedidoActual As Tipo_pedidos

        PedidoActual.cliente = TCliente.Text.Trim
        PedidoActual.direccion = TDireccion.Text.Trim
        PedidoActual.telefono = MTTelefono.Text
        PedidoActual.CantLavandina = 0
        PedidoActual.CantDetergente = 0
        PedidoActual.CantDesodorante = 0
        PedidoActual.CantPaño = 0
        PedidoActual.MlLavandina = ""
        PedidoActual.MlDetergente = ""
        PedidoActual.MlDesodorante = ""

        If ultimo = tope Then
            MsgBox("No hay lugares disponibles para guardar", MsgBoxStyle.Critical, "No se pudo guardar")
        ElseIf PedidoActual.cliente = "" Then
            MsgBox("Debe completar el campo ""Cliente"" si desea guardar", MsgBoxStyle.Critical, "ERROR")
            TCliente.Focus()
        ElseIf PedidoActual.direccion = "" Then
            MsgBox("Debe completar el campo ""Dirección"" si desea guardar", MsgBoxStyle.Critical, "ERROR")
            TDireccion.Focus()
        ElseIf Not MTTelefono.MaskCompleted Then
            MsgBox("Debe completar el campo ""Teléfono"" si desea guardar", MsgBoxStyle.Critical, "ERROR")
            MTTelefono.Focus()
        ElseIf ExistePedido(Arpedidos, ultimo, PedidoActual.cliente, PedidoActual.direccion, PedidoActual.telefono) Then
            MsgBox(" Un dato ingresado ya existe", MsgBoxStyle.Exclamation, "ADVERTENCIA")
        ElseIf Not CheckPaño.Checked And Not CheckEsponja.Checked And Not CheckDesodorante.Checked And Not CheckDetergente.Checked And Not CheckLavandina.Checked Then
            MsgBox("Debe seleccionar algún producto", MsgBoxStyle.Critical, "ERROR")
        Else

            If RBHora8.Checked Then
                PedidoActual.horario = RBHora8.Text
            ElseIf RBHora11.Checked Then
                PedidoActual.horario = RBHora11.Text
            Else
                PedidoActual.horario = RBHora14.Text
            End If

            If CheckPaño.Checked Then
                PedidoActual.CantPaño = NudPaño.Value
            End If
            If CheckEsponja.Checked Then
                PedidoActual.CantEsponja = NudEsponja.Value
            End If

            If CheckLavandina.Checked Then
                PedidoActual.CantLavandina = NudLavandina.Value
                If RB1lLavan.Checked Then
                    PedidoActual.MlLavandina = RB1lLavan.Text
                Else
                    PedidoActual.MlLavandina = RB5lLavan.Text
                End If
            End If

            If CheckDetergente.Checked Then
                PedidoActual.CantDetergente = NudDetergente.Value
                If RB500mlDeter.Checked Then
                    PedidoActual.MlDetergente = RB500mlDeter.Text
                Else
                    PedidoActual.MlDetergente = RB750mlDeter.Text
                End If
            End If

            If CheckDesodorante.Checked Then
                PedidoActual.CantDesodorante = NudDesodorante.Value
                If RB750mlDeso.Checked Then
                    PedidoActual.MlDesodorante = RB750mlDeso.Text
                Else
                    PedidoActual.MlDesodorante = RB125lDeso.Text
                End If
            End If

            InsertarPedido(Arpedidos, ultimo, tope, PedidoActual)
            MsgBox("¡Su pedido ha sido guardado con exito!", MsgBoxStyle.Information, "Guardado")
            ActualizarControles()
        End If
    End Sub

    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Dim respuesta As Integer
        respuesta = MsgBox("¿Desea salir de la aplicacion?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Consulta Cerrar")
        If respuesta = MsgBoxResult.Ok Then
            Close()
        End If
    End Sub

    Private Sub BMostrar_Click(sender As Object, e As EventArgs) Handles BMostrar.Click
        Dim buscar As String = TBuscar.Text.Trim
        Dim pos As Integer

        BEliminar.Enabled = True
        PDatos.Enabled = False
        BGuardar.Enabled = False

        pos = BuscarPedido(Arpedidos, ultimo, tope, buscar)

        If pos = -1 Then
            MsgBox("El pedido no se encontro", MsgBoxStyle.Critical, "ERROR")
        Else
            TCliente.Text = Arpedidos(pos).cliente
            TDireccion.Text = Arpedidos(pos).direccion
            MTTelefono.Text = Arpedidos(pos).telefono
            If Arpedidos(pos).CantPaño >= 1 Then
                CheckPaño.Checked = True
                NudPaño.Visible = True
                NudPaño.Value = Arpedidos(pos).CantPaño
            Else
                CheckPaño.Checked = False
            End If
            If Arpedidos(pos).CantEsponja >= 1 Then
                CheckEsponja.Checked = True
                NudEsponja.Value = Arpedidos(pos).CantEsponja
            Else
                CheckEsponja.Checked = False
            End If
            If Arpedidos(pos).CantLavandina >= 1 Then
                CheckLavandina.Checked = True
                NudLavandina.Value = Arpedidos(pos).CantLavandina
                If Arpedidos(pos).MlLavandina = "1 litro" Then
                    RB1lLavan.Checked = True
                Else
                    RB5lLavan.Checked = True
                End If
            Else
                CheckLavandina.Checked = False
            End If
            If Arpedidos(pos).CantDetergente >= 1 Then
                CheckDetergente.Checked = True
                NudDetergente.Value = Arpedidos(pos).CantDetergente
                If Arpedidos(pos).MlDetergente = "500 ml" Then
                    RB500mlDeter.Checked = True
                Else
                    RB750mlDeter.Checked = True
                End If
            Else
                CheckDetergente.Checked = False
            End If
            If Arpedidos(pos).CantDesodorante >= 1 Then
                CheckDesodorante.Checked = True
                NudDesodorante.Value = Arpedidos(pos).CantDesodorante
                If Arpedidos(pos).MlDesodorante = "750 ml" Then
                    RB750mlDeso.Checked = True
                Else
                    RB125lDeso.Checked = True
                End If
            Else
                CheckDesodorante.Checked = False
            End If
            If Arpedidos(pos).horario = "08 a 11 horas" Then
                RBHora8.Checked = True
            ElseIf Arpedidos(pos).horario = "11 a 14 horas" Then
                RBHora11.Checked = True
            Else
                RBHora14.Checked = True
            End If
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim respuesta As Integer
        Dim eliminado As String = TBuscar.Text.Trim

        respuesta = MsgBox("¿Esta seguro que desea eliminar este pedido?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "Eliminar")
        If respuesta = MsgBoxResult.Ok Then
            Eliminar(Arpedidos, ultimo, eliminado)
            MsgBox("¡¡El pedido ha sido eliminado!!", MsgBoxStyle.Information, "Eliminado")
            ActualizarControles()
            TCliente.Focus()
            PDatos.Enabled = True
            BGuardar.Enabled = True
            BEliminar.Enabled = False
        End If
    End Sub

    Private Sub BLimpiar_Click(sender As Object, e As EventArgs) Handles BLimpiar.Click
        ActualizarControles()
        PDatos.Enabled = True
        BEliminar.Enabled = False
        BGuardar.Enabled = True
    End Sub

    Private Sub BListar_Click(sender As Object, e As EventArgs) Handles BListar.Click
        Dim lista As String = ""
        Dim pos As Integer
        Dim hora As String



        If ultimo = -1 Then
            MsgBox("La lista de pedidos está vacía.", MsgBoxStyle.Information, "Lista vacía")
        ElseIf RBTodosLista.Checked Then
            hora = RBTodosLista.Text
            LlenarPedido(Arpedidos, ultimo, hora)
        ElseIf RBHora8Lista.Checked Then
            hora = "08 a 11 horas"
            pos = BuscarHorario(Arpedidos, ultimo, tope, hora)
            If (pos <> -1) Then
                LlenarPedido(Arpedidos, ultimo, hora)
            Else
                MsgBox("No hay pedidos en este horario", MsgBoxStyle.Information, "No hay pedido")
            End If
        ElseIf RBHora11Lista.Checked Then
            hora = "11 a 14 horas"
            pos = BuscarHorario(Arpedidos, ultimo, tope, hora)
            If (pos <> -1) Then
                LlenarPedido(Arpedidos, ultimo, hora)
            Else
                MsgBox("No hay pedidos en este horario", MsgBoxStyle.Information, "No hay pedido")
            End If
        ElseIf RBHora14Lista.Checked Then
            hora = "14 a 17 horas"
            pos = BuscarHorario(Arpedidos, ultimo, tope, hora)
            If (pos <> -1) Then
                LlenarPedido(Arpedidos, ultimo, hora)
            Else
                MsgBox("No hay pedidos en este horario", MsgBoxStyle.Information, "No hay pedido")
            End If
        Else
                MsgBox("Debe seleccionar un horario.", MsgBoxStyle.Exclamation, "Horario sin seleccionar")
        End If
    End Sub



#End Region
End Class