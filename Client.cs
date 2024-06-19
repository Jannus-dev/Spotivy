namespace Spotivy;

public class Client
{
    public List<Artist> artists = new List<Artist>();
    public List<User> users = new List<User>();
    public List<SongCollection> albums = new List<SongCollection>();
    public List<SongCollection> singels = new List<SongCollection>();
    public List<Playlist> playlists = new List<Playlist>();
    public List<Song> songs = new List<Song>();
    public User headUser;
    
    public void LoginUser(User user)
    {
        
    }
    
    public void LogoutUser()
    {
        
    }
    
    public void Printlist(List list)
    {
        
    }

    public int PrintChoice(String[] choices)
    {
        return 0;
    }

    public bool PrintWarning(String warning)
    {
        return false;
    }
    
    public void PrintToConsole(object text)
    {
        
    }
    
}

