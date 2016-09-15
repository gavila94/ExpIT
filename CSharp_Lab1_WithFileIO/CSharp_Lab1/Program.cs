using System;
using System.Collections.Generic;

namespace CSharp_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            //reading from a file
            string filePath = @"C:\GrandCircusMaterials\C#Bootcamp\C_Sharp_Labs\CSharp_Lab1\CSharp_Lab1\ProgramData.txt";
            filePath = "C:\\GrandCircusMaterials\\C#Bootcamp\\C_Sharp_Labs\\CSharp_Lab1\\CSharp_Lab1\\ProgramData.txt";

            string[] fileContents = System.IO.File.ReadAllLines(filePath);
            int fileContentsLine = 0;

            //file program report
            List<string> exampleOutput = new List<string>();

            string fileOutputPath = @"C:\GrandCircusMaterials\C#Bootcamp\C_Sharp_Labs\CSharp_Lab1\CSharp_Lab1\ProgramOutput.txt";

            //start of program
            // Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
            //'Console.WriteLine();
            exampleOutput.Add("Welcome to Grand Circus’ Room Detail Generator!");
            exampleOutput.Add("");

            //loop
            string inputContinue = "start value";
            do
            {
                //input for length
                exampleOutput.Add("Enter Length: {user input here, for example: 24.5}");
                Console.WriteLine("Enter Length: {user input here, for example: 24.5}");
                //string inputLength = Console.ReadLine();
                string inputLength = fileContents[fileContentsLine];
                fileContentsLine++;

                //input for width
                exampleOutput.Add("Enter Width: {user input here, for example: 20}");
                Console.WriteLine("Enter Width: {user input here, for example: 20}");
                string inputWidth = fileContents[fileContentsLine];
                fileContentsLine++;

                //Convert input values to numbers
                decimal length = decimal.Parse(inputLength);
                decimal width = decimal.Parse(inputWidth);


                //do area and perimeter calculations
                decimal area = length * width;
                decimal perimeter = 2 * (length + width);

                //write results to console
                exampleOutput.Add("Area: " + area);
                exampleOutput.Add("Perimeter :" + perimeter);
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter :" + perimeter);

                //continue question 
                Console.WriteLine("Continue? (y/n):");
                inputContinue = fileContents[fileContentsLine];
                fileContentsLine++;

            } while (inputContinue.ToLower() == "y");


            System.IO.File.WriteAllLines(fileOutputPath, exampleOutput);

        }
    }
}
