using System.Numerics;

namespace Converting_between_numeric_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao mot so thuc: ");
            string userInput = Console.ReadLine();
            double number;
            bool isValid = double.TryParse(userInput, out number);
            if(isValid ) {
                int intNumber = (int)number;
                long longNumber = (long)number;
                Console.WriteLine($"so ban da nhap {number} o dang so nguyen la {intNumber} va so dai la {longNumber}");
            }
            else
            {
                Console.WriteLine("so ban nhap khong phai so thuc");
            }
        }
    }
}
