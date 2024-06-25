namespace Spotivy;

public class Song(String name, List<String> genres)
{
    public String name = name;
    public List<String> genres  = genres;
    public List<Artist> artists = new List<Artist>() ;
    private bool isPlaying = false;
    
    public String Play()
    {
        isPlaying = true;
        return "Playing " + name;
    }
    
    public String Stop()
    {
        if (isPlaying)
        {
            isPlaying = false;
            return "Stopped " + name;
        }
        else
        {
            return "Song is not playing";
        }
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