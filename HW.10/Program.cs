using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0, c=0;
            Console.WriteLine("Введите угол");
            int a_Angel = Number(a);
            Console.WriteLine("Введите минуты");
            int b_Min = Number(b);
            Console.WriteLine("Введите Секунды");
            int с_Sec = Number(c);
            Angle d =new Angle(a_Angel, b_Min,с_Sec);
            d.ToRadian();
            Console.ReadKey();
        }
        static int Number(int a)
        {
            try
            {
                 a = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {

                Console.WriteLine("Неверный формат");
            }
            return a;
        }
   

    }

    class Angle
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            set
            {
               if (value>=0 && value<=360)
                    {
                        gradus = value;
                    }
                    else
                    {
                        Console.WriteLine("Введите положительное число от 0 до 360 Для градусов");
                    }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {  
                if (value >= 0&&value <=60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Введите положительное число от 0 до 60 Для минут");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                
                
                 if (value >= 0&&value<=60)
                 {
                     sec=value;
                 }
                 else
                 {
                     Console.WriteLine("Введите положительное число от 0 до 60 Для секунд");
                 }
            }
            get
            {
                return sec;
            }
        }


            public Angle(int gradus,int min,int sec)
        {
            Gradus =gradus;
            Min = min;
            Sec = sec;
        }
        public void ToRadian()
        {
            double Rad_1 = (gradus * Math.PI / 180);
            double Rad_2 = (min  * Math.PI / 180)/60;
            double Rad_3 = (sec  * Math.PI / 180)/3600;
            double Rad = Rad_1 + Rad_2 +Rad_3 ;
            Console.WriteLine(Rad);
        }

    }
    
}
