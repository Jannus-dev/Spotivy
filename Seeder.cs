namespace Spotivy;

public class Seeder(Client client)
{
    private Client client = client;
    private Random random = new Random();

    public void Seed()
    {
        SeedUsers();
        SeedArtists();
        SeedSongs();
        SeedAlbums();
        SeedSingles();
        SeedPlaylists();
    }

    private void SeedArtists()
    {
        client.artists = new List<Artist>
        {
            new Artist("Adele"),
            new Artist("Ariana Grande"),
            new Artist("Beyonce"),
            new Artist("Billie Eilish"),
            new Artist("Bruno Mars"),
            new Artist("Cardi B"),
            new Artist("Drake"),
            new Artist("Ed Sheeran"),
            new Artist("Eminem"),
            new Artist("Harry Styles"),
            new Artist("Justin Bieber"),
            new Artist("Kanye West"),
            new Artist("Katy Perry"),
            new Artist("Lady Gaga"),
            new Artist("Lil Nas X"),
            new Artist("Lizzo"),
            new Artist("Megan Thee Stallion"),
            new Artist("Nicki Minaj"),
            new Artist("Post Malone"),
            new Artist("Rihanna"),
            new Artist("Selena Gomez"),
            new Artist("Shawn Mendes"),
            new Artist("Taylor Swift"),
            new Artist("The Weeknd"),
        };
    }

    private void SeedUsers()
    {
        client.users = new List<User>
        {
            new User("John"),
            new User("Jane"),
            new User("Jack"),
            new User("Jill"),
            new User("James"),
            new User("Jenny"),
            new User("Jared"),
            new User("Jasmine"),
            new User("Jasper"),
            new User("Jade"),
            new User("Jax"),
        };
    }

    private void SeedAlbums()
    {
        client.albums = new List<SongCollection>
        {
            new SongCollection("Pop Hits", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Pop")).ToList()),
            new SongCollection("Rock Anthems", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Rock")).ToList()),
            new SongCollection("Jazz Standards", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Jazz")).ToList()),
            new SongCollection("Classical Masterpieces", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Classical")).ToList()),
            new SongCollection("Hip Hop Hits", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Hip Hop")).ToList()),
            new SongCollection("Country Classics", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Country")).ToList()),
            new SongCollection("Electronic Dance", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Electronic")).ToList()),
            new SongCollection("Blues Standards", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Blues")).ToList()),
            new SongCollection("Reggae Vibes", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Reggae")).ToList()),
            new SongCollection("Latin Rhythms", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Latin")).ToList()),
            new SongCollection("Metal Mayhem", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Metal")).ToList()),
        };
    }

    private void SeedSingles()
    {
        client.singels = new List<SongCollection>
        {
            new SongCollection("Indie Hits", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Indie")).ToList()),
            new SongCollection("R&B Classics", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("R&B")).ToList()),
            new SongCollection("Soulful Tunes", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Soul")).ToList()),
            new SongCollection("Folk Tales", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Folk")).ToList()),
            new SongCollection("Punk Revolution", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Punk")).ToList()),
            new SongCollection("Funk Groove", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Funk")).ToList()),
            new SongCollection("Disco Fever", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Disco")).ToList()),
            new SongCollection("Opera Arias", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Opera")).ToList()),
            new SongCollection("Ambient Dreams", client.artists[random.Next(0, client.artists.Count - 1)],
                client.songs.Where(song => song.genres.Contains("Ambient")).ToList())
        };
    }

    private void SeedPlaylists()
    {
        client.playlists = new List<Playlist>
        {
            new Playlist("Indie Collection", client.headUser,
                client.songs.Where(song => song.genres.Contains("Indie")).ToList()),
            new Playlist("Chill Vibes", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Ambient")).ToList()),
            new Playlist("Pop Hits", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Pop")).ToList()),
            new Playlist("Rock Anthems", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Rock")).ToList()),
            new Playlist("Smooth Jazz", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Jazz")).ToList()),
            new Playlist("Classical Collection", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Classical")).ToList()),
            new Playlist("Hip Hop Beats", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Hip Hop")).ToList()),
            new Playlist("Country Roads", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Country")).ToList()),
            new Playlist("Electronic Waves", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Electronic")).ToList()),
            new Playlist("Blues Nights", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Blues")).ToList()),
            new Playlist("Reggae Vibes", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Reggae")).ToList()),
            new Playlist("Latin Rhythms", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Latin")).ToList()),
            new Playlist("Metal Madness", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Metal")).ToList()),
            new Playlist("R&B Classics", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("R&B")).ToList()),
            new Playlist("Dance Hits", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Dance")).ToList()),
            new Playlist("Soulful Tunes", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Soul")).ToList()),
            new Playlist("Folk Tales", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Folk")).ToList()),
            new Playlist("Punk Revolution", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Punk")).ToList()),
            new Playlist("Funky Grooves", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Funk")).ToList()),
            new Playlist("Disco Fever", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Disco")).ToList()),
            new Playlist("Opera Arias", client.users[random.Next(0, client.users.Count)],
                client.songs.Where(song => song.genres.Contains("Opera")).ToList())
        };
    }

    private void SeedSongs()
    {
        List<Song> songs = new List<Song>
        {
            new Song("BrightMorning", ["Pop"]),
            new Song("RockAnthem", ["Rock"]),
            new Song("SmoothJazz", ["Jazz"]),
            new Song("ClassicBeethoven", ["Classical"]),
            new Song("UrbanBeats", ["Hip Hop"]),
            new Song("CountryRoads", ["Country"]),
            new Song("ElectroWave", ["Electronic"]),
            new Song("BluesNight", ["Blues"]),
            new Song("IslandVibes", ["Reggae"]),
            new Song("LatinRhythms", ["Latin"]),
            new Song("MetalStorm", ["Metal"]),
            new Song("IndieHarmonies", ["Indie"]),
            new Song("R&BClassics", ["R&B"]),
            new Song("DanceHits", ["Dance"]),
            new Song("SoulfulTunes", ["Soul"]),
            new Song("FolkTales", ["Folk"]),
            new Song("PunkRevolution", ["Punk"]),
            new Song("FunkGroove", ["Funk"]),
            new Song("DiscoFever", ["Disco"]),
            new Song("OperaArias", ["Opera"]),
            new Song("AmbientDreams", ["Ambient"])
        };

        foreach (var song in songs)
        {
            client.artists[random.Next(0, client.artists.Count - 1)].AddSong(song);
        }

        client.songs = songs;
    }
}