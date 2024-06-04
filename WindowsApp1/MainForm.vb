Imports NarsilWorks.DevLib
Imports NarsilWorks.DevLibData
Imports McKenzie.Permissions.Zeus
Imports System.Collections.ObjectModel
Imports NarsilWorks.DevLibWinForms

Public Class MainForm


    Public Sub SetFooter()
        With mftrMain
            Using m_DMgr = New DataManager(m_ConStr)
                Try
                    m_server_name = m_DMgr.GetCurrentServer
                    m_database_name = m_DMgr.GetCurrentDatabase
                    m_database_user = m_DMgr.GetCurrentUser
                    .ServerName = m_server_name
                    .DatabaseName = m_database_name
                    .DatabaseUser = m_database_user


                Catch ex As Exception

                End Try
            End Using
            .Status = "Ready."
        End With
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_ConStr = GetRegisteredConnection("SMAImport", "VDIMDCI APPS")
        SetFooter()
    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        Try
            If g_EmployeeForm Is Nothing Then
                g_EmployeeForm = New EmployeeForm
            End If
            If g_EmployeeForm IsNot Nothing Then
                If g_EmployeeForm.IsDisposed Then
                    g_EmployeeForm = New EmployeeForm
                End If
                g_EmployeeForm.MdiParent = Me
                g_EmployeeForm.Show()
                g_EmployeeForm.FooterEmployee.ServerName = m_server_name
                g_EmployeeForm.FooterEmployee.DatabaseName = m_database_name
                g_EmployeeForm.FooterEmployee.DatabaseUser = m_database_user

            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub ShippingsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ShippingsToolStripMenuItem.Click
        Try
            If g_ShippingForm Is Nothing Then
                g_ShippingForm = New ShippingForm
            End If
            If g_ShippingForm IsNot Nothing Then
                If g_ShippingForm.IsDisposed Then
                    g_ShippingForm = New ShippingForm
                End If
                g_ShippingForm.MdiParent = Me
                g_ShippingForm.Show()
                g_ShippingForm.FooterShipping.ServerName = m_server_name
                g_ShippingForm.FooterShipping.DatabaseName = m_database_name
                g_ShippingForm.FooterShipping.DatabaseUser = m_database_user
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Try
            If g_EmployeeDoorForm Is Nothing Then
                g_EmployeeDoorForm = New EmployeeDoorForm
            End If
            If g_EmployeeDoorForm IsNot Nothing Then
                If g_EmployeeDoorForm.IsDisposed Then
                    g_EmployeeDoorForm = New EmployeeDoorForm
                End If
                g_EmployeeDoorForm.MdiParent = Me
                g_EmployeeDoorForm.Show()
                g_EmployeeDoorForm.FooterEmployeeShipping.ServerName = m_server_name
                g_EmployeeDoorForm.FooterEmployeeShipping.DatabaseName = m_database_name
                g_EmployeeDoorForm.FooterEmployeeShipping.DatabaseUser = m_database_user
            End If
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
End Class
