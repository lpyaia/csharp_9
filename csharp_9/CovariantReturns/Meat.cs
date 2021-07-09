namespace CovariantReturns
{
    public class Meat : Food
    {
        public decimal Weight { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} - {Weight}";
        }
    }
}