Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml

Public Class Form1
    Dim StrParse, ECG_1 As String
    Dim ECG_1L As Integer
    Dim Limit As Integer = 200
    Dim FilePathAndName As String
    Dim strArray() As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ButtonDisconnect.Enabled = False
        ButtonConnect.Enabled = False
        ButtonStartRecording.Enabled = False
        ButtonStopRecording.Enabled = False
        ComboBoxBaudRate.SelectedIndex = 3

        ButtonSaveToExcel.Height = 50

        For i = 0 To 200 Step 1
            Chart1.Series("ECG").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(0).Points.Count = Limit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If
            'Chart1.ChartAreas(0).AxisY.Maximum = 100
        Next
        Chart1.ChartAreas(0).AxisY.Maximum = 100
        Chart1.ChartAreas(0).AxisY.Minimum = -100
        'Chart1.ChartAreas("ChartArea1").AxisX.LabelStyle.Enabled = False

    End Sub

    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i
        Try
            ComboBoxPort.SelectedIndex = i
            ButtonConnect.Enabled = True
        Catch ex As Exception
            MsgBox("Com port not detected", MsgBoxStyle.Critical, "Warning !!!")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            ButtonConnect.Enabled = False
            ButtonStartRecording.Enabled = False
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
        SerialPort1.PortName = ComboBoxPort.SelectedItem
        SerialPort1.Open()
        TimerSerial.Start()

        ComboBoxPort.Enabled = False
        Label1.Enabled = False
        ComboBoxBaudRate.Enabled = False
        ButtonScanPort.Enabled = False
        ButtonConnect.Enabled = False
        ButtonDisconnect.Enabled = True
        ButtonStartRecording.Enabled = True

        PictureBoxConnectionInd.Image = My.Resources.green
        LabelStatus.Text = "Status : Connected"
    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        PictureBoxConnectionInd.Image = My.Resources.red
        PictureBoxConnectionInd.Visible = True
        LabelStatus.Text = "Status : Disconnect"

        ComboBoxPort.Enabled = True
        Label1.Enabled = True
        ComboBoxBaudRate.Enabled = True
        ButtonScanPort.Enabled = True
        ButtonConnect.Enabled = True
        ButtonDisconnect.Enabled = False

        TimerSerial.Stop()
        TimerDataLogRecord.Stop()

        ButtonSaveToExcel.Enabled = True
        ButtonStopRecording.Enabled = False

        SerialPort1.Close()
    End Sub

    Private Sub ButtonStartRecording_Click(sender As Object, e As EventArgs) Handles ButtonStartRecording.Click
        ButtonStartRecording.Enabled = False
        ButtonStopRecording.Enabled = True
        ButtonSaveToExcel.Enabled = False
        TimerDataLogRecord.Start()
    End Sub

    Private Sub ButtonStopRecording_Click(sender As Object, e As EventArgs) Handles ButtonStopRecording.Click
        ButtonStartRecording.Enabled = True
        ButtonStopRecording.Enabled = False
        ButtonSaveToExcel.Enabled = True
        TimerDataLogRecord.Stop()
        PictureBoxRecordInd.Visible = True
    End Sub

    Private Sub ButtonRawData_Click(sender As Object, e As EventArgs) Handles ButtonRawData.Click
        SerialPort1.Write("r")
    End Sub

    Private Sub ButtonBPF_Click(sender As Object, e As EventArgs) Handles ButtonBPF.Click
        SerialPort1.Write("b")
    End Sub

    Private Sub ButtonDerivative_Click(sender As Object, e As EventArgs) Handles ButtonDerivative.Click
        SerialPort1.Write("d")
    End Sub

    Private Sub ButtonMWI_Click(sender As Object, e As EventArgs) Handles ButtonMWI.Click
        SerialPort1.Write("m")
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        SerialPort1.Write("n")
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        For i = 0 To 200 Step 1
            Chart1.Series("ECG").Points.AddXY(DateTime.Now.ToLongTimeString, 0)
            If Chart1.Series(0).Points.Count = Limit Then
                Chart1.Series(0).Points.RemoveAt(0)
            End If
            Chart1.ChartAreas(0).AxisY.Maximum = 100
            Chart1.ChartAreas(0).AxisY.Minimum = -100
        Next
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub ButtonSaveToExcel_Click(sender As Object, e As EventArgs) Handles ButtonSaveToExcel.Click
        ButtonSaveToExcel.Height = 37
        ButtonSaveToExcel.Text = "Please Wait..."
        ButtonSaveToExcel.Enabled = False
        ButtonStartRecording.Enabled = False
        ProgressBarProcess.Visible = True
        ProgressBarProcess.Value = 1

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ProgressBarProcess.Value = 3

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")

        ProgressBarProcess.Value = 5

        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next

        ProgressBarProcess.Value = 8

        FilePathAndName = Application.StartupPath & "\" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xlsx"
        If File.Exists(FilePathAndName) Then File.Delete(FilePathAndName)

        xlWorkSheet.SaveAs(FilePathAndName)
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        ProgressBarProcess.Value = 10

        MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & FilePathAndName, MsgBoxStyle.Information, "Information")

        ProgressBarProcess.Visible = False

        Process.Start(FilePathAndName)

        ButtonSaveToExcel.Height = 50
        ButtonSaveToExcel.Text = "Save To MS Excel"
        ButtonSaveToExcel.Enabled = True
        ButtonStartRecording.Enabled = True
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub TimerDataLogRecord_Tick(sender As Object, e As EventArgs) Handles TimerDataLogRecord.Tick
        Dim ECG_1Log As String
        Dim DT As DateTime = Now

        ECG_1Log = Mid(ECG_1, 2, ECG_1L)

        DataGridView1.Rows.Add(New String() {DataGridView1.RowCount, ECG_1Log, DT.ToLongTimeString, DT.ToString("dd-MM-yyyy")})
        Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1

        Chart1.Series("ECG").Points.AddXY(DateTime.Now.ToLongTimeString, ECG_1Log)
        If Chart1.Series(0).Points.Count = Limit Then
            Chart1.Series(0).Points.RemoveAt(0)
        End If

        If PictureBoxRecordInd.Visible = True Then
            PictureBoxRecordInd.Visible = False
        ElseIf PictureBoxRecordInd.Visible = False Then
            PictureBoxRecordInd.Visible = True
        End If
    End Sub

    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        Try
            Dim StrSerialIn As String = SerialPort1.ReadExisting
            Dim StrSerialInRam As String

            Dim TB As New TextBox
            TB.Multiline = True
            TB.Text = StrSerialIn

            strArray = Split(StrSerialIn, "D")
            TB.Text = "D" & strArray(1)

            StrSerialInRam = TB.Lines(0).Substring(0, 1)
            If StrSerialInRam = "D" Then
                ECG_1 = TB.Lines(0)
                ECG_1L = ECG_1.Length
            Else
                ECG_1 = ECG_1
            End If

            If PictureBoxConnectionInd.Visible = True Then
                PictureBoxConnectionInd.Visible = False
            ElseIf PictureBoxConnectionInd.Visible = False Then
                PictureBoxConnectionInd.Visible = True
            End If

            LabelECG.Text = "ECG = " & Mid(ECG_1, 2, ECG_1L)
        Catch ex As Exception

        End Try
    End Sub

End Class
