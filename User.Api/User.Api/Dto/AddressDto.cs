namespace User.Api.Dto
{
    public class AddressDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string UF { get; set; }
        public string District { get; set; }
        public string Complement { get; set; }
    }
}
