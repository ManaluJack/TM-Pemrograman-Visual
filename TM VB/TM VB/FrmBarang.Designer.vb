﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBarang
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblbarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBPenjualanDataSet = New TM_VB.DBPenjualanDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnolahdata = New System.Windows.Forms.Button()
        Me.Tbl_barangTableAdapter = New TM_VB.DBPenjualanDataSetTableAdapters.tbl_barangTableAdapter()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnfist = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBPenjualanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Baskerville Old Face", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(969, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data Barang"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Baskerville Old Face", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(213, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(897, 396)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 130
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jenis Barang"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.HeaderText = "Satuan"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Harga Beli"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 120
        '
        'Column6
        '
        Me.Column6.HeaderText = "Harga Jual"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 120
        '
        'Column7
        '
        Me.Column7.HeaderText = "Stock"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 80
        '
        'TblbarangBindingSource
        '
        Me.TblbarangBindingSource.DataMember = "tbl_barang"
        Me.TblbarangBindingSource.DataSource = Me.DBPenjualanDataSet
        '
        'DBPenjualanDataSet
        '
        Me.DBPenjualanDataSet.DataSetName = "DBPenjualanDataSet"
        Me.DBPenjualanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(225, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cari"
        '
        'txtcari
        '
        Me.txtcari.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcari.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.Location = New System.Drawing.Point(293, 190)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(604, 26)
        Me.txtcari.TabIndex = 8
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnclose.Location = New System.Drawing.Point(978, 641)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(132, 36)
        Me.btnclose.TabIndex = 14
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btnolahdata
        '
        Me.btnolahdata.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnolahdata.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnolahdata.Font = New System.Drawing.Font("Baskerville Old Face", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnolahdata.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnolahdata.Location = New System.Drawing.Point(833, 641)
        Me.btnolahdata.Name = "btnolahdata"
        Me.btnolahdata.Size = New System.Drawing.Size(132, 36)
        Me.btnolahdata.TabIndex = 13
        Me.btnolahdata.Text = "Olah Data"
        Me.btnolahdata.UseVisualStyleBackColor = False
        '
        'Tbl_barangTableAdapter
        '
        Me.Tbl_barangTableAdapter.ClearBeforeFill = True
        '
        'btnnext
        '
        Me.btnnext.BackgroundImage = Global.TM_VB.My.Resources.Resources.Warna
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnext.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnnext.Location = New System.Drawing.Point(256, 15)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(75, 36)
        Me.btnnext.TabIndex = 11
        Me.btnnext.Text = "Next>"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.BackgroundImage = Global.TM_VB.My.Resources.Resources.Warna
        Me.btnprev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprev.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprev.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnprev.Location = New System.Drawing.Point(144, 15)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(75, 36)
        Me.btnprev.TabIndex = 10
        Me.btnprev.Text = "<Prev"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnfist
        '
        Me.btnfist.BackgroundImage = Global.TM_VB.My.Resources.Resources.Warna
        Me.btnfist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfist.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfist.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnfist.Location = New System.Drawing.Point(32, 15)
        Me.btnfist.Name = "btnfist"
        Me.btnfist.Size = New System.Drawing.Size(75, 36)
        Me.btnfist.TabIndex = 9
        Me.btnfist.Text = "|<First"
        Me.btnfist.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.BackgroundImage = Global.TM_VB.My.Resources.Resources.Warna
        Me.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlast.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnlast.Location = New System.Drawing.Point(368, 15)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(75, 36)
        Me.btnlast.TabIndex = 12
        Me.btnlast.Text = "Last>|"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.btnlast)
        Me.Panel1.Controls.Add(Me.btnfist)
        Me.Panel1.Controls.Add(Me.btnprev)
        Me.Panel1.Controls.Add(Me.btnnext)
        Me.Panel1.Location = New System.Drawing.Point(268, 628)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 64)
        Me.Panel1.TabIndex = 15
        '
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TM_VB.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1302, 781)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnolahdata)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBarang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBPenjualanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcari As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents btnclose As Button
    Friend WithEvents btnolahdata As Button
    Friend WithEvents DBPenjualanDataSet As DBPenjualanDataSet
    Friend WithEvents TblbarangBindingSource As BindingSource
    Friend WithEvents Tbl_barangTableAdapter As DBPenjualanDataSetTableAdapters.tbl_barangTableAdapter
    Friend WithEvents btnnext As Button
    Friend WithEvents btnprev As Button
    Friend WithEvents btnfist As Button
    Friend WithEvents btnlast As Button
    Friend WithEvents Panel1 As Panel
End Class
