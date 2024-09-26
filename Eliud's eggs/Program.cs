namespace Eliud_s_eggs
{
    internal class Program;
    class ChickenCoop
    {

        public static int CountEggs(int number)
        {
            int count = 0;


            while (number > 0)
            {

                if ((number & 1) == 1)
                {
                    count++;
                }

                number >>= 1;
            }

            return count;
        }

        static void Main(string[] args)
        {

            int number1 = 89;
            int number2 = 16;


            Console.WriteLine("Number of eggs in the coop (example 1): " + CountEggs(number1));
            Console.WriteLine("Number of eggs in the coop (example 2): " + CountEggs(number2));
        }
    }
}
