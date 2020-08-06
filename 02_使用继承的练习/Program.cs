using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_使用继承的练习
{
    //基类
    public class Person
    {
        //字段
        private string _name;
        private int _age;
        //属性
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        //构造函数
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }


    }
    //派生类->记者
    public class Reporter:Person
    {
        //爱好
        string _hobby;
        //属性
        public string Hobby { get => _hobby; set => _hobby = value; }
        //构造函数
        public Reporter(string name,int age,string hobby):base(name,age)
        {
            this.Hobby = hobby;//派生类所独有的字段
        }
        //派生类所独有的方法
        public void ResporterSayHello()
        {
            Console.WriteLine("大家好，我叫{0} ，我今年{1}岁，我的爱好是：{2}",this.Name,this.Age,this.Hobby);
        }

        
    }
    //派生类->司机
    public class Driver:Person
    {
        //驾龄
        private int _carYear;
        public int CarYear { get => _carYear; set => _carYear = value; }
        //构造函数
        public Driver(string name,int age,int caryear):base(name, age)
        {
            this.CarYear = caryear;
        }
        //方法
        public void DriverSay()
        {
            Console.WriteLine("我叫{0} 我的年龄是{1}岁 我的驾龄{2}年 我的车是：五菱车 ",this.Name,this.Age,this.CarYear);
        }

        
    }
    //派生类->程序员
    public class programmer:Person
    {
        //公司名称
        string _corporateName;
        //工作年限
        string _workingYears;
        //属性
        public string CorporateName { get => _corporateName; set => _corporateName = value; }
        public string WorkingYears { get => _workingYears; set => _workingYears = value; }

        //构造函数
        public programmer(string name, int age, string corporateName, string workingYear) : base(name, age)
        {
            //公司名称
            this.CorporateName = corporateName;
            //工作年限
            this.WorkingYears = workingYear;
        }


        //独有的方法
        public void SayHello()
        {
            Console.WriteLine("我是{0} 我已经{1}岁 我来自{2}公司 我已经工作{3}年 但是我的头发还是很茂密",this.Name,this.Age,this.CorporateName,this.WorkingYears);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Reporter rp = new Reporter("龙嗷嗷", 18, "我是是火车王!!");
            rp.ResporterSayHello();

            Driver dr = new Driver("舒克", 23, 20);
            dr.DriverSay();

            programmer pr = new programmer("贝吉塔", 25, "超人视觉", "5");
            pr.SayHello();

        }
    }
}
