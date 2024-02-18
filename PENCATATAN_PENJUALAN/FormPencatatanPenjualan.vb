Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml

Public Class FormPencatatanPenjualan
    Dim pathNew As String = ""

    Private Sub ButtonCloseTrxVisible(cond As Boolean)
        ButtonCloseTrx.Visible = cond
        ButtonCloseTrx.Enabled = cond
    End Sub

    Private Sub ControlGroupBoxDetailTrxVisibility(cond As Boolean)
        GroupBoxDetailTrx.Visible = cond
        GroupBoxDetailTrx.Enabled = cond
    End Sub

    Private Sub CleanCurrentFileTrx()
        pathNew = ""
        LabelFileDirName.Text = ""
        LabelCreatedAtValue.Text = "-"
        LabelIdTrxValue.Text = "-"
        ControlGroupBoxDetailTrxVisibility(False)
    End Sub
    Private Sub LoadData()
        If pathNew <> "" And File.Exists(pathNew) Then
            ControlGroupBoxDetailTrxVisibility(True)
            ButtonCloseTrxVisible(True)
            DataGridViewPenjualan.Rows.Clear()
            Using reader As StreamReader = New StreamReader(pathNew)
                Dim totalPrice As Integer = 0
                Do While reader.Peek() >= 0
                    Dim line As String = reader.ReadLine()
                    Dim data As String() = line.Split(","c)
                    Dim totalRowsPrice = Convert.ToInt64(data(1)) * Convert.ToInt64(data(2))
                    ReDim Preserve data(data.Length) ' Increase the size by 1
                    totalPrice += totalRowsPrice
                    data(data.Length - 1) = totalRowsPrice.ToString()
                    DataGridViewPenjualan.Rows.Add(data)
                Loop
                LabelTotalPriceQ.Text = totalPrice
            End Using
        Else
            ControlGroupBoxDetailTrxVisibility(False)
            ButtonCloseTrxVisible(False)
        End If
    End Sub

    Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        Dim newItem As String = TextBoxItem.Text.Trim()
        Dim newQuantity As String = TextBoxQuantity.Text.Trim()
        Dim newPrice As String = TextBoxPrice.Text.Trim()

        If Not String.IsNullOrEmpty(newItem) AndAlso Not String.IsNullOrEmpty(newQuantity) AndAlso Not String.IsNullOrEmpty(newPrice) Then
            Using writer As StreamWriter = New StreamWriter(pathNew, True)
                writer.WriteLine($"{newItem},{newQuantity},{newPrice}")
            End Using
            TextBoxItem.Clear()
            TextBoxQuantity.Clear()
            TextBoxPrice.Clear()
            LoadData()
        Else
            MessageBox.Show("Silakan masukkan item, kuantitas, dan harga terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        If DataGridViewPenjualan.SelectedRows.Count > 0 Then
            Dim selectedIndex As Integer = DataGridViewPenjualan.SelectedRows(0).Index

            Dim lines As List(Of String) = File.ReadAllLines(pathNew).ToList()
            lines.RemoveAt(selectedIndex)
            File.WriteAllLines(pathNew, lines)
            LoadData()
        Else
            MessageBox.Show("Silakan pilih catatan penjualan yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ButtonOpenTrx_Click(sender As Object, e As EventArgs) Handles ButtonOpenTrx.Click
        OpenFileDialog1.Filter = "TEXT FILE | *.txt"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            LabelFileDirName.Text = OpenFileDialog1.FileName
            pathNew = OpenFileDialog1.FileName
            LabelCreatedAtValue.Text = GetCreatedTime_FromFile(pathNew)
            LabelIdTrxValue.Text = Path.GetFileNameWithoutExtension(pathNew)
            LoadData()
        End If
    End Sub

    Private Sub ButtonNewTrx_Click(sender As Object, e As EventArgs) Handles ButtonNewTrx.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            Dim uuidNew As Guid = Guid.NewGuid()
            pathNew = FolderBrowserDialog1.SelectedPath + "\" + uuidNew.ToString() + ".txt"
            LabelFileDirName.Text = pathNew
            File.Create(pathNew).Close()
            LabelCreatedAtValue.Text = GetCreatedTime_FromFile(pathNew)
            LabelIdTrxValue.Text = Path.GetFileNameWithoutExtension(pathNew)
            LoadData()
        End If
    End Sub
    Private Function GetCreatedTime_FromFile(ByVal path As String) As String
        Dim fileCreatedDate As DateTime = File.GetCreationTime(path)

        Return fileCreatedDate.ToString()
    End Function

    Private Sub ButtonCloseTrx_Click(sender As Object, e As EventArgs) Handles ButtonCloseTrx.Click
        ButtonCloseTrxVisible(False)
        CleanCurrentFileTrx()
    End Sub

    Private Sub ButtonPrintCst_Click(sender As Object, e As EventArgs) Handles ButtonPrintCst.Click
        Dim printDialog As New PrintDialog()
        If printDialog.ShowDialog() = DialogResult.OK Then
            ' Set the PrintDocument for printing
            PrintDocument1.PrinterSettings = printDialog.PrinterSettings
            ' Subscribe to the PrintPage event
            AddHandler PrintDocument1.PrintPage, AddressOf PrintPageHandler
            If PrintPreviewDialog1.ShowDialog() = DialogResult.OK Then
                ' Start printing
                PrintDocument1.Print()
            End If
            ' Unsubscribe from the PrintPage event
            RemoveHandler PrintDocument1.PrintPage, AddressOf PrintPageHandler
        End If
    End Sub

    Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
        Dim bm As New Bitmap(Me.DataGridViewPenjualan.Width, Me.DataGridViewPenjualan.Height)
        DataGridViewPenjualan.DrawToBitmap(bm, New Rectangle(30, 30, Me.DataGridViewPenjualan.Width, Me.DataGridViewPenjualan.Height))

        ' Font for the table
        Dim font As New Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point)
        ' Margin and padding
        Dim margin As Integer = 40
        Dim padding As Integer = 5
        ' Line height
        Dim lineHeight As Integer = font.Height + padding

        ' Coordinates for drawing
        Dim x As Single = margin
        Dim y As Single = margin


        ' Draw headers
        Dim IdTrxText As String = "ID : " + LabelIdTrxValue.Text
        Dim TimeStamptzTrxText As String = "Created At : " + LabelCreatedAtValue.Text
        Dim TotalTrxText As String = "Total Price : " + LabelTotalPriceQ.Text
        e.Graphics.DrawString(IdTrxText, font, Brushes.Black, x, y)
        y += lineHeight
        x = margin
        e.Graphics.DrawString(TimeStamptzTrxText, font, Brushes.Black, x, y)
        y += lineHeight
        x = margin
        e.Graphics.DrawString(TotalTrxText, font, Brushes.Black, x, y)

        ' Draw data
        y += lineHeight
        e.Graphics.DrawImage(bm, x, y)
        y += DataGridViewPenjualan.Height + lineHeight

        ' Check if another page is needed
        If y + lineHeight < e.MarginBounds.Bottom Then
            e.HasMorePages = False
        Else
            e.HasMorePages = True
        End If
    End Sub
End Class
