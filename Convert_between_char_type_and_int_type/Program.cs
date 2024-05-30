using System.Text;

namespace Convert_between_char_type_and_int_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("vui lòng nhập vào một ký tự: ");
            char userInput = Console.ReadKey().KeyChar;
            int asciiCode = (int)userInput;
            Console.WriteLine($"ký tự bạn nhập {userInput}, mã ASCII của nó là {asciiCode} ");

        }
    }
}
