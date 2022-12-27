using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program6
{
    class Program
    {
        static void Program.Main(string[] args);
        
        long[] cubes_array = new long[30];

        for (int i = 0; i < 30; i++)
            cubes_array[i] = Cube(i + 5);
        string[][] array = new string[30][];

        for (int i = 0; i< 30; i++)
            Array[i] = cubes_array[i].ToString().Split();

        for (int i = 0; i < Array.Length; i++)
            {
            for (int j = int + 1; j < Array.Length; j++)
            {
            for (int e = j + 1; e < Array.Length; e++)
            {
            if ((Array[i] == Array[j]) && (Arr[j] == Array[e]))

             Console.WriteLine("Наименьший куб,перестановки цифр которого дают три куба: ",
            cubes_array[i]);
            }
}
}
Console.ReadLine();
}

static int Cube(int num)
{
    int Cube = num;
    int i = 1;
    for (i = 1; i < 3; i++)
        Cube *= num;
    return (Cube);
}

}
}













