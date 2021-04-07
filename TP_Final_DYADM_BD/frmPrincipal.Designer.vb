<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuABM = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAluAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMatAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProfAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamenAlta = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAluBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMatBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProfBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamenBaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModificacion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAluMod = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMatMod = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProfMod = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamenMod = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTotAluInsc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTotAluApro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAluInscMat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDatTurnos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOtros = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCambiarPass = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuABM, Me.mnuReportes, Me.mnuOtros})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(728, 24)
        Me.mnuMenu.TabIndex = 5
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuABM
        '
        Me.mnuABM.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAlta, Me.mnuBaja, Me.mnuModificacion})
        Me.mnuABM.Name = "mnuABM"
        Me.mnuABM.Size = New System.Drawing.Size(50, 20)
        Me.mnuABM.Text = "&Menú"
        '
        'mnuAlta
        '
        Me.mnuAlta.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAluAlta, Me.mnuMatAlta, Me.mnuProfAlta, Me.mnuExamenAlta})
        Me.mnuAlta.Name = "mnuAlta"
        Me.mnuAlta.Size = New System.Drawing.Size(144, 22)
        Me.mnuAlta.Text = "Alta"
        '
        'mnuAluAlta
        '
        Me.mnuAluAlta.Name = "mnuAluAlta"
        Me.mnuAluAlta.Size = New System.Drawing.Size(118, 22)
        Me.mnuAluAlta.Text = "Alumno"
        '
        'mnuMatAlta
        '
        Me.mnuMatAlta.Name = "mnuMatAlta"
        Me.mnuMatAlta.Size = New System.Drawing.Size(118, 22)
        Me.mnuMatAlta.Text = "Materia"
        '
        'mnuProfAlta
        '
        Me.mnuProfAlta.Name = "mnuProfAlta"
        Me.mnuProfAlta.Size = New System.Drawing.Size(118, 22)
        Me.mnuProfAlta.Text = "Profesor"
        '
        'mnuExamenAlta
        '
        Me.mnuExamenAlta.Name = "mnuExamenAlta"
        Me.mnuExamenAlta.Size = New System.Drawing.Size(118, 22)
        Me.mnuExamenAlta.Text = "Examen"
        '
        'mnuBaja
        '
        Me.mnuBaja.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAluBaja, Me.mnuMatBaja, Me.mnuProfBaja, Me.mnuExamenBaja})
        Me.mnuBaja.Name = "mnuBaja"
        Me.mnuBaja.Size = New System.Drawing.Size(144, 22)
        Me.mnuBaja.Text = "Baja"
        '
        'mnuAluBaja
        '
        Me.mnuAluBaja.Name = "mnuAluBaja"
        Me.mnuAluBaja.Size = New System.Drawing.Size(118, 22)
        Me.mnuAluBaja.Text = "Alumno"
        '
        'mnuMatBaja
        '
        Me.mnuMatBaja.Name = "mnuMatBaja"
        Me.mnuMatBaja.Size = New System.Drawing.Size(118, 22)
        Me.mnuMatBaja.Text = "Materia"
        '
        'mnuProfBaja
        '
        Me.mnuProfBaja.Name = "mnuProfBaja"
        Me.mnuProfBaja.Size = New System.Drawing.Size(118, 22)
        Me.mnuProfBaja.Text = "Profesor"
        '
        'mnuExamenBaja
        '
        Me.mnuExamenBaja.Name = "mnuExamenBaja"
        Me.mnuExamenBaja.Size = New System.Drawing.Size(118, 22)
        Me.mnuExamenBaja.Text = "Examen"
        '
        'mnuModificacion
        '
        Me.mnuModificacion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAluMod, Me.mnuMatMod, Me.mnuProfMod, Me.mnuExamenMod})
        Me.mnuModificacion.Name = "mnuModificacion"
        Me.mnuModificacion.Size = New System.Drawing.Size(144, 22)
        Me.mnuModificacion.Text = "Modificación"
        '
        'mnuAluMod
        '
        Me.mnuAluMod.Name = "mnuAluMod"
        Me.mnuAluMod.Size = New System.Drawing.Size(118, 22)
        Me.mnuAluMod.Text = "Alumno"
        '
        'mnuMatMod
        '
        Me.mnuMatMod.Name = "mnuMatMod"
        Me.mnuMatMod.Size = New System.Drawing.Size(118, 22)
        Me.mnuMatMod.Text = "Materia"
        '
        'mnuProfMod
        '
        Me.mnuProfMod.Name = "mnuProfMod"
        Me.mnuProfMod.Size = New System.Drawing.Size(118, 22)
        Me.mnuProfMod.Text = "Profesor"
        '
        'mnuExamenMod
        '
        Me.mnuExamenMod.Name = "mnuExamenMod"
        Me.mnuExamenMod.Size = New System.Drawing.Size(118, 22)
        Me.mnuExamenMod.Text = "Examen"
        '
        'mnuReportes
        '
        Me.mnuReportes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTotAluInsc, Me.mnuTotAluApro, Me.mnuAluInscMat, Me.mnuDatTurnos})
        Me.mnuReportes.Name = "mnuReportes"
        Me.mnuReportes.Size = New System.Drawing.Size(65, 20)
        Me.mnuReportes.Text = "&Reportes"
        '
        'mnuTotAluInsc
        '
        Me.mnuTotAluInsc.Name = "mnuTotAluInsc"
        Me.mnuTotAluInsc.Size = New System.Drawing.Size(240, 22)
        Me.mnuTotAluInsc.Text = "Total de Alumnos Inscriptos"
        '
        'mnuTotAluApro
        '
        Me.mnuTotAluApro.Name = "mnuTotAluApro"
        Me.mnuTotAluApro.Size = New System.Drawing.Size(240, 22)
        Me.mnuTotAluApro.Text = "Total de Alumnos Aprobados"
        '
        'mnuAluInscMat
        '
        Me.mnuAluInscMat.Name = "mnuAluInscMat"
        Me.mnuAluInscMat.Size = New System.Drawing.Size(240, 22)
        Me.mnuAluInscMat.Text = "Alumnos Inscriptos por Materia"
        '
        'mnuDatTurnos
        '
        Me.mnuDatTurnos.Name = "mnuDatTurnos"
        Me.mnuDatTurnos.Size = New System.Drawing.Size(240, 22)
        Me.mnuDatTurnos.Text = "Datos Turnos"
        '
        'mnuOtros
        '
        Me.mnuOtros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCambiarPass, Me.ToolStripSeparator1, Me.mnuLogout, Me.mnuSalir})
        Me.mnuOtros.Name = "mnuOtros"
        Me.mnuOtros.Size = New System.Drawing.Size(48, 20)
        Me.mnuOtros.Text = "&Otros"
        '
        'mnuCambiarPass
        '
        Me.mnuCambiarPass.Name = "mnuCambiarPass"
        Me.mnuCambiarPass.Size = New System.Drawing.Size(180, 22)
        Me.mnuCambiarPass.Text = "Cambiar contraseña"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(180, 22)
        Me.mnuLogout.Text = "Desconectarse"
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(180, 22)
        Me.mnuSalir.Text = "Salir"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 296)
        Me.Controls.Add(Me.mnuMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMenu
        Me.Name = "frmPrincipal"
        Me.ShowIcon = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenu As MenuStrip
    Friend WithEvents mnuABM As ToolStripMenuItem
    Friend WithEvents mnuAlta As ToolStripMenuItem
    Friend WithEvents mnuBaja As ToolStripMenuItem
    Friend WithEvents mnuModificacion As ToolStripMenuItem
    Friend WithEvents mnuReportes As ToolStripMenuItem
    Friend WithEvents mnuOtros As ToolStripMenuItem
    Friend WithEvents mnuTotAluInsc As ToolStripMenuItem
    Friend WithEvents mnuTotAluApro As ToolStripMenuItem
    Friend WithEvents mnuAluInscMat As ToolStripMenuItem
    Friend WithEvents mnuDatTurnos As ToolStripMenuItem
    Friend WithEvents mnuCambiarPass As ToolStripMenuItem
    Friend WithEvents mnuLogout As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents mnuExamenAlta As ToolStripMenuItem
    Friend WithEvents mnuAluAlta As ToolStripMenuItem
    Friend WithEvents mnuMatAlta As ToolStripMenuItem
    Friend WithEvents mnuProfAlta As ToolStripMenuItem
    Friend WithEvents mnuAluBaja As ToolStripMenuItem
    Friend WithEvents mnuMatBaja As ToolStripMenuItem
    Friend WithEvents mnuProfBaja As ToolStripMenuItem
    Friend WithEvents mnuExamenBaja As ToolStripMenuItem
    Friend WithEvents mnuAluMod As ToolStripMenuItem
    Friend WithEvents mnuMatMod As ToolStripMenuItem
    Friend WithEvents mnuProfMod As ToolStripMenuItem
    Friend WithEvents mnuExamenMod As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
