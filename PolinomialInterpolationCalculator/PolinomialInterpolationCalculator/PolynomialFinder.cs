using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolinomialInterpolationCalculator
{
    class PolynomialFinder
    {

        public List<List<State>> StatesMatrix { get; set; }

        public PolynomialFinder()
        {
            StatesMatrix = new List<List<State>>();
        }
        public string FindPolynom(double[] Xs, double[] Ys)
        {
            var B0 = new List<State>();

            for (int i = 0; i < Xs.Length - 1; i++)
            {
                B0[i].Up = Xs[i];
                B0[i].Down = Xs[i + 1];
                B0[i].Value = ((Xs[i + 1] - Xs[i]) / (Ys[i + 1] - Ys[i]));
            }

            StatesMatrix.Add(B0);

            for (int i = 0; i < Xs.Length - 1; i++)
            {
                StatesMatrix.Add(CalculateColumn(Xs, Ys));
            }

            List<double> bs = new List<double>(); 
            foreach (var Column  in StatesMatrix)
            {
                bs.Add(Column[0].Value); 
            }
             

        }

        public List<State> CalculateColumn(double[] Xs, double[] Ys)
        {
            var column = StatesMatrix[StatesMatrix.Count - 1];
            var newcolumn = new List<State>();
            for (int i = 0; i < column.Count; i++)
            {
                newcolumn.Add(
                    new State(
                        column[i + 1].Value,
                        column[i].Value,
                       ((column[i].Down - column[i].Up) / (LowPartOfDivision(StatesMatrix.Count - 1, column[i].Up, column[i].Down)))
                        ));
            }
            return column;
        }

        public double LowPartOfDivision(int nOfColumn, double currentUp, double currentDown)
        {
            return CalculateUp(nOfColumn, currentUp) - CalculateDown(nOfColumn, currentDown);   
        }

        public double CalculateDown(int nOfColumn, double Down)
        {
            if (nOfColumn == 0)
            {
                return StatesMatrix[nOfColumn].ToList().FirstOrDefault(i => i.Down == Down).Down; 
            }
            return CalculateDown(nOfColumn - 1, StatesMatrix[nOfColumn - 1].ToList().FirstOrDefault(i => i.Down == Down).Down); 
        }
        public double CalculateUp(int nOfColumn, double Up)
        {
            if (nOfColumn == 0)
            {
                return StatesMatrix[nOfColumn].ToList().FirstOrDefault(i => i.Up == Up).Up;
            }
            return CalculateUp(nOfColumn - 1, StatesMatrix[nOfColumn - 1].ToList().FirstOrDefault(i => i.Up == Up).Up);
        }
    }
}
