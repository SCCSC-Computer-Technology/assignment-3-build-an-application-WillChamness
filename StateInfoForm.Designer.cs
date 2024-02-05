
namespace William_Chamness_206_Assignment_3
{
    partial class StateInfoForm
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
            this.components = new System.ComponentModel.Container();
            this.resetButton = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stateInfoDatabaseDataSet = new William_Chamness_206_Assignment_3.StateInfoDatabaseDataSet();
            this.tableTableAdapter = new William_Chamness_206_Assignment_3.StateInfoDatabaseDataSetTableAdapters.TableTableAdapter();
            this.stateCombobox = new System.Windows.Forms.ComboBox();
            this.getDetailsButton = new System.Windows.Forms.Button();
            this.flowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largestcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.searchStateNameTextbox = new System.Windows.Forms.TextBox();
            this.searchCapitalTextbox = new System.Windows.Forms.TextBox();
            this.searchPopulationTextbox = new System.Windows.Forms.TextBox();
            this.searchLargestCityTextbox = new System.Windows.Forms.TextBox();
            this.searchBirdTextbox = new System.Windows.Forms.TextBox();
            this.searchFlowerTextbox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.capitalLabel = new System.Windows.Forms.Label();
            this.populationLabel = new System.Windows.Forms.Label();
            this.largestCityLabel = new System.Windows.Forms.Label();
            this.birdLabel = new System.Windows.Forms.Label();
            this.flowerLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchGroupbox = new System.Windows.Forms.GroupBox();
            this.sortGroupbox = new System.Windows.Forms.GroupBox();
            this.sortNameRadioButton = new System.Windows.Forms.RadioButton();
            this.sortCapitalRadioButton = new System.Windows.Forms.RadioButton();
            this.sortPopulationRadioButton = new System.Windows.Forms.RadioButton();
            this.sortLargestCityRadioButton = new System.Windows.Forms.RadioButton();
            this.sortBirdRadioButton = new System.Windows.Forms.RadioButton();
            this.sortFlowerRadioButton = new System.Windows.Forms.RadioButton();
            this.sortButton = new System.Windows.Forms.Button();
            this.updateGroupbox = new System.Windows.Forms.GroupBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.updateFlowerRadioButton = new System.Windows.Forms.RadioButton();
            this.updateBirdRadioButton = new System.Windows.Forms.RadioButton();
            this.updateLargestCityRadioButton = new System.Windows.Forms.RadioButton();
            this.updatePopulationRadioButton = new System.Windows.Forms.RadioButton();
            this.updateCapitalRadioButton = new System.Windows.Forms.RadioButton();
            this.updateStateCombobox = new System.Windows.Forms.ComboBox();
            this.updateValueTextbox = new System.Windows.Forms.TextBox();
            this.updateValueLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.searchGroupbox.SuspendLayout();
            this.sortGroupbox.SuspendLayout();
            this.updateGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 505);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.stateInfoDatabaseDataSet;
            // 
            // stateInfoDatabaseDataSet
            // 
            this.stateInfoDatabaseDataSet.DataSetName = "StateInfoDatabaseDataSet";
            this.stateInfoDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // stateCombobox
            // 
            this.stateCombobox.FormattingEnabled = true;
            this.stateCombobox.Location = new System.Drawing.Point(47, 215);
            this.stateCombobox.Name = "stateCombobox";
            this.stateCombobox.Size = new System.Drawing.Size(121, 21);
            this.stateCombobox.TabIndex = 2;
            // 
            // getDetailsButton
            // 
            this.getDetailsButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.getDetailsButton.Location = new System.Drawing.Point(47, 242);
            this.getDetailsButton.Name = "getDetailsButton";
            this.getDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.getDetailsButton.TabIndex = 3;
            this.getDetailsButton.Text = "Get Details";
            this.getDetailsButton.UseVisualStyleBackColor = true;
            this.getDetailsButton.Click += new System.EventHandler(this.getDetailsButton_Click);
            // 
            // flowerDataGridViewTextBoxColumn
            // 
            this.flowerDataGridViewTextBoxColumn.DataPropertyName = "flower";
            this.flowerDataGridViewTextBoxColumn.HeaderText = "flower";
            this.flowerDataGridViewTextBoxColumn.Name = "flowerDataGridViewTextBoxColumn";
            // 
            // birdDataGridViewTextBoxColumn
            // 
            this.birdDataGridViewTextBoxColumn.DataPropertyName = "bird";
            this.birdDataGridViewTextBoxColumn.HeaderText = "bird";
            this.birdDataGridViewTextBoxColumn.Name = "birdDataGridViewTextBoxColumn";
            // 
            // largestcityDataGridViewTextBoxColumn
            // 
            this.largestcityDataGridViewTextBoxColumn.DataPropertyName = "largest_city";
            this.largestcityDataGridViewTextBoxColumn.HeaderText = "largest_city";
            this.largestcityDataGridViewTextBoxColumn.Name = "largestcityDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // capitalDataGridViewTextBoxColumn
            // 
            this.capitalDataGridViewTextBoxColumn.DataPropertyName = "capital";
            this.capitalDataGridViewTextBoxColumn.HeaderText = "capital";
            this.capitalDataGridViewTextBoxColumn.Name = "capitalDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dataGrid
            // 
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.capitalDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.largestcityDataGridViewTextBoxColumn,
            this.birdDataGridViewTextBoxColumn,
            this.flowerDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.tableBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(47, 26);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(691, 150);
            this.dataGrid.TabIndex = 1;
            // 
            // searchStateNameTextbox
            // 
            this.searchStateNameTextbox.Location = new System.Drawing.Point(72, 18);
            this.searchStateNameTextbox.Name = "searchStateNameTextbox";
            this.searchStateNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.searchStateNameTextbox.TabIndex = 4;
            // 
            // searchCapitalTextbox
            // 
            this.searchCapitalTextbox.Location = new System.Drawing.Point(72, 44);
            this.searchCapitalTextbox.Name = "searchCapitalTextbox";
            this.searchCapitalTextbox.Size = new System.Drawing.Size(100, 20);
            this.searchCapitalTextbox.TabIndex = 5;
            // 
            // searchPopulationTextbox
            // 
            this.searchPopulationTextbox.Location = new System.Drawing.Point(72, 70);
            this.searchPopulationTextbox.Name = "searchPopulationTextbox";
            this.searchPopulationTextbox.Size = new System.Drawing.Size(100, 20);
            this.searchPopulationTextbox.TabIndex = 6;
            // 
            // searchLargestCityTextbox
            // 
            this.searchLargestCityTextbox.Location = new System.Drawing.Point(72, 96);
            this.searchLargestCityTextbox.Name = "searchLargestCityTextbox";
            this.searchLargestCityTextbox.Size = new System.Drawing.Size(100, 20);
            this.searchLargestCityTextbox.TabIndex = 7;
            // 
            // searchBirdTextbox
            // 
            this.searchBirdTextbox.Location = new System.Drawing.Point(72, 122);
            this.searchBirdTextbox.Name = "searchBirdTextbox";
            this.searchBirdTextbox.Size = new System.Drawing.Size(100, 20);
            this.searchBirdTextbox.TabIndex = 8;
            // 
            // searchFlowerTextbox
            // 
            this.searchFlowerTextbox.Location = new System.Drawing.Point(72, 148);
            this.searchFlowerTextbox.Name = "searchFlowerTextbox";
            this.searchFlowerTextbox.Size = new System.Drawing.Size(100, 20);
            this.searchFlowerTextbox.TabIndex = 9;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(28, 21);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name:";
            // 
            // capitalLabel
            // 
            this.capitalLabel.AutoSize = true;
            this.capitalLabel.Location = new System.Drawing.Point(24, 47);
            this.capitalLabel.Name = "capitalLabel";
            this.capitalLabel.Size = new System.Drawing.Size(42, 13);
            this.capitalLabel.TabIndex = 11;
            this.capitalLabel.Text = "Captial:";
            // 
            // populationLabel
            // 
            this.populationLabel.AutoSize = true;
            this.populationLabel.Location = new System.Drawing.Point(6, 73);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(60, 13);
            this.populationLabel.TabIndex = 12;
            this.populationLabel.Text = "Population:";
            // 
            // largestCityLabel
            // 
            this.largestCityLabel.AutoSize = true;
            this.largestCityLabel.Location = new System.Drawing.Point(1, 99);
            this.largestCityLabel.Name = "largestCityLabel";
            this.largestCityLabel.Size = new System.Drawing.Size(65, 13);
            this.largestCityLabel.TabIndex = 13;
            this.largestCityLabel.Text = "Largest City:";
            // 
            // birdLabel
            // 
            this.birdLabel.AutoSize = true;
            this.birdLabel.Location = new System.Drawing.Point(38, 125);
            this.birdLabel.Name = "birdLabel";
            this.birdLabel.Size = new System.Drawing.Size(28, 13);
            this.birdLabel.TabIndex = 14;
            this.birdLabel.Text = "Bird:";
            // 
            // flowerLabel
            // 
            this.flowerLabel.AutoSize = true;
            this.flowerLabel.Location = new System.Drawing.Point(24, 151);
            this.flowerLabel.Name = "flowerLabel";
            this.flowerLabel.Size = new System.Drawing.Size(41, 13);
            this.flowerLabel.TabIndex = 15;
            this.flowerLabel.Text = "Flower:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(72, 174);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchGroupbox
            // 
            this.searchGroupbox.Controls.Add(this.searchBirdTextbox);
            this.searchGroupbox.Controls.Add(this.searchStateNameTextbox);
            this.searchGroupbox.Controls.Add(this.searchButton);
            this.searchGroupbox.Controls.Add(this.searchCapitalTextbox);
            this.searchGroupbox.Controls.Add(this.flowerLabel);
            this.searchGroupbox.Controls.Add(this.searchPopulationTextbox);
            this.searchGroupbox.Controls.Add(this.birdLabel);
            this.searchGroupbox.Controls.Add(this.searchLargestCityTextbox);
            this.searchGroupbox.Controls.Add(this.largestCityLabel);
            this.searchGroupbox.Controls.Add(this.searchFlowerTextbox);
            this.searchGroupbox.Controls.Add(this.populationLabel);
            this.searchGroupbox.Controls.Add(this.nameLabel);
            this.searchGroupbox.Controls.Add(this.capitalLabel);
            this.searchGroupbox.Location = new System.Drawing.Point(209, 215);
            this.searchGroupbox.Name = "searchGroupbox";
            this.searchGroupbox.Size = new System.Drawing.Size(200, 212);
            this.searchGroupbox.TabIndex = 18;
            this.searchGroupbox.TabStop = false;
            this.searchGroupbox.Text = "Search";
            // 
            // sortGroupbox
            // 
            this.sortGroupbox.Controls.Add(this.sortButton);
            this.sortGroupbox.Controls.Add(this.sortFlowerRadioButton);
            this.sortGroupbox.Controls.Add(this.sortBirdRadioButton);
            this.sortGroupbox.Controls.Add(this.sortLargestCityRadioButton);
            this.sortGroupbox.Controls.Add(this.sortPopulationRadioButton);
            this.sortGroupbox.Controls.Add(this.sortCapitalRadioButton);
            this.sortGroupbox.Controls.Add(this.sortNameRadioButton);
            this.sortGroupbox.Location = new System.Drawing.Point(415, 215);
            this.sortGroupbox.Name = "sortGroupbox";
            this.sortGroupbox.Size = new System.Drawing.Size(192, 212);
            this.sortGroupbox.TabIndex = 19;
            this.sortGroupbox.TabStop = false;
            this.sortGroupbox.Text = "Sort";
            // 
            // sortNameRadioButton
            // 
            this.sortNameRadioButton.AutoSize = true;
            this.sortNameRadioButton.Location = new System.Drawing.Point(51, 28);
            this.sortNameRadioButton.Name = "sortNameRadioButton";
            this.sortNameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.sortNameRadioButton.TabIndex = 0;
            this.sortNameRadioButton.TabStop = true;
            this.sortNameRadioButton.Text = "Name";
            this.sortNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortCapitalRadioButton
            // 
            this.sortCapitalRadioButton.AutoSize = true;
            this.sortCapitalRadioButton.Location = new System.Drawing.Point(51, 51);
            this.sortCapitalRadioButton.Name = "sortCapitalRadioButton";
            this.sortCapitalRadioButton.Size = new System.Drawing.Size(57, 17);
            this.sortCapitalRadioButton.TabIndex = 1;
            this.sortCapitalRadioButton.TabStop = true;
            this.sortCapitalRadioButton.Text = "Capital";
            this.sortCapitalRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortPopulationRadioButton
            // 
            this.sortPopulationRadioButton.AutoSize = true;
            this.sortPopulationRadioButton.Location = new System.Drawing.Point(51, 74);
            this.sortPopulationRadioButton.Name = "sortPopulationRadioButton";
            this.sortPopulationRadioButton.Size = new System.Drawing.Size(75, 17);
            this.sortPopulationRadioButton.TabIndex = 2;
            this.sortPopulationRadioButton.TabStop = true;
            this.sortPopulationRadioButton.Text = "Population";
            this.sortPopulationRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortLargestCityRadioButton
            // 
            this.sortLargestCityRadioButton.AutoSize = true;
            this.sortLargestCityRadioButton.Location = new System.Drawing.Point(51, 95);
            this.sortLargestCityRadioButton.Name = "sortLargestCityRadioButton";
            this.sortLargestCityRadioButton.Size = new System.Drawing.Size(80, 17);
            this.sortLargestCityRadioButton.TabIndex = 3;
            this.sortLargestCityRadioButton.TabStop = true;
            this.sortLargestCityRadioButton.Text = "Largest City";
            this.sortLargestCityRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortBirdRadioButton
            // 
            this.sortBirdRadioButton.AutoSize = true;
            this.sortBirdRadioButton.Location = new System.Drawing.Point(51, 118);
            this.sortBirdRadioButton.Name = "sortBirdRadioButton";
            this.sortBirdRadioButton.Size = new System.Drawing.Size(43, 17);
            this.sortBirdRadioButton.TabIndex = 4;
            this.sortBirdRadioButton.TabStop = true;
            this.sortBirdRadioButton.Text = "Bird";
            this.sortBirdRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortFlowerRadioButton
            // 
            this.sortFlowerRadioButton.AutoSize = true;
            this.sortFlowerRadioButton.Location = new System.Drawing.Point(51, 141);
            this.sortFlowerRadioButton.Name = "sortFlowerRadioButton";
            this.sortFlowerRadioButton.Size = new System.Drawing.Size(56, 17);
            this.sortFlowerRadioButton.TabIndex = 5;
            this.sortFlowerRadioButton.TabStop = true;
            this.sortFlowerRadioButton.Text = "Flower";
            this.sortFlowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(51, 174);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 6;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // updateGroupbox
            // 
            this.updateGroupbox.Controls.Add(this.updateValueLabel);
            this.updateGroupbox.Controls.Add(this.updateValueTextbox);
            this.updateGroupbox.Controls.Add(this.updateStateCombobox);
            this.updateGroupbox.Controls.Add(this.updateButton);
            this.updateGroupbox.Controls.Add(this.updateFlowerRadioButton);
            this.updateGroupbox.Controls.Add(this.updateBirdRadioButton);
            this.updateGroupbox.Controls.Add(this.updateLargestCityRadioButton);
            this.updateGroupbox.Controls.Add(this.updatePopulationRadioButton);
            this.updateGroupbox.Controls.Add(this.updateCapitalRadioButton);
            this.updateGroupbox.Location = new System.Drawing.Point(613, 215);
            this.updateGroupbox.Name = "updateGroupbox";
            this.updateGroupbox.Size = new System.Drawing.Size(192, 257);
            this.updateGroupbox.TabIndex = 20;
            this.updateGroupbox.TabStop = false;
            this.updateGroupbox.Text = "Update";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(50, 214);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 6;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updateFlowerRadioButton
            // 
            this.updateFlowerRadioButton.AutoSize = true;
            this.updateFlowerRadioButton.Location = new System.Drawing.Point(18, 145);
            this.updateFlowerRadioButton.Name = "updateFlowerRadioButton";
            this.updateFlowerRadioButton.Size = new System.Drawing.Size(56, 17);
            this.updateFlowerRadioButton.TabIndex = 5;
            this.updateFlowerRadioButton.TabStop = true;
            this.updateFlowerRadioButton.Text = "Flower";
            this.updateFlowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateBirdRadioButton
            // 
            this.updateBirdRadioButton.AutoSize = true;
            this.updateBirdRadioButton.Location = new System.Drawing.Point(18, 122);
            this.updateBirdRadioButton.Name = "updateBirdRadioButton";
            this.updateBirdRadioButton.Size = new System.Drawing.Size(43, 17);
            this.updateBirdRadioButton.TabIndex = 4;
            this.updateBirdRadioButton.TabStop = true;
            this.updateBirdRadioButton.Text = "Bird";
            this.updateBirdRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateLargestCityRadioButton
            // 
            this.updateLargestCityRadioButton.AutoSize = true;
            this.updateLargestCityRadioButton.Location = new System.Drawing.Point(18, 99);
            this.updateLargestCityRadioButton.Name = "updateLargestCityRadioButton";
            this.updateLargestCityRadioButton.Size = new System.Drawing.Size(80, 17);
            this.updateLargestCityRadioButton.TabIndex = 3;
            this.updateLargestCityRadioButton.TabStop = true;
            this.updateLargestCityRadioButton.Text = "Largest City";
            this.updateLargestCityRadioButton.UseVisualStyleBackColor = true;
            // 
            // updatePopulationRadioButton
            // 
            this.updatePopulationRadioButton.AutoSize = true;
            this.updatePopulationRadioButton.Location = new System.Drawing.Point(18, 78);
            this.updatePopulationRadioButton.Name = "updatePopulationRadioButton";
            this.updatePopulationRadioButton.Size = new System.Drawing.Size(75, 17);
            this.updatePopulationRadioButton.TabIndex = 2;
            this.updatePopulationRadioButton.TabStop = true;
            this.updatePopulationRadioButton.Text = "Population";
            this.updatePopulationRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateCapitalRadioButton
            // 
            this.updateCapitalRadioButton.AutoSize = true;
            this.updateCapitalRadioButton.Location = new System.Drawing.Point(18, 55);
            this.updateCapitalRadioButton.Name = "updateCapitalRadioButton";
            this.updateCapitalRadioButton.Size = new System.Drawing.Size(57, 17);
            this.updateCapitalRadioButton.TabIndex = 1;
            this.updateCapitalRadioButton.TabStop = true;
            this.updateCapitalRadioButton.Text = "Capital";
            this.updateCapitalRadioButton.UseVisualStyleBackColor = true;
            // 
            // updateStateCombobox
            // 
            this.updateStateCombobox.FormattingEnabled = true;
            this.updateStateCombobox.Location = new System.Drawing.Point(18, 27);
            this.updateStateCombobox.Name = "updateStateCombobox";
            this.updateStateCombobox.Size = new System.Drawing.Size(121, 21);
            this.updateStateCombobox.TabIndex = 21;
            // 
            // updateValueTextbox
            // 
            this.updateValueTextbox.Location = new System.Drawing.Point(61, 168);
            this.updateValueTextbox.Name = "updateValueTextbox";
            this.updateValueTextbox.Size = new System.Drawing.Size(100, 20);
            this.updateValueTextbox.TabIndex = 22;
            // 
            // updateValueLabel
            // 
            this.updateValueLabel.AutoSize = true;
            this.updateValueLabel.Location = new System.Drawing.Point(18, 171);
            this.updateValueLabel.Name = "updateValueLabel";
            this.updateValueLabel.Size = new System.Drawing.Size(37, 13);
            this.updateValueLabel.TabIndex = 23;
            this.updateValueLabel.Text = "Value:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(723, 505);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(804, 505);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // StateInfoForm
            // 
            this.AcceptButton = this.clearButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(891, 540);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateGroupbox);
            this.Controls.Add(this.sortGroupbox);
            this.Controls.Add(this.searchGroupbox);
            this.Controls.Add(this.getDetailsButton);
            this.Controls.Add(this.stateCombobox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.resetButton);
            this.Name = "StateInfoForm";
            this.Text = "State Info Form";
            this.Load += new System.EventHandler(this.StateInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.searchGroupbox.ResumeLayout(false);
            this.searchGroupbox.PerformLayout();
            this.sortGroupbox.ResumeLayout(false);
            this.sortGroupbox.PerformLayout();
            this.updateGroupbox.ResumeLayout(false);
            this.updateGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private StateInfoDatabaseDataSet stateInfoDatabaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private StateInfoDatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.ComboBox stateCombobox;
        private System.Windows.Forms.Button getDetailsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn flowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn largestcityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox searchStateNameTextbox;
        private System.Windows.Forms.TextBox searchCapitalTextbox;
        private System.Windows.Forms.TextBox searchPopulationTextbox;
        private System.Windows.Forms.TextBox searchLargestCityTextbox;
        private System.Windows.Forms.TextBox searchBirdTextbox;
        private System.Windows.Forms.TextBox searchFlowerTextbox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label capitalLabel;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.Label largestCityLabel;
        private System.Windows.Forms.Label birdLabel;
        private System.Windows.Forms.Label flowerLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox searchGroupbox;
        private System.Windows.Forms.GroupBox sortGroupbox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.RadioButton sortFlowerRadioButton;
        private System.Windows.Forms.RadioButton sortBirdRadioButton;
        private System.Windows.Forms.RadioButton sortLargestCityRadioButton;
        private System.Windows.Forms.RadioButton sortPopulationRadioButton;
        private System.Windows.Forms.RadioButton sortCapitalRadioButton;
        private System.Windows.Forms.RadioButton sortNameRadioButton;
        private System.Windows.Forms.GroupBox updateGroupbox;
        private System.Windows.Forms.Label updateValueLabel;
        private System.Windows.Forms.TextBox updateValueTextbox;
        private System.Windows.Forms.ComboBox updateStateCombobox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.RadioButton updateFlowerRadioButton;
        private System.Windows.Forms.RadioButton updateBirdRadioButton;
        private System.Windows.Forms.RadioButton updateLargestCityRadioButton;
        private System.Windows.Forms.RadioButton updatePopulationRadioButton;
        private System.Windows.Forms.RadioButton updateCapitalRadioButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

