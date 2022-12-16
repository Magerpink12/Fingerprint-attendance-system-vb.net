Imports MySql.Data.MySqlClient

Public Class Db
    Public con As MySqlConnection
    Private cmd As MySqlCommand
    Private _Connection_string As String = "datasource=localhost;username=root;database=fingerprintdb;password=;"
    Public a As Integer
    Public user As String = "Isah Ahmad"

    Public Function Connect()
        Try
            con = New MySqlConnection(_Connection_string)
            'con.ConnectionString = "server=localhost;user id=root;database=cas2"
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            Try
                con.Open()
                Return True
            Catch ex As Exception
                Return False
            End Try
        Catch ex As Exception
            Return False
        End Try



    End Function

    Public Function Insert_Query(sql As String)

        cmd = New MySqlCommand(sql, con)
        Try
            a = cmd.ExecuteNonQuery()
            Return True

        Catch ex As Exception
            Return False

        End Try

    End Function


    Public Function Select_Query(sql As String)
        Dim dt As New DataTable
        Dim da As MySqlDataAdapter

        cmd = New MySqlCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            da.Dispose()
            Return dt

        Catch ex As Exception
            Return False

        Finally
            dt.Dispose()
        End Try

    End Function

    Public Function Select_Single_Query(sql As String)
        Dim dt As New DataTable
        Dim da As MySqlDataAdapter

        cmd = New MySqlCommand(sql, con)
        Try
            cmd.ExecuteNonQuery()
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            da.Dispose()

            Return dr

        Catch ex As Exception
            Return False

        Finally
            dt.Dispose()
        End Try

    End Function

End Class
