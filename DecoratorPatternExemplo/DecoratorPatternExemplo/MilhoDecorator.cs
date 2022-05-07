using DecoratorPatternExemplo.Interfaces;

namespace DecoratorPatternExemplo
{
    //Concrete Decorator
    public class MilhoDecorator : PizzaDecorator
    {
        public MilhoDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza = pizza += "\r\n com milho extra";
            return pizza;
        }
    }
}
