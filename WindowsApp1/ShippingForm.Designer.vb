﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShippingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShippingForm))
        Me.FooterShipping = New NarsilWorks.DevLibWinForms.Footer()
        Me.RefreshLinkLabel = New NarsilWorks.DevLibWinForms.LinkLabel()
        Me.CustomPanel1 = New NarsilWorks.DevLibWinForms.CustomPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchAll = New System.Windows.Forms.TextBox()
        Me.DataGridViewFilter1 = New NarsilWorks.DevLibWinForms.DataGridViewFilter()
        Me.DataGridView1 = New NarsilWorks.DevLibWinForms.DataGridView()
        Me.DoorKey = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoorID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoorName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.ImportButton = New System.Windows.Forms.Button()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.PanelBox = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.DoorNameTextBox = New System.Windows.Forms.TextBox()
        Me.DoorIDTextBox = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FooterShipping
        '
        Me.FooterShipping.AlertIconVisible = False
        Me.FooterShipping.AlertType = NarsilWorks.DevLibWinForms.Footer.AlertTypeStatusConstants.Info
        Me.FooterShipping.AutoSize = True
        Me.FooterShipping.DatabaseName = ""
        Me.FooterShipping.DatabaseUser = ""
        Me.FooterShipping.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FooterShipping.Location = New System.Drawing.Point(0, 425)
        Me.FooterShipping.LoggedOnUser = ""
        Me.FooterShipping.Name = "FooterShipping"
        Me.FooterShipping.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks
        Me.FooterShipping.ProgressBarVisible = False
        Me.FooterShipping.ProgressValue = 0
        Me.FooterShipping.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.FooterShipping.ServerName = ""
        Me.FooterShipping.Size = New System.Drawing.Size(800, 25)
        Me.FooterShipping.Status = ""
        Me.FooterShipping.TabIndex = 28
        '
        'RefreshLinkLabel
        '
        Me.RefreshLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RefreshLinkLabel.AutoSize = True
        Me.RefreshLinkLabel.Location = New System.Drawing.Point(672, 16)
        Me.RefreshLinkLabel.Name = "RefreshLinkLabel"
        Me.RefreshLinkLabel.Size = New System.Drawing.Size(44, 13)
        Me.RefreshLinkLabel.TabIndex = 42
        Me.RefreshLinkLabel.TabStop = True
        Me.RefreshLinkLabel.Text = "Refresh"
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
        Me.CustomPanel1.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Search:"
        '
        'SearchAll
        '
        Me.SearchAll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SearchAll.Location = New System.Drawing.Point(68, 13)
        Me.SearchAll.Name = "SearchAll"
        Me.SearchAll.Size = New System.Drawing.Size(598, 20)
        Me.SearchAll.TabIndex = 39
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
        Me.DataGridViewFilter1.TabIndex = 38
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DoorKey, Me.DoorID, Me.DoorName, Me.Description})
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
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(704, 347)
        Me.DataGridView1.TabIndex = 37
        '
        'DoorKey
        '
        Me.DoorKey.DataPropertyName = "DoorKey"
        Me.DoorKey.HeaderText = "DoorKey"
        Me.DoorKey.Name = "DoorKey"
        '
        'DoorID
        '
        Me.DoorID.DataPropertyName = "DoorID"
        Me.DoorID.HeaderText = "DoorID"
        Me.DoorID.Name = "DoorID"
        '
        'DoorName
        '
        Me.DoorName.DataPropertyName = "DoorName"
        Me.DoorName.HeaderText = "DoorName"
        Me.DoorName.Name = "DoorName"
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Description.DataPropertyName = "Description"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
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
        Me.CloseButton.TabIndex = 36
        Me.CloseButton.Text = "Close"
        Me.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DeleteButton.Location = New System.Drawing.Point(722, 237)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(66, 31)
        Me.DeleteButton.TabIndex = 35
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Image = CType(resources.GetObject("SaveButton.Image"), System.Drawing.Image)
        Me.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveButton.Location = New System.Drawing.Point(722, 162)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(66, 32)
        Me.SaveButton.TabIndex = 34
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
        Me.CancelButton.TabIndex = 33
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddButton.Image = CType(resources.GetObject("AddButton.Image"), System.Drawing.Image)
        Me.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddButton.Location = New System.Drawing.Point(722, 87)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(66, 32)
        Me.AddButton.TabIndex = 32
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
        Me.EditButton.TabIndex = 31
        Me.EditButton.Text = "Edit"
        Me.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'ImportButton
        '
        Me.ImportButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImportButton.Image = CType(resources.GetObject("ImportButton.Image"), System.Drawing.Image)
        Me.ImportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ImportButton.Location = New System.Drawing.Point(722, 12)
        Me.ImportButton.Name = "ImportButton"
        Me.ImportButton.Size = New System.Drawing.Size(66, 32)
        Me.ImportButton.TabIndex = 30
        Me.ImportButton.Text = "Import"
        Me.ImportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ImportButton.UseVisualStyleBackColor = True
        '
        'ExportButton
        '
        Me.ExportButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExportButton.Image = CType(resources.GetObject("ExportButton.Image"), System.Drawing.Image)
        Me.ExportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExportButton.Location = New System.Drawing.Point(722, 50)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(66, 31)
        Me.ExportButton.TabIndex = 29
        Me.ExportButton.Text = "Export"
        Me.ExportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'PanelBox
        '
        Me.PanelBox.Controls.Add(Me.Label5)
        Me.PanelBox.Controls.Add(Me.Label4)
        Me.PanelBox.Controls.Add(Me.Label3)
        Me.PanelBox.Controls.Add(Me.DescriptionTextBox)
        Me.PanelBox.Controls.Add(Me.DoorNameTextBox)
        Me.PanelBox.Controls.Add(Me.DoorIDTextBox)
        Me.PanelBox.Location = New System.Drawing.Point(12, 71)
        Me.PanelBox.Name = "PanelBox"
        Me.PanelBox.Size = New System.Drawing.Size(704, 347)
        Me.PanelBox.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(236, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(238, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "DoorName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(255, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "DoorID"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(302, 147)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(167, 20)
        Me.DescriptionTextBox.TabIndex = 3
        '
        'DoorNameTextBox
        '
        Me.DoorNameTextBox.Location = New System.Drawing.Point(302, 121)
        Me.DoorNameTextBox.Name = "DoorNameTextBox"
        Me.DoorNameTextBox.Size = New System.Drawing.Size(167, 20)
        Me.DoorNameTextBox.TabIndex = 2
        '
        'DoorIDTextBox
        '
        Me.DoorIDTextBox.Location = New System.Drawing.Point(302, 93)
        Me.DoorIDTextBox.Name = "DoorIDTextBox"
        Me.DoorIDTextBox.Size = New System.Drawing.Size(167, 20)
        Me.DoorIDTextBox.TabIndex = 1
        '
        'ShippingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelBox)
        Me.Controls.Add(Me.RefreshLinkLabel)
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
        Me.Controls.Add(Me.FooterShipping)
        Me.Name = "ShippingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShippingForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBox.ResumeLayout(False)
        Me.PanelBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FooterShipping As NarsilWorks.DevLibWinForms.Footer
    Friend WithEvents RefreshLinkLabel As NarsilWorks.DevLibWinForms.LinkLabel
    Friend WithEvents CustomPanel1 As NarsilWorks.DevLibWinForms.CustomPanel
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents SearchAll As Windows.Forms.TextBox
    Public WithEvents DataGridViewFilter1 As NarsilWorks.DevLibWinForms.DataGridViewFilter
    Friend WithEvents DataGridView1 As NarsilWorks.DevLibWinForms.DataGridView
    Friend WithEvents CloseButton As Windows.Forms.Button
    Friend WithEvents DeleteButton As Windows.Forms.Button
    Friend WithEvents SaveButton As Windows.Forms.Button
    Friend WithEvents CancelButton As Windows.Forms.Button
    Friend WithEvents AddButton As Windows.Forms.Button
    Friend WithEvents EditButton As Windows.Forms.Button
    Friend WithEvents ImportButton As Windows.Forms.Button
    Friend WithEvents ExportButton As Windows.Forms.Button
    Friend WithEvents DoorKey As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoorID As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoorName As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PanelBox As Windows.Forms.Panel
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents DescriptionTextBox As Windows.Forms.TextBox
    Friend WithEvents DoorNameTextBox As Windows.Forms.TextBox
    Friend WithEvents DoorIDTextBox As Windows.Forms.TextBox
End Class
