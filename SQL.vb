Imports MySql.Data.MySqlClient
Public Class SQL
    Public con As New MySqlConnection With {.ConnectionString = "server = localhost; user id = root; password = ; database = test "}
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public ds As DataSet
    Public da As MySqlDataAdapter

    Public Sub fetch(query As String)
        Try
            con.Open()
            cmd = New MySqlCommand(query, con)
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds)
            con.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()

        End Try
    End Sub
End Class
