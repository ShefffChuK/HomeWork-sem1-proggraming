int a = 22; // работает при a = 5, b = 7; а также a = 2, b = 10
int b = 3;
int c = 9;

int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine(max);
