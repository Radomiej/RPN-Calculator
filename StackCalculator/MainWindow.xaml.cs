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
using StackCalculator.Logic;

namespace StackCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Stack<StackValue> stack = new Stack<StackValue>(4);
        private OperationCalculator currentOperationCalculator;

        public MainWindow()
        {
            InitializeComponent();

            stack.Push(new StackValue(0));
            stack.Push(new StackValue(0));
            stack.Push(new StackValue(0));
            stack.Push(new StackValue(0));
            currentOperationCalculator = new NumberOperationCalculator(stack);

            UpdateView();
        }

        private void ButtonClickAddNumber(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            StackValue l1 = stack.Peek();
            l1.Value += b.Content.ToString();
            UpdateView();
        }

        private void ButtonClickEnter(object sender, RoutedEventArgs e)
        {
            stack.Push(new StackValue(0));
            UpdateView();
        }
       
        private void ButtonClickDoOperation(object sender, RoutedEventArgs e)
        {
            stack.Pop();
            stack.Push(new StackValue(tb_L1.Text));

            Button b = (Button)sender;
            string operation = b.Content.ToString();
            if (operation.Equals("+")) currentOperationCalculator.Add();

            UpdateView();
        }

        private void UpdateView()
        {
            StackValue[] rawStack = stack.ToArray();
            if(rawStack.Length > 0) tb_L1.Text = rawStack[0].ToString();
            if (rawStack.Length > 1) tb_L2.Text = rawStack[1].ToString();
            if (rawStack.Length > 2) tb_L3.Text = rawStack[2].ToString();
            if (rawStack.Length > 3) tb_L4.Text = rawStack[3].ToString();
        }

    }
}
