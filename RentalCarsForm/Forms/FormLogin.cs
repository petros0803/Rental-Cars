using RentalCarsDB;
using RentalCarsDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCarsForm.Forms
{
    public partial class FormLogin : Form
    {
        private MainForm mainForm;
        public FormLogin(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            textBoxPassword.PasswordChar = '*';
        }

        private async void ButtonLogin_ClickAsync(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (verifyLoginDetails(username, password) != true)
            {
                labelFailLogIn.Text = "Failed to Login. Username or password incorrect!";
                labelFailLogIn.ForeColor = Color.Red;
            }
            

            var user = User.Create(username, password);
            bool respond = await RentalCarsAPI.LogInAsync(user);

            if (respond == false)
            {
                labelFailLogIn.Text = "Failed to Login. Username or password incorrect!";
                labelFailLogIn.ForeColor = Color.Red;
            }
            else
            {
                labelFailLogIn.Text = "";
                this.mainForm.OpenChildForm(new FormLoggedin(mainForm, username));
            }
        }

        private bool verifyLoginDetails(string username, string password)
        {
            if (username.Length < 5 || username.Length > 20 || password.Length < 5 || password.Length > 5)
            {
                return false;
            }
            return true;
        }
    }
}
