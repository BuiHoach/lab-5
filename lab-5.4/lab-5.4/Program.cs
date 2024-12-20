using System.Text;

namespace lab_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            // Tạo một phòng ban mới
            Department department = new Department("IT", 3);

            // Thêm nhân viên vào phòng ban
            department[0] = new Employee(1, "John Doe", 28);
            department[1] = new Employee(2, "Jane Smith", 34);
            department[2] = new Employee(3, "Alice Johnson", 25);

            // Hiển thị thông tin tất cả nhân viên trong phòng ban
            department.DisplayAllEmployees();

            // Truy cập và thay đổi thông tin một nhân viên thông qua indexer
            department[1].Age = 35; // Cập nhật tuổi của Jane Smith
            Console.WriteLine("\nAfter updating Jane Smith's age:");
            department.DisplayAllEmployees();
        }
    }
}
