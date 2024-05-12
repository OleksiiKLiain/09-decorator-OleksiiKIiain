namespace Pizza
{

    public interface IPizza
    {
        string GetDescription();
        double GetCost();
    }
    public class BasicPizza : IPizza
    {
        public string GetDescription()
        {
            return "Basic Pizza";
        }

        public double GetCost()
        {
            return 5.0; 
        }
    }

    public class CheeseDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public CheeseDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetDescription()
        {
            return _pizza.GetDescription() + ", Cheese";
        }

        public double GetCost()
        {
            return _pizza.GetCost() + 1.0; 
        }
    }

    public class PepperoniDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PepperoniDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string GetDescription()
        {
            return _pizza.GetDescription() + ", Pepperoni";
        }

        public double GetCost()
        {
            return _pizza.GetCost() + 1.5; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPizza basicPizza = new BasicPizza();

            IPizza cheesePizza = new CheeseDecorator(basicPizza);

            IPizza pepperoniPizza = new PepperoniDecorator(cheesePizza);

            Console.WriteLine("Description: " + pepperoniPizza.GetDescription());
            Console.WriteLine("Cost: $" + pepperoniPizza.GetCost());

        }
    }

}
