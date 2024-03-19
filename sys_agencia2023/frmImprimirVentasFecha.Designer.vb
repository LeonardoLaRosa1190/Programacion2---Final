<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImprimirVentasFecha
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImprimirVentasFecha))
        Me.SpuventasfechasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Agencia_2023DataSet = New sys_agencia2023.agencia_2023DataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Spu_ventas_fechasTableAdapter = New sys_agencia2023.agencia_2023DataSetTableAdapters.spu_ventas_fechasTableAdapter()
        Me.spu_ventas_fechasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.SpuventasfechasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Agencia_2023DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spu_ventas_fechasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpuventasfechasBindingSource
        '
        Me.SpuventasfechasBindingSource.DataMember = "spu_ventas_fechas"
        Me.SpuventasfechasBindingSource.DataSource = Me.Agencia_2023DataSet
        '
        'Agencia_2023DataSet
        '
        Me.Agencia_2023DataSet.DataSetName = "agencia_2023DataSet"
        Me.Agencia_2023DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "ventas_fechas"
        ReportDataSource3.Value = Me.spu_ventas_fechasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "sys_agencia2023.rptConsultadeVentasporFecha.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(697, 386)
        Me.ReportViewer1.TabIndex = 0
        '
        'Spu_ventas_fechasTableAdapter
        '
        Me.Spu_ventas_fechasTableAdapter.ClearBeforeFill = True
        '
        'spu_ventas_fechasBindingSource
        '
        Me.spu_ventas_fechasBindingSource.DataMember = "spu_ventas_fechas"
        Me.spu_ventas_fechasBindingSource.DataSource = Me.Agencia_2023DataSet
        '
        'frmImprimirVentasFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 386)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImprimirVentasFecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "I M P R I M I R  V E N T A S  F E C H A"
        CType(Me.SpuventasfechasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Agencia_2023DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spu_ventas_fechasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SpuventasfechasBindingSource As BindingSource
    Friend WithEvents Agencia_2023DataSet As agencia_2023DataSet
    Friend WithEvents Spu_ventas_fechasTableAdapter As agencia_2023DataSetTableAdapters.spu_ventas_fechasTableAdapter
    Friend WithEvents spu_ventas_fechasBindingSource As BindingSource
End Class
