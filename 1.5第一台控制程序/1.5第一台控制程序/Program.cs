using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5第一台控制程序
{
    interface IPersion
    { 
        string Name { get; set; }    
        int Age { get; set; }
        void Speek();
        void Work();

    }
    class Student : IPersion
    {
        public string Name { get; set; }
        public int age;
        public int Age
        {
            get 
            {
                return Age;
            }
            set 
            {
                if ((age > 0) && (age < 120))
                {
                    age = value;
                }
            }
        }
        public void Speek()
        {
            Console.WriteLine(Name + ": 老师好");
        }
        public void Work()
        {
            Console.WriteLine(Name +"同学开始做笔记");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //主函数
           
            Console.ReadLine();//等待用户输入
        }
    }
}
