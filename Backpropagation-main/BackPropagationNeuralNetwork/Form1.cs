using Backprop;
using System.Diagnostics;
using System.Windows.Forms;

namespace BackPropagationNeuralNetwork
{
    public partial class Form1 : Form
    {
        NeuralNet NN;
        List<string> operations = new List<string> { "AND", "OR" };
        string op = "AND";
        int sizeOutput = 1;
        int sizeInput = 4;
        int maxInputs = 8;
        int minInputs = 2;
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = operations;
            createNeuralNetwork();
        }

        private void buttonCreate(object sender, EventArgs e)
        {
            createNeuralNetwork();
        }

        private void buttonTrain(object sender, EventArgs e)
        {
            int epoch = 4000;
            String result = "";
            for (int x = 1; x <= epoch; x++)
            {
                var inputs = new List<int>(Enumerable.Repeat(1, sizeInput));
                int u = (int)Math.Pow(2, sizeInput);
                for (int i = 0; i < u; i++)
                {
                    for (int j = 0; j < sizeInput; j++)
                    {
                        inputs[j] = (i & (1 << j)) != 0 ? 1 : 0;
                        //Debug.Write(inputs[j] + " ");
                        NN.setInputs(j, inputs[j]);
                    }
                    int desired = inputs[0];

                    for (int j = 1; j < sizeInput; j++)
                    {
                        switch (op)
                        {
                            case "AND":
                                desired &= inputs[j];
                                break;
                            case "OR":
                                desired |= inputs[j];
                                break;
                        }
                    }
                    //Debug.Write(" " + desired + "\n");
                    NN.setDesiredOutput(0, desired);
                    NN.learn();
                }

                NN.run();
                double output = NN.getOuputData(0);

                result += $"Epoch {x}: {output.ToString("#.####")}\r\n";

                // Stop condition based on threshold
                if (output >= Convert.ToDouble(thresholdTextBox.Text))
                {
                    break;
                }
            }
            textBox1.Text = result;
        }

        private void buttonTest(object sender, EventArgs e)
        {
            for (int i = 0; i < sizeInput; i++)
            {
                NN.setInputs(i, Convert.ToDouble(inputsContainer.Controls[i].Text));
            }
            NN.run();
            double result = Math.Round(NN.getOuputData(0));

            this.result.Text = result.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            op = operations[comboBox1.SelectedIndex];
            createNeuralNetwork();
        }

        private void createNeuralNetwork()
        {
            //https://stackoverflow.com/questions/52485608/how-to-choose-the-number-of-hidden-layers-and-nodes#:~:text=The%20number%20of%20hidden%20neurons,size%20of%20the%20input%20layer.
            //The number of hidden neurons should be 2 / 3 the size of the input layer, plus the size of the output layer.
            int hiddenLayerSize =(int)((2.0 / 3) * sizeInput + sizeOutput);
            NN = new NeuralNet(sizeInput, hiddenLayerSize, sizeOutput);
        }

        private void buttonIncremetInput_Click(object sender, EventArgs e)
        {
            if (sizeInput >= maxInputs)
            {
                MessageBox.Show("Maximum inputs is set to " + maxInputs);
                return;
            }
            sizeInput++;
            TextBox input = new TextBox();
            input.Name = "input" + sizeInput;
            input.Size = new Size(100, 23);
            input.Text = "1";
            inputsContainer.Controls.Add(input);
            createNeuralNetwork();
        }

        private void buttonDecrementInput_Click(object sender, EventArgs e)
        {
            if (sizeInput <= minInputs)
            {
                MessageBox.Show("Minimum inputs is set to " + minInputs);
                return;
            }
            Control lastControl = inputsContainer.Controls[inputsContainer.Controls.Count - 1];
            inputsContainer.Controls.Remove(lastControl);
            sizeInput--;
            createNeuralNetwork();
        }
    }
}
