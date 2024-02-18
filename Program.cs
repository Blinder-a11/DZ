using System.Globalization;
// задача 1

int M = 1;
int N = 5;

void natch(int M, int N)
{
if (M < N+1)
{
Console.Write(M != N ? $"{M}," : $"{M}");
natch(M+1,N);
}
}
natch(M,N);
Console.Write("\n");

// задача 2


uint m = 3;
uint n = 2;
static uint A(uint m, uint n) {
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return A(m - 1, 1);
    else return A(m - 1, A(m, n - 1));
}
Console.Write(A(m, n));
Console.Write("\n");

// задача 3

int[] arrayNum = {9,8,7,6,5,4,3,2,1};
int size = arrayNum.Length;
void Reverse(int[] arrayNum, int size){
    if( size != 0 ){
        Console.Write(arrayNum[size-1] + " ");
        Reverse(arrayNum, size-1);
    }

}
Reverse(arrayNum, size);


