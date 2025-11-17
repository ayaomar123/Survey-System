namespace Survey.Application.Clients.Queries.Dtos
{
    public class GetClientsResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Bio { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
