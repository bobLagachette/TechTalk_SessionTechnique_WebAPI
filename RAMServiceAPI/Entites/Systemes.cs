namespace RAMServiceAPI.Entites
{
    public record Systemes
    {
        public int Id { get; init; }

        public string Nom { get; init; }

        public string CAO { get; set; }

        public List<string> Developpeurs { get; set; }

    }
}
