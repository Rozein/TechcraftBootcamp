class Program
{
    //delegate double CalAreaPointer(int a);
    //static CalAreaPointer cp = CalculateArea;
    static void Main(string[] args)
    {
        //double area = cp.Invoke(10);
       // CalAreaPointer cpa = new CalAreaPointer(delegate (int r) { return 3.14 * r * r; });
        //Console.WriteLine(cpa(10));

        //CalAreaPointer cpp = r => 3.14 *r *r;
        //Console.WriteLine(cpp(20));
        //Func is delegate that performs certain action and returns a value
        Func<double, double> cp = r => 3.14 * r *r;
        double Area = cp(10);
        Console.WriteLine(Area);

        //Action is delegates that performs certain action and does not return any value.
        //Action for void return
        Action<string> action = y => Console.WriteLine(y);
        action("Test");

        //Predicate is a delegates that performs certain and returns a boolean value.
        //Predicate for checking for some true and false
        Predicate<string> CheckNumberGreaterThan5 =  x  => x.Length > 5;
        Console.WriteLine(CheckNumberGreaterThan5("RozeenNakarmi"));


        // For detail
        List<string> list = new List<string>();
        list.Add("Test");
        list.Add("2");
        list.Add("12345678");
        list.Add("2222232222222222");
        List<string> strName = list.FindAll(CheckNumberGreaterThan5);
        foreach(string str in strName)
        {
            Console.WriteLine(str);
        }
        
        //Console.WriteLine(strName);
    }
    //static double CalculateArea(int r)
    //{
    //    return 3.4 * r * r;
    //}
}