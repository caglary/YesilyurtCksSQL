using System.Windows.Forms;
namespace Yesilyurt_Ciftci_Kayit.Utilities
{
    public static class Datagrid
    {
        public static void DataGridSettings(DataGridView dgw, string[] notAppearColumnsName)
        {
            if (dgw.Rows.Count==0)
            {
                return;
            }
            foreach (var item in notAppearColumnsName)
            {
                dgw.Columns[item].Visible = false;
            }
            dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw.MultiSelect = false;
            dgw.ReadOnly = true;
            // Automatically resize the visible rows.
            //dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            // Set the DataGridView control's border.
            dgw.BorderStyle = BorderStyle.Fixed3D;
        }
        public static void DataGridSettings(DataGridView dgw)
        {
           
            dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw.BackgroundColor = System.Drawing.Color.White;
            dgw.MultiSelect = false;
            dgw.ReadOnly = true;
            // Automatically resize the visible rows.
            //dgw.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            // Set the DataGridView control's border.
            dgw.BorderStyle = BorderStyle.Fixed3D;
           
        }
    }
}
