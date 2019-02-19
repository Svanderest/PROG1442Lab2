using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Lab2Library;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab2App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            ClearOutput();
            double sales;
            double quota;
            double salary;
            if (!double.TryParse(txtQuota.Text, out quota))
                lblError.Text += "Please enter a number value for the quota";
            if (!double.TryParse(txtSalary.Text, out salary))
                lblError.Text += "Please enter a number value for the salary";
            if (!double.TryParse(txtSales.Text, out sales))
                lblError.Text += "Please enter a number value for the sales";
            if (lblError.Text.Length == 0)
            {
                try
                {
                    SalesCommission salesCommission = new SalesCommission(sales, quota, salary);
                    lblCommissionOut.Text = salesCommission.Commission.ToString("C2");
                    lblPercentOut.Text = salesCommission.PercentOfQuota.ToString("P2");
                    lblRateOut.Text = salesCommission.CommissionRate.ToString("P2");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    lblError.Text = ex.ParamName + " must be greater than 0";
                }
            }

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ClearOutput();
            txtQuota.Text = "";
            txtSalary.Text = "";
            txtSales.Text = "";
        }

        private void ClearOutput()
        {
            lblError.Text = "";
            lblPercentOut.Text = "";
            lblRateOut.Text = "";
            lblCommissionOut.Text = "";
        }
    }
}
