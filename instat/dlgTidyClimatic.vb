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

Imports instat.Translations

Public Class dlgTidyClimaticData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsTidyClimaticFunction As New RFunction

    Private iTextBoxMaxY As Integer

    Private Sub dlgReshapeClimaticData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            iTextBoxMaxY = grpElements.Location.Y
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.clsRsyntax.iCallType = 0

        ucrPnlReshapeClimaticData.AddRadioButton(rdoYear)
        ucrPnlReshapeClimaticData.AddRadioButton(rdoMonth)
        ucrPnlReshapeClimaticData.AddRadioButton(rdoDay)

        ucrSelectorTidyClimaticData.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrSelectorTidyClimaticData.SetParameterIsrfunction()


        ucrReceiverStation.Selector = ucrSelectorTidyClimaticData
        ucrReceiverMultipleStack.Selector = ucrSelectorTidyClimaticData
        ucrReceiverElement.Selector = ucrSelectorTidyClimaticData

        ucrReceiverYear.Selector = ucrSelectorTidyClimaticData
        ucrReceiverYearTwo.Selector = ucrSelectorTidyClimaticData
        ucrReceiverMonthTwo.Selector = ucrSelectorTidyClimaticData
        ucrReceiverDayofMonth.Selector = ucrSelectorTidyClimaticData

        ucrReceiverMultipleStack.SetParameter(New RParameter("stack_cols", 2))
        ucrReceiverMultipleStack.SetParameterIsString()


        ucrReceiverStation.SetParameter(New RParameter("station", 6))
        ucrReceiverStation.SetParameterIsString()

        ucrReceiverElement.SetParameter(New RParameter("element", 7))
        ucrReceiverElement.SetParameterIsString()

        ucrTextBoxElementName.SetParameter(New RParameter("element_name", 8))
        ucrTextBoxElementName.SetRDefault("value")

        'rdoYear

        'rdoMonth
        ucrReceiverYear.SetParameter(New RParameter("year", 5))
        ucrReceiverYear.SetParameterIsString()

        ucrReceiverDayofMonth.SetParameter(New RParameter("day", 3))
        ucrReceiverDayofMonth.SetParameterIsString()

        'rdoDay
        ucrReceiverYearTwo.SetParameter(New RParameter("year", 5))
        ucrReceiverYearTwo.SetParameterIsString()

        ucrReceiverMonthTwo.SetParameter(New RParameter("month", 4))
        ucrReceiverMonthTwo.SetParameterIsString()

        'Checkboxes
        ucrChkIgnoreInvalid.SetParameter(New RParameter("ignore_invalid", 9))
        ucrChkIgnoreInvalid.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIgnoreInvalid.SetRDefault("FALSE")
        ucrChkIgnoreInvalid.SetText("Ignore values on invalid dates")

        ucrChkSilent.SetParameter(New RParameter("silent", 10))
        ucrChkSilent.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkSilent.SetRDefault("FALSE")
        ucrChkSilent.SetText("Display details of warnings and errors")

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverYear, {rdoMonth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverDayofMonth, {rdoMonth}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverYearTwo, {rdoDay}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverMonthTwo, {rdoDay}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoYear, "format", Chr(34) & "years" & Chr(34))
        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoMonth, "format", Chr(34) & "months" & Chr(34))
        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoDay, "format", Chr(34) & "days" & Chr(34))

        ucrReceiverStation.SetLinkedDisplayControl(lblStation)

        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        ucrReceiverDayofMonth.SetLinkedDisplayControl(lblDayofMonth)

        ucrReceiverYearTwo.SetLinkedDisplayControl(lblYearTwo)
        ucrReceiverMonthTwo.SetLinkedDisplayControl(lblMonthTwo)

        ucrReceiverElement.SetLinkedDisplayControl(lblMultipleElement)
        ucrTextBoxElementName.SetLinkedDisplayControl(lblElementName)

        ucrNewDFName.SetIsComboBox()
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetCheckBoxText("New Data Frame Name")
        ucrNewDFName.SetDataFrameSelector(ucrSelectorTidyClimaticData.ucrAvailableDataFrames)
        ucrNewDFName.SetAssignToIfUncheckedValue("last_data_frame")

    End Sub

    Private Sub SetDefaults()
        clsTidyClimaticFunction = New RFunction

        ucrSelectorTidyClimaticData.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        ucrNewDFName.Reset()

        clsTidyClimaticFunction.SetAssignTo(ucrNewDFName.GetText, strTempDataframe:=ucrSelectorTidyClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        clsTidyClimaticFunction.AddParameter("format", Chr(34) & "years" & Chr(34), iPosition:=3)

        clsTidyClimaticFunction.SetRCommand("tidy_climatic_data")
        ucrBase.clsRsyntax.SetBaseRFunction(clsTidyClimaticFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoYear.Checked Then
            If Not ucrReceiverMultipleStack.IsEmpty AndAlso ucrNewDFName.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
        If rdoMonth.Checked Then
            If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverMultipleStack.IsEmpty AndAlso Not ucrReceiverDayofMonth.IsEmpty AndAlso ucrNewDFName.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
        If rdoDay.Checked Then
            If Not ucrReceiverYearTwo.IsEmpty AndAlso Not ucrReceiverMonthTwo.IsEmpty AndAlso Not ucrReceiverMultipleStack.IsEmpty AndAlso ucrNewDFName.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub NewDefaultName()
        If (Not ucrNewDFName.bUserTyped) AndAlso ucrSelectorTidyClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDFName.SetPrefix(ucrSelectorTidyClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_tidy")
        End If
    End Sub

    Private Sub ucrPnlReshapeClimaticData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlReshapeClimaticData.ControlValueChanged, ucrReceiverMonthTwo.ControlValueChanged, ucrReceiverYear.ControlValueChanged, ucrReceiverYearTwo.ControlValueChanged
        UpdateParameters()
        ShowReceivers()
        ElementGroupLocation()
        ColumnstoStackText()
    End Sub

    Private Sub UpdateParameters()

        clsTidyClimaticFunction.RemoveParameterByName("format")

        If rdoYear.Checked Then
            clsTidyClimaticFunction.AddParameter("format", Chr(34) & "years" & Chr(34), iPosition:=1)
            clsTidyClimaticFunction.RemoveParameterByName("element")
        ElseIf rdoMonth.Checked Then
            clsTidyClimaticFunction.AddParameter("format", Chr(34) & "months" & Chr(34), iPosition:=1)
        ElseIf rdoDay.Checked Then
            clsTidyClimaticFunction.AddParameter("format", Chr(34) & "days" & Chr(34), iPosition:=1)
        End If

    End Sub

    Private Sub ShowReceivers()
        If rdoYear.Checked Then
            ucrReceiverElement.Visible = False
            ucrReceiverStation.Visible = False
            lblOr.Visible = False
            ucrReceiverMultipleStack.SetMeAsReceiver()
        Else
            ucrReceiverElement.Visible = True
            ucrReceiverStation.Visible = True
            lblOr.Visible = True
        End If
    End Sub

    Private Sub ColumnstoStackText()
        If rdoYear.Checked Then
            lblColumnstoStack.Text = "Year Columns"
        ElseIf rdoMonth.Checked Then
            lblColumnstoStack.Text = "Month Columns (12)"
        Else
            lblColumnstoStack.Text = "Day Columns (31)"
        End If
    End Sub

    Private Sub ElementGroupLocation()
        If rdoYear.Checked Then
            grpElements.Location = New Point(grpElements.Location.X, iTextBoxMaxY / 1.5)
        Else
            grpElements.Location = New Point(grpElements.Location.X, iTextBoxMaxY)
        End If
    End Sub

    Private Sub ElementAddRemoveParam()
        clsTidyClimaticFunction.RemoveParameterByName("element_name")

        If Not ucrReceiverElement.IsEmpty Then
            ucrTextBoxElementName.Enabled = False
        Else
            clsTidyClimaticFunction.AddParameter("element_name", Chr(34) & ucrTextBoxElementName.GetText & Chr(34), iPosition:=8)
            ucrTextBoxElementName.Enabled = True
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewDFName.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrReceiverYearTwo.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverYearTwo.ControlContentsChanged, ucrReceiverMonthTwo.ControlContentsChanged, ucrReceiverDayofMonth.ControlContentsChanged, ucrPnlReshapeClimaticData.ControlContentsChanged, ucrReceiverMultipleStack.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorReshapeClimaticData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTidyClimaticData.ControlValueChanged
        NewDefaultName()
    End Sub

    Private Sub ucrTextBoxElementName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrTextBoxElementName.ControlValueChanged, ucrReceiverElement.ControlValueChanged
        ElementAddRemoveParam()
    End Sub
End Class
