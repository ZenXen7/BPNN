namespace BackPropagationNeuralNetwork
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
            input1 = new TextBox();
            result = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            input2 = new TextBox();
            input3 = new TextBox();
            input4 = new TextBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            thresholdTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            inputsContainer = new FlowLayoutPanel();
            buttonIncremetInput = new Button();
            buttonDecrementInput = new Button();
            flowLayoutPanel1.SuspendLayout();
            inputsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // input1
            // 
            input1.Location = new Point(3, 3);
            input1.Name = "input1";
            input1.Size = new Size(100, 23);
            input1.TabIndex = 0;
            input1.Text = "1";
            // 
            // result
            // 
            result.Location = new Point(3, 3);
            result.Name = "result";
            result.Size = new Size(100, 23);
            result.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(423, 249);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 3;
            button1.Text = "Create BPNN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCreate;
            // 
            // button2
            // 
            button2.Location = new Point(423, 289);
            button2.Name = "button2";
            button2.Size = new Size(118, 23);
            button2.TabIndex = 4;
            button2.Text = "Train";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonTrain;
            // 
            // button3
            // 
            button3.Location = new Point(423, 192);
            button3.Name = "button3";
            button3.Size = new Size(118, 23);
            button3.TabIndex = 5;
            button3.Text = "Test";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonTest;
            // 
            // input2
            // 
            input2.Location = new Point(3, 32);
            input2.Name = "input2";
            input2.Size = new Size(100, 23);
            input2.TabIndex = 6;
            input2.Text = "1";
            // 
            // input3
            // 
            input3.Location = new Point(3, 61);
            input3.Name = "input3";
            input3.Size = new Size(100, 23);
            input3.TabIndex = 7;
            input3.Text = "1";
            // 
            // input4
            // 
            input4.Location = new Point(3, 90);
            input4.Name = "input4";
            input4.Size = new Size(100, 23);
            input4.TabIndex = 8;
            input4.Text = "1";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(295, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(588, 99);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(200, 153);
            textBox1.TabIndex = 10;
            // 
            // thresholdTextBox
            // 
            thresholdTextBox.Location = new Point(426, 333);
            thresholdTextBox.Name = "thresholdTextBox";
            thresholdTextBox.Size = new Size(100, 23);
            thresholdTextBox.TabIndex = 11;
            thresholdTextBox.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(426, 315);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 12;
            label1.Text = "Threshold";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 13;
            label2.Text = "Result";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(result);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(423, 135);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(108, 51);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // inputsContainer
            // 
            inputsContainer.Controls.Add(input1);
            inputsContainer.Controls.Add(input2);
            inputsContainer.Controls.Add(input3);
            inputsContainer.Controls.Add(input4);
            inputsContainer.Location = new Point(49, 99);
            inputsContainer.Name = "inputsContainer";
            inputsContainer.Size = new Size(116, 267);
            inputsContainer.TabIndex = 15;
            // 
            // buttonIncremetInput
            // 
            buttonIncremetInput.Location = new Point(171, 137);
            buttonIncremetInput.Name = "buttonIncremetInput";
            buttonIncremetInput.Size = new Size(28, 23);
            buttonIncremetInput.TabIndex = 16;
            buttonIncremetInput.Text = "+";
            buttonIncremetInput.UseVisualStyleBackColor = true;
            buttonIncremetInput.Click += buttonIncremetInput_Click;
            // 
            // buttonDecrementInput
            // 
            buttonDecrementInput.Location = new Point(171, 166);
            buttonDecrementInput.Name = "buttonDecrementInput";
            buttonDecrementInput.Size = new Size(28, 23);
            buttonDecrementInput.TabIndex = 17;
            buttonDecrementInput.Text = "-";
            buttonDecrementInput.UseVisualStyleBackColor = true;
            buttonDecrementInput.Click += buttonDecrementInput_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDecrementInput);
            Controls.Add(buttonIncremetInput);
            Controls.Add(inputsContainer);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(thresholdTextBox);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            inputsContainer.ResumeLayout(false);
            inputsContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input1;
        private TextBox result;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox input2;
        private TextBox input3;
        private TextBox input4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox thresholdTextBox;
        private Label label1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel inputsContainer;
        private Button buttonIncremetInput;
        private Button buttonDecrementInput;
    }
}
