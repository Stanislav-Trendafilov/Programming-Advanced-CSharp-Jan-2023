using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fGreenLightDuration=int.Parse(Console.ReadLine());  
            int fFreeWindowDuration=int.Parse(Console.ReadLine());
            string command=Console.ReadLine();
            Queue<string>cars=new Queue<string>();

            int total= fGreenLightDuration + fFreeWindowDuration;
            int count=0;

            bool crashHappened = false;
            char hittedLetter = ' ';
            string hitCar=string.Empty;

            while (command!= "END") 
            {
                int greenLightDuration = fGreenLightDuration;
                int freeWindowDuration = fFreeWindowDuration;
               
                if (command=="green")
                {
                    while(total>0&&cars.Any())
                    {
                        bool isGreen = false;
                        if (greenLightDuration > 0)
                        { 
                            greenLightDuration -= cars.Peek().Length; 
                            isGreen= true;
                        }
                        if (greenLightDuration+freeWindowDuration >= 0&&isGreen==true)
                        {
                            cars.Dequeue();
                            count++;
                            if (greenLightDuration < 0)
                            {
                                freeWindowDuration = greenLightDuration + freeWindowDuration;
                            }    
                        }
                        else if(isGreen==false)
                        {
                            break;
                        }
                        else if (greenLightDuration + freeWindowDuration < 0 && isGreen == true)
                        {                         
                            crashHappened = true;
                            hitCar = cars.Peek().ToString();
                            hittedLetter = hitCar[hitCar.Length - Math.Abs(greenLightDuration) + freeWindowDuration];
                            break;                            
                        }
                        
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                if (crashHappened) { break; }
                command= Console.ReadLine();
            }
            if(crashHappened) 
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{hitCar} was hit at {hittedLetter}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{count} total cars passed the crossroads.");
            }

        }
    }
}
