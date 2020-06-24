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
    public partial class FormHistory : Form
    {
        string username;
        private MainForm mainForm;
        public FormHistory(MainForm mainForm, string username)
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
            List<History> histories = await RentalCarsAPI.GetHistoryAsync();
            comboBoxHistory.Items.Add("ALL");
            comboBoxHistory.Items.Add("Prenume");
            comboBoxHistory.Items.Add("Nume");
            comboBoxHistory.Items.Add("CNP");

            foreach (var history in histories)
            {
                dataGridView.Rows.Add(history.PersonId, history.FirstName, history.LastName, history.CNP, history.Counter);
            }
            comboBoxHistory.SelectedIndex = 0;
        }
        private void InitializeDataGridView()
        {
            dataGridView.Rows.Clear();
            dataGridView.ColumnCount = 5;
            dataGridView.Columns[0].Name = "PersonId";
            dataGridView.Columns[1].Name = "Prenumele";
            dataGridView.Columns[2].Name = "Numele";
            dataGridView.Columns[3].Name = "CNP";
            dataGridView.Columns[4].Name = "Inchirieri";
            dataGridView.Columns["PersonId"].Visible = false;
        }
        private void LabelUsernameOnOpen(string username)
        {
            labelUsername.Text = username;

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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.mainForm.OpenChildForm(new FormLoggedin(mainForm, username));
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            bool ok = false;
            List<History> histories = await RentalCarsAPI.GetHistoryAsync();
            foreach (var history in histories)
            {
                if (comboBoxHistory.SelectedIndex == 0)
                {
                    if (!ok)
                    {
                        dataGridView.Rows.Clear();
                        ok = !ok;
                    }
                    dataGridView.Rows.Add(history.PersonId, history.FirstName, history.LastName, history.CNP, history.Counter);
                }
                if (comboBoxHistory.SelectedIndex == 1)
                {

                    if (!ok)
                    {
                        dataGridView.Rows.Clear();
                        ok = !ok;
                    }
                    if (history.FirstName == textBoxSearch.Text)
                    {
                        dataGridView.Rows.Add(history.PersonId, history.FirstName, history.LastName, history.CNP, history.Counter);
                    }
                }
                if (comboBoxHistory.SelectedIndex == 2)
                {
                    if (!ok)
                    {
                        dataGridView.Rows.Clear();
                        ok = !ok;
                    }
                    if (history.LastName == textBoxSearch.Text)
                    {
                        dataGridView.Rows.Add(history.PersonId, history.FirstName, history.LastName, history.CNP, history.Counter);
                    }
                }
                if (comboBoxHistory.SelectedIndex == 3)
                {
                    if (!ok)
                    {
                        dataGridView.Rows.Clear();
                        ok = !ok;
                    }
                    if (history.CNP == textBoxSearch.Text)
                    {
                        dataGridView.Rows.Add(history.PersonId, history.FirstName, history.LastName, history.CNP, history.Counter);
                    }
                }
            }
        }
        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //this.mainForm.OpenChildForm(new FormSelectedCar(mainForm));
            if (dataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["CNP"].Value);
                this.mainForm.OpenChildForm(new FormPerson(mainForm, 0, username, a));
            }
            else
            {
                Console.WriteLine("ad");
            }
        }
    }
}
