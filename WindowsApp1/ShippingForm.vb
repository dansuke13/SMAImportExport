﻿Imports NarsilWorks.DevLib
Imports NarsilWorks.DevLibData
Imports NarsilWorks.DevLibWinForms
Imports SpreadsheetLight
Imports DocumentFormat.OpenXml.InkML
Imports DocumentFormat.OpenXml.Wordprocessing
Imports System.Windows.Forms

Public Class ShippingForm
    Private m_IsLoading As Boolean = False
    Private m_IsEditing As Boolean = False
    Private m_dtdoor As DataTable
    Private m_DoorKey As Integer = 0


    Private Sub ShippingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_IsLoading = True

        'Call Initialize()
        Call RefreshList()

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
        Using m_Dmgr As New DataManager(m_ConStr)
            Try
                m_dtdoor = m_Dmgr.GetDataTable("SELECT DoorKey, DoorID, DoorName, Description FROM dbo.tcoDoor")
                DataGridView1.DataSource = m_dtdoor
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End Using
    End Sub

    Private Sub SearchAll_Call()
        Using m_Dmgr As New DataManager(m_ConStr)
            Try
                m_dtdoor = m_Dmgr.GetDataTable("SELECT * FROM dbo.tcoDoor WHERE CONCAT(DoorKey, DoorID, DoorName, Description) LIKE '%" & SearchAll.Text & "%'")
                DataGridView1.DataSource = m_dtdoor
            Catch ex As Exception
                MsgBox("Error")
            End Try
        End Using
    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles ImportButton.Click
        Dim ofd As New OpenFileDialog
        Dim DoorKey As Integer = 0
        Dim DoorID As String
        Dim DoorName As String
        Dim Description As String
        ofd.Filter = "Excel 2007 files *.xlsx|*.xlsx"
        If ofd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                Using sl = New SpreadsheetLight.SLDocument(ofd.FileName)
                    Dim ws As SpreadsheetLight.SLWorksheetStatistics = sl.GetWorksheetStatistics()
                    Dim m_MaxRows = ws.NumberOfRows

                    Using m_Dmgr As New DataManager(m_ConStr)
                        For ix As Integer = 2 To m_MaxRows
                            DoorID = Trim(sl.GetCellValueAsString(ix, 1))
                            DoorName = Trim(sl.GetCellValueAsString(ix, 2))
                            Description = Trim(sl.GetCellValueAsString(ix, 3))
                            Dim m_existing As Boolean = False
                            If DoorID <> "" Then
                                m_existing = m_Dmgr.GetCount("dbo.tcoDoor WHERE DoorID = @p1", DoorID)
                                If Not m_existing Then
                                    DoorKey = m_Dmgr.GetValue("EXEC ssh_getnextnumberapps @p1", 0, "DoorKey")
                                    Dim q As New QueryBuilder("tcoDoor")
                                    q.CommandType = QueryBuilder.CommandQuery.cqINSERT
                                    q.AddFieldValuePair("DoorKey", DoorKey, True)
                                    q.AddFieldValuePair("DoorID", DoorID, True)
                                    q.AddFieldValuePair("DoorName", DoorName, True)
                                    q.AddFieldValuePair("Description", Description, True)
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
                    Dim dataTable As DataTable = m_Dmgr.GetDataTable("SELECT DoorKey, DoorID, DoorName, Description FROM dbo.tcoDoor")

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

            DoorIDTextBox.Text = String.Empty
            DoorNameTextBox.Text = String.Empty
            DescriptionTextBox.Text = String.Empty

            DoorIDTextBox.Enabled = True
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
                m_DoorKey = NullString(dgvr.Cells("DoorKey").Value)
                DoorIDTextBox.Text = NullString(dgvr.Cells("DoorID").Value)
                DoorNameTextBox.Text = NullString(dgvr.Cells("DoorName").Value)
                DescriptionTextBox.Text = NullString(dgvr.Cells("Description").Value)


                DoorIDTextBox.Enabled = False
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

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            m_IsLoading = True
            m_IsEditing = True
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim dgvr As DataGridViewRow = DataGridView1.SelectedRows(0)
                m_DoorKey = NullString(dgvr.Cells("DoorKey").Value)
                DoorIDTextBox.Text = NullString(dgvr.Cells("DoorID").Value)
                DoorNameTextBox.Text = NullString(dgvr.Cells("DoorName").Value)
                DescriptionTextBox.Text = NullString(dgvr.Cells("Description").Value)

                DoorIDTextBox.Enabled = False
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
            SaveButton.Enabled = False

            If DoorIDTextBox.Text.Trim.Length = 0 Then
                MsgBox("Please provide reason code!", MsgBoxStyle.Exclamation, "No Data")
                SaveButton.Enabled = True
                DoorIDTextBox.Focus()
                Exit Try
            End If

            Using m_DMgr As New DataManager(m_ConStr)

                Dim q As New QueryBuilder("tcoDoor")

                If m_IsEditing = False Then
                    Dim m_IsExisting As Boolean = m_DMgr.GetCount("dbo.tcoDoor WHERE DoorID = @p1", New Parameter(DoorIDTextBox.Text.Trim)) > 0
                    If m_IsExisting = True Then
                        MsgBox("Reason code already exist in the database!", MsgBoxStyle.Exclamation, "Duplicate Record")
                        Exit Try
                    End If
                    Dim DoorKey As Integer = 0
                    DoorKey = m_DMgr.GetValue("EXEC ssh_getnextnumberapps @p1", 0, "DoorKey")
                    q.CommandType = QueryBuilder.CommandQuery.cqINSERT

                    q.AddFieldValuePair("DoorKey", DoorKey, True)
                    q.AddFieldValuePair("DoorID", DoorIDTextBox.Text, True)
                    q.AddFieldValuePair("DoorName", DoorNameTextBox.Text, True)
                    q.AddFieldValuePair("Description", DescriptionTextBox.Text, True)

                    m_DMgr.ExecuteNonQuery(q.GetQuery)

                    PanelBox.Visible = False
                    MsgBox("The record was saved successfully!", MsgBoxStyle.Information, "Success")

                Else
                    q.CommandType = QueryBuilder.CommandQuery.cqUPDATE
                    q.AddFilter("DoorKey=" & m_DoorKey)
                    q.AddFieldValuePair("DoorID", DoorIDTextBox.Text, True)
                    q.AddFieldValuePair("DoorName", DoorNameTextBox.Text, True)
                    q.AddFieldValuePair("Description", DescriptionTextBox.Text, True)

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