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
using RentalCarsDB;
using RentalCarsDB.Enums;
using RentalCarsDB.Models;

namespace RentalCarsForm.Forms
{
    public partial class FormRentCar : Form
    {

        private MainForm mainForm;
        string username;
        string carID;
        public FormRentCar(MainForm mainForm, string carID, string username)
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            this.mainForm = mainForm;
            this.username = username;
            this.carID = carID;
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.mainForm.OpenChildForm(new FormSelectedCar(mainForm, carID, username));
        }

        private async void buttonRent_Click(object sender, EventArgs e)
        {

            if (verifyData())
            {
                setLabels();

                await RentalCarsAPI.RentToPersonAsync(Guid.Parse(carID), Person.Create(textBoxCNP.Text, textBoxFirstName.Text, 
                    dateTimePickerBegin.Value, dateTimePickerFinal.Value, textBoxLastName.Text));
                
                this.mainForm.OpenChildForm(new FormSelectedCar(mainForm, carID, username));
            }

        }

        private void setLabels()
        {
            labelBegin.ForeColor = Color.Black;
            labelFinal.ForeColor = Color.Black;
            labelFirstName.ForeColor = Color.Black;
            labelLastName.ForeColor = Color.Black;
            labelCNP.ForeColor = Color.Black;
        }

        private bool verifyData()
        {
            bool ok = true;
            if (textBoxFirstName.Text.Length < 3)
            {
                ok = false;
                labelFirstName.ForeColor = Color.Red;
            }
            else
            {
                labelFirstName.ForeColor = Color.Black;
            }
            if (textBoxLastName.Text.Length < 3)
            {
                ok = false;
                labelLastName.ForeColor = Color.Red;
            }
            else
            {
                labelLastName.ForeColor = Color.Black;
            }
            if (textBoxCNP.Text.Length != 13)
            {
                ok= false;
                labelCNP.ForeColor = Color.Red;
            }
            else
            {
                labelCNP.ForeColor = Color.Black;
            }       
            if (dateTimePickerBegin.Value < DateTime.Now)
            {
                ok= false;
                labelBegin.ForeColor = Color.Red;
            }
            else
            {
                labelBegin.ForeColor = Color.Black;
            }
            if (dateTimePickerFinal.Value < dateTimePickerBegin.Value)
            {
                labelFinal.ForeColor = Color.Red;
                ok= false;
            }
            else
            {
                labelFinal.ForeColor = Color.Black;
            }
            return ok;
        }
        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            //Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(57, 128, 227), 65f);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(15, 0, 0), Color.FromArgb(70, 0, 0), 65f);

            //apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }
    }
}
