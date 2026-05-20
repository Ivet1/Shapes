using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ShapeLibrary.Commands;
using ShapeLibrary.Managers;
using ShapeLibrary.Models;
using ShapeLibrary.Models.Contracts;
using ShapeLibrary.Services;

namespace KursovaRabota
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes = new List<Shape>();
        private CommandManager commandManager = new CommandManager();
        private ShapeXmlService xmlService = new ShapeXmlService();
        private Color selectedColor = Color.Black;

        private Shape selectedShape = null;
        private bool isDragging = false;
        private Point lastMousePos;

        private int startX;
        private int startY;
        private Point dragOffset;

        public Form1()
        {
            InitializeComponent();
            btnOpenMathForm.Click += btnOpenMath_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRadius.Visible = false;
            txtRadius.Visible = false;

            lblWidth.Visible = false;
            txtWidth.Visible = false;

            lblHeight.Visible = false;
            txtHeight.Visible = false;
            comboBoxColor.Visible = false;

            comboBoxShapes.Items.Insert(0, "Select Shape...");
            comboBoxShapes.SelectedIndex = 0;

            comboBoxColor.Items.Insert(0, "Select Color...");
            comboBoxColor.SelectedIndex = 0;
        }

        private void comboBoxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxShapes.SelectedItem == null) return;

            string selected = comboBoxShapes.SelectedItem.ToString();

            lblRadius.Visible = false;
            txtRadius.Visible = false;

            lblWidth.Visible = false;
            txtWidth.Visible = false;

            lblHeight.Visible = false;
            txtHeight.Visible = false;

            comboBoxColor.Visible = false;

            if (selected == "Circle")
            {
                lblRadius.Visible = true;
                txtRadius.Visible = true;
                comboBoxColor.Visible = true;
            }
            else if (selected == "Rectangle")
            {
                lblWidth.Visible = true;
                txtWidth.Visible = true;

                lblHeight.Visible = true;
                txtHeight.Visible = true;

                comboBoxColor.Visible = true;
            }
            else if (selected == "Triangle")
            {
                lblWidth.Text = "Base";

                lblWidth.Visible = true;
                txtWidth.Visible = true;

                lblHeight.Visible = true;
                txtHeight.Visible = true;

                comboBoxColor.Visible = true;
            }
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColor.SelectedItem == null) return;

            selectedColor = Color.FromName(comboBoxColor.SelectedItem.ToString());
        }

        private void RefreshCanvas()
        {
            panelCanvas.Invalidate();
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics, new Pen(shape.Color));
            }
        }

        private void btnAddShape_Click(object sender, EventArgs e)
        {
            if (comboBoxShapes.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a shape!");
                return;
            }

            try
            {
                string selected = comboBoxShapes.SelectedItem.ToString();

                Shape shape = null;

                if (selected == "Circle")
                {
                    double radius = double.Parse(txtRadius.Text);
                    int x = panelCanvas.Width / 2 - (int)radius;
                    int y = panelCanvas.Height / 2 - (int)radius;

                    shape = new Circle(x, y, selectedColor, radius);
                }
                else if (selected == "Rectangle")
                {
                    double width = double.Parse(txtWidth.Text);
                    double height = double.Parse(txtHeight.Text);

                    int x = panelCanvas.Width / 2 - (int)(width / 2);
                    int y = panelCanvas.Height / 2 - (int)(height / 2);

                    shape = new RectangleShape(x, y, selectedColor, width, height);
                }
                else if (selected == "Triangle")
                {
                    double baseLen = double.Parse(txtWidth.Text);
                    double height = double.Parse(txtHeight.Text);

                    int x = panelCanvas.Width / 2 - (int)(baseLen / 2);
                    int y = panelCanvas.Height / 2;

                    shape = new Triangle(x, y, selectedColor, baseLen, height);
                }

                if (shape == null) return;

                ICommand cmd = new AddShapeCommand(shapes, shape);
                commandManager.Execute(cmd);

                RefreshCanvas();
            }
            catch
            {
                MessageBox.Show("Invalid input!");
            }
        }

        private Shape GetShapeAtPoint(Point p)
        {
            for (int i = shapes.Count - 1; i >= 0; i--)
            {
                if (shapes[i].ContainsPoint(p))
                    return shapes[i];
            }
            return null;
        }
        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            selectedShape = GetShapeAtPoint(e.Location);

            if (selectedShape == null)
                return;

            isDragging = true;

            dragOffset = new Point(
                e.X - selectedShape.PosX,
                e.Y - selectedShape.PosY
            );

            startX = selectedShape.PosX;
            startY = selectedShape.PosY;
        }
        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDragging || selectedShape == null)
                return;

            int newX = e.X - dragOffset.X;
            int newY = e.Y - dragOffset.Y;

            selectedShape.Move(newX, newY);

            panelCanvas.Invalidate();
        }


        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedShape != null)
            {
                var cmd = new MoveShapeCommand(
                    selectedShape,
                    startX,
                    startY,
                    selectedShape.PosX,
                    selectedShape.PosY
                );

                commandManager.Execute(cmd);
            }

            isDragging = false;
            selectedShape = null;
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            commandManager.Undo();
            RefreshCanvas();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            commandManager.Redo();
            RefreshCanvas();
        }
        private void btnOpenMath_Click(object sender, EventArgs e)
        {
            try
            {
                if (shapes == null || shapes.Count == 0)
                {
                    MessageBox.Show("No shapes to analyze!");
                    return;
                }

                MathForm form = new MathForm(shapes);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = "shapes.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = saveFileDialog.FileName;
                    xmlService.Save(selectedPath, shapes);
                    MessageBox.Show("Shapes saved succesfully", "Successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = openFileDialog.FileName;
                    shapes = xmlService.Load(selectedPath); 
                    panelCanvas.Invalidate();

                    MessageBox.Show($"Succesfully loaded {shapes.Count} shapes!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}