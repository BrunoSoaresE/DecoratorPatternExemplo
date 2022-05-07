using DecoratorPatternExemplo.Interfaces;

namespace DecoratorPatternExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            // PIZZA NORMAL
            IPizza pizza = new Pizza();
            Console.WriteLine("----PIZZA NORMAL----");
            Console.WriteLine(pizza.BuscarTipoPizza());

            // PIZZA NORMAL COM CATUPIRY 
            pizza = new Pizza();
            pizza = new CatupiryDecorator(pizza);
            Console.WriteLine("\r\n----PIZZA COM CATUPIRY----");
            Console.WriteLine(pizza.BuscarTipoPizza());


            // PIZZA NORMAL COM TODOS OS EXTRAS
            pizza = new Pizza();
            pizza = new CebolaDecorator(pizza);
            pizza = new MilhoDecorator(pizza);
            pizza = new BaconDecorator(pizza);
            pizza = new CatupiryDecorator(pizza);
            Console.WriteLine("\r\n----PIZZA COM TODOS OS EXTRAS----");
            Console.WriteLine(pizza.BuscarTipoPizza());



            // PIZZA NORMAL COM 4x bacon
            pizza = new Pizza();
            pizza = new BaconDecorator(pizza);
            pizza = new BaconDecorator(pizza);
            pizza = new BaconDecorator(pizza);
            pizza = new BaconDecorator(pizza);
            Console.WriteLine("\r\n----PIZZA COM 4X BACON----");
            Console.WriteLine(pizza.BuscarTipoPizza());


        }
    }
}
