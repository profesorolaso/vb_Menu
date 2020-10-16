<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblPrueba = New System.Windows.Forms.Label()
        Me.mnuFuente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAuto = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRojo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAzul = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVerde = New System.Windows.Forms.ToolStripMenuItem()
        Me.emnuBordes = New System.Windows.Forms.ToolStripMenuItem()
        Me.BordesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNinguno = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSencillo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEfecto3D = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu = New System.Windows.Forms.MenuStrip()
        Me.mnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrueba
        '
        Me.lblPrueba.AutoSize = True
        Me.lblPrueba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrueba.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrueba.Location = New System.Drawing.Point(36, 44)
        Me.lblPrueba.Name = "lblPrueba"
        Me.lblPrueba.Size = New System.Drawing.Size(178, 30)
        Me.lblPrueba.TabIndex = 1
        Me.lblPrueba.Text = "Texto de Prueba"
        Me.lblPrueba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnuFuente
        '
        Me.mnuFuente.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColor})
        Me.mnuFuente.Name = "mnuFuente"
        Me.mnuFuente.Size = New System.Drawing.Size(55, 20)
        Me.mnuFuente.Text = "&Fuente"
        '
        'mnuColor
        '
        Me.mnuColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAuto, Me.mnuRojo, Me.mnuAzul, Me.mnuVerde})
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(103, 22)
        Me.mnuColor.Text = "Color"
        '
        'mnuAuto
        '
        Me.mnuAuto.Name = "mnuAuto"
        Me.mnuAuto.Size = New System.Drawing.Size(137, 22)
        Me.mnuAuto.Text = "Automatico"
        '
        'mnuRojo
        '
        Me.mnuRojo.Name = "mnuRojo"
        Me.mnuRojo.Size = New System.Drawing.Size(137, 22)
        Me.mnuRojo.Text = "Rojo"
        '
        'mnuAzul
        '
        Me.mnuAzul.Name = "mnuAzul"
        Me.mnuAzul.Size = New System.Drawing.Size(137, 22)
        Me.mnuAzul.Text = "Azul"
        '
        'mnuVerde
        '
        Me.mnuVerde.Name = "mnuVerde"
        Me.mnuVerde.Size = New System.Drawing.Size(137, 22)
        Me.mnuVerde.Text = "Verde"
        '
        'emnuBordes
        '
        Me.emnuBordes.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BordesToolStripMenuItem1})
        Me.emnuBordes.Name = "emnuBordes"
        Me.emnuBordes.Size = New System.Drawing.Size(55, 20)
        Me.emnuBordes.Text = "&Bordes"
        '
        'BordesToolStripMenuItem1
        '
        Me.BordesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNinguno, Me.mnuSencillo, Me.mnuEfecto3D})
        Me.BordesToolStripMenuItem1.Name = "BordesToolStripMenuItem1"
        Me.BordesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.BordesToolStripMenuItem1.Text = "Bordes"
        '
        'mnuNinguno
        '
        Me.mnuNinguno.Name = "mnuNinguno"
        Me.mnuNinguno.Size = New System.Drawing.Size(152, 22)
        Me.mnuNinguno.Text = "Niinguno"
        '
        'mnuSencillo
        '
        Me.mnuSencillo.Name = "mnuSencillo"
        Me.mnuSencillo.Size = New System.Drawing.Size(152, 22)
        Me.mnuSencillo.Text = "Sencillo"
        '
        'mnuEfecto3D
        '
        Me.mnuEfecto3D.Name = "mnuEfecto3D"
        Me.mnuEfecto3D.Size = New System.Drawing.Size(152, 22)
        Me.mnuEfecto3D.Text = "Efecto 3D"
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(41, 20)
        Me.mnuSalir.Text = "&Salir"
        '
        'mnu
        '
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFuente, Me.emnuBordes, Me.mnuSalir})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(482, 24)
        Me.mnu.TabIndex = 2
        Me.mnu.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(482, 239)
        Me.Controls.Add(Me.lblPrueba)
        Me.Controls.Add(Me.mnu)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrueba As Label
    Friend WithEvents mnuFuente As ToolStripMenuItem
    Friend WithEvents mnuColor As ToolStripMenuItem
    Friend WithEvents mnuAuto As ToolStripMenuItem
    Friend WithEvents mnuRojo As ToolStripMenuItem
    Friend WithEvents mnuAzul As ToolStripMenuItem
    Friend WithEvents mnuVerde As ToolStripMenuItem
    Friend WithEvents emnuBordes As ToolStripMenuItem
    Friend WithEvents BordesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnuNinguno As ToolStripMenuItem
    Friend WithEvents mnuSencillo As ToolStripMenuItem
    Friend WithEvents mnuEfecto3D As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents mnu As MenuStrip
End Class
