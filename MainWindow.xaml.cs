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

namespace WpfApp_Laskin_V3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double temp = 0;

        string operation = "";

        string output = "";
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

            DivideBtn.Content = "\u00F7";
        }

        private void NumBtn_Click(object sender, RoutedEventArgs e) 
        {
            string name = ((Button)sender).Name;

            switch(name)
            {
                case "ZeroBtn":
                    output += "0";
                    Console.Text = output;   //Console on "näytön" nimi
                    break;

                case "OneBtn":                  // Kun painetaan numero 1stä, niin Console.Text näyttää outputille annetun arvon joka on siis str1
                    output += "1";              //
                    Console.Text = output;      //    
                    break;                      //toiminto lopetetaan, ja jää odottamaan uutta syötettä
                
                case "TwoBtn":
                    output += "2";
                    Console.Text = output;   
                    break;
                    
                case "ThreeBtn":
                    output += "3";
                    Console.Text = output;   
                    break;

                case "FourBtn":
                    output += "4";
                    Console.Text = output;   
                    break;
                
                case "FiveBtn":
                    output += "5";
                    Console.Text = output;
                    break;
                    
                case "SixBtn":
                    output += "6";
                    Console.Text = output;   
                    break;

                case "SevenBtn":
                    output += "7";
                    Console.Text = output;   
                    break;

                case "EightBtn":
                    output += "8";
                    Console.Text = output;   
                    break;

                case "NineBtn":
                    output += "9";
                    Console.Text = output;   
                    break;
            }
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            double outputTemp;

            switch (operation)
            {
                
                case "Minus":
                    outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString();
                    Console.Text = output;
                    break;
                
                case "Plus":
                    outputTemp = temp + double.Parse(output);
                    output = outputTemp.ToString();
                    Console.Text = output;
                    break;
                
                case "Multiply":
                    outputTemp = temp * double.Parse(output);
                    output = outputTemp.ToString();
                    Console.Text = output;
                    break;
                
                case "Divide":
                    if (double.Parse(output) != 0)
                    {
                        outputTemp = temp / double.Parse(output);
                        output = outputTemp.ToString();
                        Console.Text = output;
                        
                    }
                    break;
            }

        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Minus";
            }
        }

        private void MultiBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Multiply";

            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Plus";

            }
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Divide";

            }

        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            output = "";
            Console.Text = output;
        }
    }
}
