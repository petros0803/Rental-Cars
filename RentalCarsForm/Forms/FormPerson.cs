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
    public partial class FormPerson : Form
    {
        private MainForm mainForm;
        string username;
        int formcheck;
        string carID;
        string CNP;
        public FormPerson(MainForm mainForm, int formcheck, string username, string carID)
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            this.mainForm = mainForm;
            this.username = username;
            this.formcheck = formcheck;
            this.carID = carID;
            this.CNP = carID;
            if (formcheck == 0)
            {
                DisplayPerson0(carID);
            }
            else
            {
                DisplayPerson1(carID);
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (formcheck == 0)
            {
                this.mainForm.OpenChildForm(new FormHistory(mainForm, username));
            }
            else
            {
                this.mainForm.OpenChildForm(new FormSelectedCar(mainForm, carID, username));
            }
        }
        private async void DisplayPerson1(string carID)
        {
            Person person = await RentalCarsAPI.GetPersonByCardId(Guid.Parse(carID));
            History history = await RentalCarsAPI.GetHistoryByCNP(person.CNP);
            Car car = await RentalCarsAPI.GetCarById(Guid.Parse(carID));

            labelFirstName1.Text = person.FirstName;
            labelLastName1.Text = person.LastName;
            labelCNP1.Text = person.CNP;
            labelCarCounter1.Text = Convert.ToString(history.Counter);
            labelRented1.Text = "True";
            labelCar1.Text = car.CarModel;
            labelFromDate1.Text = Convert.ToString(person.FromDate);
            labelToDate1.Text = Convert.ToString(person.ToDate);
        }

        private async void DisplayPerson0(string carID)
        {
            Person person = await RentalCarsAPI.GetPersonByCNP(CNP);
            History history = await RentalCarsAPI.GetHistoryByCNP(CNP);
            Car car = await RentalCarsAPI.GetCarByCNP(CNP);

            labelFirstName1.Text = history.FirstName;
            labelLastName1.Text = history.LastName;
            labelCNP1.Text = history.CNP;
            labelCarCounter1.Text = Convert.ToString(history.Counter);
            if (person != null)
            {
                labelRented1.Text = "True";
                labelCar1.Text = car.CarModel;
                labelFromDate1.Text = Convert.ToString(history.FromDate);
                labelToDate1.Text = Convert.ToString(history.ToDate);
            }
            else
            {
                labelRented1.Text = "False";
                labelCar1.Text = "False";
                labelFromDate1.Text = Convert.ToString(history.FromDate);
                labelToDate1.Text = Convert.ToString(history.ToDate);
            }
        }

    }
}
