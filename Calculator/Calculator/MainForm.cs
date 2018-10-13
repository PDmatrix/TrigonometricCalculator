using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private readonly List<Dictionary<object, string>> _functionList = new List<Dictionary<object, string>>
        {
            new Dictionary<object, string>
            {
                {"Синус", "Sinus"},
                {"Косинус", "Cosinus"},
                {"Тангенс", "Tangens"},
                {"Котангенс", "Cotangens"},
                {"Секанс", "Secans"},
                {"Косеканс", "Cosecans"},
            },
            new Dictionary<object, string>
            {
                {"Арксинус", "Arcsinus"},
                {"Арккосинус", "Arccosinus"},
                {"Арктангенс", "Arctangens"},
                {"Арккотангенс", "Arccotangens"},
            },
            new Dictionary<object, string>
            {
                {"Гиперболический синус", "Sinush"},
                {"Гиперболический косинус", "Cosinush"},
                {"Гиперболический тангенс", "Tangensh"},
                {"Гиперболический котангенс", "Cotangensh"},
            },
            new Dictionary<object, string>
            {
                {"Ареасинус", "Areasinus"},
                {"Ареакосинус", "Areacosinus"},
                {"Ареатангенс", "Areatangens"},
                {"Ареакотангенс", "Areacotangens"},
            },
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void FunctionGroupCmBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            FunctionList.Items.Clear();
            switch (FunctionGroupCmBx.SelectedIndex)
            {
                case 0:
                    inputPanel.Visible = true;
                    outputPanel.Visible = false;
                    break;
                case 1:
                    inputPanel.Visible = false;
                    outputPanel.Visible = true;
                    break;
                default:
                    inputPanel.Visible = false;
                    outputPanel.Visible = false;
                    break;
            }
            FunctionList.Items.AddRange(_functionList[FunctionGroupCmBx.SelectedIndex].Keys.ToArray());
        }

        private static IEnumerable<int> SplitVal(string val)
        {
            return val.Split(new[] { "\'\'" }, StringSplitOptions.None)
                .SelectMany(r => r.Split('\''))
                .Select(r => Convert.ToInt32(r))
                .ToArray();
        }

        private double GetInputRadianValue()
        {
            if (!inputPanel.Visible)
            {
                return Convert.ToDouble(InputTxBx.Text);
            }

            if (isDegreeIn.Checked)
            {
                return MathConverter.DegreeToRadian(SplitVal(InputTxBx.Text));
            }

            if (isGradIn.Checked)
            {
                return MathConverter.GradToRadian(SplitVal(InputTxBx.Text));
            }

            return Convert.ToDouble(InputTxBx.Text);
        }

        private static string DegreeStringify(double value)
        {
            var degree = (int) value;
            var minuteDouble = (value - Math.Truncate(value)) * 60;
            var minute = (int) minuteDouble;
            var secondDouble = (minuteDouble - Math.Truncate(minuteDouble)) * 60;
            var second = (int) secondDouble;
            return $@"{degree}'{minute}''{second}";
        }

        private static string GradStringify(double value)
        {
            var degree = (int)value;
            var minuteDouble = (value - Math.Truncate(value)) * 100;
            var minute = (int)minuteDouble;
            var secondDouble = (minuteDouble - Math.Truncate(minuteDouble)) * 100;
            var second = (int)secondDouble;
            return $@"{degree}'{minute}''{second}";
        }

        private string SetOutputValue(double radianValue)
        {
            if (!outputPanel.Visible)
            {
                return radianValue.ToString(CultureInfo.CurrentCulture);
            }

            if (isDegreeOut.Checked)
            {
                var radianToDegreeValue = MathConverter.RadianToDegree(radianValue);
                return DegreeStringify(radianToDegreeValue);
            }

            if (isGradOut.Checked)
            {
                var radianToDegreeValue = MathConverter.RadianToGrad(radianValue);
                return GradStringify(radianToDegreeValue);
            }

            return radianValue.ToString(CultureInfo.CurrentCulture);
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (FunctionList.SelectedIndex == -1)
            {
                MessageBox.Show(@"Пожалуйста, выберите функцию для вычисления", 
                    @"Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            var index = FunctionGroupCmBx.SelectedIndex == -1 ? 0 : FunctionGroupCmBx.SelectedIndex;

            var function = typeof(Functions)
                .GetMethod(_functionList[index].Values
                .ElementAt(FunctionList.SelectedIndex));

            var inputRadianValue = GetInputRadianValue();
            var outputRadianValue = Convert.ToDouble(function?.Invoke(typeof(Functions), new object[] { inputRadianValue }));

            InputTxBx.Text = SetOutputValue(outputRadianValue);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            InputTxBx.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
