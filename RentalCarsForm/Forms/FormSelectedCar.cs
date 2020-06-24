using RentalCarsDB;
using RentalCarsDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCarsForm.Forms
{
    public partial class FormSelectedCar : Form
    {
        private MainForm mainForm;
        string username;
        string carID;

        public FormSelectedCar(MainForm mainForm, string carID, string username)
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            this.mainForm = mainForm;
            this.username = username;
            this.carID = carID;

            LabelUsernameOnOpen(username);
            DisplayCar(carID);
        }

        private async void DisplayCar(string carID)
        {
            Car car = await RentalCarsAPI.GetCarById(Guid.Parse(carID));
            Person person = await RentalCarsAPI.GetPersonByCardId(Guid.Parse(carID));
            labelCarModel.Text = car.CarModel;
            labelEngineSize.Text = Convert.ToString(car.EngineSize);
            labelFirstRegistrationDate.Text = Convert.ToString(car.FirstRegistrationDate);
            labelFuelType.Text = Convert.ToString(car.FuelType);
            labelCarPlate.Text = car.CarPlate;
            labelManufactureDate.Text = Convert.ToString(car.ManufactoreDate);
            if (car.Rented == true)
            {
                labelRented.Text = "Da";
                labelRentedDate.Visible = true;
                labelRentedUntil.Text = Convert.ToString(person.ToDate);
                buttonRent.Text = "FREE";
                buttonSeePerson.Visible = true;
            }
            else
            {
                labelRented.Text = "Nu este inchiriat";
                labelRentedUntil.Visible = true;
                //labelRentedDate.Visible = false;
                labelRentedUntil.Text = "Nu este inchiriat";
                buttonRent.Text = "RENT";
                buttonSeePerson.Visible = false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.mainForm.OpenChildForm(new FormLoggedin(mainForm, username));
        }

        private void LabelUsernameOnOpen(string username)
        {
            labelUsername.Text = username;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ButtonBack_ClickResolve();
        }
        private async void ButtonBack_ClickResolve()
        {
            Car car = await RentalCarsAPI.GetCarById(Guid.Parse(carID));
            Person person = await RentalCarsAPI.GetPersonByCardId(Guid.Parse(carID));
            if (car.Rented == true)
            {
                await RentalCarsAPI.FreeCar(car.CarId);
                this.mainForm.OpenChildForm(new FormSelectedCar(mainForm, carID, username));
            }
            else
            {
                this.mainForm.OpenChildForm(new FormRentCar(mainForm, carID, username));
            }
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

        private void buttonSeePerson_Click(object sender, EventArgs e)
        {
            this.mainForm.OpenChildForm(new FormPerson(mainForm, 1, username, carID));
        }
    }
}
