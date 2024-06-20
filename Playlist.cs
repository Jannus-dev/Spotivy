namespace Spotivy;

public class Playlist: SongCollection
{
    
    public void AddSong(Song song)
    {
        this.songs.Add(song);
    }
    
    public void RemoveSong(Song song)
    {
        
    }
    
    public Playlist Copy()
    {
        return null;
    }
}