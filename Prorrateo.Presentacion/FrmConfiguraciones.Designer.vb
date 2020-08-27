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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminarEquiv = New System.Windows.Forms.Button()
        Me.btnEditarEquiv = New System.Windows.Forms.Button()
        Me.btnGuardarEquiv = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        CType(Me.dtgEquivalencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgEquivalencias
        '
        Me.dtgEquivalencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEquivalencias.Location = New System.Drawing.Point(2, 37)
        Me.dtgEquivalencias.Name = "dtgEquivalencias"
        Me.dtgEquivalencias.RowHeadersWidth = 51
        Me.dtgEquivalencias.RowTemplate.Height = 24
        Me.dtgEquivalencias.Size = New System.Drawing.Size(605, 223)
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
        Me.Button2.Text = "Documentos"
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
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.cruz_entrecruzada
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(617, 210)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(202, 50)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Cancelar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.anadir
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(2, 266)
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
        Me.btnEliminarEquiv.Location = New System.Drawing.Point(418, 266)
        Me.btnEliminarEquiv.Name = "btnEliminarEquiv"
        Me.btnEliminarEquiv.Size = New System.Drawing.Size(189, 50)
        Me.btnEliminarEquiv.TabIndex = 14
        Me.btnEliminarEquiv.Text = "Eliminar"
        Me.btnEliminarEquiv.UseVisualStyleBackColor = False
        '
        'btnEditarEquiv
        '
        Me.btnEditarEquiv.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnEditarEquiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarEquiv.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.lapiz
        Me.btnEditarEquiv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditarEquiv.Location = New System.Drawing.Point(210, 266)
        Me.btnEditarEquiv.Name = "btnEditarEquiv"
        Me.btnEditarEquiv.Size = New System.Drawing.Size(202, 50)
        Me.btnEditarEquiv.TabIndex = 13
        Me.btnEditarEquiv.Text = "Editar"
        Me.btnEditarEquiv.UseVisualStyleBackColor = False
        '
        'btnGuardarEquiv
        '
        Me.btnGuardarEquiv.BackColor = System.Drawing.Color.Green
        Me.btnGuardarEquiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarEquiv.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.salvar
        Me.btnGuardarEquiv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarEquiv.Location = New System.Drawing.Point(617, 154)
        Me.btnGuardarEquiv.Name = "btnGuardarEquiv"
        Me.btnGuardarEquiv.Size = New System.Drawing.Size(202, 50)
        Me.btnGuardarEquiv.TabIndex = 12
        Me.btnGuardarEquiv.Text = "Guardar"
        Me.btnGuardarEquiv.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 439)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(605, 223)
        Me.DataGridView1.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(613, 465)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 22)
        Me.TextBox1.TabIndex = 26
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.PaleVioletRed
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.cruz_entrecruzada
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(617, 560)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(202, 50)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.salvar
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(617, 504)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(202, 50)
        Me.Button4.TabIndex = 27
        Me.Button4.Text = "Guardar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.anadir
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(2, 668)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(202, 50)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "Nuevo"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Crimson
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.eliminar
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(418, 668)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(189, 50)
        Me.Button7.TabIndex = 30
        Me.Button7.Text = "Eliminar"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = Global.Prorrateo.Presentacion.My.Resources.Resources.lapiz
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(210, 668)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(202, 50)
        Me.Button8.TabIndex = 29
        Me.Button8.Text = "Editar"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'FrmConfiguraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 751)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtContrapartida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAuxiliar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnEliminarEquiv)
        Me.Controls.Add(Me.btnEditarEquiv)
        Me.Controls.Add(Me.btnGuardarEquiv)
        Me.Controls.Add(Me.dtgEquivalencias)
        Me.Name = "FrmConfiguraciones"
        Me.Text = "FrmConfiguraciones"
        CType(Me.dtgEquivalencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgEquivalencias As DataGridView
    Friend WithEvents btnEliminarEquiv As Button
    Friend WithEvents btnEditarEquiv As Button
    Friend WithEvents btnGuardarEquiv As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAuxiliar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtContrapartida As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
