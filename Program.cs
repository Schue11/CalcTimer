
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 800000;
        double [,] numbers;
        Stopwatch timer  =new Stopwatch();

        numbers = GenRandomNumbers(n);

        timer.Restart();
        AddNumbers(numbers, n);
        timer.Stop();

        Console.WriteLine("Additions doubles");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms" + timer.ElapsedTicks + "ticks");

        timer.Restart();
        AddNumbers(numbers, n);
        timer.Stop();

        Console.WriteLine("Additions floats");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms" + timer.ElapsedTicks + "ticks");




        // int i;
        // for (i=0; i<n; ++i){
        //     Console.WriteLine(numbers[i,0] + " " + numbers[i,1] + " " + numbers[i,2]);
        // }
    }

    static double[,] GenRandomNumbers(int count)
    {
        Random rand = new Random();
        double[,] num = new double[count,3];
        for(int i = 0; i<count; ++i){
            num[i,0] = 100.0*rand.NextDouble();
            num[i,1] = 100.0*rand.NextDouble();
        }

        return num;
    }
    
    static void AddNumbers(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i){
            nums[i,2] = nums[i,0] + nums [i,1];
        }
        
    }

     static void AddNumbers(float[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i){
            nums[i,2] = nums[i,0] * nums [i,1];
        }
        
    }
}
