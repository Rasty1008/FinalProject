using static System.Console;

Clear();
string[] firstArray = new string[5] {"Hello", "-2", ":-)", "step", "43"};
string[] secArray = new string[firstArray.Length];

ResultArray(firstArray, secArray);
PrintArray(secArray);

void ResultArray(string[] array1, string[] array2) {
    int count = 0;
    for (int i = 0; i < array1.Length; i++) {
        if(array1[i].Length <= 3) {
            array2[count] = array1[i];
            count++;
        }
    }
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}
