Imports MySql.Data.MySqlClient

Module modConnection

    Public strSQLConn As String


    Public Sub SetConnection()

        If frmQueryBuilder.blnPROD Then
            strSQLConn = "Server=hh-mp-pmgr;user=PMUser;password=$h0wM3Th3M0n3y$;database=paymentmanager;default command timeout=180"
        Else
            strSQLConn = "Server=hh-mp-pmgr;user=PMUser;password=$h0wM3Th3M0n3y$;database=test;default command timeout=180"
        End If

    End Sub

    Public Sub ExecuteQuery_DataTable(strQuery As String, tblReturned As DataTable)

        Dim sqlReader As MySqlDataReader

        Using cn As New MySqlConnection(strSQLConn)
            Using sqlCommand As New MySqlCommand
                With sqlCommand
                    .CommandText = strQuery
                    .Connection = cn
                    .CommandType = CommandType.Text
                End With

                Try
                    If cn.State() <> ConnectionState.Open Then cn.Open()
                    sqlReader = sqlCommand.ExecuteReader()
                    tblReturned.Clear()
                    tblReturned.Load(sqlReader)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using

    End Sub
    Public Sub ExecuteQuery_DataSet(strQuery As String, dsReturned As DataSet)

        Using cn As New MySqlConnection(strSQLConn)
            Try
                If cn.State <> ConnectionState.Open Then cn.Open()
                Dim da As New MySqlDataAdapter(strQuery, cn)
                dsReturned.Clear()
                da.Fill(dsReturned)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using

    End Sub

    Public Sub ExecuteStoredProcedure(strProcedureName As String)

        Using cn As New MySqlConnection(strSQLConn)
            Using sqlCommand As New MySqlCommand
                With sqlCommand
                    .Connection = cn
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = strProcedureName
                    SetStoredProcedureParameters(sqlCommand, strProcedureName)
                End With
                Try
                    If cn.State <> ConnectionState.Open Then cn.Open()
                    sqlCommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using

    End Sub

    Public Sub SetStoredProcedureParameters(sqlcmd As MySqlCommand, strProc As String)

        Select Case strProc
            Case "ADD_LOG"
                Dim parLT As MySqlParameter = New MySqlParameter("LT", frmQueryBuilder.strLogUpdateType)
                parLT.Direction = ParameterDirection.Input
                parLT.DbType = DbType.String
                sqlcmd.Parameters.Add(parLT)

                Dim parCM As MySqlParameter = New MySqlParameter("CM", frmQueryBuilder.strLogUpdateText)
                parCM.Direction = ParameterDirection.Input
                parCM.DbType = DbType.String
                sqlcmd.Parameters.Add(parCM)

                Dim parINIT As MySqlParameter = New MySqlParameter("INIT", frmQueryBuilder.strInitials)
                parINIT.Direction = ParameterDirection.Input
                parINIT.DbType = DbType.String
                sqlcmd.Parameters.Add(parINIT)

            Case Else
                Dim parID As MySqlParameter = New MySqlParameter("TXID", frmQueryBuilder.strTXID)
                parID.Direction = ParameterDirection.Input
                parID.DbType = DbType.String
                sqlcmd.Parameters.Add(parID)

                Dim parTBL As MySqlParameter = New MySqlParameter("TBL", frmQueryBuilder.strDBTbl)
                parTBL.Direction = ParameterDirection.Input
                parTBL.DbType = DbType.String
                sqlcmd.Parameters.Add(parTBL)

        End Select

    End Sub
End Module
