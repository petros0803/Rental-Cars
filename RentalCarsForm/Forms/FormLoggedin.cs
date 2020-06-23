using RentalCarsDB;
using RentalCarsDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCarsForm.Forms
{
    public partial class FormLoggedin : Form
    {
        string username;
        private MainForm mainForm;

        public FormLoggedin(MainForm mainForm, string username)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            LabelUsernameOnOpen(username);
            this.username = username;
            this.Paint += new PaintEventHandler(set_background);
            InitializeDataGridView();
            LoadDataGridView();
        }

        private async void LoadDataGridView()
        {
            List<Car> cars = await RentalCarsAPI.GetCarsAsync();
            comboBoxCarModel.Items.Add("ALL");
            foreach (var car in cars)
            {
                if (!comboBoxCarModel.Items.Contains(car.CarModel))
                {
                    comboBoxCarModel.Items.Add(car.CarModel);
                }
                dataGridView.Rows.Add(car.CarId, car.CarModel, car.FuelType, car.EngineSize, car.Rented);
            }
            comboBoxCarModel.SelectedIndex = 0;

        }

        private void InitializeDataGridView()
        {
            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "CarID";
            dataGridView.Columns[1].Name = "Model";
            dataGridView.Columns[2].Name = "Combustibil";
            dataGridView.Columns[3].Name = "Capacitate";
            dataGridView.Columns[4].Name = "Inchiriat";
            dataGridView.Columns["CarID"].Visible = false;
        }

        private void LabelUsernameOnOpen(string username)
        {
            labelUsername.Text = username;
            
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.mainForm.OpenChildForm(new FormLogin(mainForm));
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.mainForm.OpenChildForm(new FormSelectedCar(mainForm));
            if (dataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["CarID"].Value);
                this.mainForm.OpenChildForm(new FormSelectedCar(mainForm, a, username));
            }
            else
            {
                Console.WriteLine("ad");
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {


            bool ok = false;
            List<Car> cars = await RentalCarsAPI.GetCarsAsync();
            foreach (var car in cars)
            {
                if (comboBoxCarModel.SelectedIndex == 0)
                {
                    if (!ok)
                    {
                        dataGridView.Rows.Clear();
                        ok = !ok;
                    }
                    dataGridView.Rows.Add(car.CarId, car.CarModel, car.FuelType, car.EngineSize, car.Rented);
                }
                if (car.CarModel == comboBoxCarModel.SelectedItem.ToString())
                {
                    if (!ok)
                    {
                        dataGridView.Rows.Clear();
                        ok = !ok;
                    }
                    dataGridView.Rows.Add(car.CarId, car.CarModel, car.FuelType, car.EngineSize, car.Rented);
                }
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
            dataGridView.BackgroundColor = Color.White;
            dataGridView.RowHeadersVisible = false;
            dataGridView.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 15, FontStyle.Bold);
            dataGridView.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 15, FontStyle.Bold);
            dataGridView.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 15, FontStyle.Bold);
            dataGridView.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 15, FontStyle.Bold);
            dataGridView.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dataGridView.CurrentCell = null;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView.AllowUserToResizeRows = false;

        }
    }
}
