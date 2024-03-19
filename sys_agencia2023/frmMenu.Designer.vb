<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnEmpresa = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnVendedores = New System.Windows.Forms.Button()
        Me.btnAutos = New System.Windows.Forms.Button()
        Me.btnLocalidades = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.sys_agencia2023.My.Resources.Resources.foto_menuPrincipal
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(784, 561)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnEmpresa
        '
        Me.btnEmpresa.BackColor = System.Drawing.SystemColors.Window
        Me.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpresa.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText
        Me.btnEmpresa.FlatAppearance.BorderSize = 3
        Me.btnEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window
        Me.btnEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpresa.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpresa.Image = Global.sys_agencia2023.My.Resources.Resources.empresa_menuPrincipal1
        Me.btnEmpresa.Location = New System.Drawing.Point(8, 352)
        Me.btnEmpresa.Name = "btnEmpresa"
        Me.btnEmpresa.Size = New System.Drawing.Size(192, 48)
        Me.btnEmpresa.TabIndex = 5
        Me.btnEmpresa.Text = "Empresas"
        Me.btnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEmpresa.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.SystemColors.Window
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText
        Me.btnClientes.FlatAppearance.BorderSize = 3
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Image = Global.sys_agencia2023.My.Resources.Resources.clientes_menuPrincipal1
        Me.btnClientes.Location = New System.Drawing.Point(8, 128)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(192, 48)
        Me.btnClientes.TabIndex = 4
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnVendedores
        '
        Me.btnVendedores.BackColor = System.Drawing.SystemColors.Window
        Me.btnVendedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVendedores.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText
        Me.btnVendedores.FlatAppearance.BorderSize = 3
        Me.btnVendedores.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window
        Me.btnVendedores.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVendedores.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendedores.Image = Global.sys_agencia2023.My.Resources.Resources.vendedores_menuPrincipal1
        Me.btnVendedores.Location = New System.Drawing.Point(8, 184)
        Me.btnVendedores.Name = "btnVendedores"
        Me.btnVendedores.Size = New System.Drawing.Size(192, 48)
        Me.btnVendedores.TabIndex = 3
        Me.btnVendedores.Text = "Vendedores"
        Me.btnVendedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVendedores.UseVisualStyleBackColor = False
        '
        'btnAutos
        '
        Me.btnAutos.BackColor = System.Drawing.SystemColors.Window
        Me.btnAutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAutos.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText
        Me.btnAutos.FlatAppearance.BorderSize = 3
        Me.btnAutos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window
        Me.btnAutos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnAutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAutos.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAutos.Image = Global.sys_agencia2023.My.Resources.Resources.autos_menuPrincipal
        Me.btnAutos.Location = New System.Drawing.Point(8, 296)
        Me.btnAutos.Name = "btnAutos"
        Me.btnAutos.Size = New System.Drawing.Size(192, 48)
        Me.btnAutos.TabIndex = 2
        Me.btnAutos.Text = "Autos"
        Me.btnAutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAutos.UseVisualStyleBackColor = False
        '
        'btnLocalidades
        '
        Me.btnLocalidades.BackColor = System.Drawing.SystemColors.Window
        Me.btnLocalidades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLocalidades.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText
        Me.btnLocalidades.FlatAppearance.BorderSize = 3
        Me.btnLocalidades.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window
        Me.btnLocalidades.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnLocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocalidades.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalidades.Image = Global.sys_agencia2023.My.Resources.Resources.localidades_menuPrincipal1
        Me.btnLocalidades.Location = New System.Drawing.Point(8, 240)
        Me.btnLocalidades.Name = "btnLocalidades"
        Me.btnLocalidades.Size = New System.Drawing.Size(192, 48)
        Me.btnLocalidades.TabIndex = 1
        Me.btnLocalidades.Text = "Localidades"
        Me.btnLocalidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLocalidades.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.SystemColors.Window
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnVentas.FlatAppearance.BorderSize = 3
        Me.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.Image = Global.sys_agencia2023.My.Resources.Resources.ventas_menuPrincipal
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(8, 72)
        Me.btnVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(192, 48)
        Me.btnVentas.TabIndex = 0
        Me.btnVentas.Text = "VENTAS"
        Me.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnEmpresa)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnVendedores)
        Me.Controls.Add(Me.btnAutos)
        Me.Controls.Add(Me.btnLocalidades)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "M E N U   P R I N C I P A L"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVentas As Button
    Friend WithEvents btnLocalidades As Button
    Friend WithEvents btnAutos As Button
    Friend WithEvents btnVendedores As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnEmpresa As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
