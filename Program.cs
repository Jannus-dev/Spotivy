// See https://aka.ms/new-console-template for more information

namespace Spotivy;

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();
        Seeder seeder = new Seeder(client);
        seeder.Seed();
        LoginFunction(client);

        while (true)
        {
            ShowMenuOptions(client);
        }
    }

    private static void LoginFunction(Client client)
    {
        List<String> allUsers = new List<String>();

        foreach (var user in client.users)
        {
            allUsers.Add(user.name);
        }

        int choise = client.PrintChoice(allUsers.ToArray());

        client.LoginUser(client.users[choise]);
    }

    private static void ShowMenuOptions(Client client)
    {
        List<String> menuOptions = new List<String>
        {
            "Show all songs",
            "Show all artists",
            "Show all albums",
            "Show all singles",
            "Show all playlists",
            "Show all users",
            "Show all friends",
            "Show all friend requests",
        };

        int choise = client.PrintChoice(menuOptions.ToArray());

        switch (choise)
        {
            case 0:
                ShowAllSongs(client);
                break;
            case 1:
                ShowAllArtists(client);
                break;
            case 2:
                ShowAllAlbums(client);
                break;
            case 3:
                ShowAllSingles(client);
                break;
            case 4:
                ShowAllPlaylists(client);
                break;
            case 5:
                ShowAllUsers(client);
                break;
            case 6:
                ShowAllFriends(client);
                break;
            case 7:
                ShowAllFriendRequests(client);
                break;
        }
    }

    private static void ShowAllSongs(Client client)
    {
        List<String> songs = new List<String>();
        foreach (var song in client.songs)
        {
            songs.Add(song.name);
        }

        client.Printlist(songs);
    }

    private static void ShowAllArtists(Client client)
    {
        List<String> artists = new List<String>();
        foreach (var artist in client.artists)
        {
            artists.Add(artist.name);
        }

        client.Printlist(artists);
    }

    private static void ShowAllAlbums(Client client)
    {
        List<String> albums = new List<String>();
        foreach (var album in client.albums)
        {
            albums.Add(album.name);
        }

        client.Printlist(albums);
    }

    private static void ShowAllSingles(Client client)
    {
        List<String> singles = new List<String>();
        foreach (var single in client.singles)
        {
            singles.Add(single.name);
        }

        client.Printlist(singles);
    }

    private static void ShowAllPlaylists(Client client)
    {
        List<String> playlists = new List<String>();
        foreach (var playlist in client.playlists)
        {
            playlists.Add(playlist.name);
        }

        client.Printlist(playlists);
    }

    private static void ShowAllUsers(Client client)
    {
        List<String> users = new List<String>();
        foreach (var user in client.users)
        {
            users.Add(user.name);
        }

        client.Printlist(users);
    }

    private static void ShowAllFriends(Client client)
    {
        List<String> friends = client.headUser.GetFriendNames();
        client.Printlist(friends);
    }

    private static void ShowAllFriendRequests(Client client)
    {
        List<String> friendRequests = new List<String>();
        foreach (var friendRequest in client.headUser.friedRequests)
        {
            friendRequests.Add(friendRequest.name);
        }

        client.Printlist(friendRequests);
    }
}