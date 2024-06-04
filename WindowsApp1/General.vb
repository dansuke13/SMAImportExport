Imports NarsilWorks.DevLib
Imports NarsilWorks.DevLibData
Imports NarsilWorks.DevLibWinForms
Imports McKenzie.Permissions.Zeus
Imports System.Collections.Specialized
Imports System.Data.SqlClient
Imports System.Windows.Forms
Module General
    Public g_EmployeeForm As EmployeeForm
    Public g_ShippingForm As ShippingForm
    Public g_EmployeeDoorForm As EmployeeDoorForm

    Public m_server_name As String
    Public m_database_name As String
    Public m_database_user As String

    Public m_ConStr As String
End Module
