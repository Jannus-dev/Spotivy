namespace Spotivy;

public class Client
{
    public List<Artist> artists { get; set; } = new List<Artist>();
    public List<User> users { get; set; } = new List<User>();
    public List<SongCollection> albums { get; set; } = new List<SongCollection>();
    public List<SongCollection> singels { get; set; } = new List<SongCollection>();
    public List<Playlist> playlists { get; set; } = new List<Playlist>();
    public List<Song> songs { get; set; } = new List<Song>();
    public User headUser { get; set; }

    public void LoginUser(User user)
    {
       this.headUser = user;
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

