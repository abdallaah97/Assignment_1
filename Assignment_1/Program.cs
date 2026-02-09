//Switch
Console.WriteLine("Enter number 1 : ");
double num_1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number 2 : ");
double num_2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the operator : ");
char @operator = Convert.ToChar(Console.ReadLine());

switch (@operator)
{
    case '+':
        Console.WriteLine($"The result of opertor {@operator} for {num_1} and {num_2} is : {num_1 + num_2}");
        break;

    case '-':
        Console.WriteLine($"The result of opertor {@operator} for {num_1} and {num_2} is : {num_1 - num_2}");
        break;

    case '*':
        Console.WriteLine($"The result of opertor {@operator} for {num_1} and {num_2} is : {num_1 * num_2}");
        break;

    case '/':
        Console.WriteLine($"The result of opertor {@operator} for {num_1} and {num_2} is : {num_1 / num_2}");
        break;

    default:
        Console.WriteLine($"Invalid operator");
        break;
}


//new change from github
