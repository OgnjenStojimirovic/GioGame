using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

    namespace GioGame
{
    public partial class Form1 : Form
    {
        
        int StopClicked = 0;
        bool IsGenerated = false;
        bool[] isClicked = new bool[6];
        string[] numbers = new string[6];
        bool flag = false;                  // number then aritmetical operation
        int LParenCount = 0;
        int RParenCount = 0;
        bool isGameOver = false;
        int time = 120;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            if (!IsGenerated)
            {
                switch (StopClicked)
                {
                    case 0:
                        Number1.Text = random.Next(0, 10).ToString();
                        StopClicked++;
                        break;

                    case 1:
                        Number2.Text = random.Next(0, 10).ToString();
                        StopClicked++;
                        break;

                    case 2:
                        Number3.Text = random.Next(0, 10).ToString();
                        StopClicked++;
                        break;

                    case 3:
                        Number4.Text = random.Next(1, 10).ToString();
                        numbers[0] = Number4.Text;
                        StopClicked++;
                        break;

                    case 4:
                        Number5.Text = random.Next(1, 10).ToString();
                        numbers[1] = Number5.Text;
                        StopClicked++;
                        break;

                    case 5:
                        Number6.Text = random.Next(1, 10).ToString();
                        numbers[2] = Number6.Text;
                        StopClicked++;
                        break;

                    case 6:
                        Number7.Text = random.Next(1, 10).ToString();
                        numbers[3] = Number7.Text;
                        StopClicked++;
                        break;

                    case 7:
                        int broj8 = random.Next(0, 2);
                        if (broj8.Equals(0))
                        {
                            broj8 = 10;
                        }
                        else if (broj8.Equals(1))
                        {
                            broj8 = 15;
                        }
                        else
                        {
                            broj8 = 20;
                        }

                        Number8.Text = broj8.ToString();
                        numbers[4] = Number8.Text;
                        StopClicked++;
                        break;

                    default:
                        // Generisanje nasumičnog broja za Number9
                        int broj9 = random.Next(0, 3);
                        if (broj9.Equals(0))
                        {
                            broj9 = 25;
                        }
                        else if (broj9.Equals(1))
                        {
                            broj9 = 50;
                        }
                        else if (broj9.Equals(2))
                        {
                            broj9 = 75;
                        }
                        else
                        {
                            broj9 = 100;
                        }

                        Number9.Text = broj9.ToString();
                        numbers[5] = Number9.Text;

                        StopClicked = 0;    // Reset
                        IsGenerated = true;
                        CountDown.Start();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Already Genarated all numbers");
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)  //MINUS
        {
            if (IsGenerated && flag && !isGameOver)
            {
                textBox1.Text += '-';
                flag = false;
            }
        }

        private bool IsValidExpression(string expression)
        {
            if (expression == null)
            {
                Console.WriteLine("IsValidExpresion got null");
                return false;
            }
            if(expression.Length == 0)
            {
                Console.WriteLine("IsValidExpresion expresion is empty string");
                return true;
            }
            if (LParenCount == LParenCount && flag == true)
            {
                return true;
            }

            Console.WriteLine("IsValidExpresion before turning false");
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsGenerated && !isGameOver)
            {
                if (IsValidExpression(textBox1.Text)){
                    var your_score = new DataTable().Compute(textBox1.Text, null);
                    if(your_score is int)
                    {
                        MyRes.Text = your_score.ToString();
                    }
                    else
                    {
                        MyRes.Text = "*.*";
                    }
                    isGameOver = true;
                }
                else
                {
                    MyRes.Text = "*.*";
                }
                isGameOver = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (IsGenerated && flag && !isGameOver)
            {
                textBox1.Text += '+';
                flag = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Number1_Click(object sender, EventArgs e)
        {
          
        }

        private void Number2_Click(object sender, EventArgs e)
        {
           
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            if (isClicked[0] == true)
            {
                Console.WriteLine("Already used!");
            }
            else if (IsGenerated == false && isGameOver)
            {
                Console.WriteLine("Not Generated or Game is over!");
            }
            else if (flag == false && !isGameOver && IsGenerated == true)
            {
                textBox1.Text += Number4.Text;
                isClicked[0] = true;
                flag = true;
            }
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            if (isClicked[1] == true)
            {
                Console.WriteLine("Already used!");
            }
            else if (IsGenerated == false && isGameOver)
            {
                Console.WriteLine("Not Generated or Game is over!");
            }
            else if (flag == false && !isGameOver && IsGenerated == true)
            {
                textBox1.Text += Number5.Text;
                isClicked[1] = true;
                flag = true;
            }
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            if (isClicked[2] == true)
            {
                Console.WriteLine("Already used!");
            }
            else if (IsGenerated == false && isGameOver)
            {
                Console.WriteLine("Not Generated or Game is Over!");
            }
            else if (flag == false && !isGameOver && IsGenerated == true)
            {
                textBox1.Text += Number6.Text;
                isClicked[2] = true;
                flag = true;
            }
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            if (isClicked[3] == true)
            {
                Console.WriteLine("Already used!");
            }
            else if (IsGenerated == false && isGameOver)
            {
                Console.WriteLine("Not Generated!");
            }
            else if (flag == false && !isGameOver && IsGenerated == true)
            {
                textBox1.Text += Number7.Text;
                isClicked[3] = true;
                flag = true;
            }
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            if (isClicked[4] == true)
            {
                Console.WriteLine("Already used!");
            }
            else if (IsGenerated == false && isGameOver)
            {
                Console.WriteLine("Not Generated or Game is over!");
            }
            else if (flag == false && !isGameOver && IsGenerated == true)
            {
                textBox1.Text += Number8.Text;
                isClicked[4] = true;
                flag = true;
            }
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            if (isClicked[5] == true)
            {
                Console.WriteLine("Already used!");
            }
            else if (IsGenerated == false && isGameOver)
            {
                Console.WriteLine("Not Generated or Game is over!");
            }
            else if (flag == false && !isGameOver && IsGenerated == true)
            {
                textBox1.Text += Number9.Text;
                isClicked[5] = true;
                flag = true;
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (IsGenerated && flag && !isGameOver)
            {
                textBox1.Text += '*';
                flag = false;
            }
        }

        private void Devide_Click(object sender, EventArgs e)
        {
            if (IsGenerated && flag && !isGameOver)
            {
                textBox1.Text += '/';
                flag = false;
            }
        }

        private void LParen_Click(object sender, EventArgs e)
        {
            if (IsGenerated && !isGameOver)
            {
                textBox1.Text += '(';
                LParenCount++;
                flag = false;
            }
        }

        private void RParen_Click(object sender, EventArgs e)
        {
            if (IsGenerated && !isGameOver)
            {
                textBox1.Text += ')';
                RParenCount++;
                flag = true;
            }
        }

        private bool bksp_function(string number)
        {
            for(int i=0; i< numbers.Length; i++){
                if (number.Equals(numbers[i])) {
                    isClicked[i] = false;
                    return true;
                }
            }
            return false;
        }

        private void Bksp_Click(object sender, EventArgs e)
        {
            if (IsGenerated && textBox1.Text.Length != 0)
            {
                if (textBox1.Text.Length >= 2)
                {
                    char last_element = textBox1.Text[textBox1.Text.Length - 1];
                    char second_last_element = textBox1.Text[textBox1.Text.Length - 2];

                    if (char.IsDigit(last_element) && char.IsDigit(second_last_element)) // Dvocifren
                    {
                        Console.WriteLine("IF A DVOCIFREN");
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 2);
                        string number = second_last_element.ToString() + last_element.ToString();
                        bksp_function(number);
                        flag = false;
                    }
                    else if (char.IsDigit(last_element)) // Jednocifren
                    {
                        Console.WriteLine("IF A Jednocifren");
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                        string number = last_element.ToString();
                        bksp_function(number);
                        flag = false;
                    }
                    else // Nije broj
                    {
                        Console.WriteLine("IF A Nije broj");
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                        flag = true;
                    }
                }
                else
                {
                    char last_element = textBox1.Text[textBox1.Text.Length - 1];
                    if (char.IsDigit(last_element))
                    {
                        Console.WriteLine("IF B jednocifren");
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                        string number = last_element.ToString();
                        bksp_function(number);
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("IF B Nije broj");
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                        flag = false;
                    }
                }
            }

        }

        private void Computer_Click(object sender, EventArgs e)
        {

        }

        private void MyRes_Click(object sender, EventArgs e)
        {

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            isGameOver = false;
            IsGenerated = false;
            StopClicked = 0;
            flag = false;
            RParenCount = 0;
            LParenCount = 0;
            time = 120;
            Number1.Text = "#";
            Number2.Text = "#";
            Number3.Text = "#";
            Number4.Text = "#";
            Number5.Text = "#";
            Number6.Text = "#";
            Number7.Text = "#";
            Number8.Text = "#";
            Number9.Text = "#";
            textBox1.Text = "";
            MyRes.Text = "       ";
            CompRes.Text = "       ";
            TimerCountDown.Text = "       ";

            for (int i=0; i<=5; i++)
            {
                isClicked[i] = false;
                numbers[i] = null;
            }
            CountDown.Stop();
        }

        private void CompRes_Click(object sender, EventArgs e)
        {

        }

        private void CountDown_Tick(object sender, EventArgs e)
        {
            if (!isGameOver) { 
                TimerCountDown.Text = time--.ToString();
                if(time == -1)
                {
                    CountDown.Stop();
                    isGameOver = true;
                    MessageBox.Show("Time is over");
                    button3_Click(sender, e);
                }
            }
        }

        private void TimerCountDown_Click(object sender, EventArgs e)
        {

        }
    }
}
