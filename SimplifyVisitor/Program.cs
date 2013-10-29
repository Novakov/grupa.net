using System;

namespace SimplifyVisitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var visitor = new ConcreteVisitor();

            visitor.Dispatch(new ConstantNode());
            visitor.Dispatch(new PlusNode());
            visitor.Dispatch(new MinusNode());

            Console.ReadLine();
        }
    }
}
