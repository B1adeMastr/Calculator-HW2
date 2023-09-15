namespace Calculator_HW2
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
            Blank = new Button();
            Num0 = new Button();
            Clear = new Button();
            Equals = new Button();
            Num3 = new Button();
            button6 = new Button();
            button7 = new Button();
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
            // Blank
            // 
            Blank.Location = new Point(46, 356);
            Blank.Name = "Blank";
            Blank.Size = new Size(75, 57);
            Blank.TabIndex = 0;
            Blank.UseVisualStyleBackColor = true;
            // 
            // Num0
            // 
            Num0.Location = new Point(168, 356);
            Num0.Name = "Num0";
            Num0.Size = new Size(75, 57);
            Num0.TabIndex = 1;
            Num0.Tag = "Num0";
            Num0.Text = "0";
            Num0.UseVisualStyleBackColor = true;
            Num0.Click += button2_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(289, 356);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 57);
            Clear.TabIndex = 2;
            Clear.Tag = "Clear";
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = true;
            // 
            // Equals
            // 
            Equals.Location = new Point(543, 357);
            Equals.Name = "Equals";
            Equals.Size = new Size(208, 56);
            Equals.TabIndex = 3;
            Equals.Text = "=";
            Equals.UseVisualStyleBackColor = true;
            // 
            // Num3
            // 
            Num3.Location = new Point(289, 294);
            Num3.Name = "Num3";
            Num3.Size = new Size(75, 57);
            Num3.TabIndex = 6;
            Num3.Text = "3";
            Num3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(168, 294);
            button6.Name = "button6";
            button6.Size = new Size(75, 57);
            button6.TabIndex = 5;
            button6.Tag = "Num2";
            button6.Text = "2";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(46, 294);
            button7.Name = "button7";
            button7.Size = new Size(75, 57);
            button7.TabIndex = 4;
            button7.Tag = "Num1";
            button7.Text = "1";
            button7.UseVisualStyleBackColor = true;
            // 
            // Num6
            // 
            Num6.Location = new Point(289, 231);
            Num6.Name = "Num6";
            Num6.Size = new Size(75, 57);
            Num6.TabIndex = 9;
            Num6.Text = "6";
            Num6.UseVisualStyleBackColor = true;
            // 
            // Num5
            // 
            Num5.Location = new Point(168, 231);
            Num5.Name = "Num5";
            Num5.Size = new Size(75, 57);
            Num5.TabIndex = 8;
            Num5.Text = "5";
            Num5.UseVisualStyleBackColor = true;
            // 
            // Num4
            // 
            Num4.Location = new Point(46, 231);
            Num4.Name = "Num4";
            Num4.Size = new Size(75, 57);
            Num4.TabIndex = 7;
            Num4.Text = "4";
            Num4.UseVisualStyleBackColor = true;
            // 
            // SQRT
            // 
            SQRT.Location = new Point(676, 294);
            SQRT.Name = "SQRT";
            SQRT.Size = new Size(75, 57);
            SQRT.TabIndex = 12;
            SQRT.Text = "SQRT";
            SQRT.UseVisualStyleBackColor = true;
            SQRT.Click += button11_Click;
            // 
            // Square
            // 
            Square.Location = new Point(543, 294);
            Square.Name = "Square";
            Square.Size = new Size(75, 57);
            Square.TabIndex = 11;
            Square.Text = "^2";
            Square.UseVisualStyleBackColor = true;
            // 
            // Divide
            // 
            Divide.Location = new Point(676, 231);
            Divide.Name = "Divide";
            Divide.Size = new Size(75, 57);
            Divide.TabIndex = 10;
            Divide.Text = "/";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += button13_Click;
            // 
            // Multiply
            // 
            Multiply.Location = new Point(543, 231);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(75, 57);
            Multiply.TabIndex = 13;
            Multiply.Text = "*";
            Multiply.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.Location = new Point(543, 168);
            Add.Name = "Add";
            Add.Size = new Size(75, 57);
            Add.TabIndex = 18;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = true;
            // 
            // Subtract
            // 
            Subtract.Location = new Point(676, 168);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(75, 57);
            Subtract.TabIndex = 17;
            Subtract.Text = "-";
            Subtract.UseVisualStyleBackColor = true;
            Subtract.Click += button16_Click;
            // 
            // Num9
            // 
            Num9.Location = new Point(289, 168);
            Num9.Name = "Num9";
            Num9.Size = new Size(75, 57);
            Num9.TabIndex = 16;
            Num9.Text = "9";
            Num9.UseVisualStyleBackColor = true;
            // 
            // Num8
            // 
            Num8.Location = new Point(168, 168);
            Num8.Name = "Num8";
            Num8.Size = new Size(75, 57);
            Num8.TabIndex = 15;
            Num8.Text = "8";
            Num8.UseVisualStyleBackColor = true;
            // 
            // Num7
            // 
            Num7.Location = new Point(46, 168);
            Num7.Name = "Num7";
            Num7.Size = new Size(75, 57);
            Num7.TabIndex = 14;
            Num7.Text = "7";
            Num7.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            Output.Location = new Point(76, 24);
            Output.Name = "Output";
            Output.Size = new Size(640, 23);
            Output.TabIndex = 19;
            Output.Tag = "Output";
            // 
            // Form1
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
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(Equals);
            Controls.Add(Clear);
            Controls.Add(Num0);
            Controls.Add(Blank);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Blank;
        private Button Num0;
        private Button Clear;
        private Button Equals;
        private Button Num3;
        private Button button6;
        private Button button7;
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