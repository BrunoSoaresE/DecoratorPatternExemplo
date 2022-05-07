using DecoratorPatternExemplo.Interfaces;

namespace DecoratorPatternExemplo
{
    //Concrete Decorator
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza = pizza += "\r\n com bacon extra";
            return pizza;
        }
    }
}
