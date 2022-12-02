namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enteredNumbers = "";
            int choice = 0;
            Calculator();

            void Calculator()
            {
                AritmeticOperators();
            }

            void AritmeticOperators()
            {
                try
                {
                    Console.WriteLine("Wprowadz algorytm ( Warość operator wartość ) ");
                    Console.WriteLine("gdzie operatorem może być: + , - , * , / , % , < , > , <= , >= , == , != , >> , << , & , | , ^ \n");
                    enteredNumbers = Console.ReadLine();

                    string[] subs = enteredNumbers.Split(' ');
                    double[] numbers =  new double[10];
                    string[] operators = new string[10];
                    int num = 0;
                    int op = 0;

                    for (int i = 0; i < subs.Length; i++)
                    {

                        if(i % 2 == 0)
                        {
                            bool succes = double.TryParse(subs[i], out numbers[num]);
                            if(succes == false)
                            {
                                Console.WriteLine("Podana wartość została wprowadzona nie prawidłowo, dla bezpieczeństwa misji zacznij od nowa\n");
                            }
                            num++;
                        }
                        if(i % 2 == 1)
                        {
                            operators[op] = subs[i];
                            op++;
                        }
                    }
                    int binarResult = 0;
                    double result = 0;
                    bool boolResult = true;

                    switch (operators[0])
                    {
                        case "+": result = numbers[0] + numbers[1]; Console.Write($"{numbers[0]} + {numbers[1]} = {result}\n\n"); Calculator(); break;
                        case "-": result = numbers[0] - numbers[1]; Console.Write($"{numbers[0]} - {numbers[1]} = {result}\n\n"); Calculator(); break;
                        case "*": result = numbers[0] * numbers[1]; Console.Write($"{numbers[0]} * {numbers[1]} = {result}\n\n"); Calculator(); break;
                        case "/": result = numbers[0] * numbers[1]; Console.Write($"{numbers[0]} / {numbers[1]} = {result}\n\n"); Calculator(); break;
                        case "%": result = numbers[0] % numbers[1]; Console.Write($"{numbers[0]} % {numbers[1]} = {result}\n\n"); Calculator(); break;
                        case "<": boolResult = numbers[0] < numbers[1]; Console.Write($"{numbers[0]} < {numbers[1]} = {boolResult}\n\n"); Calculator(); break;
                        case ">": boolResult = numbers[0] > numbers[1]; Console.Write($"{numbers[0]} > {numbers[1]} = {boolResult}\n\n"); Calculator(); break;
                        case "<=": boolResult = numbers[0] <= numbers[1]; Console.Write($"{numbers[0]} <=  {numbers[1]} = {boolResult}\n\n"); Calculator(); break;
                        case ">=": boolResult = numbers[0] >= numbers[1]; Console.Write($"{numbers[0]} >= {numbers[1]} = {boolResult}\n\n"); Calculator(); break;
                        case "==": boolResult = numbers[0] == numbers[1]; Console.Write($"{numbers[0]} == {numbers[1]} = {boolResult}\n\n"); Calculator(); break;
                        case "!=": boolResult = numbers[0] != numbers[1]; Console.Write($"{numbers[0]} != {numbers[1]} = {boolResult}\n\n"); Calculator(); break;
                        case ">>": binarResult = (int)numbers[0] >> (int)numbers[1]; Console.Write($"{numbers[0]} >> {numbers[1]} = {binarResult}\n\n"); Calculator(); break;
                        case "<<": binarResult = (int)numbers[0] << (int)numbers[1]; Console.Write($"{numbers[0]} << {numbers[1]} = {binarResult}\n\n"); Calculator(); break;
                        case "&": binarResult = (int)numbers[0] & (int)numbers[1]; Console.Write($"{numbers[0]} & {numbers[1]} = {binarResult}\n\n"); Calculator(); break;
                        case "|": binarResult = (int)numbers[0] | (int)numbers[1]; Console.Write($"{numbers[0]} | {numbers[1]} = {binarResult}\n\n"); Calculator(); break;
                        case "^": binarResult = (int)numbers[0] ^ (int)numbers[1]; Console.Write($"{numbers[0]} ^ {numbers[1]} = {binarResult}\n\n"); Calculator(); break;
                    }

                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Nie możesz dzielić przez zero, zacznij od nowa\n");
                    AritmeticOperators();
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Wprowadzono nie wszystkie części równania, spróbuj jeszcze raz.\n");
                    AritmeticOperators();
                }
            }
        }
    }
}