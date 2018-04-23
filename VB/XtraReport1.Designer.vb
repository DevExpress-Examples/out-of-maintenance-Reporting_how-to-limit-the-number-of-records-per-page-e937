Imports Microsoft.VisualBasic
Imports System
Namespace LimitNumberOfRecordsPerPage
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
			Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
			Me.nwindDataSet1 = New LimitNumberOfRecordsPerPage.nwindDataSet()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.productsTableAdapter = New LimitNumberOfRecordsPerPage.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageBreak1, Me.xrTable2})
			Me.Detail.Height = 25
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPageBreak1
			' 
			Me.xrPageBreak1.FormattingRules.Add(Me.formattingRule1)
			Me.xrPageBreak1.Location = New System.Drawing.Point(0, 0)
			Me.xrPageBreak1.Name = "xrPageBreak1"
			Me.xrPageBreak1.Visible = False
			' 
			' formattingRule1
			' 
			Me.formattingRule1.Condition = "([DataSource.CurrentRowIndex] % [Parameters.parameter1] == 0) And ([DataSource.Cu" & "rrentRowIndex] != 0)"
			Me.formattingRule1.DataMember = "Products"
			Me.formattingRule1.DataSource = Me.nwindDataSet1
			' 
			' 
			' 
			Me.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True
			Me.formattingRule1.Name = "formattingRule1"
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' xrTable2
			' 
			Me.xrTable2.BorderColor = System.Drawing.Color.Gray
			Me.xrTable2.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable2.Location = New System.Drawing.Point(8, 0)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.Size = New System.Drawing.Size(483, 25)
			Me.xrTable2.StylePriority.UseBorderColor = False
			Me.xrTable2.StylePriority.UseBorders = False
			Me.xrTable2.StylePriority.UsePadding = False
			Me.xrTable2.StylePriority.UseTextAlignment = False
			Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Size = New System.Drawing.Size(483, 25)
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName", "")})
			Me.xrTableCell4.Location = New System.Drawing.Point(0, 0)
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.Size = New System.Drawing.Size(250, 25)
			Me.xrTableCell4.Text = "xrTableCell4"
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.QuantityPerUnit", "")})
			Me.xrTableCell5.Location = New System.Drawing.Point(250, 0)
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.Size = New System.Drawing.Size(141, 25)
			Me.xrTableCell5.Text = "xrTableCell5"
			' 
			' xrTableCell6
			' 
			Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:$0.00}")})
			Me.xrTableCell6.ForeColor = System.Drawing.Color.DarkRed
			Me.xrTableCell6.Location = New System.Drawing.Point(391, 0)
			Me.xrTableCell6.Name = "xrTableCell6"
			Me.xrTableCell6.Size = New System.Drawing.Size(92, 25)
			Me.xrTableCell6.StylePriority.UseForeColor = False
			Me.xrTableCell6.StylePriority.UseTextAlignment = False
			Me.xrTableCell6.Text = "xrTableCell6"
			Me.xrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' PageHeader
			' 
			Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.PageHeader.Height = 32
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTable1
			' 
			Me.xrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
			Me.xrTable1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(242))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(255))))))
			Me.xrTable1.BorderColor = System.Drawing.Color.Gray
			Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable1.Font = New System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold)
			Me.xrTable1.Location = New System.Drawing.Point(8, 7)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.Size = New System.Drawing.Size(483, 25)
			Me.xrTable1.StylePriority.UseBackColor = False
			Me.xrTable1.StylePriority.UseBorderColor = False
			Me.xrTable1.StylePriority.UseBorders = False
			Me.xrTable1.StylePriority.UseFont = False
			Me.xrTable1.StylePriority.UsePadding = False
			Me.xrTable1.StylePriority.UseTextAlignment = False
			Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Size = New System.Drawing.Size(483, 25)
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.CanGrow = False
			Me.xrTableCell1.Location = New System.Drawing.Point(0, 0)
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.Size = New System.Drawing.Size(250, 25)
			Me.xrTableCell1.Text = "Product Name"
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.CanGrow = False
			Me.xrTableCell2.Location = New System.Drawing.Point(250, 0)
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.Size = New System.Drawing.Size(142, 25)
			Me.xrTableCell2.Text = "Quantity Per Unit"
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.CanGrow = False
			Me.xrTableCell3.Location = New System.Drawing.Point(392, 0)
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.Size = New System.Drawing.Size(91, 25)
			Me.xrTableCell3.Text = "Unit Price"
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' parameter1
			' 
			Me.parameter1.Description = "Rows per Page:"
			Me.parameter1.Name = "parameter1"
			Me.parameter1.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.Int32
			Me.parameter1.Value = 5
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.nwindDataSet1
			Me.DrawGrid = False
			Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() { Me.formattingRule1})
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.parameter1})
			Me.SnapToGrid = False
			Me.Version = "8.3"
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private nwindDataSet1 As nwindDataSet
		Private productsTableAdapter As LimitNumberOfRecordsPerPage.nwindDataSetTableAdapters.ProductsTableAdapter
		Private xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
		Private parameter1 As DevExpress.XtraReports.Parameters.Parameter
	End Class
End Namespace
