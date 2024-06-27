namespace Spotivy;

public class Client
{
    public List<Artist> artists { get; set; } = new List<Artist>();
    public List<User> users { get; set; } = new List<User>();
    public List<SongCollection> albums { get; set; } = new List<SongCollection>();
    public List<SongCollection> singles { get; set; } = new List<SongCollection>();
    public List<Playlist> playlists { get; set; } = new List<Playlist>();
    public List<Song> songs { get; set; } = new List<Song>();
    public User headUser { get; set; } = null!;

    public void LoginUser(User user)
    {
       headUser = user;
       PrintToConsole(headUser.name + " has logged in");

    }
    
    public void LogoutUser()
    {
        headUser = null!;
        PrintToConsole("User has logged out");
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
        for (int i = 0; i < choices.Length; i++)
        {
            PrintToConsole(i + ". " + choices[i]);
        }

        while (true)
        {
            try
            {
                int choice = int.Parse(Console.ReadLine() ?? string.Empty);
                if (choice >= 0 && choice < choices.Length)
                {
                    return choice;
                }
                else
                {
                    PrintToConsole("Invalid choice, try again");
                }
            }
            catch (Exception)
            {
                PrintToConsole("Invalid choice, try again");
                throw;
            }
        }
    }

    public bool PrintWarning(String warning)
    {
        PrintToConsole(warning);
        PrintToConsole("Do you want to continue? (y/n) [No default]");
        string? choice = Console.ReadLine();
        return choice == "y" || choice == "Y" || choice == "yes" || choice == "Yes";
    }
    
    public void PrintToConsole(object text)
    {
        Console.WriteLine(text.ToString());
    }
    
}

