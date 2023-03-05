int n = 2346; 

int digit1 = n / 1000; 
int digit2 = (n / 100) % 10; 
int digit3 = (n / 10) % 10; 
int digit4 = n % 10; 

if (digit1 != 0 && n % digit1 == 0 && n % digit2 == 0 && n % digit3 == 0 && n % digit4 == 0)
{
    Console.WriteLine("YES"); 
}
else
{
    Console.WriteLine("NO"); 
}
