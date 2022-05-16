using System;
using System.IO;
using System.Windows;
using System.Linq;
using System.Threading;
using System.Windows.Media;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;
using SciChart.Charting.Model.DataSeries;
using SciChart.Examples.ExternalDependencies.Data;
using SciChart.Charting3D.Model;

namespace KernelTrick
{
    /// <summary>
    /// Interaction logic for ScatterChartExampleView.xaml
    /// </summary>
    public partial class UC_Cluster : UserControl
    {
        #region Parameter

        public static XyDataSeries<double, double> dataSeries = new XyDataSeries<double, double>();
        public static XyDataSeries<double, double> dataSeries_a = new XyDataSeries<double, double>();


        double[] Xvector = new double[200];
        double[] Yvector = new double[200];


        #endregion
        #region UserControl
        public UC_Cluster()
        {
            InitializeComponent();
            txtbox_Guassian1_X_StdDev.Text = "5";
            txtbox_Guassian1_Y_StdDev.Text = "5";
            txtbox_Guassian1_X_Mean.Text = "100";
            txtbox_Guassian1_Y_Mean.Text = "100";

            txtbox_Guassian2_X_StdDev.Text = "5";
            txtbox_Guassian2_Y_StdDev.Text = "5";
            txtbox_Guassian2_X_Mean.Text = "50";
            txtbox_Guassian2_Y_Mean.Text = "50";



            txtbox_class2_Radius.Text = "40";
            txtbox_class2_Step.Text = "5";
            txtbox_class2_CenterX.Text = "100";
            txtbox_class2_CenterY.Text = "100";

        }
        private void UC_Cluster_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {

            dataSeries.AcceptsUnsortedData = true;

            var dataSeries2 = new XyDataSeries<double, double>();


            dataSeries2.AcceptsUnsortedData = true;
            PointerColor2.Fill = Colors.Blue;
            scatterRenderSeries2.DataSeries = dataSeries2;

            var dataSeries1 = new XyDataSeries<double, double>();
            dataSeries1.AcceptsUnsortedData = true;

            scatterRenderSeries.DataSeries = dataSeries1;
            

            Btn_Guassian1_Click(null, null);
            Btn_class2_Round_Click(null, null);
            Btn_KernelTrick_Click(null, null);
            sciChart.ZoomExtents();

        }
        #endregion
        #region Data
        private void Btn_Guassian1_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox_Guassian1_X_Mean.Text != "" && txtbox_Guassian1_Y_Mean.Text != "" && txtbox_Guassian1_X_StdDev.Text != "" && txtbox_Guassian1_Y_StdDev.Text != "" && txtbox_Guassian1_Count.Text != "")
            {
                dataSeries.Clear();
                #region DataSeries One
                var dataSeries1 = new XyDataSeries<double, double>
                {
                    AcceptsUnsortedData = true
                };
                PointerColor.Fill = Colors.Red;
                for (int i = 0; i < Convert.ToInt32(txtbox_Guassian1_Count.Text); i++)
                {

                    var datax = DataManager.Instance.GetGaussianRandomNumber(Convert.ToInt32(txtbox_Guassian1_X_Mean.Text), Convert.ToInt32(txtbox_Guassian1_X_StdDev.Text));
                    var datay = DataManager.Instance.GetGaussianRandomNumber(Convert.ToInt32(txtbox_Guassian1_Y_Mean.Text), Convert.ToInt32(txtbox_Guassian1_Y_StdDev.Text));
                    dataSeries1.Append(datax, datay);
                    dataSeries.Append(datax, datay);
                    Xvector[i + 100] = datax;
                    Yvector[i + 100] = datay;

                }

                //MessageBox.Show(dataSeries1.XValues[0].ToString()+ "\n" + Xvector[100].ToString());


                // Append data to series. SciChart automatically redraws
                scatterRenderSeries.DataSeries.Clear();
                scatterRenderSeries.DataSeries = dataSeries1;

                #endregion
                Snackbar_Guassian1.MessageQueue?.Enqueue($"Your Data Appiled!!!", null, null, null, false, true, TimeSpan.FromSeconds(2));
            }
            else
            {
                Snackbar_Guassian1.MessageQueue?.Enqueue($"Fill Correctly...", null, null, null, false, true, TimeSpan.FromSeconds(2));
            }
        }
        private void Btn_Guassian2_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox_Guassian2_X_Mean.Text != "" && txtbox_Guassian2_Y_Mean.Text != "" && txtbox_Guassian2_X_StdDev.Text != "" && txtbox_Guassian2_Y_StdDev.Text != "" && txtbox_Guassian2_Count.Text != "")
            {
                #region DataSeries One
                var dataSeries2 = new XyDataSeries<double, double>
                {
                    AcceptsUnsortedData = true
                };
                PointerColor2.Fill = Colors.Blue;
                for (int i = 0; i < Convert.ToInt32(txtbox_Guassian2_Count.Text); i++)
                {
                    var datax = DataManager.Instance.GetGaussianRandomNumber(Convert.ToInt32(txtbox_Guassian2_X_Mean.Text), Convert.ToInt32(txtbox_Guassian2_X_StdDev.Text));
                    var datay = DataManager.Instance.GetGaussianRandomNumber(Convert.ToInt32(txtbox_Guassian2_Y_Mean.Text), Convert.ToInt32(txtbox_Guassian2_Y_StdDev.Text));
                    dataSeries2.Append(datax, datay);
                    dataSeries.Append(datax, datay);

                    Xvector[i] = datax;
                    Yvector[i] = datay;

                }

                //MessageBox.Show(dataSeries1.XValues[0].ToString()+ "\n" + Xvector[100].ToString());


                // Append data to series. SciChart automatically redraws
                scatterRenderSeries2.DataSeries.Clear();
                scatterRenderSeries2.DataSeries = dataSeries2;
                #endregion
                Snackbar_Guassian2.MessageQueue?.Enqueue($"Your Data Appiled!!!", null, null, null, false, true, TimeSpan.FromSeconds(2));

            }
            else
            {
                Snackbar_Guassian2.MessageQueue?.Enqueue($"Fill Correctly...", null, null, null, false, true, TimeSpan.FromSeconds(2));
            }
        }
        private void Btn_class1_Round_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox_class1_Radius.Text != "" &&
                txtbox_class1_Step.Text != "" &&
                txtbox_class1_CenterX.Text != "" &&
                txtbox_class1_CenterY.Text != ""
                )
            {

                scatterRenderSeries.DataSeries.Clear();

                var dataSeries1 = new XyDataSeries<double, double>
                {
                    AcceptsUnsortedData = true
                };

                double radius = Convert.ToDouble(txtbox_class1_Radius.Text);
                double step = Convert.ToDouble(txtbox_class1_Step.Text);
                double CenterX = Convert.ToDouble(txtbox_class1_CenterX.Text);
                double CenterY = Convert.ToDouble(txtbox_class1_CenterY.Text);
                for (int i = 0; i < 100; i++)
                {
                    //شعاع
                    Random random = new Random();
                    double X1 = ((radius /*- random.Next(-10, 10)*/) * Math.Cos(i * step * Math.PI / 180)) + CenterX;
                    double Y1 = ((radius /*- random.Next(-10, 10)*/) * Math.Sin(i * step * Math.PI / 180)) + CenterY;
                    Xvector[i] = X1;
                    Yvector[i] = Y1;

                    dataSeries1.Append(X1, Y1);
                }
                scatterRenderSeries.DataSeries = dataSeries1;
            }
            else
            {
                //Fill Parameter
            }
        }
        private void Btn_class2_Round_Click(object sender, RoutedEventArgs e)
        {
            if (txtbox_class2_Radius.Text != "" &&
                txtbox_class2_Step.Text != "" &&
                txtbox_class2_CenterX.Text != "" &&
                txtbox_class2_CenterY.Text != ""
                )
            {

                scatterRenderSeries2.DataSeries.Clear();

                var dataSeries1 = new XyDataSeries<double, double>
                {
                    AcceptsUnsortedData = true
                };

                double radius = Convert.ToDouble(txtbox_class2_Radius.Text);
                double step = Convert.ToDouble(txtbox_class2_Step.Text);
                double CenterX = Convert.ToDouble(txtbox_class2_CenterX.Text);
                double CenterY = Convert.ToDouble(txtbox_class2_CenterY.Text);
                for (int i = 100; i < 200; i++)
                {
                    //شعاع
                    Random random = new Random();
                    double X1 = ((radius /*- random.Next(-10, 10)*/) * Math.Cos(i * step * Math.PI / 180)) + CenterX;
                    double Y1 = ((radius /*- random.Next(-10, 10)*/) * Math.Sin(i * step * Math.PI / 180)) + CenterY;
                    Xvector[i] = X1;
                    Yvector[i] = Y1;

                    dataSeries1.Append(X1, Y1);
                }
                scatterRenderSeries2.DataSeries = dataSeries1;
            }
            else
            {
                //Fill Parameter
            }
        }
        #endregion

        private void Btn_KernelTrick_Click(object sender, RoutedEventArgs e)
        {

            var xyzDataSeries3D = new XyzDataSeries3D<double>();
            PointerFirstPart.Fill = Colors.Red;

            for (var i = 0; i < 100; i++)
            {
                var x = Xvector[i];
                var y = Yvector[i];
                var z = Math.Pow(Math.E, -((x * x) + (y * y)));
                xyzDataSeries3D.Append(x, y, z);
            }
            ScatterSeries3D_FirstPart.DataSeries = xyzDataSeries3D;

            PointerSecondPart.Fill = Colors.Blue;

            for (var i = 100; i < 200; i++)
            {
                var x = Xvector[i];
                var y = Yvector[i];
                var z = Math.Pow(Math.E, -((x * x) + (y * y)));

                xyzDataSeries3D.Append(x, y, z);
            }

            ScatterSeries3D_SecondPart.DataSeries = xyzDataSeries3D;

        }

    }
}