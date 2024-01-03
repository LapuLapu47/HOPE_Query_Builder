Public Class frmQueryBuilder

    Public blnPROD As Boolean = True
    Public blnExecFlag As Boolean = False
    Public blnMoveFlag As Boolean = False

    Public strDBTbl As String
    Public strSkipFlag As String

    Public dsOperators As New DataSet
    Public tblColumns As New DataTable
    Public tblResults As New DataTable

    Public rIndex As Int16

    Public strTXID As String

    Public strLogUpdateType As String
    Public strLogUpdateText As String
    Public strInitials As String = "HQB"


    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        If strDBTbl <> "" Then

            ' ADD QUERY STEPS HERE
            Dim strFROM As String = ""
            Dim strSELECT As String = ""
            Dim strFILTER As String = ""
            Dim strQUERY As String = ""
            Dim strCOLUMN As String = ""
            Dim strOPERATOR As String = ""
            Dim strVALUE As String = ""
            Dim strADDTEXT As String = ""
            Dim r As Integer
            Dim intSELECTED As Integer = 0
            Dim tblResults As New DataTable


            ' BUILD "FROM" PORTION OF QUERY
            strFROM = "FROM " & strDBTbl

            ' BUILD "SELECT" PORTION OF QUERY
            If CheckedListBox1.CheckedItems.Count <> 0 Then
                For Each r In CheckedListBox1.CheckedIndices
                    strADDTEXT = CheckedListBox1.Items(r).ToString

                    If strADDTEXT.Contains("Date") Then
                        'MsgBox("Date field")
                        strADDTEXT = "CASE WHEN REPLACE(" & strADDTEXT & ",'-','') = 0 THEN '' " &
                                     "WHEN " & strADDTEXT & " IS NULL THEN '' " &
                                     "ELSE " & strADDTEXT & " " &
                                     "END AS '" & strADDTEXT & "'"
                        'MsgBox(strADDTEXT)
                    End If
                    'If strADDTEXT = "ActionCodeDate" Then
                    '    strADDTEXT = "CASE WHEN REPLACE(ActionCodeDate,'-','') = 0 THEN '' " &
                    '                 "WHEN ActionCodeDate IS NULL THEN '' " &
                    '                 "ELSE ActionCodeDate " &
                    '                 "END AS 'ActionCodeDate'"
                    'ElseIf strADDTEXT = "DateReported" Then
                    '    strADDTEXT = "CASE WHEN REPLACE(DateReported,'-','') = 0 THEN '' " &
                    '                 "WHEN DateReported IS NULL THEN '' " &
                    '                 "ELSE DateReported " &
                    '                 "END AS 'DateReported'"
                    'End If

                    If intSELECTED = 0 Then
                        strSELECT = "SELECT " & strADDTEXT
                    Else
                        strSELECT = strSELECT & ", " & strADDTEXT
                    End If
                    intSELECTED += 1
                Next
            Else
                MsgBox("Please select columns to display.", 48, "Invalid Selection")
                Exit Sub
            End If

            ' BUILD "FILTER" PORTION OF QUERY
            Dim intFilterIndex As Integer

            For intFilterIndex = 1 To 5
                strCOLUMN = ""
                strOPERATOR = ""
                strVALUE = ""
                For Each txtbx In Panel1.Controls.OfType(Of TextBox)
                    If InStr(txtbx.Name.ToString, intFilterIndex) Then
                        If txtbx.Text <> "" Then
                            strVALUE = txtbx.Text                                                      ' FILTER TEXT ENTERED IN
                            For Each cmb In Panel1.Controls.OfType(Of ComboBox)
                                If InStr(cmb.Name.ToString, "Filter" & intFilterIndex) Then
                                    strCOLUMN = cmb.SelectedItem.ToString                              ' FILTER COLUMN ID VALUE
                                ElseIf InStr(cmb.Name.ToString, "Operator" & intFilterIndex) Then
                                    strOPERATOR = cmb.SelectedValue.ToString                           ' OPERATOR VALUE
                                End If
                            Next
                        End If
                    End If
                Next
                If strCOLUMN <> "" AndAlso strOPERATOR <> "" AndAlso strVALUE <> "" Then
                    If strOPERATOR = "LIKE" Then strVALUE = Chr(37) & strVALUE & Chr(37)
                    If strFILTER = "" Then
                        strFILTER = "WHERE " & strCOLUMN & " " & strOPERATOR & " " & Chr(39) & strVALUE & Chr(39)
                    Else
                        strFILTER = strFILTER & " AND " & strCOLUMN & " " & strOPERATOR & " " & Chr(39) & strVALUE & Chr(39)

                    End If

                End If
            Next intFilterIndex

            ' STRING TOGETHER PORTIONS OF QUERY
            strQUERY = strSELECT & " " & strFROM & " " & strFILTER
            TextBox1.Text = strQUERY

            ' EXECUTE QUERY
            ExecuteQuery_DataTable(strQUERY, tblResults)

            ' POPULATE DATA GRID VIEW WITH RESULTS
            With dgvResults
                .MultiSelect = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .DataSource = tblResults
            End With


        Else
            MsgBox("Please select data table to use.", 48, "Invalid Selection")
        End If

        blnExecFlag = True

    End Sub

    Private Sub RadioButton1_Changed()

        GetColumnNames(strDBTbl)
        AddComboBoxFields()
        ClearTextBoxes()
        CheckBox1.Checked = False
        blnExecFlag = False

    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        strDBTbl = "tblcpttransactions"
        RadioButton1_Changed()

    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        strDBTbl = "tblmanagerreview"
        RadioButton1_Changed()

    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        strDBTbl = "tblnocredit"
        RadioButton1_Changed()

    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

        strDBTbl = "tbltransactions"
        RadioButton1_Changed()

    End Sub

    Sub ClearTextBoxes()
        For Each tb In Panel1.Controls.OfType(Of TextBox)
            tb.Text = ""
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If strSkipFlag = "" Then

            Dim i As Integer
            Dim checkFlag As String = "True"
            If CheckBox1.Checked <> True Then
                checkFlag = "False"
            End If
            For i = 0 To (CheckedListBox1.Items.Count - 1)
                CheckedListBox1.SetItemChecked(i, checkFlag)
            Next i

        End If

        strSkipFlag = ""

        blnExecFlag = False

    End Sub

    Private Sub AddComboBoxFields()

        Dim i As Integer

        For Each cmb In Panel1.Controls.OfType(Of ComboBox)()

            ' CLEAR ALL EXISTING VALUES IN COMBO BOXES
            If InStr(cmb.Name.ToString, "Filter") > 0 Then
                cmb.SelectedIndex = -1
                For i = 1 To cmb.Items.Count
                    cmb.Items.RemoveAt(0)
                Next
            End If

            ' POPULATE 5 DEFAULT FIELDS TO REFINE BY
            If InStr(cmb.Name.ToString, "Filter") > 0 Then
                cmb.Items.Add("TransactionID")
                cmb.Items.Add("Debtor")
                cmb.Items.Add("ClientID")
                cmb.Items.Add("TransDate")
                cmb.Items.Add("PostDate")

                ' POPULATE CREDIT FIELDS TO REFINE BY IF TRANSACTION TABLE SELECTED
                If strDBTbl = "tblcpttransactions" Or strDBTbl = "tbltransactions" Then
                    cmb.Items.Add("CreditMonth")
                    cmb.Items.Add("CreditYear")
                End If

            End If

            ' POPULATE OPERATOR COMBO BOXES
            If InStr(cmb.Name.ToString, "Operator") > 0 Then
                cmb.BindingContext = New BindingContext()
                cmb.DataSource = dsOperators.Tables(0)
                cmb.ValueMember = "operatorSymbol"
                cmb.DisplayMember = "operatorText"
                cmb.SelectedValue = ""
            End If

        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _Resize()

        SetConnection()

        'POPULATE OPERATOR TABLE
        GetOperators()

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

        strSkipFlag = "Y"
        CheckBox1.Checked = False
        strSkipFlag = ""

        blnExecFlag = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        For Each cmb In Panel1.Controls.OfType(Of ComboBox)
            cmb.SelectedIndex = -1
        Next

        For Each tb In Panel1.Controls.OfType(Of TextBox)
            tb.Text = ""
        Next

        tblResults.Clear()
        dgvResults.DataSource = Nothing

        CheckBox1.Checked = False
        blnExecFlag = False

    End Sub
    Private Sub _Resize()

        Dim intFrmHeight As Int16 = Height
        Dim intFrmWidth As Int16 = Width
        Dim intTCHeight As Int16 = intFrmHeight - 240
        Dim intTCWidth As Int16 = intFrmWidth - 40
        Dim intTPHeight As Int16
        Dim intTPWidth As Int16
        Dim objWidth As Int16
        Dim objHeight As Int16
        Dim objXLoc As Int16 = 12
        Dim objYLoc As Int16 = 191

        TabControl1.Height = intTCHeight
        TabControl1.Width = intTCWidth

        Select Case TabControl1.SelectedTab.Text
            Case "Results"
                intTPHeight = intTCHeight - 30
                intTPWidth = intTCWidth - 10
                TabPage1.Height = intTPHeight
                TabPage1.Width = intTPWidth
                objHeight = intTPHeight - 5
                objWidth = intTPWidth - 5
                dgvResults.Height = objHeight
                dgvResults.Width = objWidth
            Case "Query"
                intTPHeight = intTCHeight - 30
                intTPWidth = intTCWidth - 20
                TabPage2.Height = intTPHeight
                TabPage2.Width = intTPWidth
                objHeight = intTPHeight - 5
                objWidth = intTPWidth - 5
                TextBox1.Height = objHeight
                TextBox1.Width = objWidth
        End Select

    End Sub

    Private Sub frmQueryBuilder_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        _Resize()
    End Sub

    Private Sub tabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        _Resize()
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If blnMoveFlag = False Then
            e.Cancel = True
        Else
            Try
                dgvResults.Rows(rIndex).Selected = True
                If dgvResults(0, rIndex).Value.ToString <> "" Then
                    strTXID = dgvResults(0, rIndex).Value
                End If
            Catch ex As Exception
                dgvResults.CurrentCell = Nothing
            End Try
        End If
    End Sub

    Private Sub dgvResults_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvResults.MouseDown
        If e.Button = MouseButtons.Right Then
            If blnExecFlag = True Then
                If RadioButton1.Checked Or RadioButton4.Checked Then
                    blnMoveFlag = False
                    rIndex = Nothing
                Else
                    blnMoveFlag = True
                    rIndex = dgvResults.HitTest(e.Location.X, e.Location.Y).RowIndex
                End If
            End If
        End If
    End Sub

    Private Sub SingleTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SingleTransactionToolStripMenuItem.Click
        Dim strResponse As String
        strResponse = MsgBox("Are you sure you want to move this transaction to tbltransactions?", vbYesNo)
        If strResponse = vbYes Then
            If strTXID <> "" Then
                MoveTX()
                btnExecute_Click(sender, e)
                MsgBox("Moved " & strTXID & " from " & strDBTbl & " to tbltransactions.")
            End If
        End If
    End Sub

    Private Sub AllTransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllTransactionsToolStripMenuItem.Click
        Dim strResponse As String
        strResponse = MsgBox("Are you sure you want to move all of these transactions to tbltransactions?", vbYesNo)
        If strResponse = vbYes Then
            Dim strMovedTransactions As String = ""
            Dim t As Int16
            For t = 0 To (dgvResults.RowCount - 2)
                strTXID = dgvResults(0, t).Value.ToString
                MoveTX()
                If strMovedTransactions = "" Then
                    strMovedTransactions = strTXID
                Else
                    strMovedTransactions = strMovedTransactions & vbCrLf & strTXID
                End If
            Next t
            btnExecute_Click(sender, e)
            MsgBox("Moved the following transactions from " & strDBTbl & " to tbltransactions: " & vbCrLf & vbCrLf & strMovedTransactions)
        End If
    End Sub

End Class

