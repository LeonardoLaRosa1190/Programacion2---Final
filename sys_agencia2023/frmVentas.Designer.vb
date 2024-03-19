<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVentas
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
        Me.components = New System.ComponentModel.Container()
        Dim Id_ventaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim Id_vendedorLabel As System.Windows.Forms.Label
        Dim Id_clienteLabel As System.Windows.Forms.Label
        Dim Id_autoLabel As System.Windows.Forms.Label
        Dim ImporteLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVentas))
        Me.Agencia_2023DataSet = New sys_agencia2023.agencia_2023DataSet()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New sys_agencia2023.agencia_2023DataSetTableAdapters.ventasTableAdapter()
        Me.TableAdapterManager = New sys_agencia2023.agencia_2023DataSetTableAdapters.TableAdapterManager()
        Me.VentasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_ventaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Id_vendedorTextBox = New System.Windows.Forms.TextBox()
        Me.Id_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.Id_autoTextBox = New System.Windows.Forms.TextBox()
        Me.ImporteTextBox = New System.Windows.Forms.TextBox()
        Me.btnImprimirventas_fecha = New System.Windows.Forms.Button()
        Me.btnImprimirInforme_autos = New System.Windows.Forms.Button()
        Me.btnAutos = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnVendedor = New System.Windows.Forms.Button()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.VentasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Id_ventaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        Id_vendedorLabel = New System.Windows.Forms.Label()
        Id_clienteLabel = New System.Windows.Forms.Label()
        Id_autoLabel = New System.Windows.Forms.Label()
        ImporteLabel = New System.Windows.Forms.Label()
        CType(Me.Agencia_2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VentasBindingNavigator.SuspendLayout()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_ventaLabel
        '
        Id_ventaLabel.AutoSize = True
        Id_ventaLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_ventaLabel.Location = New System.Drawing.Point(40, 224)
        Id_ventaLabel.Name = "Id_ventaLabel"
        Id_ventaLabel.Size = New System.Drawing.Size(78, 19)
        Id_ventaLabel.TabIndex = 2
        Id_ventaLabel.Text = "ID Venta:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(56, 264)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(62, 19)
        FechaLabel.TabIndex = 4
        FechaLabel.Text = "Fecha:"
        '
        'Id_vendedorLabel
        '
        Id_vendedorLabel.AutoSize = True
        Id_vendedorLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_vendedorLabel.Location = New System.Drawing.Point(8, 304)
        Id_vendedorLabel.Name = "Id_vendedorLabel"
        Id_vendedorLabel.Size = New System.Drawing.Size(109, 19)
        Id_vendedorLabel.TabIndex = 6
        Id_vendedorLabel.Text = "ID Vendedor:"
        '
        'Id_clienteLabel
        '
        Id_clienteLabel.AutoSize = True
        Id_clienteLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_clienteLabel.Location = New System.Drawing.Point(32, 344)
        Id_clienteLabel.Name = "Id_clienteLabel"
        Id_clienteLabel.Size = New System.Drawing.Size(88, 19)
        Id_clienteLabel.TabIndex = 8
        Id_clienteLabel.Text = "ID Cliente:"
        '
        'Id_autoLabel
        '
        Id_autoLabel.AutoSize = True
        Id_autoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_autoLabel.Location = New System.Drawing.Point(48, 384)
        Id_autoLabel.Name = "Id_autoLabel"
        Id_autoLabel.Size = New System.Drawing.Size(70, 19)
        Id_autoLabel.TabIndex = 10
        Id_autoLabel.Text = "ID Auto:"
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImporteLabel.Location = New System.Drawing.Point(48, 424)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(73, 19)
        ImporteLabel.TabIndex = 12
        ImporteLabel.Text = "Importe:"
        '
        'Agencia_2023DataSet
        '
        Me.Agencia_2023DataSet.DataSetName = "agencia_2023DataSet"
        Me.Agencia_2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "ventas"
        Me.VentasBindingSource.DataSource = Me.Agencia_2023DataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.autosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.empresaTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sys_agencia2023.agencia_2023DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.vendedoresTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Me.VentasTableAdapter
        '
        'VentasBindingNavigator
        '
        Me.VentasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VentasBindingNavigator.BindingSource = Me.VentasBindingSource
        Me.VentasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VentasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VentasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VentasBindingNavigatorSaveItem})
        Me.VentasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VentasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VentasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VentasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VentasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VentasBindingNavigator.Name = "VentasBindingNavigator"
        Me.VentasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VentasBindingNavigator.Size = New System.Drawing.Size(684, 25)
        Me.VentasBindingNavigator.TabIndex = 0
        Me.VentasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.AllowUserToAddRows = False
        Me.VentasDataGridView.AllowUserToDeleteRows = False
        Me.VentasDataGridView.AllowUserToResizeColumns = False
        Me.VentasDataGridView.AllowUserToResizeRows = False
        Me.VentasDataGridView.AutoGenerateColumns = False
        Me.VentasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VentasDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        Me.VentasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VentasDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.VentasDataGridView.DataSource = Me.VentasBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VentasDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.VentasDataGridView.Location = New System.Drawing.Point(8, 32)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VentasDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.VentasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VentasDataGridView.Size = New System.Drawing.Size(672, 180)
        Me.VentasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_venta"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_venta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id_vendedor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "id_vendedor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn4.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id_auto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "id_auto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "importe"
        Me.DataGridViewTextBoxColumn6.HeaderText = "importe"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Id_ventaTextBox
        '
        Me.Id_ventaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "id_venta", True))
        Me.Id_ventaTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_ventaTextBox.Location = New System.Drawing.Point(136, 224)
        Me.Id_ventaTextBox.Name = "Id_ventaTextBox"
        Me.Id_ventaTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Id_ventaTextBox.TabIndex = 3
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(136, 264)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(299, 26)
        Me.FechaDateTimePicker.TabIndex = 5
        '
        'Id_vendedorTextBox
        '
        Me.Id_vendedorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "id_vendedor", True))
        Me.Id_vendedorTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_vendedorTextBox.Location = New System.Drawing.Point(136, 304)
        Me.Id_vendedorTextBox.Name = "Id_vendedorTextBox"
        Me.Id_vendedorTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Id_vendedorTextBox.TabIndex = 7
        '
        'Id_clienteTextBox
        '
        Me.Id_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "id_cliente", True))
        Me.Id_clienteTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_clienteTextBox.Location = New System.Drawing.Point(136, 344)
        Me.Id_clienteTextBox.Name = "Id_clienteTextBox"
        Me.Id_clienteTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Id_clienteTextBox.TabIndex = 9
        '
        'Id_autoTextBox
        '
        Me.Id_autoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "id_auto", True))
        Me.Id_autoTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_autoTextBox.Location = New System.Drawing.Point(136, 384)
        Me.Id_autoTextBox.Name = "Id_autoTextBox"
        Me.Id_autoTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Id_autoTextBox.TabIndex = 11
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "importe", True))
        Me.ImporteTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImporteTextBox.Location = New System.Drawing.Point(136, 424)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ImporteTextBox.TabIndex = 13
        '
        'btnImprimirventas_fecha
        '
        Me.btnImprimirventas_fecha.BackColor = System.Drawing.SystemColors.Window
        Me.btnImprimirventas_fecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimirventas_fecha.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText
        Me.btnImprimirventas_fecha.FlatAppearance.BorderSize = 3
        Me.btnImprimirventas_fecha.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnImprimirventas_fecha.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnImprimirventas_fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirventas_fecha.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirventas_fecha.Image = Global.sys_agencia2023.My.Resources.Resources.ventasporFecha_menuPrincipal2
        Me.btnImprimirventas_fecha.Location = New System.Drawing.Point(440, 408)
        Me.btnImprimirventas_fecha.Name = "btnImprimirventas_fecha"
        Me.btnImprimirventas_fecha.Size = New System.Drawing.Size(216, 48)
        Me.btnImprimirventas_fecha.TabIndex = 24
        Me.btnImprimirventas_fecha.Text = "Imprimir ventas por fecha"
        Me.btnImprimirventas_fecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimirventas_fecha.UseVisualStyleBackColor = False
        '
        'btnImprimirInforme_autos
        '
        Me.btnImprimirInforme_autos.BackColor = System.Drawing.SystemColors.Window
        Me.btnImprimirInforme_autos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimirInforme_autos.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText
        Me.btnImprimirInforme_autos.FlatAppearance.BorderSize = 3
        Me.btnImprimirInforme_autos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnImprimirInforme_autos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnImprimirInforme_autos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimirInforme_autos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirInforme_autos.Image = Global.sys_agencia2023.My.Resources.Resources.imprimir_menuPrincipal
        Me.btnImprimirInforme_autos.Location = New System.Drawing.Point(456, 344)
        Me.btnImprimirInforme_autos.Name = "btnImprimirInforme_autos"
        Me.btnImprimirInforme_autos.Size = New System.Drawing.Size(176, 48)
        Me.btnImprimirInforme_autos.TabIndex = 23
        Me.btnImprimirInforme_autos.Text = "Imprimir informe"
        Me.btnImprimirInforme_autos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimirInforme_autos.UseVisualStyleBackColor = False
        '
        'btnAutos
        '
        Me.btnAutos.BackColor = System.Drawing.SystemColors.Window
        Me.btnAutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutos.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText
        Me.btnAutos.FlatAppearance.BorderSize = 3
        Me.btnAutos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAutos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnAutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutos.Image = Global.sys_agencia2023.My.Resources.Resources.add_ventas1
        Me.btnAutos.Location = New System.Drawing.Point(248, 384)
        Me.btnAutos.Name = "btnAutos"
        Me.btnAutos.Size = New System.Drawing.Size(48, 32)
        Me.btnAutos.TabIndex = 18
        Me.btnAutos.UseVisualStyleBackColor = False
        '
        'btnCliente
        '
        Me.btnCliente.BackColor = System.Drawing.SystemColors.Window
        Me.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText
        Me.btnCliente.FlatAppearance.BorderSize = 3
        Me.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Image = Global.sys_agencia2023.My.Resources.Resources.add_ventas1
        Me.btnCliente.Location = New System.Drawing.Point(248, 344)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(48, 32)
        Me.btnCliente.TabIndex = 17
        Me.btnCliente.UseVisualStyleBackColor = False
        '
        'btnVendedor
        '
        Me.btnVendedor.BackColor = System.Drawing.SystemColors.Window
        Me.btnVendedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVendedor.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText
        Me.btnVendedor.FlatAppearance.BorderSize = 3
        Me.btnVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVendedor.Image = Global.sys_agencia2023.My.Resources.Resources.add_ventas1
        Me.btnVendedor.Location = New System.Drawing.Point(248, 304)
        Me.btnVendedor.Name = "btnVendedor"
        Me.btnVendedor.Size = New System.Drawing.Size(48, 32)
        Me.btnVendedor.TabIndex = 16
        Me.btnVendedor.UseVisualStyleBackColor = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'VentasBindingNavigatorSaveItem
        '
        Me.VentasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VentasBindingNavigatorSaveItem.Image = CType(resources.GetObject("VentasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VentasBindingNavigatorSaveItem.Name = "VentasBindingNavigatorSaveItem"
        Me.VentasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VentasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'frmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.btnImprimirventas_fecha)
        Me.Controls.Add(Me.btnImprimirInforme_autos)
        Me.Controls.Add(Me.btnAutos)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnVendedor)
        Me.Controls.Add(Id_ventaLabel)
        Me.Controls.Add(Me.Id_ventaTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Id_vendedorLabel)
        Me.Controls.Add(Me.Id_vendedorTextBox)
        Me.Controls.Add(Id_clienteLabel)
        Me.Controls.Add(Me.Id_clienteTextBox)
        Me.Controls.Add(Id_autoLabel)
        Me.Controls.Add(Me.Id_autoTextBox)
        Me.Controls.Add(ImporteLabel)
        Me.Controls.Add(Me.ImporteTextBox)
        Me.Controls.Add(Me.VentasDataGridView)
        Me.Controls.Add(Me.VentasBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "V E N T A S"
        CType(Me.Agencia_2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VentasBindingNavigator.ResumeLayout(False)
        Me.VentasBindingNavigator.PerformLayout()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Agencia_2023DataSet As agencia_2023DataSet
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As agencia_2023DataSetTableAdapters.ventasTableAdapter
    Friend WithEvents TableAdapterManager As agencia_2023DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VentasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents VentasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VentasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Id_ventaTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents Id_vendedorTextBox As TextBox
    Friend WithEvents Id_clienteTextBox As TextBox
    Friend WithEvents Id_autoTextBox As TextBox
    Friend WithEvents ImporteTextBox As TextBox
    Friend WithEvents btnVendedor As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnAutos As Button
    Friend WithEvents btnImprimirInforme_autos As Button
    Friend WithEvents btnImprimirventas_fecha As Button
End Class
