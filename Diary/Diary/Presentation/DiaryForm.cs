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
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
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
            EntryControl entryControl = new EntryControl();
            entryControl.Dock = DockStyle.Fill;
            controlPanel.Controls.Add(entryControl);    
        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
