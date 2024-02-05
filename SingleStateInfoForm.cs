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
    /*
     * Form to display info for selected state, as described by requirements.
     */
    public partial class SingleStateInfoForm : Form
    {
        public SingleStateInfoForm(string stateName, StateInfoDataContext db)
        {
            InitializeComponent();

            var stateData = db.Tables.Where((state) => state.name == stateName);
            
            foreach(Table state in stateData) // should be exactly one state in this query
            {
                stateNameLabel.Text = "Selected state: " + state.name;
                stateCapitalLabel.Text = "Capital: " + state.capital;
                stateLargestCityLabel.Text = "Largest city: " + state.largest_city;
                statePopulationLabel.Text = "Population: " + state.population;
                stateFlowerLabel.Text = "State flower: " + state.flower;
                stateBirdLabel.Text = "State bird: " + state.bird;
            }
        }
    }
}
