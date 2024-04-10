Imports System.Data.SqlClient
Public Class UsuariosOk
    Private Sub UsuariosOk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        Panel3.Visible = False
        LblIdUsuario.Visible = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DataList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataList.CellContentClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Panel3.Visible = True
        LblIdUsuario.Text = Nothing
        TxtNombre.Text = Nothing
        TxtUser.Text = Nothing
        TxtPassword.Text = Nothing
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("SpInsertarUsuario", Conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Nombres", TxtNombre.Text)
            cmd.Parameters.AddWithValue("@Login", TxtUser.Text)
            cmd.Parameters.AddWithValue("@Password", TxtPassword.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
            Mostrar()
            Panel3.Visible = False
        Catch ex As Exception : MsgBox(ex.Message)
        End Try
    End Sub
    Sub Mostrar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("SpMostrarUsuario", Conexion)
            da.Fill(dt)
            DataList.DataSource = dt
            Cerrar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Cerrar()
        Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel3.Visible = False
    End Sub

    Private Sub DataList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataList.CellDoubleClick
        Try
            Panel3.Visible = True
            LblIdUsuario.Text = DataList.SelectedCells.Item(1).Value
            TxtNombre.Text = DataList.SelectedCells.Item(2).Value
            TxtUser.Text = DataList.SelectedCells.Item(3).Value
            TxtPassword.Text = DataList.SelectedCells.Item(4).Value
            GuardarToolStripMenuItem.Enabled = False
            GuardarToolStripMenuItem.Visible = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        Try


            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("SpEditarUsuario", Conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@IdUsuario", LblIdUsuario.Text)
            cmd.Parameters.AddWithValue("@Nombres", TxtNombre.Text)
            cmd.Parameters.AddWithValue("@Login", TxtUser.Text)
            cmd.Parameters.AddWithValue("@Password", TxtPassword.Text)
            cmd.ExecuteNonQuery()
            Cerrar()
            Mostrar()
            Panel3.Visible = False
        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DataList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataList.CellClick
        If e.ColumnIndex = Me.DataList.Columns.Item("Eli").Index Then
            Dim Resultado As DialogResult
            Resultado = MessageBox.Show("¿Seguro que quieres eliminar este usuario?", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If Resultado = DialogResult.OK Then
                Try

                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("SpEliminarUsuario", Conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@IdUsuario", DataList.SelectedCells.Item(1).Value)
                    cmd.ExecuteNonQuery()
                    Cerrar()
                    Mostrar()
                Catch ex As Exception : MsgBox(ex.Message)

                End Try
            Else
                Resultado = MessageBox.Show("Cancelando eliminacion de registros", "Eliminando registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            End If
        End If
    End Sub
    Sub Buscar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("SpBuscarUsuario", Conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Letra", TxtSearch.Text)

            da.Fill(dt)
            DataList.DataSource = dt
            Cerrar()
        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Buscar()
    End Sub
End Class