using System;
using System.Text;

namespace Đề_3
{
    internal class Program
    {
        const int MIN_PER_HOUR = 60;
        const int SALARY_PER_HOUR = 45000;
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            double Phut = 0;
            Console.Write("Nhập số phút làm việc: ");
            double SoPhutLamViec = Convert.ToInt32(Console.ReadLine());
            QuyDoiPhutSangGio(ref SoPhutLamViec);
            double TienLuong = SoPhutLamViec * SALARY_PER_HOUR;
            Console.WriteLine("Tiền lương: " + TienLuong);
        }
        static void QuyDoiPhutSangGio(ref double phut)
        {
            phut = phut / MIN_PER_HOUR;
            phut = Math.Round(phut);
        }
    }
}
