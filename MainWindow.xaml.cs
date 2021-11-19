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


namespace Polygon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            
      
        }
        PointCollection myPointCollection = new PointCollection();
        PointCollection myPointCollection2 = new PointCollection();
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Poly1_LostFocus(object sender, RoutedEventArgs e)
        {
            
        }
      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double Degree = Convert.ToDouble(Poly1.Text);
            double edge = 0.0;
           


            if (0 < Degree && Degree < 90.0)
            {
                PolyF.Points.Clear();
                edge = Math.Abs(50.0 / Math.Tan(Degree * (Math.PI / 180.0)));
                System.Windows.Point Point1 = new System.Windows.Point(0, 0);
                System.Windows.Point Point2 = new System.Windows.Point(0, 50);
                System.Windows.Point Point3 = new System.Windows.Point(edge, 0);

                myPointCollection.Add(Point1);
                myPointCollection.Add(Point2);
                myPointCollection.Add(Point3);
                PolyF.Points = myPointCollection;



            }
            else if (Degree < 0.0)
            {
                PolyF.Points.Clear();
                edge = Math.Abs( 50.0 / (Math.Tan((180-Degree) * (Math.PI / 180.0))));
                System.Windows.Point Point1 = new System.Windows.Point(0, 0);
                System.Windows.Point Point2 = new System.Windows.Point(0, 50);
                System.Windows.Point Point3 = new System.Windows.Point(edge, 50);


                myPointCollection.Add(Point1);
                myPointCollection.Add(Point2);
                myPointCollection.Add(Point3);
                PolyF.Points = myPointCollection;


            }
            else
            {
                PolyF.Points.Clear();
                System.Windows.Point Point1 = new System.Windows.Point(0, 0);
                System.Windows.Point Point2 = new System.Windows.Point(0, 50);
                System.Windows.Point Point3 = new System.Windows.Point(0, 0);

                myPointCollection.Add(Point1);
                myPointCollection.Add(Point2);
                myPointCollection.Add(Point3);
                PolyF.Points = myPointCollection;

            }

          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double Degree2 = Convert.ToDouble(Poly2.Text);
            double edge2 = 0.0;

            if (0 < Degree2 && Degree2 < 90.0)
            {
                PolyM.Points.Clear();
                edge2 = Math.Abs(50.0 / Math.Tan(Degree2 * (Math.PI / 180.0)));
                System.Windows.Point Point4 = new System.Windows.Point(200, 0);
                System.Windows.Point Point5 = new System.Windows.Point(200, 50);
                System.Windows.Point Point6 = new System.Windows.Point(200-edge2, 0);

                myPointCollection2.Add(Point4);
                myPointCollection2.Add(Point5);
                myPointCollection2.Add(Point6);
                PolyM.Points = myPointCollection2;



            }
            else if (Degree2 < 0.0)
            {
                PolyM.Points.Clear();
                edge2 = Math.Abs(50.0 / (Math.Tan((180 - Degree2) * (Math.PI / 180.0))));
                System.Windows.Point Point4 = new System.Windows.Point(200, 0);
                System.Windows.Point Point5 = new System.Windows.Point(200, 50);
                System.Windows.Point Point6 = new System.Windows.Point(200-edge2, 50);


                myPointCollection2.Add(Point4);
                myPointCollection2.Add(Point5);
                myPointCollection2.Add(Point6);
                PolyM.Points = myPointCollection2;


            }
            else
            {
                PolyM.Points.Clear();
                System.Windows.Point Point4 = new System.Windows.Point(200, 0);
                System.Windows.Point Point5 = new System.Windows.Point(200, 50);
                System.Windows.Point Point6 = new System.Windows.Point(200, 0);

                myPointCollection2.Add(Point4);
                myPointCollection2.Add(Point5);
                myPointCollection2.Add(Point6);
                PolyM.Points = myPointCollection2;

            }

        }
    }
}
