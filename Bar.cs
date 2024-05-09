using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.Charts.WinForms;

namespace Window_Project_v5._1
{
    internal class Bar
    {
        public static void Example(GunaChart chart)
        {
            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

            //Create a new dataset 
            var barDataset = new GunaBarDataset();
            var r = new Random();
            barDataset.DataPoints.Add("January", r.Next(-50, 100));
            barDataset.DataPoints.Add("February", r.Next(-50, 100));
            barDataset.DataPoints.Add("March", r.Next(-50, 100));
            barDataset.DataPoints.Add("April", r.Next(-50, 100));
            barDataset.DataPoints.Add("May", r.Next(-50, 100));
            barDataset.DataPoints.Add("June", r.Next(-50, 100));
            barDataset.DataPoints.Add("July", r.Next(-50, 100));
            barDataset.DataPoints.Add("August", r.Next(-50, 100));
            barDataset.DataPoints.Add("September", r.Next(-50, 100));
            barDataset.DataPoints.Add("OCtober", r.Next(-50, 100));
            barDataset.DataPoints.Add("November", r.Next(-50, 100));
            barDataset.DataPoints.Add("December", r.Next(-50, 100));
            //Add a new barDataset to a chart.barDatasets
            chart.Datasets.Add(barDataset);

            //An update was made to re-render the chart
            chart.Update();
        }
    }
}
