using ComplexCalculator.Models;
using ComplexCalculator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator.Presenters
{
    public class HistoryPresenter
    {
        private HistoryModel _model;
        private HistoryView _view;

        public event EventHandler<Calculation> RestoreCalculation;

        public HistoryPresenter(HistoryModel model, HistoryView view)
        {
            _model = model;
            _view = view;
            _view.RestoreCalculation += View_RestoreCalculation;
        }

        private void View_RestoreCalculation(object sender, int index)
        {
            Calculation calculation = _model.GetCalculationAt(index);
            RestoreCalculation.Invoke(this, calculation);
        }

        internal void AddCalculation(Calculation calculation)
        {
            _model.Add(calculation);
            _view.AddCalculation(calculation);
        }

        internal void ShowHistory()
        {
            _view.ShowDialog();
        }
    }
}
