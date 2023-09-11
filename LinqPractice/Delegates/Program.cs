public delegate void Caculation(int a, int b);
public delegate void Show_Delegate();
public delegate void Calc2(int num);
delegate double calc3(int num);
class Program
{

    public static void Additional(int a, int b)
    {
        int result = a + b;
        Console.WriteLine("Addition Result is : {0}",result);
    }
    public static void Subtraction(int a, int b)
    {
        int result = a - b;
        Console.WriteLine("Subtraction Result is : {0}", result);
    }
    public static void Multiplication(int a, int b)
    {
        int result = a * b;
        Console.WriteLine("Multiplication Result is : {0}", result);
    }
    public static void Division(int a, int b)
    {
        int result = a / b;
        Console.WriteLine("Division Result is : {0}", result);
    }
    public static void Show()
    {
        Console.WriteLine("Show Method");
    }
    public static void Radius(int a)
    {
        Console.WriteLine(3.14 * a * a);
    }
    static void Main(string[] args)
    {
        //Caculation obj = new Caculation(Additional);
        //Caculation obj = Additional;
        //obj.Invoke(1,2);
        //obj = Subtraction;
        //obj.Invoke(3,1);
        //obj = Multiplication;
        //obj.Invoke(4,2);
        //obj = Division;
        //obj.Invoke(6,2);

        Show_Delegate sd = Show;
        sd.Invoke();

        Calc2 cal = Radius;
        cal.Invoke(2);

        calc3 cal2 = x => 3 * x * x;
        Console.WriteLine(cal2(2));

        //MULTI CAST
        Caculation obj = Additional;
        obj += Subtraction;
        obj += Multiplication;
        obj(6, 2);
        Console.ReadLine();

    }
}