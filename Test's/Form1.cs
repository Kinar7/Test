namespace Test_s
{
    public partial class Form1 : Form
    {
        int currentQuestion = 0;
        int totalQuestion = 10;
        int totalAnswer = 0;
        double currentAnswer = 0;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Question_Click(object sender, EventArgs e)
        {
            if (currentQuestion < totalQuestion)
            {
                int num1 = random.Next(1, 11);
                int num2 = random.Next(1, 11);
                string[] operations = { "+", "*", "-", "/" };
                string operation = operations[random.Next(operations.Length)];

                switch (operation)
                {
                    case "+":
                        currentAnswer = num1 + num2;
                        break;
                    case "-":
                        currentAnswer = num1 - num2;
                        break;
                    case "*":
                        currentAnswer = num1 * num2;
                        break;
                    case "/":
                        currentAnswer = num2 != 0 ? (double)num1 / num2 : 0;
                        break;
                }

                Question.Text = $"{num1} {operation} {num2}";
                Answer.Clear();
                currentQuestion++;
            }
            else
            {
                Question.Visible = false;
                Answer.Visible = false;
                Result.Text = $"{totalAnswer} / {totalQuestion}";
                Result.Visible = true;
            }
        }

        private void Answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (double.TryParse(Answer.Text, out double userAnswer))
                {
                    if (Math.Abs(userAnswer - currentAnswer) < 0.0001)
                    {
                        totalAnswer++;
                    }
                    Question_Click(sender, e); 
                }
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}