Namespace WpfApplication1
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
'INSTANT VB NOTE: The variable resources was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
			Dim resources_Conflict As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' TopMargin
			' 
			Me.TopMargin.Dpi = 100F
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel3
			' 
			Me.xrLabel3.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrLabel3.Dpi = 100F
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(461.4583F, 32.99999F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(165F, 28.95832F)
			Me.xrLabel3.StylePriority.UseBorders = False
			Me.xrLabel3.StylePriority.UsePadding = False
			' 
			' xrLabel5
			' 
			Me.xrLabel5.Dpi = 100F
			Me.xrLabel5.Font = New DevExpress.Drawing.DXFont("Tahoma", 10F)
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(240.625F, 10.00001F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(165F, 23F)
			Me.xrLabel5.StylePriority.UseFont = False
			Me.xrLabel5.StylePriority.UsePadding = False
			Me.xrLabel5.Text = "Select a required date:"
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrLabel1.Dpi = 100F
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 32.99999F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(165F, 28.95832F)
			Me.xrLabel1.StylePriority.UseBorders = False
			Me.xrLabel1.StylePriority.UsePadding = False
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel6, Me.xrLabel5, Me.xrLabel4, Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
			Me.Detail.Dpi = 100F
			Me.Detail.HeightF = 100F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel6
			' 
			Me.xrLabel6.Dpi = 100F
			Me.xrLabel6.Font = New DevExpress.Drawing.DXFont("Tahoma", 10F)
			Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(461.4583F, 10.00001F)
			Me.xrLabel6.Name = "xrLabel6"
			Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
			Me.xrLabel6.SizeF = New System.Drawing.SizeF(165F, 23F)
			Me.xrLabel6.StylePriority.UseFont = False
			Me.xrLabel6.StylePriority.UsePadding = False
			Me.xrLabel6.Text = "Enter a phone number:"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.Dpi = 100F
			Me.xrLabel4.Font = New DevExpress.Drawing.DXFont("Tahoma", 10F)
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(165F, 23F)
			Me.xrLabel4.StylePriority.UseFont = False
			Me.xrLabel4.StylePriority.UsePadding = False
			Me.xrLabel4.Text = "Select a required item:"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrLabel2.Dpi = 100F
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(240.625F, 32.99999F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(165F, 28.95832F)
			Me.xrLabel2.StylePriority.UseBorders = False
			Me.xrLabel2.StylePriority.UsePadding = False
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Dpi = 100F
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel7})
			Me.ReportHeader.Dpi = 100F
			Me.ReportHeader.HeightF = 100F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabel7
			' 
			Me.xrLabel7.Dpi = 100F
			Me.xrLabel7.Font = New DevExpress.Drawing.DXFont("Tahoma", 9.75F)
			Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel7.Multiline = True
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.SizeF = New System.Drawing.SizeF(616.4583F, 79.99998F)
			Me.xrLabel7.StylePriority.UseFont = False
			Me.xrLabel7.Text = resources_Conflict.GetString("xrLabel7.Text")
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.Version = "16.2"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.XtraReport1_BeforePrint);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel6 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Public xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Public xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Public xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel

	End Class
End Namespace
