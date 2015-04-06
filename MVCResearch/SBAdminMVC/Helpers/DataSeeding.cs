using System.Collections.Generic;
using SBAdminMVC.Models;

namespace SBAdminMVC.Helpers
{
    public class DataSeeding
    {
        public static List<ContactModel> ContactModels = new List<ContactModel>
        {
            new ContactModel {ID = 1, ContactName = "Alexander Povar", ContactTitle = "Alex P.", CompanyName = "Big FUSS", Country = "England"},
            new ContactModel {ID = 2, ContactName = "Bob Riverto", ContactTitle = "Bob R.", CompanyName = "Big FUSS", Country = "England"},
            new ContactModel {ID = 3, ContactName = "Coovas Enfuvus", ContactTitle = "Coovas E.", CompanyName = "Big FUSS", Country = "England"},
            new ContactModel {ID = 4, ContactName = "Douglas Strider", ContactTitle = "Douglas S.", CompanyName = "Big FUSS", Country = "England"},
            new ContactModel {ID = 5, ContactName = "Eggy Leaflet", ContactTitle = "Eggy L.", CompanyName = "Big FUSS", Country = "England"},
            new ContactModel {ID = 6, ContactName = "Fred Anderson", ContactTitle = "Fred A.", CompanyName = "Fly Kite", Country = "America"},
            new ContactModel {ID = 7, ContactName = "George Hendrickson", ContactTitle = "George H.", CompanyName = "Fly Kite", Country = "America"},
            new ContactModel {ID = 8, ContactName = "Hay Fellowa", ContactTitle = "Hay F.", CompanyName = "Fly Kite", Country = "America"},
            new ContactModel {ID = 9, ContactName = "Itto Satoiku", ContactTitle = "Itto S.", CompanyName = "Zen Partner", Country = "Japan"},
            new ContactModel {ID = 10, ContactName = "Jig Empovis", ContactTitle = "Jig E.", CompanyName = "Fly Kite", Country = "America"},
            new ContactModel {ID = 11, ContactName = "Ken Homet", ContactTitle = "Ken H.", CompanyName = "KingKong Bike", Country = "Australia"},
            new ContactModel {ID = 12, ContactName = "Lewis Stonesh", ContactTitle = "Lewis S.", CompanyName = "KingKong Bike", Country = "Australia"},
            new ContactModel {ID = 13, ContactName = "Maximus Harsh", ContactTitle = "Maximus H.", CompanyName = "KingKong Bike", Country = "Australia"},
            new ContactModel {ID = 14, ContactName = "Nina Omlette", ContactTitle = "Nina O.", CompanyName = "KingKong Bike", Country = "Australia"},
        };

        public static List<ProductModel> ProductModels = new List<ProductModel>
        {
            new ProductModel {ID = 1, ProductName = "Penball A", CategoryName = "Accessories", Price = 15},
            new ProductModel {ID = 2, ProductName = "Penball B", CategoryName = "Accessories", Price = 10},
            new ProductModel {ID = 3, ProductName = "Penball C", CategoryName = "Accessories", Price = 5},
            new ProductModel {ID = 4, ProductName = "Pen A", CategoryName = "Accessories", Price = 20},
            new ProductModel {ID = 5, ProductName = "Pen B", CategoryName = "Accessories", Price = 15},
            new ProductModel {ID = 6, ProductName = "Pen C", CategoryName = "Accessories", Price = 10},
            new ProductModel {ID = 7, ProductName = "Ruler 20cm", CategoryName = "Accessories", Price = 5},
            new ProductModel {ID = 8, ProductName = "Chalk", CategoryName = "Accessories", Price = 10},
            new ProductModel {ID = 9, ProductName = "Compass", CategoryName = "Accessories", Price = 20},
            new ProductModel {ID = 10, ProductName = "Armchair", CategoryName = "Furniture", Price = 100},
            new ProductModel {ID = 11, ProductName = "Desk", CategoryName = "Furniture", Price = 200},
        };

        public static List<ReportModel.Anual> AnualReportModels = new List<ReportModel.Anual>
        {
            new ReportModel.Anual {Year = 2013, ProductiveCost = 120000, TotalIncome = 190000},
            
            new ReportModel.Anual {Year = 2014, ProductiveCost = 100000, TotalIncome = 130000},

            new ReportModel.Anual {Year = 2015, ProductiveCost = 50000, TotalIncome = 50000},
        };
    }
}