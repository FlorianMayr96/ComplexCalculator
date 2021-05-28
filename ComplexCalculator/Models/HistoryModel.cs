using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexCalculator.Models
{
    public class HistoryModel
    {
        private List<Calculation> _calculations = new List<Calculation>();

        public void Add(Calculation calculation)
        {
            _calculations.Add(calculation);
        }

        public void Clear()
        {
            _calculations.Clear();
        }

        public int Count()
        {
            return _calculations.Count;
        }

        public Calculation GetCalculationAt(int index)
        {
            return _calculations[index];
        }
    }
}
