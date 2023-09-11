class parent
{
    public virtual void print()
    {
        Console.WriteLine("This is method of PARENT class");
    }
}
class child : parent
{
    public override void print()
    {
        //Console.WriteLine("This is method of CHILD class");
        base.print();
    }
}
class Program
{

    static void Main(string[] args)
    {
        //child c = new child();
        //c.print();
        //Console.ReadLine();

        parent p = new child();
        p.print();
        Console.ReadLine();
    }

}