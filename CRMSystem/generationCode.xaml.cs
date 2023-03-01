using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CRMSystem
{
    /// <summary>
    /// Логика взаимодействия для generationCode.xaml
    /// </summary>
    public partial class generationCode : Window
    {
        public generationCode()
        {
            InitializeComponent();
            Random random = new Random();
            int kolText = random.Next(8, 8); // Количество символов в строке

            string text = "";
            for (int i = 0; i < kolText; i++)
            {
                int j = random.Next(3); // Выбор 0 - число; 1 - буква
                if (j == 0)
                {
                        text = text + random.Next(9).ToString();
                }
                else if (j == 1)
                {
                    int l = random.Next(2); // Выбор 0 - заглавная; 1 - маленькая буква; 3 - спецсимвол
                    if (l == 0)
                    {
                        text = text + (char)random.Next('A', 'Z' + 1);
                    }
                    else
                    {
                        text = text + (char)random.Next('a', 'z' + 1);
                    }
                }
                else if (j == 2)
                {
                    string specialSymbol = "/~!@№;%:?*()";


                    text += random.Next(0, specialSymbol.Length);

                }
              

            }
            tbCode.Text = text;



        }
    }
}
