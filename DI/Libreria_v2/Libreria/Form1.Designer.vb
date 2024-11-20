<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblLibreria = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.lblPaginas = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnAltas = New System.Windows.Forms.Button()
        Me.btnBajas = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtPaginas = New System.Windows.Forms.TextBox()
        Me.GroupBoxFormato = New System.Windows.Forms.GroupBox()
        Me.chbTapaDura = New System.Windows.Forms.CheckBox()
        Me.chbRústica = New System.Windows.Forms.CheckBox()
        Me.chbCartone = New System.Windows.Forms.CheckBox()
        Me.GroupBoxEstado = New System.Windows.Forms.GroupBox()
        Me.rbReedición = New System.Windows.Forms.RadioButton()
        Me.rbNovedad = New System.Windows.Forms.RadioButton()
        Me.ListBoxLibros = New System.Windows.Forms.ListBox()
        Me.lblLibros = New System.Windows.Forms.Label()
        Me.cbTema = New System.Windows.Forms.ComboBox()
        Me.GroupBoxFormato.SuspendLayout()
        Me.GroupBoxEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLibreria
        '
        Me.lblLibreria.AutoSize = True
        Me.lblLibreria.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibreria.Location = New System.Drawing.Point(138, 37)
        Me.lblLibreria.Name = "lblLibreria"
        Me.lblLibreria.Size = New System.Drawing.Size(112, 31)
        Me.lblLibreria.TabIndex = 0
        Me.lblLibreria.Text = "Librería"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(63, 111)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(46, 13)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "TITULO"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(63, 163)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(45, 13)
        Me.lblAutor.TabIndex = 2
        Me.lblAutor.Text = "AUTOR"
        '
        'lblTema
        '
        Me.lblTema.AutoSize = True
        Me.lblTema.Location = New System.Drawing.Point(63, 202)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(37, 13)
        Me.lblTema.TabIndex = 3
        Me.lblTema.Text = "TEMA"
        '
        'lblPaginas
        '
        Me.lblPaginas.AutoSize = True
        Me.lblPaginas.Location = New System.Drawing.Point(63, 250)
        Me.lblPaginas.Name = "lblPaginas"
        Me.lblPaginas.Size = New System.Drawing.Size(69, 13)
        Me.lblPaginas.TabIndex = 4
        Me.lblPaginas.Text = "Nº PAGINAS"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(66, 318)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnAltas
        '
        Me.btnAltas.Location = New System.Drawing.Point(210, 318)
        Me.btnAltas.Name = "btnAltas"
        Me.btnAltas.Size = New System.Drawing.Size(75, 23)
        Me.btnAltas.TabIndex = 6
        Me.btnAltas.Text = "Altas"
        Me.btnAltas.UseVisualStyleBackColor = True
        '
        'btnBajas
        '
        Me.btnBajas.Location = New System.Drawing.Point(66, 371)
        Me.btnBajas.Name = "btnBajas"
        Me.btnBajas.Size = New System.Drawing.Size(75, 23)
        Me.btnBajas.TabIndex = 7
        Me.btnBajas.Text = "Bajas"
        Me.btnBajas.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(210, 371)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(200, 111)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(176, 20)
        Me.txtTitulo.TabIndex = 9
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(200, 156)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(176, 20)
        Me.txtAutor.TabIndex = 10
        '
        'txtPaginas
        '
        Me.txtPaginas.Location = New System.Drawing.Point(200, 247)
        Me.txtPaginas.Name = "txtPaginas"
        Me.txtPaginas.Size = New System.Drawing.Size(176, 20)
        Me.txtPaginas.TabIndex = 11
        '
        'GroupBoxFormato
        '
        Me.GroupBoxFormato.Controls.Add(Me.chbTapaDura)
        Me.GroupBoxFormato.Controls.Add(Me.chbRústica)
        Me.GroupBoxFormato.Controls.Add(Me.chbCartone)
        Me.GroupBoxFormato.Location = New System.Drawing.Point(543, 22)
        Me.GroupBoxFormato.Name = "GroupBoxFormato"
        Me.GroupBoxFormato.Size = New System.Drawing.Size(200, 109)
        Me.GroupBoxFormato.TabIndex = 12
        Me.GroupBoxFormato.TabStop = False
        Me.GroupBoxFormato.Text = "Formato"
        '
        'chbTapaDura
        '
        Me.chbTapaDura.AutoSize = True
        Me.chbTapaDura.Location = New System.Drawing.Point(19, 77)
        Me.chbTapaDura.Name = "chbTapaDura"
        Me.chbTapaDura.Size = New System.Drawing.Size(74, 17)
        Me.chbTapaDura.TabIndex = 2
        Me.chbTapaDura.Text = "TapaDura"
        Me.chbTapaDura.UseVisualStyleBackColor = True
        '
        'chbRústica
        '
        Me.chbRústica.AutoSize = True
        Me.chbRústica.Location = New System.Drawing.Point(19, 54)
        Me.chbRústica.Name = "chbRústica"
        Me.chbRústica.Size = New System.Drawing.Size(62, 17)
        Me.chbRústica.TabIndex = 1
        Me.chbRústica.Text = "Rústica"
        Me.chbRústica.UseVisualStyleBackColor = True
        '
        'chbCartone
        '
        Me.chbCartone.AutoSize = True
        Me.chbCartone.Location = New System.Drawing.Point(19, 29)
        Me.chbCartone.Name = "chbCartone"
        Me.chbCartone.Size = New System.Drawing.Size(63, 17)
        Me.chbCartone.TabIndex = 0
        Me.chbCartone.Text = "Cartoné"
        Me.chbCartone.UseVisualStyleBackColor = True
        '
        'GroupBoxEstado
        '
        Me.GroupBoxEstado.Controls.Add(Me.rbReedición)
        Me.GroupBoxEstado.Controls.Add(Me.rbNovedad)
        Me.GroupBoxEstado.Location = New System.Drawing.Point(543, 163)
        Me.GroupBoxEstado.Name = "GroupBoxEstado"
        Me.GroupBoxEstado.Size = New System.Drawing.Size(200, 100)
        Me.GroupBoxEstado.TabIndex = 13
        Me.GroupBoxEstado.TabStop = False
        Me.GroupBoxEstado.Text = "Estado"
        '
        'rbReedición
        '
        Me.rbReedición.AutoSize = True
        Me.rbReedición.Location = New System.Drawing.Point(19, 66)
        Me.rbReedición.Name = "rbReedición"
        Me.rbReedición.Size = New System.Drawing.Size(73, 17)
        Me.rbReedición.TabIndex = 1
        Me.rbReedición.TabStop = True
        Me.rbReedición.Text = "Reedición"
        Me.rbReedición.UseVisualStyleBackColor = True
        '
        'rbNovedad
        '
        Me.rbNovedad.AutoSize = True
        Me.rbNovedad.Location = New System.Drawing.Point(19, 34)
        Me.rbNovedad.Name = "rbNovedad"
        Me.rbNovedad.Size = New System.Drawing.Size(69, 17)
        Me.rbNovedad.TabIndex = 0
        Me.rbNovedad.TabStop = True
        Me.rbNovedad.Text = "Novedad"
        Me.rbNovedad.UseVisualStyleBackColor = True
        '
        'ListBoxLibros
        '
        Me.ListBoxLibros.FormattingEnabled = True
        Me.ListBoxLibros.Location = New System.Drawing.Point(543, 318)
        Me.ListBoxLibros.Name = "ListBoxLibros"
        Me.ListBoxLibros.Size = New System.Drawing.Size(120, 95)
        Me.ListBoxLibros.TabIndex = 14
        '
        'lblLibros
        '
        Me.lblLibros.AutoSize = True
        Me.lblLibros.Location = New System.Drawing.Point(540, 287)
        Me.lblLibros.Name = "lblLibros"
        Me.lblLibros.Size = New System.Drawing.Size(35, 13)
        Me.lblLibros.TabIndex = 15
        Me.lblLibros.Text = "Libros"
        '
        'cbTema
        '
        Me.cbTema.FormattingEnabled = True
        Me.cbTema.Items.AddRange(New Object() {"Aventuras", "Biografía", "Ciencia", "Ciencia Ficción", "Cine", "Economía", "Gastronomía", "Historia", "Informática", "Medicina", "Misterio", "Naturaleza", "Policiaco", "Política", "Romántica", "Teatro", "Terror"})
        Me.cbTema.Location = New System.Drawing.Point(200, 202)
        Me.cbTema.Name = "cbTema"
        Me.cbTema.Size = New System.Drawing.Size(176, 21)
        Me.cbTema.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbTema)
        Me.Controls.Add(Me.lblLibros)
        Me.Controls.Add(Me.ListBoxLibros)
        Me.Controls.Add(Me.GroupBoxEstado)
        Me.Controls.Add(Me.GroupBoxFormato)
        Me.Controls.Add(Me.txtPaginas)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBajas)
        Me.Controls.Add(Me.btnAltas)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lblPaginas)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblLibreria)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBoxFormato.ResumeLayout(False)
        Me.GroupBoxFormato.PerformLayout()
        Me.GroupBoxEstado.ResumeLayout(False)
        Me.GroupBoxEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLibreria As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents lblTema As Label
    Friend WithEvents lblPaginas As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnAltas As Button
    Friend WithEvents btnBajas As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents txtPaginas As TextBox
    Friend WithEvents GroupBoxFormato As GroupBox
    Friend WithEvents GroupBoxEstado As GroupBox
    Friend WithEvents ListBoxLibros As ListBox
    Friend WithEvents lblLibros As Label
    Friend WithEvents cbTema As ComboBox
    Friend WithEvents chbTapaDura As CheckBox
    Friend WithEvents chbRústica As CheckBox
    Friend WithEvents chbCartone As CheckBox
    Friend WithEvents rbReedición As RadioButton
    Friend WithEvents rbNovedad As RadioButton
End Class
