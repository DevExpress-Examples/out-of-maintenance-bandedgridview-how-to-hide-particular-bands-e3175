using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.Utils.Paint;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid;
using DevExpress.Utils.Drawing;

namespace BandedGridViewHideBands
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = FillDataTable();
            MyPaintHelper helper = new MyPaintHelper(bandedGridView2, new GridBand[] { gridBand3 });
        }

        DataTable FillDataTable()
        {
            DataTable _dataTable = new DataTable();
            _dataTable.Columns.Add(new DataColumn("bandedGridColumn1", typeof(string)));
            _dataTable.Rows.Add(new object[] { "" });
            return _dataTable;
        }
    }
}
