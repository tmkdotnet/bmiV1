using System;
using System.Windows;
using bmi1.Model;

namespace bmi1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ClickBmi(object sender, RoutedEventArgs e)
        {
            double weightFromUI;
            double heigthFromUI;

            bool weightIsValid = double.TryParse(txt1H.Text, out weightFromUI);
            bool heigthIsValid = double.TryParse(txt2W.Text, out heigthFromUI);

            if (weightIsValid && heigthIsValid)
            {
                try
                {
                 
                    Bmi bmi = new Bmi( weightFromUI, heigthFromUI );

                    double yourBmi =  bmi.CalculateBmi();
                    txtB1.Text = yourBmi.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd: {ex.Message}");
                }
            }
            else 
            {
                MessageBox.Show("Wprowadź prawidłowe wartości liczby.");
            }
        }
    }
}
