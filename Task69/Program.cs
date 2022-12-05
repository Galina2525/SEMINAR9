// Напишите программу, которая на вход принимает два числа А и В, и возводит
// число А в целую степень В с помощью рекурсии.
//A = 3; В = 5 -> 243
//A = 2; В = 3 -> 8
int Proizv(int a, int b)
{
    int res = 1;
    for(int i = 1; i <= b; i++) res = res*a;
    return res;
}

int ProizvRek(int a, int b)
{
    if(b==0) return 1;
    else return a * ProizvRek(a, b -1);

}
Console.WriteLine(Proizv(3,5));
Console.WriteLine(ProizvRek(3,5));