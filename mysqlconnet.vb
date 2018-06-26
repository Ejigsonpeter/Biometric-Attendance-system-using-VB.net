Imports MySql.Data.MySqlClient

Public Class mysqlconnet
    Public con As New MySqlConnection With {.ConnectionString = "server=localhost; user id=root; password=; database=bas;"}
    Public cmd As MySqlCommand
    Public dataset As DataSet
    Public datareader As MySqlDataReader
    Public dataadapter As MySqlDataAdapter

    Public Function connection() As Boolean
        Try
            con.Open()

            con.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function


    


End Class
