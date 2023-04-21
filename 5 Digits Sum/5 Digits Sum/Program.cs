// See https://aka.ms/new-console-template for more information

using System;

int num = 34981;
int sum =0;
while (num!=0)
{
    sum +=num % 10;
    num =num / 10;
}
{ 

Console.WriteLine(sum);
}