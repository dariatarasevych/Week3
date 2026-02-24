
namespace _24_02_practice;

public class Playlist
{
    private string _name;
    
    public string Name
    {
        get => _name;
        private set;
    }

    public Playlist(string name)
    {
        _name = name;
    }

    private List<Song> songs = new List<Song>();

    public void AddSong(Song song)
    {
        songs.Add(song);
    }

    public int GetSongCount()
    {
        return songs.Count;
    }

    public int GetTotalDuration()
    {
        int totalDuration = 0;
        foreach (var song in songs)
        {
            totalDuration += song.DurationSeconds;
        }

        return totalDuration;
    }

    public Song FindSongByArtist(string artist)
    {
        foreach (var song in songs)
        {
            if (song.Artist == artist)
            {
                return song;
            }
        }

        return null;
    }
}