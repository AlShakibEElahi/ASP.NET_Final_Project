using DAL.Entities;
using DAL.Interfaces;
using DAL.Repos;
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
    }
}
