using System;
public class Kata
{
    public static void Main(string[] args)
    {
        string str = "Indivisibilities";
        Console.WriteLine(DuplicateCount(str));
    }
    public static int DuplicateCount(string str)
    {
        int count = 0;
        char[] arr = new char[str.Length];
        str = str.ToLower();
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (str[i] == str[j] && i != j)
                {
                    count++;
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (arr[k] == 0)
                        {
                            arr[k] = str[i]; 
                            break;
                        }
                        else if (arr[k] == str[i])
                        {
                            count--; 
                            break;
                        }
                    }
                    break;
                }
            }    
        }
        return count;
    }
}