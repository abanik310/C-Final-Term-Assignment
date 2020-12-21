using Diary.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary.Presentation
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            
                
               
                string gen = null;
                if (radioMale.Checked)
                {
                    gen = radioMale.Text;
                }
                else
                {
                gen = radioFemale.Text;
                }
            String sql = "INSERT INTO Users2(Name,UserName,Password,Email,DateOFBirth,Gender) VALUES('" + tbxNameForReg.Text + "','" + tbxUserNameForReg.Text + "','" + tbxPassForReg.Text + "','" + tbxEmailforReg.Text + "','" + tbxDateForReg.Text + "','" + gen + "')";

            DataAccess dataAccess = new DataAccess();
            

            int result = dataAccess.ExecuteQuery(sql);

            if (result > 0)
            {
                MessageBox.Show("User Added Successfully","Confirmation");
                tbxNameForReg.Text = tbxUserNameForReg.Text = tbxPassForReg.Text = tbxCnfrmPassForReg.Text = tbxEmailforReg.Text = tbxDateForReg.Text = string.Empty;
                radioMale.Checked = radioFemale.Checked = false;
                


            }
            else
            {
                MessageBox.Show("Unsuccessful operation!", "Warning");

            }

                
            
        }
    }
}
