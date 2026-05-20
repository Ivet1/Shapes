namespace KursovaRabota
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelCanvas = new Panel();
            btnAddShape = new Button();
            btnUndo = new Button();
            btnRedo = new Button();
            btnOpenMathForm = new Button();
            comboBoxShapes = new ComboBox();
            lblRadius = new Label();
            lblWidth = new Label();
            lblHeight = new Label();
            txtRadius = new TextBox();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            comboBoxColor = new ComboBox();
            btnSave = new Button();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // panelCanvas
            // 
            panelCanvas.BackColor = Color.FromArgb(255, 192, 192);
            panelCanvas.Location = new Point(167, 21);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(437, 417);
            panelCanvas.TabIndex = 0;
            panelCanvas.Paint += panelCanvas_Paint;
            panelCanvas.MouseDown += panelCanvas_MouseDown;
            panelCanvas.MouseMove += panelCanvas_MouseMove;
            panelCanvas.MouseUp += panelCanvas_MouseUp;
            // 
            // btnAddShape
            // 
            btnAddShape.Location = new Point(12, 21);
            btnAddShape.Name = "btnAddShape";
            btnAddShape.Size = new Size(134, 49);
            btnAddShape.TabIndex = 1;
            btnAddShape.Text = "Add Shape";
            btnAddShape.UseVisualStyleBackColor = true;
            btnAddShape.Click += btnAddShape_Click;
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(12, 182);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(134, 49);
            btnUndo.TabIndex = 2;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.Location = new Point(12, 131);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(134, 45);
            btnRedo.TabIndex = 3;
            btnRedo.Text = "Redo";
            btnRedo.UseVisualStyleBackColor = true;
            btnRedo.Click += btnRedo_Click;
            // 
            // btnOpenMathForm
            // 
            btnOpenMathForm.Location = new Point(12, 76);
            btnOpenMathForm.Name = "btnOpenMathForm";
            btnOpenMathForm.Size = new Size(134, 49);
            btnOpenMathForm.TabIndex = 4;
            btnOpenMathForm.Text = "Open MathForm";
            btnOpenMathForm.UseVisualStyleBackColor = true;
            btnOpenMathForm.Click += btnOpenMath_Click;
            // 
            // comboBoxShapes
            // 
            comboBoxShapes.FormattingEnabled = true;
            comboBoxShapes.Items.AddRange(new object[] { "Rectangle", "Circle", "Triangle" });
            comboBoxShapes.Location = new Point(610, 21);
            comboBoxShapes.Name = "comboBoxShapes";
            comboBoxShapes.Size = new Size(151, 28);
            comboBoxShapes.TabIndex = 5;
            comboBoxShapes.SelectedIndexChanged += comboBoxShapes_SelectedIndexChanged;
            // 
            // lblRadius
            // 
            lblRadius.AutoSize = true;
            lblRadius.Location = new Point(610, 67);
            lblRadius.Name = "lblRadius";
            lblRadius.Size = new Size(53, 20);
            lblRadius.TabIndex = 6;
            lblRadius.Text = "Radius";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(610, 100);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(49, 20);
            lblWidth.TabIndex = 7;
            lblWidth.Text = "Width";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(610, 131);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(54, 20);
            lblHeight.TabIndex = 8;
            lblHeight.Text = "Height";
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(663, 64);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(125, 27);
            txtRadius.TabIndex = 9;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(663, 97);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(125, 27);
            txtWidth.TabIndex = 10;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(664, 129);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 11;
            // 
            // comboBoxColor
            // 
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Items.AddRange(new object[] { "Green", "Blue", "Red", "Yellow", "Purple", "Orange", "Black" });
            comboBoxColor.Location = new Point(610, 162);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(151, 28);
            comboBoxColor.TabIndex = 12;
            comboBoxColor.SelectedIndexChanged += comboBoxColor_SelectedIndexChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 237);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 49);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(13, 292);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(133, 49);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(comboBoxColor);
            Controls.Add(txtHeight);
            Controls.Add(txtWidth);
            Controls.Add(txtRadius);
            Controls.Add(lblHeight);
            Controls.Add(lblWidth);
            Controls.Add(lblRadius);
            Controls.Add(comboBoxShapes);
            Controls.Add(btnOpenMathForm);
            Controls.Add(btnRedo);
            Controls.Add(btnUndo);
            Controls.Add(btnAddShape);
            Controls.Add(panelCanvas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCanvas;
        private Button btnAddShape;
        private Button btnUndo;
        private Button btnRedo;
        private Button btnOpenMathForm;
        private ComboBox comboBoxShapes;
        private Label lblRadius;
        private Label lblWidth;
        private Label lblHeight;
        private TextBox txtRadius;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private ComboBox comboBoxColor;
        private Button btnSave;
        private Button btnLoad;
    }
}
