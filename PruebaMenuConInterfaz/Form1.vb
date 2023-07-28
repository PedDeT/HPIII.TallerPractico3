Imports System.Data.SqlClient
Imports System.DirectoryServices.ActiveDirectory

Public Class Form1
    Dim Numtabla As Integer
    Dim Numtabla1 = 1
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim consulta As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_Mostrar.Click
        If Numtabla = 1 Then
            cmd = New SqlCommand("select * from dbo.Authors", con) 'hacemos el query de la tabla autores
            Dim adaptador As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adaptador.Fill(dt)
            DataGridView1.DataSource = dt
        ElseIf Numtabla = 2 Then
            cmd = New SqlCommand("select * from dbo.Books", con) 'hacemos el query de la tabla Books
            Dim adaptador As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adaptador.Fill(dt)
            DataGridView1.DataSource = dt
        ElseIf Numtabla = 3 Then
            cmd = New SqlCommand("select * from dbo.BooksAuthors", con) 'hacemos el query de la tabla Books Authors
            Dim adaptador As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            adaptador.Fill(dt)
            DataGridView1.DataSource = dt
        End If
        'llenamos el data grid con la info de la tabla 
        con.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=RENE_RUIZ\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
        ocultarTabla1()
        ocultartabla2()
        Lbl_Titulo.Hide()
        TXT_Titulo.Hide()
    End Sub
    'Botones para elegir la tabla que se quiere mostrar/editar/borrar
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TXT_Nombre.Show()
        TXT_Pais.Show()
        Lbl_Nombre.Show()
        Lbl_Pais.Show()
        ocultartabla2()
        Numtabla = 1
    End Sub

    ' Ocultar Objetos tabla 1
    Sub ocultarTabla1()
        TXT_Nombre.Clear()
        TXT_Pais.Clear()
        TXT_Nombre.Hide()
        TXT_Pais.Hide()
        Lbl_Nombre.Hide()
        Lbl_Pais.Hide()
    End Sub
    'Ocultar Objetos tabla 2
    Sub ocultartabla2()
        Lbl_Titulo.Hide()
        TXT_Titulo.Hide()
        TXT_Titulo.Clear()
        TXT_ID_Libro.Clear()
        LbL_ID_Libro.Hide()
        TXT_ID_Libro.Hide()
    End Sub
    Private Sub BTN_Borrar_Click(sender As Object, e As EventArgs) Handles BTN_Borrar.Click
        ocultarTabla1()
        ocultartabla2()

    End Sub
    ' ---------------------  Insertar Registros ---------------------------------------
    Private Sub BTN_Insertar_Click(sender As Object, e As EventArgs) Handles BTN_Insertar.Click
        con.Open()
        If Numtabla = 1 AndAlso TXT_Nombre.TextLength > 0 AndAlso TXT_Pais.TextLength > 0 Then
            consulta = " insert into Authors ( Name, Country) values ('" & TXT_Nombre.Text & "','" & TXT_Pais.Text & "')"
            cmd = New SqlCommand(consulta, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Informacion añadida")
            TXT_Pais.Clear()
            TXT_Nombre.Clear()
        ElseIf Numtabla = 2 Then
            consulta = " insert into Books (Title) values ('" & TXT_Titulo.Text & "')"
            cmd = New SqlCommand(consulta, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Informacion añadida")
            TXT_Titulo.Clear()
        Else
            MessageBox.Show("No puede dejar campos vacios")
        End If
        con.Close()
    End Sub
    '-------------------------- Boton Eliminar Registro por Nombre
    Private Sub BorrarRegistro_Click(sender As Object, e As EventArgs) Handles BorrarRegistro.Click
        con.Open()
        If Numtabla = 1 AndAlso TXT_Nombre.TextLength > 0 Then
            consulta = " delete from Authors where Name= '" & TXT_Nombre.Text & "'"
            cmd = New SqlCommand(consulta, con)
            Dim cant As Integer
            cant = cmd.ExecuteNonQuery
            If cant = 1 Then
                TXT_Nombre.Clear()
                TXT_Pais.Clear()
                MessageBox.Show("El registro ha sido eliminado")
            Else
                MessageBox.Show("1. El registro no ha sido encontrado")
            End If

        ElseIf Numtabla = 2 AndAlso TXT_Titulo.TextLength > 0 Then
            consulta = " delete from Books where Title= '" & TXT_Titulo.Text & "'"
            cmd = New SqlCommand(consulta, con)
            Dim cant As Integer
            cant = cmd.ExecuteNonQuery
            If cant = 1 Then
                TXT_Nombre.Clear()
                TXT_Pais.Clear()
                MessageBox.Show("El registro ha sido eliminado")
            Else
                MessageBox.Show("1. El registro no ha sido encontrado")
            End If
        Else
            MessageBox.Show("2. No puede dejar el campo titulo vacio")
        End If
        con.Close()
    End Sub

    '--------------------------- BOTON MODIFICAR REGISTRO POR NOMBRE --------------------------------- 
    Private Sub BTN_Actualizar_Click(sender As Object, e As EventArgs) Handles BTN_Actualizar.Click
        con.Open()
        If Numtabla = 1 AndAlso TXT_Nombre.TextLength > 0 AndAlso TXT_Pais.TextLength > 0 Then
            consulta = " update Authors set Country= '" & TXT_Pais.Text & "' where Name= '" & TXT_Nombre.Text & "'"
            cmd = New SqlCommand(consulta, con)
            Dim cant As Integer
            cant = cmd.ExecuteNonQuery
            If cant = 1 Then
                TXT_Nombre.Clear()
                TXT_Pais.Clear()
                MessageBox.Show("El registro ha sido modificado")
            Else
                MessageBox.Show("1. El registro no ha sido encontrado")
            End If
        ElseIf Numtabla = 2 AndAlso TXT_Titulo.TextLength > 0 Then
            consulta = " update Books set Title= '" & TXT_Titulo.Text & "' where Id= " & TXT_ID_Libro.Text & ""
            cmd = New SqlCommand(consulta, con)
            Dim cant As Integer
            cant = cmd.ExecuteNonQuery
            If cant = 1 Then
                TXT_Nombre.Clear()
                TXT_Pais.Clear()
                MessageBox.Show("El registro ha sido modificado")
            Else
                MessageBox.Show("1. El registro no ha sido encontrado")
            End If
        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Numtabla = 2
        ocultarTabla1()
        TXT_ID_Libro.Show()
        LbL_ID_Libro.Show()
        Lbl_Titulo.Show()
        TXT_Titulo.Show()
    End Sub
End Class
