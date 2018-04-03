using System;
//using System.Collections.Generic;
using Xamarin.Forms;

namespace Testaufgabe
{
    public partial class FibonacciPage : ContentPage
    {

        private int[] fibonacciArr;
        public FibonacciPage()
        {
            this.fibonacciArr = new int[] {1,1,2,3,5,8,13,21,34,55,89,100};
            InitializeComponent();

            setValueLabel();
            setFibonacciLabel();
        }

        void OnValueChanged(object sender, ValueChangedEventArgs e)
        {
            setValueLabel();
            setFibonacciLabel();
        }

        private void setFibonacciLabel()
        {
            int index = (int)fibonacciSlider.Value - 1;

            //int index = (int) e.NewValue - 1;

            fibonacciLabel.Text = "Fib = " + this.fibonacciArr[index].ToString();
        }

        private void setValueLabel()
        {
            valueLabel.Text = "N = " + (int)fibonacciSlider.Value;
        }
    }
}
