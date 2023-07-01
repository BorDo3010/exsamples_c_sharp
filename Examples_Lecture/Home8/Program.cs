Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
int j=0;
int[] numbers = new int[N-1]; 
Console.WriteLine("Четные значения в диапазоне от 1 до N: ");
while(i<=N && j<(N-1)) 
{
    if(i%2 == 0)
    {
        numbers[j]=i; 
        
        Console.Write($"{numbers[j]}; ");       
    }
    i++;
    j++;    
}