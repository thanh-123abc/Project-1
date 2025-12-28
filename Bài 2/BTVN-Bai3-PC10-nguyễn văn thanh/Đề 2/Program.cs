using System.Text;

namespace Đề_2
{
    internal class Program
    {
        //const int WH_TO_KWH = 1000;
        //const int PRICE_PRE_KWH = 2500;

        //static void DuLieuDauVao(ref int SoDien)
        //{
        //    int SoDienGhiDe = 0;
        //    Console.InputEncoding = Encoding.UTF8;
        //    Console.OutputEncoding = Encoding.UTF8;
        //    Console.Write("Mời nhập số điện(Wh): ");
        //    SoDien = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Số điện là: " + SoDien + "Wh");
        //    SoDienGhiDe = SoDien * WH_TO_KWH;
        //    SoDien = SoDienGhiDe;
        //    Console.WriteLine("Số điện ghi đè là: " + SoDien + "kWh");
        //}
        //static int TongTiendien(ref int TongTiendien)
        //{
        //    int sodien = 0;
        //    int Total = 0;
        //    Console.InputEncoding = Encoding.UTF8;
        //    Console.OutputEncoding = Encoding.UTF8;
        //    DuLieuDauVao(ref sodien);
        //    Total = sodien * PRICE_PRE_KWH;
        //    Console.WriteLine("Tổng tiền điện phải trả là: " + Total);
        //    return Total;

        //}
        //static void Main(string[] args)
        //{
        //    Console.InputEncoding = Encoding.UTF8;
        //    Console.OutputEncoding = Encoding.UTF8;
        //    int soDien = 0;
        //    int tongTiendien = 0;
        //    int ghiDeSoDien = 0;
        //    //TongTiendien(ref tongTiendien);
        //    int InTienDien = TongTiendien(ref tongTiendien);
        //    Console.WriteLine("Tổng tiền điện (return): " + InTienDien);
        //    double SoTienDien = Convert.ToDouble(InTienDien);
        //    Console.WriteLine("Tổng tiền điện (double): " + InTienDien);
        //}
        const int WH_TO_KWH = 1000;
        const int PRICE_PER_KWH = 2500;
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            int DienTieuThu = 40;
            //int totalPrice = 0;
            DienTieuThu = Convert.ToInt32(Wh_TO_kWh(DienTieuThu));
            Console.WriteLine("Số điện tiêu thụ: " + DienTieuThu+"kWh");
            int TongTienDienPhaiTra = DienTieuThu;
            TotalPrice(ref TongTienDienPhaiTra);

            Console.WriteLine("Tổng tiền điện phải trả: " + TongTienDienPhaiTra + "d");
        }
        //quy đổi Wh sang kWh
        static double Wh_TO_kWh(double DienTieuThu)
        {
            DienTieuThu = Math.Round(DienTieuThu * WH_TO_KWH);
            return DienTieuThu;
        }
        //tính tổng số tiền điện phải trả 
        static void TotalPrice(ref int TotalPrice)
        { 
            TotalPrice = TotalPrice * PRICE_PER_KWH;
        } 

    }
}
