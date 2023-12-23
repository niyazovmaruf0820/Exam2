

using System.Security.Cryptography.X509Certificates;

Math math = new Math();
System.Console.WriteLine(math.Abs(-1.4));
System.Console.WriteLine(math.Sqrtt(0.25));

class Math{
    public double PI = 3.14;
    const double E = 2.71;
    public double Abs(double value)
    {
        if (value < 0)
        return value * (-1);
        else return value;
    }
    public float Abs(float value){
        return value * (-1);
    }
    public int Abs(int value){
        return value * (-1);
    }
    
    public int Max(int val1, int val2){
        if (val1 > val2) return val1;
        else return val2;
    }

    public int Min(int val1, int val2){
         if (val1 < val2) return val1;
        else return val2;
    }
    public double Pow(double x, double y)
    {
       for (double i = 1; i < y; i++)
       {
        x = x * x;
       }
       return x;
    }
    public double Sqrtt(double d){
        return Math.Sqrt(d);
    }
}

