﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgUseTable
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
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'UcrButtons1
        '
        Me.UcrButtons1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrButtons1.Location = New System.Drawing.Point(1, 397)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(410, 52)
        Me.UcrButtons1.TabIndex = 0
        '
        'dlgUseTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 450)
        Me.Controls.Add(Me.UcrButtons1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "dlgUseTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use Table"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrButtons1 As ucrButtons
End Class
