using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolinomialInterpolationCalculator
{
    class PolynomialFinder
    {
        public List<List<State>> StatesMatrix { get; set; }

        public PolynomialFinder()
        {
            StatesMatrix = new List<List<State>>();
        }

        public string FindPolynom(List<double> Xs, List<double> Ys)
        {
            var B0 = new List<State>();

            for (int i = 0; i < Xs.Count - 1; i++)
            {
                B0.Add(
                    new State(Xs[i], Xs[i + 1], ((Ys[i + 1] - Ys[i]) / (Xs[i + 1] - Xs[i])))
                    );
            }

            StatesMatrix.Add(B0);

            for (int i = 0; i < Xs.Count - 2; i++)
            {
                Console.WriteLine($"Column Separator{StatesMatrix.Count - 1}");

                StatesMatrix.Add(CalculateColumn(StatesMatrix.Count - 1));
            }

            return StringCalculator(Xs, Ys);
        }

        public List<State> CalculateColumn(int lastColumnIndex)
        {
            var column = StatesMatrix[lastColumnIndex];
            var newcolumn = new List<State>();
            for (int i = 0; i < column.Count - 1; i++)
            {
                Console.WriteLine($"up: {column[i].Up}, down:{column[i + 1].Down}, value: {lastColumnIndex}");

                newcolumn.Add(
                    new State(
                        column[i].Value,
                        column[i + 1].Value,
                       ((column[i + 1].Value - column[i].Value) / (LowPartOfDivision(lastColumnIndex, column[i].Up, column[i + 1].Down)))
                        ));

                Console.WriteLine($"total: {newcolumn[i].Value}");
            }
            return newcolumn;
        }

        public double LowPartOfDivision(int nOfColumn, double currentUp, double currentDown)
        {
            return (CalculateDown(nOfColumn, currentDown) - CalculateUp(nOfColumn, currentUp));
        }

        public double CalculateDown(int nOfColumn, double Down)
        {
            if (nOfColumn == 0)
            {
                // Console.WriteLine($"down: {StatesMatrix[nOfColumn].ToList().FirstOrDefault(i => i.Down == Down).Down}");

                return StatesMatrix[nOfColumn].ToList().FirstOrDefault(i => i.Down == Down).Down;

            }
            if (nOfColumn == 1)
            {
                return StatesMatrix[nOfColumn - 1].ToList().FirstOrDefault(i => i.Value == Down).Down;
            }

            return CalculateDown(nOfColumn - 1, StatesMatrix[nOfColumn - 1].ToList().FirstOrDefault(i => i.Down == Down).Down);
        }


        public double CalculateUp(int nOfColumn, double Up)
        {
            if (nOfColumn == 0)
            {
                // Console.WriteLine($"up:{StatesMatrix[nOfColumn].ToList().FirstOrDefault(i => i.Up == Up).Up} ");
                return StatesMatrix[nOfColumn].ToList().FirstOrDefault(i => i.Up == Up).Up;
            }
            if (nOfColumn == 1)
            {
                return StatesMatrix[nOfColumn - 1].ToList().FirstOrDefault(i => i.Value == Up).Up;
            }
            return CalculateUp(nOfColumn - 1, StatesMatrix[nOfColumn - 1].ToList().FirstOrDefault(i => i.Up == Up).Up);
        }

        public string StringCalculator(List<double> Xs, List<double> Ys)
        {
            List<double> bs = new List<double>();

            foreach (var Column in StatesMatrix)
            {
                bs.Add(Column[0].Value);
            }

            string myresult = $"{Ys[0]} ";

            List<string> bsresults = new List<string>();

            var xsresults = "";

            for (int i = 0; i < bs.Count; i++)
            {
                bsresults.Add($"+ {bs[i]} * ");

                xsresults = xsresults + $"(x - {Xs[i]}) ";

                myresult = myresult + bsresults[i] + xsresults;
            }
            return myresult;
        }
    }
}
