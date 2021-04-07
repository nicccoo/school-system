<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModificarExamen
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAlumno = New System.Windows.Forms.ComboBox()
        Me.dtpFechaInscripcion = New System.Windows.Forms.DateTimePicker()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.cmbCodTurno = New System.Windows.Forms.ComboBox()
        Me.cmbCodMat = New System.Windows.Forms.ComboBox()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Alumno = New System.Windows.Forms.Label()
        Me.DGVExamenes = New System.Windows.Forms.DataGridView()
        Me.ctxModificar = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtFiltrar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbNroLegajo = New System.Windows.Forms.ComboBox()
        CType(Me.DGVExamenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxModificar.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(841, 263)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(46, 23)
        Me.btnSalir.TabIndex = 60
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Location = New System.Drawing.Point(654, 263)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(110, 23)
        Me.btnModificar.TabIndex = 59
        Me.btnModificar.Text = "Modificar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(773, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Ejemplo: 10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(773, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Ejemplo: 2019"
        '
        'cmbAlumno
        '
        Me.cmbAlumno.FormattingEnabled = True
        Me.cmbAlumno.Location = New System.Drawing.Point(664, 23)
        Me.cmbAlumno.Name = "cmbAlumno"
        Me.cmbAlumno.Size = New System.Drawing.Size(200, 21)
        Me.cmbAlumno.TabIndex = 56
        '
        'dtpFechaInscripcion
        '
        Me.dtpFechaInscripcion.Location = New System.Drawing.Point(664, 218)
        Me.dtpFechaInscripcion.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaInscripcion.MinDate = New Date(1900, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaInscripcion.Name = "dtpFechaInscripcion"
        Me.dtpFechaInscripcion.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaInscripcion.TabIndex = 55
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(664, 150)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 20)
        Me.txtAño.TabIndex = 54
        '
        'cmbCodTurno
        '
        Me.cmbCodTurno.FormattingEnabled = True
        Me.cmbCodTurno.Location = New System.Drawing.Point(664, 117)
        Me.cmbCodTurno.Name = "cmbCodTurno"
        Me.cmbCodTurno.Size = New System.Drawing.Size(100, 21)
        Me.cmbCodTurno.TabIndex = 53
        '
        'cmbCodMat
        '
        Me.cmbCodMat.FormattingEnabled = True
        Me.cmbCodMat.Location = New System.Drawing.Point(664, 85)
        Me.cmbCodMat.Name = "cmbCodMat"
        Me.cmbCodMat.Size = New System.Drawing.Size(100, 21)
        Me.cmbCodMat.TabIndex = 52
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(664, 182)
        Me.txtNota.MaxLength = 2
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(100, 20)
        Me.txtNota.TabIndex = 51
        Me.txtNota.Tag = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(547, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Fecha de inscripcion: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(622, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Nota: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(622, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Año: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(613, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Turno: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(606, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Materia: "
        '
        'Alumno
        '
        Me.Alumno.AutoSize = True
        Me.Alumno.Location = New System.Drawing.Point(606, 23)
        Me.Alumno.Name = "Alumno"
        Me.Alumno.Size = New System.Drawing.Size(48, 13)
        Me.Alumno.TabIndex = 45
        Me.Alumno.Text = "Alumno: "
        '
        'DGVExamenes
        '
        Me.DGVExamenes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.DGVExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVExamenes.ContextMenuStrip = Me.ctxModificar
        Me.DGVExamenes.Location = New System.Drawing.Point(12, 55)
        Me.DGVExamenes.Name = "DGVExamenes"
        Me.DGVExamenes.Size = New System.Drawing.Size(529, 231)
        Me.DGVExamenes.TabIndex = 61
        '
        'ctxModificar
        '
        Me.ctxModificar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem})
        Me.ctxModificar.Name = "ctxModificar"
        Me.ctxModificar.Size = New System.Drawing.Size(126, 26)
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'txtFiltrar
        '
        Me.txtFiltrar.Location = New System.Drawing.Point(79, 20)
        Me.txtFiltrar.Name = "txtFiltrar"
        Me.txtFiltrar.Size = New System.Drawing.Size(247, 20)
        Me.txtFiltrar.TabIndex = 62
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Buscar: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(586, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Nro. Legajo: "
        '
        'cmbNroLegajo
        '
        Me.cmbNroLegajo.FormattingEnabled = True
        Me.cmbNroLegajo.Location = New System.Drawing.Point(664, 55)
        Me.cmbNroLegajo.Name = "cmbNroLegajo"
        Me.cmbNroLegajo.Size = New System.Drawing.Size(100, 21)
        Me.cmbNroLegajo.TabIndex = 66
        '
        'frmModificarExamen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbNroLegajo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFiltrar)
        Me.Controls.Add(Me.DGVExamenes)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAlumno)
        Me.Controls.Add(Me.dtpFechaInscripcion)
        Me.Controls.Add(Me.txtAño)
        Me.Controls.Add(Me.cmbCodTurno)
        Me.Controls.Add(Me.cmbCodMat)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Alumno)
        Me.Name = "frmModificarExamen"
        Me.Text = "frmModificarExamen"
        CType(Me.DGVExamenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxModificar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAlumno As ComboBox
    Friend WithEvents dtpFechaInscripcion As DateTimePicker
    Friend WithEvents txtAño As TextBox
    Friend WithEvents cmbCodTurno As ComboBox
    Friend WithEvents cmbCodMat As ComboBox
    Friend WithEvents txtNota As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Alumno As Label
    Friend WithEvents DGVExamenes As DataGridView
    Friend WithEvents txtFiltrar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ctxModificar As ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbNroLegajo As ComboBox
End Class
