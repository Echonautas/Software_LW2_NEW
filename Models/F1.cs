namespace Software.Design.Models;

public class F1
{
    public F1()
    {
    }
    public F1(F1DTO f1DTO)
    {
        Name = f1DTO.Name;
        WorldChampionships = f1DTO.WorldChampionships;
        Country = f1DTO.Country;
        TeamId = f1DTO.TeamId;
    }
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public int WorldChampionships { get; set; }
    public string Country { get; set; } = default!;
    public int TeamId { get; set; }
}


