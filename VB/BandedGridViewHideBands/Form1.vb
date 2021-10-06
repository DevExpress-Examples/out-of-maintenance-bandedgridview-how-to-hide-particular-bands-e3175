Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.Utils.Paint
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid
Imports DevExpress.Utils.Drawing

Namespace BandedGridViewHideBands

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.DataSource = FillDataTable()
            Dim helper As MyPaintHelper = New MyPaintHelper(bandedGridView2, New GridBand() {gridBand3})
        End Sub

        Private Function FillDataTable() As DataTable
            Dim _dataTable As DataTable = New DataTable()
            _dataTable.Columns.Add(New DataColumn("bandedGridColumn1", GetType(String)))
            _dataTable.Rows.Add(New Object() {""})
            Return _dataTable
        End Function
    End Class
End Namespace
