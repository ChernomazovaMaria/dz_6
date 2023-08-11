// Заполните спирально массив 4 на 4 числами от 1 до 16.
int[,] array =new int[4,4];
int elementValue = 1;
int dimension = array.GetLength(0);

for (int i = 0; i < dimension; i++) {
    array[0, i] = elementValue;
    elementValue++;
}
for (int j = 1; j < dimension; j++) {
    array[j, dimension - 1] = elementValue;
    elementValue++;
}
for (int i = dimension - 2; i >= 0; i--) {
    array[dimension - 1, i] = elementValue;
    elementValue++;
}
for (int j = dimension - 2; j > 0; j--) {
    array[j, 0] = elementValue;
    elementValue++;
}

int iIndex = 1;
int jIndex = 1;

while (elementValue < dimension * dimension) {
    while (array[iIndex, jIndex + 1] == 0) {
        array[iIndex, jIndex] = elementValue;
        elementValue++;
        jIndex++;
    }
    while (array[iIndex + 1, jIndex] == 0) {
        array[iIndex, jIndex] = elementValue;
        elementValue++;
        iIndex++;
    }
    while (array[iIndex, jIndex - 1] == 0) {
        array[iIndex, jIndex] = elementValue;
        elementValue++;
        jIndex--;
    }
    while (array[iIndex - 1, jIndex] == 0) {
        array[iIndex, jIndex] = elementValue;
        elementValue++;
        iIndex--;
    }
}
for (int i = 0; i < dimension; i++) {
    for (int j = 0; j < dimension; j++) {
        if (array[i, j] == 0)
            array[i, j] = elementValue;
        Console.Write("{0}\t",array[i,j].ToString("D2"));
    }
    Console.WriteLine();
}