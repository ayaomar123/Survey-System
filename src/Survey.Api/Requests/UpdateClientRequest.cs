namespace Survey.Api.Requests
{
    public class UpdateClientRequest
    {
        public string Name { get; set; } = default!;
        public string? Bio { get; set; }
    }
}
