using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompare
{
    class StringCompare
    {
        static void Main(string[] args)
        {
            //var string1 = "hello";
            //var string2 = "good bye";
            //var string3 = "Happy Birthday";
            //var string4 = "happy birthday";

            //// Outut values of four strings
            //Console.WriteLine($"string1: \"{string1}\"" +
            //    $"\nstring2: \"{string2}\"" +
            //    $"\nstring3: \"{string3}\"" +
            //    $"\nstring4: \"{string4}\"\n");

            //// Test for equality using Equals method
            //if (string1.Equals("hello"))
            //{
            //    Console.WriteLine("string1 equals\"hello\"");
            //}
            //else
            //{
            //    Console.WriteLine("string1 does not equal \"hello\"");
            //}

            //// Test for equality with ==
            //if (string1 == "hello")
            //{
            //    Console.WriteLine("string1 equals\"hello\"");
            //}
            //else
            //{
            //    Console.WriteLine("string1 does not equal \"hello\"");
            //}

            /****************** StringStartEnd ********************/
            string[] strings = { "started", "starting", "ended", "ending" };

            // Test every string to see if it starts with "st"
            foreach (var element in strings)
            {
                if (element.StartsWith("st"))
                {
                    Console.WriteLine($"\"{element}\" starts with \"st\"");
                }
            }

            Console.WriteLine();

            // Test every string to see if it ends with "ed"
            foreach (var element in strings)
            {
                if (element.EndsWith("ed"))
                {
                    Console.WriteLine($"\"{element}\" ends with\"ed\"");
                }
            }
        }
    }
}
