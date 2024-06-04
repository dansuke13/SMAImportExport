<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShippingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.mftrMain = New NarsilWorks.DevLibWinForms.Footer()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(925, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeesToolStripMenuItem, Me.ShippingsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.EmployeeToolStripMenuItem.Text = "Company"
        '
        'EmployeesToolStripMenuItem
        '
        Me.EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem"
        Me.EmployeesToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.EmployeesToolStripMenuItem.Text = "Employees"
        '
        'ShippingsToolStripMenuItem
        '
        Me.ShippingsToolStripMenuItem.Name = "ShippingsToolStripMenuItem"
        Me.ShippingsToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ShippingsToolStripMenuItem.Text = "Doors"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.ToolStripMenuItem1.Text = "EmployeesDoors"
        '
        'mftrMain
        '
        Me.mftrMain.AlertIconVisible = False
        Me.mftrMain.AlertType = NarsilWorks.DevLibWinForms.Footer.AlertTypeStatusConstants.Info
        Me.mftrMain.AutoSize = True
        Me.mftrMain.DatabaseName = ""
        Me.mftrMain.DatabaseUser = ""
        Me.mftrMain.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.mftrMain.Location = New System.Drawing.Point(0, 580)
        Me.mftrMain.LoggedOnUser = ""
        Me.mftrMain.Name = "mftrMain"
        Me.mftrMain.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks
        Me.mftrMain.ProgressBarVisible = False
        Me.mftrMain.ProgressValue = 0
        Me.mftrMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.mftrMain.ServerName = ""
        Me.mftrMain.Size = New System.Drawing.Size(925, 25)
        Me.mftrMain.Status = ""
        Me.mftrMain.TabIndex = 9
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 605)
        Me.Controls.Add(Me.mftrMain)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MainForm"
        Me.Text = "                                                        "
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EmployeeToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeesToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShippingsToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents mftrMain As NarsilWorks.DevLibWinForms.Footer
End Class
