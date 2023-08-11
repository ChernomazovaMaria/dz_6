// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] a = {{1,4,7,2}, {5,9,2,3}, {8,4,2,4}};

for (int i =0;i<a.GetLength(0); i++) {
    for (int j=0;j<a.GetLength(1); j++) {
        for (int k=j;k<a.GetLength(1);k++) {
            if (a[i,j] < a[i,k]) {
                int temp = a[i,j];
                a[i,j] = a[i,k];
                a[i,k] = temp;
            }
        }
        Console.Write("{0}\t",a[i,j]);
    }
    Console.WriteLine();
}