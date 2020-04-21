using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Loader;

//This is an example of "plug-in" style program.
namespace Reflection3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aquire the path of the files.
            var folder = Path.Combine(Environment.CurrentDirectory, "Animals");
            //Create a string[] to store the path of files in "folder".
            var files = Directory.GetFiles(folder);
            //Create a List<Type> to store classes that satisfies the conditions from "files".
            var animalTypes = new List<Type>();

            foreach (var file in files)
            {
                //"assembly" is what we called the program. This is reading the .cs files.
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(file);
                //"types" represents the class.
                var types = assembly.GetTypes();
                foreach (var t in types)
                {
                    //If the class contains a method called "Voice", add it to the list.
                    if (t.GetMethod("Voice") != null)
                    {
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

                    //Use reflection to create an instance of the class we imported and filtered.
                    //And invoke the method "Voice".
                    var t = animalTypes[index - 1];
                    var m = t.GetMethod("Voice");
                    var o = Activator.CreateInstance(t);
                    m.Invoke(o, new object[] { times });

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

