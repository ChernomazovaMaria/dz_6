// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] a = {{1,4,7,2},{5,9,2,3},{8,4,2,4},{5,2,6,7}};
int min = Int32.MaxValue;
int index = 0;
for (int i=0;i<a.GetLength(0);i++) {
    int sum = 0;
    for (int j=0;j<a.GetLength(1);j++) {
        sum = sum + a[i,j];
        Console.Write("{0}\t",a[i,j]);
    }
    if (sum<min){
        min=sum;
        index=i;
    }
    Console.WriteLine();
}
Console.WriteLine("Строка с минимальной суммой {0}",index+1);