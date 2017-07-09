using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            SongComponent industralMusic = new SongGroup("Industrial", "Description of Industrial Music.");
            SongComponent heavyMetalMusic = new SongGroup("Heavy Metal", "Description of Heavy Metal Music.");
            SongComponent dubstepMusic = new SongGroup("Dubstep", "Description of Dubstep Music.");

            SongComponent everySong = new SongGroup("Song List", "Every Song Available.");

            everySong.Add(industralMusic);
            industralMusic.Add(new Song("Head Like a Hole", "NIN", 1990));
            industralMusic.Add(new Song("HeadHunter", "Front 242", 1988));
            
            industralMusic.Add(dubstepMusic);
            dubstepMusic.Add(new Song("Tetris", "Doctor P", 2011));

            everySong.Add(heavyMetalMusic);
            heavyMetalMusic.Add(new Song("War Pigs", "Black Sabath", 1970));
            heavyMetalMusic.Add(new Song("Ace of Spades", "Motorhead", 1980));

            DiscJockey crazyLarry = new DiscJockey(everySong);
            crazyLarry.GetSongList();


            Console.ReadKey();
        }
    }
}
