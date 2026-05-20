using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using ShapeLibrary.Models;

namespace KursovaRabota
{
    public partial class MathForm : Form
    {
        private List<Shape> shapes;
        private List<double> areas;
        private List<(Shape shape, double area)> shapeData;

        public MathForm(List<Shape> shapes)
        {
            InitializeComponent();
            this.shapes = shapes;

            shapeData = shapes
                .Select(s => (shape: s, area: s.FindArea()))
                .ToList();

            areas = shapeData.Select(x => x.area).ToList();

            LoadShapesToList();
        }

        private void LoadShapesToList()
        {
            shapesList.Items.Clear();

            foreach (var item in shapeData)
            {
                shapesList.Items.Add($"{item.shape.GetType().Name} - {item.area:F2}");
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            Series series = new Series("Areas");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            chart1.Series.Add(series);

            var sorted = shapeData
                .OrderByDescending(x => x.area)
                .ToList();

            foreach (var item in sorted)
            {
                double area = item.area;
                string name = item.shape.GetType().Name;

                int index = series.Points.AddXY(name, area);
                series.Points[index].Label = $"{name}\n{area:F2}";
            }

            chart1.ChartAreas[0].AxisX.Interval = 1;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (areas.Count == 0)
            {
                txtResult.Text = "No shapes";
                return;
            }

            double total = areas.Sum();
            txtResult.Text = $"Total: {total:F2}";
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (areas.Count == 0)
            {
                txtResult.Text = "No shapes";
                return;
            }

            double avg = areas.Average();
            txtResult.Text = $"Average: {avg:F2}";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (areas.Count == 0)
            {
                txtResult.Text = "No shapes";
                return;
            }

            var maxShape = shapeData
                .OrderByDescending(x => x.area)
                .First();

            txtResult.Text =
                $"Max: {maxShape.shape.GetType().Name} - {maxShape.area:F2}";
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (areas.Count == 0)
                return;

            double avg = areas.Average();
            double variance = areas.Average(a => Math.Pow(a - avg, 2));

            shapesList.Items.Clear();
            shapesList.Items.Add($"Variance: {variance:F2}");

            var sorted = shapeData
                .OrderByDescending(x => x.area)
                .ToList();

            int index = 1;

            foreach (var item in sorted)
            {
                shapesList.Items.Add($"{index++}. {item.shape.GetType().Name} - {item.area:F2}");
            }
        }
    }
}