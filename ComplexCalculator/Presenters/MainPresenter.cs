using ComplexCalculator.Models;
using ComplexCalculator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator.Presenters
{
    public class MainPresenter
    {
        private MainView _mainView;
        private HistoryPresenter _historyPresenter;

        public MainPresenter(MainView view)
        {
            _mainView = view;
            _mainView.ShowHistoryView += MainView_ShowHistoryView;
            _mainView.CalculationFinished += MainView_CalculationFinished;

            var historyModel = new HistoryModel();
            var historyView = new HistoryView();
            _historyPresenter = new HistoryPresenter(historyModel, historyView);
            _historyPresenter.RestoreCalculation += HistoryPresenter_RestoreCalculation;
        }

        // --> HistoryPresenter
        private void HistoryPresenter_RestoreCalculation(object sender, Calculation calculation)
        {
            _mainView.RestoreCalculation(calculation);
        }

        // --> MainView
        private void MainView_CalculationFinished(object sender, Calculation calculation)
        {
            _historyPresenter.AddCalculation(calculation);
        }

        // --> MainView
        private void MainView_ShowHistoryView(object sender, EventArgs e)
        {
            _historyPresenter.ShowHistory();
        }

        public void Initialize()
        {
            _mainView.Show();
        }
    }
}
