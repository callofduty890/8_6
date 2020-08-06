using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_使用继承
{
    public class Person
    {
        //字段
        private string _name; //姓名
        private int _age;//年龄
        private string _gender;//性别
        //属性
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Gender { get => _gender; set => _gender = value; }

        //默认的无参构造函数
        public Person()
        {
            Console.WriteLine("Person的构造函数被调用");
        }
        //构造函数的重载：有参的构造函数
        public Person(string name,int age,string gender)
        {
            Console.WriteLine("Person的有参构造函数被调用");
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        //公有的方法
        public void CHISS()//
        {
            Console.WriteLine("白天吃饭+晚上休息");
        }
    }

    public class Student:Person
    {
        //学生ID
        private int _id;
        //学生 ID
        public int Id { get => _id; set => _id = value; }
        //Student默认的无参构造函数
        public Student()
        {
            Console.WriteLine("Student的构造函数被调用");
        }
        //有参构造函数
        public Student(string name,int age,string gender,int ID):base(name, age, gender)
        {
            Console.WriteLine("Student的有参构造函数被调用");
            this.Id = ID;
        }


        public void Study()
        {
            Console.WriteLine("敲代码 学习编程");
        }
    }

    public class Teacher:Person
    {
        public void work()
        {
            Console.WriteLine("努力教学，课下辅导");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //调用无参的构造函数
            //Student st = new Student();
            //st.Name = "超人视觉";
            //st.Study();

            //调用有参的构造函数
            Student student = new Student("一拳超人",18,"男",1);
            student.Study();
        }
    }
}
