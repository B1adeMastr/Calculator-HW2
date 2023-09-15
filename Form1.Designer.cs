namespace Calculator_HW2
{
    partial class Calculator
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
            Decimal = new Button();
            Num0 = new Button();
            Clear = new Button();
            Calculate = new Button();
            Num3 = new Button();
            Num2 = new Button();
            Num1 = new Button();
            Num6 = new Button();
            Num5 = new Button();
            Num4 = new Button();
            SQRT = new Button();
            Square = new Button();
            Divide = new Button();
            Multiply = new Button();
            Add = new Button();
            Subtract = new Button();
            Num9 = new Button();
            Num8 = new Button();
            Num7 = new Button();
            Output = new TextBox();
            SuspendLayout();
            // 
            // Decimal
            // 
            Decimal.BackColor = SystemColors.ActiveCaption;
            Decimal.Location = new Point(46, 356);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(75, 57);
            Decimal.TabIndex = 0;
            Decimal.Text = ".";
            Decimal.UseVisualStyleBackColor = false;
            Decimal.Click += Decimal_Click;
            // 
            // Num0
            // 
            Num0.BackColor = SystemColors.ActiveCaption;
            Num0.Location = new Point(168, 356);
            Num0.Name = "Num0";
            Num0.Size = new Size(75, 57);
            Num0.TabIndex = 1;
            Num0.Tag = "Num0";
            Num0.Text = "0";
            Num0.UseVisualStyleBackColor = false;
            Num0.Click += button2_Click;
            // 
            // Clear
            // 
            Clear.BackColor = SystemColors.ActiveCaption;
            Clear.Location = new Point(289, 356);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 57);
            Clear.TabIndex = 2;
            Clear.Tag = "Clear";
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Calculate
            // 
            Calculate.Location = new Point(543, 357);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(208, 56);
            Calculate.TabIndex = 3;
            Calculate.Text = "=";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // Num3
            // 
            Num3.BackColor = SystemColors.ActiveCaption;
            Num3.Location = new Point(289, 294);
            Num3.Name = "Num3";
            Num3.Size = new Size(75, 57);
            Num3.TabIndex = 6;
            Num3.Text = "3";
            Num3.UseVisualStyleBackColor = false;
            Num3.Click += Num3_Click;
            // 
            // Num2
            // 
            Num2.BackColor = SystemColors.ActiveCaption;
            Num2.Location = new Point(168, 294);
            Num2.Name = "Num2";
            Num2.Size = new Size(75, 57);
            Num2.TabIndex = 5;
            Num2.Tag = "Num2";
            Num2.Text = "2";
            Num2.UseVisualStyleBackColor = false;
            Num2.Click += button6_Click;
            // 
            // Num1
            // 
            Num1.BackColor = SystemColors.ActiveCaption;
            Num1.Location = new Point(46, 294);
            Num1.Name = "Num1";
            Num1.Size = new Size(75, 57);
            Num1.TabIndex = 4;
            Num1.Tag = "Num1";
            Num1.Text = "1";
            Num1.UseVisualStyleBackColor = false;
            Num1.Click += button7_Click;
            // 
            // Num6
            // 
            Num6.BackColor = SystemColors.ActiveCaption;
            Num6.Location = new Point(289, 231);
            Num6.Name = "Num6";
            Num6.Size = new Size(75, 57);
            Num6.TabIndex = 9;
            Num6.Text = "6";
            Num6.UseVisualStyleBackColor = false;
            Num6.Click += Num6_Click;
            // 
            // Num5
            // 
            Num5.BackColor = SystemColors.ActiveCaption;
            Num5.Location = new Point(168, 231);
            Num5.Name = "Num5";
            Num5.Size = new Size(75, 57);
            Num5.TabIndex = 8;
            Num5.Text = "5";
            Num5.UseVisualStyleBackColor = false;
            Num5.Click += Num5_Click;
            // 
            // Num4
            // 
            Num4.BackColor = SystemColors.ActiveCaption;
            Num4.Location = new Point(46, 231);
            Num4.Name = "Num4";
            Num4.Size = new Size(75, 57);
            Num4.TabIndex = 7;
            Num4.Text = "4";
            Num4.UseVisualStyleBackColor = false;
            Num4.Click += Num4_Click;
            // 
            // SQRT
            // 
            SQRT.BackColor = SystemColors.GradientActiveCaption;
            SQRT.Location = new Point(676, 294);
            SQRT.Name = "SQRT";
            SQRT.Size = new Size(75, 57);
            SQRT.TabIndex = 12;
            SQRT.Text = "SQRT";
            SQRT.UseVisualStyleBackColor = false;
            SQRT.Click += button11_Click;
            // 
            // Square
            // 
            Square.BackColor = SystemColors.GradientActiveCaption;
            Square.Location = new Point(543, 294);
            Square.Name = "Square";
            Square.Size = new Size(75, 57);
            Square.TabIndex = 11;
            Square.Text = "^2";
            Square.UseVisualStyleBackColor = false;
            Square.Click += Square_Click;
            // 
            // Divide
            // 
            Divide.BackColor = SystemColors.GradientActiveCaption;
            Divide.Location = new Point(676, 231);
            Divide.Name = "Divide";
            Divide.Size = new Size(75, 57);
            Divide.TabIndex = 10;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = false;
            Divide.Click += button13_Click;
            // 
            // Multiply
            // 
            Multiply.BackColor = SystemColors.GradientActiveCaption;
            Multiply.Location = new Point(543, 231);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(75, 57);
            Multiply.TabIndex = 13;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = false;
            Multiply.Click += Multiply_Click;
            // 
            // Add
            // 
            Add.BackColor = SystemColors.GradientActiveCaption;
            Add.Location = new Point(543, 168);
            Add.Name = "Add";
            Add.Size = new Size(75, 57);
            Add.TabIndex = 18;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // Subtract
            // 
            Subtract.BackColor = SystemColors.GradientActiveCaption;
            Subtract.Location = new Point(676, 168);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(75, 57);
            Subtract.TabIndex = 17;
            Subtract.Text = "-";
            Subtract.UseVisualStyleBackColor = false;
            Subtract.Click += button16_Click;
            // 
            // Num9
            // 
            Num9.BackColor = SystemColors.ActiveCaption;
            Num9.Location = new Point(289, 168);
            Num9.Name = "Num9";
            Num9.Size = new Size(75, 57);
            Num9.TabIndex = 16;
            Num9.Text = "9";
            Num9.UseVisualStyleBackColor = false;
            Num9.Click += Num9_Click;
            // 
            // Num8
            // 
            Num8.BackColor = SystemColors.ActiveCaption;
            Num8.Location = new Point(168, 168);
            Num8.Name = "Num8";
            Num8.Size = new Size(75, 57);
            Num8.TabIndex = 15;
            Num8.Text = "8";
            Num8.UseVisualStyleBackColor = false;
            Num8.Click += Num8_Click;
            // 
            // Num7
            // 
            Num7.BackColor = SystemColors.ActiveCaption;
            Num7.Location = new Point(46, 168);
            Num7.Name = "Num7";
            Num7.Size = new Size(75, 57);
            Num7.TabIndex = 14;
            Num7.Text = "7";
            Num7.UseVisualStyleBackColor = false;
            Num7.Click += Num7_Click;
            // 
            // Output
            // 
            Output.BackColor = SystemColors.ControlDark;
            Output.Enabled = false;
            Output.ForeColor = SystemColors.Info;
            Output.Location = new Point(76, 24);
            Output.Name = "Output";
            Output.ReadOnly = true;
            Output.Size = new Size(640, 23);
            Output.TabIndex = 19;
            Output.Tag = "Output";
            Output.TextChanged += Output_TextChanged;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Output);
            Controls.Add(Add);
            Controls.Add(Subtract);
            Controls.Add(Num9);
            Controls.Add(Num8);
            Controls.Add(Num7);
            Controls.Add(Multiply);
            Controls.Add(SQRT);
            Controls.Add(Square);
            Controls.Add(Divide);
            Controls.Add(Num6);
            Controls.Add(Num5);
            Controls.Add(Num4);
            Controls.Add(Num3);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Controls.Add(Calculate);
            Controls.Add(Clear);
            Controls.Add(Num0);
            Controls.Add(Decimal);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Decimal;
        private Button Num0;
        private Button Clear;
        private Button Calculate;
        private Button Num3;
        private Button Num2;
        private Button Num1;
        private Button Num6;
        private Button Num5;
        private Button Num4;
        private Button SQRT;
        private Button Square;
        private Button Divide;
        private Button Multiply;
        private Button Add;
        private Button Subtract;
        private Button Num9;
        private Button Num8;
        private Button Num7;
        private TextBox Output;
    }
}