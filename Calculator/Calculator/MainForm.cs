using System;
using System.Collections.Generic;
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
            FunctionList.Items.AddRange(_functionList[FunctionGroupCmBx.SelectedIndex].Keys.ToArray());
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

            //var valueToPass = MathConverter.ConvertTo

            var index = FunctionGroupCmBx.SelectedIndex == -1 ? 0 : FunctionGroupCmBx.SelectedIndex;

            var function = typeof(Functions)
                .GetMethod(_functionList[index].Values
                .ElementAt(FunctionList.SelectedIndex));


            function?.Invoke(typeof(Functions), new object[] { double.Epsilon });
        }
    }
}
