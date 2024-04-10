Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub TxtUser_Click(sender As Object, e As EventArgs) Handles TxtUser.Click
        TxtUser.Text = ""
        TxtUser.Focus()
    End Sub

    Private Sub TxtPassword_Click(sender As Object, e As EventArgs) Handles TxtPassword.Click
        TxtPassword.Text = ""
        TxtPassword.Focus()

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ' Crear una nueva instancia de la ventana UsuariosOk
        Dim nuevaVentana As New UsuariosOk()

        ' Mostrar la nueva ventana
        nuevaVentana.Show()

        ' Cerrar la ventana actual de inicio de sesión
        Me.Close()
    End Sub

End Class
