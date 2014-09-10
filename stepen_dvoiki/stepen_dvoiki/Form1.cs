using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stepen_dvoiki
{
    public partial class Form1 : Form
    {
        string multy_array;
        int stepenn;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            multy_array = "2";
            stepenn = Convert.ToInt32(textBox1.Text);
            int i = 2;
            for (i = 2; i <= stepenn; i++)       //здесь все еще нормально
            {
                Mult();
            }
            label2.Text = multy_array;
        }

        private void Mult()
        {
            string multy_array_2 = "";
            int n = multy_array.Length;                
            int temp = 0;
            string Help_string = "";

            char s;
            for (int j = n; j >= 1; j--)
            {
                    Help_string = "";
                    Help_string += multy_array[j - 1];
                    int cifra = Convert.ToInt32(Help_string);
                    cifra = cifra * 2 + temp;
                    temp = 0;
                    if (cifra > 9)
                    {
                        cifra = cifra % 10;
                        temp = 1;
                    }
                    multy_array_2 += Convert.ToString(cifra);
            }
            if (temp == 1)
            {
                    multy_array_2 += Convert.ToString(temp);
                    n++;
            }
            if (n > 255)
                label3.Text = "Overflow";//контроль переполнения
            multy_array = "";
            for (int j = n; j >= 1; j--)
            {
                    multy_array += multy_array_2[j - 1];
            }
        }
    }
}
