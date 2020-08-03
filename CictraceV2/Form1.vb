Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1
    Private Const saveAllTrack As String = "http://e.cictrace.com/ent.ashx?method=SaveAllTrack"
    Dim arrReportPath As String() = New String(5) {}
    Dim arrOrderNo As ArrayList = New ArrayList
    Dim GPluNo() As String = {"4712086216701", "4712086216702", "4712086216703", "4712086216704"} '國際條碼

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        While (DGV.CurrentCell.RowIndex + 1) < DGV.Rows.Count
            '傳送出口訊息
            Dim arrProp As List(Of Prop) = New List(Of Prop) '生產履歷內容
            arrProp.Add(New Prop With {._Property = "生產者姓名", .Value = DGV.CurrentRow.Cells("SName").Value})
            arrProp.Add(New Prop With {._Property = "生產組織", .Value = "卑南鄉番荔枝產銷班" & DGV.CurrentRow.Cells("CNo").Value & "班"})
            arrProp.Add(New Prop With {._Property = "產地", .Value = "台灣台東縣卑南鄉古民段新民小段"})
            arrProp.Add(New Prop With {._Property = "栽培面積", .Value = "2.7407公頃"})
            arrProp.Add(New Prop With {._Property = "採收日期", .Value = DGV.CurrentRow.Cells("ShipDate").Value})
            arrProp.Add(New Prop With {._Property = "包裝日期", .Value = DGV.CurrentRow.Cells("ShipDate").Value})
            arrProp.Add(New Prop With {._Property = "驗證機構", .Value = "中國檢驗有限公司 / 香港商中檢實業有限公司台灣分公司"})
            arrProp.Add(New Prop With {._Property = "果園註冊號碼", .Value = DGV.CurrentRow.Cells("SNo").Value})
            Dim arrProp2 As List(Of Prop) = New List(Of Prop) '商品物流信息
            arrProp2.Add(New Prop With {._Property = "出口商名稱", .Value = "長辰股份有限公司"})
            arrProp2.Add(New Prop With {._Property = "出口商地址", .Value = "台灣新北市新莊市富國路66巷2號"})
            arrProp2.Add(New Prop With {._Property = "收貨人", .Value = "SHENZHEN XILAITONG COMMERCIAL TRADE CO.,LTD."})
            arrProp2.Add(New Prop With {._Property = "出發港", .Value = "台灣高雄"})
            arrProp2.Add(New Prop With {._Property = "目的港", .Value = "香港"})
            arrProp2.Add(New Prop With {._Property = "運輸方式", .Value = "船舶/陸運"})
            Dim arrTracks As List(Of Tracks) = New List(Of Tracks) '標題
            arrTracks.Add(New Tracks With {.TrackName = "生產履歷", .prop = arrProp, .AuditFlag = True})
            arrTracks.Add(New Tracks With {.TrackName = "商品物流信息", .prop = arrProp2, .AuditFlag = True})
            Dim orderDetail As OrderDetail
            Select Case DGV.CurrentRow.Cells("CNo").Value
                Case "35"
                    orderDetail = New OrderDetail With {.OrderNo = DGV.CurrentRow.Cells("OrderId").Value, .GPluNo = GPluNo(0), .tracks = arrTracks}
                Case "36"
                    orderDetail = New OrderDetail With {.OrderNo = DGV.CurrentRow.Cells("OrderId").Value, .GPluNo = GPluNo(1), .tracks = arrTracks}
                Case "39"
                    orderDetail = New OrderDetail With {.OrderNo = DGV.CurrentRow.Cells("OrderId").Value, .GPluNo = GPluNo(2), .tracks = arrTracks}
                Case "41"
                    orderDetail = New OrderDetail With {.OrderNo = DGV.CurrentRow.Cells("OrderId").Value, .GPluNo = GPluNo(3), .tracks = arrTracks}
                Case Else
                    orderDetail = Nothing
            End Select
            If arrOrderNo.IndexOf(orderDetail.OrderNo) = -1 Then '若執行訂單號有重複則不再執行上傳證明文件及傳送出口訊息
                Dim strJson As String = JsonConvert.SerializeObject(orderDetail)
                strJson = strJson.Replace("_Property", "Property")
                Dim request As HttpWebRequest = WebRequest.Create(saveAllTrack)
                request.Method = "POST"
                request.Headers("Token") = "44b22a3b12ff0d3590362c416d618527"
                request.ContentType = "application/json;charset=UTF-8"
                Dim streamWriter As StreamWriter = New StreamWriter(request.GetRequestStream())
                streamWriter.Write(strJson)
                streamWriter.Flush()
                streamWriter.Close()
                Dim response As HttpWebResponse = request.GetResponse()
                Dim streamReader As StreamReader = New StreamReader(response.GetResponseStream)
                Dim result As Result = JsonConvert.DeserializeObject(Of Result)(streamReader.ReadToEnd)
                If result.Success Then
                    DGV.CurrentRow.Cells("Result").Value = "報告✔ "
                Else
                    DGV.CurrentRow.Cells("Result").Value = "報告✘ :" & result.ErrorMessage
                End If

                Application.DoEvents()
                '上傳證明文件
                If arrReportPath(0) <> Nothing Then
                    DGV.CurrentRow.Cells("Result").Value += HttpPostData(orderDetail.OrderNo, orderDetail.GPluNo, "CICTW證書", arrReportPath(0))
                    Application.DoEvents()
                End If
                If arrReportPath(1) <> Nothing Then
                    DGV.CurrentRow.Cells("Result").Value += HttpPostData(orderDetail.OrderNo, orderDetail.GPluNo, "報告一", arrReportPath(1))
                    Application.DoEvents()
                End If
                If arrReportPath(2) <> Nothing Then
                    DGV.CurrentRow.Cells("Result").Value += HttpPostData(orderDetail.OrderNo, orderDetail.GPluNo, "報告二", arrReportPath(2))
                    Application.DoEvents()
                End If
                If arrReportPath(3) <> Nothing Then
                    DGV.CurrentRow.Cells("Result").Value += HttpPostData(orderDetail.OrderNo, orderDetail.GPluNo, "報告三", arrReportPath(3))
                    Application.DoEvents()
                End If
                If arrReportPath(4) <> Nothing Then
                    DGV.CurrentRow.Cells("Result").Value += HttpPostData(orderDetail.OrderNo, orderDetail.GPluNo, "報告四", arrReportPath(4))
                    Application.DoEvents()
                End If
                If arrReportPath(5) <> Nothing Then
                    If DGV.CurrentRow.Cells("TGAP").Value <> "" Then
                        DGV.CurrentRow.Cells("Result").Value += HttpPostData(orderDetail.OrderNo, orderDetail.GPluNo, "報告五", arrReportPath(5))
                    End If
                    Application.DoEvents()
                End If
                arrOrderNo.Add(orderDetail.OrderNo)
                Else
                    DGV.CurrentRow.Cells("Result").Value = "重複訂單號，忽略執行上傳文件及出口訊息"
            End If
            '激活號碼
            DGV.CurrentRow.Cells("Result").Value += TrackNoAdd(orderDetail, DGV.CurrentRow.Cells("StartNo").Value, DGV.CurrentRow.Cells("EndNo").Value)
            If (DGV.CurrentCell.RowIndex + 1) < DGV.Rows.Count Then
                DGV.CurrentCell = DGV(0, DGV.CurrentRow.Index + 1)
            Else
                Exit While
            End If
            Application.DoEvents()
        End While
    End Sub
    Private Sub DGV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV.KeyPress
        If AscW(e.KeyChar) <> 22 Then
            Return
        End If
        PasteClipboard(DGV)
    End Sub
    Private Sub PasteClipboard(dataGridView As DataGridView)
        Dim strClipboard As String = Clipboard.GetText()
        Dim arrData As String() = strClipboard.Split(vbCrLf)
        Dim intCurrentRow As Integer = dataGridView.CurrentCell.RowIndex
        Dim intCurrentCol As Integer = dataGridView.CurrentCell.ColumnIndex
        Dim intRowCount As Integer = dataGridView.Rows.Count
        If arrData.Length >= intRowCount - intCurrentRow Then
            dataGridView.Rows.Add(arrData.Length - (intRowCount - intCurrentRow) + 1)
        End If
        For Each data As String In arrData
            Dim arrCells As String() = data.Split(vbTab)
            For i As Integer = 0 To arrCells.Length - 1
                arrCells(i) = arrCells(i).Replace(vbLf, "")
                dataGridView(i, intCurrentRow).Value = arrCells(i)
            Next
            intCurrentRow += 1
        Next
    End Sub

    Public Function HttpPostData(ByVal orderNo As String, ByVal GPluNo As String, ByVal fileName As String, ByVal filePath As String) As String
        Dim strUrl As String = "http://e.cictrace.com/ent.ashx?method=AddDocument&OrderNo={0}&GPluNo={1}&GroupName=普通佐证&DocumentName={2}&PublishFlag=1"
        Dim strBoundary As String = "-------------------------acebdf13572468"
        Dim fileStream As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read)
        Dim buffer() As Byte = New Byte(fileStream.Length) {}
        Dim bytesRead = 0
        Dim sb As StringBuilder = New StringBuilder
        Dim ms As MemoryStream = New MemoryStream
        Dim bw As BinaryWriter = New BinaryWriter(ms)
        strUrl = String.Format(strUrl, orderNo, GPluNo, fileName)
        sb.AppendLine("--" + strBoundary)
        sb.AppendLine("Content-Disposition: form-data;name=""FileData""; filename=""" & fileName & ".jpg""")
        sb.AppendLine("Content-Type: image/jpeg")
        sb.Append(Environment.NewLine)
        bw.Write(Encoding.UTF8.GetBytes(sb.ToString()))
        fileStream.Read(buffer, 0, buffer.Length)
        bw.Write(buffer)
        bw.Write(Encoding.UTF8.GetBytes(Environment.NewLine))
        bw.Write(Encoding.UTF8.GetBytes("--" + strBoundary))
        ms.Flush()
        ms.Position = 0
        Dim result As Byte() = ms.ToArray
        bw.Close()
        fileStream.Close()
        Dim request As HttpWebRequest = WebRequest.Create(strUrl)
        request.Method = "POST"
        request.Headers("Token") = "44b22a3b12ff0d3590362c416d618527"
        request.ContentType = "multipart/form-data; boundary=-------------------------acebdf13572468"
        Dim bw2 As BinaryWriter = New BinaryWriter(request.GetRequestStream)
        bw2.Write(result)
        bw2.Close()
        Dim response As HttpWebResponse = request.GetResponse()
        Dim streamReader As StreamReader = New StreamReader(response.GetResponseStream)
        Dim returnData As Result = JsonConvert.DeserializeObject(Of Result)(streamReader.ReadToEnd)
        response.Close()
        streamReader.Close()
        If returnData.Success Then
            Return fileName & "✔"
        Else
            Return fileName & "✘:" & returnData.ErrorMessage
        End If

    End Function
    Public Function TrackNoAdd(ByVal orderDetail As OrderDetail, ByVal startNo As String, ByVal endNo As String) As String
        Dim strAddUrl As String = "http://e.cictrace.com/ent.ashx?method=TrackNoAdd"
        Dim strActiveUrl As String = "http://e.cictrace.com/ent.ashx?method=TrackNoActive"
        Dim trackNo As TrackNo = New TrackNo With {.OrderNo = orderDetail.OrderNo, .GPluNo = orderDetail.GPluNo, .StartNo = startNo, .EndNo = endNo}
        Dim strJson As String = JsonConvert.SerializeObject(trackNo)
        Dim request As HttpWebRequest = WebRequest.Create(strAddUrl)
        request.Method = "POST"
        request.Headers("Token") = "44b22a3b12ff0d3590362c416d618527"
        request.ContentType = "application/json;charset=UTF-8"
        Dim streamWriter As StreamWriter = New StreamWriter(request.GetRequestStream())
        streamWriter.Write(strJson)
        streamWriter.Flush()
        streamWriter.Close()
        Dim response As HttpWebResponse = request.GetResponse()
        Dim streamReader As StreamReader = New StreamReader(response.GetResponseStream)
        Dim result As Result = JsonConvert.DeserializeObject(Of Result)(streamReader.ReadToEnd)
        response.Close()
        If result.Success = False Then
            Return "激活號碼✘:" & result.ErrorMessage
        Else
            request = WebRequest.Create(strActiveUrl)
            request.Method = "POST"
            request.Headers("Token") = "44b22a3b12ff0d3590362c416d618527"
            request.ContentType = "application/json;charset=UTF-8"
            streamWriter = New StreamWriter(request.GetRequestStream())
            streamWriter.Write(strJson)
            streamWriter.Flush()
            streamWriter.Close()
            response = request.GetResponse()
            streamReader = New StreamReader(response.GetResponseStream)
            result = JsonConvert.DeserializeObject(Of Result)(streamReader.ReadToEnd)
            response.Close()
        End If
        Return "激活號碼✔"
    End Function

    Private Sub ReportBtn1_Click(sender As Object, e As EventArgs) Handles ReportBtn1.Click
        Dim fileBrowser As OpenFileDialog = New OpenFileDialog
        fileBrowser.Filter = "圖片檔(*.jpg)|*.jpg"
        If fileBrowser.ShowDialog = DialogResult.OK Then
            ReporText1.Text = "CICTW證書:" & fileBrowser.FileName
            arrReportPath(0) = fileBrowser.FileName
        End If
    End Sub

    Private Sub ReportBtn2_Click(sender As Object, e As EventArgs) Handles ReportBtn2.Click
        Dim fileBrowser As OpenFileDialog = New OpenFileDialog
        fileBrowser.Filter = "圖片檔(*.jpg)|*.jpg"
        If fileBrowser.ShowDialog = DialogResult.OK Then
            ReporText2.Text = "報告一:" & fileBrowser.FileName
            arrReportPath(1) = fileBrowser.FileName
        End If
    End Sub

    Private Sub ReportBtn3_Click(sender As Object, e As EventArgs) Handles ReportBtn3.Click
        Dim fileBrowser As OpenFileDialog = New OpenFileDialog
        fileBrowser.Filter = "圖片檔(*.jpg)|*.jpg"
        If fileBrowser.ShowDialog = DialogResult.OK Then
            ReporText3.Text = "報告二:" & fileBrowser.FileName
            arrReportPath(2) = fileBrowser.FileName
        End If
    End Sub

    Private Sub ReportBtn4_Click(sender As Object, e As EventArgs) Handles ReportBtn4.Click
        Dim fileBrowser As OpenFileDialog = New OpenFileDialog
        fileBrowser.Filter = "圖片檔(*.jpg)|*.jpg"
        If fileBrowser.ShowDialog = DialogResult.OK Then
            ReporText4.Text = "報告三:" & fileBrowser.FileName
            arrReportPath(3) = fileBrowser.FileName
        End If
    End Sub

    Private Sub ReportBtn5_Click(sender As Object, e As EventArgs) Handles ReportBtn5.Click
        Dim fileBrowser As OpenFileDialog = New OpenFileDialog
        fileBrowser.Filter = "圖片檔(*.jpg)|*.jpg"
        If fileBrowser.ShowDialog = DialogResult.OK Then
            ReporText5.Text = "報告四:" & fileBrowser.FileName
            arrReportPath(4) = fileBrowser.FileName
        End If
    End Sub

    Private Sub ReportBtn6_Click(sender As Object, e As EventArgs) Handles ReportBtn6.Click
        Dim fileBrowser As OpenFileDialog = New OpenFileDialog
        fileBrowser.Filter = "圖片檔(*.jpg)|*.jpg"
        If fileBrowser.ShowDialog = DialogResult.OK Then
            ReporText6.Text = "報告五:" & fileBrowser.FileName
            arrReportPath(5) = fileBrowser.FileName
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim orderDetail As OrderDetail
        Select Case DGV.CurrentRow.Cells("CNo").Value
            Case "35"
                orderDetail = New OrderDetail With {.OrderNo = DGV.CurrentRow.Cells("OrderId").Value, .GPluNo = GPluNo(0), .tracks = Nothing}
            Case "36"
                orderDetail = New OrderDetail With {.OrderNo = DGV.CurrentRow.Cells("OrderId").Value, .GPluNo = GPluNo(1), .tracks = Nothing}
            Case "39"
                orderDetail = New OrderDetail With {.OrderNo = DGV.CurrentRow.Cells("OrderId").Value, .GPluNo = GPluNo(2), .tracks = Nothing}
            Case "41"
                orderDetail = New OrderDetail With {.OrderNo = DGV.CurrentRow.Cells("OrderId").Value, .GPluNo = GPluNo(3), .tracks = Nothing}
            Case Else
                orderDetail = Nothing
        End Select
        DGV.CurrentRow.Cells("Result").Value += TrackNoAdd(orderDetail, DGV.CurrentRow.Cells("StartNo").Value, DGV.CurrentRow.Cells("EndNo").Value)
        If (DGV.CurrentCell.RowIndex + 1) < DGV.Rows.Count Then
            DGV.CurrentCell = DGV(0, DGV.CurrentRow.Index + 1)
        End If
        Application.DoEvents()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim folderBrowser As FolderBrowserDialog = New FolderBrowserDialog
        Dim strCert As String = Nothing
        Dim arrReport As ArrayList = New ArrayList
        Dim arrReportLabel As Label() = {ReporText2, ReporText3, ReporText4, ReporText5, ReporText6}
        Dim arrReportName As String() = {"報告一:", "報告二:", "報告三:", "報告四:", "報告五:"}
        folderBrowser.SelectedPath = "\\Ds916\17.市場業務\市場業務\長辰"
        If folderBrowser.ShowDialog = DialogResult.OK Then
            For Each filetmp As String In My.Computer.FileSystem.GetFiles(folderBrowser.SelectedPath)
                If filetmp.Contains("證書") Then
                    strCert = filetmp
                ElseIf filetmp.Contains("報告") Then
                    arrReport.Add(filetmp)
                End If
            Next
            If strCert <> Nothing Then
                ReporText1.Text = "CICTW證書:" & folderBrowser.SelectedPath & strCert
                arrReportPath(0) = strCert
            End If
            Dim i As Integer = 0
            For Each strReport As String In arrReport
                arrReportLabel(i).Text = arrReportName(i) & strReport
                arrReportPath(i + 1) = strReport
                i += 1
            Next
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim strUrl As String = "https://agridata.coa.gov.tw/api/v1/ProductionTraceabilityType/?FarmerName=%E9%A3%9B%E6%B4%8B%E6%B0%B4%E7%94%A2%E6%9C%89%E9%99%90%E5%85%AC%E5%8F%B8&TraceCodelist=10802280703"
        Dim request As HttpWebRequest = WebRequest.Create(strUrl)
        request.Method = "GET"
        request.ContentType = "application/json"
        Dim response As HttpWebResponse = request.GetResponse()
        Dim streamReader As StreamReader = New StreamReader(response.GetResponseStream)
        Dim result As Result2 = JsonConvert.DeserializeObject(Of Result2)(streamReader.ReadToEnd)
        Dim arrOperation As ArrayList = New ArrayList '生產紀錄

        Dim arrProp2 As List(Of Prop) = New List(Of Prop)
        arrProp2.Add(New Prop With {._Property = "產品名稱", .Value = result.Data.Item(0).ProductName})
        arrProp2.Add(New Prop With {._Property = "經營者", .Value = result.Data.Item(0).Producer})
        arrProp2.Add(New Prop With {._Property = "生產者", .Value = result.Data.Item(0).FarmerName})
        arrProp2.Add(New Prop With {._Property = "產地", .Value = result.Data.Item(0).Place})
        arrProp2.Add(New Prop With {._Property = "包裝日期", .Value = result.Data.Item(0).PackDate})
        arrProp2.Add(New Prop With {._Property = "驗證機構", .Value = result.Data.Item(0).CertificationName})
        Dim arrTracks As List(Of Tracks) = New List(Of Tracks)
        arrTracks.Add(New Tracks With {.TrackName = "基本資料", .prop = arrProp2, .AuditFlag = True})
        Dim arrProp As List(Of Prop) = New List(Of Prop)
        Dim text As Integer = 0
        For Each i As OperationDetail In result.Data.Item(0).OperationDetail
            arrProp.Add(New Prop With {._Property = "作業日期", .Value = i.OperationDate})
            arrProp.Add(New Prop With {._Property = "作業種類", .Value = i.OperationType})
            arrProp.Add(New Prop With {._Property = "作業內容", .Value = i.Operation})
            text += 1
            If text = 10 Then
                Exit For
            End If
        Next
        arrTracks.Add(New Tracks With {.TrackName = "生產紀錄", .prop = arrProp, .AuditFlag = True})
        Dim orderDetail As OrderDetail = New OrderDetail With {.OrderNo = "232085", .GPluNo = "47154240631", .tracks = arrTracks}
        Dim strJson As String = JsonConvert.SerializeObject(orderDetail)
        strJson = strJson.Replace("_Property", "Property")
        request = WebRequest.Create(saveAllTrack)
        request.Method = "POST"
        request.Headers("Token") = "741f8dd1a6d2bcd2c6710be36c448db2"
        request.ContentType = "application/json;charset=UTF-8"
        Dim streamWriter As StreamWriter = New StreamWriter(request.GetRequestStream())
        streamWriter.Write(strJson)
        streamWriter.Flush()
        streamWriter.Close()
        response = request.GetResponse()
        streamReader = New StreamReader(response.GetResponseStream)
        Dim result2 As Result = JsonConvert.DeserializeObject(Of Result)(streamReader.ReadToEnd)
        MsgBox(result2.Success)
    End Sub
