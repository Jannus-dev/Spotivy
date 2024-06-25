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
       headUser = user;
       PrintToConsole(headUser.name + " has logged in");

    }
    
    public void LogoutUser()
    {
        
    }
    
    public void Printlist(List<String> list)
    {
        foreach (var item in list)
        {
            PrintToConsole(item);
        }
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
        Console.WriteLine(text.ToString());
    }
    
}

