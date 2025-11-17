using Survey.Domain.Entities.Services;

namespace Survey.Domain.Entities
{
    public class Client
    {
        public Guid Id { get; private set; }
        public string? Name { get; private set; }
        public string? Bio { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Client()
        {
        }

        public Client(Guid id, string? name, string? bio, DateTime createdAt)
        {
            Id = id;
            Name = name;
            Bio = bio;
            CreatedAt = createdAt;
        }

        public static Client Create(string name, string? description)
        {
            return new Client(
                Guid.NewGuid(),
                name,
                description,
                DateTime.UtcNow
            );
        }

        public void Update(string name, string? bio)
        {
            Name = name;
            Bio = bio;
        }
    }
}
