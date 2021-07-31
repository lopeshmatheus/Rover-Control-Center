﻿using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);
            Rover[] roverArray = { lunokhod, apollo, sojourner };

      

            IDirectable[] probesList = { lunokhod, apollo, sojourner, sputnik };
            DirectAll(probesList);
        }


        public static void DirectAll(IDirectable[] roverList)
        {
            foreach(Rover roverElement in roverList)
            {
                Console.WriteLine(roverElement.GetInfo());
                Console.WriteLine(roverElement.Explore());
                Console.WriteLine(roverElement.Collect());
            }
        }
    }
}
