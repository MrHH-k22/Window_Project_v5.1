using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.Charts.WinForms;
namespace Window_Project_v5._1
{
     class Chart
    {
        private ImageDAO imageDAO = new ImageDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private ProductDAO productDAO = new ProductDAO();
        private Product product;
        public static void Bar(GunaChart chart, int SellerID, string YearToFilter)
        {
            Chart obj = new Chart();
            //Chart configuration 
            chart.YAxes.GridLines.Display = false;
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //Create a new dataset 
            var dataset = new GunaBarDataset();
            for(int i = 0; i < months.Length; i++)
            {
                double data = (double)obj.FillData(i + 1, SellerID, YearToFilter);
                dataset.DataPoints.Add(months[i], data) ;
            }
            chart.Datasets.Add(dataset);
            chart.Update();
        }
        public decimal FillData(int month, int sellerID, string YearToFilter)
        {
            DataTable dt = new DataTable();
            dt = productDAO.ProfitEveryMonths(sellerID, YearToFilter);
            foreach(DataRow row in dt.Rows)
            {
                int rowMonth = row.Field<int>("MonthNumber");
                decimal earnings = row.Field<decimal>("TotalEarnings");

                if (rowMonth == month)
                {
                    return earnings;
                }
            }
            return 0;
        }
    }
}
