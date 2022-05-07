using DecoratorPatternExemplo.Interfaces;

namespace DecoratorPatternExemplo
{
    //Concrete Decorator
    public class CatupiryDecorator : PizzaDecorator
    {
        public CatupiryDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza = pizza += "\r\n com catupiry extra";
            return pizza;
        }
    }
}
