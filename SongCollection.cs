using System.Diagnostics;

namespace Spotivy;

public class SongCollection
{
    public String name;
    public Applicant owner;
    public List<Song> songs;

    private bool isPlaying = false;
    private Song currentSong = null!;

    public SongCollection(String name, Applicant owner, List<Song> songs )
    {
        this.name = name;
        this.owner = owner;
        this.songs = songs;
        owner.SongCollections.Add(this);
    }

    public String Play()
    {
        if (isPlaying)
        {
            return "Song is already playing";
        }
        else
        {
            isPlaying = true;
            currentSong = songs[0];
            return "Playing " + currentSong.name;
        }
    }

    public String Stop()
    {
        if (isPlaying)
        {
            isPlaying = false;
            return "Stopped " + currentSong.name;
        }
        else
        {
            return "Song is not playing";
        }
    }

    public String Pause()
    {
        if (isPlaying)
        {
            isPlaying = false;
            return "Paused " + currentSong.name;
        }
        else
        {
            return "Song is not playing";
        }
    }

    public String Skip()
    {
        if (isPlaying)
        {
            int index = songs.IndexOf(currentSong);
            if (index == songs.Count - 1)
            {
                currentSong = songs[0];
            }
            else
            {
                currentSong = songs[index + 1];
            }
            return "Playing " + currentSong.name;
        }
        else
        {
            return "Song is not playing";
        }

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