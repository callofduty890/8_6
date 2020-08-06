using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_里氏转换
{
    //父类
    class Friut
    {
    }

    class Apple:Friut
    {
        public void EatApple()
        {
            Console.WriteLine("苹果的吃法");
        }
    }

    class Banana : Friut
    {
        public void EatBanana()
        {
            Console.WriteLine("香蕉的吃饭");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 里氏转换
            /* 
            //如果有一个地方需要父类作为参数那么可以传入子类
            Friut fr = new Apple();
            //里氏转换
            Apple ap = (Apple)fr;

            ap.EatApple();
            */
            #endregion

            #region is
            ////is
            //Friut fr = new Banana();

            //if (fr is Apple)
            //{
            //    Apple ap = (Apple)fr;
            //    //调用功能函数
            //    ap.EatApple();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}
            #endregion

            #region as
            //Friut fr = new Banana();
            //Banana ba = fr as Banana;
            //Apple ap = fr as Apple;

            //if (ap != null){ ap.EatApple();}
            //if (ba!=null) { ba.EatBanana();}
            #endregion
        }
    }
}
