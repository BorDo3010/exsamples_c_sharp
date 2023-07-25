int[] array = { 5, 7, 3, 5, 6, 7, 1, 9, 2 };

int sum;
sum = 0; 
for (int i = 0; i < array.Length; i = i + 1)
{
   sum = sum + array[i];
}


Console.WriteLine(sum);