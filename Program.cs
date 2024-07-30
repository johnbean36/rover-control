using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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
        Rover[] rover = new Rover[]{lunokhod, apollo, sojourner};
        DirectAll(rover);
        Object[] probes = {lunokhod, apollo, sojourner, sputnik};
        foreach(Object space in probes){
            Console.WriteLine($"Tracking a {space.GetType()}");
        }
    }

    public static void DirectAll(Rover[] aRover){
        foreach(Rover item in aRover){
            Console.WriteLine(item.GetInfo());
            Console.WriteLine(item.Explore());
            Console.WriteLine(item.Collect());
        }
    }

  }
}