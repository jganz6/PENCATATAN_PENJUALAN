<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPencatatanPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPencatatanPenjualan))
        DataGridViewPenjualan = New DataGridView()
        ColumnItem = New DataGridViewTextBoxColumn()
        ColumnQuantity = New DataGridViewTextBoxColumn()
        ColumnPrice = New DataGridViewTextBoxColumn()
        ColumnTotal = New DataGridViewTextBoxColumn()
        ButtonTambah = New Button()
        TextBoxItem = New TextBox()
        TextBoxQuantity = New TextBox()
        TextBoxPrice = New TextBox()
        ButtonHapus = New Button()
        LabelTotalPrice = New Label()
        LabelTotalPriceQ = New Label()
        GroupBoxDetailTrx = New GroupBox()
        ButtonPrintCst = New Button()
        LabelIdTrxValue = New Label()
        LabelCreatedAtValue = New Label()
        LabelCreatedAt = New Label()
        LabelIdTrx = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        ButtonOpenTrx = New Button()
        LabelFileDirName = New Label()
        ButtonNewTrx = New Button()
        LabePath = New Label()
        GroupBoxTrx = New GroupBox()
        ButtonCloseTrx = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        CType(DataGridViewPenjualan, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxDetailTrx.SuspendLayout()
        GroupBoxTrx.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridViewPenjualan
        ' 
        DataGridViewPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPenjualan.Columns.AddRange(New DataGridViewColumn() {ColumnItem, ColumnQuantity, ColumnPrice, ColumnTotal})
        DataGridViewPenjualan.Location = New Point(18, 75)
        DataGridViewPenjualan.Name = "DataGridViewPenjualan"
        DataGridViewPenjualan.Size = New Size(735, 213)
        DataGridViewPenjualan.TabIndex = 0
        ' 
        ' ColumnItem
        ' 
        ColumnItem.HeaderText = "Item"
        ColumnItem.Name = "ColumnItem"
        ' 
        ' ColumnQuantity
        ' 
        ColumnQuantity.HeaderText = "Quantity"
        ColumnQuantity.Name = "ColumnQuantity"
        ' 
        ' ColumnPrice
        ' 
        ColumnPrice.HeaderText = "Price"
        ColumnPrice.Name = "ColumnPrice"
        ' 
        ' ColumnTotal
        ' 
        ColumnTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        ColumnTotal.HeaderText = "Total"
        ColumnTotal.Name = "ColumnTotal"
        ' 
        ' ButtonTambah
        ' 
        ButtonTambah.BackColor = SystemColors.ActiveCaption
        ButtonTambah.Location = New Point(352, 296)
        ButtonTambah.Name = "ButtonTambah"
        ButtonTambah.Size = New Size(82, 23)
        ButtonTambah.TabIndex = 1
        ButtonTambah.Text = "Tambah"
        ButtonTambah.UseVisualStyleBackColor = False
        ' 
        ' TextBoxItem
        ' 
        TextBoxItem.Location = New Point(18, 296)
        TextBoxItem.Name = "TextBoxItem"
        TextBoxItem.PlaceholderText = "item"
        TextBoxItem.Size = New Size(100, 23)
        TextBoxItem.TabIndex = 2
        ' 
        ' TextBoxQuantity
        ' 
        TextBoxQuantity.Location = New Point(124, 296)
        TextBoxQuantity.Name = "TextBoxQuantity"
        TextBoxQuantity.PlaceholderText = "qty"
        TextBoxQuantity.Size = New Size(100, 23)
        TextBoxQuantity.TabIndex = 3
        ' 
        ' TextBoxPrice
        ' 
        TextBoxPrice.Location = New Point(230, 296)
        TextBoxPrice.Name = "TextBoxPrice"
        TextBoxPrice.PlaceholderText = "price"
        TextBoxPrice.Size = New Size(100, 23)
        TextBoxPrice.TabIndex = 4
        ' 
        ' ButtonHapus
        ' 
        ButtonHapus.BackColor = Color.Red
        ButtonHapus.ForeColor = SystemColors.ButtonHighlight
        ButtonHapus.Location = New Point(18, 333)
        ButtonHapus.Name = "ButtonHapus"
        ButtonHapus.Size = New Size(75, 23)
        ButtonHapus.TabIndex = 5
        ButtonHapus.Text = "Hapus"
        ButtonHapus.UseVisualStyleBackColor = False
        ' 
        ' LabelTotalPrice
        ' 
        LabelTotalPrice.AutoSize = True
        LabelTotalPrice.Font = New Font("Segoe UI", 14F)
        LabelTotalPrice.Location = New Point(539, 291)
        LabelTotalPrice.Name = "LabelTotalPrice"
        LabelTotalPrice.Size = New Size(108, 25)
        LabelTotalPrice.TabIndex = 6
        LabelTotalPrice.Text = "Total Price :"
        ' 
        ' LabelTotalPriceQ
        ' 
        LabelTotalPriceQ.AutoSize = True
        LabelTotalPriceQ.Font = New Font("Segoe UI", 12F)
        LabelTotalPriceQ.Location = New Point(653, 294)
        LabelTotalPriceQ.Name = "LabelTotalPriceQ"
        LabelTotalPriceQ.Size = New Size(19, 21)
        LabelTotalPriceQ.TabIndex = 7
        LabelTotalPriceQ.Text = "0"
        ' 
        ' GroupBoxDetailTrx
        ' 
        GroupBoxDetailTrx.Controls.Add(ButtonPrintCst)
        GroupBoxDetailTrx.Controls.Add(LabelIdTrxValue)
        GroupBoxDetailTrx.Controls.Add(LabelCreatedAtValue)
        GroupBoxDetailTrx.Controls.Add(LabelCreatedAt)
        GroupBoxDetailTrx.Controls.Add(LabelTotalPriceQ)
        GroupBoxDetailTrx.Controls.Add(LabelIdTrx)
        GroupBoxDetailTrx.Controls.Add(LabelTotalPrice)
        GroupBoxDetailTrx.Controls.Add(ButtonHapus)
        GroupBoxDetailTrx.Controls.Add(TextBoxPrice)
        GroupBoxDetailTrx.Controls.Add(TextBoxQuantity)
        GroupBoxDetailTrx.Controls.Add(TextBoxItem)
        GroupBoxDetailTrx.Controls.Add(ButtonTambah)
        GroupBoxDetailTrx.Controls.Add(DataGridViewPenjualan)
        GroupBoxDetailTrx.Location = New Point(12, 169)
        GroupBoxDetailTrx.Name = "GroupBoxDetailTrx"
        GroupBoxDetailTrx.Size = New Size(776, 373)
        GroupBoxDetailTrx.TabIndex = 9
        GroupBoxDetailTrx.TabStop = False
        GroupBoxDetailTrx.Text = "Detail Transaction"
        GroupBoxDetailTrx.Visible = False
        ' 
        ' ButtonPrintCst
        ' 
        ButtonPrintCst.BackColor = SystemColors.ActiveCaption
        ButtonPrintCst.Location = New Point(678, 333)
        ButtonPrintCst.Name = "ButtonPrintCst"
        ButtonPrintCst.Size = New Size(75, 23)
        ButtonPrintCst.TabIndex = 13
        ButtonPrintCst.Text = "Print"
        ButtonPrintCst.UseVisualStyleBackColor = False
        ' 
        ' LabelIdTrxValue
        ' 
        LabelIdTrxValue.AutoSize = True
        LabelIdTrxValue.Location = New Point(63, 37)
        LabelIdTrxValue.Name = "LabelIdTrxValue"
        LabelIdTrxValue.Size = New Size(12, 15)
        LabelIdTrxValue.TabIndex = 12
        LabelIdTrxValue.Text = "-"
        ' 
        ' LabelCreatedAtValue
        ' 
        LabelCreatedAtValue.AutoSize = True
        LabelCreatedAtValue.Location = New Point(625, 37)
        LabelCreatedAtValue.Name = "LabelCreatedAtValue"
        LabelCreatedAtValue.Size = New Size(12, 15)
        LabelCreatedAtValue.TabIndex = 11
        LabelCreatedAtValue.Text = "-"
        ' 
        ' LabelCreatedAt
        ' 
        LabelCreatedAt.AutoSize = True
        LabelCreatedAt.Font = New Font("Segoe UI", 10F)
        LabelCreatedAt.Location = New Point(538, 33)
        LabelCreatedAt.Name = "LabelCreatedAt"
        LabelCreatedAt.Size = New Size(86, 19)
        LabelCreatedAt.TabIndex = 10
        LabelCreatedAt.Text = "Created At : "
        ' 
        ' LabelIdTrx
        ' 
        LabelIdTrx.AutoSize = True
        LabelIdTrx.Font = New Font("Segoe UI", 10F)
        LabelIdTrx.Location = New Point(27, 33)
        LabelIdTrx.Name = "LabelIdTrx"
        LabelIdTrx.Size = New Size(30, 19)
        LabelIdTrx.TabIndex = 4
        LabelIdTrx.Text = "ID :"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.InitialDirectory = "C:\JenieWorkStation\DATA_TRANSAKSI_PROGVISUAL_UAS"
        ' 
        ' FolderBrowserDialog1
        ' 
        FolderBrowserDialog1.InitialDirectory = "C:\JenieWorkStation\DATA_TRANSAKSI_PROGVISUAL_UAS"
        ' 
        ' ButtonOpenTrx
        ' 
        ButtonOpenTrx.BackColor = SystemColors.ActiveCaption
        ButtonOpenTrx.Font = New Font("Segoe UI", 10F)
        ButtonOpenTrx.Location = New Point(27, 55)
        ButtonOpenTrx.Name = "ButtonOpenTrx"
        ButtonOpenTrx.Size = New Size(92, 31)
        ButtonOpenTrx.TabIndex = 0
        ButtonOpenTrx.Text = "Select File"
        ButtonOpenTrx.UseVisualStyleBackColor = False
        ' 
        ' LabelFileDirName
        ' 
        LabelFileDirName.AutoSize = True
        LabelFileDirName.BackColor = SystemColors.AppWorkspace
        LabelFileDirName.Font = New Font("Segoe UI", 9F)
        LabelFileDirName.Location = New Point(70, 28)
        LabelFileDirName.Name = "LabelFileDirName"
        LabelFileDirName.Size = New Size(0, 15)
        LabelFileDirName.TabIndex = 1
        ' 
        ' ButtonNewTrx
        ' 
        ButtonNewTrx.BackColor = SystemColors.ActiveCaption
        ButtonNewTrx.Font = New Font("Segoe UI", 10F)
        ButtonNewTrx.Location = New Point(125, 55)
        ButtonNewTrx.Name = "ButtonNewTrx"
        ButtonNewTrx.Size = New Size(100, 31)
        ButtonNewTrx.TabIndex = 2
        ButtonNewTrx.Text = "New"
        ButtonNewTrx.UseVisualStyleBackColor = False
        ' 
        ' LabePath
        ' 
        LabePath.AutoSize = True
        LabePath.Font = New Font("Segoe UI", 9F)
        LabePath.Location = New Point(27, 28)
        LabePath.Name = "LabePath"
        LabePath.Size = New Size(37, 15)
        LabePath.TabIndex = 3
        LabePath.Text = "Path :"
        ' 
        ' GroupBoxTrx
        ' 
        GroupBoxTrx.Controls.Add(ButtonCloseTrx)
        GroupBoxTrx.Controls.Add(LabePath)
        GroupBoxTrx.Controls.Add(ButtonNewTrx)
        GroupBoxTrx.Controls.Add(LabelFileDirName)
        GroupBoxTrx.Controls.Add(ButtonOpenTrx)
        GroupBoxTrx.Font = New Font("Segoe UI", 14F)
        GroupBoxTrx.ForeColor = SystemColors.ControlText
        GroupBoxTrx.Location = New Point(12, 12)
        GroupBoxTrx.Name = "GroupBoxTrx"
        GroupBoxTrx.Size = New Size(776, 132)
        GroupBoxTrx.TabIndex = 8
        GroupBoxTrx.TabStop = False
        GroupBoxTrx.Text = "Transaction"
        ' 
        ' ButtonCloseTrx
        ' 
        ButtonCloseTrx.BackColor = Color.Red
        ButtonCloseTrx.Enabled = False
        ButtonCloseTrx.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonCloseTrx.ForeColor = SystemColors.ButtonFace
        ButtonCloseTrx.Location = New Point(30, 92)
        ButtonCloseTrx.Name = "ButtonCloseTrx"
        ButtonCloseTrx.Size = New Size(88, 32)
        ButtonCloseTrx.TabIndex = 4
        ButtonCloseTrx.Text = "Close File"
        ButtonCloseTrx.UseVisualStyleBackColor = False
        ButtonCloseTrx.Visible = False
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' FormPencatatanPenjualan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 554)
        Controls.Add(GroupBoxDetailTrx)
        Controls.Add(GroupBoxTrx)
        Name = "FormPencatatanPenjualan"
        Text = "Form Pencatatan Penjualan"
        CType(DataGridViewPenjualan, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxDetailTrx.ResumeLayout(False)
        GroupBoxDetailTrx.PerformLayout()
        GroupBoxTrx.ResumeLayout(False)
        GroupBoxTrx.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridViewPenjualan As DataGridView
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents TextBoxItem As TextBox
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents ButtonHapus As Button
    Friend WithEvents ColumnItem As DataGridViewTextBoxColumn
    Friend WithEvents ColumnQuantity As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrice As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTotal As DataGridViewTextBoxColumn
    Friend WithEvents LabelTotalPrice As Label
    Friend WithEvents LabelTotalPriceQ As Label
    Friend WithEvents GroupBoxDetailTrx As GroupBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents LabelIdTrx As Label
    Friend WithEvents LabelCreatedAt As Label
    Friend WithEvents LabelIdTrxValue As Label
    Friend WithEvents LabelCreatedAtValue As Label
    Friend WithEvents ButtonOpenTrx As Button
    Friend WithEvents LabelFileDirName As Label
    Friend WithEvents ButtonNewTrx As Button
    Friend WithEvents LabePath As Label
    Friend WithEvents GroupBoxTrx As GroupBox
    Friend WithEvents ButtonCloseTrx As Button
    Friend WithEvents ButtonPrintCst As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog

End Class
