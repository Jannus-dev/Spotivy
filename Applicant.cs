namespace Spotivy;

public class Applicant(string name)
{
    public String name = name;
    public List<SongCollection> SongCollections { get; set; } = new List<SongCollection>();
    
    public void AddSongCollection(SongCollection songCollection)
    {
        SongCollections.Add(songCollection);
    }
    
    public void ShowSongCollections()
    {
        foreach (var songCollection in SongCollections)
        {

        }
    }
}