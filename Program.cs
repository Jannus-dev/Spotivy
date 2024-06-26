// See https://aka.ms/new-console-template for more information

namespace Spotivy;

class Program
{
    static void Main(string[] args)
    {


        List<Song> songs = new List<Song>
        {
            new Song("Song1", ["Pop"]),
            new Song("Song2", ["Pop"]),
            new Song("Song3", ["Pop"]),
            new Song("Song4", ["Pop"]),
            new Song("Song5", ["Pop"]),
            new Song("Song6", ["Pop"]),
            new Song("Song7", ["Pop"]),
        };


        Playlist playlist = new Playlist("My Playlist", new User("John"), songs);

        Client client = new Client();

        client.PrintToConsole(playlist.Play());

        client.PrintToConsole(playlist.Skip());

        client.PrintToConsole(playlist.Pause());

        client.PrintToConsole(playlist.Play());

        client.PrintToConsole(playlist.Stop());

    }
}
