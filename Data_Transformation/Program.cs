using System.Text;

namespace Data_Transformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập vào một số nguyên: ");
            string userInput = Console.ReadLine();
            int number;
            bool isValid = int.TryParse(userInput, out number);
            if(isValid )
            {
                double doublelNumber = (double)number;
                Console.WriteLine($"số bạn đã nhập {number} và ở dạng kép là {doublelNumber}");
            }
            else
            {
                Console.WriteLine("số đã nhập không phải số nguyên");
            }
        }
    }
}
