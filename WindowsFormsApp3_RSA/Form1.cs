using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3_RSA
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxP.Text) && !string.IsNullOrEmpty(textBoxQ.Text) && !string.IsNullOrEmpty(textBoxMsgEncript.Text))
            {
                var p = int.Parse(textBoxP.Text);
                var q = int.Parse(textBoxQ.Text);
                var msg = int.Parse(textBoxMsgEncript.Text);
                gen_keys(p, q);

                int crypted = pow(msg, int.Parse(textBoxE.Text), int.Parse(textBoxN.Text)) % int.Parse((textBoxN.Text));
                textBoxC.Text = string.Format("{0}", crypted);
            }
            else
            {
                MessageBox.Show("Введите q, p, m!");
            }
        }

        /// <summary>
        /// Нахождение НОД алгоритм Евклида
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        private int gcd(int num1, int num2)
        {

            while (num1 != 0 && num2 != 0)
            {
                if (num1 > num2)
                {
                    num1 %= num2;
                }
                else
                {
                    num2 %= num1;
                }
            }
            return num1 | num2;
        }

        private void gen_keys(int p, int q)
        {
            int e, d = 0;

            if (string.IsNullOrEmpty(textBoxE.Text))
            {
                var lst = get_primes(300);
                e = lst[rand.Next(0, lst.Count)];
            }
            else
            {
                e = int.Parse(textBoxE.Text);
            }

            int n = p * q;
            int phi = (p - 1) * (q - 1);
            //e
            while (e < phi)
            {
                if (gcd(e, phi) == 1)
                {
                    break;
                }
                else
                {
                    e = e + 1;
                }
            }

            //d
            var t = 0;
            while ((e * t) % phi != 1)
            {
                t++;
            }
            d = t;

            textBoxD.Text = string.Format("{0}", d);
            textBoxE.Text = string.Format("{0}", e);
            textBoxN.Text = string.Format("{0}", n);

        }

        public int pow(int a, int b, int c)
        {
            int num = 1;
            for (int i = 0; i < b; i++)
            {
                num = num * a % c;
            }

            return num;
        }
        public static List<int> get_primes(int n)
        {
            // is_prime[i] == true, если i - простое число
            bool[] is_prime = new bool[n + 1];
            for (int i = 2; i <= n; ++i) is_prime[i] = true;
            // primes будет содержать все простые числа на отрезке от 1 до n
            List<int> primes = new List<int>();
            // Алгоритм Решето Эратосфена
            for (int i = 2; i <= n; ++i)
                if (is_prime[i])
                {
                    primes.Add(i);
                    if (i * i <= n)
                        for (int j = i * i; j <= n; j += i)
                            is_prime[j] = false;
                }
            return primes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxC.Text) && !string.IsNullOrEmpty(textBoxD.Text) && !string.IsNullOrEmpty(textBoxN.Text))
            {
                var t = pow(int.Parse(textBoxC.Text), int.Parse(textBoxD.Text), int.Parse(textBoxN.Text)) % int.Parse(textBoxC.Text);
                textBoxMsgDecript.Text = string.Format("{0}", t);
            }
            else
            {
                MessageBox.Show("Введите c, d, n!");
            }
        }
       
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
