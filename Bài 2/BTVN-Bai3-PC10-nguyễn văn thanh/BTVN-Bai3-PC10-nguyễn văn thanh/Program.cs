using System.Text;

namespace BTVN_Bai3_PC10_nguyễn_văn_thanh
{
    internal class Program
    {
        //Đề 1:
        const double VAT = 0.10;
        // Hàm nhập đơn giá và số lượng 
        static void HamNhap(ref double donGia, ref int soLuong)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Mời nhập hóa đơn :");
            Console.Write("Mời nhập đơn giá: ");
            donGia = double.Parse(Console.ReadLine());
            Console.Write("Mời nhập số lượng : ");
            soLuong = int.Parse(Console.ReadLine());
            soLuong++;                               // tăng sản lượng lên 1
            Console.WriteLine("Số lượng cộng thêm: " + soLuong);
        }
        // trả về tổng tiền và thuế VAT bằng (out)
        static void TraVeBangOut(double Tongtien, double ThueVAT, out double TongTiengOut , out double ThueVatOut)
        {
            TongTiengOut = Tongtien;
            Console.WriteLine("Tổng tiền Out: " + TongTiengOut);
            ThueVatOut = ThueVAT;
            Console.WriteLine("Thuế VAT Out: " + ThueVatOut);

        }
        static void Main(string[] args)
        {
            double DonGia = 0;
            int Soluong = 0;
            HamNhap(ref DonGia, ref Soluong);
            double ThanhTien = DonGia * Soluong;   // Thành tiền 
            double ThueVAT = ThanhTien * VAT;      // Thuế VAT
            double Tongtien = ThanhTien + ThueVAT;    // Tổng tiền thanh toán
            Console.WriteLine("Thành tiền: " + ThanhTien);
            Console.WriteLine("thuế VAT: " + ThueVAT);
            Console.WriteLine("Total: " + Tongtien);
            TraVeBangOut(Tongtien, ThueVAT, out double a , out double b);
            int TongTienInt1 = Convert.ToInt32(Tongtien);             // đổi sang kiểu int
            Console.WriteLine("TongTienToInt1 : " + TongTienInt1);
            int TongTienInt2 = (int)Tongtien;                         // đổi sang kiểu int
            Console.WriteLine("TongTienToInt2 : " + TongTienInt2);
        }
        
    }
}
