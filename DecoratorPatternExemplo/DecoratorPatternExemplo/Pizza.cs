using DecoratorPatternExemplo.Interfaces;

namespace DecoratorPatternExemplo
{
    public class Pizza: IPizza
    {
        public string BuscarTipoPizza()
        {
            var pizza = "Pizza comum";
            return pizza;
        }
    }
}
