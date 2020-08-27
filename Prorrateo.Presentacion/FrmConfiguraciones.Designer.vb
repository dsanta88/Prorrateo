<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguraciones
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
        Me.dtgEquivalencias = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAuxiliar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtContrapartida = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminarEquiv = New System.Windows.Forms.Button()
        Me.btnGuardarEquiv = New System.Windows.Forms.Button()
        Me.dtgTipoDatos = New System.Windows.Forms.DataGridView()
        Me.txtTipodato = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardarTiipoDato = New System.Windows.Forms.Button()
        Me.btnNuevoTipoDato = New System.Windows.Forms.Button()
        Me.btnEliminarTipoDato = New System.Windows.Forms.Button()
        CType(Me.dtgEquivalencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgTipoDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgEquivalencias
        '
        Me.dtgEquivalencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEquivalencias.Location = New System.Drawing.Point(2, 37)
        Me.dtgEquivalencias.Name = "dtgEquivalencias"
        Me.dtgEquivalencias.RowHeadersWidth = 51
        Me.dtgEquivalencias.RowTemplate.Height = 24
        Me.dtgEquivalencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgEquivalencias.Size = New System.Drawing.Size(605, 273)
        Me.dtgEquivalencias.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(2, 402)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(817, 31)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Tipos Documentos"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(2, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(817, 31)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Cuentas"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(613, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Auxiliar"
        '
        'txtAuxiliar
        '
        Me.txtAuxiliar.Location = New System.Drawing.Point(617, 60)
        Me.txtAuxiliar.Name = "txtAuxiliar"
        Me.txtAuxiliar.Size = New System.Drawing.Size(202, 22)
        Me.txtAuxiliar.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(613, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Contrapartida"
        '
        'txtContrapartida
        '
        Me.txtContrapartida.Location = New System.Drawing.Point(617, 108)
        Me.txtContrapartida.Name = "txtContrapartida"
        Me.txtContrapartida.Size = New System.Drawing.Size(202, 22)
        Me.txtContrapartida.TabIndex = 21
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.anadir
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(617, 260)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(202, 50)
        Me.btnNuevo.TabIndex = 22
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEliminarEquiv
        '
        Me.btnEliminarEquiv.BackColor = System.Drawing.Color.Crimson
        Me.btnEliminarEquiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarEquiv.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.eliminar
        Me.btnEliminarEquiv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarEquiv.Location = New System.Drawing.Point(617, 204)
        Me.btnEliminarEquiv.Name = "btnEliminarEquiv"
        Me.btnEliminarEquiv.Size = New System.Drawing.Size(202, 50)
        Me.btnEliminarEquiv.TabIndex = 14
        Me.btnEliminarEquiv.Text = "Eliminar"
        Me.btnEliminarEquiv.UseVisualStyleBackColor = False
        '
        'btnGuardarEquiv
        '
        Me.btnGuardarEquiv.BackColor = System.Drawing.Color.Green
        Me.btnGuardarEquiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarEquiv.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.salvar
        Me.btnGuardarEquiv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarEquiv.Location = New System.Drawing.Point(617, 148)
        Me.btnGuardarEquiv.Name = "btnGuardarEquiv"
        Me.btnGuardarEquiv.Size = New System.Drawing.Size(202, 50)
        Me.btnGuardarEquiv.TabIndex = 12
        Me.btnGuardarEquiv.Text = "Guardar"
        Me.btnGuardarEquiv.UseVisualStyleBackColor = False
        '
        'dtgTipoDatos
        '
        Me.dtgTipoDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgTipoDatos.Location = New System.Drawing.Point(2, 439)
        Me.dtgTipoDatos.Name = "dtgTipoDatos"
        Me.dtgTipoDatos.RowHeadersWidth = 51
        Me.dtgTipoDatos.RowTemplate.Height = 24
        Me.dtgTipoDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgTipoDatos.Size = New System.Drawing.Size(605, 223)
        Me.dtgTipoDatos.TabIndex = 24
        '
        'txtTipodato
        '
        Me.txtTipodato.Location = New System.Drawing.Point(613, 465)
        Me.txtTipodato.Name = "txtTipodato"
        Me.txtTipodato.Size = New System.Drawing.Size(190, 22)
        Me.txtTipodato.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(613, 442)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Tipo Documento"
        '
        'btnGuardarTiipoDato
        '
        Me.btnGuardarTiipoDato.BackColor = System.Drawing.Color.Green
        Me.btnGuardarTiipoDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarTiipoDato.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.salvar
        Me.btnGuardarTiipoDato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarTiipoDato.Location = New System.Drawing.Point(617, 504)
        Me.btnGuardarTiipoDato.Name = "btnGuardarTiipoDato"
        Me.btnGuardarTiipoDato.Size = New System.Drawing.Size(202, 50)
        Me.btnGuardarTiipoDato.TabIndex = 27
        Me.btnGuardarTiipoDato.Text = "Guardar"
        Me.btnGuardarTiipoDato.UseVisualStyleBackColor = False
        '
        'btnNuevoTipoDato
        '
        Me.btnNuevoTipoDato.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnNuevoTipoDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoTipoDato.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.anadir
        Me.btnNuevoTipoDato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoTipoDato.Location = New System.Drawing.Point(617, 616)
        Me.btnNuevoTipoDato.Name = "btnNuevoTipoDato"
        Me.btnNuevoTipoDato.Size = New System.Drawing.Size(202, 50)
        Me.btnNuevoTipoDato.TabIndex = 31
        Me.btnNuevoTipoDato.Text = "Nuevo"
        Me.btnNuevoTipoDato.UseVisualStyleBackColor = False
        '
        'btnEliminarTipoDato
        '
        Me.btnEliminarTipoDato.BackColor = System.Drawing.Color.Crimson
        Me.btnEliminarTipoDato.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTipoDato.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.eliminar
        Me.btnEliminarTipoDato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarTipoDato.Location = New System.Drawing.Point(617, 560)
        Me.btnEliminarTipoDato.Name = "btnEliminarTipoDato"
        Me.btnEliminarTipoDato.Size = New System.Drawing.Size(202, 50)
        Me.btnEliminarTipoDato.TabIndex = 30
        Me.btnEliminarTipoDato.Text = "Eliminar"
        Me.btnEliminarTipoDato.UseVisualStyleBackColor = False
        '
        'FrmConfiguraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 751)
        Me.Controls.Add(Me.btnNuevoTipoDato)
        Me.Controls.Add(Me.btnEliminarTipoDato)
        Me.Controls.Add(Me.btnGuardarTiipoDato)
        Me.Controls.Add(Me.txtTipodato)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtgTipoDatos)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtContrapartida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAuxiliar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnEliminarEquiv)
        Me.Controls.Add(Me.btnGuardarEquiv)
        Me.Controls.Add(Me.dtgEquivalencias)
        Me.Name = "FrmConfiguraciones"
        Me.Text = "FrmConfiguraciones"
        CType(Me.dtgEquivalencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgTipoDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgEquivalencias As DataGridView
    Friend WithEvents btnEliminarEquiv As Button
    Friend WithEvents btnGuardarEquiv As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAuxiliar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContrapartida As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents dtgTipoDatos As DataGridView
    Friend WithEvents txtTipodato As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGuardarTiipoDato As Button
    Friend WithEvents btnNuevoTipoDato As Button
    Friend WithEvents btnEliminarTipoDato As Button
End Class
