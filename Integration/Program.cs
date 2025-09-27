namespace Integration
{
    public class Program
    {
        public static decimal? Div(decimal number1, decimal number2)
        {
            try
            {
                return number1 / number2;
            }
            catch (Exception)
            {
                return null;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Div(10, 5));
        }
    }

}
