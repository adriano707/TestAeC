namespace User.Domain.Entities
{
    public class Phone
    {
        public int Id { get; private set; }
        public string DDD { get; private set; }
        public string Number { get; private set; }

        public Phone() { }

        public Phone(string ddd, string number)
        {
            DDD = ddd ?? throw new ArgumentNullException(nameof(ddd));
            Number = number ?? throw new ArgumentNullException(nameof(number));
        }

        public void Update(string ddd, string number)
        {
            DDD = ddd;
            Number = number;
        }
    }
}
