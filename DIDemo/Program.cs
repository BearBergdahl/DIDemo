using DIDemo;

internal class Program
{
    private static void Main(string[] args)
    {
        EnvVar envVar = EnvVar.Test;
        if (envVar == EnvVar.Test)
        {
            IApp dIAppTest = new DIAppTest();
            DIClass implementedClass = new DIClass(dIAppTest);
            implementedClass.PrintMethod();
        }
        if (envVar == EnvVar.Prod)
        {
            IApp diAppProd = new DIAppProd();
            DIClass implementedClass = new DIClass(diAppProd);
            implementedClass.PrintMethod();
            Console.ReadLine();
        }
        
    }

    class DIClass
    {
        private IApp _app;
        public DIClass(IApp app)
        {
            _app = app;
        }
        public void PrintMethod()
        {
            _app.Print();
        }
    }

    enum EnvVar
    {
        Test,
        Prod
    }
}