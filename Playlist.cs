namespace Spotivy;

public class Playlist(string name, Applicant owner, List<Song> songs) : SongCollection(name, owner, songs){

    public void AddSong(Song song)
    {
        this.songs.Add(song);
    }
    
    public void RemoveSong(Song song)
    {
        this.songs.Remove(song);
    }
    
    public Playlist Copy()
    {
        return null;
    }
}