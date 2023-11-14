using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    public interface IApp
    {
        void Print();
    }

    public class DIAppProd : IApp
    {
        public void Print() 
        {
            Console.WriteLine("Print ImplementationProd!");
        }
    }

    public class  DIAppTest : IApp
    {
        public void Print()
        {
            Console.WriteLine("Print ImplmentationTest");
        }
    }
}
