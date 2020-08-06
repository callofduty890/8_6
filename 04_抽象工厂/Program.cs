using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_抽象工厂
{
    //2.创建具体的产品
    class Friut
    {
        public string color;
    }
    class Apple:Friut
    {
        public void EatAppple()
        {
            Console.WriteLine("我是苹果的吃法");
        }
    }
    class Banana : Friut
    {
        public void EatBanana()
        {
            Console.WriteLine("我是香蕉的吃法");
        }
    }
    class Pear : Friut
    {
        public void EatPear()
        {
            Console.WriteLine("我是梨子的吃法");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您需要吃的水果 1.苹果 2.香蕉 3.梨子");

            //接收结果
            string result = Console.ReadLine();

            //1.创建抽象产品类 ->2.创建水果类
            Friut fr = null;

            //3.创建调用工厂
            switch (result)
            {
                case "苹果":
                    fr = new Apple();
                    break;
                case "梨子":
                    fr = new Pear();
                    break;
                case "香蕉":
                    fr = new Banana();
                    break;
            }

            //4.调用工厂类
            if (fr is Apple)
            {
                ((Apple)fr).EatAppple();
            }
            if (fr is Banana)
            {
                ((Banana)fr).EatBanana();
            }
            if (fr is Pear)
            {
                ((Pear)fr).EatPear();
            }

            Console.ReadKey();
        }
    }
}
