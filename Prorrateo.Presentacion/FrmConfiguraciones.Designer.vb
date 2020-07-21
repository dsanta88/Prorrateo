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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardarEquiv = New System.Windows.Forms.Button()
        Me.btnEditarEquiv = New System.Windows.Forms.Button()
        Me.btnEliminarEquiv = New System.Windows.Forms.Button()
        CType(Me.dtgEquivalencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgEquivalencias
        '
        Me.dtgEquivalencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEquivalencias.Location = New System.Drawing.Point(61, 153)
        Me.dtgEquivalencias.Name = "dtgEquivalencias"
        Me.dtgEquivalencias.RowTemplate.Height = 24
        Me.dtgEquivalencias.Size = New System.Drawing.Size(467, 150)
        Me.dtgEquivalencias.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 22)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(130, 92)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(127, 22)
        Me.TextBox2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Auxiliar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contrapartida"
        '
        'btnGuardarEquiv
        '
        Me.btnGuardarEquiv.BackColor = System.Drawing.Color.LimeGreen
        Me.btnGuardarEquiv.Location = New System.Drawing.Point(274, 80)
        Me.btnGuardarEquiv.Name = "btnGuardarEquiv"
        Me.btnGuardarEquiv.Size = New System.Drawing.Size(75, 41)
        Me.btnGuardarEquiv.TabIndex = 5
        Me.btnGuardarEquiv.Text = "Guardar"
        Me.btnGuardarEquiv.UseVisualStyleBackColor = False
        '
        'btnEditarEquiv
        '
        Me.btnEditarEquiv.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEditarEquiv.Location = New System.Drawing.Point(370, 72)
        Me.btnEditarEquiv.Name = "btnEditarEquiv"
        Me.btnEditarEquiv.Size = New System.Drawing.Size(75, 42)
        Me.btnEditarEquiv.TabIndex = 6
        Me.btnEditarEquiv.Text = "Editar"
        Me.btnEditarEquiv.UseVisualStyleBackColor = False
        '
        'btnEliminarEquiv
        '
        Me.btnEliminarEquiv.BackColor = System.Drawing.Color.Crimson
        Me.btnEliminarEquiv.Location = New System.Drawing.Point(451, 72)
        Me.btnEliminarEquiv.Name = "btnEliminarEquiv"
        Me.btnEliminarEquiv.Size = New System.Drawing.Size(75, 41)
        Me.btnEliminarEquiv.TabIndex = 7
        Me.btnEliminarEquiv.Text = "Eliminar"
        Me.btnEliminarEquiv.UseVisualStyleBackColor = False
        '
        'FrmConfiguraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 417)
        Me.Controls.Add(Me.btnEliminarEquiv)
        Me.Controls.Add(Me.btnEditarEquiv)
        Me.Controls.Add(Me.btnGuardarEquiv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dtgEquivalencias)
        Me.Name = "FrmConfiguraciones"
        Me.Text = "FrmConfiguraciones"
        CType(Me.dtgEquivalencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgEquivalencias As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardarEquiv As Button
    Friend WithEvents btnEditarEquiv As Button
    Friend WithEvents btnEliminarEquiv As Button
End Class
