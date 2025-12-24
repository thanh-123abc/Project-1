using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bài_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //câu 1:
            // Khai báo các kiểu dữ liệu 
            char a = 'G';
            int i = 89;
            short s = 56;
            long l = 4564;
            uint ui = 95;
            ushort us = 76;
            ulong ul = 3624573;
            double d = 8.358674532;
            float f = 3.7330645f;
            decimal dec = 389.5m;

            Console.WriteLine("char: " + a);
            Console.WriteLine("int: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("uint: " + ui);
            Console.WriteLine("ushort: " + us);
            Console.WriteLine("ulong: " + ul);
            Console.WriteLine("double: " + d);
            Console.WriteLine("float: " + f);
            Console.WriteLine("decimal: " + dec);

            //Câu 3:
            // Xuất hóa đơn bao gồm tính cả thuế giá trị gia tăng 
            decimal price = 300000m;
            decimal taxRate = 0.10m; // 10% thuế giá trị gia tăng 
            decimal Quantity = 5;    // số lượng 
            decimal TotalPrice = price * Quantity; // tổng tiền trước thuế 
            decimal TaxAmount = TotalPrice * taxRate; // số tiền thuế 
            decimal TotalAmount = TotalPrice + TaxAmount; // tổng tiền có cả thuế 

            Console.WriteLine("Chi tiết bill là ...");
            Console.WriteLine("Giá tiền sản phẩm: " + price + "d" + " Số lượng: " + Quantity);
            Console.WriteLine("Tổng số tiền: " + TotalPrice + "d");
            Console.WriteLine("Vat: " + TaxAmount + "d");
            Console.WriteLine("Tổng số tiền cần thanh toán: " + TotalAmount + "d");

            //Câu 4:
            //Boxing 
            object obj = 20;
            Console.WriteLine(obj.GetType());

            //Unboxing
            object obj1 = 20;
            int I = (int)obj1;
            Console.WriteLine(obj1.GetType());

            //Câu 5:
            //Double
            double a1 = 0.1;
            double b1 = 0.2;
            double c1 = a1 + b1;
            Console.WriteLine(c1);  // kết quả là 0.30000000000000004

            //Float
            float a2 = 0.1f;
            float b2 = 0.2f;
            float c2 = a2 + b2;
            Console.WriteLine(c2);  // kết quả là 0.3

            //Decimal 
            decimal a3 = 0.1m;
            decimal b3 = 0.2m;
            decimal c3 = a3 + b3;
            Console.WriteLine(c3);  // kết quả là 0.3




        }
    }
}
