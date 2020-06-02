using RentalCarsDB;
using RentalCarsDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                buttonRent.Text = "Free";
            }
            else
            {
                labelRented.Text = "Nu";
                labelRentedUntil.Visible = false;
                labelRentedDate.Visible = false;
                buttonRent.Text = "Rent";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.mainForm.OpenChildForm(new FormLoggedin(mainForm, username));
        }

        private void LabelUsernameOnOpen(string username)
        {
            labelUsername.Text = username;
            labelUsername.ForeColor = Color.BlueViolet;
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

            }
            else
            {
                this.mainForm.OpenChildForm(new FormRentCar(mainForm, carID, username));
            }
        }
    }
}
