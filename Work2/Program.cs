int a = 22; // работает при a = 2, b = 3, c = 7; а также a = 44, b = 5, c = 78
int b = 3;
int c = 9;

int max = a;

if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine(max);
