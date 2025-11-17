namespace Survey.Api.Requests
{
    public class UpdateServiceRequest
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
    }
}
