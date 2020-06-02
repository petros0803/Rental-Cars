namespace RentalCarsForm.Forms
{
    partial class FormLoggedin
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
            this.comboBoxCarModel = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelRentalCars = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCarModel
            // 
            this.comboBoxCarModel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCarModel.FormattingEnabled = true;
            this.comboBoxCarModel.Location = new System.Drawing.Point(305, 78);
            this.comboBoxCarModel.Name = "comboBoxCarModel";
            this.comboBoxCarModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCarModel.TabIndex = 17;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(18, 105);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(754, 444);
            this.dataGridView.TabIndex = 13;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // labelRentalCars
            // 
            this.labelRentalCars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRentalCars.AutoSize = true;
            this.labelRentalCars.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentalCars.Location = new System.Drawing.Point(12, 9);
            this.labelRentalCars.Name = "labelRentalCars";
            this.labelRentalCars.Size = new System.Drawing.Size(287, 31);
            this.labelRentalCars.TabIndex = 21;
            this.labelRentalCars.Text = "Rental cars. Logged in as";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogOut.Location = new System.Drawing.Point(697, 17);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 22;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearch.Location = new System.Drawing.Point(432, 77);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 21);
            this.buttonSearch.TabIndex = 23;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(299, 9);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(0, 31);
            this.labelUsername.TabIndex = 24;
            // 
            // FormLoggedin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelRentalCars);
            this.Controls.Add(this.comboBoxCarModel);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormLoggedin";
            this.Text = "FormLoggedin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCarModel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelRentalCars;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelUsername;
    }
}