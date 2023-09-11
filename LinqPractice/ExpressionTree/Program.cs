using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Add,
            Expression.Constant(20),
            Expression.Constant(15));

        BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Add,
           Expression.Constant(2),
           Expression.Constant(5));

        BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract,
          b1,
          b2);

        int result = Expression.Lambda<Func<int>>(b3).Compile()();

        Console.WriteLine(result);
    }
}