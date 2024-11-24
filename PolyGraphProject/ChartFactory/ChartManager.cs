using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PolyGraphProject.ChartManager
{
    public class ChartManager
    {
        private protected Chart _chart;
        private protected DataGridView _grid;
        private protected Color[] _colorList;

        // Constructor that requires a Chart object
        public ChartManager(Chart chart, DataGridView grid, Color[] colorList)
        {
            this._chart = chart ?? throw new ArgumentNullException(nameof(chart), "Chart cannot be null.");
            this._grid = grid ?? throw new ArgumentNullException(nameof(grid), "Grid cannot be null");
            this._colorList = colorList;
        }

        public void Generate()
        {
            var objChart = this._chart.ChartAreas[0];
            objChart.AxisX.IntervalType = DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 10;

            objChart.AxisY.IntervalType = DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = -500;
            objChart.AxisY.Maximum = 500;

            this._chart.Series.Clear();

            var v = 0;
            foreach (DataLine l in this._grid.DataSource as List<DataLine>)
            {
                v++;
                this._chart.Series.Add(l.Location);
                this._chart.Series[l.Location].Color = this._colorList[v];
                this._chart.Series[l.Location].ChartType = SeriesChartType.Line;
                //Adding Data
                for (int i = 1; i <= 10; i++)
                {
                    this._chart.Series[l.Location].Points.AddXY(i, Convert.ToInt32(l[$"M{i}"]));
                }
            }
        }
    }
}
