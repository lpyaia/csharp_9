namespace CovariantReturns
{
    public class Tiger : Animal
    {
        public override Meat GetFood()
        {
            return new Meat { Name = "Meat", Weight = 10.5m };
        }
    }
}