namespace CalculatorClassLibrary
{
    public class Class1
    {
        static void Main(string[] args)
        {
            // viser en velkomst-besked
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
            double num2 = Convert.ToDouble(Console.ReadLine()); // konvertere tallet til en double

            // angiver slutresultatet
            double result = 0;
            
            //bruger en if-statement til at basere operationen = op, angivet af tegn angivet +, -, * eller /
            if (op == '+')
            {
                result = num1 + num2;
            }
            else if (op == '-')
            {
                result = num1 - num2;
            }
            else if (op == '*')
            {
                result = num1 * num2;
            }
            else if (op == '/')
            { 
                if (num2 != 0)
                    result = num1 / num2;
                else
                        Console.WriteLine("Fejl: Du kan ikke dividere med 0.");
            }
            else
            {
                //Reaktion hvis en af 4 operatorer ikke indtastes, andet end +, -, * eller /
                //hvis forkert operator er angivet, andet end +, -, * eller /.
                Console.WriteLine("fejl: forkert tegn indtastet.");
                    return; // luk programmet hvis forkert operator er angivet, andet end +, -, * eller /.
            }
            
            if (op == '+' || op == '-' || op == '*' || (op == '/' && num2 != 0))
            {
                Console.WriteLine($"Resultat: {num1} {op} {num2} = {result}");
            }

            // viser slutresultatet.
            Console.WriteLine($"Resultat: {num1} {op} {num2} = {result}");
        }
    }
}