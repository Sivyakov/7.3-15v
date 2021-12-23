using System;

namespace _7._3_15v
{
    class Program
    {
        struct route
        {
            public int n;
            public string lin;
            public string dateOfarrival;
            public string dateOfdeparture;
            public int distance;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество поездов:");
            int n = int.Parse(Console.ReadLine());
            route[] routes = new route[n];
            for (int i = 0; i < routes.Length; i++)
            {
                Console.Write("Введите номер поезда:");
                routes[i].n = int.Parse(Console.ReadLine());
                Console.Write("Введите направление:");
                routes[i].lin = Console.ReadLine();
               Console.Write("Введите время отбытия:");
                routes[i].dateOfdeparture = Console.ReadLine(); 
                Console.Write("Введите время прибытия:");
                routes[i].dateOfarrival = Console.ReadLine();
                Console.Write("Введите расстояние:");
                routes[i].distance = int.Parse(Console.ReadLine());

            }
            foreach (route item in routes)
            {

                string[] dmy = item.dateOfdeparture.Split(".");
                int day = int.Parse(dmy[0]);
                int hours = int.Parse(dmy[1]);
                int minutes = int.Parse(dmy[2]);
                int nowDay = DateTime.Now.Day;
                int nowHours = DateTime.Now.Hour;
                int nowMinutes = DateTime.Now.Minute;
                if ((nowDay - day == 1 && hours == nowHours && nowMinutes < minutes) || (nowDay>day))
                {
                    Console.WriteLine("Номер поезда:" + item.n + ",направление" + item.lin + ", время отбытия" + item.dateOfdeparture +
                        ",время прибытия" + item.dateOfarrival + ",расстояние" + item.distance);
                }
            }
        }
    }
}
