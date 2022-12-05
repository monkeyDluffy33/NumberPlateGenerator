using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPlateGenerator
{
    public class NumberPlate
    {

        public NumberPlate()
        {

        }



        public string MemoryTag { get; set; }
        public DateTime Date { get; set; }
        public string RandomlyGenerated { get; set; }
        public string NewNumberPlate { get; set; }

        //Method to Validate Memory Tag
        public static bool IsValidMemoryTag(string MemoryTag)
        {
            if (!string.IsNullOrEmpty(MemoryTag) && MemoryTag.Length == 2 && char.IsLetter(MemoryTag[0]) && char.IsLetter(MemoryTag[1]))
            {
                return true;
            }
            return false;
        }
        //Method to Validate if the Letter is correctly generated
        public static bool IsValidlyGenerated(string RandomlyGenerated)
        {
            if (!string.IsNullOrEmpty(RandomlyGenerated) && RandomlyGenerated.Contains("I") && RandomlyGenerated.Contains("U"))
            {
                return true;
            }
            return false;
        }
        //Method to Validate Randomly Generated Letter
        public static bool IsValidLetter(string RandomlyGenerated)
        {
            if (!string.IsNullOrEmpty(RandomlyGenerated) && char.IsLetter(RandomlyGenerated[0]) && char.IsLetter(RandomlyGenerated[1]) && char.IsLetter(RandomlyGenerated[2]))
            {
                return true;
            }
            return false;
        }
        //Validating if NumberPlate already Exists
        public static bool IsValidNumberPlate (string NewNumberPlate)
        {
            //Please change this directory When You run this code
            // Read the file as one string.
            string text = System.IO.File.ReadAllText(@"C:\Users\BIPUL BHATTA\source\repos\NumberPlateGenerator\bin\Debug\net6.0\NumberPlateList.txt");




            //Please change this directory When You run this code
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\BIPUL BHATTA\source\repos\NumberPlateGenerator\bin\Debug\net6.0\NumberPlateList.txt");

                if (lines.Contains(NewNumberPlate))
                {
                    return false;
                }

                return true;
        }
            
    }
}


