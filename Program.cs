// See https://aka.ms/new-console-template for more information

namespace Spotivy;

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();
        client.LoginUser(new User("Jane"));

        Artist artist = new Artist("The Beatles");
        Console.WriteLine(artist.name);
6
        Song song = new Song("Hey Jude", new List<string>() { "pop", "rock", ":3" });
    }
}