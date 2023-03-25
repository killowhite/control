string[] array1 = new string[5] {"10" , "no" , "100" , "hello" , "world"};
string[] array2 = new string[array1.Length];
void SecondArrayWithIf(string[] array1,string[] array2)
{
    int count = 0;
    for( int i = 0; 1 < array.Length; i++)
    {
        if(array[i].Length <=3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
