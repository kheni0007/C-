using System.Text;
using System;
using System.Collections;

class GenerateRandomString
{
    static void Main()
    {
        //bubble sort

        GenerateRandomString arr = new GenerateRandomString();

        // arr.Add(Randomstring());

        // creating a StringBuilder object()
        //  System.Console.WriteLine(str_build.ToString());
        Randomstring();
        sortStrings(Randomstring());

       // Randomstring(sortStrings());
       //sortStrings(Randomstring());


       
        // InsertionSort();

        Console.ReadLine();

    }
    public static string[] Randomstring()

    {
        // int length = 10;
        //StringBuilder str_build = new StringBuilder();

        Random random = new Random();
        int num_words = 10;
        int num_letters = 10;
        char letter;
        ; string[] StringList = new string[10];
        for (int i = 0; i < num_words; i++)
        {
            StringBuilder str_build = new StringBuilder();

            for (int j = 0; j < num_letters; j++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25.999999999 * flt));
                letter = Convert.ToChar(shift + 97);
                str_build.Append(letter);
            }

            StringList[i] = str_build.ToString();
            Console.WriteLine(StringList[i]);
        }
        return StringList;
    }
    public static void sortStrings(string[] arr)

    {
        String[] stg = new string[12];
        String temp;
        // Sorting strings using bubble sort 
        for (int j = 0; j < arr.Length - 1; j++)
        {
            string[] str = new string[50];
            for (int i = j + 1; i < arr.Length; i++)
            {
                if (arr[j].CompareTo(arr[i]) > 0)
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    Console.WriteLine("I changed: " + temp);
                }
            }
        }
        foreach (var element in stg)
        {
            Console.WriteLine("enter"+ element);
        }
        
    }
   
    
}




