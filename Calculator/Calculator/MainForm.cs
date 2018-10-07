using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FunctionGroupCmBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            var functionList = new List<List<object>>
            {
                new List<object>
                {
                    "Синус",
                    "Косинус",
                    "Тангенс",
                    "Котангенс",
                    "Секанс",
                    "Косеканс"
                },
                new List<object>
                {
                    "Арксинус",
                    "Арккосинус",
                    "Арктангенс",
                    "Арккотангенс"
                },
                new List<object>
                {
                    "Гиперболический синус",
                    "Гиперболический косинус",
                    "Гиперболический тангенс",
                    "Гиперболический котангенс",
                },
                new List<object>
                {
                    "Ареасинус",
                    "Ареакосинус",
                    "Ареатангенс",
                    "Ареакотангенс",
                },
            };
            FunctionList.Items.Clear();
            FunctionList.Items.AddRange(functionList[FunctionGroupCmBx.SelectedIndex].ToArray());
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
