namespace SBAdminMVC.Models
{
    public class ReportModel
    {
        public class Anual
        {
            public decimal ProductiveCost { get; set; }
            public decimal TotalIncome { get; set; }
            public int Year { get; set; }
        }
    }
}