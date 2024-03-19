<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Id_autoLabel As System.Windows.Forms.Label
        Dim MarcaLabel As System.Windows.Forms.Label
        Dim ModeloLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim AñoLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim KmLabel As System.Windows.Forms.Label
        Dim ObsvLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutos))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Agencia_2023DataSet = New sys_agencia2023.agencia_2023DataSet()
        Me.AutosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AutosTableAdapter = New sys_agencia2023.agencia_2023DataSetTableAdapters.autosTableAdapter()
        Me.TableAdapterManager = New sys_agencia2023.agencia_2023DataSetTableAdapters.TableAdapterManager()
        Me.AutosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AutosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AutosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_autoTextBox = New System.Windows.Forms.TextBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.AñoTextBox = New System.Windows.Forms.TextBox()
        Me.CostoTextBox = New System.Windows.Forms.TextBox()
        Me.KmTextBox = New System.Windows.Forms.TextBox()
        Me.ObsvTextBox = New System.Windows.Forms.TextBox()
        Me.pickboxAuto = New System.Windows.Forms.PictureBox()
        Me.btnImprimirInforme_autos = New System.Windows.Forms.Button()
        Me.FotoTextBox = New System.Windows.Forms.TextBox()
        Id_autoLabel = New System.Windows.Forms.Label()
        MarcaLabel = New System.Windows.Forms.Label()
        ModeloLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        AñoLabel = New System.Windows.Forms.Label()
        CostoLabel = New System.Windows.Forms.Label()
        KmLabel = New System.Windows.Forms.Label()
        ObsvLabel = New System.Windows.Forms.Label()
        CType(Me.Agencia_2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AutosBindingNavigator.SuspendLayout()
        CType(Me.AutosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pickboxAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_autoLabel
        '
        Id_autoLabel.AutoSize = True
        Id_autoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_autoLabel.Location = New System.Drawing.Point(56, 280)
        Id_autoLabel.Name = "Id_autoLabel"
        Id_autoLabel.Size = New System.Drawing.Size(70, 19)
        Id_autoLabel.TabIndex = 2
        Id_autoLabel.Text = "ID Auto:"
        AddHandler Id_autoLabel.Click, AddressOf Me.Id_autoLabel_Click
        '
        'MarcaLabel
        '
        MarcaLabel.AutoSize = True
        MarcaLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarcaLabel.Location = New System.Drawing.Point(56, 312)
        MarcaLabel.Name = "MarcaLabel"
        MarcaLabel.Size = New System.Drawing.Size(61, 19)
        MarcaLabel.TabIndex = 4
        MarcaLabel.Text = "Marca:"
        '
        'ModeloLabel
        '
        ModeloLabel.AutoSize = True
        ModeloLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModeloLabel.Location = New System.Drawing.Point(288, 280)
        ModeloLabel.Name = "ModeloLabel"
        ModeloLabel.Size = New System.Drawing.Size(71, 19)
        ModeloLabel.TabIndex = 6
        ModeloLabel.Text = "Modelo:"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ColorLabel.Location = New System.Drawing.Point(288, 312)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(57, 19)
        ColorLabel.TabIndex = 8
        ColorLabel.Text = "Color:"
        '
        'AñoLabel
        '
        AñoLabel.AutoSize = True
        AñoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AñoLabel.Location = New System.Drawing.Point(288, 344)
        AñoLabel.Name = "AñoLabel"
        AñoLabel.Size = New System.Drawing.Size(46, 19)
        AñoLabel.TabIndex = 10
        AñoLabel.Text = "Año:"
        '
        'CostoLabel
        '
        CostoLabel.AutoSize = True
        CostoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CostoLabel.Location = New System.Drawing.Point(520, 272)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(61, 19)
        CostoLabel.TabIndex = 12
        CostoLabel.Text = "Costo:"
        '
        'KmLabel
        '
        KmLabel.AutoSize = True
        KmLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KmLabel.Location = New System.Drawing.Point(520, 304)
        KmLabel.Name = "KmLabel"
        KmLabel.Size = New System.Drawing.Size(40, 19)
        KmLabel.TabIndex = 14
        KmLabel.Text = "KM:"
        '
        'ObsvLabel
        '
        ObsvLabel.AutoSize = True
        ObsvLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObsvLabel.Location = New System.Drawing.Point(720, 272)
        ObsvLabel.Name = "ObsvLabel"
        ObsvLabel.Size = New System.Drawing.Size(55, 19)
        ObsvLabel.TabIndex = 18
        ObsvLabel.Text = "Obsv:"
        '
        'Agencia_2023DataSet
        '
        Me.Agencia_2023DataSet.DataSetName = "agencia_2023DataSet"
        Me.Agencia_2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AutosBindingSource
        '
        Me.AutosBindingSource.DataMember = "autos"
        Me.AutosBindingSource.DataSource = Me.Agencia_2023DataSet
        '
        'AutosTableAdapter
        '
        Me.AutosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.autosTableAdapter = Me.AutosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.empresaTableAdapter = Nothing
        Me.TableAdapterManager.localidadesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = sys_agencia2023.agencia_2023DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.vendedoresTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'AutosBindingNavigator
        '
        Me.AutosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AutosBindingNavigator.BindingSource = Me.AutosBindingSource
        Me.AutosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AutosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AutosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AutosBindingNavigatorSaveItem})
        Me.AutosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AutosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AutosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AutosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AutosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AutosBindingNavigator.Name = "AutosBindingNavigator"
        Me.AutosBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.AutosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AutosBindingNavigator.Size = New System.Drawing.Size(1028, 25)
        Me.AutosBindingNavigator.TabIndex = 0
        Me.AutosBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(55, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AutosBindingNavigatorSaveItem
        '
        Me.AutosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AutosBindingNavigatorSaveItem.Image = CType(resources.GetObject("AutosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AutosBindingNavigatorSaveItem.Name = "AutosBindingNavigatorSaveItem"
        Me.AutosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AutosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'AutosDataGridView
        '
        Me.AutosDataGridView.AllowUserToAddRows = False
        Me.AutosDataGridView.AllowUserToDeleteRows = False
        Me.AutosDataGridView.AllowUserToResizeColumns = False
        Me.AutosDataGridView.AllowUserToResizeRows = False
        Me.AutosDataGridView.AutoGenerateColumns = False
        Me.AutosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AutosDataGridView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        Me.AutosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AutosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AutosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9})
        Me.AutosDataGridView.DataSource = Me.AutosBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AutosDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.AutosDataGridView.Location = New System.Drawing.Point(8, 32)
        Me.AutosDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.AutosDataGridView.Name = "AutosDataGridView"
        Me.AutosDataGridView.ReadOnly = True
        Me.AutosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AutosDataGridView.Size = New System.Drawing.Size(1000, 224)
        Me.AutosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_auto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_auto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "marca"
        Me.DataGridViewTextBoxColumn2.HeaderText = "marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "modelo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "modelo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "color"
        Me.DataGridViewTextBoxColumn4.HeaderText = "color"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "año"
        Me.DataGridViewTextBoxColumn5.HeaderText = "año"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "costo"
        Me.DataGridViewTextBoxColumn6.HeaderText = "costo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "km"
        Me.DataGridViewTextBoxColumn7.HeaderText = "km"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "obsv"
        Me.DataGridViewTextBoxColumn9.HeaderText = "obsv"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'Id_autoTextBox
        '
        Me.Id_autoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutosBindingSource, "id_auto", True))
        Me.Id_autoTextBox.Location = New System.Drawing.Point(128, 272)
        Me.Id_autoTextBox.Name = "Id_autoTextBox"
        Me.Id_autoTextBox.Size = New System.Drawing.Size(111, 26)
        Me.Id_autoTextBox.TabIndex = 3
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutosBindingSource, "marca", True))
        Me.MarcaTextBox.Location = New System.Drawing.Point(128, 304)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(111, 26)
        Me.MarcaTextBox.TabIndex = 5
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutosBindingSource, "modelo", True))
        Me.ModeloTextBox.Location = New System.Drawing.Point(360, 272)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(111, 26)
        Me.ModeloTextBox.TabIndex = 7
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutosBindingSource, "color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(360, 304)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(111, 26)
        Me.ColorTextBox.TabIndex = 9
        '
        'AñoTextBox
        '
        Me.AñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutosBindingSource, "año", True))
        Me.AñoTextBox.Location = New System.Drawing.Point(360, 344)
        Me.AñoTextBox.Name = "AñoTextBox"
        Me.AñoTextBox.Size = New System.Drawing.Size(111, 26)
        Me.AñoTextBox.TabIndex = 11
        '
        'CostoTextBox
        '
        Me.CostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutosBindingSource, "costo", True))
        Me.CostoTextBox.Location = New System.Drawing.Point(600, 272)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(111, 26)
        Me.CostoTextBox.TabIndex = 13
        '
        'KmTextBox
        '
        Me.KmTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutosBindingSource, "km", True))
        Me.KmTextBox.Location = New System.Drawing.Point(600, 304)
        Me.KmTextBox.Name = "KmTextBox"
        Me.KmTextBox.Size = New System.Drawing.Size(111, 26)
        Me.KmTextBox.TabIndex = 15
        '
        'ObsvTextBox
        '
        Me.ObsvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutosBindingSource, "obsv", True))
        Me.ObsvTextBox.Location = New System.Drawing.Point(792, 272)
        Me.ObsvTextBox.Name = "ObsvTextBox"
        Me.ObsvTextBox.Size = New System.Drawing.Size(208, 26)
        Me.ObsvTextBox.TabIndex = 19
        '
        'pickboxAuto
        '
        Me.pickboxAuto.Location = New System.Drawing.Point(616, 344)
        Me.pickboxAuto.Name = "pickboxAuto"
        Me.pickboxAuto.Size = New System.Drawing.Size(384, 224)
        Me.pickboxAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pickboxAuto.TabIndex = 20
        Me.pickboxAuto.TabStop = False
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
        Me.btnImprimirInforme_autos.Image = Global.sys_agencia2023.My.Resources.Resources.imprimir_menuPrincipal
        Me.btnImprimirInforme_autos.Location = New System.Drawing.Point(336, 456)
        Me.btnImprimirInforme_autos.Name = "btnImprimirInforme_autos"
        Me.btnImprimirInforme_autos.Size = New System.Drawing.Size(184, 48)
        Me.btnImprimirInforme_autos.TabIndex = 22
        Me.btnImprimirInforme_autos.Text = "Imprimir informe"
        Me.btnImprimirInforme_autos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimirInforme_autos.UseVisualStyleBackColor = False
        '
        'FotoTextBox
        '
        Me.FotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AutosBindingSource, "foto", True))
        Me.FotoTextBox.Location = New System.Drawing.Point(808, 448)
        Me.FotoTextBox.Name = "FotoTextBox"
        Me.FotoTextBox.Size = New System.Drawing.Size(12, 26)
        Me.FotoTextBox.TabIndex = 23
        '
        'frmAutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1028, 588)
        Me.Controls.Add(Me.pickboxAuto)
        Me.Controls.Add(Me.FotoTextBox)
        Me.Controls.Add(Me.btnImprimirInforme_autos)
        Me.Controls.Add(Id_autoLabel)
        Me.Controls.Add(Me.Id_autoTextBox)
        Me.Controls.Add(MarcaLabel)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(ModeloLabel)
        Me.Controls.Add(Me.ModeloTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(AñoLabel)
        Me.Controls.Add(Me.AñoTextBox)
        Me.Controls.Add(CostoLabel)
        Me.Controls.Add(Me.CostoTextBox)
        Me.Controls.Add(KmLabel)
        Me.Controls.Add(Me.KmTextBox)
        Me.Controls.Add(ObsvLabel)
        Me.Controls.Add(Me.ObsvTextBox)
        Me.Controls.Add(Me.AutosDataGridView)
        Me.Controls.Add(Me.AutosBindingNavigator)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmAutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A U T O S"
        CType(Me.Agencia_2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AutosBindingNavigator.ResumeLayout(False)
        Me.AutosBindingNavigator.PerformLayout()
        CType(Me.AutosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pickboxAuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Agencia_2023DataSet As agencia_2023DataSet
    Friend WithEvents AutosBindingSource As BindingSource
    Friend WithEvents AutosTableAdapter As agencia_2023DataSetTableAdapters.autosTableAdapter
    Friend WithEvents TableAdapterManager As agencia_2023DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AutosBindingNavigator As BindingNavigator
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
    Friend WithEvents AutosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AutosDataGridView As DataGridView
    Friend WithEvents Id_autoTextBox As TextBox
    Friend WithEvents MarcaTextBox As TextBox
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents ColorTextBox As TextBox
    Friend WithEvents AñoTextBox As TextBox
    Friend WithEvents CostoTextBox As TextBox
    Friend WithEvents KmTextBox As TextBox
    Friend WithEvents ObsvTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents pickboxAuto As PictureBox
    Friend WithEvents btnImprimirInforme_autos As Button
    Friend WithEvents FotoTextBox As TextBox
End Class
