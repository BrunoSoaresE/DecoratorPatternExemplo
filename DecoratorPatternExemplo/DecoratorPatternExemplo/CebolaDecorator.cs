using DecoratorPatternExemplo.Interfaces;

namespace DecoratorPatternExemplo
{
    //Concrete Decorator

    public class CebolaDecorator : PizzaDecorator
    {
        public CebolaDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza = pizza += "\r\n com cebola extra";
            return pizza;
        }
    }
}
