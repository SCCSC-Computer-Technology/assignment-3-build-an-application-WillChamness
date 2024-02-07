using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace William_Chamness_206_Assignment_3
{
    public partial class StateInfoForm : Form
    {
        private StateInfoDataContext db = new StateInfoDataContext();
        public StateInfoForm()
        {
            InitializeComponent();
        }

        private void StateInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stateInfoDatabaseDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.stateInfoDatabaseDataSet.Table);

            // initialize the comboxboxes and reset the datagrid
            foreach (string stateName in DefaultStateValues.StateNames())
            {
                stateCombobox.Items.Add(stateName);
                updateStateCombobox.Items.Add(stateName);
            }
            resetDatagrid();
        }

        /*
         * Handler for clicking resetButton
         */
        private void resetButton_Click(object sender, EventArgs e)
        {
            resetDatagrid();
        }

        /*
         * Resets the datagrid by getting default data from a static class.
         */
        private void resetDatagrid()
        {
            string[] populations = DefaultStateValues.StatePopulations();
            string[] salaries = DefaultStateValues.StateSalaries();
            string[] otherInfo = DefaultStateValues.StateOtherInfo();
            
            for(int i = 0; i < populations.Length; i++)
            {
                // get the relevant data
                string[] statePopulation = populations[i].Split('\t'); 
                string[] stateSalaries = salaries[i].Split('\t');
                string[] stateOther = otherInfo[i].Split('\t');

                // get the state
                var stateInDB = db.Tables.Where(state => state.name == statePopulation[0]);
                int counter = 0;
                foreach(Table state in stateInDB) // actually execute query
                {
                    counter += 1;
                }
                if (counter > 0) // update the database if there are some items already
                {
                    foreach (var state in stateInDB)
                    {
                        state.name = statePopulation[0];
                        state.population = statePopulation[1];
                        state.capital = stateOther[1];
                        state.largest_city = stateOther[2];
                        state.bird = stateOther[3];
                        state.flower = stateOther[4];
                    }
                }
                else // else populate the database
                {
                    Table state = new Table
                    {
                        name = statePopulation[0],
                        population = statePopulation[1],
                        capital = stateOther[1],
                        largest_city = stateOther[2],
                        bird = stateOther[3],
                        flower = stateOther[4],
                    };
                    db.Tables.InsertOnSubmit(state);
                }
                // regardless of the above cases, submit the changes
                try
                {
                    db.SubmitChanges();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Could not modify database. Please try again");
                    Console.WriteLine(ex);
                    return;
                }
            }
            dataGrid.DataSource = db.Tables; // reset the datagrid
        }

        private void getDetailsButton_Click(object sender, EventArgs e)
        {
            if(stateCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a state");
            }
            else
            {
                SingleStateInfoForm form = new SingleStateInfoForm(stateCombobox.SelectedItem.ToString(), db);
                form.ShowDialog();
            }
        }

        /*
         * Handler for clicking searchButton
         */
        private void searchButton_Click(object sender, EventArgs e)
        {
            string name = searchStateNameTextbox.Text;
            string capital = searchCapitalTextbox.Text;
            string population = searchPopulationTextbox.Text;
            string largestCity = searchLargestCityTextbox.Text;
            string bird = searchBirdTextbox.Text;
            string flower = searchFlowerTextbox.Text;

            var states = db.Tables;

            var results = name != "" ? states.Where((state) => state.name == name) : states;
            results = capital != "" ? results.Where((state) => state.capital == capital) : results;
            results = population != "" ? results.Where((state) => state.population == population) : results;
            results = largestCity != "" ? results.Where((state) => state.largest_city == largestCity) : results;
            results = bird != "" ? results.Where((state) => state.bird == bird) : results;
            results = flower != "" ? results.Where((state) => state.flower== flower) : results;

            dataGrid.DataSource = results;
        }

        /*
         * Handler for clicking sortButton
         */
        private void sortButton_Click(object sender, EventArgs e)
        {
            if (sortNameRadioButton.Checked)
                dataGrid.DataSource = db.Tables.OrderBy((state) => state.name);
            else if (sortCapitalRadioButton.Checked)
                dataGrid.DataSource = db.Tables.OrderBy((state) => state.capital);
            else if (sortLargestCityRadioButton.Checked)
                dataGrid.DataSource = db.Tables.OrderBy((state) => state.largest_city);
            else if (sortPopulationRadioButton.Checked)
                dataGrid.DataSource = db.Tables.OrderBy((state) => state.population);
            else if (sortBirdRadioButton.Checked)
                dataGrid.DataSource = db.Tables.OrderBy((state) => state.bird);
            else if (sortFlowerRadioButton.Checked)
                dataGrid.DataSource = db.Tables.OrderBy((state) => state.flower);
            else
                MessageBox.Show("Please select an option");
        }

        /*
         * Handler for clicking updateButton 
         */
        private void updateButton_Click(object sender, EventArgs e)
        {
            string stateName = updateStateCombobox.SelectedItem.ToString();
            string newValue = updateValueTextbox.Text;
            
            if(newValue == "")
            {
                MessageBox.Show("Please enter a value into the textbox");
                return;
            }

            var states = db.Tables.Where((state) => state.name == stateName); // should be only one state
            try
            {
                foreach (var state in states)
                {
                    if (updateCapitalRadioButton.Checked)
                        state.capital = newValue;
                    else if (updateLargestCityRadioButton.Checked)
                        state.largest_city = newValue;
                    else if (updatePopulationRadioButton.Checked)
                        state.population = newValue;
                    else if (updateBirdRadioButton.Checked)
                        state.bird= newValue;
                    else if (updateFlowerRadioButton.Checked)
                        state.flower = newValue;
                    else
                    {
                        MessageBox.Show("Please select an option");
                        return;
                    }
                }
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not modify the database. Please try again.");
            }


        }

        /*
         * Handler for clicking clearButton
         */
        private void clearButton_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = db.Tables;
            stateCombobox.SelectedIndex = -1;
            searchStateNameTextbox.Text = "";
            searchCapitalTextbox.Text = "";
            searchPopulationTextbox.Text = "";
            searchLargestCityTextbox.Text = "";
            searchFlowerTextbox.Text = "";
            searchBirdTextbox.Text = "";
            updateStateCombobox.SelectedIndex = -1;
            updateValueTextbox.Text = "";
        }

        /*
         * Handler for clicking exitButton
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * Handler for clicking filterButton
         */
        private void filterButton_Click(object sender, EventArgs e)
        {
            string substringToLookFor = filterValueTextbox.Text;
            
            if(substringToLookFor == "")
            {
                MessageBox.Show("Please enter a value into the textbox");
                return;
            }

            IQueryable<Table> results = db.Tables;

            if (filterCaptialRadioButton.Checked)
                results = results.Where((state) => state.capital.Contains(substringToLookFor));
            else if (filterPopulationRadioButton.Checked)
                results = results.Where((state) => state.population.Contains(substringToLookFor));
            else if (filterLargestCityRadioButton.Checked)
                results = results.Where((state) => state.largest_city.Contains(substringToLookFor));
            else if (filterBirdRadioButton.Checked)
                results = results.Where((state) => state.bird.Contains(substringToLookFor));
            else if (filterFlowerRadioButton.Checked)
                results = results.Where((state) => state.flower.Contains(substringToLookFor));
            else
            {
                MessageBox.Show("Please select an option");
                return;
            }

            dataGrid.DataSource = results;
        }
    }
}
