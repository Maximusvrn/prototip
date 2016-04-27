using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrinterScreens
{
	/// <summary>
	/// Interaction logic for photo.xaml
	/// </summary>
	public partial class photo : UserControl
	{
		public photo()
		{
			this.InitializeComponent();
		}

        private void p1_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Изображение <Фото1> отправлено на печать";
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Изображение <Фото2> отправлено на печать";
        }

        private void p3_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Изображение <Фото3> отправлено на печать";
        }

        private void p4_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Изображение <Фото4> отправлено на печать";
        }

        private void p5_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Изображение <Фото5> отправлено на печать";
        }

        private void p6_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Изображение <Фото6> отправлено на печать";
        }

        private void p7_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Изображение <Фото7> отправлено на печать";
        }

        private void p8_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Изображение <Фото8> отправлено на печать";
        }
	}
}