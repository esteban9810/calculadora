using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadora
{
    public partial class MainPage : ContentPage
    {
        double res;
        public MainPage()
        {
            InitializeComponent();
            option.Items.Add("Sumar");
            option.Items.Add("Restar");
            option.Items.Add("Multiplicar");
            option.Items.Add("Dividir");
        }

        private void option_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(num1.Text) && !string.IsNullOrEmpty(num1.Text))
            {
                String op = option.SelectedItem.ToString();
                int n1 = Int32.Parse(num1.Text);
                int n2 = Int32.Parse(num2.Text);

                if (op == "Sumar")
                {
                    res = n1 + n2;
                }
                else if (op == "Restar")
                {
                    res = n1 - n2;
                }
                else if (op == "Multiplicar")
                {
                    res = n1 * n2;
                }
                else if (op == "Dividir")
                {
                    res = n1 / n2;
                }
                else
                {
                    Console.WriteLine("no se pueden hacer calculos multiples");
                }

            }
            else
            {
                DisplayAlert("Datos erroneos", "Por favor llene los cuadros de texto correctamente", "Ok");
            }
            ans.Text = res + "";
        }
    }
}
