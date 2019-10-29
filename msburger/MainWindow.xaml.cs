using msburger.controller;
using msburger.model;
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

namespace msburger
{
    public partial class MainWindow : Window
    {
        Bill bill;
        public MainWindow()
        {
            InitializeComponent();
            bill = new Bill();
            listBoxCart.ItemsSource = bill.getBurgers();
        }

      

        private void onButtonCheesyClicked(object sender, RoutedEventArgs e)
        {
            Burger burgerCheesy = new Burger("Cheesy",25000);
            bill.add(burgerCheesy);
            listBoxCart.Items.Refresh();
        }

        private void onButtonWowClicked(object sender, RoutedEventArgs e)
        {

        }

        private void onButtonOrioClicked(object sender, RoutedEventArgs e)
        {

        }

        private void onButtonEcoClicked(object sender, RoutedEventArgs e)
        {

        }

        private void isCouponSelected(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)((ComboBox)sender).SelectedItem;
            if (item.Tag.Equals("nkrisatu"))
            {
                labelNoteCoupon.Content= "Anda mendapatkan cashback Rp3.000";
            }else if (item.Tag.Equals("merdeka"))
            {
                labelNoteCoupon.Content = "Anda mendapatkan diskon 17%";
            }
            else if (item.Tag.Equals("sumpahpemuda"))
            {
                labelNoteCoupon.Content = "Anda mendapatkan diskon 80% atau maks Rp3.000";
            }
            else
            {
                labelNoteCoupon.Content = "ops, coupon tidak dipilih";
            }
        }
    }
}
