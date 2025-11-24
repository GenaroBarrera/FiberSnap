namespace FiberSnap.Core.Domain;

public enum VaultStatus
{
    NotStarted,
    Green,  // Complete, all required photos present & valid
    Yellow, // Incomplete, missing required photos
    Red     // Incorrect, photos do not meet standards
}

public class Vault
{
    public int Id { get; set; }
    public int ProjectId { get; set; }

    public string VaultName { get; set; } = string.Empty; // e.g., V-1234
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public VaultStatus Status { get; set; } = VaultStatus.NotStarted;

    public ICollection<Photo> Photos { get; set; } = new List<Photo>();
}
