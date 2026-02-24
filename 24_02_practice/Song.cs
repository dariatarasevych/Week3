namespace _24_02_practice;

public class Song
{
    private string _title;

    public string Title
    {
        get => _title;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Title cannot be empty.");
            }
        }
    }

    private string _artist;

    public string Artist
    {
        get => _artist;
    }

    private int _durationSeconds;

    public int DurationSeconds
    {
        get => _durationSeconds;
    }

    public Song(string title, string artist, int durationSeconds)
    {
        if (_durationSeconds < 0)
        {
            throw new Exception("Duration cannot be lees than 0.");
        }
        _title = title;
        _artist = artist;
        _durationSeconds = durationSeconds;
    }

    public string GetFormattedDuration()
    {
        int min = _durationSeconds / 60;
        int sec = _durationSeconds % 60;
        
        return $"{min}:{sec:D2}";
    }
    
}