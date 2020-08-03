<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.ShipDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TGAP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Result = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ReportBtn1 = New System.Windows.Forms.Button()
        Me.ReportBtn2 = New System.Windows.Forms.Button()
        Me.ReportBtn3 = New System.Windows.Forms.Button()
        Me.ReportBtn4 = New System.Windows.Forms.Button()
        Me.ReportBtn5 = New System.Windows.Forms.Button()
        Me.ReportBtn6 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ReporText1 = New System.Windows.Forms.Label()
        Me.ReporText2 = New System.Windows.Forms.Label()
        Me.ReporText3 = New System.Windows.Forms.Label()
        Me.ReporText4 = New System.Windows.Forms.Label()
        Me.ReporText5 = New System.Windows.Forms.Label()
        Me.ReporText6 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1178.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DGV, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1164, 749)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShipDate, Me.OrderId, Me.StartNo, Me.EndNo, Me.SName, Me.SNo, Me.CNo, Me.TGAP, Me.Result})
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV.Location = New System.Drawing.Point(3, 144)
        Me.DGV.Name = "DGV"
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(1172, 602)
        Me.DGV.TabIndex = 3
        '
        'ShipDate
        '
        Me.ShipDate.HeaderText = "出貨日期"
        Me.ShipDate.Name = "ShipDate"
        '
        'OrderId
        '
        Me.OrderId.HeaderText = "溯源單號"
        Me.OrderId.Name = "OrderId"
        '
        'StartNo
        '
        Me.StartNo.HeaderText = "起始編號"
        Me.StartNo.Name = "StartNo"
        '
        'EndNo
        '
        Me.EndNo.HeaderText = "結束編號"
        Me.EndNo.Name = "EndNo"
        '
        'SName
        '
        Me.SName.HeaderText = "姓名"
        Me.SName.Name = "SName"
        '
        'SNo
        '
        Me.SNo.HeaderText = "果園註冊號碼"
        Me.SNo.Name = "SNo"
        '
        'CNo
        '
        Me.CNo.HeaderText = "產銷班編號"
        Me.CNo.Name = "CNo"
        '
        'TGAP
        '
        Me.TGAP.HeaderText = "TGAP"
        Me.TGAP.Name = "TGAP"
        '
        'Result
        '
        Me.Result.HeaderText = "結果"
        Me.Result.Name = "Result"
        Me.Result.Width = 500
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReportBtn1)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReportBtn2)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReportBtn3)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReportBtn4)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReportBtn5)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReportBtn6)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1172, 29)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "輸出&Q"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(84, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "單一激活號碼"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(185, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "快速導入報告"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ReportBtn1
        '
        Me.ReportBtn1.Location = New System.Drawing.Point(293, 3)
        Me.ReportBtn1.Name = "ReportBtn1"
        Me.ReportBtn1.Size = New System.Drawing.Size(75, 23)
        Me.ReportBtn1.TabIndex = 7
        Me.ReportBtn1.Text = "CICTW證書"
        Me.ReportBtn1.UseVisualStyleBackColor = True
        '
        'ReportBtn2
        '
        Me.ReportBtn2.Location = New System.Drawing.Point(374, 3)
        Me.ReportBtn2.Name = "ReportBtn2"
        Me.ReportBtn2.Size = New System.Drawing.Size(75, 23)
        Me.ReportBtn2.TabIndex = 8
        Me.ReportBtn2.Text = "報告一"
        Me.ReportBtn2.UseVisualStyleBackColor = True
        '
        'ReportBtn3
        '
        Me.ReportBtn3.Location = New System.Drawing.Point(455, 3)
        Me.ReportBtn3.Name = "ReportBtn3"
        Me.ReportBtn3.Size = New System.Drawing.Size(75, 23)
        Me.ReportBtn3.TabIndex = 9
        Me.ReportBtn3.Text = "報告二"
        Me.ReportBtn3.UseVisualStyleBackColor = True
        '
        'ReportBtn4
        '
        Me.ReportBtn4.Location = New System.Drawing.Point(536, 3)
        Me.ReportBtn4.Name = "ReportBtn4"
        Me.ReportBtn4.Size = New System.Drawing.Size(75, 23)
        Me.ReportBtn4.TabIndex = 10
        Me.ReportBtn4.Text = "報告三"
        Me.ReportBtn4.UseVisualStyleBackColor = True
        '
        'ReportBtn5
        '
        Me.ReportBtn5.Location = New System.Drawing.Point(617, 3)
        Me.ReportBtn5.Name = "ReportBtn5"
        Me.ReportBtn5.Size = New System.Drawing.Size(75, 23)
        Me.ReportBtn5.TabIndex = 11
        Me.ReportBtn5.Text = "報告四"
        Me.ReportBtn5.UseVisualStyleBackColor = True
        '
        'ReportBtn6
        '
        Me.ReportBtn6.Location = New System.Drawing.Point(698, 3)
        Me.ReportBtn6.Name = "ReportBtn6"
        Me.ReportBtn6.Size = New System.Drawing.Size(75, 23)
        Me.ReportBtn6.TabIndex = 12
        Me.ReportBtn6.Text = "報告五"
        Me.ReportBtn6.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.ReporText1)
        Me.FlowLayoutPanel2.Controls.Add(Me.ReporText2)
        Me.FlowLayoutPanel2.Controls.Add(Me.ReporText3)
        Me.FlowLayoutPanel2.Controls.Add(Me.ReporText4)
        Me.FlowLayoutPanel2.Controls.Add(Me.ReporText5)
        Me.FlowLayoutPanel2.Controls.Add(Me.ReporText6)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 38)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1172, 100)
        Me.FlowLayoutPanel2.TabIndex = 4
        '
        'ReporText1
        '
        Me.ReporText1.AutoSize = True
        Me.ReporText1.Location = New System.Drawing.Point(3, 0)
        Me.ReporText1.Name = "ReporText1"
        Me.ReporText1.Size = New System.Drawing.Size(103, 12)
        Me.ReporText1.TabIndex = 0
        Me.ReporText1.Text = "CICTW證書未設定"
        '
        'ReporText2
        '
        Me.ReporText2.AutoSize = True
        Me.ReporText2.Location = New System.Drawing.Point(3, 12)
        Me.ReporText2.Name = "ReporText2"
        Me.ReporText2.Size = New System.Drawing.Size(77, 12)
        Me.ReporText2.TabIndex = 1
        Me.ReporText2.Text = "報告一未設定"
        '
        'ReporText3
        '
        Me.ReporText3.AutoSize = True
        Me.ReporText3.Location = New System.Drawing.Point(3, 24)
        Me.ReporText3.Name = "ReporText3"
        Me.ReporText3.Size = New System.Drawing.Size(77, 12)
        Me.ReporText3.TabIndex = 2
        Me.ReporText3.Text = "報告二未設定"
        '
        'ReporText4
        '
        Me.ReporText4.AutoSize = True
        Me.ReporText4.Location = New System.Drawing.Point(3, 36)
        Me.ReporText4.Name = "ReporText4"
        Me.ReporText4.Size = New System.Drawing.Size(77, 12)
        Me.ReporText4.TabIndex = 3
        Me.ReporText4.Text = "報告三未設定"
        '
        'ReporText5
        '
        Me.ReporText5.AutoSize = True
        Me.ReporText5.Location = New System.Drawing.Point(3, 48)
        Me.ReporText5.Name = "ReporText5"
        Me.ReporText5.Size = New System.Drawing.Size(77, 12)
        Me.ReporText5.TabIndex = 4
        Me.ReporText5.Text = "報告四未設定"
        '
        'ReporText6
        '
        Me.ReporText6.AutoSize = True
        Me.ReporText6.Location = New System.Drawing.Point(3, 60)
        Me.ReporText6.Name = "ReporText6"
        Me.ReporText6.Size = New System.Drawing.Size(77, 12)
        Me.ReporText6.TabIndex = 5
        Me.ReporText6.Text = "報告五未設定"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1178, 781)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1170, 755)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "長辰溯源"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1170, 755)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "飛洋水產"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(503, 207)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(709, 192)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(135, 49)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 781)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "長辰溯源資料上傳系統"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Button3 As Button
    Public WithEvents DGV As DataGridView
    Friend WithEvents ReportBtn1 As Button
    Friend WithEvents ReportBtn2 As Button
    Friend WithEvents ReportBtn3 As Button
    Friend WithEvents ReportBtn4 As Button
    Friend WithEvents ReportBtn5 As Button
    Friend WithEvents ReportBtn6 As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents ReporText1 As Label
    Friend WithEvents ReporText2 As Label
    Friend WithEvents ReporText3 As Label
    Friend WithEvents ReporText4 As Label
    Friend WithEvents ReporText5 As Label
    Friend WithEvents ReporText6 As Label
    Friend WithEvents ShipDate As DataGridViewTextBoxColumn
    Friend WithEvents OrderId As DataGridViewTextBoxColumn
    Friend WithEvents StartNo As DataGridViewTextBoxColumn
    Friend WithEvents EndNo As DataGridViewTextBoxColumn
    Friend WithEvents SName As DataGridViewTextBoxColumn
    Friend WithEvents SNo As DataGridViewTextBoxColumn
    Friend WithEvents CNo As DataGridViewTextBoxColumn
    Friend WithEvents TGAP As DataGridViewTextBoxColumn
    Friend WithEvents Result As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button4 As Button
End Class
