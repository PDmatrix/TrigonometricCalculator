using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        // Поле со всеми функциями и названиями методов для этих функций
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

        private void ChangePanelVisibility()
        {
            // В зависимости от выбранного индекса меняем видимость панелей
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
        }

        private void FunctionGroupCmBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            FunctionList.Items.Clear();

            // Меняем панель для ввода или вывода данных в зависимости от выбранной группы функций
            ChangePanelVisibility();

            // Заполнение листа с функциями в зависимости от выбранной группы функций
            FunctionList.Items.AddRange(_functionList[FunctionGroupCmBx.SelectedIndex].Keys.ToArray());
        }

        private static IEnumerable<int> SplitVal(string val)
        {
            // Разделение текста на массив для дальнейшего вывода градусов, секунда и минут
            return val.Split(new[] { "\'\'" }, StringSplitOptions.None)
                .SelectMany(r => r.Split('\''))
                .Select(r => Convert.ToInt32(r))
                .ToArray();
        }

        private double GetInputRadianValue()
        {
            // Если панель с выбором входных значений отсутствует, то возвращается введеное значение в типе double 
            if (!inputPanel.Visible)
            {
                return Convert.ToDouble(InputTxBx.Text);
            }

            // Из градусов в радианы
            if (isDegreeIn.Checked)
            {
                return MathConverter.DegreeToRadian(SplitVal(InputTxBx.Text));
            }

            // Из градов в радианы
            if (isGradIn.Checked)
            {
                return MathConverter.GradToRadian(SplitVal(InputTxBx.Text));
            }

            // Введеное значение в double
            return Convert.ToDouble(InputTxBx.Text);
        }

        private static string DegreeStringify(double value)
        {
            // Вычисление градусов, минут и секунд исходя из переданного значения
            var degree = (int) value;
            var minuteDouble = (value - Math.Truncate(value)) * 60;
            var minute = (int) minuteDouble;
            var secondDouble = (minuteDouble - Math.Truncate(minuteDouble)) * 60;
            var second = (int) secondDouble;
            return $@"{degree}'{minute}''{second}";
        }

        private static string GradStringify(double value)
        {
            // Вычисление градов, минут и секунд исходя из переданного значения
            var degree = (int)value;
            var minuteDouble = (value - Math.Truncate(value)) * 100;
            var minute = (int)minuteDouble;
            var secondDouble = (minuteDouble - Math.Truncate(minuteDouble)) * 100;
            var second = (int)secondDouble;
            return $@"{degree}'{minute}''{second}";
        }

        private string SetOutputValue(double radianValue)
        {
            // Если панель с выбором выходных значений отсутствует, то возвращается значение в типе string 
            if (!outputPanel.Visible)
            {
                return radianValue.ToString(CultureInfo.CurrentCulture);
            }

            // Из радиан в градусы
            if (isDegreeOut.Checked)
            {
                var radianToDegreeValue = MathConverter.RadianToDegree(radianValue);
                return DegreeStringify(radianToDegreeValue);
            }

            // Из радиан в грады
            if (isGradOut.Checked)
            {
                var radianToDegreeValue = MathConverter.RadianToGrad(radianValue);
                return GradStringify(radianToDegreeValue);
            }

            // Полученное значение в string
            return radianValue.ToString(CultureInfo.CurrentCulture);
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            // Не даем пользователю вычислять функцию, пока он не выбрал ее
            if (FunctionList.SelectedIndex == -1)
            {
                MessageBox.Show(@"Пожалуйста, выберите функцию для вычисления", 
                    @"Ошибка", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            // Исключаем возможность вводить буквы
            if (!ValidateInput(InputTxBx.Text))
            {
                MessageBox.Show("Ошибка ввода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // По умолчанию выбираем тригонометрические функции, либо, выбираем выбранную группу функций
            var index = FunctionGroupCmBx.SelectedIndex == -1 ? 0 : FunctionGroupCmBx.SelectedIndex;

            // Определяем, какую функцию необходимо выполнить
            var function = typeof(Functions)
                .GetMethod(_functionList[index].Values
                .ElementAt(FunctionList.SelectedIndex));

            // Обрабатываемы входные данные в соответствии выбранным критериям
            var inputValue = GetInputRadianValue();

            // Получаем значение из выбранной функции
            var outputValue = Convert.ToDouble(function?.Invoke(typeof(Functions), new object[] { inputValue }));

            // Обрабатываемы входные данные в соответствии выбранным критериям и выводим результат 
            InputTxBx.Text = SetOutputValue(outputValue);
        }

        private static bool ValidateInput(string text)
        {
            // Проверка на наличие букв 
            return !text.Where(char.IsLetter).Any();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            InputTxBx.Clear();
        }
    }
}