End Class

Public Structure OrderDetail
    Public OrderNo As String
    Public GPluNo As String
    Public tracks As Object
End Structure
Public Structure Tracks
    Public TrackName As String
    Public AuditFlag As Boolean
    Public prop As Object
End Structure
Public Structure Prop
    Public _Property As String
    Public Value As String
End Structure
Public Structure Result
    Public Success As Boolean
    Public ErrorMessage As String
End Structure
Public Structure TrackNo
    Public OrderNo As String
    Public GPluNo As String
    Public StartNo As String
    Public EndNo As String
End Structure
Public Structure ProductionTraceabilityType
    Dim Tracecode As String
    Dim FarmerName As String
    Dim ProductName As String
    Dim OrgID As String
    Dim Producer As String
    Dim Place As String
    Dim PackDate As String
    Dim CertificationName As String
    Dim ValidDate As String
    Dim StoreInfo As String
    Dim LandSecNo As String
    Dim ParentTraceCode As String
    Dim TraceCodelist As String
    Dim Log_UpdateTime As String
    Dim OperationDetail As List(Of OperationDetail)
    Dim ResumeDetail As List(Of ResumeDetail)
    Dim ProcessDetail As List(Of String)
    Dim CertificateDetail As List(Of String)
End Structure
Public Structure OperationDetail
    Dim OperationDate As String
    Dim OperationType As String
    Dim Operation As String
    Dim OperationMemo As String
End Structure
Public Structure ResumeDetail
    Dim ResumeTitle As String
    Dim StoreInfo As String
End Structure
Public Structure Result2
    Dim RS As String
    Dim Data As List(Of ProductionTraceabilityType)

End Structure
