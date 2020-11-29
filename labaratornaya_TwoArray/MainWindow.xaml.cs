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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace labaratornaya_TwoArray
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Для генерации случайных чисел 
                Random r = new Random();

                //Взаимодействие с пользователем
                int n = int.Parse(NRow.Text); //Количество строк
                int m = int.Parse(NCol.Text); //Количество столбцов

                //var для неявной типизации 
                var d = Enumerable.Range(0, n).Select(v => Enumerable.Range(0, m).Select(c => r.Next(-100, 100)).ToArray()).ToArray();
                var w = d.Select(v => v.Min()).ToArray();

                //Вывод результата
                Result.Text += ("Сгенерированная матрица:\n" + String.Join("\n", d.Select(v => String.Join("\t", v)))) + Environment.NewLine;
                Result.Text += ("Минимальные значения из каждой строки: " + String.Join(" ", w)) + Environment.NewLine;
                Result.Text += ("Максимальное значение из минимальных: " + w.Max()) + Environment.NewLine;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                //Для очистки поля вывода результата
                Result.Text = String.Empty;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
