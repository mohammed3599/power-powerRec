using System.Threading.Channels;

namespace power
{
    internal class Program
    {
       
        static int power( int number, int pow)
        {
            int value = number;
            for(int i = 2; i <= pow;i++)
            {
                value = value * number;
            }
            return value;
        }
       static int powerRec(int num, int pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            if (pow == 1) 
            {
                return num;
            }
            return num * powerRec(num,pow-1);
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number to get its Power: ");
            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("The Power "+y+" to "+x+" is: " + powerRec(x,y));
        }
    }
}