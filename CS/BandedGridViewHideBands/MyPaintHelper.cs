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
using DevExpress.XtraEditors.Drawing;
using DevExpress.Utils;

namespace BandedGridViewHideBands {
    class MyPaintHelper : GridPainter {
        BandedGridView _View;
        GridBand[] _Bands;
        public MyPaintHelper(BandedGridView view, GridBand[] bands)
            : base(view) {
            _View = view;
            _Bands = bands;
            _View.GridControl.PaintEx += GridControl_PaintEx;
            _View.CustomDrawBandHeader += new BandHeaderCustomDrawEventHandler(_View_CustomDrawBandHeader);
            _View.MouseDown += _View_MouseDown;
        }

        private void GridControl_PaintEx(object sender, PaintExEventArgs e)
        {
            foreach (GridBand band in _Bands)
                foreach (BandedGridColumn column in band.Columns)
                    DrawColumnHeader(e.Cache, column);
        }

        void _View_MouseDown(object sender, MouseEventArgs e) {
            BandedGridHitInfo hi = _View.CalcHitInfo(e.Location);
            if (_Bands.Contains(hi.Band) && hi.InRowCell == false)
                DXMouseEventArgs.GetMouseArgs(e).Handled = true;
        }

        void _View_CustomDrawBandHeader(object sender, BandHeaderCustomDrawEventArgs e) {
            if (_Bands.Contains(e.Band))
                e.Handled = true;
        }
        public void DrawColumnHeader(GraphicsCache cache, GridColumn column) {
            BandedGridViewInfo viewInfo = _View.GetViewInfo() as BandedGridViewInfo;
            GridColumnInfoArgs colInfo = viewInfo.ColumnsInfo[column];
            GridBandInfoArgs bandInfo = getBandInfo(viewInfo.BandsInfo, (column as BandedGridColumn).OwnerBand);
            if (colInfo == null || bandInfo == null)
                return;
            colInfo.Cache = cache;

            int top = bandInfo.Bounds.Top;
            Rectangle rect = colInfo.Bounds;
            int delta = rect.Top - top;
            rect.Y = top;
            rect.Height += delta;
            colInfo.Bounds = rect;
            colInfo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            HeaderObjectInfoArgs args = colInfo as HeaderObjectInfoArgs;
            if (args.InnerElements.Count > 1) {
                GridFilterButtonInfoArgs btn = args.InnerElements[1].ElementInfo as GridFilterButtonInfoArgs;
                ElementsPainter.Column.CalcObjectBounds(colInfo);
                btn.Bounds = new Rectangle(btn.Bounds.X, btn.Bounds.Y + colInfo.Bounds.Height / 2, btn.Bounds.Width, btn.Bounds.Height);
            }
            else
                ElementsPainter.Column.CalcObjectBounds(colInfo);
            ElementsPainter.Column.DrawObject(colInfo);
        }

        GridBandInfoArgs getBandInfo(GridBandInfoCollection bands, GridBand band) {
            GridBandInfoArgs info = bands[band];
            if (info != null)
                return info;
            else
                foreach (GridBandInfoArgs bandInfo in bands) {
                    if (bandInfo.Children != null) {
                        info = getBandInfo(bandInfo.Children, band);
                        if (info != null)
                            return info;
                    }
                }
            return null;
        }
    }

}
