﻿// See https://aka.ms/new-console-template for more information
int a = 1;
int b = 4;
int c = 3;
int d = 9;
int e = 6;

int max = a;

if  (a > max) {
   max = a;
}
if (b > max) {
    max = b;
}
if (c > max) {
    max = c;
}
if (d > max) {
    max = d;
}
if (e > max) {
    max = e;
}
Console.Write("Большим числом является ");
Console.WriteLine(max);