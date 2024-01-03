Module modQueries

    Public Sub GetColumnNames(strTBL As String)

        frmQueryBuilder.CheckBox1.Enabled = True

        'EXECUTE QUERY TO DETERMINE COLUMN NAMES
        Dim strQuery As String = "SELECT COLUMN_NAME " &
            "FROM INFORMATION_SCHEMA.COLUMNS " &
            "WHERE TABLE_SCHEMA = 'test' " &
            "AND TABLE_NAME = '" & strTBL & "'"

        ExecuteQuery_DataTable(strQuery, frmQueryBuilder.tblColumns)

        ' LOAD COLUMN NAME QUERY RESULTS INTO CheckedListBox1
        Dim row As DataRow
        frmQueryBuilder.CheckedListBox1.Items.Clear()
        For Each row In frmQueryBuilder.tblColumns.Rows
            frmQueryBuilder.CheckedListBox1.Items.Add(row(0).ToString)
        Next

    End Sub

    Public Sub GetOperators()

        Dim strQuery As String = "SELECT operatortext, " &
                "operatorsymbol " &
                "FROM test.tbloperators"

        ExecuteQuery_DataSet(strQuery, frmQueryBuilder.dsOperators)

    End Sub


    Public Sub MoveTX()

        Try
            ExecuteStoredProcedure("MOVE_TX")
            _ADD_LOG("HOPE_QB_Move", "Moved " & frmQueryBuilder.strTXID & " from " & frmQueryBuilder.strDBTbl & " to tbltransactions", frmQueryBuilder.strInitials)
            _REMOVE_TX()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub _REMOVE_TX()

        Try
            ExecuteStoredProcedure("REMOVE_TX")
            _ADD_LOG("HOPE_QB_Move", "Removed " & frmQueryBuilder.strTXID & " from " & frmQueryBuilder.strDBTbl, frmQueryBuilder.strInitials)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub _ADD_LOG(TYPE As String, COMMENT As String, INIT As String)

        frmQueryBuilder.strLogUpdateType = TYPE
        frmQueryBuilder.strLogUpdateText = COMMENT
        frmQueryBuilder.strInitials = INIT

        ExecuteStoredProcedure("ADD_LOG")

    End Sub

End Module
