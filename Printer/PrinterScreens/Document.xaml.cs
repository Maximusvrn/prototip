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
	/// Interaction logic for Document.xaml
	/// </summary>
	public partial class Document : UserControl
	{
		public Document()
		{
			this.InitializeComponent();
		}

        private void d1_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Документ <Расписание.txt>  отправлен на печать";

        }

        private void d2_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Документ <отчет.docx>  отправлен на печать";
        }

        private void d3_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Документ <123.txt>  отправлен на печать";
        }

        private void d4_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Документ <инструкция.txt>  отправлен на печать";
        }

        private void d5_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Документ <стихи.txt>  отправлен на печать";
        }

        private void d6_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            text.Text = "Документ <шаблон.docx>  отправлен на печать";
        }
	}
}