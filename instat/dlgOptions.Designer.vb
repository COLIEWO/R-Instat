﻿' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgOptions
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Languages")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Comments")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Output Window")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Commands")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Data View")
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.spltControls = New System.Windows.Forms.SplitContainer()
        Me.cmdFactoryReset = New System.Windows.Forms.Button()
        Me.trOptions = New System.Windows.Forms.TreeView()
        Me.tbcOptions = New System.Windows.Forms.TabControl()
        Me.tbpLanguages = New System.Windows.Forms.TabPage()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.ucrInputLanguage = New instat.ucrInputComboBox()
        Me.tbpComments = New System.Windows.Forms.TabPage()
        Me.pnComments = New System.Windows.Forms.Panel()
        Me.ucrInputComment = New instat.ucrInputTextBox()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.tbpImport = New System.Windows.Forms.TabPage()
        Me.lblPreviewRows = New System.Windows.Forms.Label()
        Me.ucrNudPreviewRows = New instat.ucrNud()
        Me.pnImportData = New System.Windows.Forms.Panel()
        Me.tbpOutputWindow = New System.Windows.Forms.TabPage()
        Me.ucrNudMaximumOutputsHeight = New instat.ucrNud()
        Me.ucrChkMaximumOutputsHeight = New instat.ucrCheck()
        Me.ucrChkShowRCommandsinOutputWindow = New instat.ucrCheck()
        Me.ucrChkIncludeCommentsbyDefault = New instat.ucrCheck()
        Me.grpROptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkShowSignifStars = New instat.ucrCheck()
        Me.ucrNudDigits = New instat.ucrNud()
        Me.lblNoDigits = New System.Windows.Forms.Label()
        Me.pnFormatOptions = New System.Windows.Forms.Panel()
        Me.rtbCommentPreview = New System.Windows.Forms.RichTextBox()
        Me.rtbOutputPreview = New System.Windows.Forms.RichTextBox()
        Me.rtbCommandPreview = New System.Windows.Forms.RichTextBox()
        Me.cmdCommandFormat = New System.Windows.Forms.Button()
        Me.lblCommentFormat = New System.Windows.Forms.Label()
        Me.cmdOutputFormat = New System.Windows.Forms.Button()
        Me.lblOutputFormat = New System.Windows.Forms.Label()
        Me.cmdCommentFormat = New System.Windows.Forms.Button()
        Me.lblCommandFormat = New System.Windows.Forms.Label()
        Me.tbpEditor = New System.Windows.Forms.TabPage()
        Me.pnFormatEditor = New System.Windows.Forms.Panel()
        Me.cmdEditorFont = New System.Windows.Forms.Button()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.tbpCommands = New System.Windows.Forms.TabPage()
        Me.lblWaitSeconds = New System.Windows.Forms.Label()
        Me.ucrChkShowWaitDialog = New instat.ucrCheck()
        Me.ucrNudWaitSeconds = New instat.ucrNud()
        Me.ucrChkIncludeDefaultParams = New instat.ucrCheck()
        Me.tbpDataView = New System.Windows.Forms.TabPage()
        Me.lblEvery = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.ucrChkAutoSave = New instat.ucrCheck()
        Me.ucrChkShowDataonGrid = New instat.ucrCheck()
        Me.ucrNudAutoSaveMinutes = New instat.ucrNud()
        Me.ucrNudMaxCols = New instat.ucrNud()
        Me.lblMaxCols = New System.Windows.Forms.Label()
        Me.ucrNudMaxRows = New instat.ucrNud()
        Me.lblMaxRows = New System.Windows.Forms.Label()
        Me.tbpWorkingDirectory = New System.Windows.Forms.TabPage()
        Me.cmdWorkingDirectory = New System.Windows.Forms.Button()
        Me.lblWorkingDirectory = New System.Windows.Forms.Label()
        Me.ucrWorkingDirectory = New instat.ucrInputTextBox()
        Me.tbpGraphDisplay = New System.Windows.Forms.TabPage()
        Me.rdoDisplayinSeparateWindows = New System.Windows.Forms.RadioButton()
        Me.rdoDisplayinRViewer = New System.Windows.Forms.RadioButton()
        Me.rdoDisplayinOutputWindow = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGraphDisplay = New instat.UcrPanel()
        Me.tbpTailoredMenus = New System.Windows.Forms.TabPage()
        Me.ucrChkViewStructuredMenu = New instat.ucrCheck()
        Me.ucrChkViewOptionsByContextMenu = New instat.ucrCheck()
        Me.ucrChkViewProcurementMenu = New instat.ucrCheck()
        Me.ucrChkViewClimaticMenu = New instat.ucrCheck()
        Me.tbpClimsoft = New System.Windows.Forms.TabPage()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblDatabaseName = New System.Windows.Forms.Label()
        Me.ucrInputUserName = New instat.ucrInputTextBox()
        Me.ucrInputPort = New instat.ucrInputTextBox()
        Me.ucrInputHost = New instat.ucrInputTextBox()
        Me.ucrInputDatabaseName = New instat.ucrInputTextBox()
        Me.cmdLanguage = New System.Windows.Forms.Button()
        Me.lversion = New System.Windows.Forms.Label()
        CType(Me.spltControls, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spltControls.Panel1.SuspendLayout()
        Me.spltControls.Panel2.SuspendLayout()
        Me.spltControls.SuspendLayout()
        Me.tbcOptions.SuspendLayout()
        Me.tbpLanguages.SuspendLayout()
        Me.tbpComments.SuspendLayout()
        Me.pnComments.SuspendLayout()
        Me.tbpImport.SuspendLayout()
        Me.tbpOutputWindow.SuspendLayout()
        Me.grpROptions.SuspendLayout()
        Me.pnFormatOptions.SuspendLayout()
        Me.tbpEditor.SuspendLayout()
        Me.pnFormatEditor.SuspendLayout()
        Me.tbpCommands.SuspendLayout()
        Me.tbpDataView.SuspendLayout()
        Me.tbpWorkingDirectory.SuspendLayout()
        Me.tbpGraphDisplay.SuspendLayout()
        Me.tbpTailoredMenus.SuspendLayout()
        Me.tbpClimsoft.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(480, 405)
        Me.cmdApply.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(94, 29)
        Me.cmdApply.TabIndex = 10
        Me.cmdApply.Tag = "Apply"
        Me.cmdApply.Text = "Apply"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(581, 405)
        Me.cmdHelp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(94, 29)
        Me.cmdHelp.TabIndex = 12
        Me.cmdHelp.Tag = "Help"
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(379, 405)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(94, 29)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Tag = "Cancel"
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(278, 405)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(94, 29)
        Me.cmdOk.TabIndex = 11
        Me.cmdOk.Tag = "Ok"
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'spltControls
        '
        Me.spltControls.Location = New System.Drawing.Point(6, 1)
        Me.spltControls.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.spltControls.Name = "spltControls"
        '
        'spltControls.Panel1
        '
        Me.spltControls.Panel1.Controls.Add(Me.cmdFactoryReset)
        Me.spltControls.Panel1.Controls.Add(Me.trOptions)
        '
        'spltControls.Panel2
        '
        Me.spltControls.Panel2.Controls.Add(Me.tbcOptions)
        Me.spltControls.Size = New System.Drawing.Size(950, 396)
        Me.spltControls.SplitterDistance = 230
        Me.spltControls.SplitterWidth = 5
        Me.spltControls.TabIndex = 8
        '
        'cmdFactoryReset
        '
        Me.cmdFactoryReset.Location = New System.Drawing.Point(16, 359)
        Me.cmdFactoryReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdFactoryReset.Name = "cmdFactoryReset"
        Me.cmdFactoryReset.Size = New System.Drawing.Size(125, 29)
        Me.cmdFactoryReset.TabIndex = 13
        Me.cmdFactoryReset.Tag = "Help"
        Me.cmdFactoryReset.Text = "Factory Reset"
        Me.cmdFactoryReset.UseVisualStyleBackColor = True
        '
        'trOptions
        '
        Me.trOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trOptions.Location = New System.Drawing.Point(0, 0)
        Me.trOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.trOptions.Name = "trOptions"
        TreeNode1.Name = "ndLanguages"
        TreeNode1.Tag = "1"
        TreeNode1.Text = "Languages"
        TreeNode1.ToolTipText = "Choose different languages"
        TreeNode2.Name = "ndComments"
        TreeNode2.Tag = "2"
        TreeNode2.Text = "Comments"
        TreeNode2.ToolTipText = "Comments for the dialogs"
        TreeNode3.Name = "ndImport"
        TreeNode3.Tag = "3"
        TreeNode3.Text = "Import"
        TreeNode3.ToolTipText = "Import Data Settings"
        TreeNode4.Name = "ndOutputWindow"
        TreeNode4.Tag = "4"
        TreeNode4.Text = "Output Window"
        TreeNode4.ToolTipText = "Output Window Formatting Options"
        TreeNode5.Name = "ndCommands"
        TreeNode5.Tag = "8"
        TreeNode5.Text = "Commands"
        TreeNode5.ToolTipText = "Commands Options"
        TreeNode6.Name = "ndDataView"
        TreeNode6.Text = "Data View"
        Me.trOptions.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5, TreeNode6})
        Me.trOptions.Size = New System.Drawing.Size(230, 396)
        Me.trOptions.TabIndex = 0
        '
        'tbcOptions
        '
        Me.tbcOptions.Controls.Add(Me.tbpLanguages)
        Me.tbcOptions.Controls.Add(Me.tbpComments)
        Me.tbcOptions.Controls.Add(Me.tbpImport)
        Me.tbcOptions.Controls.Add(Me.tbpOutputWindow)
        Me.tbcOptions.Controls.Add(Me.tbpEditor)
        Me.tbcOptions.Controls.Add(Me.tbpCommands)
        Me.tbcOptions.Controls.Add(Me.tbpDataView)
        Me.tbcOptions.Controls.Add(Me.tbpWorkingDirectory)
        Me.tbcOptions.Controls.Add(Me.tbpGraphDisplay)
        Me.tbcOptions.Controls.Add(Me.tbpTailoredMenus)
        Me.tbcOptions.Controls.Add(Me.tbpClimsoft)
        Me.tbcOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcOptions.Location = New System.Drawing.Point(0, 0)
        Me.tbcOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbcOptions.Name = "tbcOptions"
        Me.tbcOptions.SelectedIndex = 0
        Me.tbcOptions.Size = New System.Drawing.Size(715, 396)
        Me.tbcOptions.TabIndex = 0
        '
        'tbpLanguages
        '
        Me.tbpLanguages.Controls.Add(Me.lversion)
        Me.tbpLanguages.Controls.Add(Me.lblLanguage)
        Me.tbpLanguages.Controls.Add(Me.ucrInputLanguage)
        Me.tbpLanguages.Location = New System.Drawing.Point(4, 25)
        Me.tbpLanguages.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpLanguages.Name = "tbpLanguages"
        Me.tbpLanguages.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpLanguages.Size = New System.Drawing.Size(707, 367)
        Me.tbpLanguages.TabIndex = 0
        Me.tbpLanguages.Tag = "Languages"
        Me.tbpLanguages.Text = "Languages"
        Me.tbpLanguages.UseVisualStyleBackColor = True
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(11, 22)
        Me.lblLanguage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(80, 17)
        Me.lblLanguage.TabIndex = 3
        Me.lblLanguage.Text = "Language :"
        '
        'ucrInputLanguage
        '
        Me.ucrInputLanguage.AddQuotesIfUnrecognised = True
        Me.ucrInputLanguage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLanguage.GetSetSelectedIndex = -1
        Me.ucrInputLanguage.IsReadOnly = False
        Me.ucrInputLanguage.Location = New System.Drawing.Point(94, 19)
        Me.ucrInputLanguage.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrInputLanguage.Name = "ucrInputLanguage"
        Me.ucrInputLanguage.Size = New System.Drawing.Size(138, 26)
        Me.ucrInputLanguage.TabIndex = 2
        '
        'tbpComments
        '
        Me.tbpComments.Controls.Add(Me.pnComments)
        Me.tbpComments.Location = New System.Drawing.Point(4, 25)
        Me.tbpComments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpComments.Name = "tbpComments"
        Me.tbpComments.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpComments.Size = New System.Drawing.Size(707, 367)
        Me.tbpComments.TabIndex = 1
        Me.tbpComments.Tag = "Comments"
        Me.tbpComments.Text = "Comments"
        Me.tbpComments.UseVisualStyleBackColor = True
        '
        'pnComments
        '
        Me.pnComments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnComments.Controls.Add(Me.ucrInputComment)
        Me.pnComments.Controls.Add(Me.lblComment)
        Me.pnComments.Location = New System.Drawing.Point(12, 12)
        Me.pnComments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnComments.Name = "pnComments"
        Me.pnComments.Size = New System.Drawing.Size(489, 36)
        Me.pnComments.TabIndex = 2
        '
        'ucrInputComment
        '
        Me.ucrInputComment.AddQuotesIfUnrecognised = True
        Me.ucrInputComment.AutoSize = True
        Me.ucrInputComment.IsMultiline = False
        Me.ucrInputComment.IsReadOnly = False
        Me.ucrInputComment.Location = New System.Drawing.Point(120, 6)
        Me.ucrInputComment.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrInputComment.Name = "ucrInputComment"
        Me.ucrInputComment.Size = New System.Drawing.Size(365, 26)
        Me.ucrInputComment.TabIndex = 1
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(2, 11)
        Me.lblComment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(71, 17)
        Me.lblComment.TabIndex = 0
        Me.lblComment.Tag = "Comment:"
        Me.lblComment.Text = "Comment:"
        '
        'tbpImport
        '
        Me.tbpImport.Controls.Add(Me.lblPreviewRows)
        Me.tbpImport.Controls.Add(Me.ucrNudPreviewRows)
        Me.tbpImport.Controls.Add(Me.pnImportData)
        Me.tbpImport.Location = New System.Drawing.Point(4, 25)
        Me.tbpImport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpImport.Name = "tbpImport"
        Me.tbpImport.Size = New System.Drawing.Size(707, 367)
        Me.tbpImport.TabIndex = 3
        Me.tbpImport.Text = "Import"
        Me.tbpImport.UseVisualStyleBackColor = True
        '
        'lblPreviewRows
        '
        Me.lblPreviewRows.AutoSize = True
        Me.lblPreviewRows.Location = New System.Drawing.Point(4, 11)
        Me.lblPreviewRows.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPreviewRows.Name = "lblPreviewRows"
        Me.lblPreviewRows.Size = New System.Drawing.Size(169, 17)
        Me.lblPreviewRows.TabIndex = 0
        Me.lblPreviewRows.Text = "Number of Preview Rows:"
        '
        'ucrNudPreviewRows
        '
        Me.ucrNudPreviewRows.AutoSize = True
        Me.ucrNudPreviewRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPreviewRows.Location = New System.Drawing.Point(190, 6)
        Me.ucrNudPreviewRows.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudPreviewRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPreviewRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewRows.Name = "ucrNudPreviewRows"
        Me.ucrNudPreviewRows.Size = New System.Drawing.Size(62, 25)
        Me.ucrNudPreviewRows.TabIndex = 3
        Me.ucrNudPreviewRows.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'pnImportData
        '
        Me.pnImportData.AutoSize = True
        Me.pnImportData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnImportData.Location = New System.Drawing.Point(12, 12)
        Me.pnImportData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnImportData.Name = "pnImportData"
        Me.pnImportData.Size = New System.Drawing.Size(0, 0)
        Me.pnImportData.TabIndex = 2
        '
        'tbpOutputWindow
        '
        Me.tbpOutputWindow.Controls.Add(Me.ucrNudMaximumOutputsHeight)
        Me.tbpOutputWindow.Controls.Add(Me.ucrChkMaximumOutputsHeight)
        Me.tbpOutputWindow.Controls.Add(Me.ucrChkShowRCommandsinOutputWindow)
        Me.tbpOutputWindow.Controls.Add(Me.ucrChkIncludeCommentsbyDefault)
        Me.tbpOutputWindow.Controls.Add(Me.grpROptions)
        Me.tbpOutputWindow.Controls.Add(Me.pnFormatOptions)
        Me.tbpOutputWindow.Location = New System.Drawing.Point(4, 25)
        Me.tbpOutputWindow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpOutputWindow.Name = "tbpOutputWindow"
        Me.tbpOutputWindow.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpOutputWindow.Size = New System.Drawing.Size(707, 367)
        Me.tbpOutputWindow.TabIndex = 2
        Me.tbpOutputWindow.Text = "Output Window"
        Me.tbpOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrNudMaximumOutputsHeight
        '
        Me.ucrNudMaximumOutputsHeight.AutoSize = True
        Me.ucrNudMaximumOutputsHeight.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumOutputsHeight.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaximumOutputsHeight.Location = New System.Drawing.Point(598, 169)
        Me.ucrNudMaximumOutputsHeight.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudMaximumOutputsHeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaximumOutputsHeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumOutputsHeight.Name = "ucrNudMaximumOutputsHeight"
        Me.ucrNudMaximumOutputsHeight.Size = New System.Drawing.Size(62, 25)
        Me.ucrNudMaximumOutputsHeight.TabIndex = 29
        Me.ucrNudMaximumOutputsHeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMaximumOutputsHeight
        '
        Me.ucrChkMaximumOutputsHeight.AutoSize = True
        Me.ucrChkMaximumOutputsHeight.Checked = False
        Me.ucrChkMaximumOutputsHeight.Location = New System.Drawing.Point(388, 169)
        Me.ucrChkMaximumOutputsHeight.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkMaximumOutputsHeight.Name = "ucrChkMaximumOutputsHeight"
        Me.ucrChkMaximumOutputsHeight.Size = New System.Drawing.Size(202, 36)
        Me.ucrChkMaximumOutputsHeight.TabIndex = 28
        '
        'ucrChkShowRCommandsinOutputWindow
        '
        Me.ucrChkShowRCommandsinOutputWindow.AutoSize = True
        Me.ucrChkShowRCommandsinOutputWindow.Checked = False
        Me.ucrChkShowRCommandsinOutputWindow.Location = New System.Drawing.Point(12, 198)
        Me.ucrChkShowRCommandsinOutputWindow.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkShowRCommandsinOutputWindow.Name = "ucrChkShowRCommandsinOutputWindow"
        Me.ucrChkShowRCommandsinOutputWindow.Size = New System.Drawing.Size(339, 36)
        Me.ucrChkShowRCommandsinOutputWindow.TabIndex = 27
        '
        'ucrChkIncludeCommentsbyDefault
        '
        Me.ucrChkIncludeCommentsbyDefault.AutoSize = True
        Me.ucrChkIncludeCommentsbyDefault.Checked = False
        Me.ucrChkIncludeCommentsbyDefault.Location = New System.Drawing.Point(12, 169)
        Me.ucrChkIncludeCommentsbyDefault.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkIncludeCommentsbyDefault.Name = "ucrChkIncludeCommentsbyDefault"
        Me.ucrChkIncludeCommentsbyDefault.Size = New System.Drawing.Size(339, 36)
        Me.ucrChkIncludeCommentsbyDefault.TabIndex = 26
        '
        'grpROptions
        '
        Me.grpROptions.Controls.Add(Me.ucrChkShowSignifStars)
        Me.grpROptions.Controls.Add(Me.ucrNudDigits)
        Me.grpROptions.Controls.Add(Me.lblNoDigits)
        Me.grpROptions.Location = New System.Drawing.Point(12, 240)
        Me.grpROptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpROptions.Name = "grpROptions"
        Me.grpROptions.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpROptions.Size = New System.Drawing.Size(339, 116)
        Me.grpROptions.TabIndex = 25
        Me.grpROptions.TabStop = False
        Me.grpROptions.Text = "R Options"
        '
        'ucrChkShowSignifStars
        '
        Me.ucrChkShowSignifStars.AutoSize = True
        Me.ucrChkShowSignifStars.Checked = False
        Me.ucrChkShowSignifStars.Location = New System.Drawing.Point(9, 61)
        Me.ucrChkShowSignifStars.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkShowSignifStars.Name = "ucrChkShowSignifStars"
        Me.ucrChkShowSignifStars.Size = New System.Drawing.Size(319, 36)
        Me.ucrChkShowSignifStars.TabIndex = 28
        '
        'ucrNudDigits
        '
        Me.ucrNudDigits.AutoSize = True
        Me.ucrNudDigits.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDigits.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDigits.Location = New System.Drawing.Point(221, 29)
        Me.ucrNudDigits.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudDigits.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDigits.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDigits.Name = "ucrNudDigits"
        Me.ucrNudDigits.Size = New System.Drawing.Size(62, 25)
        Me.ucrNudDigits.TabIndex = 27
        Me.ucrNudDigits.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNoDigits
        '
        Me.lblNoDigits.AutoSize = True
        Me.lblNoDigits.Location = New System.Drawing.Point(8, 29)
        Me.lblNoDigits.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoDigits.Name = "lblNoDigits"
        Me.lblNoDigits.Size = New System.Drawing.Size(183, 17)
        Me.lblNoDigits.TabIndex = 1
        Me.lblNoDigits.Text = "Number of Digits to Display:"
        '
        'pnFormatOptions
        '
        Me.pnFormatOptions.AutoSize = True
        Me.pnFormatOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnFormatOptions.Controls.Add(Me.rtbCommentPreview)
        Me.pnFormatOptions.Controls.Add(Me.rtbOutputPreview)
        Me.pnFormatOptions.Controls.Add(Me.rtbCommandPreview)
        Me.pnFormatOptions.Controls.Add(Me.cmdCommandFormat)
        Me.pnFormatOptions.Controls.Add(Me.lblCommentFormat)
        Me.pnFormatOptions.Controls.Add(Me.cmdOutputFormat)
        Me.pnFormatOptions.Controls.Add(Me.lblOutputFormat)
        Me.pnFormatOptions.Controls.Add(Me.cmdCommentFormat)
        Me.pnFormatOptions.Controls.Add(Me.lblCommandFormat)
        Me.pnFormatOptions.Location = New System.Drawing.Point(12, 12)
        Me.pnFormatOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnFormatOptions.Name = "pnFormatOptions"
        Me.pnFormatOptions.Size = New System.Drawing.Size(489, 147)
        Me.pnFormatOptions.TabIndex = 21
        '
        'rtbCommentPreview
        '
        Me.rtbCommentPreview.Location = New System.Drawing.Point(155, 111)
        Me.rtbCommentPreview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtbCommentPreview.Name = "rtbCommentPreview"
        Me.rtbCommentPreview.ReadOnly = True
        Me.rtbCommentPreview.Size = New System.Drawing.Size(183, 32)
        Me.rtbCommentPreview.TabIndex = 22
        Me.rtbCommentPreview.Text = ""
        '
        'rtbOutputPreview
        '
        Me.rtbOutputPreview.Location = New System.Drawing.Point(155, 61)
        Me.rtbOutputPreview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtbOutputPreview.Name = "rtbOutputPreview"
        Me.rtbOutputPreview.ReadOnly = True
        Me.rtbOutputPreview.Size = New System.Drawing.Size(183, 32)
        Me.rtbOutputPreview.TabIndex = 21
        Me.rtbOutputPreview.Text = ""
        '
        'rtbCommandPreview
        '
        Me.rtbCommandPreview.Location = New System.Drawing.Point(155, 11)
        Me.rtbCommandPreview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtbCommandPreview.Name = "rtbCommandPreview"
        Me.rtbCommandPreview.ReadOnly = True
        Me.rtbCommandPreview.Size = New System.Drawing.Size(183, 32)
        Me.rtbCommandPreview.TabIndex = 20
        Me.rtbCommandPreview.Text = ""
        '
        'cmdCommandFormat
        '
        Me.cmdCommandFormat.Location = New System.Drawing.Point(360, 11)
        Me.cmdCommandFormat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCommandFormat.Name = "cmdCommandFormat"
        Me.cmdCommandFormat.Size = New System.Drawing.Size(125, 29)
        Me.cmdCommandFormat.TabIndex = 10
        Me.cmdCommandFormat.Text = "Change..."
        Me.cmdCommandFormat.UseVisualStyleBackColor = True
        '
        'lblCommentFormat
        '
        Me.lblCommentFormat.AutoSize = True
        Me.lblCommentFormat.Location = New System.Drawing.Point(5, 118)
        Me.lblCommentFormat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCommentFormat.Name = "lblCommentFormat"
        Me.lblCommentFormat.Size = New System.Drawing.Size(119, 17)
        Me.lblCommentFormat.TabIndex = 19
        Me.lblCommentFormat.Text = "Comment Format:"
        '
        'cmdOutputFormat
        '
        Me.cmdOutputFormat.Location = New System.Drawing.Point(360, 61)
        Me.cmdOutputFormat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdOutputFormat.Name = "cmdOutputFormat"
        Me.cmdOutputFormat.Size = New System.Drawing.Size(125, 29)
        Me.cmdOutputFormat.TabIndex = 16
        Me.cmdOutputFormat.Text = "Change..."
        Me.cmdOutputFormat.UseVisualStyleBackColor = True
        '
        'lblOutputFormat
        '
        Me.lblOutputFormat.AutoSize = True
        Me.lblOutputFormat.Location = New System.Drawing.Point(5, 68)
        Me.lblOutputFormat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutputFormat.Name = "lblOutputFormat"
        Me.lblOutputFormat.Size = New System.Drawing.Size(103, 17)
        Me.lblOutputFormat.TabIndex = 18
        Me.lblOutputFormat.Text = "Output Format:"
        '
        'cmdCommentFormat
        '
        Me.cmdCommentFormat.Location = New System.Drawing.Point(360, 111)
        Me.cmdCommentFormat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCommentFormat.Name = "cmdCommentFormat"
        Me.cmdCommentFormat.Size = New System.Drawing.Size(125, 29)
        Me.cmdCommentFormat.TabIndex = 16
        Me.cmdCommentFormat.Text = "Change..."
        Me.cmdCommentFormat.UseVisualStyleBackColor = True
        '
        'lblCommandFormat
        '
        Me.lblCommandFormat.AutoSize = True
        Me.lblCommandFormat.Location = New System.Drawing.Point(5, 18)
        Me.lblCommandFormat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCommandFormat.Name = "lblCommandFormat"
        Me.lblCommandFormat.Size = New System.Drawing.Size(123, 17)
        Me.lblCommandFormat.TabIndex = 17
        Me.lblCommandFormat.Text = "Command Format:"
        '
        'tbpEditor
        '
        Me.tbpEditor.Controls.Add(Me.pnFormatEditor)
        Me.tbpEditor.Location = New System.Drawing.Point(4, 25)
        Me.tbpEditor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpEditor.Name = "tbpEditor"
        Me.tbpEditor.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpEditor.Size = New System.Drawing.Size(707, 367)
        Me.tbpEditor.TabIndex = 10
        Me.tbpEditor.Text = "Editor Window"
        Me.tbpEditor.ToolTipText = "Data View"
        Me.tbpEditor.UseVisualStyleBackColor = True
        '
        'pnFormatEditor
        '
        Me.pnFormatEditor.AutoSize = True
        Me.pnFormatEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnFormatEditor.Controls.Add(Me.cmdEditorFont)
        Me.pnFormatEditor.Controls.Add(Me.lblFont)
        Me.pnFormatEditor.Location = New System.Drawing.Point(12, 12)
        Me.pnFormatEditor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnFormatEditor.Name = "pnFormatEditor"
        Me.pnFormatEditor.Size = New System.Drawing.Size(265, 35)
        Me.pnFormatEditor.TabIndex = 22
        '
        'cmdEditorFont
        '
        Me.cmdEditorFont.Location = New System.Drawing.Point(136, 2)
        Me.cmdEditorFont.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdEditorFont.Name = "cmdEditorFont"
        Me.cmdEditorFont.Size = New System.Drawing.Size(125, 29)
        Me.cmdEditorFont.TabIndex = 10
        Me.cmdEditorFont.Text = "Change..."
        Me.cmdEditorFont.UseVisualStyleBackColor = True
        '
        'lblFont
        '
        Me.lblFont.AutoSize = True
        Me.lblFont.Location = New System.Drawing.Point(5, 9)
        Me.lblFont.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(88, 17)
        Me.lblFont.TabIndex = 17
        Me.lblFont.Text = "Format Font:"
        '
        'tbpCommands
        '
        Me.tbpCommands.Controls.Add(Me.lblWaitSeconds)
        Me.tbpCommands.Controls.Add(Me.ucrChkShowWaitDialog)
        Me.tbpCommands.Controls.Add(Me.ucrNudWaitSeconds)
        Me.tbpCommands.Controls.Add(Me.ucrChkIncludeDefaultParams)
        Me.tbpCommands.Location = New System.Drawing.Point(4, 25)
        Me.tbpCommands.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpCommands.Name = "tbpCommands"
        Me.tbpCommands.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpCommands.Size = New System.Drawing.Size(707, 367)
        Me.tbpCommands.TabIndex = 4
        Me.tbpCommands.Tag = "Commands"
        Me.tbpCommands.Text = "Commands"
        Me.tbpCommands.UseVisualStyleBackColor = True
        '
        'lblWaitSeconds
        '
        Me.lblWaitSeconds.AutoSize = True
        Me.lblWaitSeconds.Location = New System.Drawing.Point(504, 58)
        Me.lblWaitSeconds.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWaitSeconds.Name = "lblWaitSeconds"
        Me.lblWaitSeconds.Size = New System.Drawing.Size(61, 17)
        Me.lblWaitSeconds.TabIndex = 8
        Me.lblWaitSeconds.Text = "seconds"
        '
        'ucrChkShowWaitDialog
        '
        Me.ucrChkShowWaitDialog.AutoSize = True
        Me.ucrChkShowWaitDialog.Checked = False
        Me.ucrChkShowWaitDialog.Location = New System.Drawing.Point(8, 59)
        Me.ucrChkShowWaitDialog.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkShowWaitDialog.Name = "ucrChkShowWaitDialog"
        Me.ucrChkShowWaitDialog.Size = New System.Drawing.Size(421, 36)
        Me.ucrChkShowWaitDialog.TabIndex = 6
        '
        'ucrNudWaitSeconds
        '
        Me.ucrNudWaitSeconds.AutoSize = True
        Me.ucrNudWaitSeconds.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaitSeconds.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWaitSeconds.Location = New System.Drawing.Point(436, 56)
        Me.ucrNudWaitSeconds.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudWaitSeconds.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWaitSeconds.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWaitSeconds.Name = "ucrNudWaitSeconds"
        Me.ucrNudWaitSeconds.Size = New System.Drawing.Size(62, 25)
        Me.ucrNudWaitSeconds.TabIndex = 5
        Me.ucrNudWaitSeconds.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkIncludeDefaultParams
        '
        Me.ucrChkIncludeDefaultParams.AutoSize = True
        Me.ucrChkIncludeDefaultParams.Checked = False
        Me.ucrChkIncludeDefaultParams.Location = New System.Drawing.Point(8, 25)
        Me.ucrChkIncludeDefaultParams.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkIncludeDefaultParams.Name = "ucrChkIncludeDefaultParams"
        Me.ucrChkIncludeDefaultParams.Size = New System.Drawing.Size(498, 36)
        Me.ucrChkIncludeDefaultParams.TabIndex = 3
        '
        'tbpDataView
        '
        Me.tbpDataView.Controls.Add(Me.lblEvery)
        Me.tbpDataView.Controls.Add(Me.lblMinutes)
        Me.tbpDataView.Controls.Add(Me.ucrChkAutoSave)
        Me.tbpDataView.Controls.Add(Me.ucrChkShowDataonGrid)
        Me.tbpDataView.Controls.Add(Me.ucrNudAutoSaveMinutes)
        Me.tbpDataView.Controls.Add(Me.ucrNudMaxCols)
        Me.tbpDataView.Controls.Add(Me.lblMaxCols)
        Me.tbpDataView.Controls.Add(Me.ucrNudMaxRows)
        Me.tbpDataView.Controls.Add(Me.lblMaxRows)
        Me.tbpDataView.Location = New System.Drawing.Point(4, 25)
        Me.tbpDataView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpDataView.Name = "tbpDataView"
        Me.tbpDataView.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpDataView.Size = New System.Drawing.Size(707, 367)
        Me.tbpDataView.TabIndex = 9
        Me.tbpDataView.Text = "Data View"
        Me.tbpDataView.UseVisualStyleBackColor = True
        '
        'lblEvery
        '
        Me.lblEvery.AutoSize = True
        Me.lblEvery.Location = New System.Drawing.Point(295, 128)
        Me.lblEvery.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvery.Name = "lblEvery"
        Me.lblEvery.Size = New System.Drawing.Size(43, 17)
        Me.lblEvery.TabIndex = 4
        Me.lblEvery.Text = "every"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Location = New System.Drawing.Point(426, 128)
        Me.lblMinutes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(57, 17)
        Me.lblMinutes.TabIndex = 4
        Me.lblMinutes.Text = "minutes"
        '
        'ucrChkAutoSave
        '
        Me.ucrChkAutoSave.AutoSize = True
        Me.ucrChkAutoSave.Checked = False
        Me.ucrChkAutoSave.Location = New System.Drawing.Point(16, 130)
        Me.ucrChkAutoSave.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkAutoSave.Name = "ucrChkAutoSave"
        Me.ucrChkAutoSave.Size = New System.Drawing.Size(271, 36)
        Me.ucrChkAutoSave.TabIndex = 3
        '
        'ucrChkShowDataonGrid
        '
        Me.ucrChkShowDataonGrid.AutoSize = True
        Me.ucrChkShowDataonGrid.Checked = False
        Me.ucrChkShowDataonGrid.Location = New System.Drawing.Point(16, 98)
        Me.ucrChkShowDataonGrid.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkShowDataonGrid.Name = "ucrChkShowDataonGrid"
        Me.ucrChkShowDataonGrid.Size = New System.Drawing.Size(491, 36)
        Me.ucrChkShowDataonGrid.TabIndex = 3
        '
        'ucrNudAutoSaveMinutes
        '
        Me.ucrNudAutoSaveMinutes.AutoSize = True
        Me.ucrNudAutoSaveMinutes.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAutoSaveMinutes.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudAutoSaveMinutes.Location = New System.Drawing.Point(356, 124)
        Me.ucrNudAutoSaveMinutes.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudAutoSaveMinutes.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudAutoSaveMinutes.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudAutoSaveMinutes.Name = "ucrNudAutoSaveMinutes"
        Me.ucrNudAutoSaveMinutes.Size = New System.Drawing.Size(62, 25)
        Me.ucrNudAutoSaveMinutes.TabIndex = 2
        Me.ucrNudAutoSaveMinutes.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudMaxCols
        '
        Me.ucrNudMaxCols.AutoSize = True
        Me.ucrNudMaxCols.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxCols.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxCols.Location = New System.Drawing.Point(335, 51)
        Me.ucrNudMaxCols.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudMaxCols.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxCols.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxCols.Name = "ucrNudMaxCols"
        Me.ucrNudMaxCols.Size = New System.Drawing.Size(62, 25)
        Me.ucrNudMaxCols.TabIndex = 2
        Me.ucrNudMaxCols.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaxCols
        '
        Me.lblMaxCols.AutoSize = True
        Me.lblMaxCols.Location = New System.Drawing.Point(12, 55)
        Me.lblMaxCols.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxCols.Name = "lblMaxCols"
        Me.lblMaxCols.Size = New System.Drawing.Size(264, 17)
        Me.lblMaxCols.TabIndex = 1
        Me.lblMaxCols.Text = "Maximum Number of Columns to Display:"
        '
        'ucrNudMaxRows
        '
        Me.ucrNudMaxRows.AutoSize = True
        Me.ucrNudMaxRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxRows.Location = New System.Drawing.Point(335, 19)
        Me.ucrNudMaxRows.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudMaxRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRows.Name = "ucrNudMaxRows"
        Me.ucrNudMaxRows.Size = New System.Drawing.Size(62, 25)
        Me.ucrNudMaxRows.TabIndex = 2
        Me.ucrNudMaxRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaxRows
        '
        Me.lblMaxRows.AutoSize = True
        Me.lblMaxRows.Location = New System.Drawing.Point(12, 22)
        Me.lblMaxRows.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxRows.Name = "lblMaxRows"
        Me.lblMaxRows.Size = New System.Drawing.Size(244, 17)
        Me.lblMaxRows.TabIndex = 1
        Me.lblMaxRows.Text = "Maximum Number of Rows to Display:"
        '
        'tbpWorkingDirectory
        '
        Me.tbpWorkingDirectory.Controls.Add(Me.cmdWorkingDirectory)
        Me.tbpWorkingDirectory.Controls.Add(Me.lblWorkingDirectory)
        Me.tbpWorkingDirectory.Controls.Add(Me.ucrWorkingDirectory)
        Me.tbpWorkingDirectory.Location = New System.Drawing.Point(4, 25)
        Me.tbpWorkingDirectory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpWorkingDirectory.Name = "tbpWorkingDirectory"
        Me.tbpWorkingDirectory.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpWorkingDirectory.Size = New System.Drawing.Size(707, 367)
        Me.tbpWorkingDirectory.TabIndex = 11
        Me.tbpWorkingDirectory.Text = "Working Directory"
        Me.tbpWorkingDirectory.UseVisualStyleBackColor = True
        '
        'cmdWorkingDirectory
        '
        Me.cmdWorkingDirectory.Location = New System.Drawing.Point(499, 20)
        Me.cmdWorkingDirectory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdWorkingDirectory.Name = "cmdWorkingDirectory"
        Me.cmdWorkingDirectory.Size = New System.Drawing.Size(30, 26)
        Me.cmdWorkingDirectory.TabIndex = 2
        Me.cmdWorkingDirectory.Text = "..."
        Me.cmdWorkingDirectory.UseVisualStyleBackColor = True
        '
        'lblWorkingDirectory
        '
        Me.lblWorkingDirectory.AutoSize = True
        Me.lblWorkingDirectory.Location = New System.Drawing.Point(16, 25)
        Me.lblWorkingDirectory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWorkingDirectory.Name = "lblWorkingDirectory"
        Me.lblWorkingDirectory.Size = New System.Drawing.Size(125, 17)
        Me.lblWorkingDirectory.TabIndex = 0
        Me.lblWorkingDirectory.Text = "Working Directory:"
        '
        'ucrWorkingDirectory
        '
        Me.ucrWorkingDirectory.AddQuotesIfUnrecognised = True
        Me.ucrWorkingDirectory.AutoSize = True
        Me.ucrWorkingDirectory.IsMultiline = False
        Me.ucrWorkingDirectory.IsReadOnly = False
        Me.ucrWorkingDirectory.Location = New System.Drawing.Point(172, 21)
        Me.ucrWorkingDirectory.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrWorkingDirectory.Name = "ucrWorkingDirectory"
        Me.ucrWorkingDirectory.Size = New System.Drawing.Size(319, 26)
        Me.ucrWorkingDirectory.TabIndex = 1
        '
        'tbpGraphDisplay
        '
        Me.tbpGraphDisplay.Controls.Add(Me.rdoDisplayinSeparateWindows)
        Me.tbpGraphDisplay.Controls.Add(Me.rdoDisplayinRViewer)
        Me.tbpGraphDisplay.Controls.Add(Me.rdoDisplayinOutputWindow)
        Me.tbpGraphDisplay.Controls.Add(Me.ucrPnlGraphDisplay)
        Me.tbpGraphDisplay.Location = New System.Drawing.Point(4, 25)
        Me.tbpGraphDisplay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpGraphDisplay.Name = "tbpGraphDisplay"
        Me.tbpGraphDisplay.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpGraphDisplay.Size = New System.Drawing.Size(707, 367)
        Me.tbpGraphDisplay.TabIndex = 12
        Me.tbpGraphDisplay.Text = "Graph Display"
        Me.tbpGraphDisplay.UseVisualStyleBackColor = True
        '
        'rdoDisplayinSeparateWindows
        '
        Me.rdoDisplayinSeparateWindows.AutoSize = True
        Me.rdoDisplayinSeparateWindows.Checked = True
        Me.rdoDisplayinSeparateWindows.Location = New System.Drawing.Point(8, 65)
        Me.rdoDisplayinSeparateWindows.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoDisplayinSeparateWindows.Name = "rdoDisplayinSeparateWindows"
        Me.rdoDisplayinSeparateWindows.Size = New System.Drawing.Size(212, 21)
        Me.rdoDisplayinSeparateWindows.TabIndex = 1
        Me.rdoDisplayinSeparateWindows.TabStop = True
        Me.rdoDisplayinSeparateWindows.Text = "Display in Separate Windows"
        Me.rdoDisplayinSeparateWindows.UseVisualStyleBackColor = True
        '
        'rdoDisplayinRViewer
        '
        Me.rdoDisplayinRViewer.AutoSize = True
        Me.rdoDisplayinRViewer.Location = New System.Drawing.Point(8, 36)
        Me.rdoDisplayinRViewer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoDisplayinRViewer.Name = "rdoDisplayinRViewer"
        Me.rdoDisplayinRViewer.Size = New System.Drawing.Size(150, 21)
        Me.rdoDisplayinRViewer.TabIndex = 1
        Me.rdoDisplayinRViewer.Text = "Display in R Viewer"
        Me.rdoDisplayinRViewer.UseVisualStyleBackColor = True
        '
        'rdoDisplayinOutputWindow
        '
        Me.rdoDisplayinOutputWindow.AutoSize = True
        Me.rdoDisplayinOutputWindow.Location = New System.Drawing.Point(8, 8)
        Me.rdoDisplayinOutputWindow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoDisplayinOutputWindow.Name = "rdoDisplayinOutputWindow"
        Me.rdoDisplayinOutputWindow.Size = New System.Drawing.Size(190, 21)
        Me.rdoDisplayinOutputWindow.TabIndex = 1
        Me.rdoDisplayinOutputWindow.Text = "Display in Output Window"
        Me.rdoDisplayinOutputWindow.UseVisualStyleBackColor = True
        '
        'ucrPnlGraphDisplay
        '
        Me.ucrPnlGraphDisplay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGraphDisplay.Location = New System.Drawing.Point(0, 4)
        Me.ucrPnlGraphDisplay.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrPnlGraphDisplay.Name = "ucrPnlGraphDisplay"
        Me.ucrPnlGraphDisplay.Size = New System.Drawing.Size(456, 82)
        Me.ucrPnlGraphDisplay.TabIndex = 3
        '
        'tbpTailoredMenus
        '
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewStructuredMenu)
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewOptionsByContextMenu)
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewProcurementMenu)
        Me.tbpTailoredMenus.Controls.Add(Me.ucrChkViewClimaticMenu)
        Me.tbpTailoredMenus.Location = New System.Drawing.Point(4, 25)
        Me.tbpTailoredMenus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpTailoredMenus.Name = "tbpTailoredMenus"
        Me.tbpTailoredMenus.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpTailoredMenus.Size = New System.Drawing.Size(707, 367)
        Me.tbpTailoredMenus.TabIndex = 13
        Me.tbpTailoredMenus.Text = "Tailored Menus"
        Me.tbpTailoredMenus.UseVisualStyleBackColor = True
        '
        'ucrChkViewStructuredMenu
        '
        Me.ucrChkViewStructuredMenu.AutoSize = True
        Me.ucrChkViewStructuredMenu.Checked = False
        Me.ucrChkViewStructuredMenu.Location = New System.Drawing.Point(9, 15)
        Me.ucrChkViewStructuredMenu.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkViewStructuredMenu.Name = "ucrChkViewStructuredMenu"
        Me.ucrChkViewStructuredMenu.Size = New System.Drawing.Size(472, 36)
        Me.ucrChkViewStructuredMenu.TabIndex = 2
        '
        'ucrChkViewOptionsByContextMenu
        '
        Me.ucrChkViewOptionsByContextMenu.AutoSize = True
        Me.ucrChkViewOptionsByContextMenu.Checked = False
        Me.ucrChkViewOptionsByContextMenu.Location = New System.Drawing.Point(9, 112)
        Me.ucrChkViewOptionsByContextMenu.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkViewOptionsByContextMenu.Name = "ucrChkViewOptionsByContextMenu"
        Me.ucrChkViewOptionsByContextMenu.Size = New System.Drawing.Size(516, 36)
        Me.ucrChkViewOptionsByContextMenu.TabIndex = 1
        '
        'ucrChkViewProcurementMenu
        '
        Me.ucrChkViewProcurementMenu.AutoSize = True
        Me.ucrChkViewProcurementMenu.Checked = False
        Me.ucrChkViewProcurementMenu.Location = New System.Drawing.Point(9, 80)
        Me.ucrChkViewProcurementMenu.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkViewProcurementMenu.Name = "ucrChkViewProcurementMenu"
        Me.ucrChkViewProcurementMenu.Size = New System.Drawing.Size(516, 36)
        Me.ucrChkViewProcurementMenu.TabIndex = 0
        '
        'ucrChkViewClimaticMenu
        '
        Me.ucrChkViewClimaticMenu.AutoSize = True
        Me.ucrChkViewClimaticMenu.Checked = False
        Me.ucrChkViewClimaticMenu.Location = New System.Drawing.Point(9, 48)
        Me.ucrChkViewClimaticMenu.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkViewClimaticMenu.Name = "ucrChkViewClimaticMenu"
        Me.ucrChkViewClimaticMenu.Size = New System.Drawing.Size(509, 36)
        Me.ucrChkViewClimaticMenu.TabIndex = 0
        '
        'tbpClimsoft
        '
        Me.tbpClimsoft.Controls.Add(Me.lblUserName)
        Me.tbpClimsoft.Controls.Add(Me.lblPort)
        Me.tbpClimsoft.Controls.Add(Me.lblHost)
        Me.tbpClimsoft.Controls.Add(Me.lblDatabaseName)
        Me.tbpClimsoft.Controls.Add(Me.ucrInputUserName)
        Me.tbpClimsoft.Controls.Add(Me.ucrInputPort)
        Me.tbpClimsoft.Controls.Add(Me.ucrInputHost)
        Me.tbpClimsoft.Controls.Add(Me.ucrInputDatabaseName)
        Me.tbpClimsoft.Location = New System.Drawing.Point(4, 25)
        Me.tbpClimsoft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpClimsoft.Name = "tbpClimsoft"
        Me.tbpClimsoft.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpClimsoft.Size = New System.Drawing.Size(707, 367)
        Me.tbpClimsoft.TabIndex = 14
        Me.tbpClimsoft.Text = "Climsoft"
        Me.tbpClimsoft.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUserName.Location = New System.Drawing.Point(8, 129)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(77, 17)
        Me.lblUserName.TabIndex = 19
        Me.lblUserName.Text = "Username:"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPort.Location = New System.Drawing.Point(8, 95)
        Me.lblPort.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(38, 17)
        Me.lblPort.TabIndex = 18
        Me.lblPort.Text = "Port:"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHost.Location = New System.Drawing.Point(8, 61)
        Me.lblHost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(41, 17)
        Me.lblHost.TabIndex = 17
        Me.lblHost.Text = "Host:"
        '
        'lblDatabaseName
        '
        Me.lblDatabaseName.AutoSize = True
        Me.lblDatabaseName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDatabaseName.Location = New System.Drawing.Point(8, 26)
        Me.lblDatabaseName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatabaseName.Name = "lblDatabaseName"
        Me.lblDatabaseName.Size = New System.Drawing.Size(114, 17)
        Me.lblDatabaseName.TabIndex = 16
        Me.lblDatabaseName.Text = "Database Name:"
        '
        'ucrInputUserName
        '
        Me.ucrInputUserName.AddQuotesIfUnrecognised = True
        Me.ucrInputUserName.AutoSize = True
        Me.ucrInputUserName.IsMultiline = False
        Me.ucrInputUserName.IsReadOnly = False
        Me.ucrInputUserName.Location = New System.Drawing.Point(210, 120)
        Me.ucrInputUserName.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrInputUserName.Name = "ucrInputUserName"
        Me.ucrInputUserName.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputUserName.TabIndex = 15
        '
        'ucrInputPort
        '
        Me.ucrInputPort.AddQuotesIfUnrecognised = True
        Me.ucrInputPort.AutoSize = True
        Me.ucrInputPort.IsMultiline = False
        Me.ucrInputPort.IsReadOnly = False
        Me.ucrInputPort.Location = New System.Drawing.Point(210, 86)
        Me.ucrInputPort.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrInputPort.Name = "ucrInputPort"
        Me.ucrInputPort.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputPort.TabIndex = 14
        '
        'ucrInputHost
        '
        Me.ucrInputHost.AddQuotesIfUnrecognised = True
        Me.ucrInputHost.AutoSize = True
        Me.ucrInputHost.IsMultiline = False
        Me.ucrInputHost.IsReadOnly = False
        Me.ucrInputHost.Location = New System.Drawing.Point(210, 54)
        Me.ucrInputHost.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrInputHost.Name = "ucrInputHost"
        Me.ucrInputHost.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputHost.TabIndex = 13
        '
        'ucrInputDatabaseName
        '
        Me.ucrInputDatabaseName.AddQuotesIfUnrecognised = True
        Me.ucrInputDatabaseName.AutoSize = True
        Me.ucrInputDatabaseName.IsMultiline = False
        Me.ucrInputDatabaseName.IsReadOnly = False
        Me.ucrInputDatabaseName.Location = New System.Drawing.Point(210, 21)
        Me.ucrInputDatabaseName.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.ucrInputDatabaseName.Name = "ucrInputDatabaseName"
        Me.ucrInputDatabaseName.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputDatabaseName.TabIndex = 12
        '
        'cmdLanguage
        '
        Me.cmdLanguage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLanguage.Location = New System.Drawing.Point(681, 405)
        Me.cmdLanguage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdLanguage.Name = "cmdLanguage"
        Me.cmdLanguage.Size = New System.Drawing.Size(46, 29)
        Me.cmdLanguage.TabIndex = 13
        Me.cmdLanguage.Tag = ""
        Me.cmdLanguage.Text = "Lang"
        Me.cmdLanguage.UseVisualStyleBackColor = True
        '
        'lversion
        '
        Me.lversion.Location = New System.Drawing.Point(382, 334)
        Me.lversion.Name = "lversion"
        Me.lversion.Size = New System.Drawing.Size(318, 23)
        Me.lversion.TabIndex = 4
        Me.lversion.Text = "v. "
        Me.lversion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dlgOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(962, 441)
        Me.Controls.Add(Me.cmdLanguage)
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.spltControls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Options"
        Me.Text = "Options"
        Me.spltControls.Panel1.ResumeLayout(False)
        Me.spltControls.Panel2.ResumeLayout(False)
        CType(Me.spltControls, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spltControls.ResumeLayout(False)
        Me.tbcOptions.ResumeLayout(False)
        Me.tbpLanguages.ResumeLayout(False)
        Me.tbpLanguages.PerformLayout()
        Me.tbpComments.ResumeLayout(False)
        Me.pnComments.ResumeLayout(False)
        Me.pnComments.PerformLayout()
        Me.tbpImport.ResumeLayout(False)
        Me.tbpImport.PerformLayout()
        Me.tbpOutputWindow.ResumeLayout(False)
        Me.tbpOutputWindow.PerformLayout()
        Me.grpROptions.ResumeLayout(False)
        Me.grpROptions.PerformLayout()
        Me.pnFormatOptions.ResumeLayout(False)
        Me.pnFormatOptions.PerformLayout()
        Me.tbpEditor.ResumeLayout(False)
        Me.tbpEditor.PerformLayout()
        Me.pnFormatEditor.ResumeLayout(False)
        Me.pnFormatEditor.PerformLayout()
        Me.tbpCommands.ResumeLayout(False)
        Me.tbpCommands.PerformLayout()
        Me.tbpDataView.ResumeLayout(False)
        Me.tbpDataView.PerformLayout()
        Me.tbpWorkingDirectory.ResumeLayout(False)
        Me.tbpWorkingDirectory.PerformLayout()
        Me.tbpGraphDisplay.ResumeLayout(False)
        Me.tbpGraphDisplay.PerformLayout()
        Me.tbpTailoredMenus.ResumeLayout(False)
        Me.tbpTailoredMenus.PerformLayout()
        Me.tbpClimsoft.ResumeLayout(False)
        Me.tbpClimsoft.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdOk As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdHelp As Button
    Friend WithEvents cmdApply As Button
    Friend WithEvents tbcOptions As TabControl
    Friend WithEvents tbpLanguages As TabPage
    Friend WithEvents tbpComments As TabPage
    Friend WithEvents pnComments As Panel
    Friend WithEvents lblComment As Label
    Friend WithEvents tbpImport As TabPage
    Friend WithEvents pnImportData As Panel
    Friend WithEvents lblPreviewRows As Label
    Friend WithEvents tbpOutputWindow As TabPage
    Friend WithEvents pnFormatOptions As Panel
    Friend WithEvents rtbCommentPreview As RichTextBox
    Friend WithEvents rtbOutputPreview As RichTextBox
    Friend WithEvents rtbCommandPreview As RichTextBox
    Friend WithEvents cmdCommandFormat As Button
    Friend WithEvents lblCommentFormat As Label
    Friend WithEvents cmdOutputFormat As Button
    Friend WithEvents lblOutputFormat As Label
    Friend WithEvents cmdCommentFormat As Button
    Friend WithEvents lblCommandFormat As Label
    Friend WithEvents tbpEditor As TabPage
    Friend WithEvents pnFormatEditor As Panel
    Friend WithEvents cmdEditorFont As Button
    Friend WithEvents lblFont As Label
    Friend WithEvents tbpCommands As TabPage
    Friend WithEvents tbpDataView As TabPage
    Friend WithEvents lblMaxRows As Label
    Friend WithEvents tbpWorkingDirectory As TabPage
    Friend WithEvents cmdWorkingDirectory As Button
    Friend WithEvents ucrWorkingDirectory As ucrInputTextBox
    Friend WithEvents lblWorkingDirectory As Label
    Friend WithEvents trOptions As TreeView
    Friend WithEvents spltControls As SplitContainer
    Friend WithEvents tbpGraphDisplay As TabPage
    Friend WithEvents rdoDisplayinSeparateWindows As RadioButton
    Friend WithEvents rdoDisplayinRViewer As RadioButton
    Friend WithEvents rdoDisplayinOutputWindow As RadioButton
    Friend WithEvents grpROptions As GroupBox
    Friend WithEvents lblNoDigits As Label
    Friend WithEvents cmdFactoryReset As Button
    Friend WithEvents ucrNudPreviewRows As ucrNud
    Friend WithEvents ucrNudDigits As ucrNud
    Friend WithEvents ucrChkIncludeCommentsbyDefault As ucrCheck
    Friend WithEvents ucrChkShowRCommandsinOutputWindow As ucrCheck
    Friend WithEvents ucrChkShowSignifStars As ucrCheck
    Friend WithEvents ucrChkIncludeDefaultParams As ucrCheck
    Friend WithEvents ucrNudMaxRows As ucrNud
    Friend WithEvents ucrPnlGraphDisplay As UcrPanel
    Friend WithEvents ucrInputComment As ucrInputTextBox
    Friend WithEvents ucrNudMaxCols As ucrNud
    Friend WithEvents lblMaxCols As Label
    Friend WithEvents ucrChkShowDataonGrid As ucrCheck
    Friend WithEvents ucrChkAutoSave As ucrCheck
    Friend WithEvents ucrNudAutoSaveMinutes As ucrNud
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblEvery As Label
    Friend WithEvents lblWaitSeconds As Label
    Friend WithEvents ucrChkShowWaitDialog As ucrCheck
    Friend WithEvents ucrNudWaitSeconds As ucrNud
    Friend WithEvents tbpTailoredMenus As TabPage
    Friend WithEvents ucrChkViewProcurementMenu As ucrCheck
    Friend WithEvents ucrChkViewClimaticMenu As ucrCheck
    Friend WithEvents ucrChkViewOptionsByContextMenu As ucrCheck
    Friend WithEvents tbpClimsoft As TabPage
    Friend WithEvents ucrInputUserName As ucrInputTextBox
    Friend WithEvents ucrInputPort As ucrInputTextBox
    Friend WithEvents ucrInputHost As ucrInputTextBox
    Friend WithEvents ucrInputDatabaseName As ucrInputTextBox
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents lblHost As Label
    Friend WithEvents lblDatabaseName As Label
    Friend WithEvents ucrChkViewStructuredMenu As ucrCheck
    Friend WithEvents lblLanguage As Label
    Friend WithEvents ucrInputLanguage As ucrInputComboBox
    Friend WithEvents cmdLanguage As Button
    Friend WithEvents ucrChkMaximumOutputsHeight As ucrCheck
    Friend WithEvents ucrNudMaximumOutputsHeight As ucrNud
    Friend WithEvents lversion As Label
End Class
