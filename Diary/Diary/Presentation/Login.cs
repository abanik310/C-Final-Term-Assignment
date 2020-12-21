using Diary.Data_Access;
using Diary.Entity;
using Diary.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    public partial class Login : Form,IDisposable
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbxUserName.Text == "" || tbxPassword.Text == "")
            {
                MessageBox.Show("Username or Password can not be empty", "Warning");
            }
            else
            {
                string username = tbxUserName.Text;
                string password = tbxPassword.Text;
                string id;

                UserDataAccess userDataAccess = new UserDataAccess();

                id = userDataAccess.getUserID(username, password);

                if (userDataAccess.LoginValidation(username, password))
                {

                    DiaryForm diaryForm = new DiaryForm(id);
                    diaryForm.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }

            }

            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}
