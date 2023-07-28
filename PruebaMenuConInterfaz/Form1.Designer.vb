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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        BTN_Mostrar = New Button()
        DataGridView1 = New DataGridView()
        BTN_Borrar = New Button()
        BTN_Actualizar = New Button()
        BTN_Insertar = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        TXT_Nombre = New TextBox()
        TXT_Pais = New TextBox()
        Lbl_Nombre = New Label()
        Lbl_Pais = New Label()
        Label4 = New Label()
        BorrarRegistro = New Button()
        TXT_Titulo = New TextBox()
        Lbl_Titulo = New Label()
        LbL_ID_Libro = New Label()
        TXT_ID_Libro = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BTN_Mostrar
        ' 
        BTN_Mostrar.BackColor = Color.Gray
        BTN_Mostrar.FlatAppearance.BorderColor = Color.Black
        BTN_Mostrar.FlatAppearance.BorderSize = 0
        BTN_Mostrar.FlatStyle = FlatStyle.Popup
        BTN_Mostrar.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        BTN_Mostrar.ForeColor = Color.Transparent
        BTN_Mostrar.Location = New Point(878, 569)
        BTN_Mostrar.Name = "BTN_Mostrar"
        BTN_Mostrar.Size = New Size(202, 53)
        BTN_Mostrar.TabIndex = 1
        BTN_Mostrar.Text = "MOSTRAR TABLA"
        BTN_Mostrar.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(831, 42)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(306, 496)
        DataGridView1.TabIndex = 2
        ' 
        ' BTN_Borrar
        ' 
        BTN_Borrar.BackColor = Color.Gray
        BTN_Borrar.FlatAppearance.BorderColor = Color.Black
        BTN_Borrar.FlatAppearance.BorderSize = 0
        BTN_Borrar.FlatStyle = FlatStyle.Popup
        BTN_Borrar.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        BTN_Borrar.ForeColor = Color.Transparent
        BTN_Borrar.Location = New Point(543, 569)
        BTN_Borrar.Name = "BTN_Borrar"
        BTN_Borrar.Size = New Size(202, 53)
        BTN_Borrar.TabIndex = 3
        BTN_Borrar.Text = "BORRAR "
        BTN_Borrar.UseVisualStyleBackColor = False
        ' 
        ' BTN_Actualizar
        ' 
        BTN_Actualizar.BackColor = Color.Gray
        BTN_Actualizar.FlatAppearance.BorderColor = Color.Black
        BTN_Actualizar.FlatAppearance.BorderSize = 0
        BTN_Actualizar.FlatStyle = FlatStyle.Popup
        BTN_Actualizar.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        BTN_Actualizar.ForeColor = Color.Transparent
        BTN_Actualizar.Location = New Point(287, 569)
        BTN_Actualizar.Name = "BTN_Actualizar"
        BTN_Actualizar.Size = New Size(202, 53)
        BTN_Actualizar.TabIndex = 4
        BTN_Actualizar.Text = "MODIFICAR"
        BTN_Actualizar.UseVisualStyleBackColor = False
        ' 
        ' BTN_Insertar
        ' 
        BTN_Insertar.BackColor = Color.Gray
        BTN_Insertar.FlatAppearance.BorderColor = Color.Black
        BTN_Insertar.FlatAppearance.BorderSize = 0
        BTN_Insertar.FlatStyle = FlatStyle.Popup
        BTN_Insertar.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        BTN_Insertar.ForeColor = Color.Transparent
        BTN_Insertar.Location = New Point(43, 569)
        BTN_Insertar.Name = "BTN_Insertar"
        BTN_Insertar.Size = New Size(202, 53)
        BTN_Insertar.TabIndex = 5
        BTN_Insertar.Text = "INSERTAR"
        BTN_Insertar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkGray
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.SeaShell
        Button1.Location = New Point(671, 104)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 42)
        Button1.TabIndex = 6
        Button1.Text = "Tabla 1"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkGray
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.SeaShell
        Button2.Location = New Point(671, 152)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 42)
        Button2.TabIndex = 7
        Button2.Text = "Tabla 2"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkGray
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI Variable Text Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.SeaShell
        Button3.Location = New Point(671, 200)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 42)
        Button3.TabIndex = 8
        Button3.Text = "Tabla 3"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TXT_Nombre
        ' 
        TXT_Nombre.Font = New Font("Segoe UI Variable Text Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        TXT_Nombre.Location = New Point(212, 180)
        TXT_Nombre.Multiline = True
        TXT_Nombre.Name = "TXT_Nombre"
        TXT_Nombre.Size = New Size(314, 62)
        TXT_Nombre.TabIndex = 12
        ' 
        ' TXT_Pais
        ' 
        TXT_Pais.Font = New Font("Segoe UI Variable Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TXT_Pais.Location = New Point(212, 268)
        TXT_Pais.Multiline = True
        TXT_Pais.Name = "TXT_Pais"
        TXT_Pais.Size = New Size(314, 62)
        TXT_Pais.TabIndex = 13
        ' 
        ' Lbl_Nombre
        ' 
        Lbl_Nombre.AutoSize = True
        Lbl_Nombre.BackColor = Color.Transparent
        Lbl_Nombre.Font = New Font("Trebuchet MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl_Nombre.ForeColor = SystemColors.ButtonHighlight
        Lbl_Nombre.Location = New Point(43, 199)
        Lbl_Nombre.Name = "Lbl_Nombre"
        Lbl_Nombre.Size = New Size(145, 43)
        Lbl_Nombre.TabIndex = 14
        Lbl_Nombre.Text = "NOMBRE"
        ' 
        ' Lbl_Pais
        ' 
        Lbl_Pais.AutoSize = True
        Lbl_Pais.BackColor = Color.Transparent
        Lbl_Pais.Font = New Font("Trebuchet MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl_Pais.ForeColor = SystemColors.ButtonHighlight
        Lbl_Pais.Location = New Point(43, 287)
        Lbl_Pais.Name = "Lbl_Pais"
        Lbl_Pais.Size = New Size(79, 43)
        Lbl_Pais.TabIndex = 15
        Lbl_Pais.Text = "PAÍS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Trebuchet MS", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Orange
        Label4.Location = New Point(103, 66)
        Label4.Name = "Label4"
        Label4.Size = New Size(309, 55)
        Label4.TabIndex = 16
        Label4.Text = "INFORMACIÓN"
        ' 
        ' BorrarRegistro
        ' 
        BorrarRegistro.BackColor = Color.Gray
        BorrarRegistro.FlatAppearance.BorderColor = Color.Black
        BorrarRegistro.FlatAppearance.BorderSize = 0
        BorrarRegistro.FlatStyle = FlatStyle.Popup
        BorrarRegistro.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        BorrarRegistro.ForeColor = Color.Transparent
        BorrarRegistro.Location = New Point(43, 485)
        BorrarRegistro.Name = "BorrarRegistro"
        BorrarRegistro.Size = New Size(202, 53)
        BorrarRegistro.TabIndex = 17
        BorrarRegistro.Text = "BORRAR R"
        BorrarRegistro.UseVisualStyleBackColor = False
        ' 
        ' TXT_Titulo
        ' 
        TXT_Titulo.Font = New Font("Segoe UI Variable Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TXT_Titulo.Location = New Point(212, 268)
        TXT_Titulo.Multiline = True
        TXT_Titulo.Name = "TXT_Titulo"
        TXT_Titulo.Size = New Size(314, 62)
        TXT_Titulo.TabIndex = 18
        ' 
        ' Lbl_Titulo
        ' 
        Lbl_Titulo.AutoSize = True
        Lbl_Titulo.BackColor = Color.Transparent
        Lbl_Titulo.Font = New Font("Trebuchet MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Lbl_Titulo.ForeColor = SystemColors.ButtonHighlight
        Lbl_Titulo.Location = New Point(43, 288)
        Lbl_Titulo.Name = "Lbl_Titulo"
        Lbl_Titulo.Size = New Size(130, 43)
        Lbl_Titulo.TabIndex = 19
        Lbl_Titulo.Text = "TITULO"
        ' 
        ' LbL_ID_Libro
        ' 
        LbL_ID_Libro.AutoSize = True
        LbL_ID_Libro.BackColor = Color.Transparent
        LbL_ID_Libro.Font = New Font("Trebuchet MS", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        LbL_ID_Libro.ForeColor = SystemColors.ButtonHighlight
        LbL_ID_Libro.Location = New Point(43, 200)
        LbL_ID_Libro.Name = "LbL_ID_Libro"
        LbL_ID_Libro.Size = New Size(49, 43)
        LbL_ID_Libro.TabIndex = 21
        LbL_ID_Libro.Text = "ID"
        ' 
        ' TXT_ID_Libro
        ' 
        TXT_ID_Libro.Font = New Font("Segoe UI Variable Text Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        TXT_ID_Libro.Location = New Point(212, 180)
        TXT_ID_Libro.Multiline = True
        TXT_ID_Libro.Name = "TXT_ID_Libro"
        TXT_ID_Libro.Size = New Size(314, 62)
        TXT_ID_Libro.TabIndex = 20
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1182, 643)
        Controls.Add(LbL_ID_Libro)
        Controls.Add(TXT_ID_Libro)
        Controls.Add(Lbl_Titulo)
        Controls.Add(TXT_Titulo)
        Controls.Add(BorrarRegistro)
        Controls.Add(Label4)
        Controls.Add(Lbl_Pais)
        Controls.Add(Lbl_Nombre)
        Controls.Add(TXT_Pais)
        Controls.Add(TXT_Nombre)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(BTN_Insertar)
        Controls.Add(BTN_Actualizar)
        Controls.Add(BTN_Borrar)
        Controls.Add(DataGridView1)
        Controls.Add(BTN_Mostrar)
        DoubleBuffered = True
        Name = "Form1"
        Opacity = 0.98R
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BTN_Mostrar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTN_Borrar As Button
    Friend WithEvents BTN_Actualizar As Button
    Friend WithEvents BTN_Insertar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TXT_Nombre As TextBox
    Friend WithEvents TXT_Pais As TextBox
    Friend WithEvents Lbl_Nombre As Label
    Friend WithEvents Lbl_Pais As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BorrarRegistro As Button
    Friend WithEvents TXT_Titulo As TextBox
    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents LbL_ID_Libro As Label
    Friend WithEvents TXT_ID_Libro As TextBox
End Class
