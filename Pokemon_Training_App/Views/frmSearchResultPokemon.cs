using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Training_App.Views
{
    public partial class frmSearchResultPokemon : Form
    {
        private Data.PokemonDataSet.PokemonDataTable Results;

        public frmSearchResultPokemon(Data.PokemonDataSet.PokemonDataTable results)
        {
            InitializeComponent();
            Results = results;
        }

        private void frmSearchResultPokemon_Load(object sender, EventArgs e)
        {
            displayResult();
        }

        private void displayNoResult()
        {
            lvwResults.HeaderStyle = ColumnHeaderStyle.None;
            lblNoResult.Show();
        }

        private void displayResult()
        {
            // display results in lvwResults
            // clear any previous results
            lvwResults.Items.Clear();

            // check if at least one result
            if (Results.Rows.Count > 0)
            {
                // prepare to display results
                // set lvwResult styles
                lvwResults.HeaderStyle = ColumnHeaderStyle.Nonclickable;
                lblNoResult.Hide();

                // enter data
                foreach (DataRow row in Results.Rows)
                {
                    // convert row into item
                    ListViewItem item = convertDataRowToItem(row);

                    // add to lvwResults items
                    lvwResults.Items.Add(item);
                }
            } else
            {
                // no results
                displayNoResult();
            }
        }

        private ListViewItem convertDataRowToItem(DataRow row)
        {
            string[] item = { row[0].ToString(), row[1].ToString() };
            return new ListViewItem(item);
        }
    }
}
