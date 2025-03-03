namespace tech_lab1_task2
{

    public class Logic
    { 
         public static double[] Search(List<double> numbers)
        {
            if (numbers.Count < 4)
            {
                return null;
            }

            double[] result = new double[4];
            List<double> sortedNumbers = numbers.OrderBy(n => n).ToList();

            result[0] = sortedNumbers[sortedNumbers.Count - 1]; 
            result[1] = sortedNumbers[sortedNumbers.Count - 2]; 
            result[2] = sortedNumbers[0]; 
            result[3] = sortedNumbers[1]; 

            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNumber;
            var numbers = new List<double>();

            while (true)
            {
                Console.WriteLine("Введите число либо нажмите Enter, чтобы завершить ввод чисел: ");
                inputNumber = Console.ReadLine();
                if (string.IsNullOrEmpty(inputNumber))
                {
                    break;
                }
                numbers.Add(double.Parse(inputNumber));
            }

            double[] result = Logic.Search(numbers);

            if (result == null)
            {
                Console.WriteLine("Необходимо ввести не менее четырех чисел.");
            }
            else
            {
                Console.WriteLine("Наибольшее число: " + result[0]);
                Console.WriteLine("Второе наибольшее число: " + result[1]);
                Console.WriteLine("Наименьшее число: " + result[2]);
                Console.WriteLine("Второе наименьшее число: " + result[3]);
            }
            Console.ReadLine();
        }
    }
}
