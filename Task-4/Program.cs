#region 6. Print numbers from 1 to n
Console.WriteLine("Question 6:--> print numbers from 1 to n");
Console.Write("Enter a number: ");
int n6 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n6; i++)
{
    Console.Write(i);
}
Console.WriteLine("\n----------------------------------");
#endregion

#region 7. Multiplication table up to 12
Console.WriteLine("Question 7: --> Multiplication table up to 12");
Console.Write(" Enter a number: "); 
int n7 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 12; i++)
{
    Console.Write(n7 * i + " ");
}
Console.WriteLine("\n----------------------------------");
#endregion

#region 8. Even numbers from 1 to n
Console.WriteLine("Question 8:--> Even numbers from 1 to n");
Console.Write("xEnter a number: ");
int n8 = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= n8; i += 2)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n----------------------------------");
#endregion

#region 9. Power of a number
Console.WriteLine("Question 9 --> Power of a number:");
Console.Write("Enter base number: ");
int baseNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter exponent: ");
int exp = Convert.ToInt32(Console.ReadLine());
int result9 = 1;
for (int i = 0; i < exp; i++)
{
    result9 *= baseNum;
}
Console.WriteLine("Result: " + result9);
Console.WriteLine("----------------------------------");
#endregion

#region 10. Total, Average, Percentage
Console.WriteLine("Question 10:-->Total, Average, Percentage");
int total = 0;
Console.WriteLine("Enter marks of 5 subjects:");
for (int i = 1; i <= 5; i++)
{
    Console.Write("Subject "+ i + ":");
    total += Convert.ToInt32(Console.ReadLine());
}
double average = total / 5.0;
double percentage = (total * 100) / 500;
Console.WriteLine("Total marks = " + total);
Console.WriteLine("Average marks = " + average);
Console.WriteLine("Percentage = " + percentage);
Console.WriteLine("----------------------------------");
#endregion

#region 11. Days in a month
Console.WriteLine("Question 11:-->Days in a month");
Console.Write("Enter month number (1-12): ");
int month = Convert.ToInt32(Console.ReadLine());
int days = 0;
if (month == 2)
    days = 28;
else if (month == 4 || month == 6 || month == 9 || month == 11)
    days = 30;
else if (month >= 1 && month <= 12)
    days = 31;
else
    Console.WriteLine("Invalid month number");

if (days > 0)
    Console.WriteLine("Days in month: " + days);
Console.WriteLine("----------------------------------");
#endregion

#region 12. Simple Calculator
Console.WriteLine("Question 12:--> Simple Calculator");
Console.Write("Enter first number: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter operator (+, -, *, /): ");
char op = Convert.ToChar(Console.ReadLine());
Console.Write("Enter second number: ");
double numB = Convert.ToDouble(Console.ReadLine());
switch (op)
{
    case '+': Console.WriteLine("Result: " + (numA + numB)); break;
    case '-': Console.WriteLine("Result: " + (numA - numB)); break;
    case '*': Console.WriteLine("Result: " + (numA * numB)); break;
    case '/':
        if (numB != 0) Console.WriteLine("Result: " + (numA / numB));
        else Console.WriteLine("Error: Divide by zero");
        break;
    default: Console.WriteLine("Invalid operator"); break;
}
Console.WriteLine("----------------------------------");
#endregion

#region 13. Reverse a string
Console.WriteLine("Question 13:--> Reverse a string");
Console.Write("Enter a string: ");
string input13 = Console.ReadLine();
char[] arr13 = input13.ToCharArray();
Array.Reverse(arr13);
Console.WriteLine("Reversed: " + new string(arr13));
Console.WriteLine("----------------------------------");
#endregion

#region 14. Reverse an integer
Console.WriteLine("Question 14:-->Reverse an integer");
Console.Write("Enter an integer: ");
int num14 = Convert.ToInt32(Console.ReadLine());
int reversed14 = 0;
while (num14 != 0)
{
    int digit = num14 % 10;
    reversed14 = reversed14 * 10 + digit;
    num14 /= 10;
}
Console.WriteLine("Reversed: " + reversed14);
Console.WriteLine("----------------------------------");
#endregion

#region 15. Prime numbers in range
Console.WriteLine("Question 15:-->Prime numbers in range");
Console.Write("Enter start of range: ");
int start15 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter end of range: ");
int end15 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Prime numbers:");
for (int i = start15; i <= end15; i++)
{
    if (i < 2) continue;
    bool isPrime = true;
    for (int j = 2; j * j <= i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime) Console.Write(i + " ");
}
Console.WriteLine("\n----------------------------------");
#endregion

#region 17. Check if 3 points lie on same line
Console.WriteLine("Question 17:-->Check if 3 points lie on same line");
Console.WriteLine("Enter three points (x1, y1), (x2, y2), (x3, y3):");
Console.Write("x1: "); double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1: "); double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2: "); double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2: "); double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("x3: "); double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("y3: "); double y3 = Convert.ToDouble(Console.ReadLine());

bool onSameLine = (y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1);
if (onSameLine)
    Console.WriteLine("The points lie on the same straight line.");
else
    Console.WriteLine("The points do not lie on the same line.");

Console.WriteLine("----------------------------------");
#endregion

#region 18. Worker efficiency
Console.WriteLine("Question 18:-->Worker efficiency");
Console.Write("Enter time taken to complete the task (in hours): ");
double hours = Convert.ToDouble(Console.ReadLine());
if (hours >= 2 && hours <= 3)
    Console.WriteLine("Highly efficient");
else if (hours > 3 && hours <= 4)
    Console.WriteLine("Increase your speed");
else if (hours > 4 && hours <= 5)
    Console.WriteLine("Training required");
else if (hours > 5)
    Console.WriteLine("You are to leave the company");
else
    Console.WriteLine("Invalid input");
Console.WriteLine("----------------------------------");
#endregion
