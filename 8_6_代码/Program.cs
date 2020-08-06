using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8_6_代码
{
    class Person
    {
        //字段
        private string _name; //姓名
        private int _age;//年龄
        private string _gender;//性别
        //属性
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Gender { get => _gender; set => _gender = value; }
    }
    public class Student
    {
        //字段
        private string _name; //姓名
        private int _age;//年龄
        private string _gender;//性别
        //属性
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Gender { get => _gender; set => _gender = value; }
        //方法
        public void CHISS()//
        {
            Console.WriteLine("白天吃饭+晚上休息");
        }
        public void Study()
        {
            Console.WriteLine("敲代码,努力学习");
        }
    }

    public class Teacher
    {
        //字段
        private string _name; //姓名
        private int _age;//年龄
        private string _gender;//性别
        //属性
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Gender { get => _gender; set => _gender = value; }

        public void CHISS()//吃饭+休息
        {
            Console.WriteLine("白天吃饭+晚上休息");
        }

        public void Work() //工作
        {
            Console.WriteLine("备课，修改PPT");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();

        }
    }
}
