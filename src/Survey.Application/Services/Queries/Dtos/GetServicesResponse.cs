namespace Survey.Application.Services.Queries.Dtos
{
    public sealed class GetServicesResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
