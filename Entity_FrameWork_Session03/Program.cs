using Entity_FrameWork_Session03.Contexts;
using Entity_FrameWork_Session03.InheretanceTest;

namespace Entity_FrameWork_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RouteDBContext dBContext = new RouteDBContext();

            foreach (var e in dBContext.Employees.OfType<FullTimeEmployee>())
            {

            }
            foreach (var e in dBContext.Employees.OfType<PartTimeEmployee>())
            {
                
            }
        }
    }
}
