using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diary.Data_Access;

namespace Diary.Presentation
{
    public partial class EntryControl : UserControl
    {
        string id;
        public EntryControl(string id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = tbxTitleContrl.Text;
            DateTime dateTime = tbxEntryDateContrl.Value;
            string entry = tbxEntry.Text;

            string sql = "INSERT INTO [dbo].[Entries] ([EntryID],[Title],[Entry] ,[EnrtyDate])VALUES('"+id+"', '"+title+"', '"+entry+"', '"+dateTime+"')";
            DiaryForm diaryForm = new DiaryForm(id);
            diaryForm.RefreshTable();

            DataAccess dataAccess = new DataAccess();
           if (dataAccess.ExecuteQuery(sql)>0)
            {
                tbxEntry.Text =tbxTitleContrl.Text = null;
               
            }
            


         }

        public void Update(string title, string entry)
        {
            tbxTitleContrl.Text = title;
            tbxEntry.Text = entry;
            

        }
    }
}
