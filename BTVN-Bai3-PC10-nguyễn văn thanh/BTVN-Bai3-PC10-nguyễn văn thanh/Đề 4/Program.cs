using System.Text;

namespace Đề_4
{
    internal class Program
    {
        const double VAT = 0.1;
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            double GiaGoc = 40.25;
            //recipe(GiaGoc);
            int ChangePrice = Convert.ToInt32(recipe(GiaGoc));
            double ChangePriceDouble = GiaGoc;
            Console.WriteLine("Giá sau thuế dạng double: " + ChangePriceDouble);
            ChangePriceDouble = Math.Round(ChangePriceDouble);
            Console.WriteLine("Giá sau thuế đã làm tròn: " + ChangePriceDouble);
        }
        static double recipe(double gia)
        {
            double giaThue = gia * VAT;
            double GiaSauThue = gia + giaThue;
            return GiaSauThue;
        }
    }
}
