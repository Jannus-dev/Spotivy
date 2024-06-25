namespace Spotivy;

public class Song(String name, List<String> genres)
{
    public String name = name;
    public List<String> genres  = genres;
    public List<Artist> artists = new List<Artist>() ;
    
    public String Play()
    {
        return "Playing " + name;
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
}