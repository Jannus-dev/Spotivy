using System.Diagnostics;

namespace Spotivy;

public class SongCollection(String name, Applicant owner, List<Song> songs)
{
    public String name = name;
    public Applicant owner = owner;
    public List<Song> songs = songs;

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