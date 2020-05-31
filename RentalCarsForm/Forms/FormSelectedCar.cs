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
    public partial class FormSelectedCar : Form
    {
        private MainForm mainForm;
        string username;

        public FormSelectedCar(MainForm mainForm, string carID, string username)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.username = username;

            LabelUsernameOnOpen(username);
            DispalyCar(carID);
        }

        private async void DispalyCar(string carID)
        {
            Car car = await RentalCarsAPI.GetCarById(Guid.Parse(carID));
            labelCarModel.Text = car.CarModel;
            labelEngineSize.Text = Convert.ToString(car.EngineSize);
            labelFirstRegistrationDate.Text = Convert.ToString(car.FirstRegistrationDate);
            labelFuelType.Text = Convert.ToString(car.FuelType);
            labelCarPlate.Text = car.CarPlate;
            labelManufactureDate.Text = Convert.ToString(car.ManufactoreDate);
            if (car.Rented == true)
            {
                labelRented.Text = "Da";
            }
            else
            {
                labelRented.Text = "Nu";
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
        
    }
}
