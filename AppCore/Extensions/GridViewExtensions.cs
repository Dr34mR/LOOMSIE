using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppCore.Extensions
{
    public static class GridViewExtensions
    {
        internal static void ApplySetup(this DataGridView gridView, BindingSource bindingSource, Color backColor)
        {
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToOrderColumns = false;
            //gridView.ColumnHeadersVisible = false;
            gridView.RowHeadersVisible = false;
            gridView.AllowUserToResizeColumns = true;
            gridView.AllowUserToResizeRows = false;
            gridView.BackColor = backColor;
            gridView.BackgroundColor = backColor;
            //gridView.BorderStyle = BorderStyle.None;

            //gridView.ColumnHeadersDefaultCellStyle.BackColor = backColor;
            //gridView.EnableHeadersVisualStyles = false;

            gridView.DataSource = bindingSource;
        }

        internal static void SetFont(this DataGridView gridView, Font font)
        {
            gridView.ColumnHeadersDefaultCellStyle.Font = font;

            foreach (DataGridViewColumn c in gridView.Columns)
            {
                c.DefaultCellStyle.Font = font;
            }
        }

        internal static void DataGrid_ClearSelection(object sender, EventArgs e)
        {
            if (sender is not DataGridView dataGrid) return;
            dataGrid.ClearSelection();
        }
    }
}
