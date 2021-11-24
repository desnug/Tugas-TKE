<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ButtonMWI = New FontAwesome.Sharp.IconButton()
        Me.ButtonDerivative = New FontAwesome.Sharp.IconButton()
        Me.ButtonBPF = New FontAwesome.Sharp.IconButton()
        Me.ButtonRawData = New FontAwesome.Sharp.IconButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonDisconnect = New FontAwesome.Sharp.IconButton()
        Me.ButtonConnect = New FontAwesome.Sharp.IconButton()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New FontAwesome.Sharp.IconButton()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New FontAwesome.Sharp.IconButton()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelECG = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxRecordInd = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonClear = New FontAwesome.Sharp.IconButton()
        Me.ButtonStopRecording = New FontAwesome.Sharp.IconButton()
        Me.ButtonStartRecording = New FontAwesome.Sharp.IconButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ProgressBarProcess = New System.Windows.Forms.ProgressBar()
        Me.ButtonSaveToExcel = New FontAwesome.Sharp.IconButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ECG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDataLogRecord = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBoxConnectionInd = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxConnectionInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(195, 612)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(74, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ITS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ECG_graph.My.Resources.Resources.Lambang_ITS_putih_05
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(189, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox7.Controls.Add(Me.IconButton1)
        Me.GroupBox7.Controls.Add(Me.ButtonMWI)
        Me.GroupBox7.Controls.Add(Me.ButtonDerivative)
        Me.GroupBox7.Controls.Add(Me.ButtonBPF)
        Me.GroupBox7.Controls.Add(Me.ButtonRawData)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(3, 387)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(189, 222)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Filter Menu"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Stopwatch
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 28
        Me.IconButton1.Location = New System.Drawing.Point(9, 181)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(174, 35)
        Me.IconButton1.TabIndex = 9
        Me.IconButton1.Text = "Stop Data"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'ButtonMWI
        '
        Me.ButtonMWI.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ButtonMWI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMWI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMWI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMWI.ForeColor = System.Drawing.Color.White
        Me.ButtonMWI.IconChar = FontAwesome.Sharp.IconChar.Yarn
        Me.ButtonMWI.IconColor = System.Drawing.Color.White
        Me.ButtonMWI.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonMWI.IconSize = 28
        Me.ButtonMWI.Location = New System.Drawing.Point(9, 140)
        Me.ButtonMWI.Name = "ButtonMWI"
        Me.ButtonMWI.Size = New System.Drawing.Size(174, 35)
        Me.ButtonMWI.TabIndex = 8
        Me.ButtonMWI.Text = "Moving Window"
        Me.ButtonMWI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonMWI.UseVisualStyleBackColor = False
        '
        'ButtonDerivative
        '
        Me.ButtonDerivative.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ButtonDerivative.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDerivative.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDerivative.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDerivative.ForeColor = System.Drawing.Color.White
        Me.ButtonDerivative.IconChar = FontAwesome.Sharp.IconChar.Newspaper
        Me.ButtonDerivative.IconColor = System.Drawing.Color.White
        Me.ButtonDerivative.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonDerivative.IconSize = 28
        Me.ButtonDerivative.Location = New System.Drawing.Point(9, 101)
        Me.ButtonDerivative.Name = "ButtonDerivative"
        Me.ButtonDerivative.Size = New System.Drawing.Size(174, 35)
        Me.ButtonDerivative.TabIndex = 7
        Me.ButtonDerivative.Text = "Derivative"
        Me.ButtonDerivative.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonDerivative.UseVisualStyleBackColor = False
        '
        'ButtonBPF
        '
        Me.ButtonBPF.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ButtonBPF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBPF.ForeColor = System.Drawing.Color.White
        Me.ButtonBPF.IconChar = FontAwesome.Sharp.IconChar.Bahai
        Me.ButtonBPF.IconColor = System.Drawing.Color.White
        Me.ButtonBPF.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonBPF.IconSize = 28
        Me.ButtonBPF.Location = New System.Drawing.Point(9, 60)
        Me.ButtonBPF.Name = "ButtonBPF"
        Me.ButtonBPF.Size = New System.Drawing.Size(174, 35)
        Me.ButtonBPF.TabIndex = 6
        Me.ButtonBPF.Text = "Band Pass Filter"
        Me.ButtonBPF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonBPF.UseVisualStyleBackColor = False
        '
        'ButtonRawData
        '
        Me.ButtonRawData.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.ButtonRawData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRawData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRawData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRawData.ForeColor = System.Drawing.Color.White
        Me.ButtonRawData.IconChar = FontAwesome.Sharp.IconChar.Dragon
        Me.ButtonRawData.IconColor = System.Drawing.Color.White
        Me.ButtonRawData.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonRawData.IconSize = 28
        Me.ButtonRawData.Location = New System.Drawing.Point(9, 19)
        Me.ButtonRawData.Name = "ButtonRawData"
        Me.ButtonRawData.Size = New System.Drawing.Size(174, 35)
        Me.ButtonRawData.TabIndex = 5
        Me.ButtonRawData.Text = "Raw Data"
        Me.ButtonRawData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonRawData.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.ButtonDisconnect)
        Me.GroupBox1.Controls.Add(Me.ButtonConnect)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBaudRate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPort)
        Me.GroupBox1.Controls.Add(Me.ButtonScanPort)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 262)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ButtonDisconnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDisconnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDisconnect.ForeColor = System.Drawing.Color.White
        Me.ButtonDisconnect.IconChar = FontAwesome.Sharp.IconChar.Radiation
        Me.ButtonDisconnect.IconColor = System.Drawing.Color.White
        Me.ButtonDisconnect.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonDisconnect.IconSize = 28
        Me.ButtonDisconnect.Location = New System.Drawing.Point(6, 207)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(174, 35)
        Me.ButtonDisconnect.TabIndex = 5
        Me.ButtonDisconnect.Text = "Disconnect"
        Me.ButtonDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonDisconnect.UseVisualStyleBackColor = False
        '
        'ButtonConnect
        '
        Me.ButtonConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.ButtonConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.ForeColor = System.Drawing.Color.White
        Me.ButtonConnect.IconChar = FontAwesome.Sharp.IconChar.RadiationAlt
        Me.ButtonConnect.IconColor = System.Drawing.Color.White
        Me.ButtonConnect.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonConnect.IconSize = 28
        Me.ButtonConnect.Location = New System.Drawing.Point(6, 166)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(174, 35)
        Me.ButtonConnect.TabIndex = 4
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonConnect.UseVisualStyleBackColor = False
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ComboBoxBaudRate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxBaudRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxBaudRate.ForeColor = System.Drawing.Color.White
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(9, 124)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(174, 21)
        Me.ComboBoxBaudRate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.No
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.IconChar = FontAwesome.Sharp.IconChar.Binoculars
        Me.Label1.IconColor = System.Drawing.Color.White
        Me.Label1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Label1.IconSize = 28
        Me.Label1.Location = New System.Drawing.Point(6, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 35)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Baud Rate:"
        Me.Label1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Label1.UseVisualStyleBackColor = False
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ComboBoxPort.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPort.ForeColor = System.Drawing.Color.White
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(6, 56)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(174, 21)
        Me.ComboBoxPort.TabIndex = 1
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ButtonScanPort.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonScanPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScanPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScanPort.ForeColor = System.Drawing.Color.White
        Me.ButtonScanPort.IconChar = FontAwesome.Sharp.IconChar.SatelliteDish
        Me.ButtonScanPort.IconColor = System.Drawing.Color.White
        Me.ButtonScanPort.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonScanPort.IconSize = 28
        Me.ButtonScanPort.Location = New System.Drawing.Point(6, 19)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(174, 35)
        Me.ButtonScanPort.TabIndex = 0
        Me.ButtonScanPort.Text = "Scan Port"
        Me.ButtonScanPort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonScanPort.UseVisualStyleBackColor = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.BackColor = System.Drawing.SystemColors.Control
        Me.LabelStatus.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelStatus.Location = New System.Drawing.Point(1157, 593)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(100, 13)
        Me.LabelStatus.TabIndex = 1
        Me.LabelStatus.Text = "Status : Disconnect"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(195, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1088, 121)
        Me.Panel2.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(461, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 24)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Teknik Elektro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(474, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "6022201042"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(447, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "DEVIS STYO NUGROHO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Elephant", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(214, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(653, 31)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "AKUISISI DATA MIKROKONTROLER dsPIC"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.LabelECG)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(201, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(161, 97)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Incoming Data (Real Time)"
        '
        'LabelECG
        '
        Me.LabelECG.AutoSize = True
        Me.LabelECG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelECG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.LabelECG.Location = New System.Drawing.Point(9, 37)
        Me.LabelECG.Name = "LabelECG"
        Me.LabelECG.Size = New System.Drawing.Size(99, 20)
        Me.LabelECG.TabIndex = 0
        Me.LabelECG.Text = "Waiting ....."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Controls.Add(Me.PictureBoxRecordInd)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.ButtonClear)
        Me.GroupBox3.Controls.Add(Me.ButtonStopRecording)
        Me.GroupBox3.Controls.Add(Me.ButtonStartRecording)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(368, 128)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(204, 97)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Control"
        '
        'PictureBoxRecordInd
        '
        Me.PictureBoxRecordInd.Image = Global.ECG_graph.My.Resources.Resources.red
        Me.PictureBoxRecordInd.Location = New System.Drawing.Point(181, 0)
        Me.PictureBoxRecordInd.Name = "PictureBoxRecordInd"
        Me.PictureBoxRecordInd.Size = New System.Drawing.Size(14, 15)
        Me.PictureBoxRecordInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxRecordInd.TabIndex = 6
        Me.PictureBoxRecordInd.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Recording"
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ButtonClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonClear.IconColor = System.Drawing.Color.White
        Me.ButtonClear.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonClear.Location = New System.Drawing.Point(9, 61)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(188, 23)
        Me.ButtonClear.TabIndex = 8
        Me.ButtonClear.Text = "Clear Data Grid"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonStopRecording
        '
        Me.ButtonStopRecording.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.ButtonStopRecording.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStopRecording.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStopRecording.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStopRecording.ForeColor = System.Drawing.Color.White
        Me.ButtonStopRecording.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonStopRecording.IconColor = System.Drawing.Color.Transparent
        Me.ButtonStopRecording.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonStopRecording.Location = New System.Drawing.Point(107, 29)
        Me.ButtonStopRecording.Name = "ButtonStopRecording"
        Me.ButtonStopRecording.Size = New System.Drawing.Size(90, 23)
        Me.ButtonStopRecording.TabIndex = 7
        Me.ButtonStopRecording.Text = "Stop Recording"
        Me.ButtonStopRecording.UseVisualStyleBackColor = False
        '
        'ButtonStartRecording
        '
        Me.ButtonStartRecording.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.ButtonStartRecording.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStartRecording.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStartRecording.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStartRecording.ForeColor = System.Drawing.Color.White
        Me.ButtonStartRecording.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonStartRecording.IconColor = System.Drawing.Color.White
        Me.ButtonStartRecording.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonStartRecording.Location = New System.Drawing.Point(9, 29)
        Me.ButtonStartRecording.Name = "ButtonStartRecording"
        Me.ButtonStartRecording.Size = New System.Drawing.Size(92, 23)
        Me.ButtonStartRecording.TabIndex = 6
        Me.ButtonStartRecording.Text = "Start Recording"
        Me.ButtonStartRecording.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Controls.Add(Me.ProgressBarProcess)
        Me.GroupBox4.Controls.Add(Me.ButtonSaveToExcel)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(578, 128)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(123, 95)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Export"
        '
        'ProgressBarProcess
        '
        Me.ProgressBarProcess.Location = New System.Drawing.Point(9, 68)
        Me.ProgressBarProcess.Maximum = 10
        Me.ProgressBarProcess.Name = "ProgressBarProcess"
        Me.ProgressBarProcess.Size = New System.Drawing.Size(105, 14)
        Me.ProgressBarProcess.TabIndex = 10
        Me.ProgressBarProcess.Visible = False
        '
        'ButtonSaveToExcel
        '
        Me.ButtonSaveToExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ButtonSaveToExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSaveToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSaveToExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSaveToExcel.ForeColor = System.Drawing.Color.White
        Me.ButtonSaveToExcel.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ButtonSaveToExcel.IconColor = System.Drawing.Color.White
        Me.ButtonSaveToExcel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ButtonSaveToExcel.Location = New System.Drawing.Point(9, 27)
        Me.ButtonSaveToExcel.Name = "ButtonSaveToExcel"
        Me.ButtonSaveToExcel.Size = New System.Drawing.Size(105, 35)
        Me.ButtonSaveToExcel.TabIndex = 9
        Me.ButtonSaveToExcel.Text = "Save To Excel"
        Me.ButtonSaveToExcel.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(201, 229)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(500, 361)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data Grid View (Realtime)"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.ECG, Me.TIME, Me.DATE_})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(485, 335)
        Me.DataGridView1.TabIndex = 0
        '
        'No
        '
        Me.No.FillWeight = 40.60914!
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        '
        'ECG
        '
        Me.ECG.FillWeight = 119.797!
        Me.ECG.HeaderText = "ECG"
        Me.ECG.Name = "ECG"
        '
        'TIME
        '
        Me.TIME.FillWeight = 119.797!
        Me.TIME.HeaderText = "TIME"
        Me.TIME.Name = "TIME"
        '
        'DATE_
        '
        Me.DATE_.HeaderText = "DATE"
        Me.DATE_.Name = "DATE_"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox6.Controls.Add(Me.Chart1)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(707, 128)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(576, 462)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "ECG Graph"
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea4.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend4)
        Me.Chart1.Location = New System.Drawing.Point(6, 20)
        Me.Chart1.Name = "Chart1"
        Series4.BorderWidth = 2
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series4.Color = System.Drawing.Color.DeepSkyBlue
        Series4.Legend = "Legend1"
        Series4.Name = "ECG"
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(564, 435)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'TimerSerial
        '
        '
        'TimerDataLogRecord
        '
        '
        'PictureBoxConnectionInd
        '
        Me.PictureBoxConnectionInd.Image = Global.ECG_graph.My.Resources.Resources.red
        Me.PictureBoxConnectionInd.Location = New System.Drawing.Point(1257, 593)
        Me.PictureBoxConnectionInd.Name = "PictureBoxConnectionInd"
        Me.PictureBoxConnectionInd.Size = New System.Drawing.Size(14, 15)
        Me.PictureBoxConnectionInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxConnectionInd.TabIndex = 1
        Me.PictureBoxConnectionInd.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1283, 612)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.PictureBoxConnectionInd)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tugas TKE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxConnectionInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents Label1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonScanPort As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBoxConnectionInd As PictureBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ButtonDisconnect As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonConnect As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ProgressBarProcess As ProgressBar
    Friend WithEvents ButtonSaveToExcel As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBoxRecordInd As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonClear As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonStopRecording As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonStartRecording As FontAwesome.Sharp.IconButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelECG As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents ECG As DataGridViewTextBoxColumn
    Friend WithEvents TIME As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents TimerDataLogRecord As Timer
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonMWI As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonDerivative As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonBPF As FontAwesome.Sharp.IconButton
    Friend WithEvents ButtonRawData As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
