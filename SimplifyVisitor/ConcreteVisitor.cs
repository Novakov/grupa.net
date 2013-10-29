using System;

namespace SimplifyVisitor
{
    public class ConcreteVisitor : VisitorBase
    {
        private void Visit(ConstantNode node)
        {
            Console.WriteLine("Visiting constant node");
        }

        private void Visit(PlusNode node)
        {
            Console.WriteLine("Visiting plus node");
        }

        private void Visit(MinusNode node)
        {
            Console.WriteLine("Visiting minus node");
        }
    }
}