using System;
using System.IO;

namespace FMXml2Tex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                $"FrameMaker XML to LaTeX Transpiler {Environment.Version.ToString()}\n" +
                $"Copyright (C) 0x00000FF, {DateTime.Now.Year} All rights reserved.\n"
                );

            if (args.Length == 0)
            {
                Console.WriteLine("Error: Target file path is not provided.");
                Console.WriteLine("Usage: dotnet FMXml2Tex.dll <framemaker-xml-file>");
                
                Environment.Exit(1);
            }

            var filepath = args[0];
            
            if (!File.Exists(filepath))
            {
                Console.WriteLine("Error: Target file path does not exists!");
                Environment.Exit(2);
            }


        }
    }
}
