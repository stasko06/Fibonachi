static int Fibonachi (int n)
{
    int[] a = new int[n];
    a[0] = 0;
    a[1] = 1;
    for (int i = 2; i<a.Length; i++)
    {
        a[i] = a[i-1] + a[i-2];

    }
    return a[n];
}
int n = int.Parse(Console.ReadLine());
Console.WriteLine(Fibonachi(n));
