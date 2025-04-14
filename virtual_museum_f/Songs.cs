namespace virtual_museum_f
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string FilePath { get; set; }
        public string Lyrics { get; set; }
        public int BPM { get; set; }

        public Song(string title, string artist, string filePath, string lyrics, int bpm)
        {
            Title = title;
            Artist = artist;
            FilePath = filePath;
            Lyrics = lyrics;
            BPM = bpm;
        }
    }
}