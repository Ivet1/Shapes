namespace KursovaRabota
{
    partial class MathForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            label1 = new Label();
            shapesList = new ListBox();
            txtResult = new Label();
            btnTotal = new Button();
            btnAverage = new Button();
            btnMax = new Button();
            btnCompare = new Button();
            btnChart = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(214, 0);
            label1.Name = "label1";
            label1.Size = new Size(365, 37);
            label1.TabIndex = 8;
            label1.Text = "Shape Analytics Dashboard";
            // 
            // shapesList
            // 
            shapesList.Location = new Point(12, 77);
            shapesList.Name = "shapesList";
            shapesList.Size = new Size(180, 304);
            shapesList.TabIndex = 7;
            // 
            // txtResult
            // 
            txtResult.AutoSize = true;
            txtResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtResult.Location = new Point(227, 399);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(80, 28);
            txtResult.TabIndex = 6;
            txtResult.Text = "Results";
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(650, 100);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(100, 30);
            btnTotal.TabIndex = 5;
            btnTotal.Text = "Total";
            btnTotal.Click += btnTotal_Click;
            // 
            // btnAverage
            // 
            btnAverage.Location = new Point(650, 135);
            btnAverage.Name = "btnAverage";
            btnAverage.Size = new Size(100, 30);
            btnAverage.TabIndex = 4;
            btnAverage.Text = "Average";
            btnAverage.Click += btnAverage_Click;
            // 
            // btnMax
            // 
            btnMax.Location = new Point(650, 170);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(100, 30);
            btnMax.TabIndex = 3;
            btnMax.Text = "Max";
            btnMax.Click += btnMax_Click;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(650, 205);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(100, 30);
            btnCompare.TabIndex = 2;
            btnCompare.Text = "Compare";
            btnCompare.Click += btnCompare_Click;
            // 
            // btnChart
            // 
            btnChart.Location = new Point(650, 240);
            btnChart.Name = "btnChart";
            btnChart.Size = new Size(100, 30);
            btnChart.TabIndex = 1;
            btnChart.Text = "Chart";
            btnChart.Click += btnChart_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(227, 82);
            chart1.Name = "chart1";
            chart1.Size = new Size(387, 299);
            chart1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 43);
            label2.Name = "label2";
            label2.Size = new Size(75, 31);
            label2.TabIndex = 9;
            label2.Text = "Areas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(539, 48);
            label3.Name = "label3";
            label3.Size = new Size(75, 31);
            label3.TabIndex = 10;
            label3.Text = "Chart";
            // 
            // MathForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(chart1);
            Controls.Add(btnChart);
            Controls.Add(btnCompare);
            Controls.Add(btnMax);
            Controls.Add(btnAverage);
            Controls.Add(btnTotal);
            Controls.Add(txtResult);
            Controls.Add(shapesList);
            Controls.Add(label1);
            Name = "MathForm";
            Text = "MathForm";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private ListBox shapesList;
        private Label txtResult;
        private Button btnTotal;
        private Button btnAverage;
        private Button btnMax;
        private Button btnCompare;
        private Button btnChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label2;
        private Label label3;
    }
}