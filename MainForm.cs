using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;


namespace Lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            bool error = default;
            string errorStr = "Ошибки в полях: ";

            if (!Regex.IsMatch(VoltageTextBox.Text, @"^\d{1},?(?:(?<=[,])\d+|$)(?<=\d)$"))
            {
                error = true;
                errorStr += "Величина напряжения должна быть в диапазоне от 0 до 10 В; ";
            }

            if (!Regex.IsMatch(ResistTextBox.Text, @"^\d{1,2},?(?:(?<=[,])\d+|$)(?<=\d)$"))
            {
                error = true;
                errorStr += "Величина сопротивления должна быть в диапазоне от 0 до 100 Ом; ";
            }

            if (!Regex.IsMatch(CapacityTextBox.Text, @"^\d{1,2},?(?:(?<=[,])\d+|$)(?<=\d)$"))
            {
                error = true;
                errorStr += "Величина емкости должна быть в диапазоне от 0 до 100 нФ; ";
            }

            if (!Regex.IsMatch(HTextBox.Text, @"^\d{1},?(?:(?<=[,])\d+|$)(?<=\d)$"))
            {
                error = true;
                errorStr += "Величина параметра h должна быть в диапазоне от 0 до 10 RC; ";
            }

            if (error)
            {
                MessageBox.Show(
                    Regex.Replace(errorStr,@"; $",""),
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                return;
            }

            Chart.Series.Clear();
            DataViewer.Rows.Clear();
            try
            {

                Series FuncSeries = Chart.Series.Add("Аналитическая функция");
                FuncSeries.ChartType = SeriesChartType.Line;
                FuncSeries.MarkerStyle = MarkerStyle.Star10;
                FuncSeries.MarkerSize = 11;
                FuncSeries.BorderWidth = 3;
                FuncSeries.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

                Series ExplicitSeries = null;
                Series ImplicitSeries = null;
                Series TrapezesSeries = null;

                if (ExplicitEMethodCheckBox.Checked)
                {
                    ExplicitSeries = Chart.Series.Add("Явный метод Эйлера");
                    ExplicitSeries.ChartType = SeriesChartType.Line;
                    ExplicitSeries.MarkerStyle = MarkerStyle.Circle;
                    ExplicitSeries.MarkerSize = 11;
                    ExplicitSeries.BorderWidth = 3;
                    ExplicitSeries.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }

                if (ImplicitEMethodCheckBox.Checked)
                {
                    ImplicitSeries = Chart.Series.Add("Неявный метод Эйлера");
                    ImplicitSeries.ChartType = SeriesChartType.Line;
                    ImplicitSeries.MarkerStyle = MarkerStyle.Square;
                    ImplicitSeries.MarkerSize = 11;
                    ImplicitSeries.BorderWidth = 3;
                    ImplicitSeries.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }

                if (TrapezesMethodCheckBox.Checked)
                {
                    TrapezesSeries = Chart.Series.Add("Метод трапеций");
                    TrapezesSeries.ChartType = SeriesChartType.Line;
                    TrapezesSeries.MarkerStyle = MarkerStyle.Diamond;
                    TrapezesSeries.MarkerSize = 11;
                    TrapezesSeries.BorderWidth = 3;
                    TrapezesSeries.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }

                double U0 = Double.Parse(VoltageTextBox.Text);
                double R = Double.Parse(ResistTextBox.Text);
                double C = Double.Parse(CapacityTextBox.Text);
                C *= Math.Pow(10, -9);
                double h = Double.Parse(HTextBox.Text);

                double t = default;
                int n = default;

                double UFunc = default;
                double UExplicit = default;
                double UImplicit = default;
                double UTrapezes = default;


                DataViewer.Rows.Add(0, U0, U0, U0, U0);
                FuncSeries.Points.AddXY(0, U0);
                if (ExplicitEMethodCheckBox.Checked)
                    ExplicitSeries.Points.AddXY(0, U0);

                if (ImplicitEMethodCheckBox.Checked)
                    ImplicitSeries.Points.AddXY(0, U0);

                if (TrapezesMethodCheckBox.Checked)
                    TrapezesSeries.Points?.AddXY(0, U0);

                while (t < (R * C))
                {
                    t += (R * C) / 20;

                    UFunc = U0 * Math.Pow(Math.E, -(t / (R * C)));
                    FuncSeries.Points.AddXY(t, UFunc);

                    if (ExplicitEMethodCheckBox.Checked)
                    {
                        UExplicit = ExplicitEMethod(U0, h, n);
                        ExplicitSeries.Points.AddXY(t, UExplicit);
                    }

                    if (ImplicitEMethodCheckBox.Checked)
                    {
                        UImplicit = ImplicitEMethod(U0, h, n);
                        ImplicitSeries.Points.AddXY(t, UImplicit);
                    }

                    if (TrapezesMethodCheckBox.Checked)
                    {
                        UTrapezes = TrapezesMethod(U0, h, n);
                        TrapezesSeries.Points.AddXY(t, UTrapezes);
                    }

                    DataViewer.Rows.Add(t, UFunc, UExplicit, UImplicit, UTrapezes);

                    n++;
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    "Ошибка преобразования данных. " + ex.Message,
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка преобразования данных. "+ ex.Message,
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
        }

        //Явный метод Эйлера
        public double ExplicitEMethod(double U0, double h, int n)
        {
            return U0 * (Math.Pow((1 - h), n + 1));
        }

        //Неявный метод Эйлера
        public double ImplicitEMethod(double U0, double h, int n)
        {
            return U0 / (Math.Pow((1 + h), n + 1));
        }

        //Метод трапеций
        public double TrapezesMethod(double U0, double h, int n)
        {

            double phi = (U0 * (Math.Pow((1 - h), n + 1))) + (U0 / (Math.Pow((1 + h), n + 1)));
            return phi /= 2;
        }


        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        if (sender != null)
                            (sender as TextBox).SelectAll();
                        break;
                    case Keys.C:
                        if (sender != null)
                            (sender as TextBox).Copy();
                        break;
                    case Keys.X:
                        if (sender != null)
                            (sender as TextBox).Cut();
                        break;
                    case Keys.V:
                        if (sender != null)
                            (sender as TextBox).Paste();
                        break;
                }
                e.SuppressKeyPress = true;
            }
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((!Char.IsDigit(number) && e.KeyChar != 8 && e.KeyChar != ',') || (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(",") != -1))
            {
                e.Handled = true;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch((sender as TextBox).Text, @"\D"))
            {
                if (Regex.Match((sender as TextBox).Text, @"\D").Value != ",")
                {
                    (sender as TextBox).Text = "";
                }
            }
        }

        private void Chart_MouseWheelZoom(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta < 0)
                {
                    Chart.ChartAreas[0].AxisX.ScaleView.ZoomReset();
                    Chart.ChartAreas[0].AxisY.ScaleView.ZoomReset();
                }
                if (e.Delta > 0)
                {
                    double xMin = Chart.ChartAreas[0].AxisX.ScaleView.ViewMinimum;
                    double xMax = Chart.ChartAreas[0].AxisX.ScaleView.ViewMaximum;
                    double yMin = Chart.ChartAreas[0].AxisY.ScaleView.ViewMinimum;
                    double yMax = Chart.ChartAreas[0].AxisY.ScaleView.ViewMaximum;
                    double posXStart = Chart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 3;
                    double posXFinish = Chart.ChartAreas[0].AxisX.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 3;
                    double posYStart = Chart.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 3;
                    double posYFinish = Chart.ChartAreas[0].AxisY.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 3;
                    Chart.ChartAreas[0].AxisX.ScaleView.Zoom(posXStart, posXFinish);
                    Chart.ChartAreas[0].AxisY.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
