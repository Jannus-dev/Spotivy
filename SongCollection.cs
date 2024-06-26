using System.Diagnostics;

namespace Spotivy;

public class SongCollection
{
    public String name;
    public Applicant owner;
    public List<Song> songs;

    protected SongCollection(String name, Applicant owner, List<Song> songs )
    {
        this.name = name;
        this.owner = owner;
        this.songs = songs;
        owner.SongCollections.Add(this);
    }

    public String Play()
    {

        return null;
    }

    public String Stop()
    {

        return null;
    }

    public String Pause()
    {

        return null;
    }

    public String Skip()
    {

        return null;
    }

    public void AddToPlaylist(Playlist playlist)
    {
        foreach (var song in songs)
        {
            playlist.AddSong(song);
        }
    }

    public List<String> GetSongs()
    {
        List<String> songsNames = new List<String>();
        foreach (var song in songs)
        {
            songsNames.Add(song.name);
        }

        return songsNames;
    }

}