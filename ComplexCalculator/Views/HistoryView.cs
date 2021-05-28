using ComplexCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCalculator.Views
{
    public partial class HistoryView : Form
    {
        public event EventHandler<int> RestoreCalculation;

        public HistoryView()
        {
            InitializeComponent();
        }

        public void AddCalculation(Calculation calculation)
        {
            // create columns
            var subItems = new string[] 
            { 
                calculation.FirstNumber.ToString(),
                calculation.Operation, 
                calculation.SecondNumber.ToString(),
                calculation.Result.ToString() 
            };

            // create row
            ListViewItem item = new ListViewItem(subItems);
            
            // add items
            lv_History.Items.Add(item);
        }

        private void LvHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_History.SelectedIndices.Count > 0)
            {
                int index = lv_History.SelectedIndices[0];
                RestoreCalculation?.Invoke(this, index);
            }
        }

        private void HistoryView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // only hide this view
            e.Cancel = true;
            Hide();
        }
    }
}
