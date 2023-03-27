Console.Clear();
System.Console.WriteLine("Введите числа ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int n =0;
for (int i = 0; i < size.Length; i++)
{
    if(size[i]>0){
        n++;
    }
}
System.Console.WriteLine($"Положительных чисел введенно: {n}");