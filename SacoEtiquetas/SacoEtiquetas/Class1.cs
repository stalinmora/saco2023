using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacoEtiquetas
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }

    public interface IAbstractProductA
    {
        string UseFulFunctionA();
    }

    public interface IAbstractProductB
    {
        string UseFulFunctionB();
        string AnotherUserFulFunctionB(IAbstractProductA collaborator);
    }

    class ConcreteProductA1 : IAbstractProductA
    {
        public string UseFulFunctionA()
        {
            return "The result od the Product A1.";
        }
    }

    class ConcreteProductA2 : IAbstractProductA
    {
        public string UseFulFunctionA()
        {
            return "The result od the Product A2.";
        }
    }

    class ConcreteProductB1 : IAbstractProductB
    {
        public string AnotherUserFulFunctionB(IAbstractProductA collaborator)
        {
            throw new NotImplementedException();
        }

        public string UseFulFunctionB()
        {
            throw new NotImplementedException();
        }
    }

    class ConcreteProductB2 : IAbstractProductB
    {
        public string AnotherUserFulFunctionB(IAbstractProductA collaborator)
        {
            throw new NotImplementedException();
        }

        public string UseFulFunctionB()
        {
            return "The result od the product B2.";
        }
    }

    class CconcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
    class CconcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }

    }
}