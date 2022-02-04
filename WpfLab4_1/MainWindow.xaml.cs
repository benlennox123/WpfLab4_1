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

namespace WpfLab4_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = 0;
            if (rateD.Text != "")
            {
                rateDollar = Convert.ToDouble(rateD.Text);
            }
            double sumDollar = 0;
            if (sumD.Text != "")
            {
                sumDollar = Convert.ToDouble(sumD.Text);
            }
            double resDollar = rateDollar * sumDollar;
            resSumD.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = 0;
            if (rateE.Text != "")
            {
                rateEuro = Convert.ToDouble(rateE.Text);
            }
            double sumEuro = 0;
            if (sumE.Text != "")
            {
                sumEuro = Convert.ToDouble(sumE.Text);
            }
            double resEuro = rateEuro * sumEuro;
            resSumE.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateYuan = 0;
            if (rateY.Text != "")
            {
                rateYuan = Convert.ToDouble(rateY.Text);
            }
            double sumYuan = 0;
            if (sumY.Text != "")
            {
                sumYuan = Convert.ToDouble(sumY.Text);
            }
            double resYuan = rateYuan * sumYuan;
            resSumY.Text = resYuan.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateTenge = 0;
            if (rateT.Text != "")
            {
                rateTenge = Convert.ToDouble(rateT.Text);
            }
            double sumTenge = 0;
            if (sumT.Text != "")
            {
                sumTenge = Convert.ToDouble(sumT.Text);
            }

            double resTenge = rateTenge * sumTenge;
            resSumT.Text = resTenge.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double inch = 0;
            if (Inch.Text != "")
            {
                inch = Convert.ToDouble(Inch.Text);
            }
            double m_inch = inch * 0.0254;
            mInch.Text = m_inch.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double ft = 0;
            if (Ft.Text != "")
            {
                ft = Convert.ToDouble(Ft.Text);
            }
            double m_ft = ft * 0.3048;
            mFt.Text = m_ft.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double mile = 0;
            if (Mile.Text != "")
            {
                mile = Convert.ToDouble(Mile.Text);
            }
            double m_mile = mile * 1609;
            mMile.Text = m_mile.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double versta = 0;
            if (Versta.Text != "")
            {
                versta = Convert.ToDouble(Versta.Text);
            }
            double m_versta = versta * 1060;
            mVersta.Text = m_versta.ToString();
        }
    }
}
