namespace FCManager.Domain.Entities
{
    public class Contract
    {
        public Guid Id { get; private set; }
        public DateOnly StartDate { get; private set; }
        public DateOnly EndDate { get; private set; }
        public decimal Salary { get; private set; }
    }
}
