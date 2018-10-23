namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputTxBx = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.FunctionGroupCmBx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isDegreeIn = new System.Windows.Forms.RadioButton();
            this.isRadianIn = new System.Windows.Forms.RadioButton();
            this.isGradIn = new System.Windows.Forms.RadioButton();
            this.FunctionList = new System.Windows.Forms.ListBox();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.isDegreeOut = new System.Windows.Forms.RadioButton();
            this.isRadianOut = new System.Windows.Forms.RadioButton();
            this.isGradOut = new System.Windows.Forms.RadioButton();
            this.inputPanel.SuspendLayout();
            this.outputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputTxBx
            // 
            this.InputTxBx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTxBx.Location = new System.Drawing.Point(12, 12);
            this.InputTxBx.Name = "InputTxBx";
            this.InputTxBx.Size = new System.Drawing.Size(548, 26);
            this.InputTxBx.TabIndex = 0;
            this.InputTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Red;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBtn.Location = new System.Drawing.Point(466, 174);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(94, 50);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "Очистить";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.BackColor = System.Drawing.Color.Lime;
            this.CalculateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateBtn.Location = new System.Drawing.Point(362, 174);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(98, 50);
            this.CalculateBtn.TabIndex = 2;
            this.CalculateBtn.Text = "Вычислить";
            this.CalculateBtn.UseVisualStyleBackColor = false;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // FunctionGroupCmBx
            // 
            this.FunctionGroupCmBx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionGroupCmBx.FormattingEnabled = true;
            this.FunctionGroupCmBx.Items.AddRange(new object[] {
            "Тригонометрические функции",
            "Обратные тригонометрические функции",
            "Гиперболические функции",
            "Обратные гиперболические функции"});
            this.FunctionGroupCmBx.Location = new System.Drawing.Point(12, 49);
            this.FunctionGroupCmBx.Name = "FunctionGroupCmBx";
            this.FunctionGroupCmBx.Size = new System.Drawing.Size(243, 26);
            this.FunctionGroupCmBx.TabIndex = 3;
            this.FunctionGroupCmBx.Text = "Выбор группы функций";
            this.FunctionGroupCmBx.SelectedIndexChanged += new System.EventHandler(this.FunctionGroupCmBx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Единица измерения входных данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Единица измерения выходных данных";
            // 
            // isDegreeIn
            // 
            this.isDegreeIn.AutoSize = true;
            this.isDegreeIn.Checked = true;
            this.isDegreeIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isDegreeIn.Location = new System.Drawing.Point(3, 3);
            this.isDegreeIn.Name = "isDegreeIn";
            this.isDegreeIn.Size = new System.Drawing.Size(88, 22);
            this.isDegreeIn.TabIndex = 7;
            this.isDegreeIn.TabStop = true;
            this.isDegreeIn.Text = "Градусы";
            this.isDegreeIn.UseVisualStyleBackColor = true;
            // 
            // isRadianIn
            // 
            this.isRadianIn.AutoSize = true;
            this.isRadianIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isRadianIn.Location = new System.Drawing.Point(97, 3);
            this.isRadianIn.Name = "isRadianIn";
            this.isRadianIn.Size = new System.Drawing.Size(91, 22);
            this.isRadianIn.TabIndex = 8;
            this.isRadianIn.Text = "Радианы";
            this.isRadianIn.UseVisualStyleBackColor = true;
            // 
            // isGradIn
            // 
            this.isGradIn.AutoSize = true;
            this.isGradIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isGradIn.Location = new System.Drawing.Point(198, 3);
            this.isGradIn.Name = "isGradIn";
            this.isGradIn.Size = new System.Drawing.Size(73, 22);
            this.isGradIn.TabIndex = 9;
            this.isGradIn.Text = "Грады";
            this.isGradIn.UseVisualStyleBackColor = true;
            // 
            // FunctionList
            // 
            this.FunctionList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionList.FormattingEnabled = true;
            this.FunctionList.ItemHeight = 18;
            this.FunctionList.Items.AddRange(new object[] {
            "Синус",
            "Косинус",
            "Тангенс",
            "Котангенс",
            "Секанс",
            "Косеканс"});
            this.FunctionList.Location = new System.Drawing.Point(12, 103);
            this.FunctionList.Name = "FunctionList";
            this.FunctionList.Size = new System.Drawing.Size(243, 112);
            this.FunctionList.TabIndex = 13;
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.isDegreeIn);
            this.inputPanel.Controls.Add(this.isRadianIn);
            this.inputPanel.Controls.Add(this.isGradIn);
            this.inputPanel.Controls.Add(this.label1);
            this.inputPanel.Location = new System.Drawing.Point(277, 46);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(283, 51);
            this.inputPanel.TabIndex = 14;
            // 
            // outputPanel
            // 
            this.outputPanel.Controls.Add(this.isDegreeOut);
            this.outputPanel.Controls.Add(this.isRadianOut);
            this.outputPanel.Controls.Add(this.isGradOut);
            this.outputPanel.Controls.Add(this.label2);
            this.outputPanel.Location = new System.Drawing.Point(275, 49);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(285, 48);
            this.outputPanel.TabIndex = 15;
            this.outputPanel.Visible = false;
            // 
            // isDegreeOut
            // 
            this.isDegreeOut.AutoSize = true;
            this.isDegreeOut.Checked = true;
            this.isDegreeOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isDegreeOut.Location = new System.Drawing.Point(3, 3);
            this.isDegreeOut.Name = "isDegreeOut";
            this.isDegreeOut.Size = new System.Drawing.Size(88, 22);
            this.isDegreeOut.TabIndex = 7;
            this.isDegreeOut.TabStop = true;
            this.isDegreeOut.Text = "Градусы";
            this.isDegreeOut.UseVisualStyleBackColor = true;
            // 
            // isRadianOut
            // 
            this.isRadianOut.AutoSize = true;
            this.isRadianOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isRadianOut.Location = new System.Drawing.Point(97, 3);
            this.isRadianOut.Name = "isRadianOut";
            this.isRadianOut.Size = new System.Drawing.Size(91, 22);
            this.isRadianOut.TabIndex = 8;
            this.isRadianOut.Text = "Радианы";
            this.isRadianOut.UseVisualStyleBackColor = true;
            // 
            // isGradOut
            // 
            this.isGradOut.AutoSize = true;
            this.isGradOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isGradOut.Location = new System.Drawing.Point(198, 3);
            this.isGradOut.Name = "isGradOut";
            this.isGradOut.Size = new System.Drawing.Size(73, 22);
            this.isGradOut.TabIndex = 9;
            this.isGradOut.Text = "Грады";
            this.isGradOut.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 236);
            this.Controls.Add(this.outputPanel);
            this.Controls.Add(this.inputPanel);
            this.Controls.Add(this.FunctionList);
            this.Controls.Add(this.FunctionGroupCmBx);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.InputTxBx);
            this.Name = "MainForm";
            this.Text = "Калькулятор тригонометрических функций";
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTxBx;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.ComboBox FunctionGroupCmBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton isDegreeIn;
        private System.Windows.Forms.RadioButton isRadianIn;
        private System.Windows.Forms.RadioButton isGradIn;
        private System.Windows.Forms.ListBox FunctionList;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Panel outputPanel;
        private System.Windows.Forms.RadioButton isDegreeOut;
        private System.Windows.Forms.RadioButton isRadianOut;
        private System.Windows.Forms.RadioButton isGradOut;
    }
}

