using System;

class Program
{
    static void Main(string[] args)
    {
        int fanspeed;
        char oscillateoption;
        int basefanpower = 10;

        do
        {
            Console.WriteLine("Enter fan speed (1, 2, or 3):");
        } while (!int.TryParse(Console.ReadLine(), out fanspeed) || fanspeed < 1 || fanspeed > 3);

        do
        {
            Console.WriteLine("Do you want to oscillate? (Y/N):");
        } while (!char.TryParse(Console.ReadLine(), out oscillateoption) || (oscillateoption != 'Y' && oscillateoption != 'N'));


        int fanpoweroutput = basefanpower * fanspeed;


        if (oscillateoption == 'Y')
        {
            oscillateoutput(fanpoweroutput);
        }
        else
        {
            steadyoutput(fanpoweroutput);
        }
    }

    static void oscillateoutput(int fanpoweroutput)
    {
        for (int i = 1; i <= fanpoweroutput; i++)
        {
            Console.WriteLine(new string('~', i));
        }
        for (int i = fanpoweroutput ; i >= 1; i--)
        {
            Console.WriteLine(new string('~', i));
        }
    }

    static void steadyoutput(int fanpoweroutput)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(new string('~', fanpoweroutput));
        }
    }
}