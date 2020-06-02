using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            await RentalCarsAPI.RentToPersonAsync(Guid.Parse(carID), 
                Person.Create(textBoxCNP.Text, textBoxFirstName.Text, dateTimePickerBegin.Value, 
                dateTimePickerFinal.Value, textBoxLastName.Text));
            //last
            this.mainForm.OpenChildForm(new FormSelectedCar(mainForm, carID, username));
        }
    }
}
