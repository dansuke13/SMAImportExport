Imports NarsilWorks.DevLib
Imports NarsilWorks.DevLibData
Imports NarsilWorks.DevLibWinForms
Imports SpreadsheetLight
Imports Excel = Microsoft.Office.Interop.Excel
Imports DocumentFormat.OpenXml.InkML
Imports System.Windows.Forms

Public Class EmployeeDoorForm
    Private m_IsLoading As Boolean = False
    Private m_IsEditing As Boolean = False
    Private m_dtdoor As DataTable
    Private m_EmployeeKey As Integer = 0
    Private m_DoorKey As Integer = 0

    Private Sub EmployeeDoorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_IsLoading = True

        'Call Initialize()
        Call RefreshList()
        'Call LoadReasonType()

        ImportButton.Enabled = True
        ExportButton.Enabled = True
        AddButton.Enabled = True
        EditButton.Enabled = True
        SaveButton.Enabled = False
        CancelButton.Enabled = False
        DeleteButton.Enabled = True
        PanelBox.Visible = False
    End Sub

    Private Sub RefreshList()
        Try
            Using m_Dmgr As New DataManager(m_ConStr)
                m_dtdoor = m_Dmgr.GetDataTable("SELECT a.EmployeeKey, a.UserName, a.FirstName, a.LastName, a.Email, b.DoorKey, b.DoorID, b.DoorName, b.Description 
                                                FROM dbo.tcoEmployee AS a
                                                INNER JOIN dbo.tcoDoor AS b
                                                ON a.EmployeeKey = b.DoorKey")
                DataGridView1.DataSource = m_dtdoor
                m_dtdoor.Dispose()
            End Using
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    'Private Sub LoadReasonType()
    '    Try
    '        Using m_Dmgr As New DataManager(m_ConStr)
    '            m_dtdoor = m_Dmgr.GetDataTable("SELECT EmployeeKey, UserName, FirstName, LastName, Email FROM dbo.tcoEmployee
    '                                             UNION ALL
    '                                            SELECT DoorKey, DoorID, DoorName, Description FROM dbo.tcoDoor FROM dbo.tcoDoor")
    '            DataGridView1.DataSource = m_dtdoor
    '            m_dtdoor.Dispose()
    '        End Using
    '    Catch ex As Exception
    '        MsgBox("Error")
    '    End Try
    'End Sub


    Private Sub SearchAll_Call()
        Using m_Dmgr As New DataManager(m_ConStr)
            Try
                m_dtdoor = m_Dmgr.GetDataTable("SELECT *
                                                FROM dbo.tcoEmployee AS a
                                                INNER JOIN dbo.tcoDoor AS b
                                                ON a.EmployeeKey = b.DoorKey
                                                WHERE CONCAT(a.EmployeeKey, a.UserName, a.FirstName, a.LastName, a.Email, b.DoorKey, b.DoorID, b.DoorName, b.Description) LIKE '%" & SearchAll.Text & "%'")
                DataGridView1.DataSource = m_dtdoor
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End Using
    End Sub

    Private Sub Import_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Dim ofd As New OpenFileDialog
        Dim UserName As String
        Dim FirstName As String
        Dim LastName As String
        Dim Email As String
        Dim EmployeeKey As Integer = 0
        ofd.Filter = "Excel 2007 files *.xlsx|*.xlsx"
        If ofd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                Using sl = New SpreadsheetLight.SLDocument(ofd.FileName)
                    Dim ws As SpreadsheetLight.SLWorksheetStatistics = sl.GetWorksheetStatistics()
                    Dim m_MaxRows = ws.NumberOfRows
                    Using m_Dmgr As New DataManager(m_ConStr)
                        For ix As Integer = 2 To m_MaxRows
                            UserName = Trim(sl.GetCellValueAsString(ix, 1))
                            FirstName = Trim(sl.GetCellValueAsString(ix, 2))
                            LastName = Trim(sl.GetCellValueAsString(ix, 3))
                            Email = Trim(sl.GetCellValueAsString(ix, 4))
                            Dim m_existing As Boolean = False
                            If UserName <> "" Then
                                m_existing = m_Dmgr.GetCount("dbo.tcoEmployee WHERE UserName = @p1", UserName)
                                If Not m_existing Then
                                    EmployeeKey = m_Dmgr.GetValue("EXEC ssh_getnextnumberapps @p1", 0, "EmployeeKey")
                                    Dim q As New QueryBuilder("tcoEmployee")
                                    q.CommandType = QueryBuilder.CommandQuery.cqINSERT
                                    q.AddFieldValuePair("EmployeeKey", EmployeeKey, True)
                                    q.AddFieldValuePair("UserName", UserName, True)
                                    q.AddFieldValuePair("FirstName", FirstName, True)
                                    q.AddFieldValuePair("LastName", LastName, True)
                                    q.AddFieldValuePair("Email", Email, True)
                                    m_Dmgr.ExecuteNonQuery(q.GetQuery)
                                End If
                            End If
                        Next
                        Call RefreshList()
                        m_Dmgr.Dispose()
                        MsgBox("Import Success")
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error Import")
            End Try

        End If
    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        Try
            Dim sfd As New SaveFileDialog
            sfd.Filter = "Excel 2007 files (*.xlsx)|*.xlsx"
            If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then

                Using sl = New SpreadsheetLight.SLDocument()
                    Dim m_Dmgr As New DataManager(m_ConStr)
                    Dim dataTable As DataTable = m_Dmgr.GetDataTable("SELECT UserName, FirstName, LastName, Email FROM dbo.tcoEmployee")

                    For col As Integer = 0 To dataTable.Columns.Count - 1
                        sl.SetCellValue(1, col + 1, dataTable.Columns(col).ColumnName)
                    Next

                    For row As Integer = 0 To dataTable.Rows.Count - 1
                        For col As Integer = 0 To dataTable.Columns.Count - 1
                            sl.SetCellValue(row + 2, col + 1, dataTable.Rows(row)(col).ToString())
                        Next
                    Next

                    sl.SaveAs(sfd.FileName)
                    MessageBox.Show("Export Successful")
                End Using

            End If
        Catch ex As Exception
            MsgBox("Error Export")
        End Try
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            m_IsLoading = False
            m_IsEditing = False

            UserNameTextBox.Text = String.Empty
            FirstNameTextBox.Text = String.Empty
            LastNameTextBox.Text = String.Empty
            EmailTextBox.Text = String.Empty

            DoorIDTextBox.Text = String.Empty
            DoorNameTextBox.Text = String.Empty
            DescriptionTextBox.Text = String.Empty

            UserNameTextBox.Enabled = True
            ImportButton.Enabled = False
            ExportButton.Enabled = False
            AddButton.Enabled = False
            EditButton.Enabled = False
            SaveButton.Enabled = True
            CancelButton.Enabled = True
            DeleteButton.Enabled = False
            PanelBox.Visible = True
        Catch ex As Exception
            MsgBox("Error Edit")
        End Try
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Try
            m_IsLoading = True
            m_IsEditing = True
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim dgvr As DataGridViewRow = DataGridView1.SelectedRows(0)
                m_EmployeeKey = NullString(dgvr.Cells("EmployeeKey").Value)
                UserNameTextBox.Text = NullString(dgvr.Cells("UserName").Value)
                FirstNameTextBox.Text = NullString(dgvr.Cells("FirstName").Value)
                LastNameTextBox.Text = NullString(dgvr.Cells("LastName").Value)
                EmailTextBox.Text = NullString(dgvr.Cells("Email").Value)

                m_DoorKey = NullString(dgvr.Cells("DoorKey").Value)
                DoorIDTextBox.Text = NullString(dgvr.Cells("DoorID").Value)
                DoorNameTextBox.Text = NullString(dgvr.Cells("DoorName").Value)
                DescriptionTextBox.Text = NullString(dgvr.Cells("Description").Value)

                UserNameTextBox.Enabled = False
                ImportButton.Enabled = False
                ExportButton.Enabled = False
                AddButton.Enabled = False
                EditButton.Enabled = False
                SaveButton.Enabled = True
                CancelButton.Enabled = True
                DeleteButton.Enabled = False
                PanelBox.Visible = True
            Else
                EditButton.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Error Edit")
        End Try
    End Sub

    Private Sub DataGridView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        Try
            m_IsLoading = True
            m_IsEditing = True
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim dgvr As DataGridViewRow = DataGridView1.SelectedRows(0)
                m_EmployeeKey = NullString(dgvr.Cells("EmployeeKey").Value)
                UserNameTextBox.Text = NullString(dgvr.Cells("UserName").Value)
                FirstNameTextBox.Text = NullString(dgvr.Cells("FirstName").Value)
                LastNameTextBox.Text = NullString(dgvr.Cells("LastName").Value)
                EmailTextBox.Text = NullString(dgvr.Cells("Email").Value)

                m_DoorKey = NullString(dgvr.Cells("DoorKey").Value)
                DoorIDTextBox.Text = NullString(dgvr.Cells("DoorID").Value)
                DoorNameTextBox.Text = NullString(dgvr.Cells("DoorName").Value)
                DescriptionTextBox.Text = NullString(dgvr.Cells("Description").Value)

                ImportButton.Enabled = False
                ExportButton.Enabled = False
                AddButton.Enabled = False
                EditButton.Enabled = False
                SaveButton.Enabled = True
                CancelButton.Enabled = True
                DeleteButton.Enabled = False
                PanelBox.Visible = True
            Else
                EditButton.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("Error Edit")
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If UserNameTextBox.Text.Trim.Length = 0 Then
                MsgBox("Please provide reason code!", MsgBoxStyle.Exclamation, "No Data")
                SaveButton.Enabled = True
                UserNameTextBox.Focus()
                Exit Try
            End If

            Using m_DMgr As New DataManager(m_ConStr)

                Dim q As New QueryBuilder("tcoEmployee")
                'Dim q2 As New QueryBuilder("tcoDoor")


                If m_IsEditing = False Then
                    Dim m_IsExisting As Boolean = m_DMgr.GetCount("dbo.tcoEmployee WHERE UserName = @p1", New Parameter(UserNameTextBox.Text.Trim)) > 0
                    If m_IsExisting = True Then
                        MsgBox("Reason code already exist in the database!", MsgBoxStyle.Exclamation, "Duplicate Record")
                        Exit Try
                    End If

                    Dim EmployeeKey As Integer = 0
                    EmployeeKey = m_DMgr.GetValue("EXEC ssh_getnextnumberapps @p1", 0, "EmployeeKey")

                    q.CommandType = QueryBuilder.CommandQuery.cqINSERT
                    q.AddFieldValuePair("EmployeeKey", EmployeeKey, True)
                    q.AddFieldValuePair("UserName", UserNameTextBox.Text, True)
                    q.AddFieldValuePair("FirstName", FirstNameTextBox.Text, True)
                    q.AddFieldValuePair("LastName", LastNameTextBox.Text, True)
                    q.AddFieldValuePair("Email", EmailTextBox.Text, True)


                    'Dim DoorKey As Integer = 0
                    'DoorKey = m_DMgr.GetValue("EXEC ssh_getnextnumberapps @p1", 0, "DoorKey")

                    'q2.CommandType = QueryBuilder.CommandQuery.cqINSERT
                    'q2.AddFieldValuePair("DoorKey", EmployeeKey, True)
                    'q2.AddFieldValuePair("DoorID", DoorIDTextBox.Text, True)
                    'q2.AddFieldValuePair("DoorName", DoorNameTextBox.Text, True)
                    'q2.AddFieldValuePair("Description", DescriptionTextBox.Text, True)

                    'm_DMgr.ExecuteNonQuery(q.GetQuery, q2.GetQuery)
                    m_DMgr.ExecuteNonQuery(q.GetQuery)

                    PanelBox.Visible = False
                    MsgBox("The record was saved successfully!", MsgBoxStyle.Information, "Success")

                Else
                    q.CommandType = QueryBuilder.CommandQuery.cqUPDATE
                    q.AddFilter("EmployeeKey=" & m_EmployeeKey)
                    q.AddFieldValuePair("FirstName", FirstNameTextBox.Text, True)
                    q.AddFieldValuePair("LastName", LastNameTextBox.Text, True)
                    q.AddFieldValuePair("Email", EmailTextBox.Text, True)

                    m_DMgr.ExecuteNonQuery(q.GetQuery)

                    PanelBox.Visible = False
                    MsgBox("The record was updated successfully!", MsgBoxStyle.Information, "Success")
                End If
            End Using

            SaveButton.Enabled = True
            Call RefreshList()
            m_IsLoading = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ImportButton.Enabled = True
        ExportButton.Enabled = True
        AddButton.Enabled = True
        EditButton.Enabled = True
        SaveButton.Enabled = False
        CancelButton.Enabled = False
        DeleteButton.Enabled = True
        PanelBox.Visible = False
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If MsgBox("Are you sure you want to delete this item?", MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, "Delete Item") = MsgBoxResult.Yes Then
            Using m_DMgr As New DataManager(m_ConStr)
                Try
                    'check if already used
                    If DataGridView1.SelectedRows.Count > 0 Then
                        Dim dgvr As DataGridViewRow = DataGridView1.SelectedRows(0)

                        Dim m_existing = m_DMgr.GetCount("dbo.tcoEmployee WHERE UserName = @p1", dgvr.Cells("UserName").Value)
                        If m_existing = True Then
                            MsgBox("Reason code already used in the database!", MsgBoxStyle.Exclamation, "Error")
                            Exit Try
                        End If

                        'Delete Reason
                        'm_DMgr.ExecuteNonQuery("DELETE FROM  tsoReasonCode WHERE ReasonKey= '" & dgvr.Cells("ReasonKey").Value & "'")
                        m_DMgr.ExecuteNonQuery("DELETE FROM dbo.tcoEmployee WHERE UserName = @p1", dgvr.Cells("UserName").Value)

                        Call RefreshList()

                        Call SearchAll_Call()

                        MsgBox("The record was deleted successfully!", MsgBoxStyle.Information, "Success")
                    End If

                Catch ex As Exception
                    MsgBox("Could not delete the selected record.", MsgBoxStyle.Critical, "Error")
                End Try
            End Using
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub SearchAll_TextChanged(sender As Object, e As EventArgs) Handles SearchAll.TextChanged
        Call SearchAll_Call()
    End Sub

    Private Sub RefreshLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RefreshLinkLabel.LinkClicked
        Call SearchAll_Call()
    End Sub
End Class