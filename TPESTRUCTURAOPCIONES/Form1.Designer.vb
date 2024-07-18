<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PDatos = New System.Windows.Forms.Panel()
        Me.MTTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.GBHorario = New System.Windows.Forms.GroupBox()
        Me.RBHora14 = New System.Windows.Forms.RadioButton()
        Me.RBHora11 = New System.Windows.Forms.RadioButton()
        Me.RBHora8 = New System.Windows.Forms.RadioButton()
        Me.GBProductos = New System.Windows.Forms.GroupBox()
        Me.NudEsponja = New System.Windows.Forms.NumericUpDown()
        Me.NudPaño = New System.Windows.Forms.NumericUpDown()
        Me.GBDesodorante = New System.Windows.Forms.GroupBox()
        Me.NudDesodorante = New System.Windows.Forms.NumericUpDown()
        Me.RB125lDeso = New System.Windows.Forms.RadioButton()
        Me.RB750mlDeso = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GBDetergente = New System.Windows.Forms.GroupBox()
        Me.NudDetergente = New System.Windows.Forms.NumericUpDown()
        Me.RB750mlDeter = New System.Windows.Forms.RadioButton()
        Me.RB500mlDeter = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GBLavandina = New System.Windows.Forms.GroupBox()
        Me.NudLavandina = New System.Windows.Forms.NumericUpDown()
        Me.RB5lLavan = New System.Windows.Forms.RadioButton()
        Me.RB1lLavan = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckPaño = New System.Windows.Forms.CheckBox()
        Me.CheckEsponja = New System.Windows.Forms.CheckBox()
        Me.CheckDesodorante = New System.Windows.Forms.CheckBox()
        Me.CheckDetergente = New System.Windows.Forms.CheckBox()
        Me.CheckLavandina = New System.Windows.Forms.CheckBox()
        Me.TDireccion = New System.Windows.Forms.TextBox()
        Me.TCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RBPorCliente = New System.Windows.Forms.RadioButton()
        Me.RBPorDireccion = New System.Windows.Forms.RadioButton()
        Me.RBPorTelefono = New System.Windows.Forms.RadioButton()
        Me.TBuscar = New System.Windows.Forms.TextBox()
        Me.BMostrar = New System.Windows.Forms.Button()
        Me.PBuscar = New System.Windows.Forms.Panel()
        Me.PListado = New System.Windows.Forms.Panel()
        Me.BListar = New System.Windows.Forms.Button()
        Me.RBHora14Lista = New System.Windows.Forms.RadioButton()
        Me.RBHora11Lista = New System.Windows.Forms.RadioButton()
        Me.RBHora8Lista = New System.Windows.Forms.RadioButton()
        Me.RBTodosLista = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PBotones = New System.Windows.Forms.Panel()
        Me.PDatos.SuspendLayout()
        Me.GBHorario.SuspendLayout()
        Me.GBProductos.SuspendLayout()
        CType(Me.NudEsponja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NudPaño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDesodorante.SuspendLayout()
        CType(Me.NudDesodorante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBDetergente.SuspendLayout()
        CType(Me.NudDetergente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBLavandina.SuspendLayout()
        CType(Me.NudLavandina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PBuscar.SuspendLayout()
        Me.PListado.SuspendLayout()
        Me.PBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'BEliminar
        '
        Me.BEliminar.Enabled = False
        Me.BEliminar.Location = New System.Drawing.Point(8, 9)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BEliminar.TabIndex = 0
        Me.BEliminar.Text = "&Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(130, 9)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BGuardar.TabIndex = 1
        Me.BGuardar.Text = "&Guardar"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'BLimpiar
        '
        Me.BLimpiar.Location = New System.Drawing.Point(217, 9)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BLimpiar.TabIndex = 2
        Me.BLimpiar.Text = "&Limpiar"
        Me.BLimpiar.UseVisualStyleBackColor = True
        '
        'BCerrar
        '
        Me.BCerrar.Location = New System.Drawing.Point(337, 333)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(125, 23)
        Me.BCerrar.TabIndex = 4
        Me.BCerrar.Text = "&Cerrar"
        Me.BCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Direccion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telefono:"
        '
        'PDatos
        '
        Me.PDatos.BackColor = System.Drawing.Color.PaleTurquoise
        Me.PDatos.Controls.Add(Me.MTTelefono)
        Me.PDatos.Controls.Add(Me.GBHorario)
        Me.PDatos.Controls.Add(Me.Label2)
        Me.PDatos.Controls.Add(Me.GBProductos)
        Me.PDatos.Controls.Add(Me.TDireccion)
        Me.PDatos.Controls.Add(Me.Label1)
        Me.PDatos.Controls.Add(Me.Label3)
        Me.PDatos.Controls.Add(Me.TCliente)
        Me.PDatos.Location = New System.Drawing.Point(11, 15)
        Me.PDatos.Name = "PDatos"
        Me.PDatos.Size = New System.Drawing.Size(304, 303)
        Me.PDatos.TabIndex = 0
        '
        'MTTelefono
        '
        Me.MTTelefono.Location = New System.Drawing.Point(64, 61)
        Me.MTTelefono.Mask = "(000)000-0000"
        Me.MTTelefono.Name = "MTTelefono"
        Me.MTTelefono.Size = New System.Drawing.Size(100, 20)
        Me.MTTelefono.TabIndex = 2
        Me.MTTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'GBHorario
        '
        Me.GBHorario.Controls.Add(Me.RBHora14)
        Me.GBHorario.Controls.Add(Me.RBHora11)
        Me.GBHorario.Controls.Add(Me.RBHora8)
        Me.GBHorario.Location = New System.Drawing.Point(178, 3)
        Me.GBHorario.Name = "GBHorario"
        Me.GBHorario.Size = New System.Drawing.Size(112, 97)
        Me.GBHorario.TabIndex = 3
        Me.GBHorario.TabStop = False
        Me.GBHorario.Text = "Horario de Entrega"
        '
        'RBHora14
        '
        Me.RBHora14.AutoSize = True
        Me.RBHora14.Location = New System.Drawing.Point(6, 68)
        Me.RBHora14.Name = "RBHora14"
        Me.RBHora14.Size = New System.Drawing.Size(90, 17)
        Me.RBHora14.TabIndex = 2
        Me.RBHora14.Text = "14 a 17 horas"
        Me.RBHora14.UseVisualStyleBackColor = True
        '
        'RBHora11
        '
        Me.RBHora11.AutoSize = True
        Me.RBHora11.Location = New System.Drawing.Point(7, 45)
        Me.RBHora11.Name = "RBHora11"
        Me.RBHora11.Size = New System.Drawing.Size(90, 17)
        Me.RBHora11.TabIndex = 1
        Me.RBHora11.Text = "11 a 14 horas"
        Me.RBHora11.UseVisualStyleBackColor = True
        '
        'RBHora8
        '
        Me.RBHora8.AutoSize = True
        Me.RBHora8.Checked = True
        Me.RBHora8.Location = New System.Drawing.Point(7, 22)
        Me.RBHora8.Name = "RBHora8"
        Me.RBHora8.Size = New System.Drawing.Size(90, 17)
        Me.RBHora8.TabIndex = 0
        Me.RBHora8.TabStop = True
        Me.RBHora8.Text = "08 a 11 horas"
        Me.RBHora8.UseVisualStyleBackColor = True
        '
        'GBProductos
        '
        Me.GBProductos.Controls.Add(Me.NudEsponja)
        Me.GBProductos.Controls.Add(Me.NudPaño)
        Me.GBProductos.Controls.Add(Me.GBDesodorante)
        Me.GBProductos.Controls.Add(Me.GBDetergente)
        Me.GBProductos.Controls.Add(Me.GBLavandina)
        Me.GBProductos.Controls.Add(Me.CheckPaño)
        Me.GBProductos.Controls.Add(Me.CheckEsponja)
        Me.GBProductos.Controls.Add(Me.CheckDesodorante)
        Me.GBProductos.Controls.Add(Me.CheckDetergente)
        Me.GBProductos.Controls.Add(Me.CheckLavandina)
        Me.GBProductos.Location = New System.Drawing.Point(9, 103)
        Me.GBProductos.Name = "GBProductos"
        Me.GBProductos.Size = New System.Drawing.Size(278, 197)
        Me.GBProductos.TabIndex = 4
        Me.GBProductos.TabStop = False
        Me.GBProductos.Text = "Productos"
        '
        'NudEsponja
        '
        Me.NudEsponja.Location = New System.Drawing.Point(235, 19)
        Me.NudEsponja.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NudEsponja.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudEsponja.Name = "NudEsponja"
        Me.NudEsponja.Size = New System.Drawing.Size(30, 20)
        Me.NudEsponja.TabIndex = 3
        Me.NudEsponja.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudEsponja.Visible = False
        '
        'NudPaño
        '
        Me.NudPaño.Location = New System.Drawing.Point(108, 17)
        Me.NudPaño.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NudPaño.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudPaño.Name = "NudPaño"
        Me.NudPaño.Size = New System.Drawing.Size(30, 20)
        Me.NudPaño.TabIndex = 1
        Me.NudPaño.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudPaño.Visible = False
        '
        'GBDesodorante
        '
        Me.GBDesodorante.Controls.Add(Me.NudDesodorante)
        Me.GBDesodorante.Controls.Add(Me.RB125lDeso)
        Me.GBDesodorante.Controls.Add(Me.RB750mlDeso)
        Me.GBDesodorante.Controls.Add(Me.Label7)
        Me.GBDesodorante.Enabled = False
        Me.GBDesodorante.Location = New System.Drawing.Point(173, 85)
        Me.GBDesodorante.Name = "GBDesodorante"
        Me.GBDesodorante.Size = New System.Drawing.Size(87, 100)
        Me.GBDesodorante.TabIndex = 9
        Me.GBDesodorante.TabStop = False
        Me.GBDesodorante.Text = "Desodorante"
        '
        'NudDesodorante
        '
        Me.NudDesodorante.Location = New System.Drawing.Point(36, 31)
        Me.NudDesodorante.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NudDesodorante.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudDesodorante.Name = "NudDesodorante"
        Me.NudDesodorante.Size = New System.Drawing.Size(30, 20)
        Me.NudDesodorante.TabIndex = 1
        Me.NudDesodorante.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RB125lDeso
        '
        Me.RB125lDeso.AutoSize = True
        Me.RB125lDeso.Location = New System.Drawing.Point(17, 81)
        Me.RB125lDeso.Name = "RB125lDeso"
        Me.RB125lDeso.Size = New System.Drawing.Size(65, 17)
        Me.RB125lDeso.TabIndex = 3
        Me.RB125lDeso.Text = "1.25 litro"
        Me.RB125lDeso.UseVisualStyleBackColor = True
        '
        'RB750mlDeso
        '
        Me.RB750mlDeso.AutoSize = True
        Me.RB750mlDeso.Checked = True
        Me.RB750mlDeso.Location = New System.Drawing.Point(17, 58)
        Me.RB750mlDeso.Name = "RB750mlDeso"
        Me.RB750mlDeso.Size = New System.Drawing.Size(56, 17)
        Me.RB750mlDeso.TabIndex = 2
        Me.RB750mlDeso.TabStop = True
        Me.RB750mlDeso.Text = "750 ml"
        Me.RB750mlDeso.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "cant.:"
        '
        'GBDetergente
        '
        Me.GBDetergente.Controls.Add(Me.NudDetergente)
        Me.GBDetergente.Controls.Add(Me.RB750mlDeter)
        Me.GBDetergente.Controls.Add(Me.RB500mlDeter)
        Me.GBDetergente.Controls.Add(Me.Label6)
        Me.GBDetergente.Enabled = False
        Me.GBDetergente.Location = New System.Drawing.Point(81, 85)
        Me.GBDetergente.Name = "GBDetergente"
        Me.GBDetergente.Size = New System.Drawing.Size(85, 100)
        Me.GBDetergente.TabIndex = 8
        Me.GBDetergente.TabStop = False
        Me.GBDetergente.Text = "Detergente"
        '
        'NudDetergente
        '
        Me.NudDetergente.Location = New System.Drawing.Point(41, 31)
        Me.NudDetergente.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NudDetergente.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudDetergente.Name = "NudDetergente"
        Me.NudDetergente.Size = New System.Drawing.Size(30, 20)
        Me.NudDetergente.TabIndex = 1
        Me.NudDetergente.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RB750mlDeter
        '
        Me.RB750mlDeter.AutoSize = True
        Me.RB750mlDeter.Location = New System.Drawing.Point(15, 81)
        Me.RB750mlDeter.Name = "RB750mlDeter"
        Me.RB750mlDeter.Size = New System.Drawing.Size(56, 17)
        Me.RB750mlDeter.TabIndex = 3
        Me.RB750mlDeter.Text = "750 ml"
        Me.RB750mlDeter.UseVisualStyleBackColor = True
        '
        'RB500mlDeter
        '
        Me.RB500mlDeter.AutoSize = True
        Me.RB500mlDeter.Checked = True
        Me.RB500mlDeter.Location = New System.Drawing.Point(15, 58)
        Me.RB500mlDeter.Name = "RB500mlDeter"
        Me.RB500mlDeter.Size = New System.Drawing.Size(56, 17)
        Me.RB500mlDeter.TabIndex = 2
        Me.RB500mlDeter.TabStop = True
        Me.RB500mlDeter.Text = "500 ml"
        Me.RB500mlDeter.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "cant.:"
        '
        'GBLavandina
        '
        Me.GBLavandina.Controls.Add(Me.NudLavandina)
        Me.GBLavandina.Controls.Add(Me.RB5lLavan)
        Me.GBLavandina.Controls.Add(Me.RB1lLavan)
        Me.GBLavandina.Controls.Add(Me.Label5)
        Me.GBLavandina.Enabled = False
        Me.GBLavandina.Location = New System.Drawing.Point(0, 85)
        Me.GBLavandina.Name = "GBLavandina"
        Me.GBLavandina.Size = New System.Drawing.Size(75, 100)
        Me.GBLavandina.TabIndex = 7
        Me.GBLavandina.TabStop = False
        Me.GBLavandina.Text = "Lavandina"
        '
        'NudLavandina
        '
        Me.NudLavandina.Location = New System.Drawing.Point(39, 31)
        Me.NudLavandina.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NudLavandina.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NudLavandina.Name = "NudLavandina"
        Me.NudLavandina.Size = New System.Drawing.Size(30, 20)
        Me.NudLavandina.TabIndex = 1
        Me.NudLavandina.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RB5lLavan
        '
        Me.RB5lLavan.AutoSize = True
        Me.RB5lLavan.Location = New System.Drawing.Point(2, 81)
        Me.RB5lLavan.Name = "RB5lLavan"
        Me.RB5lLavan.Size = New System.Drawing.Size(55, 17)
        Me.RB5lLavan.TabIndex = 3
        Me.RB5lLavan.Text = "5 litros"
        Me.RB5lLavan.UseVisualStyleBackColor = True
        '
        'RB1lLavan
        '
        Me.RB1lLavan.AutoSize = True
        Me.RB1lLavan.Checked = True
        Me.RB1lLavan.Location = New System.Drawing.Point(2, 58)
        Me.RB1lLavan.Name = "RB1lLavan"
        Me.RB1lLavan.Size = New System.Drawing.Size(50, 17)
        Me.RB1lLavan.TabIndex = 2
        Me.RB1lLavan.TabStop = True
        Me.RB1lLavan.Text = "1 litro"
        Me.RB1lLavan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-1, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "cant.:"
        '
        'CheckPaño
        '
        Me.CheckPaño.AutoSize = True
        Me.CheckPaño.Location = New System.Drawing.Point(61, 20)
        Me.CheckPaño.Name = "CheckPaño"
        Me.CheckPaño.Size = New System.Drawing.Size(51, 17)
        Me.CheckPaño.TabIndex = 0
        Me.CheckPaño.Text = "Paño"
        Me.CheckPaño.UseVisualStyleBackColor = True
        '
        'CheckEsponja
        '
        Me.CheckEsponja.AutoSize = True
        Me.CheckEsponja.Location = New System.Drawing.Point(174, 20)
        Me.CheckEsponja.Name = "CheckEsponja"
        Me.CheckEsponja.Size = New System.Drawing.Size(64, 17)
        Me.CheckEsponja.TabIndex = 2
        Me.CheckEsponja.Text = "Esponja"
        Me.CheckEsponja.UseVisualStyleBackColor = True
        '
        'CheckDesodorante
        '
        Me.CheckDesodorante.AutoSize = True
        Me.CheckDesodorante.Location = New System.Drawing.Point(178, 43)
        Me.CheckDesodorante.Name = "CheckDesodorante"
        Me.CheckDesodorante.Size = New System.Drawing.Size(87, 17)
        Me.CheckDesodorante.TabIndex = 6
        Me.CheckDesodorante.Text = "Desodorante"
        Me.CheckDesodorante.UseVisualStyleBackColor = True
        '
        'CheckDetergente
        '
        Me.CheckDetergente.AutoSize = True
        Me.CheckDetergente.Location = New System.Drawing.Point(92, 43)
        Me.CheckDetergente.Name = "CheckDetergente"
        Me.CheckDetergente.Size = New System.Drawing.Size(79, 17)
        Me.CheckDetergente.TabIndex = 5
        Me.CheckDetergente.Text = "Detergente"
        Me.CheckDetergente.UseVisualStyleBackColor = True
        '
        'CheckLavandina
        '
        Me.CheckLavandina.AutoSize = True
        Me.CheckLavandina.Location = New System.Drawing.Point(10, 43)
        Me.CheckLavandina.Name = "CheckLavandina"
        Me.CheckLavandina.Size = New System.Drawing.Size(76, 17)
        Me.CheckLavandina.TabIndex = 4
        Me.CheckLavandina.Text = "Lavandina"
        Me.CheckLavandina.UseVisualStyleBackColor = True
        '
        'TDireccion
        '
        Me.TDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TDireccion.Location = New System.Drawing.Point(64, 35)
        Me.TDireccion.MaxLength = 40
        Me.TDireccion.Name = "TDireccion"
        Me.TDireccion.Size = New System.Drawing.Size(100, 20)
        Me.TDireccion.TabIndex = 1
        '
        'TCliente
        '
        Me.TCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TCliente.Location = New System.Drawing.Point(65, 10)
        Me.TCliente.MaxLength = 40
        Me.TCliente.Name = "TCliente"
        Me.TCliente.Size = New System.Drawing.Size(100, 20)
        Me.TCliente.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Pedido por "
        '
        'RBPorCliente
        '
        Me.RBPorCliente.AutoSize = True
        Me.RBPorCliente.Checked = True
        Me.RBPorCliente.Location = New System.Drawing.Point(80, 11)
        Me.RBPorCliente.Name = "RBPorCliente"
        Me.RBPorCliente.Size = New System.Drawing.Size(57, 17)
        Me.RBPorCliente.TabIndex = 1
        Me.RBPorCliente.TabStop = True
        Me.RBPorCliente.Text = "Cliente"
        Me.RBPorCliente.UseVisualStyleBackColor = True
        '
        'RBPorDireccion
        '
        Me.RBPorDireccion.AutoSize = True
        Me.RBPorDireccion.Location = New System.Drawing.Point(80, 34)
        Me.RBPorDireccion.Name = "RBPorDireccion"
        Me.RBPorDireccion.Size = New System.Drawing.Size(70, 17)
        Me.RBPorDireccion.TabIndex = 2
        Me.RBPorDireccion.Text = "Direccion"
        Me.RBPorDireccion.UseVisualStyleBackColor = True
        '
        'RBPorTelefono
        '
        Me.RBPorTelefono.AutoSize = True
        Me.RBPorTelefono.Location = New System.Drawing.Point(80, 57)
        Me.RBPorTelefono.Name = "RBPorTelefono"
        Me.RBPorTelefono.Size = New System.Drawing.Size(67, 17)
        Me.RBPorTelefono.TabIndex = 3
        Me.RBPorTelefono.Text = "Telefono"
        Me.RBPorTelefono.UseVisualStyleBackColor = True
        '
        'TBuscar
        '
        Me.TBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBuscar.Location = New System.Drawing.Point(16, 80)
        Me.TBuscar.MaxLength = 40
        Me.TBuscar.Name = "TBuscar"
        Me.TBuscar.Size = New System.Drawing.Size(134, 20)
        Me.TBuscar.TabIndex = 4
        '
        'BMostrar
        '
        Me.BMostrar.Location = New System.Drawing.Point(16, 106)
        Me.BMostrar.Name = "BMostrar"
        Me.BMostrar.Size = New System.Drawing.Size(134, 23)
        Me.BMostrar.TabIndex = 5
        Me.BMostrar.Text = "&Mostrar"
        Me.BMostrar.UseVisualStyleBackColor = True
        '
        'PBuscar
        '
        Me.PBuscar.BackColor = System.Drawing.Color.NavajoWhite
        Me.PBuscar.Controls.Add(Me.Label8)
        Me.PBuscar.Controls.Add(Me.BMostrar)
        Me.PBuscar.Controls.Add(Me.RBPorCliente)
        Me.PBuscar.Controls.Add(Me.TBuscar)
        Me.PBuscar.Controls.Add(Me.RBPorDireccion)
        Me.PBuscar.Controls.Add(Me.RBPorTelefono)
        Me.PBuscar.Location = New System.Drawing.Point(321, 15)
        Me.PBuscar.Name = "PBuscar"
        Me.PBuscar.Size = New System.Drawing.Size(161, 145)
        Me.PBuscar.TabIndex = 2
        '
        'PListado
        '
        Me.PListado.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.PListado.Controls.Add(Me.BListar)
        Me.PListado.Controls.Add(Me.RBHora14Lista)
        Me.PListado.Controls.Add(Me.RBHora11Lista)
        Me.PListado.Controls.Add(Me.RBHora8Lista)
        Me.PListado.Controls.Add(Me.RBTodosLista)
        Me.PListado.Controls.Add(Me.Label9)
        Me.PListado.Location = New System.Drawing.Point(321, 166)
        Me.PListado.Name = "PListado"
        Me.PListado.Size = New System.Drawing.Size(161, 152)
        Me.PListado.TabIndex = 3
        '
        'BListar
        '
        Me.BListar.Location = New System.Drawing.Point(13, 117)
        Me.BListar.Name = "BListar"
        Me.BListar.Size = New System.Drawing.Size(134, 23)
        Me.BListar.TabIndex = 4
        Me.BListar.Text = "L&istar"
        Me.BListar.UseVisualStyleBackColor = True
        '
        'RBHora14Lista
        '
        Me.RBHora14Lista.AutoSize = True
        Me.RBHora14Lista.Location = New System.Drawing.Point(72, 85)
        Me.RBHora14Lista.Name = "RBHora14Lista"
        Me.RBHora14Lista.Size = New System.Drawing.Size(75, 17)
        Me.RBHora14Lista.TabIndex = 3
        Me.RBHora14Lista.Text = "14 a 17 hs"
        Me.RBHora14Lista.UseVisualStyleBackColor = True
        '
        'RBHora11Lista
        '
        Me.RBHora11Lista.AutoSize = True
        Me.RBHora11Lista.Location = New System.Drawing.Point(72, 62)
        Me.RBHora11Lista.Name = "RBHora11Lista"
        Me.RBHora11Lista.Size = New System.Drawing.Size(75, 17)
        Me.RBHora11Lista.TabIndex = 2
        Me.RBHora11Lista.Text = "11 a 14 hs"
        Me.RBHora11Lista.UseVisualStyleBackColor = True
        '
        'RBHora8Lista
        '
        Me.RBHora8Lista.AutoSize = True
        Me.RBHora8Lista.Location = New System.Drawing.Point(72, 39)
        Me.RBHora8Lista.Name = "RBHora8Lista"
        Me.RBHora8Lista.Size = New System.Drawing.Size(69, 17)
        Me.RBHora8Lista.TabIndex = 1
        Me.RBHora8Lista.Text = "8 a 11 hs"
        Me.RBHora8Lista.UseVisualStyleBackColor = True
        '
        'RBTodosLista
        '
        Me.RBTodosLista.AutoSize = True
        Me.RBTodosLista.Checked = True
        Me.RBTodosLista.Location = New System.Drawing.Point(72, 16)
        Me.RBTodosLista.Name = "RBTodosLista"
        Me.RBTodosLista.Size = New System.Drawing.Size(55, 17)
        Me.RBTodosLista.TabIndex = 0
        Me.RBTodosLista.TabStop = True
        Me.RBTodosLista.Text = "Todos"
        Me.RBTodosLista.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Horario:"
        '
        'PBotones
        '
        Me.PBotones.BackColor = System.Drawing.Color.PaleGreen
        Me.PBotones.Controls.Add(Me.BLimpiar)
        Me.PBotones.Controls.Add(Me.BGuardar)
        Me.PBotones.Controls.Add(Me.BEliminar)
        Me.PBotones.Location = New System.Drawing.Point(12, 324)
        Me.PBotones.Name = "PBotones"
        Me.PBotones.Size = New System.Drawing.Size(303, 39)
        Me.PBotones.TabIndex = 1
        '
        'FPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 369)
        Me.Controls.Add(Me.PBotones)
        Me.Controls.Add(Me.PListado)
        Me.Controls.Add(Me.PBuscar)
        Me.Controls.Add(Me.PDatos)
        Me.Controls.Add(Me.BCerrar)
        Me.Name = "FPedidos"
        Me.Text = "Pedidos de Limpieza"
        Me.PDatos.ResumeLayout(False)
        Me.PDatos.PerformLayout()
        Me.GBHorario.ResumeLayout(False)
        Me.GBHorario.PerformLayout()
        Me.GBProductos.ResumeLayout(False)
        Me.GBProductos.PerformLayout()
        CType(Me.NudEsponja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NudPaño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDesodorante.ResumeLayout(False)
        Me.GBDesodorante.PerformLayout()
        CType(Me.NudDesodorante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBDetergente.ResumeLayout(False)
        Me.GBDetergente.PerformLayout()
        CType(Me.NudDetergente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBLavandina.ResumeLayout(False)
        Me.GBLavandina.PerformLayout()
        CType(Me.NudLavandina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PBuscar.ResumeLayout(False)
        Me.PBuscar.PerformLayout()
        Me.PListado.ResumeLayout(False)
        Me.PListado.PerformLayout()
        Me.PBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BEliminar As Button
    Friend WithEvents BGuardar As Button
    Friend WithEvents BLimpiar As Button
    Friend WithEvents BCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PDatos As Panel
    Friend WithEvents GBHorario As GroupBox
    Friend WithEvents GBProductos As GroupBox
    Friend WithEvents MTTelefono As MaskedTextBox
    Friend WithEvents TDireccion As TextBox
    Friend WithEvents TCliente As TextBox
    Friend WithEvents RBHora8 As RadioButton
    Friend WithEvents GBDesodorante As GroupBox
    Friend WithEvents GBDetergente As GroupBox
    Friend WithEvents CheckDesodorante As CheckBox
    Friend WithEvents CheckDetergente As CheckBox
    Friend WithEvents CheckLavandina As CheckBox
    Friend WithEvents CheckEsponja As CheckBox
    Friend WithEvents CheckPaño As CheckBox
    Friend WithEvents RBHora14 As RadioButton
    Friend WithEvents RBHora11 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents NudDesodorante As NumericUpDown
    Friend WithEvents RB125lDeso As RadioButton
    Friend WithEvents RB750mlDeso As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents NudDetergente As NumericUpDown
    Friend WithEvents RB750mlDeter As RadioButton
    Friend WithEvents RB500mlDeter As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents NudLavandina As NumericUpDown
    Friend WithEvents RB5lLavan As RadioButton
    Friend WithEvents RB1lLavan As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents RBPorCliente As RadioButton
    Friend WithEvents RBPorDireccion As RadioButton
    Friend WithEvents RBPorTelefono As RadioButton
    Friend WithEvents TBuscar As TextBox
    Friend WithEvents BMostrar As Button
    Friend WithEvents PBuscar As Panel
    Friend WithEvents PListado As Panel
    Friend WithEvents BListar As Button
    Friend WithEvents RBHora14Lista As RadioButton
    Friend WithEvents RBHora11Lista As RadioButton
    Friend WithEvents RBHora8Lista As RadioButton
    Friend WithEvents RBTodosLista As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents PBotones As Panel
    Friend WithEvents NudEsponja As NumericUpDown
    Friend WithEvents NudPaño As NumericUpDown
    Private WithEvents GBLavandina As GroupBox
End Class
