namespace NewAbilityScoreCalculator
{
    internal class Program
    {
        static void Main()
        {


            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = myByte;
            string myString = "false";
            short myShort = (short)myInt;
            char myChar = 'x';
            myString = myString + myInt + myByte + myDouble + myShort + myChar;

            Console.WriteLine(myString.GetType());
        }
    }
}
