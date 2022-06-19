using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Zone
{ 
    school = 1,
    city = 2,
    highway = 3,
}

enum Speed
{
    school = 20,
    city = 30,
    highway = 55
}

namespace SpeedLimit
{ 
    class Progam
    { 
        static void Main(string[] args)
        { 
            Console.Write("********************************************\n");
            Console.Write("1.School\n2.City\n3.Highway\n");
            Console.Write("********************************************\n");
            Console.Write("Please enter a zone\n");

            int zone = Convert.ToInt32(Console.ReadLine());

            if (zone > 3 || zone < 1)
            {
                Console.Write("Incorrect value entered, please check the above available options\n");
                return;
            }

            Console.Write("Please enter your current speed\n");

            int speed = Convert.ToInt32(Console.ReadLine());

            if (speed < 0) {
                Console.Write("Speed can not be less than 0\n");
                return ;
            }

            if (zone == (int)Zone.school)
            {
                if (speed > (int)Speed.school)
                    Console.Write("Please slow down to maintain the speed limit of 20 in the school zone\n");
                else
                    Console.Write("Thank you for maintaining the speed limit in the school zone\n");
            }
            else if (zone == (int)Zone.city)
            {
                if (speed > (int)Speed.city)
                    Console.Write("Please slow down to maintain the speed limit of 30 in the city zone\n");
                else
                    Console.Write("Thank you for maintaining the speed limit in the city zone\n");
            }
            else if (zone == (int)Zone.highway)
            {
                if (speed > (int)Speed.highway)
                    Console.Write("Please slow down to maintain the speed limit of 55 in the highway zone\n");
                else
                    Console.Write("Thank you for maintaining the speed limit in the highway zone\n");
            }
        }
    }
}
