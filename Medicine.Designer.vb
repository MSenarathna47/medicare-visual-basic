<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medicine
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientButton4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMedicineName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBprice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSprice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CompCb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.MedicineGV = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnDlt = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.dateDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.PharmacyDbDataSet = New pharmacy.PharmacyDbDataSet()
        Me.PharmacyDbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMedId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmacyDbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(317, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Themara Medicare"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Controls.Add(Me.Guna2GradientButton4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(897, 100)
        Me.Panel1.TabIndex = 1
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 15
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Button1.Image = Global.pharmacy.My.Resources.Resources.icons8_go_back_48
        Me.Guna2Button1.ImageOffset = New System.Drawing.Point(-5, 0)
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(50, 50)
        Me.Guna2Button1.Location = New System.Drawing.Point(3, 18)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(132, 58)
        Me.Guna2Button1.TabIndex = 10
        Me.Guna2Button1.Text = "Back"
        '
        'Guna2GradientButton4
        '
        Me.Guna2GradientButton4.Animated = True
        Me.Guna2GradientButton4.BorderRadius = 12
        Me.Guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2GradientButton4.FillColor2 = System.Drawing.Color.Black
        Me.Guna2GradientButton4.FocusedColor = System.Drawing.Color.Red
        Me.Guna2GradientButton4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GradientButton4.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton4.HoverState.FillColor = System.Drawing.Color.DarkRed
        Me.Guna2GradientButton4.HoverState.FillColor2 = System.Drawing.Color.Red
        Me.Guna2GradientButton4.Image = Global.pharmacy.My.Resources.Resources.cancel
        Me.Guna2GradientButton4.Location = New System.Drawing.Point(832, 3)
        Me.Guna2GradientButton4.Name = "Guna2GradientButton4"
        Me.Guna2GradientButton4.Size = New System.Drawing.Size(62, 31)
        Me.Guna2GradientButton4.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pharmacy.My.Resources.Resources._CITYPNG_COM_Pharmacy_Healthcare_Green_Cross_Leaf_Medical___861x683__1_
        Me.PictureBox1.Location = New System.Drawing.Point(221, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(367, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Medicines"
        '
        'txtMedicineName
        '
        Me.txtMedicineName.Animated = True
        Me.txtMedicineName.BackColor = System.Drawing.Color.Transparent
        Me.txtMedicineName.BorderColor = System.Drawing.Color.Navy
        Me.txtMedicineName.BorderRadius = 8
        Me.txtMedicineName.BorderThickness = 2
        Me.txtMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMedicineName.DefaultText = ""
        Me.txtMedicineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMedicineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMedicineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMedicineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMedicineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMedicineName.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtMedicineName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMedicineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMedicineName.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtMedicineName.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtMedicineName.Location = New System.Drawing.Point(26, 181)
        Me.txtMedicineName.Name = "txtMedicineName"
        Me.txtMedicineName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMedicineName.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtMedicineName.PlaceholderText = "Medicine name"
        Me.txtMedicineName.SelectedText = ""
        Me.txtMedicineName.Size = New System.Drawing.Size(258, 36)
        Me.txtMedicineName.TabIndex = 2
        '
        'txtBprice
        '
        Me.txtBprice.Animated = True
        Me.txtBprice.BackColor = System.Drawing.Color.Transparent
        Me.txtBprice.BorderColor = System.Drawing.Color.Navy
        Me.txtBprice.BorderRadius = 8
        Me.txtBprice.BorderThickness = 2
        Me.txtBprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBprice.DefaultText = ""
        Me.txtBprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBprice.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBprice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBprice.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtBprice.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtBprice.Location = New System.Drawing.Point(26, 231)
        Me.txtBprice.Name = "txtBprice"
        Me.txtBprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBprice.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtBprice.PlaceholderText = "Buying Price"
        Me.txtBprice.SelectedText = ""
        Me.txtBprice.Size = New System.Drawing.Size(258, 36)
        Me.txtBprice.TabIndex = 3
        '
        'txtSprice
        '
        Me.txtSprice.Animated = True
        Me.txtSprice.BackColor = System.Drawing.Color.Transparent
        Me.txtSprice.BorderColor = System.Drawing.Color.Navy
        Me.txtSprice.BorderRadius = 8
        Me.txtSprice.BorderThickness = 2
        Me.txtSprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSprice.DefaultText = ""
        Me.txtSprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSprice.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtSprice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSprice.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtSprice.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtSprice.Location = New System.Drawing.Point(26, 282)
        Me.txtSprice.Name = "txtSprice"
        Me.txtSprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSprice.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtSprice.PlaceholderText = "Selling Price"
        Me.txtSprice.SelectedText = ""
        Me.txtSprice.Size = New System.Drawing.Size(258, 36)
        Me.txtSprice.TabIndex = 4
        '
        'txtQty
        '
        Me.txtQty.Animated = True
        Me.txtQty.BackColor = System.Drawing.Color.Transparent
        Me.txtQty.BorderColor = System.Drawing.Color.Navy
        Me.txtQty.BorderRadius = 8
        Me.txtQty.BorderThickness = 2
        Me.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQty.DefaultText = ""
        Me.txtQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQty.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQty.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtQty.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtQty.Location = New System.Drawing.Point(26, 334)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQty.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtQty.PlaceholderText = "Quantity"
        Me.txtQty.SelectedText = ""
        Me.txtQty.Size = New System.Drawing.Size(258, 36)
        Me.txtQty.TabIndex = 5
        '
        'CompCb
        '
        Me.CompCb.BackColor = System.Drawing.Color.Transparent
        Me.CompCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CompCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompCb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompCb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CompCb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CompCb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CompCb.ItemHeight = 30
        Me.CompCb.Location = New System.Drawing.Point(26, 460)
        Me.CompCb.Name = "CompCb"
        Me.CompCb.Size = New System.Drawing.Size(258, 36)
        Me.CompCb.TabIndex = 6
        '
        'MedicineGV
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.MedicineGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MedicineGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.MedicineGV.ColumnHeadersHeight = 30
        Me.MedicineGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MedicineGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.MedicineGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedicineGV.Location = New System.Drawing.Point(331, 130)
        Me.MedicineGV.Name = "MedicineGV"
        Me.MedicineGV.RowHeadersVisible = False
        Me.MedicineGV.Size = New System.Drawing.Size(527, 403)
        Me.MedicineGV.TabIndex = 7
        Me.MedicineGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.MedicineGV.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.MedicineGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.MedicineGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.MedicineGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.MedicineGV.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.MedicineGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedicineGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedicineGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.MedicineGV.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.MedicineGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.MedicineGV.ThemeStyle.HeaderStyle.Height = 30
        Me.MedicineGV.ThemeStyle.ReadOnly = False
        Me.MedicineGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.MedicineGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.MedicineGV.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MedicineGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.MedicineGV.ThemeStyle.RowsStyle.Height = 22
        Me.MedicineGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MedicineGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnAdd
        '
        Me.btnAdd.Animated = True
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BorderRadius = 12
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.Purple
        Me.btnAdd.FillColor2 = System.Drawing.Color.HotPink
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.HoverState.FillColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.HoverState.FillColor2 = System.Drawing.Color.Green
        Me.btnAdd.Location = New System.Drawing.Point(26, 502)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(82, 31)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        '
        'btnEdit
        '
        Me.btnEdit.Animated = True
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BorderRadius = 12
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.FillColor = System.Drawing.Color.Purple
        Me.btnEdit.FillColor2 = System.Drawing.Color.HotPink
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.HoverState.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnEdit.HoverState.FillColor2 = System.Drawing.Color.Navy
        Me.btnEdit.Location = New System.Drawing.Point(114, 502)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(82, 31)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "Edit"
        '
        'btnDlt
        '
        Me.btnDlt.Animated = True
        Me.btnDlt.BackColor = System.Drawing.Color.Transparent
        Me.btnDlt.BorderRadius = 12
        Me.btnDlt.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDlt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDlt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDlt.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDlt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDlt.FillColor = System.Drawing.Color.Purple
        Me.btnDlt.FillColor2 = System.Drawing.Color.HotPink
        Me.btnDlt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDlt.ForeColor = System.Drawing.Color.White
        Me.btnDlt.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnDlt.HoverState.FillColor2 = System.Drawing.Color.DarkRed
        Me.btnDlt.Location = New System.Drawing.Point(202, 502)
        Me.btnDlt.Name = "btnDlt"
        Me.btnDlt.Size = New System.Drawing.Size(82, 31)
        Me.btnDlt.TabIndex = 10
        Me.btnDlt.Text = "Delete"
        '
        'dateDate
        '
        Me.dateDate.BackColor = System.Drawing.Color.Transparent
        Me.dateDate.BorderColor = System.Drawing.Color.Navy
        Me.dateDate.BorderRadius = 8
        Me.dateDate.BorderThickness = 2
        Me.dateDate.Checked = True
        Me.dateDate.FillColor = System.Drawing.Color.White
        Me.dateDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateDate.Location = New System.Drawing.Point(26, 387)
        Me.dateDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateDate.Name = "dateDate"
        Me.dateDate.Size = New System.Drawing.Size(258, 36)
        Me.dateDate.TabIndex = 11
        Me.dateDate.Value = New Date(2022, 12, 7, 7, 48, 44, 906)
        '
        'PharmacyDbDataSet
        '
        Me.PharmacyDbDataSet.DataSetName = "PharmacyDbDataSet"
        Me.PharmacyDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PharmacyDbDataSetBindingSource
        '
        Me.PharmacyDbDataSetBindingSource.DataSource = Me.PharmacyDbDataSet
        Me.PharmacyDbDataSetBindingSource.Position = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(39, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Select Supplier :"
        '
        'txtMedId
        '
        Me.txtMedId.Animated = True
        Me.txtMedId.BackColor = System.Drawing.Color.Transparent
        Me.txtMedId.BorderColor = System.Drawing.Color.Navy
        Me.txtMedId.BorderRadius = 8
        Me.txtMedId.BorderThickness = 2
        Me.txtMedId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMedId.DefaultText = ""
        Me.txtMedId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMedId.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMedId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMedId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMedId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMedId.FocusedState.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtMedId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMedId.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMedId.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.txtMedId.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtMedId.Location = New System.Drawing.Point(26, 130)
        Me.txtMedId.Name = "txtMedId"
        Me.txtMedId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMedId.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtMedId.PlaceholderText = "Medicine ID"
        Me.txtMedId.SelectedText = ""
        Me.txtMedId.Size = New System.Drawing.Size(258, 36)
        Me.txtMedId.TabIndex = 13
        '
        'Medicine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.pharmacy.My.Resources.Resources._13313271_v870_tang_36
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(897, 552)
        Me.Controls.Add(Me.txtMedId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dateDate)
        Me.Controls.Add(Me.btnDlt)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.MedicineGV)
        Me.Controls.Add(Me.CompCb)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtSprice)
        Me.Controls.Add(Me.txtBprice)
        Me.Controls.Add(Me.txtMedicineName)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Medicine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicine"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmacyDbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MedicineGV As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CompCb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtQty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSprice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBprice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtMedicineName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDlt As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dateDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents PharmacyDbDataSetBindingSource As BindingSource
    Friend WithEvents PharmacyDbDataSet As PharmacyDbDataSet
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMedId As Guna.UI2.WinForms.Guna2TextBox
End Class
