//Fixed Code
using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main()
    {
        int n = 800000;
        double [,] numbers;
        float[,] numb;
        Stopwatch timer  =new Stopwatch();

        numbers = GenRandomNumbers(n);
        numb = new float[n,3];

        for(int i = 0; i<n; ++i){

            numb[i,0] = (float)numbers[i,0];
            numb[i,1] = (float)numbers[i,1];
        }

        timer.Restart();
        AddNumbers(numbers, n);
        timer.Stop();

        Console.WriteLine("Additions doubles");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms" + timer.ElapsedTicks + "ticks");
        float addTicks = (float)timer.ElapsedTicks;


        timer.Restart();
        AddNumbers(numb, n);
        timer.Stop();

        Console.WriteLine("Additions floats");
        Console.WriteLine("Elapsed Time = " + timer.ElapsedMilliseconds + " ms" + timer.ElapsedTicks + "ticks");
        double adTicks = (double)timer.ElapsedTicks;
        Console.WriteLine("Ratio = " + addTicks/adTicks);

        timer.Restart();
        SquareMultiply(numbers, n);
        timer.Stop();

        Console.WriteLine("Squaring by multiplication");
        Console.WriteLine("Elapsed time = "+ timer.ElapsedMilliseconds + "ms" + timer.ElapsedTicks + "ticks");
        int Squared = (int)timer.ElapsedTicks;
        Console.WriteLine("Ratio = "+ addTicks/Squared);

        timer.Restart();
        Sq(numbers,n);
        timer.Stop();
        Console.WriteLine("Squaring function");
        Console.WriteLine("Elapsed time = " + timer.ElapsedMilliseconds + "ms" + timer.ElapsedTicks + "ticks");
        int SquareMath = (int)timer.ElapsedTicks;
        Console.WriteLine("Ratio = " + addTicks/SquareMath);


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

    static void SquareMultiply(double[,] nums,int count)
    {
        int i;
        for(i=0; i<count; ++i){
            nums[i,2] = nums[i,1] * nums [i,1];
    }
    }
    
    static void Sq(double[,] nums, int count)
    {
        int i;
        for(i=0; i<count; ++i){
            nums[i,2] = Math.Pow(nums[i,0],nums[i,1]);

        }
    }
}


