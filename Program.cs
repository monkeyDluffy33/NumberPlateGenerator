// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using NumberPlateGenerator;
using System.Text;

var numberPlate = new NumberPlate();
Random random = new Random();
string MemoryTag;

Console.WriteLine("Please Enter the memory tag eg: CA, AB:");
MemoryTag = Console.ReadLine();

//Validating Memory Tag
while(!NumberPlate.IsValidMemoryTag(MemoryTag))
{
    Console.WriteLine("Please Enter the memory tag again, Note that it shoul be 2 letter long:");
    MemoryTag = Console.ReadLine();
    
    
}
MemoryTag = MemoryTag.ToUpper();

Console.WriteLine("Please enter the Date of Registration eg: 20/01/2022 dd/mm/yy:");
DateTime Date = Convert.ToDateTime(Console.ReadLine());



int stringLength = random.Next(3, 3);
string str = "";
int randomLetter;
char letter;
string RandomlyGenerated ="";
for (int i = 0; i <= stringLength; i++)
{

    // Generating a random number.
    randomLetter = random.Next(0, 26);
    

        // Generating random character by converting
        // the random number into character.
        letter = Convert.ToChar(randomLetter + 65);

        // Appending the letter to string.
        str = str + letter;
        str = str.ToUpper();


}
RandomlyGenerated = str;
while (NumberPlate.IsValidlyGenerated(RandomlyGenerated) && !NumberPlate.IsValidLetter(RandomlyGenerated))
{
    stringLength = random.Next(3, 3);
    str = "";
    
    
    for (int i = 0; i < stringLength; i++)
    {

        // Generating a random number.
        randomLetter = random.Next(0, 26);


        // Generating random character by converting
        // the random number into character.
        letter = Convert.ToChar(randomLetter + 65);

        // Appending the letter to string.
        str = str + letter;
        str = str.ToUpper();
        


    }
    RandomlyGenerated = str;

}


string RandomlyGeneratedLetter = RandomlyGenerated.Substring(0, 3); 
string AgeIdentifier = Date.ToString("yy");
int RealAgeIdentifier = Convert.ToInt32(AgeIdentifier);
string NewNumberPlate = "";

//Getting NumberPlate
if (Date.Month == 03 && Date.Month == 04 && Date.Month == 5 && Date.Month == 6 && Date.Month == 7 && Date.Month == 8)
    {
        Console.Write(MemoryTag + RealAgeIdentifier + " " + RandomlyGeneratedLetter);
    NewNumberPlate = MemoryTag + RealAgeIdentifier + " " + RandomlyGeneratedLetter;


    }
else if (Date.Month == 01 && Date.Month == 02)
    {
    RealAgeIdentifier = RealAgeIdentifier + 49;
    Console.Write(MemoryTag + RealAgeIdentifier + " " + RandomlyGeneratedLetter);
    NewNumberPlate = MemoryTag + RealAgeIdentifier + " " + RandomlyGeneratedLetter;
    }
else
    {
    RealAgeIdentifier = RealAgeIdentifier + 50;
    Console.Write(MemoryTag + RealAgeIdentifier + " " + RandomlyGeneratedLetter);
    NewNumberPlate = MemoryTag + RealAgeIdentifier + " " + RandomlyGeneratedLetter;
}
//Validating NumberPlate
while (!NumberPlate.IsValidNumberPlate(NewNumberPlate))
{
    stringLength = random.Next(3, 3);
    str = "";
    RandomlyGenerated = "";
    for (int i = 0; i <= stringLength; i++)
    {

        // Generating a random number.
        randomLetter = random.Next(0, 26);


        // Generating random character by converting
        // the random number into character.
        letter = Convert.ToChar(randomLetter + 65);

        // Appending the letter to string.
        str = str + letter;
        str =str.ToUpper();


    }
    RandomlyGenerated = str;
    while (NumberPlate.IsValidlyGenerated(RandomlyGenerated) && !NumberPlate.IsValidLetter(RandomlyGenerated))
    {
        stringLength = random.Next(3, 3);
        str = "";


        for (int i = 0; i < stringLength; i++)
        {

            // Generating a random number.
            randomLetter = random.Next(0, 26);


            // Generating random character by converting
            // the random number into character.
            letter = Convert.ToChar(randomLetter + 65);

            // Appending the letter to string.
            str = str + letter;
            str = str.ToUpper();



        }
        RandomlyGenerated = str;

    }

    RandomlyGeneratedLetter = RandomlyGenerated.Substring(0, 3);
    AgeIdentifier = Date.ToString("yy");
    RealAgeIdentifier = Convert.ToInt32(AgeIdentifier);
    NewNumberPlate = "";


    if (Date.Month == 03 && Date.Month == 04 && Date.Month == 5 && Date.Month == 6 && Date.Month == 7 && Date.Month == 8)
    {
        Console.Write(MemoryTag + RealAgeIdentifier + " " + RandomlyGeneratedLetter);
        NewNumberPlate = MemoryTag + RealAgeIdentifier + " " + RandomlyGeneratedLetter;


    }
    else if (Date.Month == 01 && Date.Month == 02)
    {
        RealAgeIdentifier = RealAgeIdentifier + 49;
        Console.Write(MemoryTag + RealAgeIdentifier + " " + RandomlyGeneratedLetter);
        NewNumberPlate = MemoryTag + RealAgeIdentifier + " " + RandomlyGeneratedLetter;
    }
    else
    {
        RealAgeIdentifier = RealAgeIdentifier + 50;
        Console.Write(MemoryTag + RealAgeIdentifier + " " + RandomlyGeneratedLetter);
        NewNumberPlate = MemoryTag + RealAgeIdentifier + " " + RandomlyGeneratedLetter;
    }

}




try
{
    // If techcoil.txt exists, seek to the end of the file,
    // else create a new one.

    FileInfo fileInfo = new FileInfo("NumberPlateList.txt");
    FileStream fileStream = fileInfo.Open(FileMode.Append,
        FileAccess.Write);

    
    String NumberPlateList = NewNumberPlate
        + Environment.NewLine;

    // Get the current date time string as bytes
    byte[] ByteNumberPlateList
         = ASCIIEncoding.UTF8.GetBytes(NumberPlateList);

    // Write those bytes to the txt file
    fileStream.Write(ByteNumberPlateList,
        0, ByteNumberPlateList.Length);
    fileStream.Flush();
    fileStream.Close();
}
catch (IOException ioe)
{
    Console.WriteLine(ioe);
}