namespace _24_02_practice;

class Program
{
    static void Main(string[] args)
    {
        var playlist = new Playlist("Road Trip");
        playlist.AddSong(new Song("Bohemian Rhapsody", "Queen", 354));
        playlist.AddSong(new Song("Hotel California", "Eagles", 391));
        
        Console.WriteLine(playlist.GetSongCount());
        Console.WriteLine(playlist.GetTotalDuration());

        var found = playlist.FindSongByArtist("Queen");
        Console.WriteLine(found.GetFormattedDuration());
    }
}