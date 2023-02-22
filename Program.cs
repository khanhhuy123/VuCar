using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace vuClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 9;

            Car Tesla = new Car(0);
            Car BMW = new Car(0);
            Car Audi = new Car(0);

            do{
                Console.WriteLine("1. Tesla");
                Console.WriteLine("2. BMW");
                Console.WriteLine("3. Audi");

                choice = int.Parse(Console.ReadLine());

                while (choice == 1) {
                    Console.WriteLine("Car: Tesla");
                    Tesla.printSpeed();
                    Console.WriteLine("1. Increase speed \n2. Decrease speed \n9. Return");
                    int teslaChoice = int.Parse(Console.ReadLine());

                    if (teslaChoice == 1){
                        Tesla.increseSpeed();
                    }
                    else if (teslaChoice == 2){
                        Tesla.decreseSpeed();
                    }
                    else if (teslaChoice == 9){
                        break;
                    }
                }
                while (choice == 2){
                    Console.WriteLine("Car: BMW");
                    BMW.printSpeed();
                    Console.WriteLine("1. Increase speed \n2. Decrease speed \n9. Return");
                    int BMWChoice = int.Parse(Console.ReadLine());

                    if (BMWChoice == 1)
                    {
                        BMW.increseSpeed();
                    }
                    else if (BMWChoice == 2){
                        BMW.decreseSpeed();
                    }
                    else if (BMWChoice == 9){ 
                        break;
                    }
                } 
                while (choice == 3){
                    Console.WriteLine("Car: Audi");
                    Audi.printSpeed();
                    Console.WriteLine("1. Increase speed \n2. Decrease speed \n9. Return");
                    int AudiChoice = int.Parse(Console.ReadLine());

                    if (AudiChoice == 1){
                        Audi.increseSpeed();
                    }
                    else if (AudiChoice == 2){
                        Audi.decreseSpeed();
                    }
                    else if (AudiChoice == 9){
                        break;
                    }
                }

            } while (choice != 0);
        }
    }
}
