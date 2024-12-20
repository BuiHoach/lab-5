using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_5._4
{
    internal class Department
    {// Trường tên phòng ban
        public string Name { get; set; }

        // Mảng Employee chứa các nhân viên trong phòng ban
        private Employee[] employees;

        // Constructor khởi tạo đối tượng Department
        public Department(string name, int numberOfEmployees)
        {
            Name = name;
            employees = new Employee[numberOfEmployees];
        }

        // Indexer cho phép truy cập và thao tác với các nhân viên trong mảng
        public Employee this[int index]
        {
            get
            {
                if (index >= 0 && index < employees.Length)
                    return employees[index];
                else
                    throw new IndexOutOfRangeException("Index out of range.");
            }
            set
            {
                if (index >= 0 && index < employees.Length)
                    employees[index] = value;
                else
                    throw new IndexOutOfRangeException("Index out of range.");
            }
        }

        // Phương thức hiển thị thông tin tất cả nhân viên trong phòng ban
        public void DisplayAllEmployees()
        {
            Console.WriteLine($"Department: {Name}");
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i]?.DisplayInfo();
            }
        }
    }
}
