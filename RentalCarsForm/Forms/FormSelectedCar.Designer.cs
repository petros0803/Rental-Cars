namespace RentalCarsForm.Forms
{
    partial class FormSelectedCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelModel = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelRentalCars = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPlate = new System.Windows.Forms.Label();
            this.labelManufacture = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelFuel = new System.Windows.Forms.Label();
            this.labelEngine = new System.Windows.Forms.Label();
            this.labelRent = new System.Windows.Forms.Label();
            this.labelCarModel = new System.Windows.Forms.Label();
            this.labelFuelType = new System.Windows.Forms.Label();
            this.labelEngineSize = new System.Windows.Forms.Label();
            this.labelManufactureDate = new System.Windows.Forms.Label();
            this.labelFirstRegistrationDate = new System.Windows.Forms.Label();
            this.labelCarPlate = new System.Windows.Forms.Label();
            this.labelRented = new System.Windows.Forms.Label();
            this.labelRentedDate = new System.Windows.Forms.Label();
            this.labelRentedUntil = new System.Windows.Forms.Label();
            this.buttonRent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelModel
            // 
            this.labelModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(74, 188);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(86, 31);
            this.labelModel.TabIndex = 21;
            this.labelModel.Text = "Model";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBack.Location = new System.Drawing.Point(31, 67);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelRentalCars
            // 
            this.labelRentalCars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRentalCars.AutoSize = true;
            this.labelRentalCars.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentalCars.Location = new System.Drawing.Point(25, 22);
            this.labelRentalCars.Name = "labelRentalCars";
            this.labelRentalCars.Size = new System.Drawing.Size(287, 31);
            this.labelRentalCars.TabIndex = 25;
            this.labelRentalCars.Text = "Rental cars. Logged in as";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(312, 22);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 31);
            this.labelUsername.TabIndex = 26;
            // 
            // labelPlate
            // 
            this.labelPlate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPlate.AutoSize = true;
            this.labelPlate.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlate.Location = new System.Drawing.Point(74, 281);
            this.labelPlate.Name = "labelPlate";
            this.labelPlate.Size = new System.Drawing.Size(272, 31);
            this.labelPlate.TabIndex = 27;
            this.labelPlate.Text = "Numar de inmatriculare";
            // 
            // labelManufacture
            // 
            this.labelManufacture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelManufacture.AutoSize = true;
            this.labelManufacture.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManufacture.Location = new System.Drawing.Point(74, 343);
            this.labelManufacture.Name = "labelManufacture";
            this.labelManufacture.Size = new System.Drawing.Size(206, 31);
            this.labelManufacture.TabIndex = 28;
            this.labelManufacture.Text = "Data de fabricatie";
            // 
            // labelFirst
            // 
            this.labelFirst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFirst.AutoSize = true;
            this.labelFirst.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirst.Location = new System.Drawing.Point(74, 312);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(228, 31);
            this.labelFirst.TabIndex = 29;
            this.labelFirst.Text = "Prima inmatriculare";
            // 
            // labelFuel
            // 
            this.labelFuel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFuel.AutoSize = true;
            this.labelFuel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuel.Location = new System.Drawing.Point(74, 219);
            this.labelFuel.Name = "labelFuel";
            this.labelFuel.Size = new System.Drawing.Size(148, 31);
            this.labelFuel.TabIndex = 30;
            this.labelFuel.Text = "Combustibil";
            // 
            // labelEngine
            // 
            this.labelEngine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEngine.AutoSize = true;
            this.labelEngine.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEngine.Location = new System.Drawing.Point(74, 250);
            this.labelEngine.Name = "labelEngine";
            this.labelEngine.Size = new System.Drawing.Size(201, 31);
            this.labelEngine.TabIndex = 31;
            this.labelEngine.Text = "Capacitate motor";
            // 
            // labelRent
            // 
            this.labelRent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRent.AutoSize = true;
            this.labelRent.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRent.Location = new System.Drawing.Point(74, 374);
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(105, 31);
            this.labelRent.TabIndex = 32;
            this.labelRent.Text = "Inchiriat";
            // 
            // labelCarModel
            // 
            this.labelCarModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCarModel.AutoSize = true;
            this.labelCarModel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarModel.Location = new System.Drawing.Point(477, 188);
            this.labelCarModel.Name = "labelCarModel";
            this.labelCarModel.Size = new System.Drawing.Size(86, 31);
            this.labelCarModel.TabIndex = 36;
            this.labelCarModel.Text = "Model";
            // 
            // labelFuelType
            // 
            this.labelFuelType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFuelType.AutoSize = true;
            this.labelFuelType.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelType.Location = new System.Drawing.Point(477, 219);
            this.labelFuelType.Name = "labelFuelType";
            this.labelFuelType.Size = new System.Drawing.Size(86, 31);
            this.labelFuelType.TabIndex = 37;
            this.labelFuelType.Text = "Model";
            // 
            // labelEngineSize
            // 
            this.labelEngineSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEngineSize.AutoSize = true;
            this.labelEngineSize.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEngineSize.Location = new System.Drawing.Point(477, 250);
            this.labelEngineSize.Name = "labelEngineSize";
            this.labelEngineSize.Size = new System.Drawing.Size(86, 31);
            this.labelEngineSize.TabIndex = 38;
            this.labelEngineSize.Text = "Model";
            // 
            // labelManufactureDate
            // 
            this.labelManufactureDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelManufactureDate.AutoSize = true;
            this.labelManufactureDate.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManufactureDate.Location = new System.Drawing.Point(477, 343);
            this.labelManufactureDate.Name = "labelManufactureDate";
            this.labelManufactureDate.Size = new System.Drawing.Size(86, 31);
            this.labelManufactureDate.TabIndex = 41;
            this.labelManufactureDate.Text = "Model";
            // 
            // labelFirstRegistrationDate
            // 
            this.labelFirstRegistrationDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFirstRegistrationDate.AutoSize = true;
            this.labelFirstRegistrationDate.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstRegistrationDate.Location = new System.Drawing.Point(477, 312);
            this.labelFirstRegistrationDate.Name = "labelFirstRegistrationDate";
            this.labelFirstRegistrationDate.Size = new System.Drawing.Size(86, 31);
            this.labelFirstRegistrationDate.TabIndex = 40;
            this.labelFirstRegistrationDate.Text = "Model";
            // 
            // labelCarPlate
            // 
            this.labelCarPlate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCarPlate.AutoSize = true;
            this.labelCarPlate.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarPlate.Location = new System.Drawing.Point(477, 281);
            this.labelCarPlate.Name = "labelCarPlate";
            this.labelCarPlate.Size = new System.Drawing.Size(86, 31);
            this.labelCarPlate.TabIndex = 39;
            this.labelCarPlate.Text = "Model";
            // 
            // labelRented
            // 
            this.labelRented.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRented.AutoSize = true;
            this.labelRented.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRented.Location = new System.Drawing.Point(477, 374);
            this.labelRented.Name = "labelRented";
            this.labelRented.Size = new System.Drawing.Size(86, 31);
            this.labelRented.TabIndex = 42;
            this.labelRented.Text = "Model";
            // 
            // labelRentedDate
            // 
            this.labelRentedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRentedDate.AutoSize = true;
            this.labelRentedDate.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentedDate.Location = new System.Drawing.Point(74, 405);
            this.labelRentedDate.Name = "labelRentedDate";
            this.labelRentedDate.Size = new System.Drawing.Size(277, 31);
            this.labelRentedDate.TabIndex = 43;
            this.labelRentedDate.Text = "Inchiriat pana la data de";
            // 
            // labelRentedUntil
            // 
            this.labelRentedUntil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRentedUntil.AutoSize = true;
            this.labelRentedUntil.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentedUntil.Location = new System.Drawing.Point(477, 405);
            this.labelRentedUntil.Name = "labelRentedUntil";
            this.labelRentedUntil.Size = new System.Drawing.Size(86, 31);
            this.labelRentedUntil.TabIndex = 44;
            this.labelRentedUntil.Text = "Model";
            // 
            // buttonRent
            // 
            this.buttonRent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRent.Location = new System.Drawing.Point(308, 459);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(105, 32);
            this.buttonRent.TabIndex = 45;
            this.buttonRent.Text = "Back";
            this.buttonRent.UseVisualStyleBackColor = false;
            this.buttonRent.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // FormSelectedCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.labelRentedUntil);
            this.Controls.Add(this.labelRentedDate);
            this.Controls.Add(this.labelRented);
            this.Controls.Add(this.labelManufactureDate);
            this.Controls.Add(this.labelFirstRegistrationDate);
            this.Controls.Add(this.labelCarPlate);
            this.Controls.Add(this.labelEngineSize);
            this.Controls.Add(this.labelFuelType);
            this.Controls.Add(this.labelCarModel);
            this.Controls.Add(this.labelRent);
            this.Controls.Add(this.labelEngine);
            this.Controls.Add(this.labelFuel);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.labelManufacture);
            this.Controls.Add(this.labelPlate);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelRentalCars);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelModel);
            this.Name = "FormSelectedCar";
            this.Text = "FormSelectedCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelRentalCars;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPlate;
        private System.Windows.Forms.Label labelManufacture;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelFuel;
        private System.Windows.Forms.Label labelEngine;
        private System.Windows.Forms.Label labelRent;
        private System.Windows.Forms.Label labelCarModel;
        private System.Windows.Forms.Label labelFuelType;
        private System.Windows.Forms.Label labelEngineSize;
        private System.Windows.Forms.Label labelManufactureDate;
        private System.Windows.Forms.Label labelFirstRegistrationDate;
        private System.Windows.Forms.Label labelCarPlate;
        private System.Windows.Forms.Label labelRented;
        private System.Windows.Forms.Label labelRentedDate;
        private System.Windows.Forms.Label labelRentedUntil;
        private System.Windows.Forms.Button buttonRent;
    }
}