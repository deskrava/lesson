﻿int a = 1;
int b = 2;
int c = 4;
int d = 7;
int e = 9;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Max = ");
Console.WriteLine(max);