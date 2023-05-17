using DAL.Entities;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections;

namespace DAL
{
    public class DataAccess
    {
        public static IBaseRepo<Grade, int, int, Grade> GradeContent()
        {
            return new GradeRepo();
        }
        public static IAuth<bool,string,string> AuthContent()
        {
            return new UserRepo();
        }
        public static IBaseRepo<Token, Token, string, Token> TokenContent()
        {
            return new TokenRepo();
        }
        public static IBaseRepo<User, int, string, User> UserContent()
        {
            return new UserRepo();
        }
        public static IBaseRepo<Unit, int, int, Unit> UnitContent()
        {
            return new UnitRepo();
        }
        public static IBaseRepo<Department, int, int, Department> DepartmentContent()
        {
            return new DepartmentRepo();
        }
        public static IBaseRepo<Color, int, int, Color> ColorContent()
        {
            return new ColorRepo();
        }
        public static IBaseRepo<Customer, int, int, Customer> CustomerContent()
        {
            return new CustomerRepo();
        }
        public static IBaseRepo<Product, int, int, Product> ProductContent()
        {
            return new ProductRepo();
        }

        public static IBaseRepo<ProductColorMap, int, int, ProductColorMap> ProductColorMapContent()
        {
            return new ProductColorMapRepo();
        }
        public static IBaseRepo<ProductOrderMap, int, int, ProductOrderMap> ProductOrderMapContent()
        {
            return new ProductOrderMapRepo();
        }
        public static IBaseRepo<Employee, int, string, Employee> EmployeeContent()
        {
            return new EmployeeRepo();
        }
        public static IBaseRepo<Size, int, int, Size> SizeContent()
        {
            return new SizeRepo();
        }
        public static IBaseRepo<Band, int, int, Band> BandContent()
        {
            return new BandRepo();
        }
        public static IBaseRepo<Designation, int, int, Designation> DesignationContent()
        {
            return new DesignationRepo();
        }

        public static IBaseRepo<ProductSizeMap, int, int, ProductSizeMap> ProductSizeMapContent()
        {
            return new ProductSizeMapRepo();
        }
        public static IBaseRepo<Gig, int, int, Gig> GigContent()
        {
            return new GigRepo();
        }

        public static IBaseRepo<Division, int, int, Division> DivisionContent()
        {
            return new DivisionRepo();
        }

        public static IBaseRepo<BandManager, int, int, BandManager> BandManagerContent()
        {
            return new BandManagerRepo();
        }

        public static IBaseRepo<Category, int, int, Category> CategoryContent()
        {
            return new CategoryRepo();
        }


        public static IBaseRepo<GigManager, int, int, GigManager> GigManagerContent()
        {
            return new GigManagerRepo();
        }

        public static IBaseRepo<Location, int, int, Location> LocationContent()
        {
            return new LocationRepo();
        }

        public static IBaseRepo<Order, int, int, Order> OrderContent()
        {
            return new OrderRepo();
        }
        //public static IReport<int, DateTime, ProductOrderMap, ProductOrderMap, ProductsSalesData> ReportContent()
        //{
           // return new ReportRepo();
        //}
    }
}
