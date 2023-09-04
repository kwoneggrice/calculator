using System;
using System.Collections;
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

namespace WpfCalculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		double[] inputNumber = new double[2];
		double result;
		bool isClear = true;
		char op;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Number_Btn_Click(object sender, RoutedEventArgs e)
		{
			Button btn = sender as Button;
			string number = btn.Content.ToString();

			if (isClear == true)
			{
				Input.Text = number;
				isClear = false;
			}
			else
			{
				Input.Text += number;
			}
		}

		private void C_Btn_Click(object sender, RoutedEventArgs e)
		{
			Display.Text = null;
			Input.Text = "0";
			isClear = true;
		}

		private void Delete_Btn_Click(object sender, RoutedEventArgs e)
		{
		}

		private void Divide_Btn_Click(object sender, RoutedEventArgs e)
		{
			inputNumber[0] = double.Parse(Input.Text);
			Display.Text = (Input.Text + "÷");
			op = '/';
			Input.Text = "";
		}

		private void Multiply_Btn_Click(object sender, RoutedEventArgs e)
		{
			inputNumber[0] = double.Parse(Input.Text);
			Display.Text = (Input.Text + "×");
			op = '*';
			Input.Text = "";
		}

		private void Subtract_Btn_Click(object sender, RoutedEventArgs e)
		{
			inputNumber[0] = double.Parse(Input.Text);
			Display.Text = (Input.Text + "−");
			op = '-';
			Input.Text = "";
		}

		private void Plus_Btn_Click(object sender, RoutedEventArgs e)
		{
			inputNumber[0] = double.Parse(Input.Text);
			Display.Text = (Input.Text + "+");
			op = '+';
			Input.Text = "";
		}

		private void Dot_Btn_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Result_Btn_Click(object sender, RoutedEventArgs e)
		{
			if (op == '+')
			{
				inputNumber[1] = double.Parse(Input.Text);
				result = inputNumber[0] + inputNumber[1];
				Display.Text += (Input.Text + "=");
				Input.Text = result.ToString();
			}
			else if (op == '-')
			{
				inputNumber[1] = double.Parse(Input.Text);
				result = inputNumber[0] - inputNumber[1];
				Display.Text += (Input.Text + "=");
				Input.Text = result.ToString();
			}
			else if (op == '*')
			{
				inputNumber[1] = double.Parse(Input.Text);
				result = inputNumber[0] * inputNumber[1];
				Display.Text += (Input.Text + "=");
				Input.Text = result.ToString();
			}
			else
			{
				inputNumber[1] = double.Parse(Input.Text);
				result = inputNumber[0] / inputNumber[1];
				Display.Text += (Input.Text + "=");
				Input.Text = result.ToString();
			}
		}


	}
}
