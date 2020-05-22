<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatos
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
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.txtGasto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstPeriodo = New System.Windows.Forms.ListBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid
        '
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(12, 237)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.RowTemplate.Height = 24
        Me.DataGrid.Size = New System.Drawing.Size(1495, 461)
        Me.DataGrid.TabIndex = 0
        '
        'txtGasto
        '
        Me.txtGasto.Location = New System.Drawing.Point(110, 12)
        Me.txtGasto.Name = "txtGasto"
        Me.txtGasto.Size = New System.Drawing.Size(101, 22)
        Me.txtGasto.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "GASTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "IVA"
        '
        'lstPeriodo
        '
        Me.lstPeriodo.FormattingEnabled = True
        Me.lstPeriodo.ItemHeight = 16
        Me.lstPeriodo.Location = New System.Drawing.Point(109, 75)
        Me.lstPeriodo.Name = "lstPeriodo"
        Me.lstPeriodo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstPeriodo.Size = New System.Drawing.Size(120, 100)
        Me.lstPeriodo.TabIndex = 4
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(110, 47)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(100, 22)
        Me.txtIva.TabIndex = 5
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 764)
        Me.Splitter1.TabIndex = 6
        Me.Splitter1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PERIODO"
        '
        'btnConsultar
        '
        Me.btnConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultar.Location = New System.Drawing.Point(15, 181)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(182, 50)
        Me.btnConsultar.TabIndex = 8
        Me.btnConsultar.Text = "CONSULTAR"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.iconfinder_79_excel_social_4241335
        Me.btnExcel.Location = New System.Drawing.Point(1403, 148)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(104, 83)
        Me.btnExcel.TabIndex = 9
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjecutar.Location = New System.Drawing.Point(621, 181)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(182, 50)
        Me.btnEjecutar.TabIndex = 10
        Me.btnEjecutar.Text = "EJECUTAR"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'FrmDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1517, 764)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.btnExcel)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.lstPeriodo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGasto)
        Me.Controls.Add(Me.DataGrid)
        Me.Name = "FrmDatos"
        Me.Text = "Form1"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents txtGasto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstPeriodo As ListBox
    Friend WithEvents txtIva As TextBox
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnEjecutar As Button
End Class
