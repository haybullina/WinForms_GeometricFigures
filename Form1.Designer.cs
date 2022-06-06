namespace WinForm_GeometricFigures
{
    partial class GeometricFiguresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeometricFiguresForm));
            this.pnlArtBoard = new System.Windows.Forms.Panel();
            this.tbWidthLine = new System.Windows.Forms.TextBox();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Label();
            this.Triangle = new System.Windows.Forms.Label();
            this.tColorLine = new System.Windows.Forms.Label();
            this.tColorTriangle = new System.Windows.Forms.Label();
            this.tbColorTriangle = new System.Windows.Forms.ListBox();
            this.tbWidthTriangle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tColorRectangle = new System.Windows.Forms.Label();
            this.tWidthRectangle = new System.Windows.Forms.Label();
            this.tbColorRectangle = new System.Windows.Forms.ListBox();
            this.tbWidthRectangle = new System.Windows.Forms.TextBox();
            this.tColorCircle = new System.Windows.Forms.Label();
            this.tbColorCircle = new System.Windows.Forms.ListBox();
            this.tbWidthCircle = new System.Windows.Forms.TextBox();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.tRadius = new System.Windows.Forms.Label();
            this.btnDrawTriangle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.tLengthLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lineAx = new System.Windows.Forms.TextBox();
            this.lineAy = new System.Windows.Forms.TextBox();
            this.lineBy = new System.Windows.Forms.TextBox();
            this.lineBx = new System.Windows.Forms.TextBox();
            this.triangleBy = new System.Windows.Forms.TextBox();
            this.triangleBx = new System.Windows.Forms.TextBox();
            this.triangleAy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.triangleAx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.triangleCy = new System.Windows.Forms.TextBox();
            this.triangleCx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLengthRect = new System.Windows.Forms.TextBox();
            this.rectangleAy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rectangleAx = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.Label();
            this.circleY = new System.Windows.Forms.TextBox();
            this.circleX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbWidthRect = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.colorDialogFigure = new System.Windows.Forms.ColorDialog();
            this.label19 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbColorLine = new System.Windows.Forms.ListBox();
            this.saveFileDialogFigures = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogFigures = new System.Windows.Forms.OpenFileDialog();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArtBoard
            // 
            this.pnlArtBoard.BackColor = System.Drawing.SystemColors.Window;
            this.pnlArtBoard.Location = new System.Drawing.Point(83, 426);
            this.pnlArtBoard.Name = "pnlArtBoard";
            this.pnlArtBoard.Size = new System.Drawing.Size(688, 331);
            this.pnlArtBoard.TabIndex = 0;
            // 
            // tbWidthLine
            // 
            this.tbWidthLine.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWidthLine.Location = new System.Drawing.Point(83, 97);
            this.tbWidthLine.Name = "tbWidthLine";
            this.tbWidthLine.Size = new System.Drawing.Size(76, 25);
            this.tbWidthLine.TabIndex = 1;
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDrawLine.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDrawLine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDrawLine.Location = new System.Drawing.Point(83, 333);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(109, 50);
            this.btnDrawLine.TabIndex = 3;
            this.btnDrawLine.Text = "Draw";
            this.btnDrawLine.UseVisualStyleBackColor = false;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Tomato;
            this.btnClear.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnClear.Location = new System.Drawing.Point(800, 520);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 51);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Line.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Line.Location = new System.Drawing.Point(83, 46);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(49, 25);
            this.Line.TabIndex = 5;
            this.Line.Text = "Line";
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Triangle.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Triangle.Location = new System.Drawing.Point(355, 46);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(86, 25);
            this.Triangle.TabIndex = 6;
            this.Triangle.Text = "Triangle";
            // 
            // tColorLine
            // 
            this.tColorLine.AutoSize = true;
            this.tColorLine.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tColorLine.Location = new System.Drawing.Point(27, 221);
            this.tColorLine.Name = "tColorLine";
            this.tColorLine.Size = new System.Drawing.Size(54, 20);
            this.tColorLine.TabIndex = 8;
            this.tColorLine.Text = "color";
            // 
            // tColorTriangle
            // 
            this.tColorTriangle.AutoSize = true;
            this.tColorTriangle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tColorTriangle.Location = new System.Drawing.Point(295, 260);
            this.tColorTriangle.Name = "tColorTriangle";
            this.tColorTriangle.Size = new System.Drawing.Size(54, 20);
            this.tColorTriangle.TabIndex = 13;
            this.tColorTriangle.Text = "color";
            // 
            // tbColorTriangle
            // 
            this.tbColorTriangle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbColorTriangle.FormattingEnabled = true;
            this.tbColorTriangle.ItemHeight = 20;
            this.tbColorTriangle.Items.AddRange(new object[] {
            "Select...",
            "White",
            "Black",
            "Blue",
            "Yellow",
            "Red",
            "Violet",
            "Green",
            "Orange",
            "Purple"});
            this.tbColorTriangle.Location = new System.Drawing.Point(355, 260);
            this.tbColorTriangle.Name = "tbColorTriangle";
            this.tbColorTriangle.Size = new System.Drawing.Size(148, 44);
            this.tbColorTriangle.TabIndex = 11;
            this.tbColorTriangle.SelectedIndexChanged += new System.EventHandler(this.tbColorTriangle_SelectedIndexChanged);
            // 
            // tbWidthTriangle
            // 
            this.tbWidthTriangle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWidthTriangle.Location = new System.Drawing.Point(355, 94);
            this.tbWidthTriangle.Name = "tbWidthTriangle";
            this.tbWidthTriangle.Size = new System.Drawing.Size(76, 25);
            this.tbWidthTriangle.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(662, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rectangle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(909, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Circle";
            // 
            // tColorRectangle
            // 
            this.tColorRectangle.AutoSize = true;
            this.tColorRectangle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tColorRectangle.Location = new System.Drawing.Point(606, 256);
            this.tColorRectangle.Name = "tColorRectangle";
            this.tColorRectangle.Size = new System.Drawing.Size(54, 20);
            this.tColorRectangle.TabIndex = 20;
            this.tColorRectangle.Text = "color";
            // 
            // tWidthRectangle
            // 
            this.tWidthRectangle.AutoSize = true;
            this.tWidthRectangle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tWidthRectangle.Location = new System.Drawing.Point(604, 84);
            this.tWidthRectangle.Name = "tWidthRectangle";
            this.tWidthRectangle.Size = new System.Drawing.Size(54, 40);
            this.tWidthRectangle.TabIndex = 19;
            this.tWidthRectangle.Text = "line\r\nwidth";
            // 
            // tbColorRectangle
            // 
            this.tbColorRectangle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbColorRectangle.FormattingEnabled = true;
            this.tbColorRectangle.ItemHeight = 20;
            this.tbColorRectangle.Items.AddRange(new object[] {
            "Select...",
            "White",
            "Black",
            "Blue",
            "Yellow",
            "Red",
            "Violet",
            "Green",
            "Orange",
            "Purple"});
            this.tbColorRectangle.Location = new System.Drawing.Point(662, 256);
            this.tbColorRectangle.Name = "tbColorRectangle";
            this.tbColorRectangle.Size = new System.Drawing.Size(148, 44);
            this.tbColorRectangle.TabIndex = 18;
            this.tbColorRectangle.SelectedIndexChanged += new System.EventHandler(this.tbColorRectangle_SelectedIndexChanged);
            // 
            // tbWidthRectangle
            // 
            this.tbWidthRectangle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWidthRectangle.Location = new System.Drawing.Point(664, 93);
            this.tbWidthRectangle.Name = "tbWidthRectangle";
            this.tbWidthRectangle.Size = new System.Drawing.Size(76, 25);
            this.tbWidthRectangle.TabIndex = 17;
            // 
            // tColorCircle
            // 
            this.tColorCircle.AutoSize = true;
            this.tColorCircle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tColorCircle.Location = new System.Drawing.Point(853, 256);
            this.tColorCircle.Name = "tColorCircle";
            this.tColorCircle.Size = new System.Drawing.Size(54, 20);
            this.tColorCircle.TabIndex = 26;
            this.tColorCircle.Text = "color";
            // 
            // tbColorCircle
            // 
            this.tbColorCircle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbColorCircle.FormattingEnabled = true;
            this.tbColorCircle.ItemHeight = 20;
            this.tbColorCircle.Items.AddRange(new object[] {
            "Select...",
            "White",
            "Black",
            "Blue",
            "Yellow",
            "Red",
            "Violet",
            "Green",
            "Orange",
            "Purple"});
            this.tbColorCircle.Location = new System.Drawing.Point(909, 256);
            this.tbColorCircle.Name = "tbColorCircle";
            this.tbColorCircle.Size = new System.Drawing.Size(148, 44);
            this.tbColorCircle.TabIndex = 24;
            this.tbColorCircle.SelectedIndexChanged += new System.EventHandler(this.tbColorCircle_SelectedIndexChanged);
            // 
            // tbWidthCircle
            // 
            this.tbWidthCircle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWidthCircle.Location = new System.Drawing.Point(911, 149);
            this.tbWidthCircle.Name = "tbWidthCircle";
            this.tbWidthCircle.Size = new System.Drawing.Size(76, 25);
            this.tbWidthCircle.TabIndex = 23;
            // 
            // tbRadius
            // 
            this.tbRadius.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRadius.Location = new System.Drawing.Point(911, 95);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(100, 25);
            this.tbRadius.TabIndex = 22;
            // 
            // tRadius
            // 
            this.tRadius.AutoSize = true;
            this.tRadius.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tRadius.Location = new System.Drawing.Point(846, 98);
            this.tRadius.Name = "tRadius";
            this.tRadius.Size = new System.Drawing.Size(63, 20);
            this.tRadius.TabIndex = 27;
            this.tRadius.Text = "radius";
            // 
            // btnDrawTriangle
            // 
            this.btnDrawTriangle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDrawTriangle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDrawTriangle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDrawTriangle.Location = new System.Drawing.Point(355, 333);
            this.btnDrawTriangle.Name = "btnDrawTriangle";
            this.btnDrawTriangle.Size = new System.Drawing.Size(109, 50);
            this.btnDrawTriangle.TabIndex = 28;
            this.btnDrawTriangle.Text = "Draw";
            this.btnDrawTriangle.UseVisualStyleBackColor = false;
            this.btnDrawTriangle.Click += new System.EventHandler(this.btnDrawTriangle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRectangle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRectangle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRectangle.Location = new System.Drawing.Point(664, 333);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(109, 50);
            this.btnRectangle.TabIndex = 29;
            this.btnRectangle.Text = "Draw";
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDrawCircle.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDrawCircle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDrawCircle.Location = new System.Drawing.Point(909, 333);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(109, 50);
            this.btnDrawCircle.TabIndex = 30;
            this.btnDrawCircle.Text = "Draw";
            this.btnDrawCircle.UseVisualStyleBackColor = false;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // tLengthLine
            // 
            this.tLengthLine.AutoSize = true;
            this.tLengthLine.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tLengthLine.Location = new System.Drawing.Point(42, 178);
            this.tLengthLine.Name = "tLengthLine";
            this.tLengthLine.Size = new System.Drawing.Size(18, 20);
            this.tLengthLine.TabIndex = 35;
            this.tLengthLine.Text = "B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "A";
            // 
            // lineAx
            // 
            this.lineAx.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lineAx.Location = new System.Drawing.Point(83, 135);
            this.lineAx.Name = "lineAx";
            this.lineAx.Size = new System.Drawing.Size(49, 25);
            this.lineAx.TabIndex = 42;
            // 
            // lineAy
            // 
            this.lineAy.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lineAy.Location = new System.Drawing.Point(153, 135);
            this.lineAy.Name = "lineAy";
            this.lineAy.Size = new System.Drawing.Size(49, 25);
            this.lineAy.TabIndex = 44;
            // 
            // lineBy
            // 
            this.lineBy.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lineBy.Location = new System.Drawing.Point(153, 175);
            this.lineBy.Name = "lineBy";
            this.lineBy.Size = new System.Drawing.Size(49, 25);
            this.lineBy.TabIndex = 46;
            // 
            // lineBx
            // 
            this.lineBx.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lineBx.Location = new System.Drawing.Point(83, 175);
            this.lineBx.Name = "lineBx";
            this.lineBx.Size = new System.Drawing.Size(49, 25);
            this.lineBx.TabIndex = 45;
            // 
            // triangleBy
            // 
            this.triangleBy.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.triangleBy.Location = new System.Drawing.Point(429, 174);
            this.triangleBy.Name = "triangleBy";
            this.triangleBy.Size = new System.Drawing.Size(49, 25);
            this.triangleBy.TabIndex = 52;
            // 
            // triangleBx
            // 
            this.triangleBx.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.triangleBx.Location = new System.Drawing.Point(355, 174);
            this.triangleBx.Name = "triangleBx";
            this.triangleBx.Size = new System.Drawing.Size(49, 25);
            this.triangleBx.TabIndex = 51;
            // 
            // triangleAy
            // 
            this.triangleAy.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.triangleAy.Location = new System.Drawing.Point(429, 134);
            this.triangleAy.Name = "triangleAy";
            this.triangleAy.Size = new System.Drawing.Size(49, 25);
            this.triangleAy.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(314, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "A";
            // 
            // triangleAx
            // 
            this.triangleAx.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.triangleAx.Location = new System.Drawing.Point(355, 134);
            this.triangleAx.Name = "triangleAx";
            this.triangleAx.Size = new System.Drawing.Size(49, 25);
            this.triangleAx.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(314, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "B";
            // 
            // triangleCy
            // 
            this.triangleCy.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.triangleCy.Location = new System.Drawing.Point(429, 215);
            this.triangleCy.Name = "triangleCy";
            this.triangleCy.Size = new System.Drawing.Size(49, 25);
            this.triangleCy.TabIndex = 55;
            // 
            // triangleCx
            // 
            this.triangleCx.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.triangleCx.Location = new System.Drawing.Point(355, 215);
            this.triangleCx.Name = "triangleCx";
            this.triangleCx.Size = new System.Drawing.Size(49, 25);
            this.triangleCx.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(314, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "C";
            // 
            // tbLengthRect
            // 
            this.tbLengthRect.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLengthRect.Location = new System.Drawing.Point(664, 177);
            this.tbLengthRect.Name = "tbLengthRect";
            this.tbLengthRect.Size = new System.Drawing.Size(49, 25);
            this.tbLengthRect.TabIndex = 60;
            // 
            // rectangleAy
            // 
            this.rectangleAy.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rectangleAy.Location = new System.Drawing.Point(735, 137);
            this.rectangleAy.Name = "rectangleAy";
            this.rectangleAy.Size = new System.Drawing.Size(49, 25);
            this.rectangleAy.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(527, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 40);
            this.label8.TabIndex = 58;
            this.label8.Text = "left up angle/\r\nstart point";
            // 
            // rectangleAx
            // 
            this.rectangleAx.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rectangleAx.Location = new System.Drawing.Point(664, 137);
            this.rectangleAx.Name = "rectangleAx";
            this.rectangleAx.Size = new System.Drawing.Size(49, 25);
            this.rectangleAx.TabIndex = 57;
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.length.Location = new System.Drawing.Point(599, 180);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(63, 20);
            this.length.TabIndex = 56;
            this.length.Text = "length";
            // 
            // circleY
            // 
            this.circleY.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circleY.Location = new System.Drawing.Point(980, 197);
            this.circleY.Name = "circleY";
            this.circleY.Size = new System.Drawing.Size(48, 25);
            this.circleY.TabIndex = 67;
            // 
            // circleX
            // 
            this.circleX.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circleX.Location = new System.Drawing.Point(911, 197);
            this.circleX.Name = "circleX";
            this.circleX.Size = new System.Drawing.Size(48, 25);
            this.circleX.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(846, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 40);
            this.label10.TabIndex = 65;
            this.label10.Text = "center\r\npoint";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(604, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "width";
            // 
            // tbWidthRect
            // 
            this.tbWidthRect.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWidthRect.Location = new System.Drawing.Point(664, 218);
            this.tbWidthRect.Name = "tbWidthRect";
            this.tbWidthRect.Size = new System.Drawing.Size(49, 25);
            this.tbWidthRect.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(851, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 40);
            this.label9.TabIndex = 68;
            this.label9.Text = "line\r\nwidth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(295, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 40);
            this.label11.TabIndex = 69;
            this.label11.Text = "line\r\nwidth";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(23, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 40);
            this.label12.TabIndex = 70;
            this.label12.Text = "line\r\nwidth";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(959, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 20);
            this.label13.TabIndex = 71;
            this.label13.Text = ";";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(406, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 20);
            this.label14.TabIndex = 72;
            this.label14.Text = ";";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(406, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 20);
            this.label15.TabIndex = 73;
            this.label15.Text = ";";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(406, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 20);
            this.label16.TabIndex = 74;
            this.label16.Text = ";";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(132, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(18, 20);
            this.label17.TabIndex = 75;
            this.label17.Text = ";";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(132, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 20);
            this.label18.TabIndex = 76;
            this.label18.Text = ";";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Tomato;
            this.btnLoad.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnLoad.Location = new System.Drawing.Point(957, 577);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(122, 51);
            this.btnLoad.TabIndex = 77;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Tomato;
            this.btnSave.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnSave.Location = new System.Drawing.Point(957, 520);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 51);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(714, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 20);
            this.label19.TabIndex = 79;
            this.label19.Text = ";";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(447, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbColorLine
            // 
            this.tbColorLine.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbColorLine.FormattingEnabled = true;
            this.tbColorLine.ItemHeight = 20;
            this.tbColorLine.Items.AddRange(new object[] {
            "Select...",
            "White",
            "Black",
            "Blue",
            "Yellow",
            "Red",
            "Violet",
            "Green",
            "Orange",
            "Purple"});
            this.tbColorLine.Location = new System.Drawing.Point(83, 221);
            this.tbColorLine.Name = "tbColorLine";
            this.tbColorLine.Size = new System.Drawing.Size(148, 44);
            this.tbColorLine.TabIndex = 2;
            this.tbColorLine.SelectedIndexChanged += new System.EventHandler(this.lbColors_ChangeItem);
            // 
            // openFileDialogFigures
            // 
            this.openFileDialogFigures.FileName = "openFileDialog1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(59, 426);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 40);
            this.label20.TabIndex = 80;
            this.label20.Text = "Y\r\n↓";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(83, 403);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 20);
            this.label21.TabIndex = 81;
            this.label21.Text = "X →";
            // 
            // GeometricFiguresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 788);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.circleY);
            this.Controls.Add(this.circleX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbWidthRect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLengthRect);
            this.Controls.Add(this.rectangleAy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rectangleAx);
            this.Controls.Add(this.length);
            this.Controls.Add(this.triangleCy);
            this.Controls.Add(this.triangleCx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.triangleBy);
            this.Controls.Add(this.triangleBx);
            this.Controls.Add(this.triangleAy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.triangleAx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lineBy);
            this.Controls.Add(this.lineBx);
            this.Controls.Add(this.lineAy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lineAx);
            this.Controls.Add(this.tLengthLine);
            this.Controls.Add(this.btnDrawCircle);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnDrawTriangle);
            this.Controls.Add(this.tRadius);
            this.Controls.Add(this.tColorCircle);
            this.Controls.Add(this.tbColorCircle);
            this.Controls.Add(this.tbWidthCircle);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.tColorRectangle);
            this.Controls.Add(this.tWidthRectangle);
            this.Controls.Add(this.tbColorRectangle);
            this.Controls.Add(this.tbWidthRectangle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tColorTriangle);
            this.Controls.Add(this.tbColorTriangle);
            this.Controls.Add(this.tbWidthTriangle);
            this.Controls.Add(this.tColorLine);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDrawLine);
            this.Controls.Add(this.tbColorLine);
            this.Controls.Add(this.tbWidthLine);
            this.Controls.Add(this.pnlArtBoard);
            this.Name = "GeometricFiguresForm";
            this.Text = "Geometric figures";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlArtBoard;
        private TextBox tbWidthLine;
        private Button btnDrawLine;
        private Button btnClear;
        private Label Line;
        private Label Triangle;
        private Label tColorLine;
        private Label tColorTriangle;
        private ListBox tbColorTriangle;
        private TextBox tbWidthTriangle;
        private Label label3;
        private Label label4;
        private Label tColorRectangle;
        private ListBox tbColorRectangle;
        private TextBox tbWidthRectangle;
        private Label tColorCircle;
        private ListBox tbColorCircle;
        private TextBox tbWidthCircle;
        private TextBox tbRadius;
        private Label tRadius;
        private Button btnDrawTriangle;
        private Button btnRectangle;
        private Button btnDrawCircle;
        private Label tWidthRectangle;
        private Label tLengthLine;
        private Label label1;
        private TextBox lineAx;
        private TextBox lineAy;
        private TextBox lineBy;
        private TextBox lineBx;
        private TextBox triangleBy;
        private TextBox triangleBx;
        private TextBox triangleAy;
        private Label label2;
        private TextBox triangleAx;
        private Label label5;
        private TextBox triangleCy;
        private TextBox triangleCx;
        private Label label6;
        private TextBox tbLengthRect;
        private TextBox rectangleAy;
        private Label label8;
        private TextBox rectangleAx;
        private Label length;
        private TextBox circleY;
        private TextBox circleX;
        private Label label10;
        private Label label7;
        private TextBox tbWidthRect;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button btnLoad;
        private Button btnSave;
        private ColorDialog colorDialogFigure;
        private Label label19;
        private PictureBox pictureBox1;
        private ListBox tbColorLine;
        private SaveFileDialog saveFileDialogFigures;
        private OpenFileDialog openFileDialogFigures;
        private Label label20;
        private Label label21;
    }
}