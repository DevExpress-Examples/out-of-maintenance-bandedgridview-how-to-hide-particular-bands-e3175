' Developer Express Code Central Example:
' BandedGridView - How to hide particular Bands
' 
' This example illustrates how to hide a particular Band and draw on its place
' column captions that belong to this Band.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3175

Namespace BandedGridViewHideBands
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.bandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.bandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.bandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.bandedGridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bandedGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.bandedGridView2
			Me.gridControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(757, 474)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.bandedGridView2})
			' 
			' bandedGridView2
			' 
			Me.bandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1})
			Me.bandedGridView2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.bandedGridColumn1, Me.bandedGridColumn2, Me.bandedGridColumn3, Me.bandedGridColumn4, Me.bandedGridColumn5})
			Me.bandedGridView2.GridControl = Me.gridControl1
			Me.bandedGridView2.Name = "bandedGridView2"
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "gridBand1"
			Me.gridBand1.Children.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand3, Me.gridBand2})
			Me.gridBand1.MinWidth = 20
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.VisibleIndex = 0
			Me.gridBand1.Width = 406
			' 
			' gridBand3
			' 
			Me.gridBand3.Caption = "gridBand3"
			Me.gridBand3.Columns.Add(Me.bandedGridColumn3)
			Me.gridBand3.Columns.Add(Me.bandedGridColumn5)
			Me.gridBand3.MinWidth = 20
			Me.gridBand3.Name = "gridBand3"
			Me.gridBand3.VisibleIndex = 0
			Me.gridBand3.Width = 150
			' 
			' bandedGridColumn3
			' 
			Me.bandedGridColumn3.Caption = "bandedGridColumn3"
			Me.bandedGridColumn3.Name = "bandedGridColumn3"
			Me.bandedGridColumn3.Visible = True
			' 
			' bandedGridColumn5
			' 
			Me.bandedGridColumn5.Caption = "bandedGridColumn5"
			Me.bandedGridColumn5.Name = "bandedGridColumn5"
			Me.bandedGridColumn5.Visible = True
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "gridBand2"
			Me.gridBand2.Columns.Add(Me.bandedGridColumn4)
			Me.gridBand2.Columns.Add(Me.bandedGridColumn2)
			Me.gridBand2.Columns.Add(Me.bandedGridColumn1)
			Me.gridBand2.MinWidth = 20
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.VisibleIndex = 1
			Me.gridBand2.Width = 256
			' 
			' bandedGridColumn4
			' 
			Me.bandedGridColumn4.Caption = "bandedGridColumn4"
			Me.bandedGridColumn4.Name = "bandedGridColumn4"
			Me.bandedGridColumn4.Visible = True
			' 
			' bandedGridColumn2
			' 
			Me.bandedGridColumn2.Caption = "bandedGridColumn2"
			Me.bandedGridColumn2.Name = "bandedGridColumn2"
			Me.bandedGridColumn2.OptionsFilter.AllowFilter = False
			Me.bandedGridColumn2.Visible = True
			' 
			' bandedGridColumn1
			' 
			Me.bandedGridColumn1.Caption = "bandedGridColumn1"
			Me.bandedGridColumn1.Name = "bandedGridColumn1"
			Me.bandedGridColumn1.OptionsFilter.AllowFilter = False
			Me.bandedGridColumn1.Visible = True
			Me.bandedGridColumn1.Width = 106
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(757, 474)
			Me.Controls.Add(Me.gridControl1)
			Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bandedGridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private bandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private bandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private bandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private bandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	End Class
End Namespace

