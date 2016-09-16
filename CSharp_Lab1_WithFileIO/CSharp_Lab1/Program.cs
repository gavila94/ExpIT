using System;
using System.Collections.Generic;

namespace CSharp_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            //reading from a file
            string path = @"C:\GrandCircusMaterials\C#Bootcamp\ExpIT_dotNETBootcamp\CSharp_Lab1_WithFileIO\CSharp_Lab1\";
            //path = "C:\\GrandCircusMaterials\\C#Bootcamp\\C_Sharp_Labs\\CSharp_Lab1\\CSharp_Lab1\\ProgramData.txt";

            string filePath = path+"ProgramData.txt";
           
            string[] fileContents = System.IO.File.ReadAllLines(filePath);
            int fileContentsLine = 0;

            //file program report
            string fileOutputPath = path+"ProgramOutput.txt";
            List<string> exampleOutput = new List<string>();

            //start of program
            string headerLine = "Welcome to Grand Circus’ Room Detail Generator!";
            // Console.WriteLine(headerLine);
            //Console.WriteLine();
            exampleOutput.Add(headerLine);
            exampleOutput.Add("");

            //loop
            string inputContinue = "start value";
            do
            {
                //input for length
                string enterLengthLine  = "Enter Length: {user input here, for example: 24.5}";
                exampleOutput.Add(enterLengthLine);
                //Console.WriteLine(enterTextLine);

                //string inputLength = Console.ReadLine();
                string inputLength = fileContents[fileContentsLine];
                fileContentsLine++;

                //input for width
                string enterWidthLine = "Enter Width: {user input here, for example: 20}";
                exampleOutput.Add(enterWidthLine);
                Console.WriteLine(enterWidthLine);

                string inputWidth = fileContents[fileContentsLine];
                fileContentsLine++;

                //Convert input values to numbers
                decimal length = decimal.Parse(inputLength);
                decimal width = decimal.Parse(inputWidth);


                //do area and perimeter calculations
                decimal area = length * width;
                decimal perimeter = 2 * (length + width);

                //write results to console
                string areaLine = "Area: " + area;
                string permiterLine = "Perimeter :" + perimeter;

                exampleOutput.Add(areaLine);
                exampleOutput.Add(permiterLine);

                Console.WriteLine(areaLine);
                Console.WriteLine(permiterLine);

                //continue question 
                Console.WriteLine("Continue? (y/n):");
                inputContinue = fileContents[fileContentsLine];
                fileContentsLine++;

            } while (inputContinue.ToLower() == "y");


            System.IO.File.WriteAllLines(fileOutputPath, exampleOutput);

        }
    }
}
