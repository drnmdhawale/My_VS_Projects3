using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber;
            int secondTextBoxNumber;
            int answer;

            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
            secondTextBoxNumber = int.Parse(tbSecondNumber.Text);
            answer = firstTextBoxNumber + secondTextBoxNumber;
            
            MessageBox.Show(answer.ToString());
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber;
            int secondTextBoxNumber;
            int ThirdTextBoxNumber;
            int answer;

            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
            secondTextBoxNumber = int.Parse(tbSecondNumber.Text);
            ThirdTextBoxNumber = int.Parse(tbThirdNumber.Text);
            answer = firstTextBoxNumber * secondTextBoxNumber * ThirdTextBoxNumber;

            MessageBox.Show(answer.ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber;
            int secondTextBoxNumber;
            int ThirdTextBoxNumber;
            int answer;

            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
            secondTextBoxNumber = int.Parse(tbSecondNumber.Text);
            ThirdTextBoxNumber = int.Parse(tbThirdNumber.Text);
            answer = firstTextBoxNumber + secondTextBoxNumber + ThirdTextBoxNumber;

            MessageBox.Show(answer.ToString());
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber;
            int secondTextBoxNumber;
            int ThirdTextBoxNumber;
            int answer;

            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
            secondTextBoxNumber = int.Parse(tbSecondNumber.Text);
            ThirdTextBoxNumber = int.Parse(tbThirdNumber.Text);
            answer = firstTextBoxNumber - secondTextBoxNumber - ThirdTextBoxNumber;

            MessageBox.Show(answer.ToString());
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber;
            int secondTextBoxNumber;
            int ThirdTextBoxNumber;
            int answer;

            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
            secondTextBoxNumber = int.Parse(tbSecondNumber.Text);
            ThirdTextBoxNumber = int.Parse(tbThirdNumber.Text);
            answer = firstTextBoxNumber / secondTextBoxNumber / ThirdTextBoxNumber;

            MessageBox.Show(answer.ToString());
        }
    }
}
