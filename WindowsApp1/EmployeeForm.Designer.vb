<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeForm))
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New NarsilWorks.DevLibWinForms.DataGridView()
        Me.DataGridViewFilter1 = New NarsilWorks.DevLibWinForms.DataGridViewFilter()
        Me.SearchAll = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomPanel1 = New NarsilWorks.DevLibWinForms.CustomPanel()
        Me.Footer1 = New NarsilWorks.DevLibWinForms.Footer()
        Me.RefreshLinkLabel = New NarsilWorks.DevLibWinForms.LinkLabel()
        Me.PanelBox = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeKey = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExportButton
        '
        Me.ExportButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExportButton.Image = CType(resources.GetObject("ExportButton.Image"), System.Drawing.Image)
        Me.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExportButton.Location = New System.Drawing.Point(722, 50)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(66, 31)
        Me.ExportButton.TabIndex = 0
        Me.ExportButton.Text = "Export"
        Me.ExportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'ImportButton
        '
        Me.ImportButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImportButton.Image = CType(resources.GetObject("ImportButton.Image"), System.Drawing.Image)
        Me.ImportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ImportButton.Location = New System.Drawing.Point(722, 12)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(66, 32)
        Me.ImportButton.TabIndex = 1
        Me.ImportButton.Text = "Import"
        Me.ImportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddButton.Image = CType(resources.GetObject("AddButton.Image"), System.Drawing.Image)
        Me.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddButton.Location = New System.Drawing.Point(722, 87)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(66, 32)
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "Add"
        Me.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditButton.Image = CType(resources.GetObject("EditButton.Image"), System.Drawing.Image)
        Me.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditButton.Location = New System.Drawing.Point(722, 125)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(66, 31)
        Me.EditButton.TabIndex = 2
        Me.EditButton.Text = "Edit"
        Me.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(722, 162)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(66, 32)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Save"
        Me.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelButton.Image = CType(resources.GetObject("CancelButton.Image"), System.Drawing.Image)
        Me.CancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelButton.Location = New System.Drawing.Point(722, 200)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(66, 31)
        Me.CancelButton.TabIndex = 4
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(722, 237)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(66, 31)
        Me.DeleteButton.TabIndex = 6
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.AllowDrop = True
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Image = CType(resources.GetObject("CloseButton.Image"), System.Drawing.Image)
        Me.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CloseButton.Location = New System.Drawing.Point(722, 387)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(66, 31)
        Me.CloseButton.TabIndex = 7
        Me.CloseButton.Text = "Close"
        Me.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowMultiRowDrag = False
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoReflectEnableOnColumns = True
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CheckAllColumn = ""
        Me.DataGridView1.CheckAllToolTipText = ""
        Me.DataGridView1.CheckAllVisible = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeKey, Me.UserName, Me.FirstName, Me.LastName, Me.Email})
        Me.DataGridView1.CustomGroupRowPainting = False
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GroupRowBackColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.GroupRowDropShadowColor = System.Drawing.SystemColors.ControlDark
        Me.DataGridView1.GroupRowFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.GroupRowForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView1.GroupRowHeight = 22.0!
        Me.DataGridView1.GroupRowIndicatorDataGridViewColumnName = ""
        Me.DataGridView1.GroupRowIndicatorID = ""
        Me.DataGridView1.GroupRowTextDataGridViewColumnName = ""
        Me.DataGridView1.Location = New System.Drawing.Point(12, 72)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(704, 347)
        Me.DataGridView1.TabIndex = 3
        '
        'DataGridViewFilter1
        '
        Me.DataGridViewFilter1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewFilter1.AutoCompleteColumnFilters = New String(-1) {}
        Me.DataGridViewFilter1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridViewFilter1.DataGridView = Nothing
        Me.DataGridViewFilter1.DropdownColumnFilters = New String(-1) {}
        Me.DataGridViewFilter1.FieldHeight = 28
        Me.DataGridViewFilter1.FieldMargin = New System.Windows.Forms.Padding(1, 4, 1, 4)
        Me.DataGridViewFilter1.FixedFilter = ""
        Me.DataGridViewFilter1.Location = New System.Drawing.Point(12, 39)
        Me.DataGridViewFilter1.Name = "DataGridViewFilter1"
        Me.DataGridViewFilter1.Size = New System.Drawing.Size(704, 27)
        Me.DataGridViewFilter1.TabIndex = 9
        '
        'SearchAll
        '
        Me.SearchAll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchAll.Location = New System.Drawing.Point(68, 13)
        Me.SearchAll.Name = "SearchAll"
        Me.SearchAll.Size = New System.Drawing.Size(598, 20)
        Me.SearchAll.TabIndex = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Search:"
        '
        'CustomPanel1
        '
        Me.CustomPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CustomPanel1.BackColor2 = System.Drawing.SystemColors.Control
        Me.CustomPanel1.Location = New System.Drawing.Point(722, 274)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Size = New System.Drawing.Size(66, 107)
        Me.CustomPanel1.TabIndex = 12
        '
        'Footer1
        '
        Me.Footer1.AlertIconVisible = False
        Me.Footer1.AlertType = NarsilWorks.DevLibWinForms.Footer.AlertTypeStatusConstants.Info
        Me.Footer1.AutoSize = True
        Me.Footer1.DatabaseName = ""
        Me.Footer1.DatabaseUser = ""
        Me.Footer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Footer1.Location = New System.Drawing.Point(0, 425)
        Me.Footer1.LoggedOnUser = ""
        Me.Footer1.Name = "Footer1"
        Me.Footer1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks
        Me.Footer1.ProgressBarVisible = False
        Me.Footer1.ProgressValue = 0
        Me.Footer1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.Footer1.ServerName = ""
        Me.Footer1.Size = New System.Drawing.Size(800, 25)
        Me.Footer1.Status = ""
        Me.Footer1.TabIndex = 13
        '
        'RefreshLinkLabel
        '
        Me.RefreshLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshLinkLabel.AutoSize = True
        Me.RefreshLinkLabel.Location = New System.Drawing.Point(672, 16)
        Me.RefreshLinkLabel.Name = "RefreshLinkLabel"
        Me.RefreshLinkLabel.Size = New System.Drawing.Size(44, 13)
        Me.RefreshLinkLabel.TabIndex = 14
        Me.RefreshLinkLabel.TabStop = True
        Me.RefreshLinkLabel.Text = "Refresh"
        '
        'PanelBox
        '
        Me.PanelBox.Controls.Add(Me.Label6)
        Me.PanelBox.Controls.Add(Me.Label5)
        Me.PanelBox.Controls.Add(Me.Label4)
        Me.PanelBox.Controls.Add(Me.Label3)
        Me.PanelBox.Controls.Add(Me.EmailTextBox)
        Me.PanelBox.Controls.Add(Me.LastNameTextBox)
        Me.PanelBox.Controls.Add(Me.FirstNameTextBox)
        Me.PanelBox.Controls.Add(Me.UserNameTextBox)
        Me.PanelBox.Location = New System.Drawing.Point(12, 71)
        Me.PanelBox.Name = "PanelBox"
        Me.PanelBox.Size = New System.Drawing.Size(704, 347)
        Me.PanelBox.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(266, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(243, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "LastName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(243, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "FirstName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(241, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "UserName"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(302, 175)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(167, 20)
        Me.EmailTextBox.TabIndex = 4
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(302, 147)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(167, 20)
        Me.LastNameTextBox.TabIndex = 3
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(302, 121)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(167, 20)
        Me.FirstNameTextBox.TabIndex = 2
        '
        'UserNameTextBox
        '
        Me.UserNameTextBox.Location = New System.Drawing.Point(302, 93)
        Me.UserNameTextBox.Name = "UserNameTextBox"
        Me.UserNameTextBox.Size = New System.Drawing.Size(167, 20)
        Me.UserNameTextBox.TabIndex = 1
        '
        'EmployeeKey
        '
        Me.EmployeeKey.DataPropertyName = "EmployeeKey"
        Me.EmployeeKey.HeaderText = "EmployeeKey"
        Me.EmployeeKey.Name = "EmployeeKey"
        Me.EmployeeKey.ReadOnly = True
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "UserName"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'FirstName
        '
        Me.FirstName.DataPropertyName = "FirstName"
        Me.FirstName.HeaderText = "FirstName"
        Me.FirstName.Name = "FirstName"
        Me.FirstName.ReadOnly = True
        '
        'LastName
        '
        Me.LastName.DataPropertyName = "LastName"
        Me.LastName.HeaderText = "LastName"
        Me.LastName.Name = "LastName"
        Me.LastName.ReadOnly = True
        '
        'Email
        '
        Me.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelBox)
        Me.Controls.Add(Me.RefreshLinkLabel)
        Me.Controls.Add(Me.Footer1)
        Me.Controls.Add(Me.CustomPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchAll)
        Me.Controls.Add(Me.DataGridViewFilter1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.ImportButton)
        Me.Controls.Add(Me.ExportButton)
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBox.ResumeLayout(False)
        Me.PanelBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExportButton As Windows.Forms.Button
    Friend WithEvents ImportButton As Windows.Forms.Button
    Friend WithEvents AddButton As Windows.Forms.Button
    Friend WithEvents EditButton As Windows.Forms.Button
    Friend WithEvents SaveButton As Windows.Forms.Button
    Friend WithEvents CancelButton As Windows.Forms.Button
    Friend WithEvents DeleteButton As Windows.Forms.Button
    Friend WithEvents CloseButton As Windows.Forms.Button
    Friend WithEvents DataGridView1 As NarsilWorks.DevLibWinForms.DataGridView
    Friend WithEvents SearchAll As Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As Windows.Forms.Label
    Public WithEvents DataGridViewFilter1 As NarsilWorks.DevLibWinForms.DataGridViewFilter
    Friend WithEvents CustomPanel1 As NarsilWorks.DevLibWinForms.CustomPanel
    Friend WithEvents Footer1 As NarsilWorks.DevLibWinForms.Footer
    Friend WithEvents RefreshLinkLabel As NarsilWorks.DevLibWinForms.LinkLabel
    Friend WithEvents PanelBox As Windows.Forms.Panel
    Friend WithEvents EmailTextBox As Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As Windows.Forms.TextBox
    Friend WithEvents UserNameTextBox As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents EmployeeKey As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As Windows.Forms.DataGridViewTextBoxColumn
End Class
