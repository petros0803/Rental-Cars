using RentalCarsDB;
using RentalCarsDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            this.Paint += new PaintEventHandler(set_background);
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

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            //Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(57, 128, 227), 65f);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(15, 0, 0), Color.FromArgb(40, 0, 0), 65f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
