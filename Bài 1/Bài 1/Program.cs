using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bài_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            //AssemblyLoadEventArgsa
            //    a
            //    a
            //    a
            //    a
            //    a


         //Câu 4:













        }
    }
}
