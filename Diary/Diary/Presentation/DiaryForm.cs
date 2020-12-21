using Diary.Data_Access;
using Diary.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary.Presentation
{
    public partial class DiaryForm : Form,IDisposable
    {

        string ID;

        public DiaryForm(string ID)
        {
            this.ID = ID;
            
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void DiaryForm_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        public void RefreshTable()
        {

            EntryControl entryControl = new EntryControl(this.ID);
            entryControl.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(entryControl);

            UserDataAccess userDataAccess = new UserDataAccess();

            DiaryDataGridView.DataSource = userDataAccess.ReturnDataTable(this.ID);

            DiaryDataGridView.Refresh();
            DiaryDataGridView.ClearSelection();
            
        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Dispose();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
        string Entryid;
        private void DiaryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Entryid = DiaryDataGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Entries WHERE ID = '" + Entryid + "'";
            DataAccess dataAccess = new DataAccess();
            if(dataAccess.ExecuteQuery(sql)>0)
            {
                Refresh();
            }
            
        }
    }
}
