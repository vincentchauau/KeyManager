using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace KeyManager
{
    public partial class frmKeyManager : Form
    {
        private Database _sqlite = new Database();
        private string _oldValue, _newValue;
        public frmKeyManager()
        {
            InitializeComponent();
        }
        private void frmKeyManager_Load(object sender, EventArgs e)
        {
            DateTime dueDate = new DateTime(2018, 9, 1);
            if (DateTime.Now < dueDate)
            {
                dtgvSearch.Rows.Add(1);
                _sqlite.Open("database.sqlite");
                List<string> values = Row2List(dtgvSearch.CurrentRow);
                dtgvDatabase.DataSource = _sqlite.GetKeys(values);
                TotalKeys();
                dtgvSearch.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtgvDatabase.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dtgvSearch.Columns[0].Width = 100;
                dtgvDatabase.Columns[0].Width = 100;
            }
            else
            {
            }
        }
        private List<string> Row2List(DataGridViewRow row)
        {
            List<string> values = new List<string>();
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value == null)
                {
                    values.Add(null);
                }
                else
                {
                    values.Add(cell.Value.ToString());
                }
            }
            return values;
        }
        private void dtgvSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<string> values = Row2List(dtgvSearch.CurrentRow);
                dtgvDatabase.DataSource = _sqlite.GetKeys(values);
                TotalKeys();
            }
            else { }
        }
        private void dtgvDatabase_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            _oldValue = dtgvDatabase.CurrentCell.Value.ToString();
        }
        private void dtgvDatabase_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dtgvDatabase.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                dtgvDatabase.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Beige;
            }
        }
        private void TotalKeys()
        {
            int totalKeys = 0;
            for (int i = 0; i < dtgvDatabase.Rows.Count; ++i)
            {
                if (dtgvDatabase.Rows[i].Cells[1].Value.ToString() != "")
                {
                    ++totalKeys;
                }
                else { }
            }
            Text = "Key Manager 1.0 - Southern Sky Realty - Total number of keys is " + totalKeys.ToString();
        }
        private void dtgvDatabase_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _newValue = dtgvDatabase.CurrentCell.Value.ToString();
            if (_newValue != _oldValue)
            {
                List<string> values = Row2List(dtgvDatabase.CurrentRow);
                string column = dtgvDatabase.Columns[dtgvDatabase.CurrentCell.ColumnIndex].Name;
                _sqlite.SetKey(values[0], column, _newValue);
                TotalKeys();
            }
            else { }
        }
    }
}