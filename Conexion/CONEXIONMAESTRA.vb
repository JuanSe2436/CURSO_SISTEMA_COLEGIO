Imports System.Data.SqlClient
Imports System.Configuration
Module CONEXIONMAESTRA
    'Public Conexion As New SqlConnection("Data Source=Sebastián\SQLEXPRESS; Initial Catalog =BASECOBROS;Integrated Security=True")
    Public Conexion As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB; Initial Catalog =BASECOBROS;Integrated Security=True")

    Sub abrir()
        If Conexion.State = 0 Then
            Conexion.Open()

        End If
    End Sub
    Sub Cerrar()
        If Conexion.State = 1 Then
            Conexion.Close()

        End If
    End Sub
End Module
