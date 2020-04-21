using Reflection3_withSDK.SDK;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Loader;

//This is an example of how to use SDK to make it easier for developers to write .dll.
namespace Reflection3
{
    class Program
    {
        static void Main(string[] args)
        {
            var folder = Path.Combine(Environment.CurrentDirectory, "Animals");
            var files = Directory.GetFiles(folder);
            var animalTypes = new List<Type>();

            foreach (var file in files)
            {
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(file);                
                var types = assembly.GetTypes();
                foreach (var t in types)
                {
                    //The imported assembly should be a derivate class of IAnimal and it should not have the attribute "Unfinished".
                    //也可以写成“if(t.GetInterfaces("IAnimal") != null);”
                    if (t.GetInterfaces().Contains(typeof(IAnimal)))
                    {
                        var isUnfinished = t.GetCustomAttributes(false).Any(a => a.GetType() == typeof(UnfinishedAttribute));
                        if (isUnfinished)
                        {
                            continue;
                        }
                        animalTypes.Add(t);
                    }
                }
            }

            while (true)
            {
                for (int i = 0; i < animalTypes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{animalTypes[i].Name}");
                }
                Console.WriteLine("---------------------");

                Console.WriteLine("Please type in a number to choose the animal.");
                try
                {
                    int index = int.Parse(Console.ReadLine());
                    if (index > animalTypes.Count || index < 1)
                    {
                        Console.WriteLine("Input error!");
                        continue;
                    }

                    Console.WriteLine("Please input how many times you want it to bark.");
                    int times = int.Parse(Console.ReadLine());
                    if (times < 0)
                    {
                        Console.WriteLine("Please input a positive number.");
                    }

                    var t = animalTypes[index - 1];                    
                    var o = Activator.CreateInstance(t);
                    //Use explicit convert to call the method directly.
                    var a = (IAnimal)o;
                    a.Voice(times);

                    //Or we could simplified it even more.
                    /*
                    Type t = animalTypes[index - 1];
                    IAnimal o = (IAnimal)Activator.CreateInstance(t);
                    o.Voice(times);
                    */

                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }                
            }
        }
    }
}

