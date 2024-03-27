
namespace tryCatchExample{
    class MainClass{
        public static void Main(String[] args){
            int num1;
            int num2;
            try{
            Console.WriteLine("Enter first number: ");
            // num1 = int.Parse(Console.ReadLine());
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            // num2 = int.Parse(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1/num2;
            Console.WriteLine(result);
            }
            catch(DivideByZeroException ex){
                Console.WriteLine("Cannot divide by zero "+ex.Message);
            }
        }
    }
}