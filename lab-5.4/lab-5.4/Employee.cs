using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5._4
{
    internal class Employee
    {
        // Các trường thông tin của nhân viên
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor khởi tạo đối tượng Employee
        public Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        // Phương thức hiển thị thông tin nhân viên
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}");
        }
    }
}

