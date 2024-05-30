using System.Text;

namespace MaxOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("vui lòng nhập kích thước của mảng: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("vui lòng nhập các phần tử của mảng: ");
            for(int i = 0; i< size; i++)
            {
                Console.WriteLine($"phần tử thứ {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int max = array[0];
            for(int i = 0; i< size; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("phần tử lớn nhất của mảng là: " + max);
        }
    }
}
