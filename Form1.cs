namespace WinForm_GeometricFigures
{
    public partial class GeometricFiguresForm : Form
    {
        Graphics paper;
        Figures figures;
        Color color;

        public GeometricFiguresForm()
        {
            InitializeComponent();
            paper = pnlArtBoard.CreateGraphics();
            figures = new Figures();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int width = Int32.Parse(tbWidthLine.Text);
                string colorName = tbColorLine.SelectedItem.ToString();
                if (colorName != "Select...")
                {
                    color = Color.FromName(colorName);
                }
                LineSegment line = new LineSegment(color, width);
                line.pointA(Int32.Parse(lineAx.Text), Int32.Parse(lineAy.Text));
                line.pointB(Int32.Parse(lineBx.Text), Int32.Parse(lineBy.Text));
                line.Draw(paper);
                figures.Add(line);
            }
            catch
            {
                MessageBox.Show(
                "Остались пустые поля",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            paper.Clear(Color.White);
            figures.Clear();
        }

        private void btnDrawTriangle_Click(object sender, EventArgs e)
        {
            try
            {
                int width = Int32.Parse(tbWidthTriangle.Text);
                string colorName = tbColorTriangle.SelectedItem.ToString();
                if (colorName != "Select...")
                {
                    color = Color.FromName(colorName);
                }
                Triangle triangle = new Triangle(color, width);
                triangle.pointA(Int32.Parse(triangleAx.Text), Int32.Parse(triangleAy.Text));
                triangle.pointB(Int32.Parse(triangleBx.Text), Int32.Parse(triangleBy.Text));
                triangle.pointC(Int32.Parse(triangleCx.Text), Int32.Parse(triangleCy.Text));
                triangle.Draw(paper);
                figures.Add(triangle);
            }
            catch
            {
                MessageBox.Show(
                "Остались пустые поля",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            try
            {
                int width = Int32.Parse(tbWidthRectangle.Text);
                string colorName = tbColorRectangle.SelectedItem.ToString();
                if (colorName != "Select...")
                {
                    color = Color.FromName(colorName);
                }
                Rectangle rectangle = new Rectangle(color, width);
                rectangle.pointA(Int32.Parse(rectangleAx.Text), Int32.Parse(rectangleAy.Text));
                rectangle.pointB(Int32.Parse(rectangleAx.Text) + Int32.Parse(tbLengthRect.Text), Int32.Parse(rectangleAy.Text));
                rectangle.pointC(Int32.Parse(rectangleAx.Text), Int32.Parse(rectangleAy.Text) + Int32.Parse(tbWidthRect.Text));
                rectangle.pointD(Int32.Parse(rectangleAx.Text) + Int32.Parse(tbLengthRect.Text),
                    Int32.Parse(rectangleAy.Text) + Int32.Parse(tbWidthRect.Text));
                rectangle.Draw(paper);
                figures.Add(rectangle);
            }
            catch
            {
                MessageBox.Show(
                "Остались пустые поля",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            try
            {
                int width = Int32.Parse(tbWidthCircle.Text);
                string colorName = tbColorCircle.SelectedItem.ToString();
                if (colorName != "Select...")
                {
                    color = Color.FromName(colorName);
                }
                Circle circle = new Circle(color, width, Int32.Parse(tbRadius.Text));
                circle.pointA(Int32.Parse(circleX.Text), Int32.Parse(circleY.Text));
                circle.Draw(paper);
                figures.Add(circle);
            }
            catch
            {
                MessageBox.Show(
                "Остались пустые поля",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void lbColors_ChangeItem(object sender, EventArgs e)
        {
            string colorName = tbColorLine.SelectedItem.ToString();
            if (colorName == "Select...")
            {
                colorDialogFigure.ShowDialog();
                color = colorDialogFigure.Color;
            }
        }

        private void tbColorTriangle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorName = tbColorTriangle.SelectedItem.ToString();
            if (colorName == "Select...")
            {
                colorDialogFigure.ShowDialog();
                color = colorDialogFigure.Color;
            }
        }

        private void tbColorRectangle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorName = tbColorRectangle.SelectedItem.ToString();
            if (colorName == "Select...")
            {
                colorDialogFigure.ShowDialog();
                color = colorDialogFigure.Color;
            }
        }

        private void tbColorCircle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorName = tbColorCircle.SelectedItem.ToString();
            if (colorName == "Select...")
            {
                colorDialogFigure.ShowDialog();
                color = colorDialogFigure.Color;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialogFigures.ShowDialog() == DialogResult.OK)
            {
                figures.Save(saveFileDialogFigures.FileName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialogFigures.ShowDialog() == DialogResult.OK)
            {
                paper.Clear(Color.White);
                figures.Load(openFileDialogFigures.FileName);
                figures.Draw(paper);
            }        
        }
    }
}