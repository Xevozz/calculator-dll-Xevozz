namespace CalculatorClassLibrary
{
    public class Class1
    {
        static void Main(string[] args)
        {
            // Display a welcome message for the calculator
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-----------------");

            // indtast første nummer
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine()); // konvertere første tal angivet til decimaltal

            // beder brugere indtaste en af 4 værdier (+, -, *, /)
            Console.Write("Enter an operator (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar; // læser det angivet tegn
            Console.WriteLine(); // bevæger sig til næste linje

            // beder brugeren indtaste tal nr. 2 som skal +, -, * eller /
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine()); // konventere tallet til en double

            // angiver slutresultatet
            double result = 0;
            
            //bruger en Switch-statement til at basere operationen, angivet af tegn angivet +, -, * eller /
            switch (op)
            {
                case '+':
                    result = num1 + num2; // plusser tallene
                    break;
                case '-':
                    result = num1 - num2; // fratrækker tallene
                    break;
                case '*':
                    result = num1 * num2; // ganger tallene
                    break;
                case '/':
                    // checker om nr. 2 tal angivet ikke er 0
                    if (num2 != 0)
                        result = num1 / num2; //ganger tallene
                    else
                        Console.WriteLine("Fejl: Du kan ikke dividere med 0.");
                    break;
                
                //Reaktion hvis en af 4 operatorer ikke indtastes, andet end +, -, * eller /
                default:
                    //hvis forkert operator er angivet, andet end +, -, * eller /.
                    Console.WriteLine("fejl: forkert tegn indtastet.");
                    return; // luk programmet hvis forkert operator er angivet, andet end +, -, * eller /.
            }

            // viser slutresultatet.
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
        }
    }
}