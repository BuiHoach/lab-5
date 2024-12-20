using System.Text;

namespace lab_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Mảng CAN và CHI
            string[] can = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
            string[] chi = { "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };

            // Năm 2010 là năm CANH DẦN
            int baseYear = 2010;
            int baseCanIndex = 6;  // CANH là chỉ số thứ 6 trong mảng CAN
            int baseChiIndex = 2;  // DẦN là chỉ số thứ 2 trong mảng CHI

            // Nhập năm dương lịch từ người dùng
            Console.Write("Nhập vào năm dương lịch: ");
            int year = int.Parse(Console.ReadLine());

            // Tính toán chỉ số Can và Chi của năm dương lịch nhập vào
            int canIndex = (baseCanIndex + (year - baseYear) % 10 + 10) % 10;
            int chiIndex = (baseChiIndex + (year - baseYear) % 12 + 12) % 12;

            // In ra năm âm lịch tương ứng
            Console.WriteLine($"Năm {year} dương lịch tương ứng với năm {can[canIndex]} {chi[chiIndex]} âm lịch.");
        }
    }
}
