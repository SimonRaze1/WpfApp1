using System;
using System.Windows;
using System.Windows.Controls;

namespace FinanceSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            contentControl.Content = new Home();
        }

        private void BtnAddIncome_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new AddIncome();
        }

        private void BtnAddExpense_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new AddExpense();
        }

        private void BtnViewReport_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new Report();
        }
    }
    public partial class AddIncome : UserControl
    {
        public AddIncome()
        {
            InitializeComponent();
        }

        private void BtnAddIncome_Click(object sender, RoutedEvender, RoutedEventArgs e)
        {
            // Логика добавления дохода
            MessageBox.Show("Доход добавлен успешно!");
        }
    }
}