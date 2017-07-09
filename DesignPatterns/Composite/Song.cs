using System;

namespace Composite
{
    class Song : SongComponent
    {
        public string SongName { get; private set; }
        public string BandName { get; private set; }
        public int ReleaseYear { get; private set; }

        public Song(string songName, string bandName, int releaseYear)
        {
            SongName = songName;
            BandName = bandName;
            ReleaseYear = releaseYear;
        }

        public override void DisplaySongInfo()
        {
            Console.WriteLine($"{SongName} was recorder by {BandName} in {ReleaseYear}.");
        }
    }
}
